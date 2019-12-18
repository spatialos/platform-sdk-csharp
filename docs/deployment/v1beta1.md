<a name='assembly'></a>
# Improbable.SpatialOS.Platform.Deployment.V1Beta1

## Contents

- [CreateDeploymentMetadata](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentMetadata 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentMetadata')
  - [DeploymentIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentMetadata-DeploymentIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentMetadata.DeploymentIdFieldNumber')
- [CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest')
  - [AssemblyNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-AssemblyNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.AssemblyNameFieldNumber')
  - [ClusterCodeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ClusterCodeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.ClusterCodeFieldNumber')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-DeploymentNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.DeploymentNameFieldNumber')
  - [LaunchConfigFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-LaunchConfigFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.LaunchConfigFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.ProjectNameFieldNumber')
  - [RegionCodeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RegionCodeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.RegionCodeFieldNumber')
  - [RuntimeVersionFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RuntimeVersionFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.RuntimeVersionFieldNumber')
  - [StartingSnapshotIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-StartingSnapshotIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.StartingSnapshotIdFieldNumber')
  - [TagsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-TagsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.TagsFieldNumber')
  - [AssemblyName](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-AssemblyName 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.AssemblyName')
  - [ClusterCode](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ClusterCode 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.ClusterCode')
  - [DeploymentName](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-DeploymentName 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.DeploymentName')
  - [LaunchConfig](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-LaunchConfig 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.LaunchConfig')
  - [ProjectName](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ProjectName 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.ProjectName')
  - [RegionCode](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RegionCode 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.RegionCode')
  - [RuntimeVersion](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RuntimeVersion 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.RuntimeVersion')
  - [StartingSnapshotId](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-StartingSnapshotId 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.StartingSnapshotId')
  - [Tags](#P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-Tags 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest.Tags')
- [CreateTimePropertyFilter](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter 'Improbable.SpatialOS.Deployment.V1Beta1.CreateTimePropertyFilter')
  - [CreateTimeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter-CreateTimeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateTimePropertyFilter.CreateTimeFieldNumber')
  - [OperatorFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter-OperatorFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.CreateTimePropertyFilter.OperatorFieldNumber')
- [DeleteDeploymentMetadata](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentMetadata 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentMetadata')
- [DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest-IdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest.IdFieldNumber')
- [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment')
  - [AssemblyNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-AssemblyNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.AssemblyNameFieldNumber')
  - [ClusterCodeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ClusterCodeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.ClusterCodeFieldNumber')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-DeploymentNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.DeploymentNameFieldNumber')
  - [DescriptionFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-DescriptionFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.DescriptionFieldNumber')
  - [ExpiryTimeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ExpiryTimeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.ExpiryTimeFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-IdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.IdFieldNumber')
  - [LaunchConfigFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-LaunchConfigFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.LaunchConfigFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ProjectNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.ProjectNameFieldNumber')
  - [RegionCodeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RegionCodeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.RegionCodeFieldNumber')
  - [RuntimeVersionFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RuntimeVersionFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.RuntimeVersionFieldNumber')
  - [StartTimeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartTimeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StartTimeFieldNumber')
  - [StartingSnapshotIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartingSnapshotIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StartingSnapshotIdFieldNumber')
  - [StatusFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StatusFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StatusFieldNumber')
  - [StopTimeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StopTimeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StopTimeFieldNumber')
  - [TagsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-TagsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.TagsFieldNumber')
  - [WorkerConnectionCapacitiesFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionCapacitiesFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.WorkerConnectionCapacitiesFieldNumber')
  - [WorkerConnectionRateLimitsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionRateLimitsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.WorkerConnectionRateLimitsFieldNumber')
  - [WorkerFlagsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerFlagsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.WorkerFlagsFieldNumber')
  - [AssemblyName](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-AssemblyName 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.AssemblyName')
  - [ClusterCode](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ClusterCode 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.ClusterCode')
  - [DeploymentName](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-DeploymentName 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.DeploymentName')
  - [Description](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Description 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.Description')
  - [ExpiryTime](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ExpiryTime 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.ExpiryTime')
  - [Id](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Id 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.Id')
  - [LaunchConfig](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-LaunchConfig 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.LaunchConfig')
  - [ProjectName](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ProjectName 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.ProjectName')
  - [RegionCode](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RegionCode 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.RegionCode')
  - [RuntimeVersion](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RuntimeVersion 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.RuntimeVersion')
  - [StartTime](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartTime 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StartTime')
  - [StartingSnapshotId](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartingSnapshotId 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StartingSnapshotId')
  - [Status](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Status 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.Status')
  - [StopTime](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StopTime 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.StopTime')
  - [Tags](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Tags 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.Tags')
  - [WorkerConnectionCapacities](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionCapacities 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.WorkerConnectionCapacities')
  - [WorkerConnectionRateLimits](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionRateLimits 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.WorkerConnectionRateLimits')
  - [WorkerFlags](#P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerFlags 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.WorkerFlags')
- [DeploymentNamePropertyFilter](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentNamePropertyFilter')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter-DeploymentNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentNamePropertyFilter.DeploymentNameFieldNumber')
  - [OperatorFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter-OperatorFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentNamePropertyFilter.OperatorFieldNumber')
- [DeploymentReflection](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentReflection 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentReflection')
  - [Descriptor](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentReflection-Descriptor 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentReflection.Descriptor')
- [DeploymentService](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService')
  - [Descriptor](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-Descriptor 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.Descriptor')
  - [BindService(serviceImpl)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-BindService-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.BindService(Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase)')
  - [BindService(serviceBinder,serviceImpl)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.BindService(Grpc.Core.ServiceBinderBase,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase)')
- [DeploymentServiceBase](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase')
  - [CreateDeployment(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.CreateDeployment(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Grpc.Core.ServerCallContext)')
  - [DeleteDeployment(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.DeleteDeployment(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Grpc.Core.ServerCallContext)')
  - [GetDeployment(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.GetDeployment(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Grpc.Core.ServerCallContext)')
  - [GetRunningDeploymentByName(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.GetRunningDeploymentByName(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Grpc.Core.ServerCallContext)')
  - [ListDeployments(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.ListDeployments(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Grpc.Core.ServerCallContext)')
  - [RestartDeployment(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.RestartDeployment(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Grpc.Core.ServerCallContext)')
  - [SetDeploymentTags(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.SetDeploymentTags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Grpc.Core.ServerCallContext)')
  - [SetDeploymentWorkerCapacities(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.SetDeploymentWorkerCapacities(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Grpc.Core.ServerCallContext)')
  - [SetDeploymentWorkerFlags(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.SetDeploymentWorkerFlags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Grpc.Core.ServerCallContext)')
  - [SetDeploymentWorkerRateLimits(request,context)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase.SetDeploymentWorkerRateLimits(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Grpc.Core.ServerCallContext)')
- [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient')
- [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient')
  - [#ctor(channel)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor-Grpc-Core-Channel- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.#ctor(Grpc.Core.Channel)')
  - [#ctor(callInvoker)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor-Grpc-Core-CallInvoker- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.#ctor(Grpc.Core.CallInvoker)')
  - [#ctor()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.#ctor')
  - [#ctor(configuration)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.#ctor(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [CreateDeploymentOperationsClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateDeploymentOperationsClient')
  - [DefaultEndpoint](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DefaultEndpoint 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DefaultEndpoint')
  - [DefaultScopes](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DefaultScopes 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DefaultScopes')
  - [DeleteDeploymentOperationsClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DeleteDeploymentOperationsClient')
  - [GrpcClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GrpcClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GrpcClient')
  - [RestartDeploymentOperationsClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.RestartDeploymentOperationsClient')
  - [CreateDeployment(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.CreateDeployment(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateDeployment(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.CreateDeployment(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Grpc.Core.CallOptions)')
  - [CreateDeploymentAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.CreateDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateDeploymentAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.CreateDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Grpc.Core.CallOptions)')
  - [CreateOperationsClient()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.CreateOperationsClient')
  - [DeleteDeployment(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.DeleteDeployment(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DeleteDeployment(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.DeleteDeployment(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Grpc.Core.CallOptions)')
  - [DeleteDeploymentAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.DeleteDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DeleteDeploymentAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.DeleteDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Grpc.Core.CallOptions)')
  - [GetDeployment(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetDeployment(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetDeployment(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetDeployment(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Grpc.Core.CallOptions)')
  - [GetDeploymentAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetDeploymentAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Grpc.Core.CallOptions)')
  - [GetRunningDeploymentByName(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetRunningDeploymentByName(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetRunningDeploymentByName(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetRunningDeploymentByName(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Grpc.Core.CallOptions)')
  - [GetRunningDeploymentByNameAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetRunningDeploymentByNameAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetRunningDeploymentByNameAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.GetRunningDeploymentByNameAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Grpc.Core.CallOptions)')
  - [ListDeployments(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.ListDeployments(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ListDeployments(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.ListDeployments(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Grpc.Core.CallOptions)')
  - [ListDeploymentsAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.ListDeploymentsAsync(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ListDeploymentsAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.ListDeploymentsAsync(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Grpc.Core.CallOptions)')
  - [NewInstance()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.NewInstance(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [RestartDeployment(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.RestartDeployment(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [RestartDeployment(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.RestartDeployment(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Grpc.Core.CallOptions)')
  - [RestartDeploymentAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.RestartDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [RestartDeploymentAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.RestartDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentTags(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentTags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentTags(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentTags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentTagsAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentTagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentTagsAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentTagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentWorkerCapacities(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerCapacities(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerCapacities(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerCapacities(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentWorkerCapacitiesAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerCapacitiesAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentWorkerFlags(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerFlags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerFlags(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerFlags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentWorkerFlagsAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerFlagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerFlagsAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerFlagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentWorkerRateLimits(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerRateLimits(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerRateLimits(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerRateLimits(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Grpc.Core.CallOptions)')
  - [SetDeploymentWorkerRateLimitsAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerRateLimitsAsync(request,options)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Grpc.Core.CallOptions)')
  - [Create(endpoint,settings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
  - [Create(channel,settings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.Create(Grpc.Core.Channel,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
  - [Create(callInvoker,settings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.Create(Grpc.Core.CallInvoker,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
  - [CreateAsync(endpoint,settings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
  - [CreateDeployment(projectName,deploymentName,assemblyName,startingSnapshotId,launchConfig,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeployment-System-String,System-String,System-String,System-String,Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateDeployment(System.String,System.String,System.String,System.String,Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateDeployment(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDeploymentAsync(projectName,deploymentName,assemblyName,startingSnapshotId,launchConfig,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentAsync-System-String,System-String,System-String,System-String,Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateDeploymentAsync(System.String,System.String,System.String,System.String,Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDeploymentAsync(projectName,deploymentName,assemblyName,startingSnapshotId,launchConfig,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentAsync-System-String,System-String,System-String,System-String,Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateDeploymentAsync(System.String,System.String,System.String,System.String,Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig,System.Threading.CancellationToken)')
  - [CreateDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteDeployment(id,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeployment-System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DeleteDeployment(System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DeleteDeployment(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteDeploymentAsync(id,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentAsync-System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DeleteDeploymentAsync(System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteDeploymentAsync(id,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentAsync-System-Int64,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DeleteDeploymentAsync(System.Int64,System.Threading.CancellationToken)')
  - [DeleteDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.DeleteDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeployment(id,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeployment-System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetDeployment(System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetDeployment(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeploymentAsync(id,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetDeploymentAsync(System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeploymentAsync(id,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-System-Int64,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetDeploymentAsync(System.Int64,System.Threading.CancellationToken)')
  - [GetDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeploymentAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,System.Threading.CancellationToken)')
  - [GetRunningDeploymentByName(projectName,deploymentName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByName-System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetRunningDeploymentByName(System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [GetRunningDeploymentByName(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetRunningDeploymentByName(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetRunningDeploymentByNameAsync(projectName,deploymentName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetRunningDeploymentByNameAsync(System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [GetRunningDeploymentByNameAsync(projectName,deploymentName,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-System-String,System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetRunningDeploymentByNameAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [GetRunningDeploymentByNameAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetRunningDeploymentByNameAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetRunningDeploymentByNameAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.GetRunningDeploymentByNameAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,System.Threading.CancellationToken)')
  - [ListDeployments(projectName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeployments-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.ListDeployments(System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListDeployments(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.ListDeployments(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListDeploymentsAsync(projectName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeploymentsAsync-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.ListDeploymentsAsync(System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListDeploymentsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.ListDeploymentsAsync(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceCreateDeployment(operationName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceCreateDeployment-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.PollOnceCreateDeployment(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceCreateDeploymentAsync(operationName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceCreateDeploymentAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.PollOnceCreateDeploymentAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceDeleteDeployment(operationName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceDeleteDeployment-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.PollOnceDeleteDeployment(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceDeleteDeploymentAsync(operationName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceDeleteDeploymentAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.PollOnceDeleteDeploymentAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceRestartDeployment(operationName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceRestartDeployment-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.PollOnceRestartDeployment(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceRestartDeploymentAsync(operationName,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceRestartDeploymentAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.PollOnceRestartDeploymentAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [RestartDeployment(id,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeployment-System-Nullable{System-Int64},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.RestartDeployment(System.Nullable{System.Int64},Google.Api.Gax.Grpc.CallSettings)')
  - [RestartDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.RestartDeployment(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [RestartDeploymentAsync(id,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentAsync-System-Nullable{System-Int64},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.RestartDeploymentAsync(System.Nullable{System.Int64},Google.Api.Gax.Grpc.CallSettings)')
  - [RestartDeploymentAsync(id,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentAsync-System-Nullable{System-Int64},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.RestartDeploymentAsync(System.Nullable{System.Int64},System.Threading.CancellationToken)')
  - [RestartDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.RestartDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTags(deploymentId,tags,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTags-System-Int64,System-Collections-Generic-IEnumerable{System-String},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentTags(System.Int64,System.Collections.Generic.IEnumerable{System.String},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTags(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentTags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTagsAsync(deploymentId,tags,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-System-Int64,System-Collections-Generic-IEnumerable{System-String},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentTagsAsync(System.Int64,System.Collections.Generic.IEnumerable{System.String},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTagsAsync(deploymentId,tags,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-System-Int64,System-Collections-Generic-IEnumerable{System-String},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentTagsAsync(System.Int64,System.Collections.Generic.IEnumerable{System.String},System.Threading.CancellationToken)')
  - [SetDeploymentTagsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentTagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTagsAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentTagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,System.Threading.CancellationToken)')
  - [SetDeploymentWorkerCapacities(deploymentId,workerConnectionCapacities,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacities-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerCapacities(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerCapacities(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerCapacities(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerCapacitiesAsync(deploymentId,workerConnectionCapacities,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerCapacitiesAsync(deploymentId,workerConnectionCapacities,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerCapacitiesAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerCapacitiesAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,System.Threading.CancellationToken)')
  - [SetDeploymentWorkerFlags(deploymentId,workerFlags,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlags-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerFlags(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerFlags(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerFlags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerFlagsAsync(deploymentId,workerFlags,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerFlagsAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerFlagsAsync(deploymentId,workerFlags,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerFlagsAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerFlagsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerFlagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerFlagsAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerFlagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,System.Threading.CancellationToken)')
  - [SetDeploymentWorkerRateLimits(deploymentId,workerConnectionRateLimits,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimits-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerRateLimits(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerRateLimits(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerRateLimits(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerRateLimitsAsync(deploymentId,workerConnectionRateLimits,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit},Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerRateLimitsAsync(deploymentId,workerConnectionRateLimits,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit},System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit},System.Threading.CancellationToken)')
  - [SetDeploymentWorkerRateLimitsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerRateLimitsAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,System.Threading.CancellationToken)')
  - [ShutdownDefaultChannelsAsync()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ShutdownDefaultChannelsAsync 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.ShutdownDefaultChannelsAsync')
- [DeploymentServiceClientBuilder](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder')
  - [Settings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-Settings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder.Settings')
  - [Build()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-Build 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder.Build')
  - [BuildAsync()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-BuildAsync-System-Threading-CancellationToken- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder.BuildAsync(System.Threading.CancellationToken)')
  - [GetChannelPool()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-GetChannelPool 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder.GetChannelPool')
  - [GetDefaultEndpoint()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-GetDefaultEndpoint 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder.GetDefaultEndpoint')
  - [GetDefaultScopes()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-GetDefaultScopes 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientBuilder.GetDefaultScopes')
- [DeploymentServiceClientImpl](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl')
  - [#ctor(grpcClient,settings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-#ctor-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.#ctor(Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
  - [CreateDeploymentOperationsClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-CreateDeploymentOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.CreateDeploymentOperationsClient')
  - [DeleteDeploymentOperationsClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-DeleteDeploymentOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.DeleteDeploymentOperationsClient')
  - [GrpcClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GrpcClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.GrpcClient')
  - [RestartDeploymentOperationsClient](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-RestartDeploymentOperationsClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.RestartDeploymentOperationsClient')
  - [CreateDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.CreateDeployment(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.CreateDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.DeleteDeployment(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.DeleteDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.GetDeployment(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.GetDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetRunningDeploymentByName(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.GetRunningDeploymentByName(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetRunningDeploymentByNameAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.GetRunningDeploymentByNameAsync(Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListDeployments(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.ListDeployments(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListDeploymentsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.ListDeploymentsAsync(Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [RestartDeployment(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.RestartDeployment(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [RestartDeploymentAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.RestartDeploymentAsync(Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTags(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentTags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentTagsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentTagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerCapacities(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentWorkerCapacities(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerCapacitiesAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentWorkerCapacitiesAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerFlags(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentWorkerFlags(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerFlagsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentWorkerFlagsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerRateLimits(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentWorkerRateLimits(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [SetDeploymentWorkerRateLimitsAsync(request,callSettings)](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClientImpl.SetDeploymentWorkerRateLimitsAsync(Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest,Google.Api.Gax.Grpc.CallSettings)')
- [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings')
  - [#ctor()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-#ctor 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.#ctor')
  - [CreateDeploymentOperationsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-CreateDeploymentOperationsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.CreateDeploymentOperationsSettings')
  - [CreateDeploymentSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-CreateDeploymentSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.CreateDeploymentSettings')
  - [DeleteDeploymentOperationsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-DeleteDeploymentOperationsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.DeleteDeploymentOperationsSettings')
  - [DeleteDeploymentSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-DeleteDeploymentSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.DeleteDeploymentSettings')
  - [GetDeploymentSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDeploymentSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.GetDeploymentSettings')
  - [GetRunningDeploymentByNameSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetRunningDeploymentByNameSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.GetRunningDeploymentByNameSettings')
  - [IdempotentRetryFilter](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-IdempotentRetryFilter 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.IdempotentRetryFilter')
  - [ListDeploymentsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-ListDeploymentsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.ListDeploymentsSettings')
  - [NonIdempotentRetryFilter](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-NonIdempotentRetryFilter 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.NonIdempotentRetryFilter')
  - [RestartDeploymentOperationsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-RestartDeploymentOperationsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.RestartDeploymentOperationsSettings')
  - [RestartDeploymentSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-RestartDeploymentSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.RestartDeploymentSettings')
  - [SetDeploymentTagsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentTagsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.SetDeploymentTagsSettings')
  - [SetDeploymentWorkerCapacitiesSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentWorkerCapacitiesSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.SetDeploymentWorkerCapacitiesSettings')
  - [SetDeploymentWorkerFlagsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentWorkerFlagsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.SetDeploymentWorkerFlagsSettings')
  - [SetDeploymentWorkerRateLimitsSettings](#P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentWorkerRateLimitsSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.SetDeploymentWorkerRateLimitsSettings')
  - [Clone()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-Clone 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.Clone')
  - [GetDefault()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDefault 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.GetDefault')
  - [GetDefaultRetryBackoff()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDefaultRetryBackoff 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.GetDefaultRetryBackoff')
  - [GetDefaultTimeoutBackoff()](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDefaultTimeoutBackoff 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings.GetDefaultTimeoutBackoff')
- [Filter](#T-Improbable-SpatialOS-Deployment-V1Beta1-Filter 'Improbable.SpatialOS.Deployment.V1Beta1.Filter')
  - [CreateTimePropertyFilterFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-CreateTimePropertyFilterFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Filter.CreateTimePropertyFilterFieldNumber')
  - [DeploymentNamePropertyFilterFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-DeploymentNamePropertyFilterFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Filter.DeploymentNamePropertyFilterFieldNumber')
  - [StoppedStatusPropertyFilterFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-StoppedStatusPropertyFilterFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Filter.StoppedStatusPropertyFilterFieldNumber')
  - [StoppedTimePropertyFilterFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-StoppedTimePropertyFilterFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Filter.StoppedTimePropertyFilterFieldNumber')
  - [TagsPropertyFilterFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-TagsPropertyFilterFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.Filter.TagsPropertyFilterFieldNumber')
- [FilterTypeOneofCase](#T-Improbable-SpatialOS-Deployment-V1Beta1-Filter-FilterTypeOneofCase 'Improbable.SpatialOS.Deployment.V1Beta1.Filter.FilterTypeOneofCase')
- [GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-IdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest.IdFieldNumber')
  - [ViewFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-ViewFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest.ViewFieldNumber')
  - [Id](#P-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-Id 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest.Id')
  - [View](#P-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-View 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest.View')
- [GetDeploymentResponse](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentResponse 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentResponse')
  - [DeploymentFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentResponse-DeploymentFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentResponse.DeploymentFieldNumber')
- [GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-DeploymentNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest.DeploymentNameFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest.ProjectNameFieldNumber')
  - [ViewFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-ViewFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest.ViewFieldNumber')
  - [DeploymentName](#P-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-DeploymentName 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest.DeploymentName')
  - [ProjectName](#P-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-ProjectName 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest.ProjectName')
  - [View](#P-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-View 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest.View')
- [LaunchConfig](#T-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig 'Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig')
  - [ConfigJsonFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig-ConfigJsonFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig.ConfigJsonFieldNumber')
  - [ConfigJson](#P-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig-ConfigJson 'Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig.ConfigJson')
- [ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest')
  - [FiltersFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-FiltersFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.FiltersFieldNumber')
  - [PageSizeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageSizeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.PageSizeFieldNumber')
  - [PageTokenFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageTokenFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.PageTokenFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.ProjectNameFieldNumber')
  - [Filters](#P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-Filters 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.Filters')
  - [PageSize](#P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageSize 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.PageSize')
  - [PageToken](#P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageToken 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.PageToken')
  - [ProjectName](#P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-ProjectName 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.ProjectName')
- [ListDeploymentsResponse](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsResponse')
  - [DeploymentsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-DeploymentsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsResponse.DeploymentsFieldNumber')
  - [NextPageTokenFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-NextPageTokenFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsResponse.NextPageTokenFieldNumber')
  - [NextPageToken](#P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-NextPageToken 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsResponse.NextPageToken')
  - [GetEnumerator()](#M-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-GetEnumerator 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsResponse.GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-System#Collections#IEnumerable#GetEnumerator 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsResponse.System#Collections#IEnumerable#GetEnumerator')
- [RestartDeploymentMetadata](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentMetadata 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentMetadata')
- [RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest-IdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest.IdFieldNumber')
- [SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest')
  - [DeploymentIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest-DeploymentIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest.DeploymentIdFieldNumber')
  - [TagsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest-TagsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest.TagsFieldNumber')
- [SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest')
  - [DeploymentIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest-DeploymentIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest.DeploymentIdFieldNumber')
  - [WorkerConnectionCapacitiesFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest-WorkerConnectionCapacitiesFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest.WorkerConnectionCapacitiesFieldNumber')
- [SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest')
  - [DeploymentIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest-DeploymentIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest.DeploymentIdFieldNumber')
  - [WorkerFlagsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest-WorkerFlagsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest.WorkerFlagsFieldNumber')
- [SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest')
  - [DeploymentIdFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest-DeploymentIdFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest.DeploymentIdFieldNumber')
  - [WorkerConnectionRateLimitsFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest-WorkerConnectionRateLimitsFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest.WorkerConnectionRateLimitsFieldNumber')
- [StoppedStatusPropertyFilter](#T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedStatusPropertyFilter 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedStatusPropertyFilter')
  - [StoppedStatusFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-StoppedStatusPropertyFilter-StoppedStatusFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedStatusPropertyFilter.StoppedStatusFieldNumber')
- [StoppedTimePropertyFilter](#T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedTimePropertyFilter')
  - [OperatorFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter-OperatorFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedTimePropertyFilter.OperatorFieldNumber')
  - [StoppedTimeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter-StoppedTimeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedTimePropertyFilter.StoppedTimeFieldNumber')
- [TagsPropertyFilter](#T-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter 'Improbable.SpatialOS.Deployment.V1Beta1.TagsPropertyFilter')
  - [OperatorFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter-OperatorFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.TagsPropertyFilter.OperatorFieldNumber')
  - [TagFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter-TagFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.TagsPropertyFilter.TagFieldNumber')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter-Types 'Improbable.SpatialOS.Deployment.V1Beta1.CreateTimePropertyFilter.Types')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Types 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment.Types')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter-Types 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentNamePropertyFilter.Types')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-Types 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest.Types')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedStatusPropertyFilter-Types 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedStatusPropertyFilter.Types')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter-Types 'Improbable.SpatialOS.Deployment.V1Beta1.StoppedTimePropertyFilter.Types')
- [Types](#T-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter-Types 'Improbable.SpatialOS.Deployment.V1Beta1.TagsPropertyFilter.Types')
- [ViewType](#T-Improbable-SpatialOS-Deployment-V1Beta1-ViewType 'Improbable.SpatialOS.Deployment.V1Beta1.ViewType')
  - [Basic](#F-Improbable-SpatialOS-Deployment-V1Beta1-ViewType-Basic 'Improbable.SpatialOS.Deployment.V1Beta1.ViewType.Basic')
  - [Full](#F-Improbable-SpatialOS-Deployment-V1Beta1-ViewType-Full 'Improbable.SpatialOS.Deployment.V1Beta1.ViewType.Full')
- [WorkerCapacity](#T-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity')
  - [MaxCapacityFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-MaxCapacityFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity.MaxCapacityFieldNumber')
  - [RemainingCapacityFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-RemainingCapacityFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity.RemainingCapacityFieldNumber')
  - [WorkerTypeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-WorkerTypeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity.WorkerTypeFieldNumber')
  - [MaxCapacity](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-MaxCapacity 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity.MaxCapacity')
  - [RemainingCapacity](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-RemainingCapacity 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity.RemainingCapacity')
  - [WorkerType](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-WorkerType 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity.WorkerType')
- [WorkerFlag](#T-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag')
  - [KeyFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-KeyFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag.KeyFieldNumber')
  - [ValueFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-ValueFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag.ValueFieldNumber')
  - [WorkerTypeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-WorkerTypeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag.WorkerTypeFieldNumber')
  - [Key](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-Key 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag.Key')
  - [Value](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-Value 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag.Value')
  - [WorkerType](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-WorkerType 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag.WorkerType')
- [WorkerRateLimit](#T-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit')
  - [DurationFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-DurationFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit.DurationFieldNumber')
  - [RequestsInDurationFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-RequestsInDurationFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit.RequestsInDurationFieldNumber')
  - [WorkerTypeFieldNumber](#F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-WorkerTypeFieldNumber 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit.WorkerTypeFieldNumber')
  - [Duration](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-Duration 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit.Duration')
  - [RequestsInDuration](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-RequestsInDuration 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit.RequestsInDuration')
  - [WorkerType](#P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-WorkerType 'Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit.WorkerType')

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentMetadata'></a>
## CreateDeploymentMetadata `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Metadata for CreateDeployment operations.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentMetadata-DeploymentIdFieldNumber'></a>
### DeploymentIdFieldNumber `constants`

##### Summary

Field number for the "deployment_id" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest'></a>
## CreateDeploymentRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-AssemblyNameFieldNumber'></a>
### AssemblyNameFieldNumber `constants`

##### Summary

Field number for the "assembly_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ClusterCodeFieldNumber'></a>
### ClusterCodeFieldNumber `constants`

##### Summary

Field number for the "cluster_code" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-LaunchConfigFieldNumber'></a>
### LaunchConfigFieldNumber `constants`

##### Summary

Field number for the "launch_config" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RegionCodeFieldNumber'></a>
### RegionCodeFieldNumber `constants`

##### Summary

Field number for the "region_code" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RuntimeVersionFieldNumber'></a>
### RuntimeVersionFieldNumber `constants`

##### Summary

Field number for the "runtime_version" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-StartingSnapshotIdFieldNumber'></a>
### StartingSnapshotIdFieldNumber `constants`

##### Summary

Field number for the "starting_snapshot_id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-TagsFieldNumber'></a>
### TagsFieldNumber `constants`

##### Summary

Field number for the "tags" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-AssemblyName'></a>
### AssemblyName `property`

##### Summary

The assembly to use for the deployment. You must supply this for cloud deployments. Local
deployments automatically use the assembly located in the folder containing the
\`spatialos.json\` file, so any value you supply is ignored.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ClusterCode'></a>
### ClusterCode `property`

##### Summary

The name of the cluster this deployment is in.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The name of the deployment.

 You choose the deployment's name. It must be lower case letters or numbers or underscores and
 3-32 characters in length.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-LaunchConfig'></a>
### LaunchConfig `property`

##### Summary

The configuration for starting the deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The name of the project this deployment belongs to.
It must be lower case letters or numbers or underscores and 3-32 characters in length.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RegionCode'></a>
### RegionCode `property`

##### Summary

The region that the deployment is running in.
The supported regions are "EU" and "US" (and "AP" for specific users who have requested
access). Leave blank if unknown.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-RuntimeVersion'></a>
### RuntimeVersion `property`

##### Summary

Only use this field if you were directed to do so by SpatialOS support

 The version of the Runtime to start the deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-StartingSnapshotId'></a>
### StartingSnapshotId `property`

##### Summary

The starting snapshot for the deployment. For cloud deployments, you must provide a starting
snapshot. For local deployments, if you don't provide a starting snapshot, it uses the default.
This is a string to allow users to provide a filepath to a snapshot in the local workflow.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest-Tags'></a>
### Tags `property`

##### Summary

Tags associated with the deployment. Tags are a set of strings you can use to identify
deployments. A tag must be upper or lower case letters or numbers or underscores and 3-32
characters in length.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter'></a>
## CreateTimePropertyFilter `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter-CreateTimeFieldNumber'></a>
### CreateTimeFieldNumber `constants`

##### Summary

Field number for the "create_time" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter-OperatorFieldNumber'></a>
### OperatorFieldNumber `constants`

##### Summary

Field number for the "operator" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentMetadata'></a>
## DeleteDeploymentMetadata `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Metadata for DeleteDeployment operations.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest'></a>
## DeleteDeploymentRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment'></a>
## Deployment `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-AssemblyNameFieldNumber'></a>
### AssemblyNameFieldNumber `constants`

##### Summary

Field number for the "assembly_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ClusterCodeFieldNumber'></a>
### ClusterCodeFieldNumber `constants`

##### Summary

Field number for the "cluster_code" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-DescriptionFieldNumber'></a>
### DescriptionFieldNumber `constants`

##### Summary

Field number for the "description" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ExpiryTimeFieldNumber'></a>
### ExpiryTimeFieldNumber `constants`

##### Summary

Field number for the "expiry_time" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-LaunchConfigFieldNumber'></a>
### LaunchConfigFieldNumber `constants`

##### Summary

Field number for the "launch_config" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RegionCodeFieldNumber'></a>
### RegionCodeFieldNumber `constants`

##### Summary

Field number for the "region_code" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RuntimeVersionFieldNumber'></a>
### RuntimeVersionFieldNumber `constants`

##### Summary

Field number for the "runtime_version" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartTimeFieldNumber'></a>
### StartTimeFieldNumber `constants`

##### Summary

Field number for the "start_time" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartingSnapshotIdFieldNumber'></a>
### StartingSnapshotIdFieldNumber `constants`

##### Summary

Field number for the "starting_snapshot_id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StatusFieldNumber'></a>
### StatusFieldNumber `constants`

##### Summary

Field number for the "status" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StopTimeFieldNumber'></a>
### StopTimeFieldNumber `constants`

##### Summary

Field number for the "stop_time" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-TagsFieldNumber'></a>
### TagsFieldNumber `constants`

##### Summary

Field number for the "tags" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionCapacitiesFieldNumber'></a>
### WorkerConnectionCapacitiesFieldNumber `constants`

##### Summary

Field number for the "worker_connection_capacities" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionRateLimitsFieldNumber'></a>
### WorkerConnectionRateLimitsFieldNumber `constants`

##### Summary

Field number for the "worker_connection_rate_limits" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerFlagsFieldNumber'></a>
### WorkerFlagsFieldNumber `constants`

##### Summary

Field number for the "worker_flags" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-AssemblyName'></a>
### AssemblyName `property`

##### Summary

The assembly to use for the deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ClusterCode'></a>
### ClusterCode `property`

##### Summary

The name of the cluster this deployment is in.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The name of the deployment.
It must be lower case letters or numbers or underscores and 3-32 characters in length.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Description'></a>
### Description `property`

##### Summary

The description provided when the deployment was started

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ExpiryTime'></a>
### ExpiryTime `property`

##### Summary

The time the deployment will expire.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Id'></a>
### Id `property`

##### Summary

A unique identifier for the deployment. Read-only. The deployment's \`id\` is assigned
automatically and uniquely identifies a particular run of a deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-LaunchConfig'></a>
### LaunchConfig `property`

##### Summary

The configuration for starting the deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-ProjectName'></a>
### ProjectName `property`

##### Summary

The name of the project this deployment belongs to.
It must be lower case letters or numbers or underscores and 3-32 characters in length.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RegionCode'></a>
### RegionCode `property`

##### Summary

The region that the deployment is running in.
The supported regions are "EU" and "US" (and "AP" for specific users who have requested
access).

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-RuntimeVersion'></a>
### RuntimeVersion `property`

##### Summary

Only use this field if you were directed to do so by SpatialOS support

 The version of the Runtime to start the deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartTime'></a>
### StartTime `property`

##### Summary

The time the deployment is started.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StartingSnapshotId'></a>
### StartingSnapshotId `property`

##### Summary

The starting snapshot for the deployment.
This is a string to allow users to provide a filepath to a snapshot in the local workflow.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Status'></a>
### Status `property`

##### Summary

Whether the deployment is running.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-StopTime'></a>
### StopTime `property`

##### Summary

The time the deployment is stopped.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Tags'></a>
### Tags `property`

##### Summary

Tags associated with the deployment. Tags are a set of strings you can use to identify
deployments. A tag must be upper or lower case letters or numbers or underscores and 3-32
characters in length.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionCapacities'></a>
### WorkerConnectionCapacities `property`

##### Summary

Only applicable to running deployments.

 The capacities of the deployment, broken down by worker type.
 The default maximum capacity for any worker type is a very large number,
 usually the maximum value of int32, i.e. 0x7FFFFFFF. But, it is not guaranteed.

 The current used capacity can always be calculated as \`max_capacity\` - \`remaining_capacity\`.

 Note: if you set the same worker type more than once, we provide no guarantee which overrides
 which.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerConnectionRateLimits'></a>
### WorkerConnectionRateLimits `property`

##### Summary

Only applicable to running deployments.

 The rate limits of the deployment, broken down by worker type. If a worker type is absent or
 has zero'ed value, you can assume that worker type is not rate limited.

 Note: if you set the same worker type more than once, we provide no guarantee which overrides
 which.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-WorkerFlags'></a>
### WorkerFlags `property`

##### Summary

The worker flags that the deployment exposes at runtime.

 Only applicable to running deployments. It is omitted for deployments in other states.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter'></a>
## DeploymentNamePropertyFilter `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

'Equal' will return all deployments matching the name exactly.
'Contains' will return deployments that match the supplied substring.
'Not Contains' is the logical not of 'Contains'.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter-OperatorFieldNumber'></a>
### OperatorFieldNumber `constants`

##### Summary

Field number for the "operator" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentReflection'></a>
## DeploymentReflection `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Holder for reflection information generated from improbable/spatialos/deployment/v1beta1/deployment.proto

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentReflection-Descriptor'></a>
### Descriptor `property`

##### Summary

File descriptor for improbable/spatialos/deployment/v1beta1/deployment.proto

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService'></a>
## DeploymentService `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

DeploymentService provides methods for managing deployments.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-Descriptor'></a>
### Descriptor `property`

##### Summary

Service descriptor

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-BindService-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-'></a>
### BindService(serviceImpl) `method`

##### Summary

Creates service definition that can be registered with a server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceImpl | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase') | An object implementing the server-side handling logic. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-'></a>
### BindService(serviceBinder,serviceImpl) `method`

##### Summary

Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
Note: this method is part of an experimental API that can change or be removed without any prior notice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBinder | [Grpc.Core.ServiceBinderBase](#T-Grpc-Core-ServiceBinderBase 'Grpc.Core.ServiceBinderBase') | Service methods will be bound by calling `AddMethod` on this object. |
| serviceImpl | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceBase') | An object implementing the server-side handling logic. |

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase'></a>
## DeploymentServiceBase `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService

##### Summary

Base class for server-side implementations of DeploymentService

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-ServerCallContext-'></a>
### CreateDeployment(request,context) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-ServerCallContext-'></a>
### DeleteDeployment(request,context) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-ServerCallContext-'></a>
### GetDeployment(request,context) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-ServerCallContext-'></a>
### GetRunningDeploymentByName(request,context) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-ServerCallContext-'></a>
### ListDeployments(request,context) `method`

##### Summary

Lists deployments under a given project.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-ServerCallContext-'></a>
### RestartDeployment(request,context) `method`

##### Summary

Restarts a deployment.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-ServerCallContext-'></a>
### SetDeploymentTags(request,context) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-ServerCallContext-'></a>
### SetDeploymentWorkerCapacities(request,context) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-ServerCallContext-'></a>
### SetDeploymentWorkerFlags(request,context) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceBase-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-ServerCallContext-'></a>
### SetDeploymentWorkerRateLimits(request,context) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient'></a>
## DeploymentServiceClient `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService

##### Summary

Client for DeploymentService

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient'></a>
## DeploymentServiceClient `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

DeploymentService client wrapper, for convenient use.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor-Grpc-Core-Channel-'></a>
### #ctor(channel) `constructor`

##### Summary

Creates a new client for DeploymentService

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The channel to use to make remote calls. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor-Grpc-Core-CallInvoker-'></a>
### #ctor(callInvoker) `constructor`

##### Summary

Creates a new client for DeploymentService that uses a custom `CallInvoker`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The callInvoker to use to make remote calls. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Protected parameterless constructor to allow creation of test doubles.

##### Parameters

This constructor has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Protected constructor to allow creation of configured clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Grpc.Core.ClientBase.ClientBaseConfiguration](#T-Grpc-Core-ClientBase-ClientBaseConfiguration 'Grpc.Core.ClientBase.ClientBaseConfiguration') | The client configuration. |

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentOperationsClient'></a>
### CreateDeploymentOperationsClient `property`

##### Summary

The long-running operations client for `CreateDeployment`.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DefaultEndpoint'></a>
### DefaultEndpoint `property`

##### Summary

The default endpoint for the DeploymentService service, which is a host of "platform.api.improbable.io" and a port of 443.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DefaultScopes'></a>
### DefaultScopes `property`

##### Summary

The default DeploymentService scopes.

##### Remarks

The default DeploymentService scopes are:

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentOperationsClient'></a>
### DeleteDeploymentOperationsClient `property`

##### Summary

The long-running operations client for `DeleteDeployment`.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC DeploymentService client.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentOperationsClient'></a>
### RestartDeploymentOperationsClient `property`

##### Summary

The long-running operations client for `RestartDeployment`.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateDeployment(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-CallOptions-'></a>
### CreateDeployment(request,options) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateDeploymentAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Grpc-Core-CallOptions-'></a>
### CreateDeploymentAsync(request,options) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-CreateOperationsClient'></a>
### CreateOperationsClient() `method`

##### Summary

Creates a new instance of [OperationsClient](#T-Google-LongRunning-Operations-OperationsClient 'Google.LongRunning.Operations.OperationsClient') using the same call invoker as this client.

##### Returns

A new Operations client for the same target as this client.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DeleteDeployment(request,headers,deadline,cancellationToken) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-CallOptions-'></a>
### DeleteDeployment(request,options) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DeleteDeploymentAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Grpc-Core-CallOptions-'></a>
### DeleteDeploymentAsync(request,options) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetDeployment(request,headers,deadline,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-CallOptions-'></a>
### GetDeployment(request,options) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetDeploymentAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Grpc-Core-CallOptions-'></a>
### GetDeploymentAsync(request,options) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetRunningDeploymentByName(request,headers,deadline,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-CallOptions-'></a>
### GetRunningDeploymentByName(request,options) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetRunningDeploymentByNameAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Grpc-Core-CallOptions-'></a>
### GetRunningDeploymentByNameAsync(request,options) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ListDeployments(request,headers,deadline,cancellationToken) `method`

##### Summary

Lists deployments under a given project.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-CallOptions-'></a>
### ListDeployments(request,options) `method`

##### Summary

Lists deployments under a given project.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ListDeploymentsAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Lists deployments under a given project.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Grpc-Core-CallOptions-'></a>
### ListDeploymentsAsync(request,options) `method`

##### Summary

Lists deployments under a given project.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### NewInstance() `method`

##### Summary

Creates a new instance of client from given `ClientBaseConfiguration`.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### RestartDeployment(request,headers,deadline,cancellationToken) `method`

##### Summary

Restarts a deployment.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-CallOptions-'></a>
### RestartDeployment(request,options) `method`

##### Summary

Restarts a deployment.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### RestartDeploymentAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Restarts a deployment.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Grpc-Core-CallOptions-'></a>
### RestartDeploymentAsync(request,options) `method`

##### Summary

Restarts a deployment.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentTags(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentTags(request,options) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentTagsAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentTagsAsync(request,options) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerCapacities(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentWorkerCapacities(request,options) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerCapacitiesAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentWorkerCapacitiesAsync(request,options) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerFlags(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentWorkerFlags(request,options) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerFlagsAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentWorkerFlagsAsync(request,options) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerRateLimits(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentWorkerRateLimits(request,options) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerRateLimitsAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Grpc-Core-CallOptions-'></a>
### SetDeploymentWorkerRateLimitsAsync(request,options) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-'></a>
### Create(endpoint,settings) `method`

##### Summary

Synchronously creates a [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The created [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') | Optional [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.Deployment.V1Beta1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
DeploymentServiceClient client = DeploymentServiceClient.Create();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.Deployment.V1Beta1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    DeploymentServiceClient.DefaultEndpoint.Host, DeploymentServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
DeploymentServiceClient client = DeploymentServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
channel.ShutdownAsync().Wait();
```

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-'></a>
### Create(channel,settings) `method`

##### Summary

Creates a [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') which uses the specified channel for remote operations.

##### Returns

The created [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The [Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') | Optional [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings'). |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-'></a>
### Create(callInvoker,settings) `method`

##### Summary

Creates a [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') which uses the specified call invoker for remote operations.

##### Returns

The created [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The [CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') | Optional [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings'). |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-'></a>
### CreateAsync(endpoint,settings) `method`

##### Summary

Asynchronously creates a [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The task representing the created [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') | Optional [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.Deployment.V1Beta1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
DeploymentServiceClient client = await DeploymentServiceClient.CreateAsync();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.Deployment.V1Beta1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    DeploymentServiceClient.DefaultEndpoint.Host, DeploymentServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
DeploymentServiceClient client = DeploymentServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
await channel.ShutdownAsync();
```

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeployment-System-String,System-String,System-String,System-String,Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDeployment(projectName,deploymentName,assemblyName,startingSnapshotId,launchConfig,callSettings) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project this deployment belongs to.
 It must be lower case letters or numbers or underscores and 3-32 characters in length. |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the deployment.

 You choose the deployment's name. It must be lower case letters or numbers or underscores and
 3-32 characters in length. |
| assemblyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The assembly to use for the deployment. You must supply this for cloud deployments. Local
 deployments automatically use the assembly located in the folder containing the
 \`spatialos.json\` file, so any value you supply is ignored. |
| startingSnapshotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The starting snapshot for the deployment. For cloud deployments, you must provide a starting
 snapshot. For local deployments, if you don't provide a starting snapshot, it uses the default.
 This is a string to allow users to provide a filepath to a snapshot in the local workflow. |
| launchConfig | [Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig](#T-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig 'Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig') | The configuration for starting the deployment. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDeployment(request,callSettings) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentAsync-System-String,System-String,System-String,System-String,Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDeploymentAsync(projectName,deploymentName,assemblyName,startingSnapshotId,launchConfig,callSettings) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project this deployment belongs to.
 It must be lower case letters or numbers or underscores and 3-32 characters in length. |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the deployment.

 You choose the deployment's name. It must be lower case letters or numbers or underscores and
 3-32 characters in length. |
| assemblyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The assembly to use for the deployment. You must supply this for cloud deployments. Local
 deployments automatically use the assembly located in the folder containing the
 \`spatialos.json\` file, so any value you supply is ignored. |
| startingSnapshotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The starting snapshot for the deployment. For cloud deployments, you must provide a starting
 snapshot. For local deployments, if you don't provide a starting snapshot, it uses the default.
 This is a string to allow users to provide a filepath to a snapshot in the local workflow. |
| launchConfig | [Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig](#T-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig 'Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig') | The configuration for starting the deployment. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentAsync-System-String,System-String,System-String,System-String,Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig,System-Threading-CancellationToken-'></a>
### CreateDeploymentAsync(projectName,deploymentName,assemblyName,startingSnapshotId,launchConfig,cancellationToken) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project this deployment belongs to.
 It must be lower case letters or numbers or underscores and 3-32 characters in length. |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the deployment.

 You choose the deployment's name. It must be lower case letters or numbers or underscores and
 3-32 characters in length. |
| assemblyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The assembly to use for the deployment. You must supply this for cloud deployments. Local
 deployments automatically use the assembly located in the folder containing the
 \`spatialos.json\` file, so any value you supply is ignored. |
| startingSnapshotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The starting snapshot for the deployment. For cloud deployments, you must provide a starting
 snapshot. For local deployments, if you don't provide a starting snapshot, it uses the default.
 This is a string to allow users to provide a filepath to a snapshot in the local workflow. |
| launchConfig | [Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig](#T-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig 'Improbable.SpatialOS.Deployment.V1Beta1.LaunchConfig') | The configuration for starting the deployment. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDeploymentAsync(request,callSettings) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeployment-System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteDeployment(id,callSettings) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteDeployment(request,callSettings) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentAsync-System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteDeploymentAsync(id,callSettings) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentAsync-System-Int64,System-Threading-CancellationToken-'></a>
### DeleteDeploymentAsync(id,cancellationToken) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteDeploymentAsync(request,callSettings) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeployment-System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDeployment(id,callSettings) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A unique identifier for the deployment. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDeployment(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDeploymentAsync(id,callSettings) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A unique identifier for the deployment. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-System-Int64,System-Threading-CancellationToken-'></a>
### GetDeploymentAsync(id,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A unique identifier for the deployment. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDeploymentAsync(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,System-Threading-CancellationToken-'></a>
### GetDeploymentAsync(request,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByName-System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetRunningDeploymentByName(projectName,deploymentName,callSettings) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment's project.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the deployment.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetRunningDeploymentByName(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetRunningDeploymentByNameAsync(projectName,deploymentName,callSettings) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment's project.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the deployment.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### GetRunningDeploymentByNameAsync(projectName,deploymentName,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment's project.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the deployment.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetRunningDeploymentByNameAsync(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,System-Threading-CancellationToken-'></a>
### GetRunningDeploymentByNameAsync(request,cancellationToken) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeployments-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDeployments(projectName,pageToken,pageSize,callSettings) `method`

##### Summary

Lists deployments under a given project.

##### Returns

A pageable sequence of [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project to list all deployments for.

 \`project_name\` must conform to the regex: ^[a-z0-9_]{3,32}$ |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
 A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
 A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDeployments(request,callSettings) `method`

##### Summary

Lists deployments under a given project.

##### Returns

A pageable sequence of [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeploymentsAsync-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDeploymentsAsync(projectName,pageToken,pageSize,callSettings) `method`

##### Summary

Lists deployments under a given project.

##### Returns

A pageable asynchronous sequence of [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project to list all deployments for.

 \`project_name\` must conform to the regex: ^[a-z0-9_]{3,32}$ |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
 A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
 A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDeploymentsAsync(request,callSettings) `method`

##### Summary

Lists deployments under a given project.

##### Returns

A pageable asynchronous sequence of [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceCreateDeployment-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceCreateDeployment(operationName,callSettings) `method`

##### Summary

Poll an operation once, using an `operationName` from a previous invocation of `CreateDeployment`.

##### Returns

The result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceCreateDeploymentAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceCreateDeploymentAsync(operationName,callSettings) `method`

##### Summary

Asynchronously poll an operation once, using an `operationName` from a previous invocation of `CreateDeploymentAsync`.

##### Returns

A task representing the result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceDeleteDeployment-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceDeleteDeployment(operationName,callSettings) `method`

##### Summary

Poll an operation once, using an `operationName` from a previous invocation of `DeleteDeployment`.

##### Returns

The result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceDeleteDeploymentAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceDeleteDeploymentAsync(operationName,callSettings) `method`

##### Summary

Asynchronously poll an operation once, using an `operationName` from a previous invocation of `DeleteDeploymentAsync`.

##### Returns

A task representing the result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceRestartDeployment-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceRestartDeployment(operationName,callSettings) `method`

##### Summary

Poll an operation once, using an `operationName` from a previous invocation of `RestartDeployment`.

##### Returns

The result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-PollOnceRestartDeploymentAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceRestartDeploymentAsync(operationName,callSettings) `method`

##### Summary

Asynchronously poll an operation once, using an `operationName` from a previous invocation of `RestartDeploymentAsync`.

##### Returns

A task representing the result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeployment-System-Nullable{System-Int64},Google-Api-Gax-Grpc-CallSettings-'></a>
### RestartDeployment(id,callSettings) `method`

##### Summary

Restarts a deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### RestartDeployment(request,callSettings) `method`

##### Summary

Restarts a deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentAsync-System-Nullable{System-Int64},Google-Api-Gax-Grpc-CallSettings-'></a>
### RestartDeploymentAsync(id,callSettings) `method`

##### Summary

Restarts a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentAsync-System-Nullable{System-Int64},System-Threading-CancellationToken-'></a>
### RestartDeploymentAsync(id,cancellationToken) `method`

##### Summary

Restarts a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### RestartDeploymentAsync(request,callSettings) `method`

##### Summary

Restarts a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTags-System-Int64,System-Collections-Generic-IEnumerable{System-String},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentTags(deploymentId,tags,callSettings) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| tags | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentTags(request,callSettings) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-System-Int64,System-Collections-Generic-IEnumerable{System-String},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentTagsAsync(deploymentId,tags,callSettings) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| tags | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-System-Int64,System-Collections-Generic-IEnumerable{System-String},System-Threading-CancellationToken-'></a>
### SetDeploymentTagsAsync(deploymentId,tags,cancellationToken) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| tags | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentTagsAsync(request,callSettings) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,System-Threading-CancellationToken-'></a>
### SetDeploymentTagsAsync(request,cancellationToken) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacities-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerCapacities(deploymentId,workerConnectionCapacities,callSettings) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
 \`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerConnectionCapacities | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerCapacities(request,callSettings) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerCapacitiesAsync(deploymentId,workerConnectionCapacities,callSettings) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
 \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerConnectionCapacities | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerCapacitiesAsync(deploymentId,workerConnectionCapacities,cancellationToken) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
 \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerConnectionCapacities | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerCapacity}') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerCapacitiesAsync(request,callSettings) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerCapacitiesAsync(request,cancellationToken) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlags-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerFlags(deploymentId,workerFlags,callSettings) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
 \`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerFlags | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerFlags(request,callSettings) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerFlagsAsync(deploymentId,workerFlags,callSettings) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
 \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerFlags | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerFlagsAsync(deploymentId,workerFlags,cancellationToken) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
 \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerFlags | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerFlag}') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerFlagsAsync(request,callSettings) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerFlagsAsync(request,cancellationToken) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimits-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerRateLimits(deploymentId,workerConnectionRateLimits,callSettings) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
 \`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerConnectionRateLimits | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerRateLimits(request,callSettings) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit},Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerRateLimitsAsync(deploymentId,workerConnectionRateLimits,callSettings) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
 \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerConnectionRateLimits | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit}') |  |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit},System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerRateLimitsAsync(deploymentId,workerConnectionRateLimits,cancellationToken) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
 \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| workerConnectionRateLimits | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.Deployment.V1Beta1.WorkerRateLimit}') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerRateLimitsAsync(request,callSettings) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,System-Threading-CancellationToken-'></a>
### SetDeploymentWorkerRateLimitsAsync(request,cancellationToken) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-ShutdownDefaultChannelsAsync'></a>
### ShutdownDefaultChannelsAsync() `method`

##### Summary

Shuts down any channels automatically created by [Create](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)'). Channels which weren't automatically
created are not affected.

##### Returns

A task representing the asynchronous shutdown operation.

##### Parameters

This method has no parameters.

##### Remarks

After calling this method, further calls to [Create](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings- 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings)') will create new channels, which could
in turn be shut down by another call to this method.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder'></a>
## DeploymentServiceClientBuilder `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Builder class for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') to provide simple configuration of credentials, endpoint etc.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-Settings'></a>
### Settings `property`

##### Summary

The settings to use for RPCs, or null for the default settings.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-Build'></a>
### Build() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-BuildAsync-System-Threading-CancellationToken-'></a>
### BuildAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-GetChannelPool'></a>
### GetChannelPool() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-GetDefaultEndpoint'></a>
### GetDefaultEndpoint() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientBuilder-GetDefaultScopes'></a>
### GetDefaultScopes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl'></a>
## DeploymentServiceClientImpl `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

DeploymentService client wrapper implementation, for convenient use.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-#ctor-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient,Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-'></a>
### #ctor(grpcClient,settings) `constructor`

##### Summary

Constructs a client wrapper for the DeploymentService service, with the specified gRPC client and settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| grpcClient | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentService-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentService.DeploymentServiceClient') | The underlying gRPC client. |
| settings | [Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') | The base [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') used within this client |

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-CreateDeploymentOperationsClient'></a>
### CreateDeploymentOperationsClient `property`

##### Summary

The long-running operations client for `CreateDeployment`.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-DeleteDeploymentOperationsClient'></a>
### DeleteDeploymentOperationsClient `property`

##### Summary

The long-running operations client for `DeleteDeployment`.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC DeploymentService client.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-RestartDeploymentOperationsClient'></a>
### RestartDeploymentOperationsClient `property`

##### Summary

The long-running operations client for `RestartDeployment`.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-CreateDeployment-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDeployment(request,callSettings) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-CreateDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDeploymentAsync(request,callSettings) `method`

##### Summary

Creates a deployment.

 The returned operation result is of type \`Deployment\` upon successful creation.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-CreateDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.CreateDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-DeleteDeployment-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteDeployment(request,callSettings) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-DeleteDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteDeploymentAsync(request,callSettings) `method`

##### Summary

Deletes a deployment.

 The returned operation result is of type \`Deployment\` upon successful deletion.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeleteDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.DeleteDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetDeployment-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDeployment(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDeploymentAsync(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetRunningDeploymentByName-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetRunningDeploymentByName(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-GetRunningDeploymentByNameAsync-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetRunningDeploymentByNameAsync(request,callSettings) `method`

##### Summary

Gets a deployment as identified by \`name\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest 'Improbable.SpatialOS.Deployment.V1Beta1.GetRunningDeploymentByNameRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-ListDeployments-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDeployments(request,callSettings) `method`

##### Summary

Lists deployments under a given project.

##### Returns

A pageable sequence of [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-ListDeploymentsAsync-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDeploymentsAsync(request,callSettings) `method`

##### Summary

Lists deployments under a given project.

##### Returns

A pageable asynchronous sequence of [Deployment](#T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment 'Improbable.SpatialOS.Deployment.V1Beta1.Deployment') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-RestartDeployment-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### RestartDeployment(request,callSettings) `method`

##### Summary

Restarts a deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-RestartDeploymentAsync-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### RestartDeploymentAsync(request,callSettings) `method`

##### Summary

Restarts a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest 'Improbable.SpatialOS.Deployment.V1Beta1.RestartDeploymentRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentTags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentTags(request,callSettings) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentTagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentTagsAsync(request,callSettings) `method`

##### Summary

SetDeploymentTags sets the tags on a deployment as identified by the \`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentTagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerCapacities-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerCapacities(request,callSettings) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerCapacitiesAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerCapacitiesAsync(request,callSettings) `method`

##### Summary

SetDeploymentWorkerCapacities sets the worker capacities on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerCapacitiesRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerFlags-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerFlags(request,callSettings) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerFlagsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerFlagsAsync(request,callSettings) `method`

##### Summary

SetDeploymentWorkerFlags sets the worker flags on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerFlagsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerRateLimits-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerRateLimits(request,callSettings) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClientImpl-SetDeploymentWorkerRateLimitsAsync-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### SetDeploymentWorkerRateLimitsAsync(request,callSettings) `method`

##### Summary

SetDeploymentWorkerRateLimits sets the worker rate limits on a deployment as identified by the
\`deployment_id\`.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest](#T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest 'Improbable.SpatialOS.Deployment.V1Beta1.SetDeploymentWorkerRateLimitsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings'></a>
## DeploymentServiceSettings `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Settings for a [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient').

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') object with default settings.

##### Parameters

This constructor has no parameters.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-CreateDeploymentOperationsSettings'></a>
### CreateDeploymentOperationsSettings `property`

##### Summary

Long Running Operation settings for calls to `DeploymentServiceClient.CreateDeployment`.

##### Remarks

Uses default [PollSettings](#T-Google-Api-Gax-PollSettings 'Google.Api.Gax.PollSettings') of:

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-CreateDeploymentSettings'></a>
### CreateDeploymentSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.CreateDeployment` and `DeploymentServiceClient.CreateDeploymentAsync`.

##### Remarks

The default `DeploymentServiceClient.CreateDeployment` and
`DeploymentServiceClient.CreateDeploymentAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-DeleteDeploymentOperationsSettings'></a>
### DeleteDeploymentOperationsSettings `property`

##### Summary

Long Running Operation settings for calls to `DeploymentServiceClient.DeleteDeployment`.

##### Remarks

Uses default [PollSettings](#T-Google-Api-Gax-PollSettings 'Google.Api.Gax.PollSettings') of:

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-DeleteDeploymentSettings'></a>
### DeleteDeploymentSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.DeleteDeployment` and `DeploymentServiceClient.DeleteDeploymentAsync`.

##### Remarks

The default `DeploymentServiceClient.DeleteDeployment` and
`DeploymentServiceClient.DeleteDeploymentAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDeploymentSettings'></a>
### GetDeploymentSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.GetDeployment` and `DeploymentServiceClient.GetDeploymentAsync`.

##### Remarks

The default `DeploymentServiceClient.GetDeployment` and
`DeploymentServiceClient.GetDeploymentAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetRunningDeploymentByNameSettings'></a>
### GetRunningDeploymentByNameSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.GetRunningDeploymentByName` and `DeploymentServiceClient.GetRunningDeploymentByNameAsync`.

##### Remarks

The default `DeploymentServiceClient.GetRunningDeploymentByName` and
`DeploymentServiceClient.GetRunningDeploymentByNameAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-IdempotentRetryFilter'></a>
### IdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "Idempotent" [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods.

##### Remarks

The eligible RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s for retry for "Idempotent" RPC methods are:

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-ListDeploymentsSettings'></a>
### ListDeploymentsSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.ListDeployments` and `DeploymentServiceClient.ListDeploymentsAsync`.

##### Remarks

The default `DeploymentServiceClient.ListDeployments` and
`DeploymentServiceClient.ListDeploymentsAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-NonIdempotentRetryFilter'></a>
### NonIdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "NonIdempotent" [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods.

##### Remarks

There are no RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s eligible for retry for "NonIdempotent" RPC methods.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-RestartDeploymentOperationsSettings'></a>
### RestartDeploymentOperationsSettings `property`

##### Summary

Long Running Operation settings for calls to `DeploymentServiceClient.RestartDeployment`.

##### Remarks

Uses default [PollSettings](#T-Google-Api-Gax-PollSettings 'Google.Api.Gax.PollSettings') of:

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-RestartDeploymentSettings'></a>
### RestartDeploymentSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.RestartDeployment` and `DeploymentServiceClient.RestartDeploymentAsync`.

##### Remarks

The default `DeploymentServiceClient.RestartDeployment` and
`DeploymentServiceClient.RestartDeploymentAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentTagsSettings'></a>
### SetDeploymentTagsSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.SetDeploymentTags` and `DeploymentServiceClient.SetDeploymentTagsAsync`.

##### Remarks

The default `DeploymentServiceClient.SetDeploymentTags` and
`DeploymentServiceClient.SetDeploymentTagsAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentWorkerCapacitiesSettings'></a>
### SetDeploymentWorkerCapacitiesSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.SetDeploymentWorkerCapacities` and `DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync`.

##### Remarks

The default `DeploymentServiceClient.SetDeploymentWorkerCapacities` and
`DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentWorkerFlagsSettings'></a>
### SetDeploymentWorkerFlagsSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.SetDeploymentWorkerFlags` and `DeploymentServiceClient.SetDeploymentWorkerFlagsAsync`.

##### Remarks

The default `DeploymentServiceClient.SetDeploymentWorkerFlags` and
`DeploymentServiceClient.SetDeploymentWorkerFlagsAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-SetDeploymentWorkerRateLimitsSettings'></a>
### SetDeploymentWorkerRateLimitsSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`DeploymentServiceClient.SetDeploymentWorkerRateLimits` and `DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync`.

##### Remarks

The default `DeploymentServiceClient.SetDeploymentWorkerRateLimits` and
`DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-Clone'></a>
### Clone() `method`

##### Summary

Creates a deep clone of this object, with all the same property values.

##### Returns

A deep clone of this [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings') object.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDefault'></a>
### GetDefault() `method`

##### Summary

Get a new instance of the default [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings').

##### Returns

A new instance of the default [DeploymentServiceSettings](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceSettings').

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDefaultRetryBackoff'></a>
### GetDefaultRetryBackoff() `method`

##### Summary

"Default" retry backoff for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods.

##### Returns

The "Default" retry backoff for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" retry backoff for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods is defined as:

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceSettings-GetDefaultTimeoutBackoff'></a>
### GetDefaultTimeoutBackoff() `method`

##### Summary

"Default" timeout backoff for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods.

##### Returns

The "Default" timeout backoff for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" timeout backoff for [DeploymentServiceClient](#T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentServiceClient 'Improbable.SpatialOS.Deployment.V1Beta1.DeploymentServiceClient') RPC methods is defined as:

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-Filter'></a>
## Filter `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-CreateTimePropertyFilterFieldNumber'></a>
### CreateTimePropertyFilterFieldNumber `constants`

##### Summary

Field number for the "create_time_property_filter" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-DeploymentNamePropertyFilterFieldNumber'></a>
### DeploymentNamePropertyFilterFieldNumber `constants`

##### Summary

Field number for the "deployment_name_property_filter" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-StoppedStatusPropertyFilterFieldNumber'></a>
### StoppedStatusPropertyFilterFieldNumber `constants`

##### Summary

Field number for the "stopped_status_property_filter" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-StoppedTimePropertyFilterFieldNumber'></a>
### StoppedTimePropertyFilterFieldNumber `constants`

##### Summary

Field number for the "stopped_time_property_filter" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-Filter-TagsPropertyFilterFieldNumber'></a>
### TagsPropertyFilterFieldNumber `constants`

##### Summary

Field number for the "tags_property_filter" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-Filter-FilterTypeOneofCase'></a>
## FilterTypeOneofCase `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.Filter

##### Summary

Enum of possible cases for the "filter_type" oneof.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest'></a>
## GetDeploymentRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-ViewFieldNumber'></a>
### ViewFieldNumber `constants`

##### Summary

Field number for the "view" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-Id'></a>
### Id `property`

##### Summary

A unique identifier for the deployment.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentRequest-View'></a>
### View `property`

##### Summary

How much data is returned for the deployment. Optional.
The default is BASIC, which does NOT return all fields for the \`Deployment\` in the response,
but is much cheaper than requesting a FULL response.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentResponse'></a>
## GetDeploymentResponse `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-GetDeploymentResponse-DeploymentFieldNumber'></a>
### DeploymentFieldNumber `constants`

##### Summary

Field number for the "deployment" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest'></a>
## GetRunningDeploymentByNameRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-ViewFieldNumber'></a>
### ViewFieldNumber `constants`

##### Summary

Field number for the "view" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The name of the deployment.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The deployment's project.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-GetRunningDeploymentByNameRequest-View'></a>
### View `property`

##### Summary

How much data is returned for the deployment. Optional.
The default is BASIC, which does NOT return all fields for the \`Deployment\` in the response,
but is much cheaper than requesting a FULL response.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig'></a>
## LaunchConfig `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig-ConfigJsonFieldNumber'></a>
### ConfigJsonFieldNumber `constants`

##### Summary

Field number for the "config_json" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-LaunchConfig-ConfigJson'></a>
### ConfigJson `property`

##### Summary

The launch configuration for the deployment, supplied as JSON. Multiple formats are supported:
FPL launch config format:
https://docs.improbable.io/reference/latest/shared/flexible-project-layout/reference/launch-configuration
SPL launch config format:
https://docs.improbable.io/reference/latest/shared/project-layout/launch-config

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest'></a>
## ListDeploymentsRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-FiltersFieldNumber'></a>
### FiltersFieldNumber `constants`

##### Summary

Field number for the "filters" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageSizeFieldNumber'></a>
### PageSizeFieldNumber `constants`

##### Summary

Field number for the "page_size" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageTokenFieldNumber'></a>
### PageTokenFieldNumber `constants`

##### Summary

Field number for the "page_token" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-Filters'></a>
### Filters `property`

##### Summary

TODO(1896): add cli annotation here, may require an extension to protoc-gen-gocli

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageSize'></a>
### PageSize `property`

##### Summary

The maximum number of deployments to return in the response.

 It must not be negative. If unset or 0,
 it defaults to 20.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-PageToken'></a>
### PageToken `property`

##### Summary

The token to identify the starting point of the request.
An empty or invalid token defaults to listing from the start.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The project to list all deployments for.

 \`project_name\` must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse'></a>
## ListDeploymentsResponse `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-DeploymentsFieldNumber'></a>
### DeploymentsFieldNumber `constants`

##### Summary

Field number for the "deployments" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-NextPageTokenFieldNumber'></a>
### NextPageTokenFieldNumber `constants`

##### Summary

Field number for the "next_page_token" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-NextPageToken'></a>
### NextPageToken `property`

##### Summary

A token you can supply to the ListDeployments RPC to retrieve the next page of
paginated results.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the resources in this response.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsResponse-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentMetadata'></a>
## RestartDeploymentMetadata `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Metadata for RestartDeployment operations.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest'></a>
## RestartDeploymentRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-RestartDeploymentRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest'></a>
## SetDeploymentTagsRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest-DeploymentIdFieldNumber'></a>
### DeploymentIdFieldNumber `constants`

##### Summary

Field number for the "deployment_id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentTagsRequest-TagsFieldNumber'></a>
### TagsFieldNumber `constants`

##### Summary

Field number for the "tags" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest'></a>
## SetDeploymentWorkerCapacitiesRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest-DeploymentIdFieldNumber'></a>
### DeploymentIdFieldNumber `constants`

##### Summary

Field number for the "deployment_id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerCapacitiesRequest-WorkerConnectionCapacitiesFieldNumber'></a>
### WorkerConnectionCapacitiesFieldNumber `constants`

##### Summary

Field number for the "worker_connection_capacities" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest'></a>
## SetDeploymentWorkerFlagsRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest-DeploymentIdFieldNumber'></a>
### DeploymentIdFieldNumber `constants`

##### Summary

Field number for the "deployment_id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerFlagsRequest-WorkerFlagsFieldNumber'></a>
### WorkerFlagsFieldNumber `constants`

##### Summary

Field number for the "worker_flags" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest'></a>
## SetDeploymentWorkerRateLimitsRequest `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest-DeploymentIdFieldNumber'></a>
### DeploymentIdFieldNumber `constants`

##### Summary

Field number for the "deployment_id" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-SetDeploymentWorkerRateLimitsRequest-WorkerConnectionRateLimitsFieldNumber'></a>
### WorkerConnectionRateLimitsFieldNumber `constants`

##### Summary

Field number for the "worker_connection_rate_limits" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedStatusPropertyFilter'></a>
## StoppedStatusPropertyFilter `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-StoppedStatusPropertyFilter-StoppedStatusFieldNumber'></a>
### StoppedStatusFieldNumber `constants`

##### Summary

Field number for the "stopped_status" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter'></a>
## StoppedTimePropertyFilter `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter-OperatorFieldNumber'></a>
### OperatorFieldNumber `constants`

##### Summary

Field number for the "operator" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter-StoppedTimeFieldNumber'></a>
### StoppedTimeFieldNumber `constants`

##### Summary

Field number for the "stopped_time" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter'></a>
## TagsPropertyFilter `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

'Equal' will return all deployments that have at least one tag matching the provided string.
'Contains' will return all deployments that have at least one tag matching the provided
substring. 'Not Contains' is the logical not of 'Contains'.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter-OperatorFieldNumber'></a>
### OperatorFieldNumber `constants`

##### Summary

Field number for the "operator" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter-TagFieldNumber'></a>
### TagFieldNumber `constants`

##### Summary

Field number for the "tag" field.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-CreateTimePropertyFilter-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.CreateTimePropertyFilter

##### Summary

Container for nested types declared in the CreateTimePropertyFilter message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-Deployment-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.Deployment

##### Summary

Container for nested types declared in the Deployment message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-DeploymentNamePropertyFilter-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.DeploymentNamePropertyFilter

##### Summary

Container for nested types declared in the DeploymentNamePropertyFilter message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-ListDeploymentsRequest-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.ListDeploymentsRequest

##### Summary

Container for nested types declared in the ListDeploymentsRequest message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedStatusPropertyFilter-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.StoppedStatusPropertyFilter

##### Summary

Container for nested types declared in the StoppedStatusPropertyFilter message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-StoppedTimePropertyFilter-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.StoppedTimePropertyFilter

##### Summary

Container for nested types declared in the StoppedTimePropertyFilter message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-TagsPropertyFilter-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1.TagsPropertyFilter

##### Summary

Container for nested types declared in the TagsPropertyFilter message type.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-ViewType'></a>
## ViewType `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

##### Summary

Default is BASIC unless otherwise specified.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ViewType-Basic'></a>
### Basic `constants`

##### Summary

Only return basic fields for each \`Deployment\` message.
Does not return:
  * WorkerFlags
  * WorkerConnectionCapacities
  * WorkerConnectionRateLimits

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-ViewType-Full'></a>
### Full `constants`

##### Summary

Return all fields for each \`Deployment\` message. Unless you require the additional fields,
prefer BASIC as it is significantly less expensive.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity'></a>
## WorkerCapacity `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-MaxCapacityFieldNumber'></a>
### MaxCapacityFieldNumber `constants`

##### Summary

Field number for the "max_capacity" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-RemainingCapacityFieldNumber'></a>
### RemainingCapacityFieldNumber `constants`

##### Summary

Field number for the "remaining_capacity" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-WorkerTypeFieldNumber'></a>
### WorkerTypeFieldNumber `constants`

##### Summary

Field number for the "worker_type" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-MaxCapacity'></a>
### MaxCapacity `property`

##### Summary

Mutable.

 The maximum number of workers of the specified type that are allowed to connect to a SpatialOS
 deployment. Setting it to a lower number than the number of already connected workers does not
 drop their connections.

 It must not be a negative number.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-RemainingCapacity'></a>
### RemainingCapacity `property`

##### Summary

Read-only.

 The available capacity for connection.

 Note: it can go negative when you set \`max_capacity\` lower than the connection capacity already
 used.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerCapacity-WorkerType'></a>
### WorkerType `property`

##### Summary

The type of worker that this capacity limit applies to.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag'></a>
## WorkerFlag `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-KeyFieldNumber'></a>
### KeyFieldNumber `constants`

##### Summary

Field number for the "key" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-ValueFieldNumber'></a>
### ValueFieldNumber `constants`

##### Summary

Field number for the "value" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-WorkerTypeFieldNumber'></a>
### WorkerTypeFieldNumber `constants`

##### Summary

Field number for the "worker_type" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-Key'></a>
### Key `property`

##### Summary

The key of the flag.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-Value'></a>
### Value `property`

##### Summary

The value of the flag.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerFlag-WorkerType'></a>
### WorkerType `property`

##### Summary

The type of server worker that can see the flag.

<a name='T-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit'></a>
## WorkerRateLimit `type`

##### Namespace

Improbable.SpatialOS.Deployment.V1Beta1

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-DurationFieldNumber'></a>
### DurationFieldNumber `constants`

##### Summary

Field number for the "duration" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-RequestsInDurationFieldNumber'></a>
### RequestsInDurationFieldNumber `constants`

##### Summary

Field number for the "requests_in_duration" field.

<a name='F-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-WorkerTypeFieldNumber'></a>
### WorkerTypeFieldNumber `constants`

##### Summary

Field number for the "worker_type" field.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-Duration'></a>
### Duration `property`

##### Summary

Mutable.

 The duration window to apply the rate limit in.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-RequestsInDuration'></a>
### RequestsInDuration `property`

##### Summary

Mutable.

 The maximum number of requests allowed during the specified duration window.

<a name='P-Improbable-SpatialOS-Deployment-V1Beta1-WorkerRateLimit-WorkerType'></a>
### WorkerType `property`

##### Summary

The type of worker that this rate limit applies to.
