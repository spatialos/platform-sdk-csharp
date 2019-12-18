using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
using Utils;

namespace ServiceAccountMaintenance
{
    /// <summary>
    /// This contains the implementation of the "Service account maintenance" scenario.
    /// 1. Iterate over the service accounts in your project.
    /// 2. If a service account has expired, or is close to expiry, prolong the expiry time to some point in the
    /// future.
    /// </summary>
    internal class ServiceAccountMaintenanceScenario : ScenarioBase
    {
        /// <summary>
        /// The threshold for when a service account's expiry time should be increased, in days relative to
        /// the current time. If the service account expires in fewer days than this, its lifetime will be extended
        /// by DaysToExpandServiceAccountBy days.
        /// </summary>
        private const int DaysRemainingAtWhichExpiryShouldBeIncreased = 1;

        /// <summary>
        /// How many days to expand the service account's lifetime by if it is too close to expiry (as defined by
        /// DaysRemainingAtWhichExpiryShouldBeIncreased), relative to the current time.
        /// </summary>
        private const int DaysToExpandServiceAccountBy = 4;

        private const int NumberOfServiceAccountsToCreate = 10;

        /// <summary>
        /// PLEASE REPLACE.
        /// The name given to service accounts created during setup.
        /// </summary>
        private const string ServiceAccountName = "sa_maintenance_scenario";

        private static List<long> ServiceAccountIds;

        /// <summary>
        /// This creates some service accounts with permissions to read and write to a project, which expire
        /// in one week.
        /// </summary>
        protected override void Setup()
        {
            ServiceAccountIds = new List<long>();
            var permProject = new Permission
            {
                Parts = { new RepeatedField<string> { "prj", ProjectName, "*" } },
                Verbs =
                {
                    new RepeatedField<Permission.Types.Verb>
                    {
                        Permission.Types.Verb.Read,
                        Permission.Types.Verb.Write
                    }
                }
            };

            var permServices = new Permission
            {
                Parts = { new RepeatedField<string> { "srv", "*" } },
                Verbs =
                {
                    new RepeatedField<Permission.Types.Verb>
                    {
                        Permission.Types.Verb.Read
                    }
                }
            };

            Console.WriteLine("Setting up for the scenario by creating new service accounts...");
            for (var i = 0; i < NumberOfServiceAccountsToCreate; i++)
            {
                var resp = _serviceAccountServiceClient.CreateServiceAccount(
                    new CreateServiceAccountRequest
                    {
                        Name = ServiceAccountName,
                        ProjectName = ProjectName,
                        Permissions = { new RepeatedField<Permission> { permProject, permServices } },
                        Lifetime = Duration.FromTimeSpan(new TimeSpan(1, 0, 0, 0)) // Let this service account live for one day
                    }
                );
                ServiceAccountIds.Add(resp.Id);
            }
        }

        protected override void Run()
        {
            Console.WriteLine("Getting the service accounts that you have permission to view...");

            var serviceAccounts = _serviceAccountServiceClient.ListServiceAccounts(ProjectName).Where(
                serviceAccount => (serviceAccount.ExpirationTime.ToDateTime() - DateTime.UtcNow).TotalDays <= DaysRemainingAtWhichExpiryShouldBeIncreased
            );

            foreach (var serviceAccount in serviceAccounts)
            {
                // Calculate how many days it is until the service account expires, and output a message
                // depending on whether it has already expired, or is close to expiry

                var daysUntilExpiry =
                    Math.Floor((serviceAccount.ExpirationTime.ToDateTime() - DateTime.UtcNow).TotalDays);

                Console.WriteLine(daysUntilExpiry < 0
                    ? $"Service account '{serviceAccount.Name}' expired {Math.Abs(daysUntilExpiry)} day(s) ago"
                    : $"Service account '{serviceAccount.Name}' will expire in {daysUntilExpiry} day(s)");

                // Now extend the lifetime by increasing the expiry time relative to the current time

                Console.WriteLine(
                    $"Extending service account '{serviceAccount.Name}' expiry time by {DaysToExpandServiceAccountBy} days from now");

                _serviceAccountServiceClient.UpdateServiceAccount(serviceAccount.Id, DateTime.UtcNow.AddDays(DaysToExpandServiceAccountBy).ToTimestamp());
            }

            Console.WriteLine("No more service accounts found");
        }

        /// <summary>
        /// This deletes the service accounts created in the setup phase.
        /// </summary>
        protected override void Cleanup()
        {
            Console.WriteLine("Cleaning up by deleting service accounts created during setup...");
            foreach (var id in ServiceAccountIds)
            {
                _serviceAccountServiceClient.DeleteServiceAccount(id);
            }
        }
    }

    internal class Program
    {
        private static readonly ScenarioBase Scenario = new ServiceAccountMaintenanceScenario();

        private static void Main(string[] args)
        {
            Scenario.Execute();
        }
    }
}