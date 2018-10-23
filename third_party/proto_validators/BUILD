package(default_visibility = ["//visibility:public"])

proto_library(
    name = "validator_proto",
    srcs = ["github.com/mwitkow/go-proto-validators/validator.proto"],
    deps = ["@com_google_protobuf//:descriptor_proto"],
)

exports_files(["validator.proto"])

filegroup(
    name = "proto",
    srcs = ["github.com/mwitkow/go-proto-validators/validator.proto"],
)