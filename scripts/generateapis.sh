#!/usr/bin/env bash

set -e

REPO_ROOT=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)

generate_api() {
    NAME=$1
    VERSION=$2
    PACKAGE=apis/${NAME}_${VERSION}

    bazel build //$PACKAGE:gapic
    bazel build //$PACKAGE:grpc
    rm -rf $PACKAGE/*.cs
    cp -R $REPO_ROOT/bazel-genfiles/$PACKAGE/${NAME}_gapicout/*/*/*.cs $REPO_ROOT/$PACKAGE
    cp -R $REPO_ROOT/bazel-genfiles/$PACKAGE/*.cs $REPO_ROOT/$PACKAGE
}

generate_api 'deployment' 'v1alpha1'
generate_api 'snapshot' 'v1alpha1'
generate_api 'serviceaccount' 'v1alpha1'
generate_api 'playerauth' 'v2alpha1'
