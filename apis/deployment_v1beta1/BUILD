package(default_visibility = ["//visibility:public"])

load("//apis:rules.bzl", "gapic_generator_codegen")

gapic_generator_codegen(
    name = "gapic",
    outs = [
        "deployment_gapicout/Improbable.SpatialOS.Deployment.V1Beta1/Improbable.SpatialOS.Deployment.V1Beta1/DeploymentServiceClient.cs"
    ],
    descriptor_set = "//apis:platform_api_descriptor_set",
    gapic_yaml = "@improbable_platform//proto/improbable/spatialos/deployment/v1beta1:csharp_gapic",
    package_yaml = "//apis:package_yaml",
    service_yaml = "@improbable_platform//proto/improbable/spatialos/deployment:deployment_v1beta1.yaml",
)

load("@org_pubref_rules_protobuf//csharp:rules.bzl", "csharp_proto_compile")
csharp_proto_compile(
    name = "grpc",
    imports = [
        "external/com_github_googleapis_googleapis/",
        "external/com_github_improbable_io_go_proto_logfields_proto/",
        "external/com_github_mwitkow_go_proto_validators_proto/",
        "external/com_google_protobuf/src/",
        "external/improbable_protoc_gen_gocli/",
    ],
    inputs = [
        "@com_github_googleapis_googleapis//:important_protos",
        "@com_github_mwitkow_go_proto_validators_proto//:proto",
        "@com_github_improbable_io_go_proto_logfields_proto//:proto",
        "@com_google_protobuf//:well_known_protos",
        "@improbable_protoc_gen_gocli//:proto",
    ],
    protos = [
        "@improbable_platform//proto/improbable/spatialos/deployment/v1beta1:protos",
    ],
    with_grpc = True,
)
