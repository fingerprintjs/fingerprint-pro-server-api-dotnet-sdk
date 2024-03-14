# FingerprintPro.ServerSdk.Model.WebhookVisit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VisitorId** | **string** |  | 
**ClientReferrer** | **string** |  | [optional] 
**UserAgent** | **string** |  | [optional] 
**Bot** | [**BotdDetectionResult**](BotdDetectionResult.md) |  | [optional] 
**IpInfo** | [**IpInfoResult**](IpInfoResult.md) |  | [optional] 
**Incognito** | **bool?** | Flag if user used incognito session. | 
**RootApps** | [**RootAppsResult**](RootAppsResult.md) |  | [optional] 
**Emulator** | [**EmulatorResult**](EmulatorResult.md) |  | [optional] 
**ClonedApp** | [**ClonedAppResult**](ClonedAppResult.md) |  | [optional] 
**FactoryReset** | [**FactoryResetResult**](FactoryResetResult.md) |  | [optional] 
**Jailbroken** | [**JailbrokenResult**](JailbrokenResult.md) |  | [optional] 
**Frida** | [**FridaResult**](FridaResult.md) |  | [optional] 
**IpBlocklist** | [**IpBlockListResult**](IpBlockListResult.md) |  | [optional] 
**Tor** | [**TorResult**](TorResult.md) |  | [optional] 
**PrivacySettings** | [**PrivacySettingsResult**](PrivacySettingsResult.md) |  | [optional] 
**VirtualMachine** | [**VirtualMachineResult**](VirtualMachineResult.md) |  | [optional] 
**Vpn** | [**VpnResult**](VpnResult.md) |  | [optional] 
**Proxy** | [**ProxyResult**](ProxyResult.md) |  | [optional] 
**Tampering** | [**TamperingResult**](TamperingResult.md) |  | [optional] 
**RawDeviceAttributes** | [**RawDeviceAttributesResult**](RawDeviceAttributesResult.md) |  | [optional] 
**HighActivity** | [**HighActivityResult**](HighActivityResult.md) |  | [optional] 
**LocationSpoofing** | [**LocationSpoofingResult**](LocationSpoofingResult.md) |  | [optional] 
**SuspectScore** | [**SuspectScoreResult**](SuspectScoreResult.md) |  | [optional] 
**RequestId** | **string** | Unique identifier of the user's identification request. | 
**BrowserDetails** | [**BrowserDetails**](BrowserDetails.md) |  | 
**Ip** | **string** |  | 
**IpLocation** | [**IPLocation**](IPLocation.md) |  | [optional] 
**Timestamp** | **long?** | Timestamp of the event with millisecond precision in Unix time. | 
**Time** | **DateTime?** | Time expressed according to ISO 8601 in UTC format. | 
**Url** | **string** | Page URL from which identification request was sent. | 
**Tag** | **Dictionary&lt;string, Object&gt;** | A customer-provided value or an object that was sent with identification request. | [optional] 
**LinkedId** | **string** | A customer-provided id that was sent with identification request. | [optional] 
**Confidence** | [**Confidence**](Confidence.md) |  | 
**VisitorFound** | **bool?** | Attribute represents if a visitor had been identified before. | 
**FirstSeenAt** | [**SeenAt**](SeenAt.md) |  | 
**LastSeenAt** | [**SeenAt**](SeenAt.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

