<a name='assembly'></a>
# Improbable.SpatialOS.Platform.ServiceAccount.V1Alpha1

## Contents

- [CreateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest')
  - [LifetimeFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-LifetimeFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.LifetimeFieldNumber')
  - [NameFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-NameFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.NameFieldNumber')
  - [PermissionsFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-PermissionsFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.PermissionsFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.ProjectNameFieldNumber')
  - [Lifetime](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-Lifetime 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.Lifetime')
  - [Name](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-Name 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.Name')
  - [Permissions](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-Permissions 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.Permissions')
  - [ProjectName](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-ProjectName 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest.ProjectName')
- [DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest')
  - [IdFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest-IdFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest.IdFieldNumber')
  - [Id](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest-Id 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest.Id')
- [ListServiceAccountsRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest')
  - [PageSizeFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageSizeFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest.PageSizeFieldNumber')
  - [PageTokenFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageTokenFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest.PageTokenFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest.ProjectNameFieldNumber')
  - [PageSize](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageSize 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest.PageSize')
  - [PageToken](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageToken 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest.PageToken')
  - [ProjectName](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-ProjectName 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest.ProjectName')
- [ListServiceAccountsResponse](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsResponse')
  - [NextPageTokenFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-NextPageTokenFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsResponse.NextPageTokenFieldNumber')
  - [ServiceAccountsFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-ServiceAccountsFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsResponse.ServiceAccountsFieldNumber')
  - [NextPageToken](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-NextPageToken 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsResponse.NextPageToken')
  - [GetEnumerator()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-GetEnumerator 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsResponse.GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-System#Collections#IEnumerable#GetEnumerator 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsResponse.System#Collections#IEnumerable#GetEnumerator')
- [Permission](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission')
  - [PartsFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission-PartsFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission.PartsFieldNumber')
  - [VerbsFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission-VerbsFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission.VerbsFieldNumber')
- [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount')
  - [CreationTimeFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-CreationTimeFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.CreationTimeFieldNumber')
  - [ExpirationTimeFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-ExpirationTimeFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.ExpirationTimeFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-IdFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.IdFieldNumber')
  - [NameFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-NameFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.NameFieldNumber')
  - [PermissionsFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-PermissionsFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.PermissionsFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-ProjectNameFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.ProjectNameFieldNumber')
  - [TokenFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-TokenFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.TokenFieldNumber')
  - [CreationTime](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-CreationTime 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.CreationTime')
  - [Id](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Id 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.Id')
  - [Name](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Name 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.Name')
  - [Permissions](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Permissions 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.Permissions')
  - [ProjectName](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-ProjectName 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.ProjectName')
  - [Token](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Token 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount.Token')
- [ServiceAccountService](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService')
  - [Descriptor](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-Descriptor 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.Descriptor')
  - [BindService(serviceImpl)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-BindService-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.BindService(Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase)')
  - [BindService(serviceBinder,serviceImpl)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.BindService(Grpc.Core.ServiceBinderBase,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase)')
- [ServiceAccountServiceBase](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase')
  - [DeleteServiceAccount(request,context)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase.DeleteServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Grpc.Core.ServerCallContext)')
  - [UpdateServiceAccount(request,context)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase.UpdateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Grpc.Core.ServerCallContext)')
- [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient')
- [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient')
  - [#ctor(channel)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor-Grpc-Core-Channel- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.#ctor(Grpc.Core.Channel)')
  - [#ctor(callInvoker)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor-Grpc-Core-CallInvoker- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.#ctor(Grpc.Core.CallInvoker)')
  - [#ctor()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.#ctor')
  - [#ctor(configuration)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.#ctor(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [DefaultEndpoint](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DefaultEndpoint 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DefaultEndpoint')
  - [DefaultScopes](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DefaultScopes 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DefaultScopes')
  - [GrpcClient](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-GrpcClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.GrpcClient')
  - [DeleteServiceAccount(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.DeleteServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DeleteServiceAccount(request,options)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.DeleteServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Grpc.Core.CallOptions)')
  - [DeleteServiceAccountAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.DeleteServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DeleteServiceAccountAsync(request,options)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.DeleteServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Grpc.Core.CallOptions)')
  - [NewInstance()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.NewInstance(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [UpdateServiceAccount(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.UpdateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [UpdateServiceAccount(request,options)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.UpdateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Grpc.Core.CallOptions)')
  - [UpdateServiceAccountAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.UpdateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [UpdateServiceAccountAsync(request,options)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient.UpdateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Grpc.Core.CallOptions)')
  - [Create(endpoint,settings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
  - [Create(channel,settings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.Create(Grpc.Core.Channel,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
  - [Create(callInvoker,settings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.Create(Grpc.Core.CallInvoker,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
  - [CreateAsync(endpoint,settings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
  - [CreateServiceAccount(projectName,name,permissions,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccount-System-String,System-String,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateServiceAccount(System.String,System.String,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission},Google.Api.Gax.Grpc.CallSettings)')
  - [CreateServiceAccount(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateServiceAccountAsync(projectName,name,permissions,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-System-String,System-String,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateServiceAccountAsync(System.String,System.String,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission},Google.Api.Gax.Grpc.CallSettings)')
  - [CreateServiceAccountAsync(projectName,name,permissions,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-System-String,System-String,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateServiceAccountAsync(System.String,System.String,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission},System.Threading.CancellationToken)')
  - [CreateServiceAccountAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateServiceAccountAsync(request,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest,System.Threading.CancellationToken)')
  - [DeleteServiceAccount(id,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccount-System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DeleteServiceAccount(System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteServiceAccount(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DeleteServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteServiceAccountAsync(id,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-System-Int64,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DeleteServiceAccountAsync(System.Int64,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteServiceAccountAsync(id,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-System-Int64,System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DeleteServiceAccountAsync(System.Int64,System.Threading.CancellationToken)')
  - [DeleteServiceAccountAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DeleteServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteServiceAccountAsync(request,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.DeleteServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,System.Threading.CancellationToken)')
  - [ListServiceAccounts(projectName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccounts-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.ListServiceAccounts(System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListServiceAccounts(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccounts-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.ListServiceAccounts(Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListServiceAccountsAsync(projectName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccountsAsync-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.ListServiceAccountsAsync(System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListServiceAccountsAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccountsAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.ListServiceAccountsAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ShutdownDefaultChannelsAsync()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ShutdownDefaultChannelsAsync 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.ShutdownDefaultChannelsAsync')
  - [UpdateServiceAccount(id,expirationTime,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccount-System-Int64,Google-Protobuf-WellKnownTypes-Timestamp,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccount(System.Int64,Google.Protobuf.WellKnownTypes.Timestamp,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccount(id,permissions,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccount-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccount(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission},Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccount(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccountAsync(id,expirationTime,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,Google-Protobuf-WellKnownTypes-Timestamp,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccountAsync(System.Int64,Google.Protobuf.WellKnownTypes.Timestamp,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccountAsync(id,expirationTime,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,Google-Protobuf-WellKnownTypes-Timestamp,System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccountAsync(System.Int64,Google.Protobuf.WellKnownTypes.Timestamp,System.Threading.CancellationToken)')
  - [UpdateServiceAccountAsync(id,permissions,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccountAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission},Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccountAsync(id,permissions,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccountAsync(System.Int64,System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission},System.Threading.CancellationToken)')
  - [UpdateServiceAccountAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccountAsync(request,cancellationToken)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.UpdateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,System.Threading.CancellationToken)')
- [ServiceAccountServiceClientBuilder](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder')
  - [Settings](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-Settings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder.Settings')
  - [Build()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-Build 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder.Build')
  - [BuildAsync()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-BuildAsync-System-Threading-CancellationToken- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder.BuildAsync(System.Threading.CancellationToken)')
  - [GetChannelPool()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-GetChannelPool 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder.GetChannelPool')
  - [GetDefaultEndpoint()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-GetDefaultEndpoint 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder.GetDefaultEndpoint')
  - [GetDefaultScopes()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-GetDefaultScopes 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientBuilder.GetDefaultScopes')
- [ServiceAccountServiceClientImpl](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl')
  - [#ctor(grpcClient,settings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-#ctor-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.#ctor(Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
  - [GrpcClient](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-GrpcClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.GrpcClient')
  - [CreateServiceAccount(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-CreateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.CreateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateServiceAccountAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-CreateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.CreateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteServiceAccount(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.DeleteServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DeleteServiceAccountAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.DeleteServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListServiceAccounts(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-ListServiceAccounts-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.ListServiceAccounts(Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListServiceAccountsAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-ListServiceAccountsAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.ListServiceAccountsAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccount(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.UpdateServiceAccount(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateServiceAccountAsync(request,callSettings)](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClientImpl.UpdateServiceAccountAsync(Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest,Google.Api.Gax.Grpc.CallSettings)')
- [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings')
  - [#ctor()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-#ctor 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.#ctor')
  - [CreateServiceAccountSettings](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-CreateServiceAccountSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.CreateServiceAccountSettings')
  - [DeleteServiceAccountSettings](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-DeleteServiceAccountSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.DeleteServiceAccountSettings')
  - [IdempotentRetryFilter](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-IdempotentRetryFilter 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.IdempotentRetryFilter')
  - [ListServiceAccountsSettings](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-ListServiceAccountsSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.ListServiceAccountsSettings')
  - [NonIdempotentRetryFilter](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-NonIdempotentRetryFilter 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.NonIdempotentRetryFilter')
  - [UpdateServiceAccountSettings](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-UpdateServiceAccountSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.UpdateServiceAccountSettings')
  - [Clone()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-Clone 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.Clone')
  - [GetDefault()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-GetDefault 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.GetDefault')
  - [GetDefaultRetryBackoff()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-GetDefaultRetryBackoff 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.GetDefaultRetryBackoff')
  - [GetDefaultTimeoutBackoff()](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-GetDefaultTimeoutBackoff 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings.GetDefaultTimeoutBackoff')
- [ServiceaccountReflection](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceaccountReflection 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceaccountReflection')
  - [Descriptor](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceaccountReflection-Descriptor 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceaccountReflection.Descriptor')
- [Types](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission-Types 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission.Types')
- [UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest')
  - [ExpirationTimeFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-ExpirationTimeFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest.ExpirationTimeFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-IdFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest.IdFieldNumber')
  - [PermissionsFieldNumber](#F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-PermissionsFieldNumber 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest.PermissionsFieldNumber')
  - [ExpirationTime](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-ExpirationTime 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest.ExpirationTime')
  - [Id](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-Id 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest.Id')
  - [Permissions](#P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-Permissions 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest.Permissions')

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest'></a>
## CreateServiceAccountRequest `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

A request to create a new service account.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-LifetimeFieldNumber'></a>
### LifetimeFieldNumber `constants`

##### Summary

Field number for the "lifetime" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-NameFieldNumber'></a>
### NameFieldNumber `constants`

##### Summary

Field number for the "name" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-PermissionsFieldNumber'></a>
### PermissionsFieldNumber `constants`

##### Summary

Field number for the "permissions" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-Lifetime'></a>
### Lifetime `property`

##### Summary

The lifetime of the service account. If not specified, then the new service account
will have a default lifetime of 30 days. This value cannot be larger than 90 days.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-Name'></a>
### Name `property`

##### Summary

The name of the service account.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-Permissions'></a>
### Permissions `property`

##### Summary

The service account's scope.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The name of the project associated with the service account.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest'></a>
## DeleteServiceAccountRequest `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest-Id'></a>
### Id `property`

##### Summary

ID of the service account to delete.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest'></a>
## ListServiceAccountsRequest `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

A request used to list all the service accounts you have permission to view.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageSizeFieldNumber'></a>
### PageSizeFieldNumber `constants`

##### Summary

Field number for the "page_size" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageTokenFieldNumber'></a>
### PageTokenFieldNumber `constants`

##### Summary

Field number for the "page_token" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageSize'></a>
### PageSize `property`

##### Summary

The maximum number of service accounts to return in the response.
If unspecified this will be 20 results per page.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-PageToken'></a>
### PageToken `property`

##### Summary

The token to identify the starting point of the request.
An empty or invalid token defaults to listing from the start.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The name of the project whose service accounts should be listed. You must have access to this
project.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse'></a>
## ListServiceAccountsResponse `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-NextPageTokenFieldNumber'></a>
### NextPageTokenFieldNumber `constants`

##### Summary

Field number for the "next_page_token" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-ServiceAccountsFieldNumber'></a>
### ServiceAccountsFieldNumber `constants`

##### Summary

Field number for the "service_accounts" field.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-NextPageToken'></a>
### NextPageToken `property`

##### Summary

A token you can supply to the ListDeployments RPC to retrieve the next page of
paginated results.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the resources in this response.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsResponse-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission'></a>
## Permission `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

EXAMPLE:  For the permission, [r,w]:prj/gamex
[r,w]     represented by READ, WRITE    VERBs
prj/gamex represented by "prj", "gamex" PARTs

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission-PartsFieldNumber'></a>
### PartsFieldNumber `constants`

##### Summary

Field number for the "parts" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission-VerbsFieldNumber'></a>
### VerbsFieldNumber `constants`

##### Summary

Field number for the "verbs" field.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount'></a>
## ServiceAccount `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

A representation of service account containing the information required to display them to a
user.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-CreationTimeFieldNumber'></a>
### CreationTimeFieldNumber `constants`

##### Summary

Field number for the "creation_time" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-ExpirationTimeFieldNumber'></a>
### ExpirationTimeFieldNumber `constants`

##### Summary

Field number for the "expiration_time" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-NameFieldNumber'></a>
### NameFieldNumber `constants`

##### Summary

Field number for the "name" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-PermissionsFieldNumber'></a>
### PermissionsFieldNumber `constants`

##### Summary

Field number for the "permissions" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-TokenFieldNumber'></a>
### TokenFieldNumber `constants`

##### Summary

Field number for the "token" field.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-CreationTime'></a>
### CreationTime `property`

##### Summary

Creation and expiration time of the service account token. Expiration time optional, if
non-expiring.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Id'></a>
### Id `property`

##### Summary

The unique service account id.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Name'></a>
### Name `property`

##### Summary

The name of the service account.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Permissions'></a>
### Permissions `property`

##### Summary

The service account's scope, as \`Permission\`s.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-ProjectName'></a>
### ProjectName `property`

##### Summary

The name of the project associated with the service account.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount-Token'></a>
### Token `property`

##### Summary

A refresh token representing the created service account.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService'></a>
## ServiceAccountService `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

ServiceAccountService provides methods for managing service accounts.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-Descriptor'></a>
### Descriptor `property`

##### Summary

Service descriptor

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-BindService-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase-'></a>
### BindService(serviceImpl) `method`

##### Summary

Creates service definition that can be registered with a server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceImpl | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase') | An object implementing the server-side handling logic. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase-'></a>
### BindService(serviceBinder,serviceImpl) `method`

##### Summary

Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
Note: this method is part of an experimental API that can change or be removed without any prior notice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBinder | [Grpc.Core.ServiceBinderBase](#T-Grpc-Core-ServiceBinderBase 'Grpc.Core.ServiceBinderBase') | Service methods will be bound by calling `AddMethod` on this object. |
| serviceImpl | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceBase') | An object implementing the server-side handling logic. |

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase'></a>
## ServiceAccountServiceBase `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService

##### Summary

Base class for server-side implementations of ServiceAccountService

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-ServerCallContext-'></a>
### DeleteServiceAccount(request,context) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceBase-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-ServerCallContext-'></a>
### UpdateServiceAccount(request,context) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient'></a>
## ServiceAccountServiceClient `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService

##### Summary

Client for ServiceAccountService

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient'></a>
## ServiceAccountServiceClient `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

ServiceAccountService client wrapper, for convenient use.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor-Grpc-Core-Channel-'></a>
### #ctor(channel) `constructor`

##### Summary

Creates a new client for ServiceAccountService

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The channel to use to make remote calls. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor-Grpc-Core-CallInvoker-'></a>
### #ctor(callInvoker) `constructor`

##### Summary

Creates a new client for ServiceAccountService that uses a custom `CallInvoker`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The callInvoker to use to make remote calls. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Protected parameterless constructor to allow creation of test doubles.

##### Parameters

This constructor has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Protected constructor to allow creation of configured clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Grpc.Core.ClientBase.ClientBaseConfiguration](#T-Grpc-Core-ClientBase-ClientBaseConfiguration 'Grpc.Core.ClientBase.ClientBaseConfiguration') | The client configuration. |

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DefaultEndpoint'></a>
### DefaultEndpoint `property`

##### Summary

The default endpoint for the ServiceAccountService service, which is a host of "platform.api.improbable.io" and a port of 443.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DefaultScopes'></a>
### DefaultScopes `property`

##### Summary

The default ServiceAccountService scopes.

##### Remarks

The default ServiceAccountService scopes are:

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC ServiceAccountService client.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DeleteServiceAccount(request,headers,deadline,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-CallOptions-'></a>
### DeleteServiceAccount(request,options) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DeleteServiceAccountAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Grpc-Core-CallOptions-'></a>
### DeleteServiceAccountAsync(request,options) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### NewInstance() `method`

##### Summary

Creates a new instance of client from given `ClientBaseConfiguration`.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### UpdateServiceAccount(request,headers,deadline,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-CallOptions-'></a>
### UpdateServiceAccount(request,options) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### UpdateServiceAccountAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Grpc-Core-CallOptions-'></a>
### UpdateServiceAccountAsync(request,options) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-'></a>
### Create(endpoint,settings) `method`

##### Summary

Synchronously creates a [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The created [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') | Optional [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
ServiceAccountServiceClient client = ServiceAccountServiceClient.Create();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    ServiceAccountServiceClient.DefaultEndpoint.Host, ServiceAccountServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
ServiceAccountServiceClient client = ServiceAccountServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
channel.ShutdownAsync().Wait();
```

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-'></a>
### Create(channel,settings) `method`

##### Summary

Creates a [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') which uses the specified channel for remote operations.

##### Returns

The created [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The [Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') | Optional [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings'). |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-'></a>
### Create(callInvoker,settings) `method`

##### Summary

Creates a [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') which uses the specified call invoker for remote operations.

##### Returns

The created [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The [CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') | Optional [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings'). |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-'></a>
### CreateAsync(endpoint,settings) `method`

##### Summary

Asynchronously creates a [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The task representing the created [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') | Optional [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
ServiceAccountServiceClient client = await ServiceAccountServiceClient.CreateAsync();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    ServiceAccountServiceClient.DefaultEndpoint.Host, ServiceAccountServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
ServiceAccountServiceClient client = ServiceAccountServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
await channel.ShutdownAsync();
```

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccount-System-String,System-String,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateServiceAccount(projectName,name,permissions,callSettings) `method`

##### Summary



##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project associated with the service account. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the service account. |
| permissions | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}') | The service account's scope. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateServiceAccount(request,callSettings) `method`

##### Summary



##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-System-String,System-String,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateServiceAccountAsync(projectName,name,permissions,callSettings) `method`

##### Summary



##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project associated with the service account. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the service account. |
| permissions | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}') | The service account's scope. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-System-String,System-String,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},System-Threading-CancellationToken-'></a>
### CreateServiceAccountAsync(projectName,name,permissions,cancellationToken) `method`

##### Summary



##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project associated with the service account. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the service account. |
| permissions | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}') | The service account's scope. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateServiceAccountAsync(request,callSettings) `method`

##### Summary



##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,System-Threading-CancellationToken-'></a>
### CreateServiceAccountAsync(request,cancellationToken) `method`

##### Summary



##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccount-System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteServiceAccount(id,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of the service account to delete. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteServiceAccount(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-System-Int64,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteServiceAccountAsync(id,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task that completes when the RPC has completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of the service account to delete. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-System-Int64,System-Threading-CancellationToken-'></a>
### DeleteServiceAccountAsync(id,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task that completes when the RPC has completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of the service account to delete. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteServiceAccountAsync(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task that completes when the RPC has completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,System-Threading-CancellationToken-'></a>
### DeleteServiceAccountAsync(request,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task that completes when the RPC has completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccounts-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListServiceAccounts(projectName,pageToken,pageSize,callSettings) `method`

##### Summary



##### Returns

A pageable sequence of [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project whose service accounts should be listed. You must have access to this
 project. |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
 A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
 A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccounts-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListServiceAccounts(request,callSettings) `method`

##### Summary



##### Returns

A pageable sequence of [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccountsAsync-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListServiceAccountsAsync(projectName,pageToken,pageSize,callSettings) `method`

##### Summary



##### Returns

A pageable asynchronous sequence of [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the project whose service accounts should be listed. You must have access to this
 project. |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
 A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
 A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ListServiceAccountsAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListServiceAccountsAsync(request,callSettings) `method`

##### Summary



##### Returns

A pageable asynchronous sequence of [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-ShutdownDefaultChannelsAsync'></a>
### ShutdownDefaultChannelsAsync() `method`

##### Summary

Shuts down any channels automatically created by [Create](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)'). Channels which weren't automatically
created are not affected.

##### Returns

A task representing the asynchronous shutdown operation.

##### Parameters

This method has no parameters.

##### Remarks

After calling this method, further calls to [Create](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings- 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings)') will create new channels, which could
in turn be shut down by another call to this method.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccount-System-Int64,Google-Protobuf-WellKnownTypes-Timestamp,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccount(id,expirationTime,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the service account which is to be updated. |
| expirationTime | [Google.Protobuf.WellKnownTypes.Timestamp](#T-Google-Protobuf-WellKnownTypes-Timestamp 'Google.Protobuf.WellKnownTypes.Timestamp') | An updated expiration time for the account. This cannot be more than 90 days in the future. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccount-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccount(id,permissions,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the service account which is to be updated. |
| permissions | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}') | An updated set of grants for the service account. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccount(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,Google-Protobuf-WellKnownTypes-Timestamp,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccountAsync(id,expirationTime,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the service account which is to be updated. |
| expirationTime | [Google.Protobuf.WellKnownTypes.Timestamp](#T-Google-Protobuf-WellKnownTypes-Timestamp 'Google.Protobuf.WellKnownTypes.Timestamp') | An updated expiration time for the account. This cannot be more than 90 days in the future. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,Google-Protobuf-WellKnownTypes-Timestamp,System-Threading-CancellationToken-'></a>
### UpdateServiceAccountAsync(id,expirationTime,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the service account which is to be updated. |
| expirationTime | [Google.Protobuf.WellKnownTypes.Timestamp](#T-Google-Protobuf-WellKnownTypes-Timestamp 'Google.Protobuf.WellKnownTypes.Timestamp') | An updated expiration time for the account. This cannot be more than 90 days in the future. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccountAsync(id,permissions,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the service account which is to be updated. |
| permissions | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}') | An updated set of grants for the service account. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-System-Int64,System-Collections-Generic-IEnumerable{Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission},System-Threading-CancellationToken-'></a>
### UpdateServiceAccountAsync(id,permissions,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the service account which is to be updated. |
| permissions | [System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission}') | An updated set of grants for the service account. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccountAsync(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,System-Threading-CancellationToken-'></a>
### UpdateServiceAccountAsync(request,cancellationToken) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder'></a>
## ServiceAccountServiceClientBuilder `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

Builder class for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') to provide simple configuration of credentials, endpoint etc.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-Settings'></a>
### Settings `property`

##### Summary

The settings to use for RPCs, or null for the default settings.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-Build'></a>
### Build() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-BuildAsync-System-Threading-CancellationToken-'></a>
### BuildAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-GetChannelPool'></a>
### GetChannelPool() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-GetDefaultEndpoint'></a>
### GetDefaultEndpoint() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientBuilder-GetDefaultScopes'></a>
### GetDefaultScopes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl'></a>
## ServiceAccountServiceClientImpl `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

ServiceAccountService client wrapper implementation, for convenient use.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-#ctor-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient,Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-'></a>
### #ctor(grpcClient,settings) `constructor`

##### Summary

Constructs a client wrapper for the ServiceAccountService service, with the specified gRPC client and settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| grpcClient | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountService-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountService.ServiceAccountServiceClient') | The underlying gRPC client. |
| settings | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') | The base [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') used within this client |

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC ServiceAccountService client.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-CreateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateServiceAccount(request,callSettings) `method`

##### Summary



##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-CreateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateServiceAccountAsync(request,callSettings) `method`

##### Summary



##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-CreateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.CreateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-DeleteServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteServiceAccount(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-DeleteServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DeleteServiceAccountAsync(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please add a
(potentially empty) standard DeleteServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task that completes when the RPC has completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-DeleteServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.DeleteServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-ListServiceAccounts-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListServiceAccounts(request,callSettings) `method`

##### Summary



##### Returns

A pageable sequence of [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-ListServiceAccountsAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListServiceAccountsAsync(request,callSettings) `method`

##### Summary



##### Returns

A pageable asynchronous sequence of [ServiceAccount](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccount 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccount') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ListServiceAccountsRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ListServiceAccountsRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-UpdateServiceAccount-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccount(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClientImpl-UpdateServiceAccountAsync-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateServiceAccountAsync(request,callSettings) `method`

##### Summary

!!! WARNING !!!
When this API is moved to beta/stable please use a
standard UpdateServiceAccountResponse struct.
!!! WARNING !!!

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.UpdateServiceAccountRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings'></a>
## ServiceAccountServiceSettings `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

Settings for a [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient').

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') object with default settings.

##### Parameters

This constructor has no parameters.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-CreateServiceAccountSettings'></a>
### CreateServiceAccountSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`ServiceAccountServiceClient.CreateServiceAccount` and `ServiceAccountServiceClient.CreateServiceAccountAsync`.

##### Remarks

The default `ServiceAccountServiceClient.CreateServiceAccount` and
`ServiceAccountServiceClient.CreateServiceAccountAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-DeleteServiceAccountSettings'></a>
### DeleteServiceAccountSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`ServiceAccountServiceClient.DeleteServiceAccount` and `ServiceAccountServiceClient.DeleteServiceAccountAsync`.

##### Remarks

The default `ServiceAccountServiceClient.DeleteServiceAccount` and
`ServiceAccountServiceClient.DeleteServiceAccountAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-IdempotentRetryFilter'></a>
### IdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "Idempotent" [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods.

##### Remarks

The eligible RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s for retry for "Idempotent" RPC methods are:

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-ListServiceAccountsSettings'></a>
### ListServiceAccountsSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`ServiceAccountServiceClient.ListServiceAccounts` and `ServiceAccountServiceClient.ListServiceAccountsAsync`.

##### Remarks

The default `ServiceAccountServiceClient.ListServiceAccounts` and
`ServiceAccountServiceClient.ListServiceAccountsAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-NonIdempotentRetryFilter'></a>
### NonIdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "NonIdempotent" [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods.

##### Remarks

There are no RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s eligible for retry for "NonIdempotent" RPC methods.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-UpdateServiceAccountSettings'></a>
### UpdateServiceAccountSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`ServiceAccountServiceClient.UpdateServiceAccount` and `ServiceAccountServiceClient.UpdateServiceAccountAsync`.

##### Remarks

The default `ServiceAccountServiceClient.UpdateServiceAccount` and
`ServiceAccountServiceClient.UpdateServiceAccountAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-Clone'></a>
### Clone() `method`

##### Summary

Creates a deep clone of this object, with all the same property values.

##### Returns

A deep clone of this [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings') object.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-GetDefault'></a>
### GetDefault() `method`

##### Summary

Get a new instance of the default [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings').

##### Returns

A new instance of the default [ServiceAccountServiceSettings](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceSettings').

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-GetDefaultRetryBackoff'></a>
### GetDefaultRetryBackoff() `method`

##### Summary

"Default" retry backoff for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods.

##### Returns

The "Default" retry backoff for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" retry backoff for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods is defined as:

<a name='M-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceSettings-GetDefaultTimeoutBackoff'></a>
### GetDefaultTimeoutBackoff() `method`

##### Summary

"Default" timeout backoff for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods.

##### Returns

The "Default" timeout backoff for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" timeout backoff for [ServiceAccountServiceClient](#T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceAccountServiceClient 'Improbable.SpatialOS.ServiceAccount.V1Alpha1.ServiceAccountServiceClient') RPC methods is defined as:

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceaccountReflection'></a>
## ServiceaccountReflection `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

##### Summary

Holder for reflection information generated from improbable/spatialos/serviceaccount/v1alpha1/serviceaccount.proto

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-ServiceaccountReflection-Descriptor'></a>
### Descriptor `property`

##### Summary

File descriptor for improbable/spatialos/serviceaccount/v1alpha1/serviceaccount.proto

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-Permission-Types'></a>
## Types `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1.Permission

##### Summary

Container for nested types declared in the Permission message type.

<a name='T-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest'></a>
## UpdateServiceAccountRequest `type`

##### Namespace

Improbable.SpatialOS.ServiceAccount.V1Alpha1

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-ExpirationTimeFieldNumber'></a>
### ExpirationTimeFieldNumber `constants`

##### Summary

Field number for the "expiration_time" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-PermissionsFieldNumber'></a>
### PermissionsFieldNumber `constants`

##### Summary

Field number for the "permissions" field.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-ExpirationTime'></a>
### ExpirationTime `property`

##### Summary

An updated expiration time for the account. This cannot be more than 90 days in the future.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-Id'></a>
### Id `property`

##### Summary

The ID of the service account which is to be updated.

<a name='P-Improbable-SpatialOS-ServiceAccount-V1Alpha1-UpdateServiceAccountRequest-Permissions'></a>
### Permissions `property`

##### Summary

An updated set of grants for the service account.
