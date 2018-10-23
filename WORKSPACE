http_archive(
  name = "bazel_skylib",
  url = "https://github.com/bazelbuild/bazel-skylib/archive/ff23a62c57d2912c3073a69c12f42c3d6e58a957.zip",
  strip_prefix = "bazel-skylib-ff23a62c57d2912c3073a69c12f42c3d6e58a957",
  sha256 = "ccf83f162e4a265b3aa09445c84fbc470215e392b250c86f0ce00536c99d5c17",
)
load("@bazel_skylib//:lib.bzl", "versions")
versions.check(minimum_bazel_version="0.14.0")

load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository", "new_git_repository")

git_repository(
    name = "io_bazel_rules_go",
    remote = "https://github.com/improbable-io/rules_go.git",
    commit = "d22b20a098718f9156f3152e613554860b399c7a",
)
load("@io_bazel_rules_go//go:def.bzl", "go_rules_dependencies", "go_register_toolchains")
go_rules_dependencies()
go_register_toolchains()

git_repository(
    name = "org_pubref_rules_protobuf",
    remote = "https://github.com/pubref/rules_protobuf",
    commit = "5f6195e83e06db2fd110626b0f2dc64e345e6618"
)
load("@org_pubref_rules_protobuf//go:rules.bzl", "go_proto_repositories", "proto_repositories")
go_proto_repositories()
proto_repositories()

# git_repository(
#   name = "com_google_grpc",
#   remote = "https://github.com/grpc/grpc.git",
#   commit = "1a60e6971f428323245a930031ad267bb3142ba4",
#   shallow_since = "2018-10-01",
# #   build_file = "@//third_party/grpc:BUILD",
# )

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet.git",
    commit = "1a6ca96fe05bca83782464453ac4657fb8ed8379"
)

load("@io_bazel_rules_dotnet//dotnet:csharp.bzl", "csharp_repositories")
csharp_repositories(use_local_mono = True)

git_repository(
  name = "org_pubref_rules_protobuf",
  remote = "https://github.com/pubref/rules_protobuf",
  commit = "7c8c80b61e3a0bc30fd61302d781a317524b0167"
)
load("@org_pubref_rules_protobuf//csharp:rules.bzl", "csharp_proto_repositories", "new_nuget_package")
csharp_proto_repositories()

git_repository(
  name = "gapic_generator",
  commit = "08ee52ae36617ca071218f4596aa26230ee82b5b",
  remote = "git@github.com:improbable/sdk-platform-toolkit.git",
)

git_repository(
    name = "improbable_platform",
    remote = "git@github.com:improbable/platform.git",
    commit = "52be31cb52f4a523653d4077832653c10e92ce90",
    shallow_since = "2018-10-10",
)

new_git_repository(
    name = "com_github_googleapis_googleapis",
    remote = "https://github.com/googleapis/googleapis.git",
    commit = "672f0d39cadef1b08b36271a9359e2d169ea0a60",
    build_file = "@//third_party/googleapis:BUILD",
)

git_repository(
    name = "com_github_mwitkow_go_proto_validators_proto",
    commit = "61ea39b6438ad463fc5cc6dbf2ebad1286ce7813",
    remote = "https://github.com/improbable-io/go-proto-validators",
)

new_git_repository(
    name = "com_github_mwitkow_go_proto_validators_proto",
    commit = "61ea39b6438ad463fc5cc6dbf2ebad1286ce7813",
    remote = "https://github.com/improbable-io/go-proto-validators",
    build_file = "@//third_party/proto_validators:BUILD",
    strip_prefix = "src",
)

maven_jar(
    name = "com_atlassian_commonmark_commonmark",
    artifact = "com.atlassian.commonmark:commonmark:0.9.0",
    sha1 = "4eb11e3f9aaecafc6073b84c15f66376ef8dc5d3",
)

maven_jar(
    name = "com_fasterxml_jackson_core_jackson_annotations",
    artifact = "com.fasterxml.jackson.core:jackson-annotations:2.9.0",
    sha1 = "07c10d545325e3a6e72e06381afe469fd40eb701",
)

maven_jar(
    name = "com_fasterxml_jackson_core_jackson_core",
    artifact = "com.fasterxml.jackson.core:jackson-core:2.9.0",
    sha1 = "88e7c6220be3b3497b3074d3fc7754213289b987",
)

