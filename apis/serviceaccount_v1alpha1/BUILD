package(default_visibility = ["//visibility:public"])

load("//apis:rules.bzl", "gapic_generator_codegen")

gapic_generator_codegen(
    name = "gapic",
    outs = [
        "serviceaccount_gapicout/Improbable.SpatialOS.ServiceAccount.V1Alpha1/Improbable.SpatialOS.ServiceAccount.V1Alpha1/ServiceAccountServiceClient.cs"
    ],
    descriptor_set = "//apis:platform_api_descriptor_set",
    gapic_yaml = "@improbable_platform//proto/improbable/spatialos/serviceaccount/v1alpha1:csharp_gapic",
    package_yaml = "//apis:package_yaml",
    service_yaml = "@improbable_platform//proto/improbable/spatialos/serviceaccount:serviceaccount_v1alpha1.yaml",
)

load("@org_pubref_rules_protobuf//csharp:rules.bzl", "csharp_proto_compile")
csharp_proto_compile(
    name = "grpc",
    imports = [
        "external/com_github_googleapis_googleapis/",
        "external/com_github_mwitkow_go_proto_validators_proto/",
        "external/com_google_protobuf/src/",
    ],
    inputs = [
        "@com_github_googleapis_googleapis//:important_protos",
        "@com_github_mwitkow_go_proto_validators_proto//:proto",
        "@com_google_protobuf//:well_known_protos",
    ],
    protos = [
        "@improbable_platform//proto/improbable/spatialos/serviceaccount:protos",
    ],
    with_grpc = True,
)
