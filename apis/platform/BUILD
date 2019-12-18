load("@com_google_googleapis_imports//:imports.bzl", "csharp_proto_library")

csharp_proto_library(
    name = "auth_csharp_proto",
    visibility = ["//visibility:private"],
    deps = ["@improbable_platform//proto/improbable/ext/plugin/auth:native_proto_library"],
)

csharp_proto_library(
    name = "cli_csharp_proto",
    visibility = ["//visibility:private"],
    deps = ["@improbable_platform//proto/github.com/improbable/protoc-gen-gocli:native_proto_library"],
)

csharp_proto_library(
    name = "logfields_csharp_proto",
    visibility = ["//visibility:private"],
    deps = ["@com_github_improbable_io_go_proto_logfields//:logfields_proto"],
)

csharp_proto_library(
    name = "validators_csharp_proto",
    visibility = ["//visibility:private"],
    deps = ["@com_github_mwitkow_go_proto_validators//:validators_proto"],
)
