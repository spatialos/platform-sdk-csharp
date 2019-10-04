#!/usr/bin/env bash

set -e -u -x -o pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
cd "${REPO_ROOT}"

source scripts/includes/bazel.sh

function generate_api() {
    NAME="$1"
    VERSION="$2"
    PACKAGE="apis/${NAME}_${VERSION}"

    find "${REPO_ROOT}/${PACKAGE}" -type f -name "*.cs" -exec rm -f {} \+

    runBazel build "//${PACKAGE}:gapic"
    runBazel build "//${PACKAGE}:grpc"

    find "bazel-genfiles/${PACKAGE}" -type f -name "*.cs" -exec cp {} "${REPO_ROOT}/${PACKAGE}" \;
    find "${REPO_ROOT}/${PACKAGE}" -type f -name "*.cs" -exec chmod +w {} \+
}

generate_api "deployment" "v1beta1"
generate_api "playerauth" "v2alpha1"
generate_api "remoteinteraction" "v1alpha1"
generate_api "serviceaccount" "v1alpha1"
generate_api "snapshot" "v1alpha1"
