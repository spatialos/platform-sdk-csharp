package(default_visibility = ["//visibility:public"])

load("//apis:rules.bzl", "gapic_generator_codegen")

gapic_generator_codegen(
    name = "gapic",
    outs = [
        "playerauth_gapicout/Improbable.SpatialOS.PlayerAuth.V2Alpha1/Improbable.SpatialOS.PlayerAuth.V2Alpha1/PlayerAuthServiceClient.cs"
    ],
    descriptor_set = "//apis:platform_api_descriptor_set",
    gapic_yaml = "@improbable_platform//proto/improbable/spatialos/playerauth/v2alpha1:csharp_gapic",
    package_yaml = "//apis:package_yaml",
    service_yaml = "@improbable_platform//proto/improbable/spatialos/playerauth:playerauth_v2alpha1.yaml",
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
        "@com_google_protobuf//:well_known_protos",
        "@com_github_googleapis_googleapis//:important_protos",
        "@com_github_mwitkow_go_proto_validators_proto//:proto",
    ],
    protos = [
        "@improbable_platform//proto/improbable/spatialos/playerauth/v2alpha1:protos",
    ],
    with_grpc = True,
)
