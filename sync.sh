#!/bin/bash
set -euo pipefail

defaultBaseUrl="https://fingerprintjs.github.io/fingerprint-pro-server-api-openapi"
schemaUrl="${1:-$defaultBaseUrl/schemas/fingerprint-server-api-compact.yaml}"
examplesBaseUrl="${2:-$defaultBaseUrl/examples}"

mkdir -p ./res

curl -fSL -o ./res/fingerprint-server-api.yaml "$schemaUrl"

examplesList=(
  'get_visits_200_limit_1.json'
  'get_visits_200_limit_500.json'
  'get_visits_403_error.json'
  'get_visits_429_too_many_requests_error.json'
  'webhook.json'
  'get_event_200.json'
  'get_event_200_all_errors.json'
  'get_event_200_extra_fields.json'
  'get_event_403_error.json'
  'get_event_404_error.json'
  'get_event_200_botd_failed_error.json'
  'get_event_200_botd_too_many_requests_error.json'
  'get_event_200_identification_failed_error.json'
  'get_event_200_identification_too_many_requests_error.json'
  'get_event_200_identification_too_many_requests_error_all_fields.json'
  'delete_visits_400_error.json'
  'delete_visits_404_error.json'
  'delete_visits_403_error.json'
  'delete_visits_429_error.json'
)

baseDestination="./src/Fingerprint.ServerSdk.Test/mocks"

for example in "${examplesList[@]}"; do
  destinationPath="$baseDestination/$example"
  destinationDir="$(dirname "$destinationPath")"

  mkdir -p "$destinationDir"

  echo "Downloading $example to $destinationPath"
  curl -fSL -o "$destinationPath" "$examplesBaseUrl/$example"
done

echo "All OpenAPI documentation downloads complete."