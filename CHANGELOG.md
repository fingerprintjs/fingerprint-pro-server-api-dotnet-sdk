## [6.0.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v5.0.0...v6.0.0) (2024-06-28)


### ⚠ BREAKING CHANGES

* rename `ManyRequestsResponse` to `TooManyRequestsResponse`
* drop support for netcoreapp3.1 and older,

### Features

* add `Webhook.IsValidWebhookSignature` function for validating webhook signature ([7b4a7fb](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/7b4a7fb952af3837ed82fc4adf675dc9a20a7e29))
* add DELETE API ([6a457b7](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/6a457b7ccfe7a888a9ca4fa6933c6f0366ba20ae))
* add os Mismatch ([85ec77b](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/85ec77b49069ba7419e706f2a801f441ae9b78cf))
* add revision string field to confidence object ([d2af0ac](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/d2af0ac90467b24061ecf85c9470d08ecc02463a))
* drop support for frameworks that reached EOL ([a39d863](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a39d8639ead451792361ba235dc361ae255ada56))
* migrate swagger generated code in request logic to manual implementation ([b7e60c0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/b7e60c0e6928a7da200e7ed2a028b17fbe1ad92c))
* remove usage of Newtonsoft.Json and RestSharp ([77eed3d](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/77eed3dc79fb9e8ed73095f83023e94180b67eab))
* rename `ManyRequestsResponse` to `TooManyRequestsResponse` ([8eae642](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/8eae642de09e55383794162ecbc91ff80b5bd263))


### Bug Fixes

* add `JsonDeserializeException` when json deserialization fails ([7aab037](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/7aab037d6c0aae76bf546a223b682bb74d9ff1b5))
* use correct error type for `incognito`, `rawDeviceAttributes` and `tampering` in the `GetEvent` method ([4b4120e](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/4b4120e812e9c4aa9a948e40ce5c25a626156c73))


### Documentation

* **README:** mention how to access raw HTTP response ([fd324e1](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/fd324e1d82ba700f26672dd09694698c5bf63db0))
* **README:** remove dependencies section ([9d7ae2a](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/9d7ae2af56f13bec54d4f952345b2eb7fdec7209))

## [5.0.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v4.0.0...v5.0.0) (2024-03-28)


### ⚠ BREAKING CHANGES

* now only .NET >= 6 is supported

### Features

* add .net v8 ([56959dc](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/56959dc3e320007d79a831c8b798a188806ba226))
* drop support for .NET 5 ([866042e](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/866042e303accc528452bb81bdb0e49d7035c2b6))
* drop support for .NET 5 ([a402975](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a402975e576e4f531238fc846e78a313d95be520))

## [4.0.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v3.1.0...v4.0.0) (2024-03-18)


### ⚠ BREAKING CHANGES

* make identification field `confidence` optional
* deprecated `ipLocation` field uses `DeprecatedIpLocation` model
* change models for the most smart signals

### Features

* add `linkedId` field to the `BotdResult` type ([cddcd3c](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/cddcd3c97c15b4699bf3fe10bff5a5b42194d32b))
* add `originCountry` field to the `vpn` signal ([a8d9c42](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a8d9c426bbdd6cf901f458815a43d1fdf8f68cf8))
* add `SuspectScore` smart signal support ([36bcf07](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/36bcf0748fc1ee7a9b54453afd60b225e3d3a8df))
* fix `ipLocation` deprecation ([ca56d40](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/ca56d40d0c9a45c9c2a9e90a9dd92a2eb198a02b))
* make identification field `tag` required ([a2ba563](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a2ba563a9e5a04f2251860a964ec7b0a5a36fb49))
* use shared structures for webhooks and event ([a0adeff](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a0adeff17f903731be6460a4f3f5c9c0755ff31a))


### Bug Fixes

* make fields required according to real API response ([461797e](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/461797e4a9fa01ae13d68f444acfe4b82d90de7c))

## [3.1.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v3.0.0...v3.1.0) (2024-02-13)


### Features

* add method for decoding sealed results ([763b940](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/763b940c1ee6bc35ac45b1a9384736d8d6312431))

## [3.0.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.4.0...v3.0.0) (2024-01-12)


### ⚠ BREAKING CHANGES

* `IpInfo` field `DataCenter` renamed to `Datacenter`

### Features

* deprecate `IPLocation` ([0ffeeb9](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/0ffeeb9b6f35dd43ca88e8580b40cc6e795a06f9))
* use datacenter instead of the wrong dataCenter ([308b5e2](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/308b5e263028c0e366e0f616d83a2e9e0e1f953a))

## [2.4.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.3.2...v2.4.0) (2023-11-23)


