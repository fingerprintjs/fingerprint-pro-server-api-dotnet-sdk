#!/bin/bash

# jar was downloaded from here https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.34/

java -jar ./bin/swagger-codegen-cli.jar generate -t ./template -l csharp -i ./res/fingerprint-server-api.yaml -o ./ -c config.json -DpackageVersion=$VERSION
