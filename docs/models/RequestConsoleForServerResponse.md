# Hetzner.Cloud.Model.RequestConsoleForServerResponse
Response to POST https://api.hetzner.cloud/v1/servers/{id}/actions/request_console

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | [**Action**](Action.md) |  | 
**Password** | **string** | VNC password to use for this connection (this password only works in combination with a wss_url with valid token) | 
**WssUrl** | **string** | URL of websocket proxy to use; this includes a token which is valid for a limited time only | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

