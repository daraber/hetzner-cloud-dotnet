## Using the library in your project

```cs
using Hetzner.Cloud.Client;

var apiToken = "<your api token>";
var hetznerClient = new HetznerCloudClient(apiToken);

var response = await hetznerClient.Locations.ListLocationsAsync();
if (!response.TryOk(out var result))
{
    Console.WriteLine($"Bad API response: {response.StatusCode}");
    return;
}

result.Locations.ForEach(Console.WriteLine);
```