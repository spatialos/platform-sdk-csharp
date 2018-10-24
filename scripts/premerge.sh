#!/usr/bin/env bash

set -euo pipefail

if [[ -z ${IMPROBABLE_REFRESH_TOKEN+x} ]]; 
then 
    echo "IMPROBABLE_REFRESH_TOKEN is unset."
    echo "Trying to retrieve from vaults."
    IMPROBABLE_REFRESH_TOKEN="$(imp-ci secrets read --environment=production --buildkite-org=improbable --secret-type=spatialos-service-account --secret-name=platform-sdk --field=token)"
fi

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
SDK_VERSION_PREMERGE=888.8.8-PREMERGE
DOCKER_IMAGE=platform-sdk/csharp:$SDK_VERSION_PREMERGE

docker build --build-arg IMPROBABLE_REFRESH_TOKEN=$IMPROBABLE_REFRESH_TOKEN --build-arg SDK_VERSION=$SDK_VERSION_PREMERGE -t $DOCKER_IMAGE $REPO_ROOT
$REPO_ROOT/scripts/runtests.sh $DOCKER_IMAGE
