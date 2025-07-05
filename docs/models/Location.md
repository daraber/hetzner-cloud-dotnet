# Hetzner.Cloud.Model.Location
[Location](#locations) the [Datacenter](#datacenters) is located at.  | [Location](#locations) the for the [Floating IP](#floating-ips) is located at.  Routing is optimized for this [Location](#locations).  | Location of the Volume. Volume can only be attached to Servers in the same Location.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**City** | **string** | Name of the closest city to the [Location](#locations).  City name or city name and state in short form. E.g. &#x60;Falkenstein&#x60; or &#x60;Ashburn, VA&#x60;.  | 
**Country** | **string** | Country the [Location](#locations) resides in.  ISO 3166-1 alpha-2 code of the country.  | 
**Description** | **string** | Humand readable description of the [Location](#locations). | 
**Id** | **long** | ID of the Location. | 
**Latitude** | **double** | Latitude of the city closest to the [Location](#locations). | 
**Longitude** | **double** | Longitude of the city closest to the [Location](#locations). | 
**Name** | **string** | Unique identifier of the [Location](#locations). | 
**NetworkZone** | **string** | Name of the Network Zone this [Location](#locations) resides in. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

