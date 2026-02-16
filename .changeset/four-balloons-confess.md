---
"fingerprint-server-dotnet-sdk": major
---

Rename .NET SDK project and namespaces from `FingerprintPro.ServerSdk.*` to `Fingerprint.ServerSdk.*`.

**Breaking changes**

- Update all `using` directives and fully-qualified type names:
    - `FingerprintPro.ServerSdk.*` → `Fingerprint.ServerSdk.*`
- If you reference solution/project file names or CI paths, update them to the new `Fingerprint.ServerSdk.*` locations.