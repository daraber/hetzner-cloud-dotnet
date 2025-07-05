# Hetzner.Cloud.Model.CreateImageFromServerRequest
Request for POST https://api.hetzner.cloud/v1/servers/{id}/actions/create_image

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the Image, will be auto-generated if not set | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Type** | **string** | Type of Image to create. | [optional] [default to TypeEnum.Snapshot]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

