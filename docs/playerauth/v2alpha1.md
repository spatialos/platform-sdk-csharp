<a name='assembly'></a>
# Improbable.SpatialOS.Platform.PlayerAuth.V2Alpha1

## Contents

- [CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest')
  - [DescriptionFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-DescriptionFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest.DescriptionFieldNumber')
  - [LifetimeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-LifetimeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest.LifetimeFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest.ProjectNameFieldNumber')
  - [Description](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-Description 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest.Description')
  - [Lifetime](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-Lifetime 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest.Lifetime')
  - [ProjectName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-ProjectName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest.ProjectName')
- [CreateDevelopmentAuthenticationTokenResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenResponse')
  - [DevelopmentAuthenticationTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenResponse.DevelopmentAuthenticationTokenFieldNumber')
  - [TokenSecretFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-TokenSecretFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenResponse.TokenSecretFieldNumber')
  - [DevelopmentAuthenticationToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenResponse.DevelopmentAuthenticationToken')
  - [TokenSecret](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-TokenSecret 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenResponse.TokenSecret')
- [CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest')
  - [DeploymentIdFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-DeploymentIdFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.DeploymentIdFieldNumber')
  - [LifetimeDurationFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-LifetimeDurationFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.LifetimeDurationFieldNumber')
  - [PlayerIdentityTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-PlayerIdentityTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.PlayerIdentityTokenFieldNumber')
  - [WorkerTypeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-WorkerTypeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.WorkerTypeFieldNumber')
  - [DeploymentId](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-DeploymentId 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.DeploymentId')
  - [LifetimeDuration](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-LifetimeDuration 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.LifetimeDuration')
  - [PlayerIdentityToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-PlayerIdentityToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.PlayerIdentityToken')
  - [WorkerType](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-WorkerType 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.WorkerType')
- [CreateLoginTokenResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse')
  - [LoginTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenResponse-LoginTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse.LoginTokenFieldNumber')
  - [LoginToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenResponse-LoginToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse.LoginToken')
- [CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest')
  - [DisplayNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-DisplayNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.DisplayNameFieldNumber')
  - [LifetimeDurationFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-LifetimeDurationFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.LifetimeDurationFieldNumber')
  - [MetadataFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-MetadataFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.MetadataFieldNumber')
  - [PlayerIdentifierFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-PlayerIdentifierFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.PlayerIdentifierFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.ProjectNameFieldNumber')
  - [ProviderFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-ProviderFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.ProviderFieldNumber')
  - [DisplayName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-DisplayName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.DisplayName')
  - [LifetimeDuration](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-LifetimeDuration 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.LifetimeDuration')
  - [Metadata](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-Metadata 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.Metadata')
  - [PlayerIdentifier](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-PlayerIdentifier 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.PlayerIdentifier')
  - [ProjectName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-ProjectName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.ProjectName')
  - [Provider](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-Provider 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.Provider')
- [CreatePlayerIdentityTokenResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse')
  - [PlayerIdentityTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenResponse-PlayerIdentityTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse.PlayerIdentityTokenFieldNumber')
  - [PlayerIdentityToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenResponse-PlayerIdentityToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse.PlayerIdentityToken')
- [DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest')
  - [PlayerIdentityTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest-PlayerIdentityTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest.PlayerIdentityTokenFieldNumber')
  - [PlayerIdentityToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest-PlayerIdentityToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest.PlayerIdentityToken')
- [DecodePlayerIdentityTokenResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse')
  - [PlayerIdentityTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenResponse-PlayerIdentityTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse.PlayerIdentityTokenFieldNumber')
  - [PlayerIdentityToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenResponse-PlayerIdentityToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse.PlayerIdentityToken')
- [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken')
  - [CreationTimeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-CreationTimeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.CreationTimeFieldNumber')
  - [DescriptionFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-DescriptionFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.DescriptionFieldNumber')
  - [ExpirationTimeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ExpirationTimeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.ExpirationTimeFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-IdFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.IdFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ProjectNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.ProjectNameFieldNumber')
  - [CreationTime](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-CreationTime 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.CreationTime')
  - [Description](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-Description 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.Description')
  - [ExpirationTime](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ExpirationTime 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.ExpirationTime')
  - [Id](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-Id 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.Id')
  - [ProjectName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ProjectName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken.ProjectName')
- [ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest')
  - [IdFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest-IdFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest.IdFieldNumber')
  - [Id](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest-Id 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest.Id')
- [GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest')
  - [IdFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest-IdFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest.IdFieldNumber')
  - [Id](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest-Id 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest.Id')
- [GetDevelopmentAuthenticationTokenResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenResponse')
  - [DevelopmentAuthenticationTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenResponse.DevelopmentAuthenticationTokenFieldNumber')
  - [DevelopmentAuthenticationToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenResponse.DevelopmentAuthenticationToken')
- [ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest')
  - [IncludeExpiredFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-IncludeExpiredFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.IncludeExpiredFieldNumber')
  - [PageSizeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageSizeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.PageSizeFieldNumber')
  - [PageTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.PageTokenFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-ProjectNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.ProjectNameFieldNumber')
  - [IncludeExpired](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-IncludeExpired 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.IncludeExpired')
  - [PageSize](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageSize 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.PageSize')
  - [PageToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.PageToken')
  - [ProjectName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-ProjectName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest.ProjectName')
- [ListDevelopmentAuthenticationTokensResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse')
  - [DevelopmentAuthenticationTokensFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-DevelopmentAuthenticationTokensFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse.DevelopmentAuthenticationTokensFieldNumber')
  - [NextPageTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-NextPageTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse.NextPageTokenFieldNumber')
  - [DevelopmentAuthenticationTokens](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-DevelopmentAuthenticationTokens 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse.DevelopmentAuthenticationTokens')
  - [NextPageToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-NextPageToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse.NextPageToken')
  - [GetEnumerator()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-GetEnumerator 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse.GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-System#Collections#IEnumerable#GetEnumerator 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensResponse.System#Collections#IEnumerable#GetEnumerator')
- [PlayerAuthService](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService')
  - [Descriptor](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-Descriptor 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.Descriptor')
  - [BindService(serviceImpl)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-BindService-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.BindService(Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase)')
  - [BindService(serviceBinder,serviceImpl)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.BindService(Grpc.Core.ServiceBinderBase,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase)')
- [PlayerAuthServiceBase](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase')
  - [CreateDevelopmentAuthenticationToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.CreateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Grpc.Core.ServerCallContext)')
  - [CreateLoginToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.CreateLoginToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Grpc.Core.ServerCallContext)')
  - [CreatePlayerIdentityToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.CreatePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Grpc.Core.ServerCallContext)')
  - [DecodePlayerIdentityToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.DecodePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Grpc.Core.ServerCallContext)')
  - [ExpireDevelopmentAuthenticationToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.ExpireDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Grpc.Core.ServerCallContext)')
  - [GetDevelopmentAuthenticationToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.GetDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Grpc.Core.ServerCallContext)')
  - [ListDevelopmentAuthenticationTokens(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.ListDevelopmentAuthenticationTokens(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Grpc.Core.ServerCallContext)')
  - [UpdateDevelopmentAuthenticationToken(request,context)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase.UpdateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Grpc.Core.ServerCallContext)')
- [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient')
- [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient')
  - [#ctor(channel)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor-Grpc-Core-Channel- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.#ctor(Grpc.Core.Channel)')
  - [#ctor(callInvoker)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor-Grpc-Core-CallInvoker- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.#ctor(Grpc.Core.CallInvoker)')
  - [#ctor()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.#ctor')
  - [#ctor(configuration)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.#ctor(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [DefaultEndpoint](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DefaultEndpoint 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DefaultEndpoint')
  - [DefaultScopes](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DefaultScopes 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DefaultScopes')
  - [GrpcClient](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GrpcClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GrpcClient')
  - [CreateDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateDevelopmentAuthenticationToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [CreateDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateDevelopmentAuthenticationTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [CreateLoginToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateLoginToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateLoginToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateLoginToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Grpc.Core.CallOptions)')
  - [CreateLoginTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateLoginTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreateLoginTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreateLoginTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Grpc.Core.CallOptions)')
  - [CreatePlayerIdentityToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreatePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreatePlayerIdentityToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreatePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Grpc.Core.CallOptions)')
  - [CreatePlayerIdentityTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [CreatePlayerIdentityTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Grpc.Core.CallOptions)')
  - [DecodePlayerIdentityToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.DecodePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DecodePlayerIdentityToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.DecodePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Grpc.Core.CallOptions)')
  - [DecodePlayerIdentityTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [DecodePlayerIdentityTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Grpc.Core.CallOptions)')
  - [ExpireDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ExpireDevelopmentAuthenticationToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [ExpireDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ExpireDevelopmentAuthenticationTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [GetDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.GetDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetDevelopmentAuthenticationToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.GetDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [GetDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [GetDevelopmentAuthenticationTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [ListDevelopmentAuthenticationTokens(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ListDevelopmentAuthenticationTokens(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Grpc.Core.CallOptions)')
  - [ListDevelopmentAuthenticationTokensAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [ListDevelopmentAuthenticationTokensAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Grpc.Core.CallOptions)')
  - [NewInstance()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.NewInstance(Grpc.Core.ClientBase.ClientBaseConfiguration)')
  - [UpdateDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [UpdateDevelopmentAuthenticationToken(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [UpdateDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Grpc.Core.Metadata,System.Nullable{System.DateTime},System.Threading.CancellationToken)')
  - [UpdateDevelopmentAuthenticationTokenAsync(request,options)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Grpc.Core.CallOptions)')
  - [Create(endpoint,settings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
  - [Create(channel,settings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.Create(Grpc.Core.Channel,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
  - [Create(callInvoker,settings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.Create(Grpc.Core.CallInvoker,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
  - [CreateAsync(endpoint,settings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
  - [CreateDevelopmentAuthenticationToken(projectName,description,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken(System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDevelopmentAuthenticationTokenAsync(projectName,description,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync(System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDevelopmentAuthenticationTokenAsync(projectName,description,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-System-String,System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [CreateDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDevelopmentAuthenticationTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,System.Threading.CancellationToken)')
  - [CreateLoginToken(deploymentId,playerIdentityToken,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginToken-System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateLoginToken(System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateLoginToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateLoginToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateLoginTokenAsync(deploymentId,playerIdentityToken,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateLoginTokenAsync(System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateLoginTokenAsync(deploymentId,playerIdentityToken,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-System-String,System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateLoginTokenAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [CreateLoginTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateLoginTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateLoginTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateLoginTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,System.Threading.CancellationToken)')
  - [CreatePlayerIdentityToken(projectName,provider,playerIdentifier,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityToken-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreatePlayerIdentityToken(System.String,System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [CreatePlayerIdentityToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreatePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreatePlayerIdentityTokenAsync(projectName,provider,playerIdentifier,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync(System.String,System.String,System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [CreatePlayerIdentityTokenAsync(projectName,provider,playerIdentifier,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-System-String,System-String,System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync(System.String,System.String,System.String,System.Threading.CancellationToken)')
  - [CreatePlayerIdentityTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreatePlayerIdentityTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,System.Threading.CancellationToken)')
  - [DecodePlayerIdentityToken(playerIdentityToken,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityToken-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DecodePlayerIdentityToken(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [DecodePlayerIdentityToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DecodePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DecodePlayerIdentityTokenAsync(playerIdentityToken,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [DecodePlayerIdentityTokenAsync(playerIdentityToken,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync(System.String,System.Threading.CancellationToken)')
  - [DecodePlayerIdentityTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DecodePlayerIdentityTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,System.Threading.CancellationToken)')
  - [ExpireDevelopmentAuthenticationToken(id,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [ExpireDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ExpireDevelopmentAuthenticationTokenAsync(id,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [ExpireDevelopmentAuthenticationTokenAsync(id,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync(System.String,System.Threading.CancellationToken)')
  - [ExpireDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ExpireDevelopmentAuthenticationTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,System.Threading.CancellationToken)')
  - [GetDevelopmentAuthenticationToken(id,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GetDevelopmentAuthenticationToken(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GetDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDevelopmentAuthenticationTokenAsync(id,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-System-String,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync(System.String,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDevelopmentAuthenticationTokenAsync(id,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-System-String,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync(System.String,System.Threading.CancellationToken)')
  - [GetDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDevelopmentAuthenticationTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,System.Threading.CancellationToken)')
  - [ListDevelopmentAuthenticationTokens(projectName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens(System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListDevelopmentAuthenticationTokens(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListDevelopmentAuthenticationTokensAsync(projectName,pageToken,pageSize,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync(System.String,System.String,System.Nullable{System.Int32},Google.Api.Gax.Grpc.CallSettings)')
  - [ListDevelopmentAuthenticationTokensAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ShutdownDefaultChannelsAsync()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ShutdownDefaultChannelsAsync 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.ShutdownDefaultChannelsAsync')
  - [UpdateDevelopmentAuthenticationToken(id,updatedLifetime,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-System-String,Google-Protobuf-WellKnownTypes-Duration,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken(System.String,Google.Protobuf.WellKnownTypes.Duration,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateDevelopmentAuthenticationTokenAsync(id,updatedLifetime,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-System-String,Google-Protobuf-WellKnownTypes-Duration,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync(System.String,Google.Protobuf.WellKnownTypes.Duration,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateDevelopmentAuthenticationTokenAsync(id,updatedLifetime,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-System-String,Google-Protobuf-WellKnownTypes-Duration,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync(System.String,Google.Protobuf.WellKnownTypes.Duration,System.Threading.CancellationToken)')
  - [UpdateDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateDevelopmentAuthenticationTokenAsync(request,cancellationToken)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,System.Threading.CancellationToken)')
- [PlayerAuthServiceClientBuilder](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder')
  - [Settings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-Settings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder.Settings')
  - [Build()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-Build 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder.Build')
  - [BuildAsync()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-BuildAsync-System-Threading-CancellationToken- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder.BuildAsync(System.Threading.CancellationToken)')
  - [GetChannelPool()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-GetChannelPool 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder.GetChannelPool')
  - [GetDefaultEndpoint()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-GetDefaultEndpoint 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder.GetDefaultEndpoint')
  - [GetDefaultScopes()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-GetDefaultScopes 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientBuilder.GetDefaultScopes')
- [PlayerAuthServiceClientImpl](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl')
  - [#ctor(grpcClient,settings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-#ctor-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.#ctor(Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
  - [GrpcClient](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-GrpcClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.GrpcClient')
  - [CreateDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.CreateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.CreateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateLoginToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.CreateLoginToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreateLoginTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.CreateLoginTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreatePlayerIdentityToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.CreatePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [CreatePlayerIdentityTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.CreatePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DecodePlayerIdentityToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.DecodePlayerIdentityToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [DecodePlayerIdentityTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.DecodePlayerIdentityTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ExpireDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.ExpireDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ExpireDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.ExpireDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.GetDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [GetDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.GetDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListDevelopmentAuthenticationTokens(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.ListDevelopmentAuthenticationTokens(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [ListDevelopmentAuthenticationTokensAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.ListDevelopmentAuthenticationTokensAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateDevelopmentAuthenticationToken(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.UpdateDevelopmentAuthenticationToken(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
  - [UpdateDevelopmentAuthenticationTokenAsync(request,callSettings)](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClientImpl.UpdateDevelopmentAuthenticationTokenAsync(Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest,Google.Api.Gax.Grpc.CallSettings)')
- [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings')
  - [#ctor()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-#ctor 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.#ctor')
  - [CreateDevelopmentAuthenticationTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-CreateDevelopmentAuthenticationTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.CreateDevelopmentAuthenticationTokenSettings')
  - [CreateLoginTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-CreateLoginTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.CreateLoginTokenSettings')
  - [CreatePlayerIdentityTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-CreatePlayerIdentityTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.CreatePlayerIdentityTokenSettings')
  - [DecodePlayerIdentityTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-DecodePlayerIdentityTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.DecodePlayerIdentityTokenSettings')
  - [ExpireDevelopmentAuthenticationTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-ExpireDevelopmentAuthenticationTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.ExpireDevelopmentAuthenticationTokenSettings')
  - [GetDevelopmentAuthenticationTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDevelopmentAuthenticationTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.GetDevelopmentAuthenticationTokenSettings')
  - [IdempotentRetryFilter](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-IdempotentRetryFilter 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.IdempotentRetryFilter')
  - [ListDevelopmentAuthenticationTokensSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-ListDevelopmentAuthenticationTokensSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.ListDevelopmentAuthenticationTokensSettings')
  - [NonIdempotentRetryFilter](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-NonIdempotentRetryFilter 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.NonIdempotentRetryFilter')
  - [UpdateDevelopmentAuthenticationTokenSettings](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-UpdateDevelopmentAuthenticationTokenSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.UpdateDevelopmentAuthenticationTokenSettings')
  - [Clone()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-Clone 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.Clone')
  - [GetDefault()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDefault 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.GetDefault')
  - [GetDefaultRetryBackoff()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDefaultRetryBackoff 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.GetDefaultRetryBackoff')
  - [GetDefaultTimeoutBackoff()](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDefaultTimeoutBackoff 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings.GetDefaultTimeoutBackoff')
- [PlayerIdentityToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken')
  - [DisplayNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-DisplayNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.DisplayNameFieldNumber')
  - [ExpiryTimeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ExpiryTimeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.ExpiryTimeFieldNumber')
  - [IssuedAtTimeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-IssuedAtTimeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.IssuedAtTimeFieldNumber')
  - [MetadataFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-MetadataFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.MetadataFieldNumber')
  - [PlayerIdentifierFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-PlayerIdentifierFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.PlayerIdentifierFieldNumber')
  - [ProjectNameFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ProjectNameFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.ProjectNameFieldNumber')
  - [ProviderFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ProviderFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.ProviderFieldNumber')
  - [DisplayName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-DisplayName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.DisplayName')
  - [ExpiryTime](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ExpiryTime 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.ExpiryTime')
  - [IssuedAtTime](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-IssuedAtTime 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.IssuedAtTime')
  - [Metadata](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-Metadata 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.Metadata')
  - [PlayerIdentifier](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-PlayerIdentifier 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.PlayerIdentifier')
  - [ProjectName](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ProjectName 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.ProjectName')
  - [Provider](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-Provider 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerIdentityToken.Provider')
- [PlayerauthReflection](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerauthReflection 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerauthReflection')
  - [Descriptor](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerauthReflection-Descriptor 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerauthReflection.Descriptor')
- [UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest')
  - [DescriptionFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-DescriptionFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest.DescriptionFieldNumber')
  - [IdFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-IdFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest.IdFieldNumber')
  - [UpdatedLifetimeFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-UpdatedLifetimeFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest.UpdatedLifetimeFieldNumber')
  - [Description](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-Description 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest.Description')
  - [Id](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-Id 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest.Id')
  - [UpdatedLifetime](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-UpdatedLifetime 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest.UpdatedLifetime')
- [UpdateDevelopmentAuthenticationTokenResponse](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenResponse 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenResponse')
  - [DevelopmentAuthenticationTokenFieldNumber](#F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationTokenFieldNumber 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenResponse.DevelopmentAuthenticationTokenFieldNumber')
  - [DevelopmentAuthenticationToken](#P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenResponse.DevelopmentAuthenticationToken')

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest'></a>
## CreateDevelopmentAuthenticationTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-DescriptionFieldNumber'></a>
### DescriptionFieldNumber `constants`

##### Summary

Field number for the "description" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-LifetimeFieldNumber'></a>
### LifetimeFieldNumber `constants`

##### Summary

Field number for the "lifetime" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-Description'></a>
### Description `property`

##### Summary

A description for the DAT.

 It cannot be empty and has a maximum length of 200 characters.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-Lifetime'></a>
### Lifetime `property`

##### Summary

The validity period of the DAT starting from the time of this request. This field is optional.

 The maximum value is 90 days. If unset, this field defaults to 30 days.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the DAT is scoped to. You must have access to this project.

 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse'></a>
## CreateDevelopmentAuthenticationTokenResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationTokenFieldNumber'></a>
### DevelopmentAuthenticationTokenFieldNumber `constants`

##### Summary

Field number for the "development_authentication_token" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-TokenSecretFieldNumber'></a>
### TokenSecretFieldNumber `constants`

##### Summary

Field number for the "token_secret" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationToken'></a>
### DevelopmentAuthenticationToken `property`

##### Summary

The newly created DAT metadata.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenResponse-TokenSecret'></a>
### TokenSecret `property`

##### Summary

The secret value of the DAT. This cannot be retrieved again.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest'></a>
## CreateLoginTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

The following fields are mandatory:
 - \`player_identity_token\`
 - \`deployment_id\`

 The remaining fields are optional:
  - \`lifetime_duration\`. If provided, this must be a positive duration. If unset,
    it defaults to 15 minutes.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-DeploymentIdFieldNumber'></a>
### DeploymentIdFieldNumber `constants`

##### Summary

Field number for the "deployment_id" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-LifetimeDurationFieldNumber'></a>
### LifetimeDurationFieldNumber `constants`

##### Summary

Field number for the "lifetime_duration" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-PlayerIdentityTokenFieldNumber'></a>
### PlayerIdentityTokenFieldNumber `constants`

##### Summary

Field number for the "player_identity_token" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-WorkerTypeFieldNumber'></a>
### WorkerTypeFieldNumber `constants`

##### Summary

Field number for the "worker_type" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-DeploymentId'></a>
### DeploymentId `property`

##### Summary

The UUID of the deployment that the user gets access to.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-LifetimeDuration'></a>
### LifetimeDuration `property`

##### Summary

Specifies how long the LT is valid for.

 This field is optional. If unset or 0, it defaults to 15 minutes. The maximum value is 30
 minutes.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-PlayerIdentityToken'></a>
### PlayerIdentityToken `property`

##### Summary

The player_identity_token is the JWT returned by the
\`PlayerIdentityTokenService.CreatePlayerIdentityToken\` RPC

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest-WorkerType'></a>
### WorkerType `property`

##### Summary

The worker type you can use to connect to the deployment.

 This field is optional. Leave empty to allow all types of worker. If provided, it must conform
 to the regex \`^$|^[a-zA-Z0-9_-]{3,128}$\`.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenResponse'></a>
## CreateLoginTokenResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenResponse-LoginTokenFieldNumber'></a>
### LoginTokenFieldNumber `constants`

##### Summary

Field number for the "login_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenResponse-LoginToken'></a>
### LoginToken `property`

##### Summary

The login_token is a short-lived token (up to 15 minutes), allowing the user to log in to a
deployment with the specified name. It is a signed JWT with the following claims:
- sub:     Provider-scoped unique user ID. Corresponds to \`player_identifier\` supplied in
\`CreatePlayerIdentityTokenRequest\`.
- prvdr:   Describes system used to authenticate the user. Corresponds to \`provider\` supplied
in \`CreatePlayerIdentityTokenRequest\`.
- prj:     Project that the token is scoped to.
- dpl:     Deployment UUID that the token gives access to.
- iat:     Issued at time. This is the time since epoch in seconds in UTC.
- exp:     Expiry time. This is the time since epoch in seconds in UTC.
- wkt:     worker type: This is the worker type you can use to connect to the deployment.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest'></a>
## CreatePlayerIdentityTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

The following fields are mandatory:
 - \`provider\`
 - \`player_identifier\`. The maximum length is 64 characters.
 - \`project_name\`

 The remaining fields are optional:
 - \`lifetime_duration\`. If provided, this must be a positive duration,
   less than or equal to 24.
 - \`display_name\`. If provided, the maximum length is 64 characters.
 - \`metadata\`. If provided, this must be less than or equal to 256 bytes.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-DisplayNameFieldNumber'></a>
### DisplayNameFieldNumber `constants`

##### Summary

Field number for the "display_name" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-LifetimeDurationFieldNumber'></a>
### LifetimeDurationFieldNumber `constants`

##### Summary

Field number for the "lifetime_duration" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-MetadataFieldNumber'></a>
### MetadataFieldNumber `constants`

##### Summary

Field number for the "metadata" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-PlayerIdentifierFieldNumber'></a>
### PlayerIdentifierFieldNumber `constants`

##### Summary

Field number for the "player_identifier" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-ProviderFieldNumber'></a>
### ProviderFieldNumber `constants`

##### Summary

Field number for the "provider" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-DisplayName'></a>
### DisplayName `property`

##### Summary

The player's display name. This field is optional.

 The display name is controlled by the caller and may contain personal information. It should
 not be stored or logged. The maximum length is 64 characters.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-LifetimeDuration'></a>
### LifetimeDuration `property`

##### Summary

The duration for which the issued PIT is valid.

 It must be set to less than or equal to 24 hours.

 This field is optional. If unset or 0, it defaults to 24 hours.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-Metadata'></a>
### Metadata `property`

##### Summary

Additional metadata that is stored within the PIT.

 You can use this to securely attach extra attributes on the PIT in a format you choose.
 For example: JSON payload: bytes("{ 'userType': 'PREMIUM', 'region': 'EU' }")
 It must use less than or equal to 256 bytes.
 Exceeding this limitation results in an \`InvalidArgument\` error.

 This field is optional.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-PlayerIdentifier'></a>
### PlayerIdentifier `property`

##### Summary

The ID of the player for whom who you are generating a PIT.

 This should uniquely identify a user in the specified provider.
 The maximum length is 64 characters.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the PIT is scoped to.
This should be between 3 and 32 characters and made up of lower case letters, numbers and
underscores only.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest-Provider'></a>
### Provider `property`

##### Summary

The system used to authenticate the player with (for example) Steam or Google. This field must
not be empty. The provider name cannot contain 'improbable' (case insensitive) as this is
reserved for internal use.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenResponse'></a>
## CreatePlayerIdentityTokenResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenResponse-PlayerIdentityTokenFieldNumber'></a>
### PlayerIdentityTokenFieldNumber `constants`

##### Summary

Field number for the "player_identity_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenResponse-PlayerIdentityToken'></a>
### PlayerIdentityToken `property`

##### Summary

The \`player_identity_token\` is a long-lived token (up to 24h) which guarantees a user's
 identity in the context of a project.

 It is a signed JWT with the following payload:
 - sub:     Provider-scoped unique user ID. Corresponds to \`player_identifier\` supplied in
 \`CreatePlayerIdentityTokenRequest\`.
 - prvdr:   Describes system used to authenticate the user. Corresponds to \`provider\` supplied
 in \`CreatePlayerIdentityTokenRequest\`.
 - prj:     Project that the PIT is scoped to.
 - md:      Metadata. Corresponds to \`md\` supplied in \`CreatePlayerIdentityTokenRequest\`.
 - iat:     Issued at time. This is the time since epoch in seconds in UTC.
 - exp:     Expiry time. This is the time since epoch in seconds in UTC.
 - dn:      Display name. This is an optional user-provided string, corresponding to \`dn\`
 supplied in \`CreatePlayerIdentityRequest\`.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest'></a>
## DecodePlayerIdentityTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

The following fields are mandatory:
- \`player_identity_token\`

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest-PlayerIdentityTokenFieldNumber'></a>
### PlayerIdentityTokenFieldNumber `constants`

##### Summary

Field number for the "player_identity_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest-PlayerIdentityToken'></a>
### PlayerIdentityToken `property`

##### Summary

The PIT that was issued to the user.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenResponse'></a>
## DecodePlayerIdentityTokenResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenResponse-PlayerIdentityTokenFieldNumber'></a>
### PlayerIdentityTokenFieldNumber `constants`

##### Summary

Field number for the "player_identity_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenResponse-PlayerIdentityToken'></a>
### PlayerIdentityToken `property`

##### Summary

The PIT that should be decoded.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken'></a>
## DevelopmentAuthenticationToken `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

You can exchange a \`DevelopmentAuthenticationToken\` (DAT) for an anonymous \`PlayerIdentityToken\`
(PIT) using the \`DevelopmentAuthenticationService\` (DAS) to join a deployment anonymously. DATs
are intended to be used during the early stage of game development and can be hardcoded into game
clients.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-CreationTimeFieldNumber'></a>
### CreationTimeFieldNumber `constants`

##### Summary

Field number for the "creation_time" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-DescriptionFieldNumber'></a>
### DescriptionFieldNumber `constants`

##### Summary

Field number for the "description" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ExpirationTimeFieldNumber'></a>
### ExpirationTimeFieldNumber `constants`

##### Summary

Field number for the "expiration_time" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-CreationTime'></a>
### CreationTime `property`

##### Summary

Creation time of the DAT.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-Description'></a>
### Description `property`

##### Summary

A user-specified description for the DAT.

 It cannot be empty and has a maximum length of 200 characters.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ExpirationTime'></a>
### ExpirationTime `property`

##### Summary

Expiration time of the DAT.

 The expiration time can be extended using the \`UpdateDevelopmentAuthenticationToken\` endpoint.
 Expired DATs are permanently deleted after one week.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-Id'></a>
### Id `property`

##### Summary

The ID of a DAT. Pass this into requests to a DAS to exchange your DAT for an anonymous PIT.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the DAT is scoped to.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest'></a>
## ExpireDevelopmentAuthenticationTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest-Id'></a>
### Id `property`

##### Summary

The ID of the DAT to expire.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest'></a>
## GetDevelopmentAuthenticationTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest-Id'></a>
### Id `property`

##### Summary

The ID of the DAT.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenResponse'></a>
## GetDevelopmentAuthenticationTokenResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationTokenFieldNumber'></a>
### DevelopmentAuthenticationTokenFieldNumber `constants`

##### Summary

Field number for the "development_authentication_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationToken'></a>
### DevelopmentAuthenticationToken `property`

##### Summary

DAT of the given UUID.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest'></a>
## ListDevelopmentAuthenticationTokensRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-IncludeExpiredFieldNumber'></a>
### IncludeExpiredFieldNumber `constants`

##### Summary

Field number for the "include_expired" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageSizeFieldNumber'></a>
### PageSizeFieldNumber `constants`

##### Summary

Field number for the "page_size" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageTokenFieldNumber'></a>
### PageTokenFieldNumber `constants`

##### Summary

Field number for the "page_token" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-IncludeExpired'></a>
### IncludeExpired `property`

##### Summary

Specifies whether the response will include expired DATs. This field is optional.

 If unset, this field defaults to false.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageSize'></a>
### PageSize `property`

##### Summary

The maximum number of DATs to return in the response. This field is optional.

 The maximum value is 50 results per page. If unset, this field defaults to 20 results per page.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-PageToken'></a>
### PageToken `property`

##### Summary

The token to identify the starting point of the request. This field is optional.

 An empty or invalid token defaults to listing from the start.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the queried DATs are scoped to. You must have access to this project.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse'></a>
## ListDevelopmentAuthenticationTokensResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-DevelopmentAuthenticationTokensFieldNumber'></a>
### DevelopmentAuthenticationTokensFieldNumber `constants`

##### Summary

Field number for the "development_authentication_tokens" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-NextPageTokenFieldNumber'></a>
### NextPageTokenFieldNumber `constants`

##### Summary

Field number for the "next_page_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-DevelopmentAuthenticationTokens'></a>
### DevelopmentAuthenticationTokens `property`

##### Summary

The DATs corresponding to your query.

 The DATs are listed in descending order sorted by creation time.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-NextPageToken'></a>
### NextPageToken `property`

##### Summary

A token you can supply to the \`ListDeployments\` RPC to retrieve the next page of
paginated results. This field is optional.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the resources in this response.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensResponse-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService'></a>
## PlayerAuthService `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

The PlayerAuthService provides methods for creating and managing
\`PlayerIdentityTokens\` (PITs), \`LoginTokens\` (LTs) and \`DevelopmentAuthenticationTokens\` (DATs).

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-Descriptor'></a>
### Descriptor `property`

##### Summary

Service descriptor

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-BindService-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-'></a>
### BindService(serviceImpl) `method`

##### Summary

Creates service definition that can be registered with a server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceImpl | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase') | An object implementing the server-side handling logic. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-BindService-Grpc-Core-ServiceBinderBase,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-'></a>
### BindService(serviceBinder,serviceImpl) `method`

##### Summary

Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
Note: this method is part of an experimental API that can change or be removed without any prior notice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBinder | [Grpc.Core.ServiceBinderBase](#T-Grpc-Core-ServiceBinderBase 'Grpc.Core.ServiceBinderBase') | Service methods will be bound by calling `AddMethod` on this object. |
| serviceImpl | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceBase') | An object implementing the server-side handling logic. |

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase'></a>
## PlayerAuthServiceBase `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService

##### Summary

Base class for server-side implementations of PlayerAuthService

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext-'></a>
### CreateDevelopmentAuthenticationToken(request,context) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-ServerCallContext-'></a>
### CreateLoginToken(request,context) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-ServerCallContext-'></a>
### CreatePlayerIdentityToken(request,context) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-ServerCallContext-'></a>
### DecodePlayerIdentityToken(request,context) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext-'></a>
### ExpireDevelopmentAuthenticationToken(request,context) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext-'></a>
### GetDevelopmentAuthenticationToken(request,context) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-ServerCallContext-'></a>
### ListDevelopmentAuthenticationTokens(request,context) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceBase-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-ServerCallContext-'></a>
### UpdateDevelopmentAuthenticationToken(request,context) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The response to send back to the client (wrapped by a task).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request received from the client. |
| context | [Grpc.Core.ServerCallContext](#T-Grpc-Core-ServerCallContext 'Grpc.Core.ServerCallContext') | The context of the server-side call handler being invoked. |

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient'></a>
## PlayerAuthServiceClient `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService

##### Summary

Client for PlayerAuthService

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient'></a>
## PlayerAuthServiceClient `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

PlayerAuthService client wrapper, for convenient use.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor-Grpc-Core-Channel-'></a>
### #ctor(channel) `constructor`

##### Summary

Creates a new client for PlayerAuthService

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The channel to use to make remote calls. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor-Grpc-Core-CallInvoker-'></a>
### #ctor(callInvoker) `constructor`

##### Summary

Creates a new client for PlayerAuthService that uses a custom `CallInvoker`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The callInvoker to use to make remote calls. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Protected parameterless constructor to allow creation of test doubles.

##### Parameters

This constructor has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-#ctor-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Protected constructor to allow creation of configured clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Grpc.Core.ClientBase.ClientBaseConfiguration](#T-Grpc-Core-ClientBase-ClientBaseConfiguration 'Grpc.Core.ClientBase.ClientBaseConfiguration') | The client configuration. |

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DefaultEndpoint'></a>
### DefaultEndpoint `property`

##### Summary

The default endpoint for the PlayerAuthService service, which is a host of "platform.api.improbable.io" and a port of 443.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DefaultScopes'></a>
### DefaultScopes `property`

##### Summary

The default PlayerAuthService scopes.

##### Remarks

The default PlayerAuthService scopes are:

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC PlayerAuthService client.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### CreateDevelopmentAuthenticationToken(request,options) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### CreateDevelopmentAuthenticationTokenAsync(request,options) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateLoginToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-CallOptions-'></a>
### CreateLoginToken(request,options) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreateLoginTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Grpc-Core-CallOptions-'></a>
### CreateLoginTokenAsync(request,options) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreatePlayerIdentityToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-CallOptions-'></a>
### CreatePlayerIdentityToken(request,options) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### CreatePlayerIdentityTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Grpc-Core-CallOptions-'></a>
### CreatePlayerIdentityTokenAsync(request,options) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DecodePlayerIdentityToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-CallOptions-'></a>
### DecodePlayerIdentityToken(request,options) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### DecodePlayerIdentityTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Grpc-Core-CallOptions-'></a>
### DecodePlayerIdentityTokenAsync(request,options) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ExpireDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### ExpireDevelopmentAuthenticationToken(request,options) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(request,options) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### GetDevelopmentAuthenticationToken(request,options) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### GetDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### GetDevelopmentAuthenticationTokenAsync(request,options) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ListDevelopmentAuthenticationTokens(request,headers,deadline,cancellationToken) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-CallOptions-'></a>
### ListDevelopmentAuthenticationTokens(request,options) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### ListDevelopmentAuthenticationTokensAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Grpc-Core-CallOptions-'></a>
### ListDevelopmentAuthenticationTokensAsync(request,options) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-NewInstance-Grpc-Core-ClientBase-ClientBaseConfiguration-'></a>
### NewInstance() `method`

##### Summary

Creates a new instance of client from given `ClientBaseConfiguration`.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### UpdateDevelopmentAuthenticationToken(request,headers,deadline,cancellationToken) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### UpdateDevelopmentAuthenticationToken(request,options) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The response received from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-Metadata,System-Nullable{System-DateTime},System-Threading-CancellationToken-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(request,headers,deadline,cancellationToken) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| headers | [Grpc.Core.Metadata](#T-Grpc-Core-Metadata 'Grpc.Core.Metadata') | The initial metadata to send with the call. This parameter is optional. |
| deadline | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | An optional deadline for the call. The call will be cancelled if deadline is hit. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | An optional token for canceling the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Grpc-Core-CallOptions-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(request,options) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The call object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request to send to the server. |
| options | [Grpc.Core.CallOptions](#T-Grpc-Core-CallOptions 'Grpc.Core.CallOptions') | The options for the call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-'></a>
### Create(endpoint,settings) `method`

##### Summary

Synchronously creates a [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The created [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') | Optional [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
PlayerAuthServiceClient client = PlayerAuthServiceClient.Create();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    PlayerAuthServiceClient.DefaultEndpoint.Host, PlayerAuthServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
PlayerAuthServiceClient client = PlayerAuthServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
channel.ShutdownAsync().Wait();
```

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Grpc-Core-Channel,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-'></a>
### Create(channel,settings) `method`

##### Summary

Creates a [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') which uses the specified channel for remote operations.

##### Returns

The created [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Grpc.Core.Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') | The [Channel](#T-Grpc-Core-Channel 'Grpc.Core.Channel') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') | Optional [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings'). |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Grpc-Core-CallInvoker,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-'></a>
### Create(callInvoker,settings) `method`

##### Summary

Creates a [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') which uses the specified call invoker for remote operations.

##### Returns

The created [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| callInvoker | [Grpc.Core.CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') | The [CallInvoker](#T-Grpc-Core-CallInvoker 'Grpc.Core.CallInvoker') for remote operations. Must not be null. |
| settings | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') | Optional [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings'). |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-'></a>
### CreateAsync(endpoint,settings) `method`

##### Summary

Asynchronously creates a [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient'), applying defaults for all unspecified settings,
and creating a channel connecting to the given endpoint with application default credentials where
necessary. See the example for how to use custom credentials.

##### Returns

The task representing the created [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Google.Api.Gax.Grpc.ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint') | Optional [ServiceEndpoint](#T-Google-Api-Gax-Grpc-ServiceEndpoint 'Google.Api.Gax.Grpc.ServiceEndpoint'). |
| settings | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') | Optional [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings'). |

##### Example

This sample shows how to create a client using default credentials:

```
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
...
// When running on Google Cloud Platform this will use the project Compute Credential.
// Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
// credential file to use that credential.
PlayerAuthServiceClient client = await PlayerAuthServiceClient.CreateAsync();
```

This sample shows how to create a client using credentials loaded from a JSON file:

```
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
...
GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
Channel channel = new Channel(
    PlayerAuthServiceClient.DefaultEndpoint.Host, PlayerAuthServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
PlayerAuthServiceClient client = PlayerAuthServiceClient.Create(channel);
...
// Shutdown the channel when it is no longer required.
await channel.ShutdownAsync();
```

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDevelopmentAuthenticationToken(projectName,description,callSettings) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the DAT is scoped to. You must have access to this project.

 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A description for the DAT.

 It cannot be empty and has a maximum length of 200 characters. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDevelopmentAuthenticationTokenAsync(projectName,description,callSettings) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the DAT is scoped to. You must have access to this project.

 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A description for the DAT.

 It cannot be empty and has a maximum length of 200 characters. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### CreateDevelopmentAuthenticationTokenAsync(projectName,description,cancellationToken) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the DAT is scoped to. You must have access to this project.

 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A description for the DAT.

 It cannot be empty and has a maximum length of 200 characters. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken-'></a>
### CreateDevelopmentAuthenticationTokenAsync(request,cancellationToken) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginToken-System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateLoginToken(deploymentId,playerIdentityToken,callSettings) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The UUID of the deployment that the user gets access to. |
| playerIdentityToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The player_identity_token is the JWT returned by the
 \`PlayerIdentityTokenService.CreatePlayerIdentityToken\` RPC |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateLoginToken(request,callSettings) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateLoginTokenAsync(deploymentId,playerIdentityToken,callSettings) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The UUID of the deployment that the user gets access to. |
| playerIdentityToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The player_identity_token is the JWT returned by the
 \`PlayerIdentityTokenService.CreatePlayerIdentityToken\` RPC |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### CreateLoginTokenAsync(deploymentId,playerIdentityToken,cancellationToken) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deploymentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The UUID of the deployment that the user gets access to. |
| playerIdentityToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The player_identity_token is the JWT returned by the
 \`PlayerIdentityTokenService.CreatePlayerIdentityToken\` RPC |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateLoginTokenAsync(request,callSettings) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,System-Threading-CancellationToken-'></a>
### CreateLoginTokenAsync(request,cancellationToken) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityToken-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreatePlayerIdentityToken(projectName,provider,playerIdentifier,callSettings) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the PIT is scoped to.
 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only. |
| provider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The system used to authenticate the player with (for example) Steam or Google. This field must
 not be empty. The provider name cannot contain 'improbable' (case insensitive) as this is
 reserved for internal use. |
| playerIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the player for whom who you are generating a PIT.

 This should uniquely identify a user in the specified provider.
 The maximum length is 64 characters. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreatePlayerIdentityToken(request,callSettings) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-System-String,System-String,System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreatePlayerIdentityTokenAsync(projectName,provider,playerIdentifier,callSettings) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the PIT is scoped to.
 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only. |
| provider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The system used to authenticate the player with (for example) Steam or Google. This field must
 not be empty. The provider name cannot contain 'improbable' (case insensitive) as this is
 reserved for internal use. |
| playerIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the player for whom who you are generating a PIT.

 This should uniquely identify a user in the specified provider.
 The maximum length is 64 characters. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-System-String,System-String,System-String,System-Threading-CancellationToken-'></a>
### CreatePlayerIdentityTokenAsync(projectName,provider,playerIdentifier,cancellationToken) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the PIT is scoped to.
 This should be between 3 and 32 characters and made up of lower case letters, numbers and
 underscores only. |
| provider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The system used to authenticate the player with (for example) Steam or Google. This field must
 not be empty. The provider name cannot contain 'improbable' (case insensitive) as this is
 reserved for internal use. |
| playerIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the player for whom who you are generating a PIT.

 This should uniquely identify a user in the specified provider.
 The maximum length is 64 characters. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreatePlayerIdentityTokenAsync(request,callSettings) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,System-Threading-CancellationToken-'></a>
### CreatePlayerIdentityTokenAsync(request,cancellationToken) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityToken-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### DecodePlayerIdentityToken(playerIdentityToken,callSettings) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIdentityToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The PIT that was issued to the user. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DecodePlayerIdentityToken(request,callSettings) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### DecodePlayerIdentityTokenAsync(playerIdentityToken,callSettings) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIdentityToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The PIT that was issued to the user. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-System-String,System-Threading-CancellationToken-'></a>
### DecodePlayerIdentityTokenAsync(playerIdentityToken,cancellationToken) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIdentityToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The PIT that was issued to the user. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DecodePlayerIdentityTokenAsync(request,callSettings) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,System-Threading-CancellationToken-'></a>
### DecodePlayerIdentityTokenAsync(request,cancellationToken) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### ExpireDevelopmentAuthenticationToken(id,callSettings) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT to expire. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ExpireDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(id,callSettings) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT to expire. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-System-String,System-Threading-CancellationToken-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(id,cancellationToken) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT to expire. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(request,cancellationToken) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDevelopmentAuthenticationToken(id,callSettings) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-System-String,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDevelopmentAuthenticationTokenAsync(id,callSettings) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-System-String,System-Threading-CancellationToken-'></a>
### GetDevelopmentAuthenticationTokenAsync(id,cancellationToken) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken-'></a>
### GetDevelopmentAuthenticationTokenAsync(request,cancellationToken) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDevelopmentAuthenticationTokens(projectName,pageToken,pageSize,callSettings) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

A pageable sequence of [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the queried DATs are scoped to. You must have access to this project. |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDevelopmentAuthenticationTokens(request,callSettings) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

A pageable sequence of [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-System-String,System-String,System-Nullable{System-Int32},Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDevelopmentAuthenticationTokensAsync(projectName,pageToken,pageSize,callSettings) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

A pageable asynchronous sequence of [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The project that the queried DATs are scoped to. You must have access to this project. |
| pageToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token returned from the previous request.
A value of `null` or an empty string retrieves the first page. |
| pageSize | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The size of page to request. The response will not be larger than this, but may be smaller.
A value of `null` or 0 uses a server-defined page size. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDevelopmentAuthenticationTokensAsync(request,callSettings) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

A pageable asynchronous sequence of [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-ShutdownDefaultChannelsAsync'></a>
### ShutdownDefaultChannelsAsync() `method`

##### Summary

Shuts down any channels automatically created by [Create](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)'). Channels which weren't automatically
created are not affected.

##### Returns

A task representing the asynchronous shutdown operation.

##### Parameters

This method has no parameters.

##### Remarks

After calling this method, further calls to [Create](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-Create-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.Create(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)')
and [CreateAsync](#M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-CreateAsync-Google-Api-Gax-Grpc-ServiceEndpoint,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings- 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient.CreateAsync(Google.Api.Gax.Grpc.ServiceEndpoint,Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings)') will create new channels, which could
in turn be shut down by another call to this method.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-System-String,Google-Protobuf-WellKnownTypes-Duration,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateDevelopmentAuthenticationToken(id,updatedLifetime,callSettings) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT to update. |
| updatedLifetime | [Google.Protobuf.WellKnownTypes.Duration](#T-Google-Protobuf-WellKnownTypes-Duration 'Google.Protobuf.WellKnownTypes.Duration') | The updated validity period of the DAT starting from the time of this request. This field is
 optional.

 Set this field to update and potentially extend the validity period of the DAT.
 The maximum value is 90 days. If unset, the validity period of the DAT remains unchanged. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-System-String,Google-Protobuf-WellKnownTypes-Duration,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(id,updatedLifetime,callSettings) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT to update. |
| updatedLifetime | [Google.Protobuf.WellKnownTypes.Duration](#T-Google-Protobuf-WellKnownTypes-Duration 'Google.Protobuf.WellKnownTypes.Duration') | The updated validity period of the DAT starting from the time of this request. This field is
 optional.

 Set this field to update and potentially extend the validity period of the DAT.
 The maximum value is 90 days. If unset, the validity period of the DAT remains unchanged. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-System-String,Google-Protobuf-WellKnownTypes-Duration,System-Threading-CancellationToken-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(id,updatedLifetime,cancellationToken) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the DAT to update. |
| updatedLifetime | [Google.Protobuf.WellKnownTypes.Duration](#T-Google-Protobuf-WellKnownTypes-Duration 'Google.Protobuf.WellKnownTypes.Duration') | The updated validity period of the DAT starting from the time of this request. This field is
 optional.

 Set this field to update and potentially extend the validity period of the DAT.
 The maximum value is 90 days. If unset, the validity period of the DAT remains unchanged. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,System-Threading-CancellationToken-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(request,cancellationToken) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to use for this RPC. |

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder'></a>
## PlayerAuthServiceClientBuilder `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

Builder class for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') to provide simple configuration of credentials, endpoint etc.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-Settings'></a>
### Settings `property`

##### Summary

The settings to use for RPCs, or null for the default settings.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-Build'></a>
### Build() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-BuildAsync-System-Threading-CancellationToken-'></a>
### BuildAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-GetChannelPool'></a>
### GetChannelPool() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-GetDefaultEndpoint'></a>
### GetDefaultEndpoint() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientBuilder-GetDefaultScopes'></a>
### GetDefaultScopes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl'></a>
## PlayerAuthServiceClientImpl `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

PlayerAuthService client wrapper implementation, for convenient use.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-#ctor-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient,Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-'></a>
### #ctor(grpcClient,settings) `constructor`

##### Summary

Constructs a client wrapper for the PlayerAuthService service, with the specified gRPC client and settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| grpcClient | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthService-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthService.PlayerAuthServiceClient') | The underlying gRPC client. |
| settings | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') | The base [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') used within this client |

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-GrpcClient'></a>
### GrpcClient `property`

##### Summary

The underlying gRPC PlayerAuthService client.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Creates a \`DevelopmentAuthenticationToken\` (DAT) for a given project.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateLoginToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateLoginToken(request,callSettings) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreateLoginTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreateLoginTokenAsync(request,callSettings) `method`

##### Summary

Creates a \`LoginToken\` (LT) for a given user, project and deployment.

 This grants the user access to a given deployment.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreateLoginTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreatePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreatePlayerIdentityToken(request,callSettings) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-CreatePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### CreatePlayerIdentityTokenAsync(request,callSettings) `method`

##### Summary

Creates a \`PlayerIdentityToken\` (PIT) for a given user and project.

 This identifies players in the context of a project and provider.

 Invalid fields result in an \`InvalidArgument\` error. See the \`CreatePlayerIdentityTokenRequest\`
 message for details of what is valid for each field.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-CreatePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-DecodePlayerIdentityToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DecodePlayerIdentityToken(request,callSettings) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-DecodePlayerIdentityTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### DecodePlayerIdentityTokenAsync(request,callSettings) `method`

##### Summary

Decodes a \`PlayerIdentityToken\` (PIT).

 Tokens that cannot be verified result in an \`InvalidArgument\` error.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DecodePlayerIdentityTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ExpireDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ExpireDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ExpireDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ExpireDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Immediately expires a DAT thereby revoking its validity.

 You can undo this operation by extending the lifetime of an expired DAT using the
 \`UpdateDevelopmentAuthenticationToken\` endpoint. Expired DATs are permanently deleted after one
 week.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ExpireDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ExpireDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-GetDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-GetDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### GetDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Get a DAT given its ID.

 This endpoint returns a NotFound error in case the DAT could not be found.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-GetDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.GetDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ListDevelopmentAuthenticationTokens-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDevelopmentAuthenticationTokens(request,callSettings) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

A pageable sequence of [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-ListDevelopmentAuthenticationTokensAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### ListDevelopmentAuthenticationTokensAsync(request,callSettings) `method`

##### Summary

Lists DATs associated with a project.

##### Returns

A pageable asynchronous sequence of [DevelopmentAuthenticationToken](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-DevelopmentAuthenticationToken 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.DevelopmentAuthenticationToken') resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-ListDevelopmentAuthenticationTokensRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.ListDevelopmentAuthenticationTokensRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-UpdateDevelopmentAuthenticationToken-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateDevelopmentAuthenticationToken(request,callSettings) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

The RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClientImpl-UpdateDevelopmentAuthenticationTokenAsync-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest,Google-Api-Gax-Grpc-CallSettings-'></a>
### UpdateDevelopmentAuthenticationTokenAsync(request,callSettings) `method`

##### Summary

Updates the description and the validity period of a DAT.

 You can use this endpoint to both extend the validity period of valid DATs and renew expired
 DATs.

##### Returns

A Task containing the RPC response.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.UpdateDevelopmentAuthenticationTokenRequest') | The request object containing all of the parameters for the API call. |
| callSettings | [Google.Api.Gax.Grpc.CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') | If not null, applies overrides to this RPC call. |

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings'></a>
## PlayerAuthServiceSettings `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

Settings for a [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient').

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') object with default settings.

##### Parameters

This constructor has no parameters.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-CreateDevelopmentAuthenticationTokenSettings'></a>
### CreateDevelopmentAuthenticationTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken` and `PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken` and
`PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-CreateLoginTokenSettings'></a>
### CreateLoginTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.CreateLoginToken` and `PlayerAuthServiceClient.CreateLoginTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.CreateLoginToken` and
`PlayerAuthServiceClient.CreateLoginTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-CreatePlayerIdentityTokenSettings'></a>
### CreatePlayerIdentityTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.CreatePlayerIdentityToken` and `PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.CreatePlayerIdentityToken` and
`PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-DecodePlayerIdentityTokenSettings'></a>
### DecodePlayerIdentityTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.DecodePlayerIdentityToken` and `PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.DecodePlayerIdentityToken` and
`PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-ExpireDevelopmentAuthenticationTokenSettings'></a>
### ExpireDevelopmentAuthenticationTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken` and `PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken` and
`PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDevelopmentAuthenticationTokenSettings'></a>
### GetDevelopmentAuthenticationTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.GetDevelopmentAuthenticationToken` and `PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.GetDevelopmentAuthenticationToken` and
`PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-IdempotentRetryFilter'></a>
### IdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "Idempotent" [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods.

##### Remarks

The eligible RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s for retry for "Idempotent" RPC methods are:

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-ListDevelopmentAuthenticationTokensSettings'></a>
### ListDevelopmentAuthenticationTokensSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens` and `PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync`.

##### Remarks

The default `PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens` and
`PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-NonIdempotentRetryFilter'></a>
### NonIdempotentRetryFilter `property`

##### Summary

The filter specifying which RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s are eligible for retry
for "NonIdempotent" [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods.

##### Remarks

There are no RPC [StatusCode](#T-Grpc-Core-StatusCode 'Grpc.Core.StatusCode')s eligible for retry for "NonIdempotent" RPC methods.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-UpdateDevelopmentAuthenticationTokenSettings'></a>
### UpdateDevelopmentAuthenticationTokenSettings `property`

##### Summary

[CallSettings](#T-Google-Api-Gax-Grpc-CallSettings 'Google.Api.Gax.Grpc.CallSettings') for synchronous and asynchronous calls to
`PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken` and `PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync`.

##### Remarks

The default `PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken` and
`PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync`[RetrySettings](#T-Google-Api-Gax-Grpc-RetrySettings 'Google.Api.Gax.Grpc.RetrySettings') are:

Retry will be attempted on the following response status codes:

Default RPC expiration is 600000 milliseconds.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-Clone'></a>
### Clone() `method`

##### Summary

Creates a deep clone of this object, with all the same property values.

##### Returns

A deep clone of this [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings') object.

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDefault'></a>
### GetDefault() `method`

##### Summary

Get a new instance of the default [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings').

##### Returns

A new instance of the default [PlayerAuthServiceSettings](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceSettings').

##### Parameters

This method has no parameters.

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDefaultRetryBackoff'></a>
### GetDefaultRetryBackoff() `method`

##### Summary

"Default" retry backoff for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods.

##### Returns

The "Default" retry backoff for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" retry backoff for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods is defined as:

<a name='M-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceSettings-GetDefaultTimeoutBackoff'></a>
### GetDefaultTimeoutBackoff() `method`

##### Summary

"Default" timeout backoff for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods.

##### Returns

The "Default" timeout backoff for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods.

##### Parameters

This method has no parameters.

##### Remarks

The "Default" timeout backoff for [PlayerAuthServiceClient](#T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerAuthServiceClient 'Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthServiceClient') RPC methods is defined as:

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken'></a>
## PlayerIdentityToken `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-DisplayNameFieldNumber'></a>
### DisplayNameFieldNumber `constants`

##### Summary

Field number for the "display_name" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ExpiryTimeFieldNumber'></a>
### ExpiryTimeFieldNumber `constants`

##### Summary

Field number for the "expiry_time" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-IssuedAtTimeFieldNumber'></a>
### IssuedAtTimeFieldNumber `constants`

##### Summary

Field number for the "issued_at_time" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-MetadataFieldNumber'></a>
### MetadataFieldNumber `constants`

##### Summary

Field number for the "metadata" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-PlayerIdentifierFieldNumber'></a>
### PlayerIdentifierFieldNumber `constants`

##### Summary

Field number for the "player_identifier" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ProjectNameFieldNumber'></a>
### ProjectNameFieldNumber `constants`

##### Summary

Field number for the "project_name" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ProviderFieldNumber'></a>
### ProviderFieldNumber `constants`

##### Summary

Field number for the "provider" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-DisplayName'></a>
### DisplayName `property`

##### Summary

The player's display name.

 This corresponds to the \`dn\` claim in the JWT.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ExpiryTime'></a>
### ExpiryTime `property`

##### Summary

Time at which the PIT expires.

 This corresponds to the \`exp\` claim in the JWT.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-IssuedAtTime'></a>
### IssuedAtTime `property`

##### Summary

Time at which the PIT was issued.

 This corresponds to the \`iat\` claim in the JWT.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-Metadata'></a>
### Metadata `property`

##### Summary

Additional metadata that is stored within the PIT.

 This corresponds to the \`md\` claim in the JWT.
 This field is exposed to workers through the Player Connection Entity.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-PlayerIdentifier'></a>
### PlayerIdentifier `property`

##### Summary

The ID of the player.

 This should uniquely identify a user in the specified provider.
 This corresponds to the \`sub\` claim in the JWT.
 This field is exposed to workers through the Player Connection Entity.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-ProjectName'></a>
### ProjectName `property`

##### Summary

The project that the PIT is scoped to.

 This corresponds to the \`prj\` claim in the JWT.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerIdentityToken-Provider'></a>
### Provider `property`

##### Summary

The system that was used to authenticate the player with, for example Steam or Google.

 This corresponds to the \`prvdr\` claim in the JWT.
 This field is exposed to workers through the Player Connection Entity.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerauthReflection'></a>
## PlayerauthReflection `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

##### Summary

Holder for reflection information generated from improbable/spatialos/playerauth/v2alpha1/playerauth.proto

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-PlayerauthReflection-Descriptor'></a>
### Descriptor `property`

##### Summary

File descriptor for improbable/spatialos/playerauth/v2alpha1/playerauth.proto

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest'></a>
## UpdateDevelopmentAuthenticationTokenRequest `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-DescriptionFieldNumber'></a>
### DescriptionFieldNumber `constants`

##### Summary

Field number for the "description" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-IdFieldNumber'></a>
### IdFieldNumber `constants`

##### Summary

Field number for the "id" field.

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-UpdatedLifetimeFieldNumber'></a>
### UpdatedLifetimeFieldNumber `constants`

##### Summary

Field number for the "updated_lifetime" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-Description'></a>
### Description `property`

##### Summary

An updated description for the DAT. This field is optional.

 The maximum length is 200 characters. If unset, the description of the DAT remains unchanged.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-Id'></a>
### Id `property`

##### Summary

The ID of the DAT to update.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenRequest-UpdatedLifetime'></a>
### UpdatedLifetime `property`

##### Summary

The updated validity period of the DAT starting from the time of this request. This field is
 optional.

 Set this field to update and potentially extend the validity period of the DAT.
 The maximum value is 90 days. If unset, the validity period of the DAT remains unchanged.

<a name='T-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenResponse'></a>
## UpdateDevelopmentAuthenticationTokenResponse `type`

##### Namespace

Improbable.SpatialOS.PlayerAuth.V2Alpha1

<a name='F-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationTokenFieldNumber'></a>
### DevelopmentAuthenticationTokenFieldNumber `constants`

##### Summary

Field number for the "development_authentication_token" field.

<a name='P-Improbable-SpatialOS-PlayerAuth-V2Alpha1-UpdateDevelopmentAuthenticationTokenResponse-DevelopmentAuthenticationToken'></a>
### DevelopmentAuthenticationToken `property`

##### Summary

The updated DAT.
