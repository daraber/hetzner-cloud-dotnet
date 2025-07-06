using System;
using System.Net.Http;
using Hetzner.Cloud.Api;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hetzner.Cloud.Client;

/// <inheritdoc cref="IHetznerCloudClient" />
public class HetznerCloudClient : IHetznerCloudClient, IDisposable
{
    /// <inheritdoc />
    public ActionsApi Actions { get; }

    /// <inheritdoc />
    public CertificatesApi Certificates { get; }

    /// <inheritdoc />
    public DatacentersApi Datacenters { get; }

    /// <inheritdoc />
    public FirewallsApi Firewalls { get; }

    /// <inheritdoc />
    public FloatingIpsApi FloatingIps { get; }

    /// <inheritdoc />
    public ImagesApi Images { get; }

    /// <inheritdoc />
    public IsosApi Isos { get; }

    /// <inheritdoc />
    public LoadBalancersApi LoadBalancers { get; }

    /// <inheritdoc />
    public LoadBalancerTypesApi LoadBalancerTypes { get; }

    /// <inheritdoc />
    public LocationsApi Locations { get; }

    /// <inheritdoc />
    public NetworksApi Networks { get; }

    /// <inheritdoc />
    public PlacementGroupsApi PlacementGroups { get; }

    /// <inheritdoc />
    public PricingApi Pricing { get; }

    /// <inheritdoc />
    public PrimaryIpsApi PrimaryIps { get; }

    /// <inheritdoc />
    public ServersApi Servers { get; }

    /// <inheritdoc />
    public ServerTypesApi ServerTypes { get; }

    /// <inheritdoc />
    public SshKeysApi SshKeys { get; }

    /// <inheritdoc />
    public VolumesApi Volumes { get; }

    private readonly HttpClient _httpClient;
    private bool _disposed;

    /// <summary>
    /// Initializes a new instance of the <see cref="HetznerCloudClient"/> class with the specified API token.
    /// </summary>
    public HetznerCloudClient(string apiToken) : this(new HetznerCloudClientOptions(apiToken))
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HetznerCloudClient"/> class with the specified options.
    /// </summary>
    /// <param name="options">The options to configure the client.</param>
    public HetznerCloudClient(HetznerCloudClientOptions options)
    {
        ArgumentNullException.ThrowIfNull(options, nameof(options));
        ArgumentException.ThrowIfNullOrWhiteSpace(options.ApiToken, nameof(options.ApiToken));

        var bearerTokenProvider = new BearerTokenProvider(options.ApiToken);
        var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(options.JsonSerializerOptions);

        _httpClient = options.GetOrCreateHttpClient();

        // TODO: Use reflection to instantiate API instances (or meta-programming)
        Actions = new ActionsApi(
            NullLogger<ActionsApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new ActionsApiEvents(),
            bearerTokenProvider
        );

        Certificates = new CertificatesApi(
            NullLogger<CertificatesApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new CertificatesApiEvents(),
            bearerTokenProvider
        );

        Datacenters = new DatacentersApi(
            NullLogger<DatacentersApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new DatacentersApiEvents(),
            bearerTokenProvider
        );

        Firewalls = new FirewallsApi(
            NullLogger<FirewallsApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new FirewallsApiEvents(),
            bearerTokenProvider
        );

        FloatingIps = new FloatingIpsApi(
            NullLogger<FloatingIpsApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new FloatingIpsApiEvents(),
            bearerTokenProvider
        );

        Images = new ImagesApi(
            NullLogger<ImagesApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new ImagesApiEvents(),
            bearerTokenProvider
        );

        Isos = new IsosApi(
            NullLogger<IsosApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new IsosApiEvents(),
            bearerTokenProvider
        );

        LoadBalancers = new LoadBalancersApi(
            NullLogger<LoadBalancersApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new LoadBalancersApiEvents(),
            bearerTokenProvider
        );

        LoadBalancerTypes = new LoadBalancerTypesApi(
            NullLogger<LoadBalancerTypesApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new LoadBalancerTypesApiEvents(),
            bearerTokenProvider
        );

        Locations = new LocationsApi(
            NullLogger<LocationsApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new LocationsApiEvents(),
            bearerTokenProvider
        );

        Networks = new NetworksApi(
            NullLogger<NetworksApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new NetworksApiEvents(),
            bearerTokenProvider
        );

        PlacementGroups = new PlacementGroupsApi(
            NullLogger<PlacementGroupsApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new PlacementGroupsApiEvents(),
            bearerTokenProvider
        );

        Pricing = new PricingApi(
            NullLogger<PricingApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new PricingApiEvents(),
            bearerTokenProvider
        );

        PrimaryIps = new PrimaryIpsApi(
            NullLogger<PrimaryIpsApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new PrimaryIpsApiEvents(),
            bearerTokenProvider
        );

        Servers = new ServersApi(
            NullLogger<ServersApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new ServersApiEvents(),
            bearerTokenProvider
        );

        ServerTypes = new ServerTypesApi(
            NullLogger<ServerTypesApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new ServerTypesApiEvents(),
            bearerTokenProvider
        );

        SshKeys = new SshKeysApi(
            NullLogger<SshKeysApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new SshKeysApiEvents(),
            bearerTokenProvider
        );

        Volumes = new VolumesApi(
            NullLogger<VolumesApi>.Instance,
            options.LoggerFactory,
            _httpClient,
            jsonSerializerOptionsProvider,
            new VolumesApiEvents(),
            bearerTokenProvider
        );
    }

    /// <summary>
    /// Disposes the <see cref="HetznerCloudClient"/> and releases any resources it holds.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _httpClient.Dispose();
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}