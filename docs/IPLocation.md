# FingerprintPro.ServerSdk.Model.IPLocation
This field is **deprecated** and will not return a result for **accounts created after December 18th, 2023**. Please use the [`ipInfo` Smart signal](https://dev.fingerprint.com/docs/smart-signals-overview#ip-geolocation) for geolocation information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccuracyRadius** | **int?** | The IP address is likely to be within this radius (in km) of the specified location. | [optional] 
**Latitude** | **double?** |  | [optional] 
**Longitude** | **double?** |  | [optional] 
**PostalCode** | **string** |  | [optional] 
**Timezone** | **string** |  | [optional] 
**City** | [**IPLocationCity**](IPLocationCity.md) |  | [optional] 
**Country** | [**Location**](Location.md) |  | [optional] 
**Continent** | [**Location**](Location.md) |  | [optional] 
**Subdivisions** | [**List&lt;Subdivision&gt;**](Subdivision.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

