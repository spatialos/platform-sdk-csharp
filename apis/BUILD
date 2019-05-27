package(default_visibility = ["//visibility:public"])

genrule(
    name = "package_yaml",
    outs = ["package.yaml"],
    cmd = """
echo "
articact_type: GAPIC
api_name: platform
api_version: v1
organization_name: improbable
proto_path: improbable.spatial_os" > $@
""",
)

load("//apis:rules.bzl", "proto_descriptor")
proto_descriptor(
    name = "platform_api_descriptor_set",
    out = "platform_api_descriptor_set.pb",
    proto_library = ":platform_api_proto_library",
)

proto_library(
    name = "platform_api_proto_library",
    srcs = [
        ":platform_api_protos",
    ],
    deps = [
        "@improbable_protoc_gen_gocli//:gocli_proto",
        "@com_github_improbable_io_go_proto_logfields_proto//:logfields_proto",
        "@com_github_googleapis_googleapis//:important_protos_lib",
        "@com_github_mwitkow_go_proto_validators_proto//:validator_proto",
        "@com_google_protobuf//:field_mask_proto",
        "@com_google_protobuf//:timestamp_proto",
        "@com_google_protobuf//:duration_proto",
        "@com_google_protobuf//:empty_proto",
    ],
)

filegroup(
    name = "platform_api_protos",
    srcs = [
        "@improbable_platform//proto/improbable/spatialos/deployment:protos",
        "@improbable_platform//proto/improbable/spatialos/snapshot:protos",
        "@improbable_platform//proto/improbable/spatialos/serviceaccount:protos",
        "@improbable_platform//proto/improbable/spatialos/playerauth/v1alpha1:protos",
        "@improbable_platform//proto/improbable/spatialos/playerauth/v2alpha1:protos",
    ],
)

# load("@org_pubref_rules_protobuf//protobuf:rules.bzl", "proto_language")
# proto_language(
#     name = "csharp",
#     grpc_file_extensions = ["Grpc.cs"],
#     grpc_plugin = "@com_google_grpc//:grpc_csharp_plugin",
#     grpc_plugin_name = "grpc_csharp",
#     output_file_style = "pascal",
#     output_to_libdir = True,
#     pb_file_extensions = [".cs"],
#     supports_grpc = True,
# )
