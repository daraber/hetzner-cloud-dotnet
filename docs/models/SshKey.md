# Hetzner.Cloud.Model.SshKey
SSH keys are public keys you provide to the cloud system. They can be injected into Servers at creation time. We highly recommend that you use keys instead of passwords to manage your Servers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Fingerprint** | **string** | Fingerprint of public key | 
**Id** | **long** | ID of the SSH Key. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**PublicKey** | **string** | Public key | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

