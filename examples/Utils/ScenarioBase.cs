using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.Platform;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
using Improbable.SpatialOS.Snapshot.V1Alpha1;

namespace Utils
{
    public abstract class ScenarioBase
    {
        /// <summary>
        /// PLEASE REPLACE.
        /// Your SpatialOS project name.
        /// It should be the same as the name specified in the local project definition file (spatialos.json) used to start the local API service.
        /// </summary>
        public const string ProjectName = "spindle";

        /// <summary>
        /// PLEASE REPLACE.
        /// The name of the deployment.
        /// </summary>
        public string DeploymentName { get; }

        /// <summary>
        /// PLEASE REPLACE.
        /// The assembly you want the cloud deployment to use.
        /// </summary>
        public const string AssemblyName = "blank_project";

        /// <summary>
        /// PLEASE REPLACE.
        /// The path to a valid launch configuration JSON file.
        /// </summary>
        public const string LaunchConfigFilePath = "../blank_project/default_launch.json";

        /// <summary>
        /// PLEASE REPLACE.
        /// The path to a valid snapshot for the target assembly.
        /// </summary>
        public const string SnapshotFilePath = "../blank_project/snapshots/default.snapshot";

        /// <summary>
        /// PLEASE REPLACE.
        /// The SpatialOS refresh token of a service account or a user account.
        /// </summary>
        public string RefreshToken { get; }

        public DeploymentServiceClient _deploymentServiceClient { get; }
        public PlayerAuthServiceClient _playerAuthServiceClient { get; }
        public ServiceAccountServiceClient _serviceAccountServiceClient { get; }
        public SnapshotServiceClient _snapshotServiceClient { get; }

        public Deployment _deployment { get; set; }

        protected const int DeploymentCreationPollIntervalMillis = 10000;
        protected const int DeploymentCreationTimeoutSeconds = 600;
        protected const int DeploymentDeletionPollInterviewMillis = 5000;
        protected const int DeploymentDeletionTimeoutSeconds = 120;
        protected const int SnapshotPollIntervalMillis = 2000;
        protected const int SnapshotTimeoutSeconds = 20;

        protected abstract void Run();

        protected ScenarioBase()
        {
            DeploymentName = $"game_maintenance_{StringUtils.Random(6)}";
            RefreshToken = Environment.GetEnvironmentVariable("IMPROBABLE_REFRESH_TOKEN") ?? "PLEASE_REPLACE_ME";

            _deploymentServiceClient = DeploymentServiceClient.Create(Channel.Create(Service.DeploymentService, Silo.China, RefreshToken));
            _playerAuthServiceClient = PlayerAuthServiceClient.Create(Channel.Create(Service.PlayerAuthService, Silo.China, RefreshToken));
            _serviceAccountServiceClient = ServiceAccountServiceClient.Create(Channel.Create(Service.ServiceAccountService, Silo.China, RefreshToken));
            _snapshotServiceClient = SnapshotServiceClient.Create(Channel.Create(Service.SnapshotService, Silo.China, RefreshToken));
        }

        public void Execute()
        {
            var exitCode = 0;
            try
            {
                Setup();
                Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                exitCode = 1;
            }
            finally
            {
                Cleanup();
            }
            Environment.Exit(exitCode);
        }

        protected virtual void Setup()
        {
            Console.WriteLine("Preparing a starting snapshot");
            var snapshotToUpload = new Snapshot
            {
                ProjectName = ProjectName,
                DeploymentName = DeploymentName
            };
            using (var md5 = MD5.Create())
            {
                var bytes = File.ReadAllBytes(SnapshotFilePath);
                snapshotToUpload.Checksum = Convert.ToBase64String(md5.ComputeHash(bytes));
                snapshotToUpload.Size = bytes.Length;
            }

            var uploadSnapshotResponse = _snapshotServiceClient.UploadSnapshot(snapshotToUpload);
            snapshotToUpload = uploadSnapshotResponse.Snapshot;

            Console.WriteLine($"Uploading snapshot '{snapshotToUpload.Id}' to '{ProjectName}/{DeploymentName}'");
            var httpRequest = WebRequest.Create(uploadSnapshotResponse.UploadUrl) as HttpWebRequest;
            httpRequest.Method = "PUT";
            httpRequest.ContentLength = snapshotToUpload.Size;
            httpRequest.Headers.Set("Content-MD5", snapshotToUpload.Checksum);
            httpRequest.Headers.Set("x-amz-server-side-encryption", "AES256");
            using (var dataStream = httpRequest.GetRequestStream())
            {
                var bytesToSend = File.ReadAllBytes(SnapshotFilePath);
                dataStream.Write(bytesToSend, 0, bytesToSend.Length);
            }

            httpRequest.GetResponse();
            _snapshotServiceClient.ConfirmUpload(snapshotToUpload.ProjectName, snapshotToUpload.DeploymentName, snapshotToUpload.Id);

            Console.WriteLine($"Starting deployment '{ProjectName}/{DeploymentName}'");
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
                    StartingSnapshotId = snapshotToUpload.Id,
                    Tag = { "my_live_tag" },
                }
            ).PollUntilCompleted();
            if (deploymentCreation.IsFaulted)
            {
                throw new Exception($"Deployment '{ProjectName}/{DeploymentName}' could not be started: {deploymentCreation.RpcMessage.Error.ToString()}");
            }
            _deployment = deploymentCreation.Result;
            Console.WriteLine($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' was successfully started.");
        }

        protected virtual void Cleanup()
        {
            if (_deployment == null || (_deployment.Status != Deployment.Types.Status.Running && _deployment.Status != Deployment.Types.Status.Starting))
            {
                return;
            }

            Console.WriteLine("Stopping deployment");
            var deploymentDeletion = _deploymentServiceClient.DeleteDeployment(_deployment.Id).PollUntilCompleted();
            if (deploymentDeletion.IsFaulted)
            {
                throw new Exception($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' could not be stopped: {deploymentDeletion.RpcMessage.Error.ToString()}");
            }
            Console.WriteLine($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' was successfully stopped.");
        }
    }
}