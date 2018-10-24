#!/usr/bin/env bash

set -e

if [[ $# -ne 2 ]]; then
  echo "SDK_VERSION, ARTEFACT_DIR must be supplied as the first and second argument."
  echo "SDK_VERSION will set the version of the generated assembly."
  echo "ARTEFACT_DIR will set the output path for the generated zip and NuGet package."
  exit 1
fi

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
OUTPUT_DIR=$REPO_ROOT/apis/sdk/bin/Release
SDK_VERSION=$1
ARTEFACT_DIR=$2

mkdir -p $ARTEFACT_DIR
rm -rf $ARTEFACT_DIR/*
msbuild $REPO_ROOT/apis/sdk/sdk.csproj /p:Configuration=Release /p:Version=${SDK_VERSION} /t:Clean,Build
zip -r ${ARTEFACT_DIR}/${SDK_VERSION}-net451.zip ${OUTPUT_DIR}/net451
cp ${OUTPUT_DIR}/Improbable.SpatialOS.Platform.${SDK_VERSION}.nupkg ${ARTEFACT_DIR}
