#!/usr/bin/env bash

set -e -u -o pipefail

REPO_ROOT="$(dirname "$0")/.."
cd "${REPO_ROOT}"

DOCKER_IMAGE="platform-sdk/csharp"
ARTEFACT_DIR="${REPO_ROOT}/artefacts"
OUTPUT_DIR="${REPO_ROOT}/apis/bin/Release"

if [[ -z "${SDK_VERSION+x}" ]]; then
  echo "Please set the SDK_VERSION environment variable to the correct version."
  exit 1
fi

if [[ -z "${NUGET_API_KEY+x}" ]]; then
  echo "Please set the NUGET_API_KEY environment variable."
  # echo "Trying to retrieve from vaults."
  # IMPROBABLE_REFRESH_TOKEN="$(imp-ci secrets read --environment=production --buildkite-org=improbable --secret-type=spatialos-service-account --secret-name=platform-sdk)"
fi

echo "--- Clearing artefacts from previous runs"
rm -rf "${ARTEFACT_DIR}"
mkdir -p "${ARTEFACT_DIR}"

echo "--- Preparing artefacts for release"
msbuild "${REPO_ROOT}/apis/apis.csproj" \
  /p:Configuration=Release \
  /p:Version="${SDK_VERSION}" \
  /t:Clean,Build \
  -verbosity:minimal

pushd "${OUTPUT_DIR}/net451"
  zip -r "${ARTEFACT_DIR}/${SDK_VERSION}-net451.zip" *
popd

cp "${OUTPUT_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg" "${ARTEFACT_DIR}"

echo "--- Publishing to NuGet"
nuget setApiKey "${NUGET_API_KEY}"
nuget push "${ARTEFACT_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg" -Source https://api.nuget.org/v3/index.json

echo "--- Publishing to SpatialOS Package service"
package_client publish platform_sdk csharp "${SDK_VERSION}" "${ARTEFACT_DIR}/${SDK_VERSION}-net451.zip"

