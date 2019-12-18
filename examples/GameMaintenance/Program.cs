using System;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.Snapshot.V1Alpha1;
using Utils;

namespace GameMaintenance
{
    /// <summary>
    /// This contains the implementation of the "Game maintenance" scenario.
    /// 1. Get the currently running cloud deployment that needs taking down for maintenance.
    /// 2. Lock down the deployment by removing the `live` tag and setting the worker flag.
    /// 3. Take a snapshot of the deployment.
    /// 4. Stop the deployment.
    /// 5. Start a new cloud deployment based on the old deployment, but with clean tags.
    /// 6. Mark the new cloud deployment live by adding the `live` tag.
    /// </summary>
    internal class GameMaintenanceScenario : ScenarioBase
    {
        protected override void Run()
        {
            Console.WriteLine("Finding the current running deployment");
            _deployment = _deploymentServiceClient.GetRunningDeploymentByName(_deployment.ProjectName, _deployment.Name).Deployment;

            Console.WriteLine("Putting the deployment to maintenance mode");
            _deployment.Tag.Remove("my_live_tag");
            _deploymentServiceClient.SetDeploymentTags(Convert.ToInt64(_deployment.Id), _deployment.Tag);

            Console.WriteLine("Taking a cloud snapshot");
            var snapshotting = _snapshotServiceClient.TakeSnapshot(
                new Snapshot
                {
                    ProjectName = _deployment.ProjectName,
                    DeploymentName = _deployment.Name
                }
            ).PollUntilCompleted();
            if (snapshotting.IsFaulted)
            {
                Console.Error.WriteLine($"Failed to take a snapshot: {snapshotting.RpcMessage.Error.ToString()}");
                Environment.Exit(1);
            }
            var latestSnapshot = snapshotting.Result;

            Console.WriteLine($"Stopping deployment '{_deployment.ProjectName}/{_deployment.Name}'");
            var deploymentDeletion = _deploymentServiceClient.DeleteDeployment(_deployment.Id).PollUntilCompleted();
            if (deploymentDeletion.IsFaulted)
            {
                Console.Error.WriteLine($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' could not be stopped: {deploymentDeletion.RpcMessage.Error.ToString()}");
                Environment.Exit(1);
            }
            Console.WriteLine($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' was successfully stopped.");

            Console.WriteLine($"Starting a new deployment '{_deployment.ProjectName}/{_deployment.Name}' with empty tags");
            var deploymentCreation = _deploymentServiceClient.CreateDeployment(
                new Deployment
                {
                    Name = _deployment.Name,
                    ProjectName = _deployment.ProjectName,
                    StartingSnapshotId = latestSnapshot.Id,
                    LaunchConfig = _deployment.LaunchConfig,
                    AssemblyId = _deployment.AssemblyId,
                }
            ).PollUntilCompleted();
            if (deploymentCreation.IsFaulted)
            {
                Console.Error.WriteLine($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' could not be started: {deploymentCreation.RpcMessage.Error.ToString()}");
                Environment.Exit(1);
            }

            _deployment = deploymentCreation.Result;
            Console.WriteLine($"Deployment '{_deployment.ProjectName}/{_deployment.Name}' was successfully started.");

            Console.WriteLine("Putting the new deployment to live");
            _deployment.Tag.Add("my_live_tag");
            _deploymentServiceClient.SetDeploymentTags(Convert.ToInt64(_deployment.Id), _deployment.Tag);
        }
    }

    internal class Program
    {
        private static readonly ScenarioBase Scenario = new GameMaintenanceScenario();

        private static void Main(string[] args)
        {
            Scenario.Execute();
        }
    }

}