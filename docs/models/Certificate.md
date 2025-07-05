# Hetzner.Cloud.Model.Certificate
TLS/SSL Certificates prove the identity of a Server and are used to encrypt client traffic.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**DomainNames** | **List&lt;string&gt;** | Domains and subdomains covered by the Certificate | 
**Id** | **long** | ID of the Certificate. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**UsedBy** | [**List&lt;Resource&gt;**](Resource.md) | Resources currently using the Certificate | 
**VarCertificate** | **string** | Certificate and chain in PEM format, in order so that each record directly certifies the one preceding | 
**Fingerprint** | **string** | SHA256 fingerprint of the Certificate | 
**NotValidAfter** | **string** | Point in time when the Certificate stops being valid (in ISO-8601 format) | 
**NotValidBefore** | **string** | Point in time when the Certificate becomes valid (in ISO-8601 format) | 
**Status** | [**CertificateStatus**](CertificateStatus.md) |  | [optional] 
**Type** | **string** | Type of the Certificate | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

