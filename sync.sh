#!/bin/bash

curl -o ./res/fingerprint-server-api.yaml https://fingerprintjs.github.io/fingerprint-pro-server-api-openapi/schemas/fingerprint-server-api-compact.yaml

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

for example in ${examplesList[*]}; do
  curl -o ./src/FingerprintPro.ServerSdk.Test/mocks/"$example" https://fingerprintjs.github.io/fingerprint-pro-server-api-openapi/examples/"$example"
done
