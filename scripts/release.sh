#!/usr/bin/env bash

set -e

if [[ $# -ne 2 ]]; then
  echo "SDK_VERSION, NUGET_API_KEY must be supplied as the first and second argument."
  exit 1
fi

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
ARTEFACT_DIR=$REPO_ROOT/artefacts
SDK_VERSION=$1
NUGET_API_KEY=$2

$REPO_ROOT/scripts/build.sh $SDK_VERSION $ARTEFACT_DIR

nuget setApiKey ${NUGET_API_KEY}
nuget push ${ARTEFACT_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg -Source https://api.nuget.org/v3/index.json
