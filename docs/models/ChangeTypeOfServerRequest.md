# Hetzner.Cloud.Model.ChangeTypeOfServerRequest
Request for POST https://api.hetzner.cloud/v1/servers/{id}/actions/change_type

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerType** | **string** | ID or name of Server type the Server should migrate to | 
**UpgradeDisk** | **bool** | If false, do not upgrade the disk (this allows downgrading the Server type later) | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

