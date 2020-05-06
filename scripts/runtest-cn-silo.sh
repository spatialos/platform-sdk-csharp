#!/usr/bin/env bash

set -e -u -o pipefail

REPO_ROOT="$(dirname "$0")/.."
cd "${REPO_ROOT}"

SDK_VERSION_PREMERGE="888.8.8-PREMERGE"
DOCKER_IMAGE="platform-sdk/csharp:${SDK_VERSION_PREMERGE}"

if [[ -z "${IMPROBABLE_REFRESH_TOKEN+x}" ]]; then
  echo "IMPROBABLE_REFRESH_TOKEN is unset. Please make sure you set this variable to a valid CN silo SpatialOS refresh token."
  exit 1
fi

echo "--- Building docker image"
docker build \
  --build-arg "IMPROBABLE_REFRESH_TOKEN=${IMPROBABLE_REFRESH_TOKEN}" \
  --build-arg "SDK_VERSION=${SDK_VERSION_PREMERGE}" \
  --tag "${DOCKER_IMAGE}" \
  "${REPO_ROOT}"

echo "--- Running CN Silo Scenario"
docker run \
  --workdir="/workspace/examples/CNSilo" \
  "${DOCKER_IMAGE}" \
  /bin/bash -c "dotnet run --no-build --configuration Release"
