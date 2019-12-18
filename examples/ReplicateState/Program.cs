using System;
using System.IO;
using System.Net;
using Google.LongRunning;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.Platform;
using Improbable.SpatialOS.Snapshot.V1Alpha1;
using Utils;

namespace ReplicateState
{
    /// <summary>
    /// This contains the implementation of the "Replicate local state to cloud" scenario.
    /// 1. Take a snapshot of a local deployment.
    /// 2. Download the local snapshot to a temporary address.
    /// 3. Upload the local snapshot to the cloud through in three steps:
    /// 3a. Allocate space for the snapshot.
    /// 3b. Upload the local snapshot to the allocated space.
    /// 3c. Confirm uploading has completed to mark the snapshot as available.
    /// 4. Start a new cloud deployment using the newly uploaded snapshot.
    ///
    /// In order for this script to start the local deployment correctly, please build the local project by running "spatial build" in the project directory.
    /// </summary>
    internal class ReplicateStateScenario : ScenarioBase
    {
        private Deployment _localDeployment;

        private DeploymentServiceClient _localDeploymentServiceClient;
        private OperationsClient _localOperationsClient;
        private SnapshotServiceClient _localSnapshotServiceClient;

        internal ReplicateStateScenario()
        {
            _localDeploymentServiceClient = DeploymentServiceClient.Create(Channel.Create(Service.DeploymentService, Silo.Local, RefreshToken));
            _localOperationsClient = OperationsClient.Create(Channel.Create(Service.OperationsService, Silo.Local, RefreshToken));
            _localSnapshotServiceClient = SnapshotServiceClient.Create(Channel.Create(Service.SnapshotService, Silo.Local, RefreshToken));
        }

        /// <summary>
        /// This assumes you already have the local API service ("spatiald") running at the specified port. For
        /// more information about how to start the local API service, visit the accompanying documentation on
        /// https://docs.improbable.io/reference/latest//platform-sdk/local-api.
        /// </summary>
        protected override void Setup()
        {
            Console.WriteLine($"Starting a local deployment {DeploymentName}");
            var launchConfig = File.ReadAllText(LaunchConfigFilePath);
            var deploymentCreation = _localDeploymentServiceClient.CreateDeployment(
                new Deployment
                {
                    ProjectName = ProjectName,
                    Name = DeploymentName,
                    LaunchConfig = new LaunchConfig
                    {
                        ConfigJson = launchConfig
                    }
                }
            ).PollUntilCompleted();
            if (deploymentCreation.IsFaulted)
            {
                throw new Exception($"Local deployment '{DeploymentName}' could not be started. " + deploymentCreation.RpcMessage.Error.ToString());
            }
            _localDeployment = deploymentCreation.Result;
            Console.WriteLine($"Local deployment '{_localDeployment.Name}' was successfully started.");

            if (_localDeployment.Status == Deployment.Types.Status.Error)
            {
                throw new Exception("Failed to create the local eployment; please make sure to build the project by running `spatial build` in the project directory");
            }
        }

        protected override void Run()
        {
            Console.WriteLine("Taking a local snapshot");
            var snapshotting = _localSnapshotServiceClient.TakeSnapshot(
                new Snapshot
                {
                    ProjectName = ProjectName,
                    DeploymentName = DeploymentName
                }
            ).PollUntilCompleted();
            if (snapshotting.IsFaulted)
            {
                throw new Exception($"Failed to take a snapshot. " + snapshotting.RpcMessage.Error.ToString());
            }
            var localSnapshot = snapshotting.Result;

            Console.WriteLine("Downloading the local snapshot");
            var snapshotFile = Path.GetTempPath() + Guid.NewGuid();
            using (var client = new WebClient())
            {
                client.DownloadFile(localSnapshot.DownloadUrl, snapshotFile);
            }

            Console.WriteLine("Uploading the local snapshot to cloud");
            Console.WriteLine("Acquiring a URL to upload");
            localSnapshot.ProjectName = ProjectName;
            localSnapshot.DeploymentName = DeploymentName;
            var uploadSnapshotResponse = _snapshotServiceClient.UploadSnapshot(localSnapshot);

            Console.WriteLine("Uploading to the acquired URL");
            var newSnapshot = uploadSnapshotResponse.Snapshot;
            var httpRequest = WebRequest.Create(uploadSnapshotResponse.UploadUrl) as HttpWebRequest;
            httpRequest.Method = "PUT";
            httpRequest.ContentLength = newSnapshot.Size;
            httpRequest.Headers.Set("Content-MD5", newSnapshot.Checksum);
            httpRequest.Headers.Set("x-amz-server-side-encryption", "AES256");
            using (var dataStream = httpRequest.GetRequestStream())
            {
                var bytesToSend = File.ReadAllBytes(snapshotFile);
                dataStream.Write(bytesToSend, 0, bytesToSend.Length);
            }

            httpRequest.GetResponse();

            Console.WriteLine("Confirming that uploading is finished");
            _snapshotServiceClient.ConfirmUpload(newSnapshot.ProjectName, newSnapshot.DeploymentName, newSnapshot.Id);

            Console.WriteLine($"Starting a new cloud deployment '{ProjectName}/{DeploymentName}' with the new snapshot");
            var deploymentCreation = _deploymentServiceClient.CreateDeployment(
                new Deployment
                {
                    ProjectName = ProjectName,
                    Name = DeploymentName,
                    AssemblyId = AssemblyName,
                    LaunchConfig = new LaunchConfig
                    {
                        ConfigJson = File.ReadAllText(LaunchConfigFilePath)
                    },
                    StartingSnapshotId = newSnapshot.Id
                }
            ).PollUntilCompleted();
            if (deploymentCreation.IsFaulted)
            {
                throw new Exception($"Cloud deployment '{ProjectName}/{DeploymentName}' could not be started. " + deploymentCreation.RpcMessage.ToString());
            }
            _deployment = deploymentCreation.Result;
            Console.WriteLine($"Cloud deployment '{_deployment.ProjectName}/{_deployment.Name}' was successfully started.");
        }

        protected override void Cleanup()
        {
            var error = "";
            if (_localDeployment != null)
            {
                Console.WriteLine($"Stopping local deployment '{_localDeployment.Name}'");
                var deploymentDeletion = _localDeploymentServiceClient.DeleteDeployment(_localDeployment.Id).PollUntilCompleted();
                if (deploymentDeletion.IsFaulted)
                {
                    error = $"Local deployment '{_localDeployment.Name}' could not be stopped." + deploymentDeletion.RpcMessage.Error.ToString();
                }
                else
                {
                    Console.WriteLine($"Local deployment '{_localDeployment.Name}' was successfully stopped.");
                }
            }

            base.Cleanup();

            if (error != "")
            {
                throw new Exception(error);
            }
        }
    }

    internal class Program
    {
        private static readonly ScenarioBase Scenario = new ReplicateStateScenario();

        private static void Main(string[] args)
        {
            Scenario.Execute();
        }
    }
}