FROM microsoft/dotnet:runtime

RUN apt-get update && apt-get install -y --no-install-recommends \
 ca-certificates \
 curl \
 && rm -rf /var/lib/apt/lists/

# Install Factorio
ENV FACTORIO_VERSION 0.14.21
RUN cd /opt/ && \
curl -sL "http://www.factorio.com/get-download/${FACTORIO_VERSION}/headless/linux64" | tar xzv && \
chmod +x /opt/factorio/bin/x64/factorio
