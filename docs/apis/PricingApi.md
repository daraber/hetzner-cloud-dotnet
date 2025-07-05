# Hetzner.Cloud.Api.PricingApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListPrices**](PricingApi.md#listprices) | **GET** /pricing | Get all prices |

<a id="listprices"></a>
# **ListPrices**
> ListPricesResponse ListPrices ()

Get all prices

Returns prices for all resources available on the platform. VAT and currency of the Project owner are used for calculations.  Both net and gross prices are included in the response. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListPricesResponse**](ListPricesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;pricing&#x60; key in the reply contains an pricing object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

