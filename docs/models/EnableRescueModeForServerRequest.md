# Hetzner.Cloud.Model.EnableRescueModeForServerRequest
Request for POST https://api.hetzner.cloud/v1/servers/{id}/actions/enable_rescue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SshKeys** | **List&lt;long&gt;** | Array of SSH key IDs which should be injected into the rescue system. | [optional] 
**Type** | **string** | Type of rescue system to boot. | [optional] [default to TypeEnum.Linux64]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

