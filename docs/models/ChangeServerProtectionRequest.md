# Hetzner.Cloud.Model.ChangeServerProtectionRequest
Request for POST https://api.hetzner.cloud/v1/servers/{id}/actions/change_protection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Delete** | **bool** | If true, prevents the Server from being deleted (currently delete and rebuild attribute needs to have the same value) | [optional] 
**Rebuild** | **bool** | If true, prevents the Server from being rebuilt (currently delete and rebuild attribute needs to have the same value) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

