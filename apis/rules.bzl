load(
    "@com_google_googleapis_imports//:imports.bzl",
    "csharp_gapic_assembly_pkg",
    "csharp_gapic_library",
    "csharp_grpc_library",
    "csharp_proto_library",
    "proto_library_with_info",
)

def platform_sdk_package(name):
    """
    'platform_sdk_package' generates a series of inter-dependent targets that
    result in a 'csharp_gapic_assembly_pkg' target with the specified name. This
    final target supports the code generation required for the Platform SDK
    sources that are available to SpatialOS developers as both Nuget packages
    and via Improbable's package service.
    """
    target_service = native.package_name()
    if not target_service.startswith("apis/"):
        fail("The 'gapic_csharp_library' macro should only be used within the 'apis' folder of the repository.")

    target_service = target_service[len("apis/"):]

    proto_library_with_info(
        name = "proto_with_info",
        deps = ["@improbable_platform//proto/improbable/spatialos/" + target_service + ":native_proto_library"],
    )

    csharp_proto_library(
        name = "csharp_proto",
        visibility = ["//visibility:private"],
        deps = ["@improbable_platform//proto/improbable/spatialos/" + target_service + ":native_proto_library"],
    )

    csharp_grpc_library(
        name = "csharp_grpc",
        srcs = ["@improbable_platform//proto/improbable/spatialos/" + target_service + ":native_proto_library"],
        visibility = ["//visibility:private"],
        deps = [":csharp_proto"],
    )

    csharp_gapic_library(
        name = "csharp_gapic",
        src = ":proto_with_info",
        gapic_yaml = "@improbable_platform//proto/improbable/spatialos/" + target_service + ":gapic_api.yaml",
        service_yaml = "@improbable_platform//proto/improbable/spatialos/" + target_service + ":gapic_service.yaml",
        visibility = ["//visibility:private"],
        deps = [
            ":csharp_grpc",
            ":csharp_proto",
            "//apis:platform_common",
        ],
    )

    csharp_gapic_assembly_pkg(
        name = name,
        visibility = ["//visibility:public"],
        deps = [
            ":csharp_gapic",
            ":csharp_grpc",
            ":csharp_proto",
        ],
    )
