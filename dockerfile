FROM ubuntu:xenial

RUN apt-get update && apt-get install -y --no-install-recommends \
 ca-certificates \
 curl \
 libunwind8 \
 libkrb5-3 \
 libicu55 \
 liblttng-ust0 \
 libssl1.0.0 \
 zlib1g \
 libuuid1 \
 liblldb-3.6 \
 && rm -rf /var/lib/apt/lists/

# Install Factorio
ENV FACTORIO_VERSION 0.14.21
RUN cd /opt/ && \
curl -sL "http://www.factorio.com/get-download/${FACTORIO_VERSION}/headless/linux64" | tar xzv && \
chmod +x /opt/factorio/bin/x64/factorio

# Install the App
WORKDIR /dotnetapp
COPY out .

# Set Environment
ENV PORT 5000
EXPOSE 5000

ENV FACTORIO_PORT 34197
EXPOSE 34197/udp

#VOLUME /opt/factorio/saves
#VOLUME /opt/factorio/mods

CMD [ "./FactorioMultiplayerAdmin" ]
