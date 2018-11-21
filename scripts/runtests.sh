#!/usr/bin/env bash

set -e

if [[ $# -ne 1 ]]; then
  echo "Supply the docker image name as the first argument."
  exit 1
fi

DOCKER_IMAGE=$1

echo "--- Running Game Maintenance Scenario"
docker run $DOCKER_IMAGE /bin/bash -c "cd examples/GameMaintenance && dotnet run --no-build --configuration Release"

echo "--- Running Service Account Maintenance Scenario"
docker run $DOCKER_IMAGE /bin/bash -c "cd examples/ServiceAccountMaintenance && dotnet run --no-build --configuration Release"

echo "--- Running Replicate State Scenario"
docker run $DOCKER_IMAGE /bin/bash -c "cd examples && spatial service start --main_config=blank_project/spatialos.json && cd ReplicateState && dotnet run --no-build --configuration Release"

echo "--- Running BYO Auth Scenario"
docker run $DOCKER_IMAGE /bin/bash -c "cd examples && cd BYOAuthFlow && dotnet run --no-build --configuration Release"
