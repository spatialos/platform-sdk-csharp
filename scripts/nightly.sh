#!/usr/bin/env bash

set -euo pipefail

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
SDK_VERSION_NIGHTLY=999.9.9-NIGHTLY
DOCKER_IMAGE=platform-sdk/csharp:$SDK_VERSION_NIGHTLY

if [[ -z ${IMPROBABLE_REFRESH_TOKEN+x} ]]; 
then 
    echo "IMPROBABLE_REFRESH_TOKEN is unset."
    echo "Trying to retrieve from vaults."
    IMPROBABLE_REFRESH_TOKEN="$(imp-ci secrets read --environment=production --buildkite-org=improbable --secret-type=spatialos-service-account --secret-name=platform-sdk --field=token)"
fi

echo "--- regenerating APIs"
echo "skipping until bazel is available on the agent"
# $REPO_ROOT/scripts/generateapis.sh

echo "--- Preparing docker image for nightly"
docker build --build-arg IMPROBABLE_REFRESH_TOKEN=$IMPROBABLE_REFRESH_TOKEN --build-arg SDK_VERSION=$SDK_VERSION_NIGHTLY -t $DOCKER_IMAGE $REPO_ROOT

echo "--- Running scenarios in docker"
$REPO_ROOT/scripts/runtests.sh $DOCKER_IMAGE
