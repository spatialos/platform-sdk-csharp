#!/usr/bin/env bash

set -e -u -o pipefail

if [[ "$#" -ne 1 ]]; then
  echo "Supply the docker image name as the first argument."
  exit 1
fi

DOCKER_IMAGE="$1"

echo "--- Running Game Maintenance Scenario"
docker run \
  --workdir="/workspace/examples/GameMaintenance" \
  "${DOCKER_IMAGE}" \
  /bin/bash -c "dotnet run --no-build --configuration Release"

echo "--- Running Service Account Maintenance Scenario"
docker run \
  --workdir="/workspace/examples/ServiceAccountMaintenance" \
  "${DOCKER_IMAGE}" \
  /bin/bash -c "dotnet run --no-build --configuration Release"

echo "--- Running Replicate State Scenario"
docker run \
  --workdir="/workspace/examples" \
  "${DOCKER_IMAGE}" \
  /bin/bash -c "spatial service start --main_config=blank_project/spatialos.json && cd ReplicateState && dotnet run --no-build --configuration Release"

echo "--- Running BYO Auth Scenario"
docker run \
  --workdir="/workspace/examples/BYOAuthFlow" \
  "${DOCKER_IMAGE}" \
  /bin/bash -c "dotnet run --no-build --configuration Release"

echo "--- Running Capacity Limit Scenario"
docker run \
  --workdir="/workspace/examples/CapacityLimit" \
  "${DOCKER_IMAGE}" \
  /bin/bash -c "dotnet run --no-build --configuration Release"

