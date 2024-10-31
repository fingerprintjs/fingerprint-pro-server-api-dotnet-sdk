#!/bin/bash

# clean models and docs before generating
find ./src/FingerprintPro.ServerSdk/Model -type f ! -name "DictionaryModel.cs" -exec rm {} +
find ./docs -type f ! -name "DecryptionKey.md" ! -name "Sealed.md" ! -name -name "Webhook.md" -exec rm {} +

# jar was downloaded from here https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.34/

java -jar ./bin/swagger-codegen-cli.jar generate -t ./template -l csharp -i ./res/fingerprint-server-api.yaml -o ./ -c config.json
dotnet format

platform=$(uname)

# Fix for codegen generating override in ToJson for models that extend Dictionary
declare -a files=("./src/FingerprintPro.ServerSdk/Model/RawDeviceAttributes.cs" "./src/FingerprintPro.ServerSdk/Model/WebhookRawDeviceAttributes.cs" "./src/FingerprintPro.ServerSdk/Model/Tag.cs")

for i in "${files[@]}"
do
  (
    # Model file fix
    if [ "$platform" = "Darwin" ]; then
      sed -i '' 's/public override string ToJson()/public string ToJson()/' "$i"
      sed -i '' 's/: Dictionary/: DictionaryModel/' "$i"
    else
      sed -i 's/: Dictionary/: DictionaryModel/' "$i"
    fi
  )
done


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
