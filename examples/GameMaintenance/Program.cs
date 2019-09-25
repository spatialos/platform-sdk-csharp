using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using Improbable.SpatialOS.Deployment.V1Beta1;
using Improbable.SpatialOS.Platform.Common;
using Improbable.SpatialOS.Snapshot.V1Alpha1;
using Utils;

namespace GameMaintenance
{
    internal class Program
    {
        /// <summary>
        ///     PLEASE REPLACE.
        ///     Your SpatialOS project name.
        ///     It should be the same as the name specified in the local project definition file (spatialos.json) used to start the local API service.
        /// </summary>
        private const string ProjectName = "platform_sdk_examples";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The name of the deployment.
        /// </summary>
        private static readonly string DeploymentName = $"game_maintenance_{StringUtils.Random(6)}";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The assembly you want the cloud deployment to use.
        /// </summary>
        private const string AssemblyId = "blank_project";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The path to a valid snapshot for the target assembly.
        /// </summary>
        private const string SnapshotFilePath =  "../blank_project/snapshots/default.snapshot" ;

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The path to a valid launch configuration JSON file.
        /// </summary>
        private const string LaunchConfigFilePath = "../blank_project/default_launch.json";

        private static readonly PlatformRefreshTokenCredential CredentialWithProvidedToken =
            new PlatformRefreshTokenCredential(RefreshToken);

        private static readonly DeploymentServiceClient DeploymentServiceClient =
            DeploymentServiceClient.Create(credentials: CredentialWithProvidedToken);

        private static readonly SnapshotServiceClient SnapshotServiceClient =
            SnapshotServiceClient.Create(credentials: CredentialWithProvidedToken);

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The SpatialOS Platform refresh token of a service account or a user account.
        /// </summary>
        private static string RefreshToken =>
            Environment.GetEnvironmentVariable("IMPROBABLE_REFRESH_TOKEN") ?? "PLEASE_REPLACE_ME";

        /// <summary>
        ///     This contains the implementation of the "Game maintenance" scenario.
        ///     1. Get the currently running cloud deployment that needs taking down for maintenance.
        ///     2. Lock down the deployment by removing the `live` tag and setting the worker flag.
        ///     3. Take a snapshot of the deployment.
        ///     4. Stop the deployment.
        ///     5. Start a new cloud deployment based on the old deployment, but with clean tags.
        ///     6. Mark the new cloud deployment live by adding the `live` tag.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Setup();

            Console.WriteLine("Finding the current running deployment");
            var currentLiveDeployment = DeploymentServiceClient.GetRunningDeploymentByName(new GetRunningDeploymentByNameRequest
            {
                ProjectName = ProjectName,
                DeploymentName = DeploymentName,
            });

            Console.WriteLine("Putting the deployment to maintenance mode");
            currentLiveDeployment.Deployment.Tags.Remove("my_live_tag");
            var setTagsRequest = new SetDeploymentTagsRequest
            {
                DeploymentId = currentLiveDeployment.Deployment.Id,
                Tags = {currentLiveDeployment.Deployment.Tags},
            };
            DeploymentServiceClient.SetDeploymentTags(setTagsRequest);


            Console.WriteLine("Taking a cloud snapshot");
            var latestSnapshot = SnapshotServiceClient.TakeSnapshot(new TakeSnapshotRequest
                {
                    Snapshot = new Snapshot
                    {
                        ProjectName = currentLiveDeployment.Deployment.ProjectName,
                        DeploymentName = currentLiveDeployment.Deployment.DeploymentName
                    }
                }).PollUntilCompleted()
                .GetResultOrNull();

            Console.WriteLine("Stopping the deployment");
            DeploymentServiceClient.DeleteDeployment(new DeleteDeploymentRequest
            {
                Id = currentLiveDeployment.Deployment.Id,
            }).PollUntilCompleted();

            Console.WriteLine("Starting a new deployment with empty tags");
            var newDeployment = DeploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
                {
                    DeploymentName = currentLiveDeployment.Deployment.DeploymentName,
                    ProjectName = currentLiveDeployment.Deployment.ProjectName,
                    StartingSnapshotId = latestSnapshot.Id,
                })
                .PollUntilCompleted()
                .GetResultOrNull();

            Console.WriteLine("Putting the new deployment to live");
            var setLiveTagsRequest = new SetDeploymentTagsRequest
            {
                DeploymentId = newDeployment.Id,
            };
            setTagsRequest.Tags.Add("my_live_tag");
            DeploymentServiceClient.SetDeploymentTags(setLiveTagsRequest);

            Cleanup(newDeployment);
        }

        /// <summary>
        ///     This uploads a local snapshot and creates a cloud deployment with `my_live_tag` tag. This is to simulate the
        ///     scenario where you have a running game deployment that you want taken down for maintenance.
        /// </summary>
        private static void Setup()
        {
            Console.WriteLine("Setting up for the scenario");
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

            var uploadSnapshotResponse =
                SnapshotServiceClient.UploadSnapshot(new UploadSnapshotRequest {Snapshot = snapshotToUpload});
            snapshotToUpload = uploadSnapshotResponse.Snapshot;

            var httpRequest = WebRequest.Create(uploadSnapshotResponse.UploadUrl) as HttpWebRequest;
            httpRequest.Method = "PUT";
            httpRequest.ContentLength = snapshotToUpload.Size;
            httpRequest.Headers.Set("Content-MD5", snapshotToUpload.Checksum);
            using (var dataStream = httpRequest.GetRequestStream())
            {
                var bytesToSend = File.ReadAllBytes(SnapshotFilePath);
                dataStream.Write(bytesToSend, 0, bytesToSend.Length);
            }

            httpRequest.GetResponse();
            SnapshotServiceClient.ConfirmUpload(new ConfirmUploadRequest
            {
                DeploymentName = snapshotToUpload.DeploymentName,
                Id = snapshotToUpload.Id,
                ProjectName = snapshotToUpload.ProjectName
            });

            Console.WriteLine("Preparing a live deployment");
            DeploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
                {
                    ProjectName = ProjectName,
                    DeploymentName = DeploymentName,
                    LaunchConfig = new LaunchConfig
                    {
                        ConfigJson = File.ReadAllText(LaunchConfigFilePath)
                    },
                    Tags = {"my_live_tag"},
                    AssemblyName = AssemblyId
                })
                .PollUntilCompleted();
        }

        /// <summary>
        ///     This stops the newly created cloud deployment as a cleanup.
        /// </summary>
        /// <param name="deployment"></param>
        private static void Cleanup(Deployment deployment)
        {
            Console.WriteLine("Cleaning up");
            DeploymentServiceClient.DeleteDeployment(new DeleteDeploymentRequest
            {
                Id = deployment.Id,
            }).PollUntilCompleted();
        }
    }
}