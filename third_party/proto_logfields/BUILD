package(default_visibility = ["//visibility:public"])

exports_files(["logfields.proto"])

proto_library(
    name = "logfields_proto",
    srcs = [
       "github.com/improbable-io/go-proto-logfields/logfields.proto",
    ],
    deps = [
       "@com_google_protobuf//:descriptor_proto",
    ],
)

filegroup(
    name = "proto",
    srcs = ["github.com/improbable-io/go-proto-logfields/logfields.proto"],
)
