#!/usr/bin/env bash

set -e -u -o pipefail

REPO_ROOT="$(dirname "$0")/.."
cd "${REPO_ROOT}"

SDK_VERSION_PREMERGE="888.8.8-PREMERGE"
DOCKER_IMAGE="platform-sdk/csharp:${SDK_VERSION_PREMERGE}"

if [[ -z "${IMPROBABLE_REFRESH_TOKEN+x}" ]]; 
then 
    echo "IMPROBABLE_REFRESH_TOKEN is unset."
    echo "Trying to retrieve from vaults."
    IMPROBABLE_REFRESH_TOKEN="$(imp-ci secrets read \
      --environment=production \
      --buildkite-org=improbable \
      --secret-type=spatialos-service-account \
      --secret-name=platform-sdk \
      --field=token
    )"
fi

echo "--- Regenerating APIs"
echo "Skipping until bazel is available on the agent"
# scripts/generateapis.sh

echo "--- Preparing docker image for premerge"
docker build \
  --build-arg "IMPROBABLE_REFRESH_TOKEN=${IMPROBABLE_REFRESH_TOKEN}" \
  --build-arg "SDK_VERSION=${SDK_VERSION_PREMERGE}" \
  --tag "${DOCKER_IMAGE}" \
  "${REPO_ROOT}"

echo "--- Running scenarios in docker"
scripts/runtests.sh "${DOCKER_IMAGE}"

