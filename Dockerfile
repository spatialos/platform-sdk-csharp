# Adapted from: https://github.com/dotnet/dotnet-docker/blob/master/2.2/sdk/bionic/amd64/Dockerfile
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-bionic

## Improbable specific section
# Fetch and set up the 'spatial' CLI.
RUN curl -L https://console.improbable.io/toolbelt/download/latest/linux -o /usr/bin/spatial
RUN chmod +x /usr/bin/spatial
RUN spatial update

# Make the sources available in the container.
WORKDIR /workspace
COPY apis apis
COPY examples examples
COPY scripts scripts

# Build the examples for use by scripts.
ARG SDK_VERSION
RUN dotnet build examples/examples.sln --configuration Release -p:Version=$SDK_VERSION

# Ensure authentication is available for the 'spatial' CLI and the Platform SDK.
ARG IMPROBABLE_REFRESH_TOKEN
ENV IMPROBABLE_REFRESH_TOKEN=$IMPROBABLE_REFRESH_TOKEN
RUN mkdir -p $HOME/.improbable/oauth2 && echo $IMPROBABLE_REFRESH_TOKEN >>$HOME/.improbable/oauth2/oauth2_refresh_token_cn-production
