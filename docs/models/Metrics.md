# Hetzner.Cloud.Model.Metrics
You must specify the type of metric to get: open_connections, requests_per_second or bandwidth. You can also specify more than one type by comma separation, e.g. requests_per_second,bandwidth. Depending on the type you will get different time series data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**End** | **string** | End of period of metrics reported (in ISO-8601 format) | 
**Start** | **string** | Start of period of metrics reported (in ISO-8601 format) | 
**Step** | **int** | Resolution of results in seconds. | 
**TimeSeries** | [**Dictionary&lt;string, MetricsTimeSeriesValue&gt;**](MetricsTimeSeriesValue.md) | Hash with timeseries information, containing the name of timeseries as key | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

