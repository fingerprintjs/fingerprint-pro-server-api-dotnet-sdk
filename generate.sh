#!/bin/bash

# Cleanup
rm -Rf ./docs
rm -Rf ./src/Fingerprint.ServerSdk

# Prepare OpenAPI Generator CLI
OPENAPI_GENERATOR_FILE="./bin/openapi-generator-cli.jar"
OPENAPI_GENERATOR_URL="https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/7.19.0/openapi-generator-cli-7.19.0.jar"

if [[ ! -e "$OPENAPI_GENERATOR_FILE" ]]; then
  echo "Downloading $OPENAPI_GENERATOR_URL..."
  mkdir -p "$(dirname "$OPENAPI_GENERATOR_FILE")"
  curl -fSL -o "$OPENAPI_GENERATOR_FILE" "$OPENAPI_GENERATOR_URL"
fi

# Generate
export LANG=en_US.UTF-8
export LC_ALL=en_US.UTF-8
java -Duser.language=en -Duser.country=US -Duser.variant="" \
  -jar "$OPENAPI_GENERATOR_FILE" generate \
  -t ./template -g csharp \
  -i ./res/fingerprint-server-api.yaml -o ./ -c config.json

# Fix api doc
mv ./docs/apis/FingerprintApi.md ./docs/FingerprintApi.md
rmdir ./docs/apis
