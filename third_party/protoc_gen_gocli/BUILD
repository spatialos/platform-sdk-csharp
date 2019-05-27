package(default_visibility = ["//visibility:public"])

exports_files(["cli.proto"])

proto_library(
    name = "gocli_proto",
    srcs = [
       "github.com/improbable/protoc-gen-gocli/cli.proto",
    ],
    deps = [
       "@com_google_protobuf//:descriptor_proto",
    ],
)

filegroup(
    name = "proto",
    srcs = ["github.com/improbable/protoc-gen-gocli/cli.proto"],
)
