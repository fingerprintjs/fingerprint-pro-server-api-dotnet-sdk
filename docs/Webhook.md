# FingerprintPro.ServerSdk.Webhook

## **IsValidWebhookSignature**

> bool IsValidWebhookSignature(string header, byte[] data, string secret)

Verifies the HMAC signature extracted from the "fpjs-event-signature" header of the incoming request. This is a part of
the webhook signing process, which is available only for enterprise customers.
If you wish to enable it, please contact our support: https://fingerprint.com/support

### Required Parameters

| Name       | Type         | Description                                     | Notes |
|------------|--------------|-------------------------------------------------|-------|
| **header** | **string**   | The value of the "fpjs-event-signature" header. |       |
| **data**   | **byte[]**   | The raw data of the incoming request.           |       | 
| **secret** | **string[]** | The secret key used to sign the request         |       | 
