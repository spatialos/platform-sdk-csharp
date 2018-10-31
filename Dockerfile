FROM microsoft/dotnet:2.0-sdk

ENV MONO_VERSION 5.16.0.179
RUN apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
RUN echo "deb http://download.mono-project.com/repo/debian stretch/snapshots/$MONO_VERSION main" > /etc/apt/sources.list.d/mono-official.list \
    && apt-get update \
    && apt-get install -y mono-runtime \
    && rm -rf /var/lib/apt/lists/* /tmp/*
RUN apt-get update \
    && apt-get install -y binutils curl mono-devel ca-certificates-mono fsharp mono-vbnc nuget referenceassemblies-pcl \
    && rm -rf /var/lib/apt/lists/* /tmp/*

# Install OpenJDK-8
RUN apt-get update && \
    apt-get install -y openjdk-8-jdk && \
    apt-get clean;

ENV JAVA_HOME /usr/lib/jvm/java-8-openjdk-amd64/
RUN export JAVA_HOME

RUN curl -L https://console.improbable.io/toolbelt/download/latest/linux -o /usr/bin/spatial
RUN chmod +x /usr/bin/spatial
RUN spatial update

WORKDIR /workspace
COPY apis apis
COPY examples examples
COPY scripts scripts

RUN nuget restore examples/examples.sln

ARG SDK_VERSION
RUN msbuild examples/examples.sln /p:Configuration=Release /p:Version=$SDK_VERSION /t:Clean,Build -verbosity:minimal

ARG IMPROBABLE_REFRESH_TOKEN
ENV IMPROBABLE_REFRESH_TOKEN=$IMPROBABLE_REFRESH_TOKEN
RUN mkdir -p $HOME/.improbable/oauth2 && echo $IMPROBABLE_REFRESH_TOKEN >> $HOME/.improbable/oauth2/oauth2_refresh_token
