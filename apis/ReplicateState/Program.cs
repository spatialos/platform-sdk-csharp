using System;
using System.IO;
using System.Net;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.Platform.Common;
using Improbable.SpatialOS.Snapshot.V1Alpha1;
using Utils;

namespace ReplicateState
{
    internal class Program
    {
        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     You SpatialOS project name.
        ///     It should be the same as the name specified in the local spaitalos.json file used to start spatiald.
        /// </summary>
        private const string ProjectName = "platform_sdk_examples";

        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     The name of the deployment.
        /// </summary>
        private static readonly string DeploymentName = $"snapshot_upload_{StringUtils.Random(6)}";

        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     The path to a valid launch configuration json file.
        /// </summary>
        private const string LaunchConfigFilePath = "../../blank_project/default_launch.json";

        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     The assembly you would want the cloud deployment to use.
        /// </summary>
        private const string AssemblyId = "blank_project";

        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     The port spatiald is running on.
        /// </summary>
        private const int SpatialDPort = 9876;

        private static Deployment _localDeployment;
        private static Deployment _cloudDeployment;

        private static readonly PlatformRefreshTokenCredential CredentialWithProvidedToken =
            new PlatformRefreshTokenCredential(RefreshToken);

        private static readonly PlatformApiEndpoint SpatialdEndpoint = new PlatformApiEndpoint
        (
            "localhost",
            SpatialDPort,
            true
        );

        private static readonly SnapshotServiceClient CloudSnapshotServiceClient =
            SnapshotServiceClient.Create(credentials: CredentialWithProvidedToken);

        private static readonly DeploymentServiceClient CloudDeploymentServiceClient =
            DeploymentServiceClient.Create(credentials: CredentialWithProvidedToken);

        private static readonly SnapshotServiceClient LocalSnapshotServiceClient =
            SnapshotServiceClient.Create(SpatialdEndpoint);

        private static readonly DeploymentServiceClient LocalDeploymentServiceClient =
            DeploymentServiceClient.Create(SpatialdEndpoint);

        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     The SpatialOS Platform refresh token of a service account or a user account.
        /// </summary>
        private static string RefreshToken =>
            Environment.GetEnvironmentVariable("IMPROBABLE_REFRESH_TOKEN") ?? "PLEASE_REPLACE_ME";

        /// <summary>
        ///     This contains the implementation of the "replicate local state to cloud" scenario.
        ///     1. Take a snapshot of a local deployment.
        ///     2. Download the local snapshot to a temporary address.
        ///     3. Upload the local snapshot to the cloud through in three steps:
        ///     3a. Allocate space for the snapshot.
        ///     3b. Upload the local snapshot to the allocated space.
        ///     3c. Confirm uploading has completed to mark the snapshot as available.
        ///     4. Start a new cloud deployment using the newly uploaded snapshot.
        ///
        ///     In order for this script to start the local deployment correctly, please build the local project by running "spatial build" in the project directory.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Setup();

            Console.WriteLine("Taking a local snapshot");
            var localSnapshot = LocalSnapshotServiceClient.TakeSnapshot(new TakeSnapshotRequest
                {
                    Snapshot = new Snapshot
                    {
                        ProjectName = ProjectName,
                        DeploymentName = DeploymentName
                    }
                })
                .PollUntilCompleted()
                .GetResultOrNull();

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
            var uploadSnapshotResponse =
                CloudSnapshotServiceClient.UploadSnapshot(new UploadSnapshotRequest {Snapshot = localSnapshot});

            Console.WriteLine("Uploading to the acquired URL");
            var newSnapshot = uploadSnapshotResponse.Snapshot;
            var httpRequest = WebRequest.Create(uploadSnapshotResponse.UploadUrl) as HttpWebRequest;
            httpRequest.Method = "PUT";
            httpRequest.ContentLength = newSnapshot.Size;
            httpRequest.Headers.Set("Content-MD5", newSnapshot.Checksum);
            using (var dataStream = httpRequest.GetRequestStream())
            {
                var bytesToSend = File.ReadAllBytes(snapshotFile);
                dataStream.Write(bytesToSend, 0, bytesToSend.Length);
            }

            httpRequest.GetResponse();

            Console.WriteLine("Confirming that uploading is finished");
            CloudSnapshotServiceClient.ConfirmUpload(new ConfirmUploadRequest
            {
                DeploymentName = newSnapshot.DeploymentName,
                Id = newSnapshot.Id,
                ProjectName = newSnapshot.ProjectName
            });

            Console.WriteLine("Starting a new cloud deployment with the new snapshot");
            _cloudDeployment = new Deployment
            {
                ProjectName = ProjectName,
                Name = DeploymentName,
                LaunchConfig = new LaunchConfig
                {
                    ConfigJson = File.ReadAllText(LaunchConfigFilePath)
                },
                AssemblyId = AssemblyId,
                StartingSnapshotId = newSnapshot.Id
            };
            _cloudDeployment = CloudDeploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
            {
                Deployment = _cloudDeployment
            }).PollUntilCompleted().GetResultOrNull();

            Cleanup();
        }

        /// <summary>
        ///     This assumes you already have a running spatiald process at the specified port.
        ///     For more information about how to start a spatiald process, please visit the accompanying documentation on
        ///     https://docs.improbable.io/reference/latest//platform-sdk/local-api.
        ///     This starts a local deployment using the blank SpatialOS project included in this repository.
        /// </summary>
        private static void Setup()
        {
            Console.WriteLine("Setting up for the scenario");
            Console.WriteLine($"Assuming spatiald is running at localhost:{SpatialDPort}");
            Console.WriteLine("Starting a local deployment");
            var launchConfig = File.ReadAllText(LaunchConfigFilePath);
            _localDeployment = LocalDeploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
            {
                Deployment = new Deployment
                {
                    ProjectName = ProjectName,
                    Name = DeploymentName,
                    LaunchConfig = new LaunchConfig
                    {
                        ConfigJson = launchConfig
                    }
                }
            }).PollUntilCompleted().GetResultOrNull();
            
            if (_localDeployment.Status == Deployment.Types.Status.Error)
            {
                throw new Exception(
                    "Failed to create the local eployment; please make sure to build the project by running `spatial build` in the project directory");
            }
        }

        /// <summary>
        ///     This stops the local and cloud deployments as a cleanup.
        /// </summary>
        private static void Cleanup()
        {
            Console.WriteLine("Cleaning up");
            LocalDeploymentServiceClient.StopDeployment(new StopDeploymentRequest
            {
                Id = _localDeployment.Id,
                ProjectName = _localDeployment.ProjectName
            });

            CloudDeploymentServiceClient.StopDeployment(new StopDeploymentRequest
            {
                Id = _cloudDeployment.Id,
                ProjectName = _cloudDeployment.ProjectName
            });
        }
    }
}