<a name='assembly'></a>
# Improbable.SpatialOS.Platform.Snapshot.V1Alpha1

## Contents

- [ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-DeploymentNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest.DeploymentNameFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-IdFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest.IdFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest.ProjectNameFieldNumber')
  - [DeploymentName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-DeploymentName 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest.DeploymentName')
  - [Id](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-Id 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest.Id')
  - [ProjectName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-ProjectName 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest.ProjectName')
- [ConfirmUploadResponse](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadResponse 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadResponse')
  - [SnapshotFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadResponse-SnapshotFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadResponse.SnapshotFieldNumber')
- [GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-DeploymentNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest.DeploymentNameFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-IdFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest.IdFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest.ProjectNameFieldNumber')
  - [DeploymentName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-DeploymentName 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest.DeploymentName')
  - [Id](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-Id 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest.Id')
  - [ProjectName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-ProjectName 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest.ProjectName')
- [GetSnapshotResponse](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotResponse 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotResponse')
  - [SnapshotFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotResponse-SnapshotFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotResponse.SnapshotFieldNumber')
- [ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-DeploymentNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.DeploymentNameFieldNumber')
  - [PageSizeFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageSizeFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.PageSizeFieldNumber')
  - [PageTokenFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageTokenFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.PageTokenFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.ProjectNameFieldNumber')
  - [DeploymentName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-DeploymentName 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.DeploymentName')
  - [PageSize](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageSize 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.PageSize')
  - [PageToken](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageToken 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.PageToken')
  - [ProjectName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-ProjectName 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest.ProjectName')
- [ListSnapshotsResponse](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsResponse')
  - [NextPageTokenFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-NextPageTokenFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsResponse.NextPageTokenFieldNumber')
  - [SnapshotFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-SnapshotFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsResponse.SnapshotFieldNumber')
  - [NextPageToken](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-NextPageToken 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsResponse.NextPageToken')
  - [GetEnumerator()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-GetEnumerator 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsResponse.GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-System#Collections#IEnumerable#GetEnumerator 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsResponse.System#Collections#IEnumerable#GetEnumerator')
- [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot')
  - [ChecksumFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-ChecksumFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.ChecksumFieldNumber')
  - [CreateTimeFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-CreateTimeFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.CreateTimeFieldNumber')
  - [DeploymentNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DeploymentNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.DeploymentNameFieldNumber')
  - [DownloadUrlFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DownloadUrlFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.DownloadUrlFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-IdFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.IdFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-ProjectNameFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.ProjectNameFieldNumber')
  - [SizeFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-SizeFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.SizeFieldNumber')
  - [TagsFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-TagsFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.TagsFieldNumber')
  - [Checksum](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Checksum 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.Checksum')
  - [CreateTime](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-CreateTime 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.CreateTime')
  - [DeploymentName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DeploymentName 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.DeploymentName')
  - [DownloadUrl](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DownloadUrl 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.DownloadUrl')
  - [Id](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Id 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.Id')
  - [ProjectName](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-ProjectName 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.ProjectName')
  - [Size](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Size 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.Size')
  - [Tags](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Tags 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot.Tags')
- [SnapshotReflection](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotReflection 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotReflection')
  - [Descriptor](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotReflection-Descriptor 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotReflection.Descriptor')
- [SnapshotService](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService')
  - [Descriptor](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-Descriptor 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.Descriptor')
  - [BindService(serviceImpl)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-BindService-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.BindService(Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase)')
  - [BindService(serviceBinder,serviceImpl)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.BindService(Grpc.Core.ServiceBinderBase,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase)')
- [SnapshotServiceBase](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase')
  - [ConfirmUpload(request,context)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase.ConfirmUpload(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Grpc.Core.ServerCallContext)')
  - [GetSnapshot(request,context)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase.GetSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Grpc.Core.ServerCallContext)')
  - [ListSnapshots(request,context)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase.ListSnapshots(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Grpc.Core.ServerCallContext)')
  - [TakeSnapshot(request,context)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase.TakeSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Grpc.Core.ServerCallContext)')
  - [UploadSnapshot(request,context)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase.UploadSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Grpc.Core.ServerCallContext)')
- [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient')
- [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient')
  - [#ctor(channel)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor-Grpc-Core-Channel- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.#ctor(Grpc.Core.Channel)')
  - [#ctor(callInvoker)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor-Grpc-Core-CallInvoker- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.#ctor(Grpc.Core.CallInvoker)')
  - [#ctor()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.#ctor')
  - [#ctor(configuration)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.#ctor(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [DefaultEndpoint](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-DefaultEndpoint 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.DefaultEndpoint')
  - [DefaultScopes](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-DefaultScopes 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.DefaultScopes')
  - [GrpcClient](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GrpcClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GrpcClient')
  - [TakeSnapshotOperationsClient](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotOperationsClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.TakeSnapshotOperationsClient')
  - [ConfirmUpload(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ConfirmUpload(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ConfirmUpload(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ConfirmUpload(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Grpc.Core.CallOptions)')
  - [ConfirmUploadAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ConfirmUploadAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ConfirmUploadAsync(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ConfirmUploadAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Grpc.Core.CallOptions)')
  - [CreateOperationsClient()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-CreateOperationsClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.CreateOperationsClient')
  - [GetSnapshot(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.GetSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetSnapshot(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.GetSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Grpc.Core.CallOptions)')
  - [GetSnapshotAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.GetSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetSnapshotAsync(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.GetSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Grpc.Core.CallOptions)')
  - [ListSnapshots(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ListSnapshots(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ListSnapshots(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ListSnapshots(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Grpc.Core.CallOptions)')
  - [ListSnapshotsAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ListSnapshotsAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ListSnapshotsAsync(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.ListSnapshotsAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Grpc.Core.CallOptions)')
  - [NewInstance()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.NewInstance(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [TakeSnapshot(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.TakeSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [TakeSnapshot(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.TakeSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Grpc.Core.CallOptions)')
  - [TakeSnapshotAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.TakeSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [TakeSnapshotAsync(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.TakeSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Grpc.Core.CallOptions)')
  - [UploadSnapshot(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.UploadSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [UploadSnapshot(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.UploadSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Grpc.Core.CallOptions)')
  - [UploadSnapshotAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [UploadSnapshotAsync(request,options)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Grpc.Core.CallOptions)')
  - [ConfirmUpload(projectName,deploymentName,id,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUpload-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ConfirmUpload(System.String,System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [ConfirmUpload(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ConfirmUpload(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ConfirmUploadAsync(projectName,deploymentName,id,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ConfirmUploadAsync(System.String,System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [ConfirmUploadAsync(projectName,deploymentName,id,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-System-String,System-String,System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ConfirmUploadAsync(System.String,System.String,System.String,System.Threading.CancellationToken)')
  - [ConfirmUploadAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ConfirmUploadAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ConfirmUploadAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ConfirmUploadAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,System.Threading.CancellationToken)')
  - [Create(endpoint,settings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
  - [Create(channel,settings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.Create(Grpc.Core.Channel,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
  - [Create(callInvoker,settings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.Create(Grpc.Core.CallInvoker,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
  - [CreateAsync(endpoint,settings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
  - [GetSnapshot(projectName,deploymentName,id,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshot-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GetSnapshot(System.String,System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [GetSnapshot(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GetSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetSnapshotAsync(projectName,deploymentName,id,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GetSnapshotAsync(System.String,System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [GetSnapshotAsync(projectName,deploymentName,id,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-System-String,System-String,System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GetSnapshotAsync(System.String,System.String,System.String,System.Threading.CancellationToken)')
  - [GetSnapshotAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GetSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetSnapshotAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.GetSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,System.Threading.CancellationToken)')
  - [ListSnapshots(projectName,deploymentName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshots-System-String,System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ListSnapshots(System.String,System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListSnapshots(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ListSnapshots(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListSnapshotsAsync(projectName,deploymentName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshotsAsync-System-String,System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ListSnapshotsAsync(System.String,System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListSnapshotsAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ListSnapshotsAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceTakeSnapshot(operationName,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-PollOnceTakeSnapshot-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.PollOnceTakeSnapshot(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [PollOnceTakeSnapshotAsync(operationName,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-PollOnceTakeSnapshotAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.PollOnceTakeSnapshotAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [ShutdownDefaultChannelsAsync()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ShutdownDefaultChannelsAsync 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.ShutdownDefaultChannelsAsync')
  - [TakeSnapshot(snapshot,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.TakeSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot,Google.Api.Gax.Grpc.CallSettings)')
  - [TakeSnapshot(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.TakeSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [TakeSnapshotAsync(snapshot,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.TakeSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot,Google.Api.Gax.Grpc.CallSettings)')
  - [TakeSnapshotAsync(snapshot,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.TakeSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot,System.Threading.CancellationToken)')
  - [TakeSnapshotAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.TakeSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshot(snapshot,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.UploadSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshot(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.UploadSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshotAsync(snapshot,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshotAsync(snapshot,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot,System.Threading.CancellationToken)')
  - [UploadSnapshotAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshotAsync(request,cancellationToken)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,System.Threading.CancellationToken)')
- [SnapshotServiceClientBuilder](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder')
  - [Settings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-Settings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder.Settings')
  - [Build()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-Build 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder.Build')
  - [BuildAsync()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-BuildAsync-System-Threading-CancellationToken- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder.BuildAsync(System.Threading.CancellationToken)')
  - [GetChannelPool()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-GetChannelPool 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder.GetChannelPool')
  - [GetDefaultEndpoint()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-GetDefaultEndpoint 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder.GetDefaultEndpoint')
  - [GetDefaultScopes()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-GetDefaultScopes 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientBuilder.GetDefaultScopes')
- [SnapshotServiceClientImpl](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl')
  - [#ctor(grpcClient,settings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-#ctor-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.#ctor(Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
  - [GrpcClient](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-GrpcClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.GrpcClient')
  - [TakeSnapshotOperationsClient](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-TakeSnapshotOperationsClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.TakeSnapshotOperationsClient')
  - [ConfirmUpload(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.ConfirmUpload(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ConfirmUploadAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.ConfirmUploadAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetSnapshot(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.GetSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetSnapshotAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.GetSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListSnapshots(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.ListSnapshots(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListSnapshotsAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.ListSnapshotsAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [TakeSnapshot(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.TakeSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [TakeSnapshotAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.TakeSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshot(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.UploadSnapshot(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UploadSnapshotAsync(request,callSettings)](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClientImpl.UploadSnapshotAsync(Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest,Google.Api.Gax.Grpc.CallSettings)')
- [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings')
  - [#ctor()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-#ctor 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.#ctor')
  - [ConfirmUploadSettings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-ConfirmUploadSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.ConfirmUploadSettings')
  - [GetSnapshotSettings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetSnapshotSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.GetSnapshotSettings')
  - [IdempotentRetryFilter](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-IdempotentRetryFilter 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.IdempotentRetryFilter')
  - [ListSnapshotsSettings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-ListSnapshotsSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.ListSnapshotsSettings')
  - [NonIdempotentRetryFilter](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-NonIdempotentRetryFilter 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.NonIdempotentRetryFilter')
  - [TakeSnapshotOperationsSettings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-TakeSnapshotOperationsSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.TakeSnapshotOperationsSettings')
  - [TakeSnapshotSettings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-TakeSnapshotSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.TakeSnapshotSettings')
  - [UploadSnapshotSettings](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-UploadSnapshotSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.UploadSnapshotSettings')
  - [Clone()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-Clone 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.Clone')
  - [GetDefault()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetDefault 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.GetDefault')
  - [GetDefaultRetryBackoff()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetDefaultRetryBackoff 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.GetDefaultRetryBackoff')
  - [GetDefaultTimeoutBackoff()](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetDefaultTimeoutBackoff 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings.GetDefaultTimeoutBackoff')
- [TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest')
  - [SnapshotFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest-SnapshotFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest.SnapshotFieldNumber')
  - [Snapshot](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest.Snapshot')
- [UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest')
  - [SnapshotFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest-SnapshotFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest.SnapshotFieldNumber')
  - [Snapshot](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest.Snapshot')
- [UploadSnapshotResponse](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotResponse')
  - [SnapshotFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-SnapshotFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotResponse.SnapshotFieldNumber')
  - [UploadUrlFieldNumber](#F-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-UploadUrlFieldNumber 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotResponse.UploadUrlFieldNumber')
  - [Snapshot](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotResponse.Snapshot')
  - [UploadUrl](#P-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-UploadUrl 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotResponse.UploadUrl')

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest'></a>
## ConfirmUploadRequest `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-Id'></a>
### Id `property`

##### Summary

The identifier for the uploaded snapshot.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadResponse'></a>
## ConfirmUploadResponse `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadResponse-SnapshotFieldNumber'></a>
### SnapshotFieldNumber `constants`

##### Summary

Field number for the "snapshot" field.

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest'></a>
## GetSnapshotRequest `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-Id'></a>
### Id `property`

##### Summary

The identifier for the snapshot.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotResponse'></a>
## GetSnapshotResponse `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotResponse-SnapshotFieldNumber'></a>
### SnapshotFieldNumber `constants`

##### Summary

Field number for the "snapshot" field.

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest'></a>
## ListSnapshotsRequest `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageSizeFieldNumber'></a>
### PageSizeFieldNumber `constants`

##### Summary

Field number for the "page_size" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageTokenFieldNumber'></a>
### PageTokenFieldNumber `constants`

##### Summary

Field number for the "page_token" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The deployment to list snapshots for.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageSize'></a>
### PageSize `property`

##### Summary

Optional. The number of snapshots to fetch in each page of the paginated results.
If provided, the \`page_size\` must be a positive integer. If omitted,
the default value of 20 is used.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-PageToken'></a>
### PageToken `property`

##### Summary

Optional. An opaque token to identify the start of the paginated results.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The name of the project to list snapshots for.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse'></a>
## ListSnapshotsResponse `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-NextPageTokenFieldNumber'></a>
### NextPageTokenFieldNumber `constants`

##### Summary

Field number for the "next_page_token" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-SnapshotFieldNumber'></a>
### SnapshotFieldNumber `constants`

##### Summary

Field number for the "snapshot" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-NextPageToken'></a>
### NextPageToken `property`

##### Summary

A token which you can supply to the \`ListSnapshot\` RPC to retrieve the next page of paginated
results.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the resources in this response.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsResponse-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot'></a>
## Snapshot `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-ChecksumFieldNumber'></a>
### ChecksumFieldNumber `constants`

##### Summary

Field number for the "checksum" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-CreateTimeFieldNumber'></a>
### CreateTimeFieldNumber `constants`

##### Summary

Field number for the "create_time" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DeploymentNameFieldNumber'></a>
### DeploymentNameFieldNumber `constants`

##### Summary

Field number for the "deployment_name" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DownloadUrlFieldNumber'></a>
### DownloadUrlFieldNumber `constants`

##### Summary

Field number for the "download_url" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-SizeFieldNumber'></a>
### SizeFieldNumber `constants`

##### Summary

Field number for the "size" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-TagsFieldNumber'></a>
### TagsFieldNumber `constants`

##### Summary

Field number for the "tags" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Checksum'></a>
### Checksum `property`

##### Summary

A checksum hash of the snapshot file. You can only supply this with \`UploadSnapshot\`.

 Currently, we only support base64 MD5 format.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-CreateTime'></a>
### CreateTime `property`

##### Summary

The time at which the snapshot was taken (either taken from a running deployment or
initiated by an upload). Read-only.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DeploymentName'></a>
### DeploymentName `property`

##### Summary

The deployment that the snapshot is associated with. You can only supply this with
 \`TakeSnapshot\` or \`UploadSnapshot\`.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-DownloadUrl'></a>
### DownloadUrl `property`

##### Summary

A download URL for the snapshot, which is valid for five minutes. Read-only.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Id'></a>
### Id `property`

##### Summary

A unique identifier for the snapshot. Read-only.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the snapshot is associated with. You can only supply this with
 \`TakeSnapshot\`or \`UploadSnapshot\`.

 It must conform to the regex: ^[a-z0-9_]{3,32}$

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Size'></a>
### Size `property`

##### Summary

The size of the snapshot in bytes. Read-only.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot-Tags'></a>
### Tags `property`

##### Summary

Tags associated with the snapshot. Tags are set of strings which you can use to identify
 deployments. You must supply this with \`TakeSnapshot\` or \`UploadSnapshot\`.

 It must conform to the regex: ^[a-zA-Z0-9_:.-]{2,32}$

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotReflection'></a>
## SnapshotReflection `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

##### Summary

Holder for reflection information generated from improbable/spatialos/snapshot/v1alpha1/snapshot.proto

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotReflection-Descriptor'></a>
### Descriptor `property`

##### Summary

File descriptor for improbable/spatialos/snapshot/v1alpha1/snapshot.proto

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService'></a>
## SnapshotService `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

##### Summary

SnapshotService provides methods for managing snapshots.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-Descriptor'></a>
### Descriptor `property`

##### Summary

Service descriptor

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-BindService-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-'></a>
### BindService(serviceImpl) `method`

##### Summary

Creates service definition that can be registered with a server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceImpl | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase') | An object implementing the server-side handling logic. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-'></a>
### BindService(serviceBinder,serviceImpl) `method`

##### Summary

Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
Note: this method is part of an experimental API that can change or be removed without any prior notice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBinder | [Grpc.Core.ServiceBinderBase](#T-Grpc-Core-ServiceBinderBase 'Grpc.Core.ServiceBinderBase') | Service methods will be bound by calling `AddMethod` on this object. |
| serviceImpl | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceBase') | An object implementing the server-side handling logic. |

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase'></a>
## SnapshotServiceBase `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService

##### Summary

Base class for server-side implementations of SnapshotService

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-ServerCallContext-'></a>
### ConfirmUpload(request,context) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-ServerCallContext-'></a>
### GetSnapshot(request,context) `method`

##### Summary

Gets a snapshot.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-ServerCallContext-'></a>
### ListSnapshots(request,context) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-ServerCallContext-'></a>
### TakeSnapshot(request,context) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceBase-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-ServerCallContext-'></a>
### UploadSnapshot(request,context) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient'></a>
## SnapshotServiceClient `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService

##### Summary

Client for SnapshotService

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient'></a>
## SnapshotServiceClient `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

##### Summary

SnapshotService client wrapper, for convenient use.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor-Grpc-Core-Channel-'></a>
### #ctor(channel) `constructor`

##### Summary

Creates a new client for SnapshotService

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The channel to use to make remote calls. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor-Grpc-Core-CallInvoker-'></a>
### #ctor(callInvoker) `constructor`

##### Summary

Creates a new client for SnapshotService that uses a custom `CallInvoker`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The callInvoker to use to make remote calls. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Protected parameterless constructor to allow creation of test doubles.

##### Parameters

This constructor has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Protected constructor to allow creation of configured clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Grpc.Core.ClientBase.ClientBaseConfiguration](#T-Grpc-Core-ClientBase-ClientBaseConfiguration 'Grpc.Core.ClientBase.ClientBaseConfiguration') | The client configuration. |

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-DefaultEndpoint'></a>
### DefaultEndpoint `property`

##### Summary

The default endpoint for the SnapshotService service, which is a host of "platform.api.improbable.io" and a port of 443.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-DefaultScopes'></a>
### DefaultScopes `property`

##### Summary

The default SnapshotService scopes.

##### Remarks

The default SnapshotService scopes are:

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC SnapshotService client.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotOperationsClient'></a>
### TakeSnapshotOperationsClient `property`

##### Summary

The long-running operations client for `TakeSnapshot`.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ConfirmUpload(request,headers,deadline,cancellationToken) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-CallOptions-'></a>
### ConfirmUpload(request,options) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ConfirmUploadAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Grpc-Core-CallOptions-'></a>
### ConfirmUploadAsync(request,options) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-CreateOperationsClient'></a>
### CreateOperationsClient() `method`

##### Summary

Creates a new instance of [OperationsClient](#T-Google-LongRunning-Operations-OperationsClient 'Google.LongRunning.Operations.OperationsClient') using the same call invoker as this client.

##### Returns

A new Operations client for the same target as this client.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetSnapshot(request,headers,deadline,cancellationToken) `method`

##### Summary

Gets a snapshot.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-CallOptions-'></a>
### GetSnapshot(request,options) `method`

##### Summary

Gets a snapshot.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetSnapshotAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Gets a snapshot.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Grpc-Core-CallOptions-'></a>
### GetSnapshotAsync(request,options) `method`

##### Summary

Gets a snapshot.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ListSnapshots(request,headers,deadline,cancellationToken) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-CallOptions-'></a>
### ListSnapshots(request,options) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ListSnapshotsAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Grpc-Core-CallOptions-'></a>
### ListSnapshotsAsync(request,options) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### NewInstance() `method`

##### Summary

Creates a new instance of client from given `ClientBaseConfiguration`.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### TakeSnapshot(request,headers,deadline,cancellationToken) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-CallOptions-'></a>
### TakeSnapshot(request,options) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### TakeSnapshotAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Grpc-Core-CallOptions-'></a>
### TakeSnapshotAsync(request,options) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### UploadSnapshot(request,headers,deadline,cancellationToken) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-CallOptions-'></a>
### UploadSnapshot(request,options) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### UploadSnapshotAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Grpc-Core-CallOptions-'></a>
### UploadSnapshotAsync(request,options) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUpload-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### ConfirmUpload(projectName,deploymentName,id,callSettings) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
 it available for use in a deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier for the uploaded snapshot. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ConfirmUpload(request,callSettings) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### ConfirmUploadAsync(projectName,deploymentName,id,callSettings) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
 it available for use in a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier for the uploaded snapshot. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-System-String,System-String,System-String,System-Threading-CancellationToken-'></a>
### ConfirmUploadAsync(projectName,deploymentName,id,cancellationToken) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
 it available for use in a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier for the uploaded snapshot. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ConfirmUploadAsync(request,callSettings) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,System-Threading-CancellationToken-'></a>
### ConfirmUploadAsync(request,cancellationToken) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-'></a>
### Create(endpoint,settings) `method`

##### Summary

Synchronously creates a [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The created [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') | Optional [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.Snapshot.V1Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
SnapshotServiceClient client = SnapshotServiceClient.Create();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.Snapshot.V1Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    SnapshotServiceClient.DefaultEndpoint.Host, SnapshotServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
SnapshotServiceClient client = SnapshotServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
channel.ShutdownAsync().Wait();
```

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-'></a>
### Create(channel,settings) `method`

##### Summary

Creates a [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') which uses the specified channel for remote operations.

##### Returns

The created [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The [Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') | Optional [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings'). |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-'></a>
### Create(callInvoker,settings) `method`

##### Summary

Creates a [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') which uses the specified call invoker for remote operations.

##### Returns

The created [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The [CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') | Optional [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings'). |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-'></a>
### CreateAsync(endpoint,settings) `method`

##### Summary

Asynchronously creates a [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The task representing the created [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') | Optional [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.Snapshot.V1Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
SnapshotServiceClient client = await SnapshotServiceClient.CreateAsync();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.Snapshot.V1Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    SnapshotServiceClient.DefaultEndpoint.Host, SnapshotServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
SnapshotServiceClient client = SnapshotServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
await channel.ShutdownAsync();
```

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshot-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetSnapshot(projectName,deploymentName,id,callSettings) `method`

##### Summary

Gets a snapshot.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier for the snapshot. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetSnapshot(request,callSettings) `method`

##### Summary

Gets a snapshot.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetSnapshotAsync(projectName,deploymentName,id,callSettings) `method`

##### Summary

Gets a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier for the snapshot. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-System-String,System-String,System-String,System-Threading-CancellationToken-'></a>
### GetSnapshotAsync(projectName,deploymentName,id,cancellationToken) `method`

##### Summary

Gets a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment the snapshot belongs to.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier for the snapshot. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetSnapshotAsync(request,callSettings) `method`

##### Summary

Gets a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,System-Threading-CancellationToken-'></a>
### GetSnapshotAsync(request,cancellationToken) `method`

##### Summary

Gets a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshots-System-String,System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListSnapshots(projectName,deploymentName,pageToken,pageSize,callSettings) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
 (descending).

##### Returns

A pageable sequence of [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project to list snapshots for.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment to list snapshots for.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
 A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
 A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListSnapshots(request,callSettings) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

A pageable sequence of [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshotsAsync-System-String,System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListSnapshotsAsync(projectName,deploymentName,pageToken,pageSize,callSettings) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
 (descending).

##### Returns

A pageable asynchronous sequence of [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project to list snapshots for.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| deploymentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The deployment to list snapshots for.

 It must conform to the regex: ^[a-z0-9_]{3,32}$ |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
 A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
 A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListSnapshotsAsync(request,callSettings) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

A pageable asynchronous sequence of [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-PollOnceTakeSnapshot-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceTakeSnapshot(operationName,callSettings) `method`

##### Summary

Poll an operation once, using an `operationName` from a previous invocation of `TakeSnapshot`.

##### Returns

The result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-PollOnceTakeSnapshotAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### PollOnceTakeSnapshotAsync(operationName,callSettings) `method`

##### Summary

Asynchronously poll an operation once, using an `operationName` from a previous invocation of `TakeSnapshotAsync`.

##### Returns

A task representing the result of polling the operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a previously invoked operation. Must not be `null` or empty. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-ShutdownDefaultChannelsAsync'></a>
### ShutdownDefaultChannelsAsync() `method`

##### Summary

Shuts down any channels automatically created by [Create](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)'). Channels which weren't automatically
created are not affected.

##### Returns

A task representing the asynchronous shutdown operation.

##### Parameters

This method has no parameters.

##### Remarks

After calling this method, further calls to [Create](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings- 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings)') will create new channels, which could
in turn be shut down by another call to this method.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings-'></a>
### TakeSnapshot(snapshot,callSettings) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshot | [Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') | These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### TakeSnapshot(request,callSettings) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings-'></a>
### TakeSnapshotAsync(snapshot,callSettings) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshot | [Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') | These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,System-Threading-CancellationToken-'></a>
### TakeSnapshotAsync(snapshot,cancellationToken) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshot | [Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') | These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### TakeSnapshotAsync(request,callSettings) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings-'></a>
### UploadSnapshot(snapshot,callSettings) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshot | [Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') | These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`
 - \`checksum\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UploadSnapshot(request,callSettings) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,Google-Api-Gax-Grpc-CallSettings-'></a>
### UploadSnapshotAsync(snapshot,callSettings) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshot | [Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') | These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`
 - \`checksum\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot,System-Threading-CancellationToken-'></a>
### UploadSnapshotAsync(snapshot,cancellationToken) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshot | [Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') | These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`
 - \`checksum\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UploadSnapshotAsync(request,callSettings) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,System-Threading-CancellationToken-'></a>
### UploadSnapshotAsync(request,cancellationToken) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder'></a>
## SnapshotServiceClientBuilder `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

##### Summary

Builder class for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') to provide simple configuration of credentials, endpoint etc.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-Settings'></a>
### Settings `property`

##### Summary

The settings to use for RPCs, or null for the default settings.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-Build'></a>
### Build() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-BuildAsync-System-Threading-CancellationToken-'></a>
### BuildAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-GetChannelPool'></a>
### GetChannelPool() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-GetDefaultEndpoint'></a>
### GetDefaultEndpoint() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientBuilder-GetDefaultScopes'></a>
### GetDefaultScopes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl'></a>
## SnapshotServiceClientImpl `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

##### Summary

SnapshotService client wrapper implementation, for convenient use.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-#ctor-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient,Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-'></a>
### #ctor(grpcClient,settings) `constructor`

##### Summary

Constructs a client wrapper for the SnapshotService service, with the specified gRPC client and settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| grpcClient | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotService-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotService.SnapshotServiceClient') | The underlying gRPC client. |
| settings | [Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') | The base [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') used within this client |

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC SnapshotService client.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-TakeSnapshotOperationsClient'></a>
### TakeSnapshotOperationsClient `property`

##### Summary

The long-running operations client for `TakeSnapshot`.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ConfirmUpload-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ConfirmUpload(request,callSettings) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ConfirmUploadAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ConfirmUploadAsync(request,callSettings) `method`

##### Summary

Confirms that a snapshot is uploaded to the URL allocated by the \`UploadSnapshot\` RPC and makes
it available for use in a deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ConfirmUploadRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ConfirmUploadRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-GetSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetSnapshot(request,callSettings) `method`

##### Summary

Gets a snapshot.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-GetSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetSnapshotAsync(request,callSettings) `method`

##### Summary

Gets a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-GetSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.GetSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ListSnapshots-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListSnapshots(request,callSettings) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

A pageable sequence of [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-ListSnapshotsAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListSnapshotsAsync(request,callSettings) `method`

##### Summary

Lists snapshots under a deployment. By default, snapshots are sorted by creation time
(descending).

##### Returns

A pageable asynchronous sequence of [Snapshot](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-Snapshot 'Improbable.SpatialOS.Snapshot.V1Alpha1.Snapshot') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-ListSnapshotsRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.ListSnapshotsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-TakeSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### TakeSnapshot(request,callSettings) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-TakeSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### TakeSnapshotAsync(request,callSettings) `method`

##### Summary

Takes a snapshot. You can only take snapshots of running deployments.

 The returned operation result is of type \`snapshot\` upon successfully taking a snapshot.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.TakeSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-UploadSnapshot-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UploadSnapshot(request,callSettings) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClientImpl-UploadSnapshotAsync-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UploadSnapshotAsync(request,callSettings) `method`

##### Summary

Allocates space and returns a URL to upload a snapshot to.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest 'Improbable.SpatialOS.Snapshot.V1Alpha1.UploadSnapshotRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings'></a>
## SnapshotServiceSettings `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

##### Summary

Settings for a [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient').

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') object with default settings.

##### Parameters

This constructor has no parameters.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-ConfirmUploadSettings'></a>
### ConfirmUploadSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`SnapshotServiceClient.ConfirmUpload` and `SnapshotServiceClient.ConfirmUploadAsync`.

##### Remarks

The default `SnapshotServiceClient.ConfirmUpload` and
`SnapshotServiceClient.ConfirmUploadAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetSnapshotSettings'></a>
### GetSnapshotSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`SnapshotServiceClient.GetSnapshot` and `SnapshotServiceClient.GetSnapshotAsync`.

##### Remarks

The default `SnapshotServiceClient.GetSnapshot` and
`SnapshotServiceClient.GetSnapshotAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-IdempotentRetryFilter'></a>
### IdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "Idempotent" [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods.

##### Remarks

The eligible RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s for retry for "Idempotent" RPC methods are:

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-ListSnapshotsSettings'></a>
### ListSnapshotsSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`SnapshotServiceClient.ListSnapshots` and `SnapshotServiceClient.ListSnapshotsAsync`.

##### Remarks

The default `SnapshotServiceClient.ListSnapshots` and
`SnapshotServiceClient.ListSnapshotsAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-NonIdempotentRetryFilter'></a>
### NonIdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "NonIdempotent" [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods.

##### Remarks

There are no RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s eligible for retry for "NonIdempotent" RPC methods.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-TakeSnapshotOperationsSettings'></a>
### TakeSnapshotOperationsSettings `property`

##### Summary

Long Running Operation settings for calls to `SnapshotServiceClient.TakeSnapshot`.

##### Remarks

Uses default [PollSettings](#T-Google-Api-Gax-PollSettings 'Google.Api.Gax.PollSettings') of:

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-TakeSnapshotSettings'></a>
### TakeSnapshotSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`SnapshotServiceClient.TakeSnapshot` and `SnapshotServiceClient.TakeSnapshotAsync`.

##### Remarks

The default `SnapshotServiceClient.TakeSnapshot` and
`SnapshotServiceClient.TakeSnapshotAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-UploadSnapshotSettings'></a>
### UploadSnapshotSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`SnapshotServiceClient.UploadSnapshot` and `SnapshotServiceClient.UploadSnapshotAsync`.

##### Remarks

The default `SnapshotServiceClient.UploadSnapshot` and
`SnapshotServiceClient.UploadSnapshotAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-Clone'></a>
### Clone() `method`

##### Summary

Creates a deep clone of this object, with all the same property values.

##### Returns

A deep clone of this [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings') object.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetDefault'></a>
### GetDefault() `method`

##### Summary

Get a new instance of the default [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings').

##### Returns

A new instance of the default [SnapshotServiceSettings](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceSettings').

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetDefaultRetryBackoff'></a>
### GetDefaultRetryBackoff() `method`

##### Summary

"Default" retry backoff for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods.

##### Returns

The "Default" retry backoff for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" retry backoff for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods is defined as:

<a name='M-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceSettings-GetDefaultTimeoutBackoff'></a>
### GetDefaultTimeoutBackoff() `method`

##### Summary

"Default" timeout backoff for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods.

##### Returns

The "Default" timeout backoff for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" timeout backoff for [SnapshotServiceClient](#T-Improbable-SpatialOS-Snapshot-V1Alpha1-SnapshotServiceClient 'Improbable.SpatialOS.Snapshot.V1Alpha1.SnapshotServiceClient') RPC methods is defined as:

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest'></a>
## TakeSnapshotRequest `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest-SnapshotFieldNumber'></a>
### SnapshotFieldNumber `constants`

##### Summary

Field number for the "snapshot" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-TakeSnapshotRequest-Snapshot'></a>
### Snapshot `property`

##### Summary

These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored.

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest'></a>
## UploadSnapshotRequest `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest-SnapshotFieldNumber'></a>
### SnapshotFieldNumber `constants`

##### Summary

Field number for the "snapshot" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotRequest-Snapshot'></a>
### Snapshot `property`

##### Summary

These fields are mandatory:
 - \`project_name\`
 - \`deployment_name\`
 - \`checksum\`

 These fields are optional:
 - \`tags\`

 Other set values will be ignored.

<a name='T-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse'></a>
## UploadSnapshotResponse `type`

##### Namespace

Improbable.SpatialOS.Snapshot.V1Alpha1

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-SnapshotFieldNumber'></a>
### SnapshotFieldNumber `constants`

##### Summary

Field number for the "snapshot" field.

<a name='F-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-UploadUrlFieldNumber'></a>
### UploadUrlFieldNumber `constants`

##### Summary

Field number for the "upload_url" field.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-Snapshot'></a>
### Snapshot `property`

##### Summary

The created snapshot.

<a name='P-Improbable-SpatialOS-Snapshot-V1Alpha1-UploadSnapshotResponse-UploadUrl'></a>
### UploadUrl `property`

##### Summary

A URL to accept the snapshot's contents.

 You should supply the contents in the body of an HTTP POST request.
