<a name='assembly'></a>
# Improbable.SpatialOS.Platform.RemoteInteraction.V1Alpha1

## Contents

- [Code](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-Types-Code 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.Types.Code')
- [CommandStatus](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus')
  - [MessageFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-MessageFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.MessageFieldNumber')
  - [StatusCodeFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-StatusCodeFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.StatusCodeFieldNumber')
  - [Message](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-Message 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.Message')
  - [StatusCode](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-StatusCode 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.StatusCode')
- [CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest')
  - [BinaryFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-BinaryFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.BinaryFieldNumber')
  - [EntityIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-EntityIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.EntityIdFieldNumber')
  - [TargetFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-TargetFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.TargetFieldNumber')
  - [Binary](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-Binary 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.Binary')
  - [EntityId](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-EntityId 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.EntityId')
  - [Target](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-Target 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.Target')
- [CreateEntityResponse](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse')
  - [EntityIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-EntityIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse.EntityIdFieldNumber')
  - [StatusFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-StatusFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse.StatusFieldNumber')
  - [EntityId](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-EntityId 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse.EntityId')
  - [Status](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-Status 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse.Status')
- [DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest')
  - [EntityIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-EntityIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest.EntityIdFieldNumber')
  - [TargetFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-TargetFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest.TargetFieldNumber')
  - [EntityId](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-EntityId 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest.EntityId')
  - [Target](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-Target 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest.Target')
- [DeleteEntityResponse](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityResponse 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse')
  - [StatusFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityResponse-StatusFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse.StatusFieldNumber')
  - [Status](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityResponse-Status 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse.Status')
- [Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-DeploymentNameFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment.DeploymentNameFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-ProjectNameFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment.ProjectNameFieldNumber')
  - [DeploymentName](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-DeploymentName 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment.DeploymentName')
  - [ProjectName](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-ProjectName 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment.ProjectName')
- [Entity](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity')
  - [BinaryFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-BinaryFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity.BinaryFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-IdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity.IdFieldNumber')
  - [Binary](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-Binary 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity.Binary')
  - [Id](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-Id 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity.Id')
- [EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest')
  - [BinaryFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-BinaryFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.BinaryFieldNumber')
  - [ComponentTargetFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-ComponentTargetFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.ComponentTargetFieldNumber')
  - [TargetFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-TargetFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.TargetFieldNumber')
  - [WorkerIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.WorkerIdFieldNumber')
  - [WorkerTypeFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerTypeFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.WorkerTypeFieldNumber')
  - [Binary](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Binary 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Binary')
  - [ComponentTarget](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-ComponentTarget 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.ComponentTarget')
  - [Target](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Target 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Target')
  - [WorkerId](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerId 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.WorkerId')
  - [WorkerType](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerType 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.WorkerType')
- [EntityCommandResponse](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse')
  - [BinaryFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-BinaryFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse.BinaryFieldNumber')
  - [StatusFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-StatusFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse.StatusFieldNumber')
  - [Binary](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-Binary 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse.Binary')
  - [Status](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-Status 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse.Status')
- [EntityCommandTarget](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Types.EntityCommandTarget')
  - [CommandIdxFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget-CommandIdxFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Types.EntityCommandTarget.CommandIdxFieldNumber')
  - [ComponentIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget-ComponentIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Types.EntityCommandTarget.ComponentIdFieldNumber')
  - [EntityIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget-EntityIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Types.EntityCommandTarget.EntityIdFieldNumber')
- [EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest')
  - [BinaryFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-BinaryFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest.BinaryFieldNumber')
  - [TargetFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-TargetFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest.TargetFieldNumber')
  - [Binary](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-Binary 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest.Binary')
  - [Target](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-Target 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest.Target')
- [EntityQueryResponse](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse')
  - [ResultFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-ResultFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.ResultFieldNumber')
  - [StatusFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-StatusFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.StatusFieldNumber')
  - [Result](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Result 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Result')
  - [Status](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Status 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Status')
- [EntityStateOneofCase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-EntityStateOneofCase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.EntityStateOneofCase')
- [PayloadOneofCase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-PayloadOneofCase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.PayloadOneofCase')
- [QueryOneofCase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-QueryOneofCase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest.QueryOneofCase')
- [RemoteInteractionService](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService')
  - [Descriptor](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-Descriptor 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.Descriptor')
  - [BindService(serviceImpl)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-BindService-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.BindService(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase)')
  - [BindService(serviceBinder,serviceImpl)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.BindService(Grpc.Core.ServiceBinderBase,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase)')
- [RemoteInteractionServiceBase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase')
  - [CreateEntity(request,context)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase.CreateEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Grpc.Core.ServerCallContext)')
  - [DeleteEntity(request,context)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase.DeleteEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Grpc.Core.ServerCallContext)')
  - [EntityCommand(request,context)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase.EntityCommand(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Grpc.Core.ServerCallContext)')
  - [EntityQuery(request,context)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase.EntityQuery(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Grpc.Core.ServerCallContext)')
  - [ReserveEntityId(request,context)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase.ReserveEntityId(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Grpc.Core.ServerCallContext)')
- [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient')
- [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient')
  - [#ctor(channel)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor-Grpc-Core-Channel- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.#ctor(Grpc.Core.Channel)')
  - [#ctor(callInvoker)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor-Grpc-Core-CallInvoker- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.#ctor(Grpc.Core.CallInvoker)')
  - [#ctor()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.#ctor')
  - [#ctor(configuration)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.#ctor(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [DefaultEndpoint](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DefaultEndpoint 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DefaultEndpoint')
  - [DefaultScopes](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DefaultScopes 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DefaultScopes')
  - [GrpcClient](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-GrpcClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.GrpcClient')
  - [CreateEntity(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.CreateEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateEntity(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.CreateEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Grpc.Core.CallOptions)')
  - [CreateEntityAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateEntityAsync(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Grpc.Core.CallOptions)')
  - [DeleteEntity(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.DeleteEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DeleteEntity(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.DeleteEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Grpc.Core.CallOptions)')
  - [DeleteEntityAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DeleteEntityAsync(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Grpc.Core.CallOptions)')
  - [EntityCommand(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityCommand(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [EntityCommand(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityCommand(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Grpc.Core.CallOptions)')
  - [EntityCommandAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityCommandAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [EntityCommandAsync(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityCommandAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Grpc.Core.CallOptions)')
  - [EntityQuery(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityQuery(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [EntityQuery(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityQuery(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Grpc.Core.CallOptions)')
  - [EntityQueryAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [EntityQueryAsync(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Grpc.Core.CallOptions)')
  - [NewInstance()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.NewInstance(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [ReserveEntityId(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.ReserveEntityId(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ReserveEntityId(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.ReserveEntityId(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Grpc.Core.CallOptions)')
  - [ReserveEntityIdAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ReserveEntityIdAsync(request,options)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Grpc.Core.CallOptions)')
  - [Create(endpoint,settings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
  - [Create(channel,settings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.Create(Grpc.Core.Channel,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
  - [Create(callInvoker,settings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.Create(Grpc.Core.CallInvoker,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
  - [CreateAsync(endpoint,settings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
  - [CreateEntity(target,entityId,binary,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-Int64},Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Nullable{System.Int64},Google.Protobuf.ByteString,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateEntity(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateEntityAsync(target,entityId,binary,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-Int64},Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Nullable{System.Int64},Google.Protobuf.ByteString,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateEntityAsync(target,entityId,binary,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-Int64},Google-Protobuf-ByteString,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Nullable{System.Int64},Google.Protobuf.ByteString,System.Threading.CancellationToken)')
  - [CreateEntityAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateEntityAsync(request,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,System.Threading.CancellationToken)')
  - [DeleteEntity(target,entityId,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DeleteEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteEntity(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DeleteEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteEntityAsync(target,entityId,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteEntityAsync(target,entityId,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Int64,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Int64,System.Threading.CancellationToken)')
  - [DeleteEntityAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteEntityAsync(request,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,System.Threading.CancellationToken)')
  - [EntityCommand(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityCommand(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityCommandAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityCommandAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityCommandAsync(request,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityCommandAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,System.Threading.CancellationToken)')
  - [EntityQuery(target,binary,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityQuery(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,Google.Protobuf.ByteString,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityQuery(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityQuery(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityQueryAsync(target,binary,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,Google.Protobuf.ByteString,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityQueryAsync(target,binary,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,Google-Protobuf-ByteString,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,Google.Protobuf.ByteString,System.Threading.CancellationToken)')
  - [EntityQueryAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityQueryAsync(request,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,System.Threading.CancellationToken)')
  - [ReserveEntityId(target,numberOfIds,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-UInt32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ReserveEntityId(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Nullable{System.UInt32},Google.Api.Gax.Grpc.CallSettings)')
  - [ReserveEntityId(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ReserveEntityId(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ReserveEntityIdAsync(target,numberOfIds,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-UInt32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Nullable{System.UInt32},Google.Api.Gax.Grpc.CallSettings)')
  - [ReserveEntityIdAsync(target,numberOfIds,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-UInt32},System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment,System.Nullable{System.UInt32},System.Threading.CancellationToken)')
  - [ReserveEntityIdAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ReserveEntityIdAsync(request,cancellationToken)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,System.Threading.CancellationToken)')
  - [ShutdownDefaultChannelsAsync()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ShutdownDefaultChannelsAsync 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.ShutdownDefaultChannelsAsync')
- [RemoteInteractionServiceClientBuilder](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder')
  - [Settings](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-Settings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder.Settings')
  - [Build()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-Build 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder.Build')
  - [BuildAsync()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-BuildAsync-System-Threading-CancellationToken- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder.BuildAsync(System.Threading.CancellationToken)')
  - [GetChannelPool()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-GetChannelPool 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder.GetChannelPool')
  - [GetDefaultEndpoint()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-GetDefaultEndpoint 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder.GetDefaultEndpoint')
  - [GetDefaultScopes()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-GetDefaultScopes 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientBuilder.GetDefaultScopes')
- [RemoteInteractionServiceClientImpl](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl')
  - [#ctor(grpcClient,settings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-#ctor-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.#ctor(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
  - [GrpcClient](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-GrpcClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.GrpcClient')
  - [CreateEntity(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.CreateEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateEntityAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.CreateEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteEntity(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.DeleteEntity(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteEntityAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.DeleteEntityAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityCommand(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.EntityCommand(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityCommandAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.EntityCommandAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityQuery(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.EntityQuery(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [EntityQueryAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.EntityQueryAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ReserveEntityId(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.ReserveEntityId(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ReserveEntityIdAsync(request,callSettings)](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClientImpl.ReserveEntityIdAsync(Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest,Google.Api.Gax.Grpc.CallSettings)')
- [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings')
  - [#ctor()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-#ctor 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.#ctor')
  - [CreateEntitySettings](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-CreateEntitySettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.CreateEntitySettings')
  - [DeleteEntitySettings](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-DeleteEntitySettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.DeleteEntitySettings')
  - [EntityCommandSettings](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-EntityCommandSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.EntityCommandSettings')
  - [EntityQuerySettings](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-EntityQuerySettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.EntityQuerySettings')
  - [IdempotentRetryFilter](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-IdempotentRetryFilter 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.IdempotentRetryFilter')
  - [NonIdempotentRetryFilter](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-NonIdempotentRetryFilter 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.NonIdempotentRetryFilter')
  - [ReserveEntityIdSettings](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-ReserveEntityIdSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.ReserveEntityIdSettings')
  - [Clone()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-Clone 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.Clone')
  - [GetDefault()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-GetDefault 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.GetDefault')
  - [GetDefaultRetryBackoff()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-GetDefaultRetryBackoff 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.GetDefaultRetryBackoff')
  - [GetDefaultTimeoutBackoff()](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-GetDefaultTimeoutBackoff 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings.GetDefaultTimeoutBackoff')
- [RemoteinteractionReflection](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteinteractionReflection 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteinteractionReflection')
  - [Descriptor](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteinteractionReflection-Descriptor 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteinteractionReflection.Descriptor')
- [ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest')
  - [NumberOfIdsFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-NumberOfIdsFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest.NumberOfIdsFieldNumber')
  - [TargetFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-TargetFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest.TargetFieldNumber')
  - [NumberOfIds](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-NumberOfIds 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest.NumberOfIds')
  - [Target](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-Target 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest.Target')
- [ReserveEntityIdResponse](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse')
  - [EntityIdFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-EntityIdFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse.EntityIdFieldNumber')
  - [StatusFieldNumber](#F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-StatusFieldNumber 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse.StatusFieldNumber')
  - [EntityId](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-EntityId 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse.EntityId')
  - [Status](#P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-Status 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse.Status')
- [ResponseOneofCase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-ResponseOneofCase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse.ResponseOneofCase')
- [StateOneofCase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-StateOneofCase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity.StateOneofCase')
- [Types](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-Types 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.Types')
- [Types](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Types')
- [Types](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types')

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-Types-Code'></a>
## Code `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus.Types

##### Summary

Status codes that can be returned. They are identical to the ones
supported by the Worker SDKs.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus'></a>
## CommandStatus `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

##### Summary

Additional status information for when executing an entity command.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-MessageFieldNumber'></a>
### MessageFieldNumber `constants`

##### Summary

Field number for the "message" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-StatusCodeFieldNumber'></a>
### StatusCodeFieldNumber `constants`

##### Summary

Field number for the "status_code" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-Message'></a>
### Message `property`

##### Summary

An optional descriptive string explaining the status.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-StatusCode'></a>
### StatusCode `property`

##### Summary

The status code telling us what the result of the command was.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest'></a>
## CreateEntityRequest `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-BinaryFieldNumber'></a>
### BinaryFieldNumber `constants`

##### Summary

Field number for the "binary" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-EntityIdFieldNumber'></a>
### EntityIdFieldNumber `constants`

##### Summary

Field number for the "entity_id" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-TargetFieldNumber'></a>
### TargetFieldNumber `constants`

##### Summary

Field number for the "target" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-Binary'></a>
### Binary `property`

##### Summary

Binary-encoded schema.improbable.EntityState message.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-EntityId'></a>
### EntityId `property`

##### Summary

Optional ID of the entity to create. If specified it needs to have been reserved before by a
call to ReserveEntityId.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-Target'></a>
### Target `property`

##### Summary

Deployment targeted by the requeset.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse'></a>
## CreateEntityResponse `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-EntityIdFieldNumber'></a>
### EntityIdFieldNumber `constants`

##### Summary

Field number for the "entity_id" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-StatusFieldNumber'></a>
### StatusFieldNumber `constants`

##### Summary

Field number for the "status" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-EntityId'></a>
### EntityId `property`

##### Summary

ID of the newly created entity.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityResponse-Status'></a>
### Status `property`

##### Summary

Response status.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest'></a>
## DeleteEntityRequest `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-EntityIdFieldNumber'></a>
### EntityIdFieldNumber `constants`

##### Summary

Field number for the "entity_id" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-TargetFieldNumber'></a>
### TargetFieldNumber `constants`

##### Summary

Field number for the "target" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-EntityId'></a>
### EntityId `property`

##### Summary

ID of the entity that should be deleted.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest-Target'></a>
### Target `property`

##### Summary

Deployment targeted by the requeset.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityResponse'></a>
## DeleteEntityResponse `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityResponse-StatusFieldNumber'></a>
### StatusFieldNumber `constants`

##### Summary

Field number for the "status" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityResponse-Status'></a>
### Status `property`

##### Summary

Response status.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment'></a>
## Deployment `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The name of the deployment targeted by the execution request.

 \`deployment_name\` must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the deployment targeted by the execution request belongs to.

 \`project_name\` must conform to the following regular expression: ^[a-z0-9_]{3,32}$

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity'></a>
## Entity `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-BinaryFieldNumber'></a>
### BinaryFieldNumber `constants`

##### Summary

Field number for the "binary" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-Binary'></a>
### Binary `property`

##### Summary

List of binary-encoded schema.improbable.EntityState messages.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-Id'></a>
### Id `property`

##### Summary

ID of the entity.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest'></a>
## EntityCommandRequest `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-BinaryFieldNumber'></a>
### BinaryFieldNumber `constants`

##### Summary

Field number for the "binary" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-ComponentTargetFieldNumber'></a>
### ComponentTargetFieldNumber `constants`

##### Summary

Field number for the "component_target" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-TargetFieldNumber'></a>
### TargetFieldNumber `constants`

##### Summary

Field number for the "target" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerIdFieldNumber'></a>
### WorkerIdFieldNumber `constants`

##### Summary

Field number for the "worker_id" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerTypeFieldNumber'></a>
### WorkerTypeFieldNumber `constants`

##### Summary

Field number for the "worker_type" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Binary'></a>
### Binary `property`

##### Summary

Binary-encoded schema.improbable.EntityCommand message.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-ComponentTarget'></a>
### ComponentTarget `property`

##### Summary

Target component of the entity command.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Target'></a>
### Target `property`

##### Summary

Deployment targeted by the request.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerId'></a>
### WorkerId `property`

##### Summary

Worker ID that will be forwarded with the command to the handling worker. This allows for
entity commands forwarded through the RIS to impersonate any (in)existent worker.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-WorkerType'></a>
### WorkerType `property`

##### Summary

Worker type that will be forwarded with the command to the handling worker. The specified
 string needs to correspond to a worker type defined in the deployment's bridge configurations.
 This allows for entity commands forwarded through the RIS to impersonate any known worker type.
 Specifying an unknown worker type will result in an error with an INVALID_ARGUMENT code.

 The regular expression used to validate types is synchronised with the one present in the
 WorkerType message of proto/improbable/platform/deployment/worker_flagz.proto.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse'></a>
## EntityCommandResponse `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-BinaryFieldNumber'></a>
### BinaryFieldNumber `constants`

##### Summary

Field number for the "binary" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-StatusFieldNumber'></a>
### StatusFieldNumber `constants`

##### Summary

Field number for the "status" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-Binary'></a>
### Binary `property`

##### Summary

Binary-encoded schema.improbable.EntityCommand message.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-Status'></a>
### Status `property`

##### Summary

Response status.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget'></a>
## EntityCommandTarget `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Types

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget-CommandIdxFieldNumber'></a>
### CommandIdxFieldNumber `constants`

##### Summary

Field number for the "command_idx" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget-ComponentIdFieldNumber'></a>
### ComponentIdFieldNumber `constants`

##### Summary

Field number for the "component_id" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types-EntityCommandTarget-EntityIdFieldNumber'></a>
### EntityIdFieldNumber `constants`

##### Summary

Field number for the "entity_id" field.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest'></a>
## EntityQueryRequest `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-BinaryFieldNumber'></a>
### BinaryFieldNumber `constants`

##### Summary

Field number for the "binary" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-TargetFieldNumber'></a>
### TargetFieldNumber `constants`

##### Summary

Field number for the "target" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-Binary'></a>
### Binary `property`

##### Summary

Binary-encoded schema.improbable.ComponentInterest.Query message.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-Target'></a>
### Target `property`

##### Summary

Deployment targeted by the requeset.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse'></a>
## EntityQueryResponse `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-ResultFieldNumber'></a>
### ResultFieldNumber `constants`

##### Summary

Field number for the "result" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-StatusFieldNumber'></a>
### StatusFieldNumber `constants`

##### Summary

Field number for the "status" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Result'></a>
### Result `property`

##### Summary

Entities returned by the query.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Status'></a>
### Status `property`

##### Summary

Response status.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest-EntityStateOneofCase'></a>
## EntityStateOneofCase `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest

##### Summary

Enum of possible cases for the "entity_state" oneof.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-PayloadOneofCase'></a>
## PayloadOneofCase `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest

##### Summary

Enum of possible cases for the "payload" oneof.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest-QueryOneofCase'></a>
## QueryOneofCase `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest

##### Summary

Enum of possible cases for the "query" oneof.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService'></a>
## RemoteInteractionService `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-Descriptor'></a>
### Descriptor `property`

##### Summary

Service descriptor

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-BindService-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-'></a>
### BindService(serviceImpl) `method`

##### Summary

Creates service definition that can be registered with a server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceImpl | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase') | An object implementing the server-side handling logic. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-'></a>
### BindService(serviceBinder,serviceImpl) `method`

##### Summary

Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
Note: this method is part of an experimental API that can change or be removed without any prior notice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBinder | [Grpc.Core.ServiceBinderBase](#T-Grpc-Core-ServiceBinderBase 'Grpc.Core.ServiceBinderBase') | Service methods will be bound by calling `AddMethod` on this object. |
| serviceImpl | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceBase') | An object implementing the server-side handling logic. |

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase'></a>
## RemoteInteractionServiceBase `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService

##### Summary

Base class for server-side implementations of RemoteInteractionService

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-ServerCallContext-'></a>
### CreateEntity(request,context) `method`

##### Summary

Create a new entity.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-ServerCallContext-'></a>
### DeleteEntity(request,context) `method`

##### Summary

Delete an existing entity.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-ServerCallContext-'></a>
### EntityCommand(request,context) `method`

##### Summary

Execute an entity command.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-ServerCallContext-'></a>
### EntityQuery(request,context) `method`

##### Summary

Execute a one-shot query.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceBase-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-ServerCallContext-'></a>
### ReserveEntityId(request,context) `method`

##### Summary

Reserve an entity ID.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient'></a>
## RemoteInteractionServiceClient `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService

##### Summary

Client for RemoteInteractionService

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient'></a>
## RemoteInteractionServiceClient `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

##### Summary

RemoteInteractionService client wrapper, for convenient use.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor-Grpc-Core-Channel-'></a>
### #ctor(channel) `constructor`

##### Summary

Creates a new client for RemoteInteractionService

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The channel to use to make remote calls. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor-Grpc-Core-CallInvoker-'></a>
### #ctor(callInvoker) `constructor`

##### Summary

Creates a new client for RemoteInteractionService that uses a custom `CallInvoker`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The callInvoker to use to make remote calls. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Protected parameterless constructor to allow creation of test doubles.

##### Parameters

This constructor has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Protected constructor to allow creation of configured clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Grpc.Core.ClientBase.ClientBaseConfiguration](#T-Grpc-Core-ClientBase-ClientBaseConfiguration 'Grpc.Core.ClientBase.ClientBaseConfiguration') | The client configuration. |

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DefaultEndpoint'></a>
### DefaultEndpoint `property`

##### Summary

The default endpoint for the RemoteInteractionService service, which is a host of "platform.api.improbable.io" and a port of 443.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DefaultScopes'></a>
### DefaultScopes `property`

##### Summary

The default RemoteInteractionService scopes.

##### Remarks

The default RemoteInteractionService scopes are:

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC RemoteInteractionService client.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateEntity(request,headers,deadline,cancellationToken) `method`

##### Summary

Create a new entity.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-CallOptions-'></a>
### CreateEntity(request,options) `method`

##### Summary

Create a new entity.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateEntityAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Create a new entity.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Grpc-Core-CallOptions-'></a>
### CreateEntityAsync(request,options) `method`

##### Summary

Create a new entity.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DeleteEntity(request,headers,deadline,cancellationToken) `method`

##### Summary

Delete an existing entity.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-CallOptions-'></a>
### DeleteEntity(request,options) `method`

##### Summary

Delete an existing entity.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DeleteEntityAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Delete an existing entity.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Grpc-Core-CallOptions-'></a>
### DeleteEntityAsync(request,options) `method`

##### Summary

Delete an existing entity.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### EntityCommand(request,headers,deadline,cancellationToken) `method`

##### Summary

Execute an entity command.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-CallOptions-'></a>
### EntityCommand(request,options) `method`

##### Summary

Execute an entity command.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### EntityCommandAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Execute an entity command.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Grpc-Core-CallOptions-'></a>
### EntityCommandAsync(request,options) `method`

##### Summary

Execute an entity command.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### EntityQuery(request,headers,deadline,cancellationToken) `method`

##### Summary

Execute a one-shot query.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-CallOptions-'></a>
### EntityQuery(request,options) `method`

##### Summary

Execute a one-shot query.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### EntityQueryAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Execute a one-shot query.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Grpc-Core-CallOptions-'></a>
### EntityQueryAsync(request,options) `method`

##### Summary

Execute a one-shot query.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### NewInstance() `method`

##### Summary

Creates a new instance of client from given `ClientBaseConfiguration`.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ReserveEntityId(request,headers,deadline,cancellationToken) `method`

##### Summary

Reserve an entity ID.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-CallOptions-'></a>
### ReserveEntityId(request,options) `method`

##### Summary

Reserve an entity ID.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ReserveEntityIdAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Reserve an entity ID.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Grpc-Core-CallOptions-'></a>
### ReserveEntityIdAsync(request,options) `method`

##### Summary

Reserve an entity ID.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-'></a>
### Create(endpoint,settings) `method`

##### Summary

Synchronously creates a [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The created [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') | Optional [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.RemoteInteraction.V1Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
RemoteInteractionServiceClient client = RemoteInteractionServiceClient.Create();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.RemoteInteraction.V1Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    RemoteInteractionServiceClient.DefaultEndpoint.Host, RemoteInteractionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
RemoteInteractionServiceClient client = RemoteInteractionServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
channel.ShutdownAsync().Wait();
```

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-'></a>
### Create(channel,settings) `method`

##### Summary

Creates a [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') which uses the specified channel for remote operations.

##### Returns

The created [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The [Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') | Optional [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings'). |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-'></a>
### Create(callInvoker,settings) `method`

##### Summary

Creates a [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') which uses the specified call invoker for remote operations.

##### Returns

The created [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The [CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') | Optional [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings'). |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-'></a>
### CreateAsync(endpoint,settings) `method`

##### Summary

Asynchronously creates a [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The task representing the created [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') | Optional [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.RemoteInteraction.V1Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
RemoteInteractionServiceClient client = await RemoteInteractionServiceClient.CreateAsync();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.RemoteInteraction.V1Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    RemoteInteractionServiceClient.DefaultEndpoint.Host, RemoteInteractionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
RemoteInteractionServiceClient client = RemoteInteractionServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
await channel.ShutdownAsync();
```

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-Int64},Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateEntity(target,entityId,binary,callSettings) `method`

##### Summary

Create a new entity.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| entityId | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | Optional ID of the entity to create. If specified it needs to have been reserved before by a
call to ReserveEntityId. |
| binary | [Google.Protobuf.ByteString](#T-Google-Protobuf-ByteString 'Google.Protobuf.ByteString') | Binary-encoded schema.improbable.EntityState message. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateEntity(request,callSettings) `method`

##### Summary

Create a new entity.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-Int64},Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateEntityAsync(target,entityId,binary,callSettings) `method`

##### Summary

Create a new entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| entityId | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | Optional ID of the entity to create. If specified it needs to have been reserved before by a
call to ReserveEntityId. |
| binary | [Google.Protobuf.ByteString](#T-Google-Protobuf-ByteString 'Google.Protobuf.ByteString') | Binary-encoded schema.improbable.EntityState message. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-Int64},Google-Protobuf-ByteString,System-Threading-CancellationToken-'></a>
### CreateEntityAsync(target,entityId,binary,cancellationToken) `method`

##### Summary

Create a new entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| entityId | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | Optional ID of the entity to create. If specified it needs to have been reserved before by a
call to ReserveEntityId. |
| binary | [Google.Protobuf.ByteString](#T-Google-Protobuf-ByteString 'Google.Protobuf.ByteString') | Binary-encoded schema.improbable.EntityState message. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateEntityAsync(request,callSettings) `method`

##### Summary

Create a new entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,System-Threading-CancellationToken-'></a>
### CreateEntityAsync(request,cancellationToken) `method`

##### Summary

Create a new entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteEntity(target,entityId,callSettings) `method`

##### Summary

Delete an existing entity.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| entityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of the entity that should be deleted. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteEntity(request,callSettings) `method`

##### Summary

Delete an existing entity.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteEntityAsync(target,entityId,callSettings) `method`

##### Summary

Delete an existing entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| entityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of the entity that should be deleted. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Int64,System-Threading-CancellationToken-'></a>
### DeleteEntityAsync(target,entityId,cancellationToken) `method`

##### Summary

Delete an existing entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| entityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of the entity that should be deleted. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteEntityAsync(request,callSettings) `method`

##### Summary

Delete an existing entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,System-Threading-CancellationToken-'></a>
### DeleteEntityAsync(request,cancellationToken) `method`

##### Summary

Delete an existing entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityCommand(request,callSettings) `method`

##### Summary

Execute an entity command.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityCommandAsync(request,callSettings) `method`

##### Summary

Execute an entity command.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,System-Threading-CancellationToken-'></a>
### EntityCommandAsync(request,cancellationToken) `method`

##### Summary

Execute an entity command.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityQuery(target,binary,callSettings) `method`

##### Summary

Execute a one-shot query.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| binary | [Google.Protobuf.ByteString](#T-Google-Protobuf-ByteString 'Google.Protobuf.ByteString') | Binary-encoded schema.improbable.ComponentInterest.Query message. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityQuery(request,callSettings) `method`

##### Summary

Execute a one-shot query.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,Google-Protobuf-ByteString,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityQueryAsync(target,binary,callSettings) `method`

##### Summary

Execute a one-shot query.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| binary | [Google.Protobuf.ByteString](#T-Google-Protobuf-ByteString 'Google.Protobuf.ByteString') | Binary-encoded schema.improbable.ComponentInterest.Query message. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,Google-Protobuf-ByteString,System-Threading-CancellationToken-'></a>
### EntityQueryAsync(target,binary,cancellationToken) `method`

##### Summary

Execute a one-shot query.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the requeset. |
| binary | [Google.Protobuf.ByteString](#T-Google-Protobuf-ByteString 'Google.Protobuf.ByteString') | Binary-encoded schema.improbable.ComponentInterest.Query message. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityQueryAsync(request,callSettings) `method`

##### Summary

Execute a one-shot query.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,System-Threading-CancellationToken-'></a>
### EntityQueryAsync(request,cancellationToken) `method`

##### Summary

Execute a one-shot query.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-UInt32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ReserveEntityId(target,numberOfIds,callSettings) `method`

##### Summary

Reserve an entity ID.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the request. |
| numberOfIds | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Optional number of entity IDs to reserve. If specified this allows for bulk reservations. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ReserveEntityId(request,callSettings) `method`

##### Summary

Reserve an entity ID.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-UInt32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ReserveEntityIdAsync(target,numberOfIds,callSettings) `method`

##### Summary

Reserve an entity ID.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the request. |
| numberOfIds | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Optional number of entity IDs to reserve. If specified this allows for bulk reservations. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment,System-Nullable{System-UInt32},System-Threading-CancellationToken-'></a>
### ReserveEntityIdAsync(target,numberOfIds,cancellationToken) `method`

##### Summary

Reserve an entity ID.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-Deployment 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.Deployment') | Deployment targeted by the request. |
| numberOfIds | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Optional number of entity IDs to reserve. If specified this allows for bulk reservations. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ReserveEntityIdAsync(request,callSettings) `method`

##### Summary

Reserve an entity ID.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,System-Threading-CancellationToken-'></a>
### ReserveEntityIdAsync(request,cancellationToken) `method`

##### Summary

Reserve an entity ID.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-ShutdownDefaultChannelsAsync'></a>
### ShutdownDefaultChannelsAsync() `method`

##### Summary

Shuts down any channels automatically created by [Create](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)'). Channels which weren't automatically
created are not affected.

##### Returns

A task representing the asynchronous shutdown operation.

##### Parameters

This method has no parameters.

##### Remarks

After calling this method, further calls to [Create](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings- 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings)') will create new channels, which could
in turn be shut down by another call to this method.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder'></a>
## RemoteInteractionServiceClientBuilder `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

##### Summary

Builder class for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') to provide simple configuration of credentials, endpoint etc.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-Settings'></a>
### Settings `property`

##### Summary

The settings to use for RPCs, or null for the default settings.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-Build'></a>
### Build() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-BuildAsync-System-Threading-CancellationToken-'></a>
### BuildAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-GetChannelPool'></a>
### GetChannelPool() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-GetDefaultEndpoint'></a>
### GetDefaultEndpoint() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientBuilder-GetDefaultScopes'></a>
### GetDefaultScopes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl'></a>
## RemoteInteractionServiceClientImpl `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

##### Summary

RemoteInteractionService client wrapper implementation, for convenient use.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-#ctor-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient,Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-'></a>
### #ctor(grpcClient,settings) `constructor`

##### Summary

Constructs a client wrapper for the RemoteInteractionService service, with the specified gRPC client and settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| grpcClient | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionService-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionService.RemoteInteractionServiceClient') | The underlying gRPC client. |
| settings | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') | The base [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') used within this client |

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC RemoteInteractionService client.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-CreateEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateEntity(request,callSettings) `method`

##### Summary

Create a new entity.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-CreateEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateEntityAsync(request,callSettings) `method`

##### Summary

Create a new entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CreateEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-DeleteEntity-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteEntity(request,callSettings) `method`

##### Summary

Delete an existing entity.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-DeleteEntityAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteEntityAsync(request,callSettings) `method`

##### Summary

Delete an existing entity.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-DeleteEntityRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityCommand-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityCommand(request,callSettings) `method`

##### Summary

Execute an entity command.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityCommandAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityCommandAsync(request,callSettings) `method`

##### Summary

Execute an entity command.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityQuery-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityQuery(request,callSettings) `method`

##### Summary

Execute a one-shot query.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-EntityQueryAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### EntityQueryAsync(request,callSettings) `method`

##### Summary

Execute a one-shot query.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-ReserveEntityId-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ReserveEntityId(request,callSettings) `method`

##### Summary

Reserve an entity ID.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClientImpl-ReserveEntityIdAsync-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ReserveEntityIdAsync(request,callSettings) `method`

##### Summary

Reserve an entity ID.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings'></a>
## RemoteInteractionServiceSettings `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

##### Summary

Settings for a [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient').

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') object with default settings.

##### Parameters

This constructor has no parameters.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-CreateEntitySettings'></a>
### CreateEntitySettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`RemoteInteractionServiceClient.CreateEntity` and `RemoteInteractionServiceClient.CreateEntityAsync`.

##### Remarks

The default `RemoteInteractionServiceClient.CreateEntity` and
`RemoteInteractionServiceClient.CreateEntityAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 60000 milliseconds.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-DeleteEntitySettings'></a>
### DeleteEntitySettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`RemoteInteractionServiceClient.DeleteEntity` and `RemoteInteractionServiceClient.DeleteEntityAsync`.

##### Remarks

The default `RemoteInteractionServiceClient.DeleteEntity` and
`RemoteInteractionServiceClient.DeleteEntityAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 60000 milliseconds.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-EntityCommandSettings'></a>
### EntityCommandSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`RemoteInteractionServiceClient.EntityCommand` and `RemoteInteractionServiceClient.EntityCommandAsync`.

##### Remarks

The default `RemoteInteractionServiceClient.EntityCommand` and
`RemoteInteractionServiceClient.EntityCommandAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 60000 milliseconds.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-EntityQuerySettings'></a>
### EntityQuerySettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`RemoteInteractionServiceClient.EntityQuery` and `RemoteInteractionServiceClient.EntityQueryAsync`.

##### Remarks

The default `RemoteInteractionServiceClient.EntityQuery` and
`RemoteInteractionServiceClient.EntityQueryAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 60000 milliseconds.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-IdempotentRetryFilter'></a>
### IdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "Idempotent" [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods.

##### Remarks

The eligible RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s for retry for "Idempotent" RPC methods are:

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-NonIdempotentRetryFilter'></a>
### NonIdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "NonIdempotent" [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods.

##### Remarks

There are no RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s eligible for retry for "NonIdempotent" RPC methods.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-ReserveEntityIdSettings'></a>
### ReserveEntityIdSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`RemoteInteractionServiceClient.ReserveEntityId` and `RemoteInteractionServiceClient.ReserveEntityIdAsync`.

##### Remarks

The default `RemoteInteractionServiceClient.ReserveEntityId` and
`RemoteInteractionServiceClient.ReserveEntityIdAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 60000 milliseconds.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-Clone'></a>
### Clone() `method`

##### Summary

Creates a deep clone of this object, with all the same property values.

##### Returns

A deep clone of this [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings') object.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-GetDefault'></a>
### GetDefault() `method`

##### Summary

Get a new instance of the default [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings').

##### Returns

A new instance of the default [RemoteInteractionServiceSettings](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceSettings').

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-GetDefaultRetryBackoff'></a>
### GetDefaultRetryBackoff() `method`

##### Summary

"Default" retry backoff for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods.

##### Returns

The "Default" retry backoff for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" retry backoff for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods is defined as:

<a name='M-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceSettings-GetDefaultTimeoutBackoff'></a>
### GetDefaultTimeoutBackoff() `method`

##### Summary

"Default" timeout backoff for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods.

##### Returns

The "Default" timeout backoff for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" timeout backoff for [RemoteInteractionServiceClient](#T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteInteractionServiceClient 'Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteInteractionServiceClient') RPC methods is defined as:

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteinteractionReflection'></a>
## RemoteinteractionReflection `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

##### Summary

Holder for reflection information generated from improbable/spatialos/remoteinteraction/v1alpha1/remoteinteraction.proto

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-RemoteinteractionReflection-Descriptor'></a>
### Descriptor `property`

##### Summary

File descriptor for improbable/spatialos/remoteinteraction/v1alpha1/remoteinteraction.proto

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest'></a>
## ReserveEntityIdRequest `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-NumberOfIdsFieldNumber'></a>
### NumberOfIdsFieldNumber `constants`

##### Summary

Field number for the "number_of_ids" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-TargetFieldNumber'></a>
### TargetFieldNumber `constants`

##### Summary

Field number for the "target" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-NumberOfIds'></a>
### NumberOfIds `property`

##### Summary

Optional number of entity IDs to reserve. If specified this allows for bulk reservations.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdRequest-Target'></a>
### Target `property`

##### Summary

Deployment targeted by the request.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse'></a>
## ReserveEntityIdResponse `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-EntityIdFieldNumber'></a>
### EntityIdFieldNumber `constants`

##### Summary

Field number for the "entity_id" field.

<a name='F-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-StatusFieldNumber'></a>
### StatusFieldNumber `constants`

##### Summary

Field number for the "status" field.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-EntityId'></a>
### EntityId `property`

##### Summary

The entity ID that has been reserved. If a bulk reservation request was made this will
correspond to the first of a contiguous range of entity IDs of which the lenght is identical to
the number of IDs that were requested.

<a name='P-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-ReserveEntityIdResponse-Status'></a>
### Status `property`

##### Summary

Response status.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandResponse-ResponseOneofCase'></a>
## ResponseOneofCase `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse

##### Summary

Enum of possible cases for the "response" oneof.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types-Entity-StateOneofCase'></a>
## StateOneofCase `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Types.Entity

##### Summary

Enum of possible cases for the "state" oneof.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-CommandStatus-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CommandStatus

##### Summary

Container for nested types declared in the CommandStatus message type.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityCommandRequest-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest

##### Summary

Container for nested types declared in the EntityCommandRequest message type.

<a name='T-Improbable-SpatialOS-RemoteInteraction-V1Alpha1-EntityQueryResponse-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse

##### Summary

Container for nested types declared in the EntityQueryResponse message type.