### Features

* add `highActivity` and `locationSpoofing` signals, support `originTimezone` for `vpn` signal ([8f80f28](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/8f80f2807337dc961982da5a26009bd6b772ca10))

## [2.3.2](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.3.1...v2.3.2) (2023-10-20)


### Bug Fixes

* change package author to Fingerprint ([721e91c](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/721e91ccf3494aa146bfc4aeabe870a86c7df0bc))


### Documentation

* **README:** add requirements and license mention INTER-283 ([0caaccc](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/0caaccc7e7d588bd11ececd52b9cf79cd85c63ce))

## [2.3.1](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.3.0...v2.3.1) (2023-09-25)


### Bug Fixes

* update OpenAPI Schema with `asn` and `dataCenter` signals ([210b79a](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/210b79a86cd558c209342e10c24d17d4652a0bf9))
* update OpenAPI Schema with `auxiliaryMobile` method for VPN signal ([fcf0cf5](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/fcf0cf58eebbf17a99f1f601d00a323a379c4ab0))

## [2.3.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.2.1...v2.3.0) (2023-07-31)


### Features

* add `rawDeviceAttributes` signal as generic JObject ([40f5022](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/40f5022e2e960f2b99e98789275ddc0e8d80ff12))
* add smart signals support ([053779d](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/053779d0d26544482c0461b00ecb7b4b5003c5cf))

## [2.2.1](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.2.0...v2.2.1) (2023-07-11)


### Bug Fixes

* ensure that SeenAt properties are correctly set in constructor ([9bd9e14](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/9bd9e14764dad8a8472f54619972867d871f5661))

## [2.2.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.1.0...v2.2.0) (2023-06-01)


### Features

* update schema with correct `IpLocation` format and doc updates ([4ddae4d](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/4ddae4dc2b279b8f15d1f5829b152b095bba31d3))


### Bug Fixes

* fix backtick problem in comments and documentation ([a12e9a3](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a12e9a3e2e14f357ca0ecdd96b53eae0d5cb3c3a))

## [2.1.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v2.0.0...v2.1.0) (2023-05-16)


### Features

* introduce new signals ([c38a0da](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/c38a0dacdebae155f97a942e6f16184f925f5413))

## [2.0.0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/compare/v1.0.0...v2.0.0) (2023-01-30)


### ⚠ BREAKING CHANGES

* changed `before` parameter type from `int` to `long`

### Features

* change `before` parameter type in /visits endpoint ([c9234aa](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/c9234aa30971f69d0965da66b70de211b6602d0d))

## 1.0.0 (2023-01-23)


### Features

* add identification error to events response ([a0afe34](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a0afe34a3e4d2dea7d3e56573d71ba72748cae8b))
* bump RestSharp to 108.0.3 ([a36615f](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/a36615f17a6fdefde279aef93e8e1d89b27cad75))
* change namespace from Fingerprint.Sdk to Fingerprint.ServerSdk ([250b756](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/250b756ec21162bf90dc2f5ca010f012804544e8))
* introduce TooManyRequestsException ([bd94cf8](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/bd94cf8f31c50019b5dcba68b4b3a1c9d1389aeb))
* rename package to match new root namespace ([e457a69](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/e457a6932d871e9371ea72c9faa2e411604e3439))
* require passing api key in Configuration constructor, remove default configuration ([b7b6e0f](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/b7b6e0fbbc39c88ec3740a2a05f94339385988e3))
* send "ii" parameter ([c09dab0](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/c09dab0bfd30eb94fa5d206b7236e24b55a2ea28))
* support other API regions ([ccc9250](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/ccc9250d901dd24e58a81873afaa0000eea6b858))
* support other dotenv frameworks as well ([692f1bc](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/692f1bc7c4be0e164a39b53777f164cf3b0ff45a))
* update client to latest schema version ([29e1d24](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/29e1d242332032fd34ef34901287388c85c815c0))


### Documentation

* **README:** add badges ([c3a7f87](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/c3a7f87ea6d390d8fb18dc09a77b0c94556e805d))
* **README:** add install command and fix style problems ([4798730](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/47987309a0dcb8d63a42bb6863fb0328e7f3b705))
* **README:** add logo ([55f72fb](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/55f72fbfee8e4e206a93f1419c370c0fdaefbb03))
* **README:** add separate readme to package ([6572a05](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/6572a05a311954342a7e46cc30fc4d2442c5d252))
* **README:** include readme and license ([6102d58](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/6102d589823e0bcefd25e08a6cd0d16304e6321a))
* **README:** update readme and license ([074fa61](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/commit/074fa61464b423fd52e2503e977dca3e21122670))
