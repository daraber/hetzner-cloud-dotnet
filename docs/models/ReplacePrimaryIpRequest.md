# Hetzner.Cloud.Model.ReplacePrimaryIpRequest
Request for PUT https://api.hetzner.cloud/v1/primary_ips/{id}

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoDelete** | **bool** | Auto deletion state.  If enabled the [Primary IP](#primary-ips) will be deleted once the assigned resource gets deleted.  | [optional] [default to false]
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Name** | **string** | Name of the Resource. Must be unique per Project. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

