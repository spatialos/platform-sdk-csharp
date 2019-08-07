#!/usr/bin/env bash

set -e -u -o pipefail

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
cd "${REPO_ROOT}"

PACKAGE_DIR="${REPO_ROOT}/artefacts"
BIN_DIR="${REPO_ROOT}/apis/bin/Release"
TARGET_FRAMEWORK="netstandard1.6"

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
rm -rf "${PACKAGE_DIR}"
mkdir -p "${PACKAGE_DIR}"

echo "--- Preparing artefacts for release"
dotnet build apis/apis.csproj --configuration Release --framework "${TARGET_FRAMEWORK}"
dotnet pack apis/apis.csproj --no-build --configuration Release -p:"PackageVersion=${SDK_VERSION}"

pushd "${BIN_DIR}/${TARGET_FRAMEWORK}"
zip -r "${PACKAGE_DIR}/${SDK_VERSION}.zip" ./*
popd

cp "${BIN_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg" "${PACKAGE_DIR}"

echo "--- Publishing to NuGet"
dotnet nuget push "${PACKAGE_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg" \
  --source https://api.nuget.org/v3/index.json \
  --api-key "${NUGET_API_KEY}"

echo "--- Publishing to SpatialOS Package service"
package_client publish platform_sdk csharp "${SDK_VERSION}" "${PACKAGE_DIR}/${SDK_VERSION}.zip"
