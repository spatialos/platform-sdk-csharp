#!/usr/bin/env bash

set -e

generate_api() {
    NAME=$1
    VERSION=$2
    PACKAGE=apis/sdk/${NAME}_${VERSION}

    bazel build //$PACKAGE:gapic
    bazel build //$PACKAGE:grpc
    rm -rf $PACKAGE/*.cs
    cp -R bazel-genfiles/$PACKAGE/${NAME}_gapicout/*/*/*.cs $PACKAGE
    cp -R bazel-genfiles/$PACKAGE/*.cs $PACKAGE
}

generate_api 'deployment' 'v1alpha1'
generate_api 'snapshot' 'v1alpha1'
generate_api 'serviceaccount' 'v1alpha1'
