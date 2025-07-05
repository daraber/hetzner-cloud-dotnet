# Hetzner.Cloud.Model.ReplaceNetworkRequest
Request for PUT https://api.hetzner.cloud/v1/networks/{id}

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExposeRoutesToVswitch** | **bool** | Toggle to expose routes to the [Networks](#networks) vSwitch.  Indicates if the routes from this [Network](#networks) should be exposed to the vSwitch in this [Network](#networks). Only takes effect if a [vSwitch is setup](https://docs.hetzner.com/cloud/networks/connect-dedi-vswitch) in this [Network](#networks).  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Name** | **string** | New [Network](#networks) name. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

