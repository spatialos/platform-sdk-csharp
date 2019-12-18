workspace(name = "improbable_platform_sdk_csharp")

load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# A library of helper methods for Starlark. Contains version checking function, so needs to be
# loaded first.
http_archive(
    name = "bazel_skylib",
    sha256 = "a8677c64e2a58eb113f305784e6af9759cfa3f9a6eacb4d40531fe1bd6356aca",
    strip_prefix = "bazel-skylib-0.9.0",
    urls = [
        "https://github.com/bazelbuild/bazel-skylib/archive/0.9.0.zip",
    ],
)

load("@bazel_skylib//:workspace.bzl", "bazel_skylib_workspace")

bazel_skylib_workspace()

load("@bazel_skylib//lib:versions.bzl", "versions")

BAZEL_VERSION = "1.2.1"

GO_VERSION = "1.13.5"  # Does not affect the repository but it is required to load dependencies.

versions.check(
    minimum_bazel_version = BAZEL_VERSION,
    maximum_bazel_version = BAZEL_VERSION,
)

################################################################################
# Improbable-specific dependencies
################################################################################

git_repository(
    name = "improbable_platform",
    commit = "9b3725e398a62f311844ccf96e8d0a561046c089",
    remote = "git@github.com:improbable/platform.git",
    # Hello! Are you updating the commit of the platform repo dependency? This comment is for you!
    # The "shallow_since" field must be set to the day *before* the day of the commit. You can run
    # the following script inside the *platform* repo to determine the value you should put in the
    # "shallow_since" field based on the commit (replace <commit> with the actual commit hash):
    # $ date --date="$(git show --pretty=format:'%cD' <commit> | head --lines=1)-1 day" "+%F"
    shallow_since = "2020-10-02",
)

# Required as it's a dependency of proto-validators.
http_archive(
    name = "io_bazel_rules_go",
    sha256 = "e88471aea3a3a4f19ec1310a55ba94772d087e9ce46e41ae38ecebe17935de7b",
    urls = [
        "https://github.com/bazelbuild/rules_go/releases/download/v0.20.3/rules_go-v0.20.3.tar.gz",
    ],
)

load("@io_bazel_rules_go//go:deps.bzl", "go_register_toolchains", "go_rules_dependencies")

go_rules_dependencies()

go_register_toolchains(go_version = GO_VERSION)

http_archive(
    name = "com_github_mwitkow_go_proto_validators",
    sha256 = "fcff094c16b683f95b80f73f84289f3567a896764a9356acd5ca9e69628480e4",
    strip_prefix = "go-proto-validators-f73ec5a7ce82b3f9fb47f01d4629aa4617247af5",
    urls = [
        "https://github.com/mwitkow/go-proto-validators/archive/f73ec5a7ce82b3f9fb47f01d4629aa4617247af5.zip",
    ],
)

http_archive(
    name = "com_github_improbable_io_go_proto_logfields",
    sha256 = "92325807c37cb1ef059b104adbe9ba7363bfd1bb9ce56e3d2e81fac776242664",
    strip_prefix = "go-proto-logfields-7d343fec6f0818cd516c1fc26fc6a5d9845afad5",
    urls = [
        "https://github.com/improbable-io/go-proto-logfields/archive/7d343fec6f0818cd516c1fc26fc6a5d9845afad5.zip",
    ],
)

git_repository(
    name = "com_github_improbable_protoc_gen_gocli",
    commit = "f13d85d151a5a55541a139ebf88fe571c4b3f496",
    remote = "git@github.com:improbable/protoc-gen-gocli.git",
    shallow_since = "1573823803 +0000",
)

################################################################################
# Protobuf / gRPC dependencies
################################################################################

http_archive(
    name = "com_google_protobuf",
    sha256 = "e4f8bedb19a93d0dccc359a126f51158282e0b24d92e0cad9c76a9699698268d",
    strip_prefix = "protobuf-3.11.2",
    urls = [
        # When updating this dependency please ensure you also update the C# NuGet dependency's version in apis/apis.csproj.
        "https://github.com/protocolbuffers/protobuf/archive/v3.11.2.zip",
    ],
)

load("@com_google_protobuf//:protobuf_deps.bzl", "protobuf_deps")

protobuf_deps()

http_archive(
    name = "rules_proto",
    sha256 = "602e7161d9195e50246177e7c55b2f39950a9cf7366f74ed5f22fd45750cd208",
    strip_prefix = "rules_proto-97d8af4dc474595af3900dd85cb3a29ad28cc313",
    urls = [
        "https://mirror.bazel.build/github.com/bazelbuild/rules_proto/archive/97d8af4dc474595af3900dd85cb3a29ad28cc313.tar.gz",
        "https://github.com/bazelbuild/rules_proto/archive/97d8af4dc474595af3900dd85cb3a29ad28cc313.tar.gz",
    ],
)

load("@rules_proto//proto:repositories.bzl", "rules_proto_dependencies", "rules_proto_toolchains")

rules_proto_dependencies()

rules_proto_toolchains()

http_archive(
    name = "com_github_grpc_grpc",
    sha256 = "1e3138fdd811015a66a22c4cafdc6ac4a117c5c70822008dc798f715d1239544",
    strip_prefix = "grpc-1.22.1",
    urls = [
        # When updating this dependency please ensure you also update the C# NuGet dependency's version in apis/apis.csproj.
        "https://github.com/grpc/grpc/archive/v1.22.1.zip",
    ],
)

load("@com_github_grpc_grpc//bazel:grpc_deps.bzl", "grpc_deps")

grpc_deps()

################################################################################
# GAPIC dependencies
################################################################################

http_archive(
    name = "com_google_googleapis",
    sha256 = "25ca6032d83e5f72c863c7f307f11134210ccc514de40115b3b3d0ea7eaf2472",
    strip_prefix = "googleapis-3352100a15ede383f5ab3c34599f7a10a3d066fe",
    urls = [
        # Corresponds to `master` on December 17th, 2019.
        "https://github.com/googleapis/googleapis/archive/3352100a15ede383f5ab3c34599f7a10a3d066fe.tar.gz",
    ],
)

load("@com_google_googleapis//:repository_rules.bzl", "switched_rules_by_language")

switched_rules_by_language(
    name = "com_google_googleapis_imports",
    csharp = True,
    gapic = True,
    grpc = True,
)

http_archive(
    name = "com_google_api_codegen",
    patches = ["//third_party/gapic-generator:grpc-1.22.1.patch"],
    sha256 = "171be68cab2cda6ee292571e82e9882ebf24ae232457b390718ac63a5ab20ce1",
    strip_prefix = "gapic-generator-cd919793e439d2d21505900aa08ef9f99519d8fa",
    urls = [
        # Corresponds to `master` on January 3rd, 2020.
        "https://github.com/googleapis/gapic-generator/archive/cd919793e439d2d21505900aa08ef9f99519d8fa.zip",
    ],
)

load("@com_google_api_codegen//:repository_rules.bzl", "com_google_api_codegen_properties")

com_google_api_codegen_properties(
    name = "com_google_api_codegen_properties",
    file = "@com_google_api_codegen//:dependencies.properties",
)

load("@com_google_api_codegen//:repositories.bzl", "com_google_api_codegen_repositories")

com_google_api_codegen_repositories()

################################################################################
# Dummy dependencies - These are used to satisify some unused dependencies.
################################################################################

local_repository(
    name = "build_bazel_rules_nodejs",
    path = "./third_party/rules_nodejs",
)
