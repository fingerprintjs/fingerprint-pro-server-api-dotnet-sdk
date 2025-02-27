# FingerprintPro.ServerSdk.Model.DeprecatedGeolocation
This field is **deprecated** and will not return a result for **applications created after January 23rd, 2024**.  Please use the [IP Geolocation Smart signal](https://dev.fingerprint.com/docs/smart-signals-overview#ip-geolocation) for geolocation information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccuracyRadius** | **int?** | The IP address is likely to be within this radius (in km) of the specified location. | [optional] 
**Latitude** | **double?** |  | [optional] 
**Longitude** | **double?** |  | [optional] 
**PostalCode** | **string** |  | [optional] 
**Timezone** | **string** |  | [optional] 
**City** | [**GeolocationCity**](GeolocationCity.md) |  | [optional] 
**Country** | [**GeolocationCountry**](GeolocationCountry.md) |  | [optional] 
**Continent** | [**GeolocationContinent**](GeolocationContinent.md) |  | [optional] 
**Subdivisions** | [**GeolocationSubdivisions**](GeolocationSubdivisions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