maven_jar(
    name = "com_fasterxml_jackson_core_jackson_databind",
    artifact = "com.fasterxml.jackson.core:jackson-databind:2.9.0",
    sha1 = "14fb5f088cc0b0dc90a73ba745bcade4961a3ee3",
)

maven_jar(
    name = "com_google_api_api_common",
    artifact = "com.google.api:api-common:1.1.0",
    sha1 = "14733901500ad0744cebf7adf73045a466ce1a11",
)

maven_jar(
    name = "com_google_api_api_compiler",
    artifact = "com.google.api:api-compiler:0.0.7",
    sha1 = "974c9d5b7d9b6902202f2280839939eb468207fa",
)

maven_jar(
    name = "com_google_api_gax",
    artifact = "com.google.api:gax:1.5.1",
    sha1 = "3bc202725a07394fa13e83c131ca84eb5b212e77",
)

maven_jar(
    name = "com_google_api_grpc_proto_google_common_protos",
    artifact = "com.google.api.grpc:proto-google-common-protos:1.0.5",
    sha1 = "3a5e2e2849a918acbba69154c957c36679441fcf",
)

maven_jar(
    name = "com_google_auto_value_auto_value",
    artifact = "com.google.auto.value:auto-value:1.6",
    sha1 = "a3b1b1404f8acaa88594a017185e013cd342c9a8",
)

maven_jar(
    name = "com_google_auto_value_auto_value_annotations",
    artifact = "com.google.auto.value:auto-value-annotations:1.6",
    sha1 = "da725083ee79fdcd86d9f3d8a76e38174a01892a",
)

maven_jar(
    name = "com_google_code_findbugs_jsr305",
    artifact = "com.google.code.findbugs:jsr305:3.0.0",
    sha1 = "5871fb60dc68d67da54a663c3fd636a10a532948",
)

maven_jar(
    name = "com_google_code_gson_gson",
    artifact = "com.google.code.gson:gson:2.3",
    sha1 = "5fc52c41ef0239d1093a1eb7c3697036183677ce",
)

maven_jar(
    name = "com_google_guava_guava",
    artifact = "com.google.guava:guava:23.0",
    sha1 = "c947004bb13d18182be60077ade044099e4f26f1",
)

maven_jar(
    name = "com_google_inject_guice",
    artifact = "com.google.inject:guice:4.0",
    sha1 = "0f990a43d3725781b6db7cd0acf0a8b62dfd1649",
)

maven_jar(
    name = "commons_cli_commons_cli",
    artifact = "commons-cli:commons-cli:1.4",
    sha1 = "c51c00206bb913cd8612b24abd9fa98ae89719b1",
)

maven_jar(
    name = "io_grpc_grpc_core",
    artifact = "io.grpc:grpc-core:1.0.1",
    sha1 = "dce1c939c2c6110ac571d99f8d2a29b19bdad4db",
)

maven_jar(
    name = "org_apache_commons_commons_lang3",
    artifact = "org.apache.commons:commons-lang3:3.6",
    sha1 = "9d28a6b23650e8a7e9063c04588ace6cf7012c17",
)

maven_jar(
    name = "org_threeten_threetenbp",
    artifact = "org.threeten:threetenbp:1.3.3",
    sha1 = "3ea31c96676ff12ab56be0b1af6fff61d1a4f1f2",
)

maven_jar(
    name = "org_yaml_snakeyaml",
    artifact = "org.yaml:snakeyaml:1.18",
    sha1 = "e4a441249ade301985cb8d009d4e4a72b85bf68e",
)

maven_jar(
    name = "cglib_cglib",
    artifact = "cglib:cglib:3.1",
    sha1 = "1f1cb6c7a7479e0c7fd7987109e503914bebe84a",
)

maven_jar(
    name = "javax_inject_javax_inject",
    artifact = "javax.inject:javax.inject:1",
    sha1 = "6975da39a7040257bd51d21a231b76c915872d38",
)

maven_jar(
    name = "org_ow2_asm_asm",
    artifact = "org.ow2.asm:asm:4.2",
    sha1 = "4b2c12b92dd045aeabf5b2aeeb3220bf010da9d4",
)
