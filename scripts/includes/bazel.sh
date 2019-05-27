#!/usr/bin/env bash

source scripts/includes/os.sh

if isLinux; then
  DEFAULT_BAZEL_CONFIG="k8-gcc-opt"
elif isMacOS; then
  DEFAULT_BAZEL_CONFIG="darwin-opt-clang"
else
  DEFAULT_BAZEL_CONFIG="x64_windows-opt-msvc_md"
fi

# By convention bazel config's names are identical to their output folder names.
DEFAULT_BAZEL_OUT="bazel-out/${DEFAULT_BAZEL_CONFIG}"
DEFAULT_BAZEL_BIN="${DEFAULT_BAZEL_OUT}/bin"

# Main function that should be used by scripts sourcing this file.
function runBazel() {
  "$(pwd)/tools/bazel" "$@"
}

function copyBazelOutput() {
  cp -Rf "$1" "$2"
  chmod +w "$2"
}
