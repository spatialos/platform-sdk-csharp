#!/usr/bin/env bash

set -e -u -x -o pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
cd "${REPO_ROOT}"

# shellcheck source=includes/bazel.sh
source scripts/includes/bazel.sh

function generate_common() {
  rm -rf apis/platform/generated
  mkdir --mode=0755 apis/platform/generated

  runBazel build //apis/platform/...

  local generated_zips
  generated_zips="$(jq --raw-output 'select(.id.targetCompleted != null).completed.importantOutput[0].uri' <bazel_build_events.json)"

  for generated_zip in ${generated_zips}; do
    # The previous 'jq' search in the build events log only turns up the '.srcjar'
    # files. These are all accompanied by an identically named ZIP archive.
    unzip -j -d apis/platform/generated "${generated_zip#file://}.zip"
  done
}

function sanitise_headers() {
  local package="$1"
  local file line
  for file in "${package}"/*Client.cs; do
    # Determine the line that ends the header.
    line="$(grep --line-number --color=no 'Generated code. DO NOT EDIT!' "${file}")"
    line="${line%%:*}"

    printf "// Copyright (c) Improbable Worlds Ltd, All Rights Reserved\n\n" >"${file}.tmp"
    tail --lines="+$((line))" "${file}" >>"${file}.tmp"
    mv "${file}.tmp" "${file}"
  done
}

function generate_api() {
  local name="$1"
  local version="$2"
  local name_lower version_lower
  name_lower="$(tr '[:upper:]' '[:lower:]' <<<"${name}")"
  version_lower="$(tr '[:upper:]' '[:lower:]' <<<"${version}")"

  local package="apis/${name_lower}/${version_lower}"
  local build_file="${package}/BUILD"
  local csproj_file="${package}/${name_lower}_${version_lower}.csproj"

  # We need to create each level individually as the '--mode' flag
  # only applies to the deepest level if more than one is created.
  # shellcheck disable=SC2174
  mkdir --parents --mode=0755 "apis/${name_lower}"
  # shellcheck disable=SC2174
  mkdir --parents --mode=0755 "apis/${name_lower}/${version_lower}"
  cat >"${build_file}" <<EOF
load("//apis:rules.bzl", "platform_sdk_package")

platform_sdk_package(name = "spatialos-${name_lower}-${version_lower}")

EOF
  chmod 644 "${build_file}"

  cat >"${csproj_file}" <<EOF
<!-- GENERATED FILE - DO NOT MODIFY -->
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <AssemblyName>Improbable.SpatialOS.Platform.${name}.${version}</AssemblyName>
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    <Deterministic>true</Deterministic>
    <DocumentationFile>../../../docs/${name_lower}/${version_lower}</DocumentationFile>
    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
    <TargetFrameworks>netstandard1.6</TargetFrameworks>
    <VsxmdAutoDeleteXml>true</VsxmdAutoDeleteXml>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="../../platform/platform.csproj" />
    <PackageReference Include="Google.Api.CommonProtos" Version="1.6.0" />
    <PackageReference Include="Google.Api.Gax.Grpc" Version="2.7.0" />
    <PackageReference Include="Google.Protobuf" Version="3.11.2" />
    <PackageReference Include="Grpc.Core" Version="1.22.1" />
    <PackageReference Include="Microsoft.NETFramework.ReferenceAssemblies" PrivateAssets="All" Version="1.0.0-preview.2" />
    <PackageReference Include="Vsxmd" Version="1.4.4">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
  </ItemGroup>

</Project>
EOF

  runBazel build "//${package}:spatialos-${name_lower}-${version_lower}"

  local assembly_pkg
  assembly_pkg="$(jq --raw-output 'select(.id.targetCompleted != null).completed.importantOutput[0].uri' <bazel_build_events.json | grep '.tar.gz$')"

  tar --extract --wildcards --directory="${package}" --strip=3 --file "${assembly_pkg#file://}" '*.cs' --exclude '*.g.cs' --exclude 'ResourceNames.cs'

  sanitise_headers "${package}"

  # Ensure we only have the files that we meant to be part of the SDK packages.
  find "${package}" -type f -not \( -name "BUILD" -or -iname "${name}*" \) -exec rm -f {} \+

  pushd "${package}"
  dotnet build
  popd
}

function generate_pkg() {
  local pkg_csproj="pkg/apis.csproj"

  rm --recursive --force "pkg"
  mkdir --parent "pkg/lib"

  cat >"${pkg_csproj}" <<EOF
<!-- GENERATED FILE - DO NOT MODIFY -->
<Project Sdk="Microsoft.NET.Sdk" ToolsVersion="15.0">

  <PropertyGroup>
    <Authors>Improbable</Authors>
    <Copyright>Copyright (c) Improbable Worlds Ltd, All Rights Reserved</Copyright>
    <Description>Platform C# SDK that allows interacting with the SpatialOS Platform.</Description>
    <PackageTags>Platform SDK;Improbable;SpatialOS Platform</PackageTags>
    <PackageProjectUrl>https://github.com/spatialos/platform-sdk-csharp</PackageProjectUrl>
    <RepositoryUrl>\$(PackageProjectUrl)</RepositoryUrl>
    <RepositoryType>git</RepositoryType>
    <AssemblyName>Improbable.SpatialOS.Platform</AssemblyName>
    <RootNamespace>Improbable.SpatialOS</RootNamespace>
  </PropertyGroup>

  <PropertyGroup>
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    <Deterministic>true</Deterministic>
    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
    <TargetFrameworks>netstandard1.6</TargetFrameworks>
  </PropertyGroup>

  <ItemGroup Condition="\$(Configuration) == Debug">
EOF

  local api_csproj
  while read -r api_csproj; do
    cat >>"${pkg_csproj}" <<EOF
    <ProjectReference Include="../${api_csproj}" />
EOF
  done <<<"$(find apis -type f -name '*.csproj')"

  cat >>"${pkg_csproj}" <<EOF
  </ItemGroup>

  <ItemGroup Condition="\$(Configuration) == Release">
EOF

  local api_csproj
  while read -r api_csproj; do
    cat >>"${pkg_csproj}" <<EOF
    <Compile Include="../$(dirname "${api_csproj}")/*.cs" />
EOF
  done <<<"$(find apis -type f -name '*.csproj')"

  cat >>"${pkg_csproj}" <<EOF
    <Compile Include="../apis/platform/generated/*.cs" />
    <PackageReference Include="Google.Api.CommonProtos" Version="1.6.0" />
    <PackageReference Include="Google.Api.Gax.Grpc" Version="2.7.0" />
    <PackageReference Include="Google.Protobuf" Version="3.11.2" />
    <PackageReference Include="Google.LongRunning" Version="1.1.0" />
    <PackageReference Include="Grpc.Core" Version="1.22.1" />
    <PackageReference Include="Microsoft.NETFramework.ReferenceAssemblies" PrivateAssets="All" Version="1.0.0-preview.2" />
  </ItemGroup>

</Project>
EOF
}

# Generate common files.
generate_common

# Remove all existing generated documentation and SDK packages to ensure regeneration from scratch.
find "docs" -mindepth 1 -maxdepth 1 -type d -exec rm -rf {} \;
find "apis" -mindepth 1 -maxdepth 1 -type d -not -name "platform" -exec rm -rf {} \;

# Explicitely declare all SDK packages to generate.
generate_api "Deployment" "V1Alpha1"
generate_api "Deployment" "V1Beta1"
generate_api "PlayerAuth" "V2Alpha1"
generate_api "RemoteInteraction" "V1Alpha1"
generate_api "ServiceAccount" "V1Alpha1"
generate_api "Snapshot" "V1Alpha1"

# Generate the package project.
generate_pkg
