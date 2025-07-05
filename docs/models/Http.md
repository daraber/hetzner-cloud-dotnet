# Hetzner.Cloud.Model.Http
Configuration option for protocols http and https

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificates** | **List&lt;long&gt;** | IDs of the Certificates to use for TLS/SSL termination by the Load Balancer; empty for TLS/SSL passthrough or if &#x60;protocol&#x60; is &#x60;http&#x60;. | [optional] 
**CookieLifetime** | **int** | Lifetime of the cookie used for sticky sessions (in seconds). | [optional] [default to 300]
**CookieName** | **string** | Name of the cookie used for sticky sessions. | [optional] [default to "HCLBSTICKY"]
**RedirectHttp** | **bool** | Redirect HTTP requests to HTTPS. Only available if &#x60;protocol&#x60; is &#x60;https&#x60;. | [optional] [default to false]
**StickySessions** | **bool** | Use sticky sessions. Only available if &#x60;protocol&#x60; is &#x60;http&#x60; or &#x60;https&#x60;. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

