#!/usr/bin/env bash

set -e

RELEASE_BRANCH=$(git symbolic-ref --short HEAD)
dotnet build /p:Configuration=Release /p:Version=${RELEASE_BRANCH} apis/sdk/sdk.csproj
