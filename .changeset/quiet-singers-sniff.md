---
"fingerprint-server-dotnet-sdk": major
---

Migrate to `generichost` and Server API v4.

**BREAKING CHANGE:** This release contains multiple breaking changes:

- SDK version bumped to `8.0.0`.
- Server API version upgraded from v3 to v4.
- Base URL changed from `https://api.fpjs.io` to `https://api.fpjs.io/v4`.
- Parameter `request_id` renamed to `event_id` for all endpoints.
- Removed `GetVisits` and `GetRelatedVisitors` operations and endpoints.
- All API methods are async.
- New dependency injection pattern for API client configuration.

**Migration notes:**
- Replace `Configuration` class usage with generichost
  (`IHostBuilder.ConfigureApi()`).
- Update all API method calls to use async variants.
- Replace `request_id` parameters with `event_id`
- Update any code using removed endpoints/operations (`GetVisits`,
  `GetRelatedVisitors`). You can use search operation.
