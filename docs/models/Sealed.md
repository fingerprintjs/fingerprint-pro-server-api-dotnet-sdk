# Fingerprint.ServerSdk.Sealed

## **UnsealEventsResponse**

> EventResponse unsealEventResponse(sealed []byte, keys DecryptionKey[])

Decrypts the sealed response with provided keys.

### Required Parameters

| Name       | Type                | Description                                                                              | Notes |
|------------|---------------------|------------------------------------------------------------------------------------------|-------|
| **sealed** | **byte[]**          | Base64 encoded sealed data                                                               |       |
| **keys**   | **DecryptionKey[]** | Decryption keys. The SDK will try to decrypt the result with each key until it succeeds. |       | 
