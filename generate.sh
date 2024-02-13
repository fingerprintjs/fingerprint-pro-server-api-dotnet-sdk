#!/bin/bash

# clean models and docs before generating
rm -f ./src/FingerprintPro.ServerSdk/Model/*
find ./docs -type f ! -name "DecryptionKey.md" ! -name "Sealed.md" -exec rm {} +

# jar was downloaded from here https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.34/

java -jar ./bin/swagger-codegen-cli.jar generate -t ./template -l csharp -i ./res/fingerprint-server-api.yaml -o ./ -c config.json
dotnet format

# Ugly fix for codegen problem that I couldn't fix editing template.
# Platform check
platform=$(uname)
(
  # Model file fix
  if [ "$platform" = "Darwin" ]; then
    sed -i '' 's/public override string ToJson()/public string ToJson()/' ./src/FingerprintPro.ServerSdk/Model/RawDeviceAttributesResult.cs
  else
    sed -i 's/public override string ToJson()/public string ToJson()/' ./src/FingerprintPro.ServerSdk/Model/RawDeviceAttributesResult.cs
  fi
)

(
  # Readme file fix
  replacement=$(printf 'The rawAttributes object follows this general shape: `{ value: any } | { error: { name: string; message: string; } }`\n')
  readme_filename="./docs/RawDeviceAttributesResult.md"
  if [ "$platform" = "Darwin" ]; then
    sed -i '' "s/^Name |.*/${replacement}/" "$readme_filename"
    sed -i '' "/^------------ |/c\\" "$readme_filename"
  else
    sed -i "s/^Name |.*/${replacement}/" "$readme_filename"
    sed -i "/^------------ |/c\\" "$readme_filename"
  fi
)
