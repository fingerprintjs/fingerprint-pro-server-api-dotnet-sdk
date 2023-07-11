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
