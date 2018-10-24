#!/usr/bin/env bash

set -e

if [[ $# -ne 1 ]]; then
  echo "Supply the docker image name as the first argument."
  exit 1
fi

DOCKER_IMAGE=$1

docker run $DOCKER_IMAGE /bin/bash -c "cd apis/GameMaintenance && dotnet run --no-build --configuration Release"
docker run $DOCKER_IMAGE /bin/bash -c "cd apis/ServiceAccountMaintenance && dotnet run --no-build --configuration Release"
docker run $DOCKER_IMAGE /bin/bash -c "cd apis && spatial service start --main_config=blank_project/spatialos.json && cd ReplicateState && dotnet run --no-build --configuration Release"
