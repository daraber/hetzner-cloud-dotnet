# Hetzner.Cloud.Model.CreateCertificateRequest
Request for POST https://api.hetzner.cloud/v1/certificates

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Certificate | 
**Certificate** | **string** | Certificate and chain in PEM format, in order so that each record directly certifies the one preceding. Required for type &#x60;uploaded&#x60; Certificates. | [optional] 
**DomainNames** | **List&lt;string&gt;** | Domains and subdomains that should be contained in the Certificate issued by *Let&#39;s Encrypt*. Required for type &#x60;managed&#x60; Certificates. | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**PrivateKey** | **string** | Certificate key in PEM format. Required for type &#x60;uploaded&#x60; Certificates. | [optional] 
**Type** | **string** | Choose between uploading a Certificate in PEM format or requesting a managed *Let&#39;s Encrypt* Certificate. | [optional] [default to TypeEnum.Uploaded]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

