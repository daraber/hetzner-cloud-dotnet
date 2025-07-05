# Hetzner.Cloud.Model.CreateVolumeRequest
Request for POST https://api.hetzner.cloud/v1/volumes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the volume | 
**Size** | **int** | Size of the Volume in GB | 
**Automount** | **bool** | Auto-mount Volume after attach. &#x60;server&#x60; must be provided. | [optional] 
**Format** | **string** | Format Volume after creation. One of: &#x60;xfs&#x60;, &#x60;ext4&#x60; | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Location** | **string** | Location to create the Volume in (can be omitted if Server is specified) | [optional] 
**Server** | **long** | Server to which to attach the Volume once it&#39;s created (Volume will be created in the same Location as the server) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

