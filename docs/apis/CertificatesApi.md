# Hetzner.Cloud.Api.CertificatesApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCertificate**](CertificatesApi.md#createcertificate) | **POST** /certificates | Create a Certificate |
| [**DeleteCertificate**](CertificatesApi.md#deletecertificate) | **DELETE** /certificates/{id} | Delete a Certificate |
| [**GetActionForCertificate**](CertificatesApi.md#getactionforcertificate) | **GET** /certificates/{id}/actions/{action_id} | Get an Action for a Certificate |
| [**GetCertificate**](CertificatesApi.md#getcertificate) | **GET** /certificates/{id} | Get a Certificate |
| [**GetCertificateAction**](CertificatesApi.md#getcertificateaction) | **GET** /certificates/actions/{id} | Get an Action |
| [**ListActionsForCertificate**](CertificatesApi.md#listactionsforcertificate) | **GET** /certificates/{id}/actions | Get all Actions for a Certificate |
| [**ListCertificateActions**](CertificatesApi.md#listcertificateactions) | **GET** /certificates/actions | Get all Actions |
| [**ListCertificates**](CertificatesApi.md#listcertificates) | **GET** /certificates | Get all Certificates |
| [**ReplaceCertificate**](CertificatesApi.md#replacecertificate) | **PUT** /certificates/{id} | Update a Certificate |
| [**RetryIssuanceOrRenewal**](CertificatesApi.md#retryissuanceorrenewal) | **POST** /certificates/{id}/actions/retry | Retry Issuance or Renewal |

<a id="createcertificate"></a>
# **CreateCertificate**
> CreateCertificateResponse CreateCertificate (CreateCertificateRequest createCertificateRequest = null)

Create a Certificate

Creates a new Certificate.  The default type **uploaded** allows for uploading your existing `certificate` and `private_key` in PEM format. You have to monitor its expiration date and handle renewal yourself.  In contrast, type **managed** requests a new Certificate from *Let's Encrypt* for the specified `domain_names`. Only domains managed by *Hetzner DNS* are supported. We handle renewal and timely alert the project owner via email if problems occur.  For type `managed` Certificates the `action` key of the response contains the Action that allows for tracking the issuance process. For type `uploaded` Certificates the `action` is always null. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCertificateRequest** | [**CreateCertificateRequest**](CreateCertificateRequest.md) |  | [optional]  |

### Return type

[**CreateCertificateResponse**](CreateCertificateResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;certificate&#x60; key contains the Certificate that was just created. For type &#x60;managed&#x60; Certificates the &#x60;action&#x60; key contains the Action that allows for tracking the issuance process. For type &#x60;uploaded&#x60; Certificates the &#x60;action&#x60; is always null. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecertificate"></a>
# **DeleteCertificate**
> void DeleteCertificate (long id)

Delete a Certificate

Deletes a Certificate.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Certificate. |  |

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Certificate deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforcertificate"></a>
# **GetActionForCertificate**
> GetActionForCertificateResponse GetActionForCertificate (long id, long actionId)

Get an Action for a Certificate

Returns a specific Action for a Certificate. Only type `managed` Certificates have Actions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Certificate. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForCertificateResponse**](GetActionForCertificateResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key contains the Certificate Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcertificate"></a>
# **GetCertificate**
> GetCertificateResponse GetCertificate (long id)

Get a Certificate

Gets a specific Certificate object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Certificate. |  |

### Return type

[**GetCertificateResponse**](GetCertificateResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;certificate&#x60; key contains a Certificate object |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcertificateaction"></a>
# **GetCertificateAction**
> GetActionResponse GetCertificateAction (long id)

Get an Action

Returns a specific Action object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Action |  |

### Return type

[**GetActionResponse**](GetActionResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key in the reply has this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listactionsforcertificate"></a>
# **ListActionsForCertificate**
> ListActionsForCertificateResponse ListActionsForCertificate (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Certificate

Returns all Action objects for a Certificate. You can sort the results by using the `sort` URI parameter, and filter them with the `status` parameter.  Only type `managed` Certificates can have Actions. For type `uploaded` Certificates the `actions` key will always contain an empty array. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Certificate |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForCertificateResponse**](ListActionsForCertificateResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;actions&#x60; key contains a list of Actions |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcertificateactions"></a>
# **ListCertificateActions**
> ListActionsResponse ListCertificateActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions

Returns all Action objects. You can `sort` the results by using the sort URI parameter, and filter them with the `status` and `id` parameter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Filter the actions by ID. Can be used multiple times. The response will only contain actions matching the specified IDs.  | [optional]  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsResponse**](ListActionsResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;actions&#x60; key contains a list of Actions |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcertificates"></a>
# **ListCertificates**
> ListCertificatesResponse ListCertificates (string sort = null, string name = null, string labelSelector = null, string type = null, long page = null, long perPage = null)

Get all Certificates

Returns all Certificate objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **type** | **string** | Can be used multiple times. The response will only contain Certificates matching the type. | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListCertificatesResponse**](ListCertificatesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;certificates&#x60; key contains an array of Certificate objects |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replacecertificate"></a>
# **ReplaceCertificate**
> ReplaceCertificateResponse ReplaceCertificate (long id, ReplaceCertificateRequest replaceCertificateRequest = null)

Update a Certificate

Updates the Certificate properties.  Note that when updating labels, the Certificate’s current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.  Note: if the Certificate object changes during the request, the response will be a “conflict” error. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Certificate. |  |
| **replaceCertificateRequest** | [**ReplaceCertificateRequest**](ReplaceCertificateRequest.md) |  | [optional]  |

### Return type

[**ReplaceCertificateResponse**](ReplaceCertificateResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;certificate&#x60; key contains the Certificate that was just updated |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="retryissuanceorrenewal"></a>
# **RetryIssuanceOrRenewal**
> RetryIssuanceOrRenewalResponse RetryIssuanceOrRenewal (long id)

Retry Issuance or Renewal

Retry a failed Certificate issuance or renewal.  Only applicable if the type of the Certificate is `managed` and the issuance or renewal status is `failed`.  #### Call specific error codes  | Code                                                    | Description                                                               | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `caa_record_does_not_allow_ca`                          | CAA record does not allow certificate authority                           | | `ca_dns_validation_failed`                              | Certificate Authority: DNS validation failed                              | | `ca_too_many_authorizations_failed_recently`            | Certificate Authority: Too many authorizations failed recently            | | `ca_too_many_certificates_issued_for_registered_domain` | Certificate Authority: Too many certificates issued for registered domain | | `ca_too_many_duplicate_certificates`                    | Certificate Authority: Too many duplicate certificates                    | | `could_not_verify_domain_delegated_to_zone`             | Could not verify domain delegated to zone                                 | | `dns_zone_not_found`                                    | DNS zone not found                                                        | | `dns_zone_is_secondary_zone`                            | DNS zone is a secondary zone                                              | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Certificate. |  |

### Return type

[**RetryIssuanceOrRenewalResponse**](RetryIssuanceOrRenewalResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the resulting Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

