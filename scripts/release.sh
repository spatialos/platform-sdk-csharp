#!/usr/bin/env bash

set -euo pipefail

if [[ -z ${SDK_VERSION+x} ]]; 
then 
    echo "Pls provide SDK_VERSION."
    exit 1
fi

if [[ -z ${NUGET_API_KEY+x} ]]; 
then 
    echo "NUGET_API_KEY is unset."
    # echo "Trying to retrieve from vaults."
    # IMPROBABLE_REFRESH_TOKEN="$(imp-ci secrets read --environment=production --buildkite-org=improbable --secret-type=spatialos-service-account --secret-name=platform-sdk)"
fi

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
DOCKER_IMAGE=platform-sdk/csharp
ARTEFACT_DIR=$REPO_ROOT/artefacts
OUTPUT_DIR=$REPO_ROOT/apis/bin/Release

echo "--- Clearing artefacts from previous runs"
mkdir -p $ARTEFACT_DIR
rm -rf $ARTEFACT_DIR/*

echo "--- Preparing artefacts for release"
msbuild $REPO_ROOT/apis/sdk/sdk.csproj /p:Configuration=Release /p:Version=${SDK_VERSION} /t:Clean,Build -verbosity:minimal
zip -r ${ARTEFACT_DIR}/${SDK_VERSION}-net451.zip ${OUTPUT_DIR}/net451
cp ${OUTPUT_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg ${ARTEFACT_DIR}

echo "--- Publishing to NuGet"
nuget setApiKey ${NUGET_API_KEY}
nuget push ${ARTEFACT_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg -Source https://api.nuget.org/v3/index.json

echo "--- Publishing to SpatialOS Package service"
package_client publish platform_sdk csharp $SDK_VERSION ${ARTEFACT_DIR}/${SDK_VERSION}-net451.zip
