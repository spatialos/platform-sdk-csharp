#!/usr/bin/env bash

set -e -u -x -o pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
cd "${REPO_ROOT}"

source scripts/includes/bazel.sh

generate_api() {
    NAME="$1"
    VERSION="$2"
    PACKAGE="apis/${NAME}_${VERSION}"

    runBazel build "//${PACKAGE}:gapic"
    runBazel build "//${PACKAGE}:grpc"
    rm -rf ${PACKAGE}/*.cs
    copyBazelOutput "bazel-genfiles/${PACKAGE}/${NAME}_gapicout/*/*/*.cs" "${REPO_ROOT}/${PACKAGE}"
    copyBazelOutput "bazel-genfiles/${PACKAGE}/*.cs" "${REPO_ROOT}/${PACKAGE}"
}

generate_api "deployment" "v1alpha1"
generate_api "snapshot" "v1alpha1"
generate_api "serviceaccount" "v1alpha1"
generate_api "playerauth" "v2alpha1"
