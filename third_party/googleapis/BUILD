package(default_visibility = ["//visibility:public"])

licenses(["permissive"])

filegroup(
    name = "api_proto",
    srcs = glob([
        "google/api/**/*.proto",
    ]),
)

filegroup(
    name = "important_protos",
    srcs = [
        "google/api/annotations.proto",
        "google/api/http.proto",
        "google/longrunning/operations.proto",
        "google/rpc/status.proto",
    ],
)

proto_library(
    name = "status_proto",
    srcs = ["google/rpc/status.proto"],
    deps = [
        "@com_google_protobuf//:any_proto",
    ],
)

proto_library(
    name = "operations_proto",
    srcs = ["google/longrunning/operations.proto"],
    deps = [
        ":api_protos",
        ":status_proto",
        "@com_google_protobuf//:any_proto",
        "@com_google_protobuf//:empty_proto",
    ],
)

proto_library(
    name = "important_protos_lib",
    srcs = [
        "google/api/annotations.proto",
        "google/api/http.proto",
        "google/longrunning/operations.proto",
        "google/rpc/status.proto",
    ],
    deps = [
        "@com_google_protobuf//:any_proto",
        "@com_google_protobuf//:descriptor_proto",
        "@com_google_protobuf//:empty_proto",
    ],
)
