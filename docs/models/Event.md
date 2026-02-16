# Fingerprint.ServerSdk.Model.Event
Contains results from Fingerprint Identification and all active Smart Signals.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **string** | Unique identifier of the user&#39;s request. The first portion of the event_id is a unix epoch milliseconds timestamp For example: &#x60;1758130560902.8tRtrH&#x60;  | 
**Timestamp** | **long** | Timestamp of the event with millisecond precision in Unix time. | 
**LinkedId** | **string** | A customer-provided id that was sent with the request. | [optional] 
**EnvironmentId** | **string** | Environment Id of the event. For example: &#x60;ae_47abaca3db2c7c43&#x60;  | [optional] 
**Suspect** | **bool** | Field is &#x60;true&#x60; if you have previously set the &#x60;suspect&#x60; flag for this event using the [Server API Update event endpoint](https://dev.fingerprint.com/reference/updateevent). | [optional] 
**Sdk** | [**SDK**](SDK.md) |  | [optional] 
**Replayed** | **bool** | &#x60;true&#x60; if we determined that this payload was replayed, &#x60;false&#x60; otherwise.  | [optional] 
**Identification** | [**Identification**](Identification.md) |  | [optional] 
**SupplementaryIdHighRecall** | [**SupplementaryIDHighRecall**](SupplementaryIDHighRecall.md) |  | [optional] 
**Tags** | **Dictionary&lt;string, Object&gt;** | A customer-provided value or an object that was sent with the identification request or updated later. | [optional] 
**Url** | **string** | Page URL from which the request was sent. For example &#x60;https://example.com/&#x60;  | [optional] 
**BundleId** | **string** | Bundle Id of the iOS application integrated with the Fingerprint SDK for the event. For example: &#x60;com.foo.app&#x60;  | [optional] 
**PackageName** | **string** | Package name of the Android application integrated with the Fingerprint SDK for the event. For example: &#x60;com.foo.app&#x60;  | [optional] 
**IpAddress** | **string** | IP address of the requesting browser or bot. | [optional] 
**UserAgent** | **string** | User Agent of the client, for example: &#x60;Mozilla/5.0 (Windows NT 6.1; Win64; x64) ....&#x60;  | [optional] 
**ClientReferrer** | **string** | Client Referrer field corresponds to the &#x60;document.referrer&#x60; field gathered during an identification request. The value is an empty string if the user navigated to the page directly (not through a link, but, for example, by using a bookmark) For example: &#x60;https://example.com/blog/my-article&#x60;  | [optional] 
**BrowserDetails** | [**BrowserDetails**](BrowserDetails.md) |  | [optional] 
**Proximity** | [**Proximity**](Proximity.md) |  | [optional] 
**Bot** | **BotResult** |  | [optional] 
**BotType** | **string** | Additional classification of the bot type if detected.  | [optional] 
**ClonedApp** | **bool** | Android specific cloned application detection. There are 2 values:  * &#x60;true&#x60; - Presence of app cloners work detected (e.g. fully cloned application found or launch of it inside of a not main working profile detected). * &#x60;false&#x60; - No signs of cloned application detected or the client is not Android.  | [optional] 
**DeveloperTools** | **bool** | &#x60;true&#x60; if the browser is Chrome with DevTools open or Firefox with Developer Tools open, &#x60;false&#x60; otherwise.  | [optional] 
**Emulator** | **bool** | Android specific emulator detection. There are 2 values:  * &#x60;true&#x60; - Emulated environment detected (e.g. launch inside of AVD).  * &#x60;false&#x60; - No signs of emulated environment detected or the client is not Android.  | [optional] 
**FactoryResetTimestamp** | **long** | The time of the most recent factory reset that happened on the **mobile device** is expressed as Unix epoch time. When a factory reset cannot be detected on the mobile device or when the request is initiated from a browser,  this field will correspond to the *epoch* time (i.e 1 Jan 1970 UTC) as a value of 0. See [Factory Reset Detection](https://dev.fingerprint.com/docs/smart-signals-overview#factory-reset-detection) to learn more about this Smart Signal.  | [optional] 
**Frida** | **bool** | [Frida](https://frida.re/docs/) detection for Android and iOS devices. There are 2 values: * &#x60;true&#x60; - Frida detected * &#x60;false&#x60; - No signs of Frida or the client is not a mobile device.  | [optional] 
**IpBlocklist** | [**IPBlockList**](IPBlockList.md) |  | [optional] 
**IpInfo** | [**IPInfo**](IPInfo.md) |  | [optional] 
**Proxy** | **bool** | IP address was used by a public proxy provider or belonged to a known recent residential proxy  | [optional] 
**ProxyConfidence** | **ProxyConfidence** |  | [optional] 
**ProxyDetails** | [**ProxyDetails**](ProxyDetails.md) |  | [optional] 
**Incognito** | **bool** | &#x60;true&#x60; if we detected incognito mode used in the browser, &#x60;false&#x60; otherwise.  | [optional] 
**Jailbroken** | **bool** | iOS specific jailbreak detection. There are 2 values:  * &#x60;true&#x60; - Jailbreak detected. * &#x60;false&#x60; - No signs of jailbreak or the client is not iOS.  | [optional] 
**LocationSpoofing** | **bool** | Flag indicating whether the request came from a mobile device with location spoofing enabled. | [optional] 
**MitmAttack** | **bool** | * &#x60;true&#x60; - When requests made from your users&#39; mobile devices to Fingerprint servers have been intercepted and potentially modified.  * &#x60;false&#x60; - Otherwise or when the request originated from a browser. See [MitM Attack Detection](https://dev.fingerprint.com/docs/smart-signals-reference#mitm-attack-detection) to learn more about this Smart Signal.  | [optional] 
**PrivacySettings** | **bool** | &#x60;true&#x60; if the request is from a privacy aware browser (e.g. Tor) or from a browser in which fingerprinting is blocked. Otherwise &#x60;false&#x60;.  | [optional] 
**RootApps** | **bool** | Android specific root management apps detection. There are 2 values:  * &#x60;true&#x60; - Root Management Apps detected (e.g. Magisk). * &#x60;false&#x60; - No Root Management Apps detected or the client isn&#39;t Android.  | [optional] 
**RuleAction** | [**EventRuleAction**](EventRuleAction.md) |  | [optional] 
**SuspectScore** | **int** | Suspect Score is an easy way to integrate Smart Signals into your fraud protection work flow.  It is a weighted representation of all Smart Signals present in the payload that helps identify suspicious activity. The value range is [0; S] where S is sum of all Smart Signals weights.  See more details here: https://dev.fingerprint.com/docs/suspect-score  | [optional] 
**Tampering** | **bool** | Flag indicating browser tampering was detected. This happens when either:   * There are inconsistencies in the browser configuration that cross internal tampering thresholds (see &#x60;tampering_details.anomaly_score&#x60;).   * The browser signature resembles an \&quot;anti-detect\&quot; browser specifically designed to evade fingerprinting (see &#x60;tampering_details.anti_detect_browser&#x60;).  | [optional] 
**TamperingDetails** | [**TamperingDetails**](TamperingDetails.md) |  | [optional] 
**Velocity** | [**Velocity**](Velocity.md) |  | [optional] 
**VirtualMachine** | **bool** | &#x60;true&#x60; if the request came from a browser running inside a virtual machine (e.g. VMWare), &#x60;false&#x60; otherwise.  | [optional] 
**Vpn** | **bool** | VPN or other anonymizing service has been used when sending the request.  | [optional] 
**VpnConfidence** | **VpnConfidence** |  | [optional] 
**VpnOriginTimezone** | **string** | Local timezone which is used in timezone_mismatch method.  | [optional] 
**VpnOriginCountry** | **string** | Country of the request (only for Android SDK version &gt;&#x3D; 2.4.0, ISO 3166 format or unknown).  | [optional] 
**VpnMethods** | [**VpnMethods**](VpnMethods.md) |  | [optional] 
**HighActivityDevice** | **bool** | Flag indicating if the request came from a high-activity visitor. | [optional] 
**RawDeviceAttributes** | [**RawDeviceAttributes**](RawDeviceAttributes.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

