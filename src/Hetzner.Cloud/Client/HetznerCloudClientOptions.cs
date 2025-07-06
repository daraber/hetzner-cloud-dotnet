using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Hetzner.Cloud.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hetzner.Cloud.Client;

/// <summary>
/// Configuration options for <see cref="HetznerCloudClient"/>.
/// </summary>
public sealed class HetznerCloudClientOptions
{
    private HttpMessageHandler? _handler;
    private HttpClient? _httpClient;

    /// <summary>
    /// The API token used for authentication with the Hetzner Cloud API.
    /// </summary>
    public string ApiToken { get; }

    /// <summary>
    /// The logger factory used for creating loggers. Defaults to <see cref="NullLoggerFactory.Instance"/>.
    /// </summary>
    public ILoggerFactory LoggerFactory { get; set; } = NullLoggerFactory.Instance;

    /// <summary>
    /// JSON serializer options used for serializing and deserializing HTTP requests and responses.
    /// Defaults to an instance with necessary custom converters and type info resolvers for the Hetzner Cloud API types.
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; set; } = CreateDefaultJsonSerializerOptions();

    /// <summary>
    /// Custom <see cref="HttpClient"/> instance to use for API requests.
    /// Setting this property will clear any custom message handler.
    /// </summary>
    /// <remarks>
    /// If both <see cref="CustomHttpClient"/> and <see cref="CustomHttpMessageHandler"/> are null,
    /// a default client will be created.
    /// </remarks>
    public HttpClient? CustomHttpClient
    {
        get => _httpClient;
        set
        {
            _httpClient = value;
            _handler = null; // Clear handler when custom client is set
        }
    }

    /// <summary>
    /// Custom <see cref="HttpMessageHandler"/> to use when creating the HTTP client.
    /// Setting this property will clear any custom HTTP client.
    /// </summary>
    /// <remarks>
    /// This is used only when <see cref="CustomHttpClient"/> is null and a new client is created.
    /// </remarks>
    public HttpMessageHandler? CustomHttpMessageHandler
    {
        get => _handler;
        set
        {
            _handler = value;
            _httpClient = null; // Clear client when custom handler is set
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HetznerCloudClientOptions"/> class with the specified API token.
    /// </summary>
    /// <param name="apiToken"></param>
    public HetznerCloudClientOptions(string apiToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiToken, nameof(apiToken));
        ApiToken = apiToken;
    }

    internal HttpClient GetOrCreateHttpClient()
    {
        if (_httpClient != null)
        {
            return _httpClient;
        }

        var handler = _handler ?? new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.All
        };

        var disposeHandler = _handler == null; // No custom handler set, so dispose it.

        // TODO: Add more options such as timeout?
        var client = new HttpClient(handler, disposeHandler: disposeHandler)
        {
            BaseAddress = new Uri(ClientUtils.BASE_ADDRESS)
        };

        return client;
    }


    private static JsonSerializerOptions CreateDefaultJsonSerializerOptions()
    {
        var jsonOptions = new JsonSerializerOptions();

        AddJsonConverters(jsonOptions);
        AddJsonTypeInfoResolvers(jsonOptions);

        return jsonOptions;
    }

    /// <summary>
    /// Adds custom JSON converters to the provided <see cref="JsonSerializerOptions"/>.
    /// </summary>
    /// <remarks>
    /// Copied from <see cref="HostConfiguration"/> constructor.
    /// </remarks>
    private static void AddJsonConverters(JsonSerializerOptions jsonOptions)
    {
        // TODO: Discover converters with reflection and add them dynamically (or use meta-programming)
        jsonOptions.Converters.Add(new JsonStringEnumConverter());
        jsonOptions.Converters.Add(new DateTimeJsonConverter());
        jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
        jsonOptions.Converters.Add(new DateOnlyJsonConverter());
        jsonOptions.Converters.Add(new DateOnlyNullableJsonConverter());
        jsonOptions.Converters.Add(new ActionJsonConverter());
        jsonOptions.Converters.Add(new ActionOptionalJsonConverter());
        jsonOptions.Converters.Add(new AddRouteToNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new AddServerToPlacementGroupRequestJsonConverter());
        jsonOptions.Converters.Add(new AddServerToPlacementGroupResponseJsonConverter());
        jsonOptions.Converters.Add(new AddServiceResponseJsonConverter());
        jsonOptions.Converters.Add(new AddSubnetToNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new AddTargetResponseJsonConverter());
        jsonOptions.Converters.Add(new ApplyToResourcesRequestJsonConverter());
        jsonOptions.Converters.Add(new ApplyToResourcesResponseJsonConverter());
        jsonOptions.Converters.Add(new ArchitectureJsonConverter());
        jsonOptions.Converters.Add(new ArchitectureNullableJsonConverter());
        jsonOptions.Converters.Add(new ArchitectureOptionalJsonConverter());
        jsonOptions.Converters.Add(new ArchitectureOptionalNullableJsonConverter());
        jsonOptions.Converters.Add(new AssignFloatingIpToServerRequestJsonConverter());
        jsonOptions.Converters.Add(new AssignFloatingIpToServerResponseJsonConverter());
        jsonOptions.Converters.Add(new AssignPrimaryIpToResourceRequestJsonConverter());
        jsonOptions.Converters.Add(new AssignPrimaryIpToResourceResponseJsonConverter());
        jsonOptions.Converters.Add(new AttachIsoToServerRequestJsonConverter());
        jsonOptions.Converters.Add(new AttachIsoToServerResponseJsonConverter());
        jsonOptions.Converters.Add(new AttachLoadBalancerToNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new AttachLoadBalancerToNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new AttachServerToNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new AttachServerToNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new AttachVolumeToServerRequestJsonConverter());
        jsonOptions.Converters.Add(new AttachVolumeToServerResponseJsonConverter());
        jsonOptions.Converters.Add(new CertificateJsonConverter());
        jsonOptions.Converters.Add(new CertificateStatusJsonConverter());
        jsonOptions.Converters.Add(new CertificateStatusErrorJsonConverter());
        jsonOptions.Converters.Add(new ChangeAlgorithmResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeAliasIpsOfNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeAliasIpsOfNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeFloatingIpProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeImageProtectionRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeImageProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeIpRangeOfNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeIpRangeOfNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeLoadBalancerProtectionRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeLoadBalancerProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeNetworkProtectionRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeNetworkProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangePrimaryIpProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeReverseDnsEntryForThisLoadBalancerRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeReverseDnsEntryForThisLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeReverseDnsEntryForThisServerRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeReverseDnsEntryForThisServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeReverseDnsRecordsForFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeReverseDnsRecordsForPrimaryIpResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeServerProtectionRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeServerProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeTypeOfLoadBalancerRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeTypeOfLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeTypeOfServerRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeTypeOfServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ChangeVolumeProtectionRequestJsonConverter());
        jsonOptions.Converters.Add(new ChangeVolumeProtectionResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateCertificateRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateCertificateResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateFirewallRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateFirewallResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateFloatingIpRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateImageFromServerRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateImageFromServerResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateLoadBalancerRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new CreatePlacementgroupRequestJsonConverter());
        jsonOptions.Converters.Add(new CreatePlacementgroupResponseJsonConverter());
        jsonOptions.Converters.Add(new CreatePrimaryIpRequestJsonConverter());
        jsonOptions.Converters.Add(new CreatePrimaryIpResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateServerRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateServerRequestFirewallsJsonConverter());
        jsonOptions.Converters.Add(new CreateServerRequestPublicNetJsonConverter());
        jsonOptions.Converters.Add(new CreateServerResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateSshKeyRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateSshKeyResponseJsonConverter());
        jsonOptions.Converters.Add(new CreateVolumeRequestJsonConverter());
        jsonOptions.Converters.Add(new CreateVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new CreatedFromJsonConverter());
        jsonOptions.Converters.Add(new DatacenterJsonConverter());
        jsonOptions.Converters.Add(new DatacenterServerTypesJsonConverter());
        jsonOptions.Converters.Add(new DeleteRouteFromNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new DeleteServerResponseJsonConverter());
        jsonOptions.Converters.Add(new DeleteServiceRequestJsonConverter());
        jsonOptions.Converters.Add(new DeleteServiceResponseJsonConverter());
        jsonOptions.Converters.Add(new DeleteSubnetFromNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new DeleteSubnetFromNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new DeprecationInfoJsonConverter());
        jsonOptions.Converters.Add(new DetachIsoFromServerResponseJsonConverter());
        jsonOptions.Converters.Add(new DetachLoadBalancerFromNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new DetachLoadBalancerFromNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new DetachServerFromNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new DetachServerFromNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new DetachVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new DisableBackupsForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new DisablePublicInterfaceOfLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new DisableRescueModeForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new DnsPtrJsonConverter());
        jsonOptions.Converters.Add(new EnableAndConfigureBackupsForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new EnablePublicInterfaceOfLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new EnableRescueModeForServerRequestJsonConverter());
        jsonOptions.Converters.Add(new EnableRescueModeForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ErrorJsonConverter());
        jsonOptions.Converters.Add(new FirewallJsonConverter());
        jsonOptions.Converters.Add(new FirewallResourceJsonConverter());
        jsonOptions.Converters.Add(new FirewallResourceIdJsonConverter());
        jsonOptions.Converters.Add(new FirewallResourceIdAppliedToResourcesJsonConverter());
        jsonOptions.Converters.Add(new FloatingIpJsonConverter());
        jsonOptions.Converters.Add(new GetActionForCertificateResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForFirewallResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForImageResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionForVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new GetActionResponseJsonConverter());
        jsonOptions.Converters.Add(new GetCertificateResponseJsonConverter());
        jsonOptions.Converters.Add(new GetDatacenterResponseJsonConverter());
        jsonOptions.Converters.Add(new GetFirewallResponseJsonConverter());
        jsonOptions.Converters.Add(new GetFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new GetImageResponseJsonConverter());
        jsonOptions.Converters.Add(new GetIsoResponseJsonConverter());
        jsonOptions.Converters.Add(new GetLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new GetLoadBalancerTypeResponseJsonConverter());
        jsonOptions.Converters.Add(new GetLocationResponseJsonConverter());
        jsonOptions.Converters.Add(new GetMetricsForLoadbalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new GetMetricsForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new GetNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new GetPlacementgroupResponseJsonConverter());
        jsonOptions.Converters.Add(new GetPrimaryIpResponseJsonConverter());
        jsonOptions.Converters.Add(new GetServerResponseJsonConverter());
        jsonOptions.Converters.Add(new GetServerTypeResponseJsonConverter());
        jsonOptions.Converters.Add(new GetSshKeyResponseJsonConverter());
        jsonOptions.Converters.Add(new GetVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new HttpJsonConverter());
        jsonOptions.Converters.Add(new ImageJsonConverter());
        jsonOptions.Converters.Add(new ImageOptionalJsonConverter());
        jsonOptions.Converters.Add(new IpTypeJsonConverter());
        jsonOptions.Converters.Add(new IpTypeNullableJsonConverter());
        jsonOptions.Converters.Add(new Ipv4JsonConverter());
        jsonOptions.Converters.Add(new Ipv6JsonConverter());
        jsonOptions.Converters.Add(new IsoJsonConverter());
        jsonOptions.Converters.Add(new IsoOptionalJsonConverter());
        jsonOptions.Converters.Add(new LabelSelectorJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForCertificateResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForFirewallResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForImageResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsForVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new ListActionsResponseJsonConverter());
        jsonOptions.Converters.Add(new ListCertificatesResponseJsonConverter());
        jsonOptions.Converters.Add(new ListDatacentersResponseJsonConverter());
        jsonOptions.Converters.Add(new ListFirewallsResponseJsonConverter());
        jsonOptions.Converters.Add(new ListFloatingIpsResponseJsonConverter());
        jsonOptions.Converters.Add(new ListImagesResponseJsonConverter());
        jsonOptions.Converters.Add(new ListIsosResponseJsonConverter());
        jsonOptions.Converters.Add(new ListLoadBalancerTypesResponseJsonConverter());
        jsonOptions.Converters.Add(new ListLoadBalancersResponseJsonConverter());
        jsonOptions.Converters.Add(new ListLocationsResponseJsonConverter());
        jsonOptions.Converters.Add(new ListNetworksResponseJsonConverter());
        jsonOptions.Converters.Add(new ListPlacementgroupsResponseJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponseJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingFloatingIpJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingFloatingIpsJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingImageJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingLoadBalancerTypesJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingPrimaryIpsJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingServerBackupJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingServerTypesJsonConverter());
        jsonOptions.Converters.Add(new ListPricesResponsePricingVolumeJsonConverter());
        jsonOptions.Converters.Add(new ListPrimaryIpsResponseJsonConverter());
        jsonOptions.Converters.Add(new ListServerTypesResponseJsonConverter());
        jsonOptions.Converters.Add(new ListServersResponseJsonConverter());
        jsonOptions.Converters.Add(new ListSshKeysResponseJsonConverter());
        jsonOptions.Converters.Add(new ListVolumesResponseJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerAddTargetJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerAlgorithmJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerPrivateNetJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerPublicNetJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerPublicNetIpv4JsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerPublicNetIpv6JsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerSelectedTargetJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerServiceJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerServiceHealthCheckJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerServiceHealthCheckHttpJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerTargetJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerTargetHealthStatusJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerTargetIpJsonConverter());
        jsonOptions.Converters.Add(new LoadBalancerTypeJsonConverter());
        jsonOptions.Converters.Add(new LocationJsonConverter());
        jsonOptions.Converters.Add(new MetaJsonConverter());
        jsonOptions.Converters.Add(new MetricsJsonConverter());
        jsonOptions.Converters.Add(new MetricsTimeSeriesValueJsonConverter());
        jsonOptions.Converters.Add(new NetworkJsonConverter());
        jsonOptions.Converters.Add(new PaginationJsonConverter());
        jsonOptions.Converters.Add(new PlacementGroupJsonConverter());
        jsonOptions.Converters.Add(new PlacementGroupNullableJsonConverter());
        jsonOptions.Converters.Add(new PowerOffServerResponseJsonConverter());
        jsonOptions.Converters.Add(new PowerOnServerResponseJsonConverter());
        jsonOptions.Converters.Add(new PriceJsonConverter());
        jsonOptions.Converters.Add(new PricePerTimeJsonConverter());
        jsonOptions.Converters.Add(new PricePerTimeMonthlyJsonConverter());
        jsonOptions.Converters.Add(new PricePerTimeWithoutTrafficJsonConverter());
        jsonOptions.Converters.Add(new PrimaryIPJsonConverter());
        jsonOptions.Converters.Add(new ProtectionJsonConverter());
        jsonOptions.Converters.Add(new RebuildServerFromImageRequestJsonConverter());
        jsonOptions.Converters.Add(new RebuildServerFromImageResponseJsonConverter());
        jsonOptions.Converters.Add(new RemoveFromPlacementGroupResponseJsonConverter());
        jsonOptions.Converters.Add(new RemoveFromResourcesRequestJsonConverter());
        jsonOptions.Converters.Add(new RemoveFromResourcesResponseJsonConverter());
        jsonOptions.Converters.Add(new RemoveTargetRequestJsonConverter());
        jsonOptions.Converters.Add(new RemoveTargetResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceCertificateRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceCertificateResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceFirewallRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceFirewallResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceFloatingIpRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceImageRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceImageResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceLoadBalancerRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceLoadBalancerResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceNetworkRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceNetworkResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplacePlacementgroupRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplacePlacementgroupResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplacePrimaryIpRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplacePrimaryIpResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceServerRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceSshKeyRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceSshKeyResponseJsonConverter());
        jsonOptions.Converters.Add(new ReplaceVolumeRequestJsonConverter());
        jsonOptions.Converters.Add(new ReplaceVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new RequestConsoleForServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ResetRootPasswordOfServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ResetServerResponseJsonConverter());
        jsonOptions.Converters.Add(new ResizeVolumeRequestJsonConverter());
        jsonOptions.Converters.Add(new ResizeVolumeResponseJsonConverter());
        jsonOptions.Converters.Add(new ResourceJsonConverter());
        jsonOptions.Converters.Add(new ResourceIdJsonConverter());
        jsonOptions.Converters.Add(new RetryIssuanceOrRenewalResponseJsonConverter());
        jsonOptions.Converters.Add(new RouteJsonConverter());
        jsonOptions.Converters.Add(new RuleJsonConverter());
        jsonOptions.Converters.Add(new RuleResponseJsonConverter());
        jsonOptions.Converters.Add(new ServerJsonConverter());
        jsonOptions.Converters.Add(new ServerPrivateNetJsonConverter());
        jsonOptions.Converters.Add(new ServerProtectionJsonConverter());
        jsonOptions.Converters.Add(new ServerPublicNetJsonConverter());
        jsonOptions.Converters.Add(new ServerPublicNetFirewallJsonConverter());
        jsonOptions.Converters.Add(new ServerTypeJsonConverter());
        jsonOptions.Converters.Add(new SetRulesRequestJsonConverter());
        jsonOptions.Converters.Add(new SetRulesResponseJsonConverter());
        jsonOptions.Converters.Add(new ShutdownServerResponseJsonConverter());
        jsonOptions.Converters.Add(new SoftRebootServerResponseJsonConverter());
        jsonOptions.Converters.Add(new SshKeyJsonConverter());
        jsonOptions.Converters.Add(new SubnetJsonConverter());
        jsonOptions.Converters.Add(new SubnetWithGatewayJsonConverter());
        jsonOptions.Converters.Add(new UnassignFloatingIpResponseJsonConverter());
        jsonOptions.Converters.Add(new UnassignPrimaryIpFromResourceResponseJsonConverter());
        jsonOptions.Converters.Add(new UpdateLoadBalancerServiceJsonConverter());
        jsonOptions.Converters.Add(new UpdateLoadBalancerServiceHealthCheckJsonConverter());
        jsonOptions.Converters.Add(new UpdateLoadBalancerServiceHealthCheckHttpJsonConverter());
        jsonOptions.Converters.Add(new UpdateServiceResponseJsonConverter());
        jsonOptions.Converters.Add(new VolumeJsonConverter());
    }

    /// <summary>
    /// Adds custom type info resolvers to the provided <see cref="JsonSerializerOptions"/>.
    /// </summary>
    /// <remarks>
    /// Resolvers copied from from <see cref="HostConfiguration"/> constructor. 
    /// </remarks>
    private static void AddJsonTypeInfoResolvers(JsonSerializerOptions jsonOptions)
    {
        // TODO: Discover type info resolvers with reflection and add them dynamically (or use meta-programming)
        jsonOptions.TypeInfoResolver = JsonTypeInfoResolver.Combine(
            new ActionSerializationContext(),
            new ActionOptionalSerializationContext(),
            new AddRouteToNetworkResponseSerializationContext(),
            new AddServerToPlacementGroupRequestSerializationContext(),
            new AddServerToPlacementGroupResponseSerializationContext(),
            new AddServiceResponseSerializationContext(),
            new AddSubnetToNetworkResponseSerializationContext(),
            new AddTargetResponseSerializationContext(),
            new ApplyToResourcesRequestSerializationContext(),
            new ApplyToResourcesResponseSerializationContext(),
            new ArchitectureSerializationContext(),
            new ArchitectureOptionalSerializationContext(),
            new AssignFloatingIpToServerRequestSerializationContext(),
            new AssignFloatingIpToServerResponseSerializationContext(),
            new AssignPrimaryIpToResourceRequestSerializationContext(),
            new AssignPrimaryIpToResourceResponseSerializationContext(),
            new AttachIsoToServerRequestSerializationContext(),
            new AttachIsoToServerResponseSerializationContext(),
            new AttachLoadBalancerToNetworkRequestSerializationContext(),
            new AttachLoadBalancerToNetworkResponseSerializationContext(),
            new AttachServerToNetworkRequestSerializationContext(),
            new AttachServerToNetworkResponseSerializationContext(),
            new AttachVolumeToServerRequestSerializationContext(),
            new AttachVolumeToServerResponseSerializationContext(),
            new CertificateSerializationContext(),
            new CertificateStatusSerializationContext(),
            new CertificateStatusErrorSerializationContext(),
            new ChangeAlgorithmResponseSerializationContext(),
            new ChangeAliasIpsOfNetworkRequestSerializationContext(),
            new ChangeAliasIpsOfNetworkResponseSerializationContext(),
            new ChangeFloatingIpProtectionResponseSerializationContext(),
            new ChangeImageProtectionRequestSerializationContext(),
            new ChangeImageProtectionResponseSerializationContext(),
            new ChangeIpRangeOfNetworkRequestSerializationContext(),
            new ChangeIpRangeOfNetworkResponseSerializationContext(),
            new ChangeLoadBalancerProtectionRequestSerializationContext(),
            new ChangeLoadBalancerProtectionResponseSerializationContext(),
            new ChangeNetworkProtectionRequestSerializationContext(),
            new ChangeNetworkProtectionResponseSerializationContext(),
            new ChangePrimaryIpProtectionResponseSerializationContext(),
            new ChangeReverseDnsEntryForThisLoadBalancerRequestSerializationContext(),
            new ChangeReverseDnsEntryForThisLoadBalancerResponseSerializationContext(),
            new ChangeReverseDnsEntryForThisServerRequestSerializationContext(),
            new ChangeReverseDnsEntryForThisServerResponseSerializationContext(),
            new ChangeReverseDnsRecordsForFloatingIpResponseSerializationContext(),
            new ChangeReverseDnsRecordsForPrimaryIpResponseSerializationContext(),
            new ChangeServerProtectionRequestSerializationContext(),
            new ChangeServerProtectionResponseSerializationContext(),
            new ChangeTypeOfLoadBalancerRequestSerializationContext(),
            new ChangeTypeOfLoadBalancerResponseSerializationContext(),
            new ChangeTypeOfServerRequestSerializationContext(),
            new ChangeTypeOfServerResponseSerializationContext(),
            new ChangeVolumeProtectionRequestSerializationContext(),
            new ChangeVolumeProtectionResponseSerializationContext(),
            new CreateCertificateRequestSerializationContext(),
            new CreateCertificateResponseSerializationContext(),
            new CreateFirewallRequestSerializationContext(),
            new CreateFirewallResponseSerializationContext(),
            new CreateFloatingIpRequestSerializationContext(),
            new CreateFloatingIpResponseSerializationContext(),
            new CreateImageFromServerRequestSerializationContext(),
            new CreateImageFromServerResponseSerializationContext(),
            new CreateLoadBalancerRequestSerializationContext(),
            new CreateLoadBalancerResponseSerializationContext(),
            new CreateNetworkRequestSerializationContext(),
            new CreateNetworkResponseSerializationContext(),
            new CreatePlacementgroupRequestSerializationContext(),
            new CreatePlacementgroupResponseSerializationContext(),
            new CreatePrimaryIpRequestSerializationContext(),
            new CreatePrimaryIpResponseSerializationContext(),
            new CreateServerRequestSerializationContext(),
            new CreateServerRequestFirewallsSerializationContext(),
            new CreateServerRequestPublicNetSerializationContext(),
            new CreateServerResponseSerializationContext(),
            new CreateSshKeyRequestSerializationContext(),
            new CreateSshKeyResponseSerializationContext(),
            new CreateVolumeRequestSerializationContext(),
            new CreateVolumeResponseSerializationContext(),
            new CreatedFromSerializationContext(),
            new DatacenterSerializationContext(),
            new DatacenterServerTypesSerializationContext(),
            new DeleteRouteFromNetworkResponseSerializationContext(),
            new DeleteServerResponseSerializationContext(),
            new DeleteServiceRequestSerializationContext(),
            new DeleteServiceResponseSerializationContext(),
            new DeleteSubnetFromNetworkRequestSerializationContext(),
            new DeleteSubnetFromNetworkResponseSerializationContext(),
            new DeprecationInfoSerializationContext(),
            new DetachIsoFromServerResponseSerializationContext(),
            new DetachLoadBalancerFromNetworkRequestSerializationContext(),
            new DetachLoadBalancerFromNetworkResponseSerializationContext(),
            new DetachServerFromNetworkRequestSerializationContext(),
            new DetachServerFromNetworkResponseSerializationContext(),
            new DetachVolumeResponseSerializationContext(),
            new DisableBackupsForServerResponseSerializationContext(),
            new DisablePublicInterfaceOfLoadBalancerResponseSerializationContext(),
            new DisableRescueModeForServerResponseSerializationContext(),
            new DnsPtrSerializationContext(),
            new EnableAndConfigureBackupsForServerResponseSerializationContext(),
            new EnablePublicInterfaceOfLoadBalancerResponseSerializationContext(),
            new EnableRescueModeForServerRequestSerializationContext(),
            new EnableRescueModeForServerResponseSerializationContext(),
            new ErrorSerializationContext(),
            new FirewallSerializationContext(),
            new FirewallResourceSerializationContext(),
            new FirewallResourceIdSerializationContext(),
            new FirewallResourceIdAppliedToResourcesSerializationContext(),
            new FloatingIpSerializationContext(),
            new GetActionForCertificateResponseSerializationContext(),
            new GetActionForFirewallResponseSerializationContext(),
            new GetActionForFloatingIpResponseSerializationContext(),
            new GetActionForImageResponseSerializationContext(),
            new GetActionForLoadBalancerResponseSerializationContext(),
            new GetActionForNetworkResponseSerializationContext(),
            new GetActionForServerResponseSerializationContext(),
            new GetActionForVolumeResponseSerializationContext(),
            new GetActionResponseSerializationContext(),
            new GetCertificateResponseSerializationContext(),
            new GetDatacenterResponseSerializationContext(),
            new GetFirewallResponseSerializationContext(),
            new GetFloatingIpResponseSerializationContext(),
            new GetImageResponseSerializationContext(),
            new GetIsoResponseSerializationContext(),
            new GetLoadBalancerResponseSerializationContext(),
            new GetLoadBalancerTypeResponseSerializationContext(),
            new GetLocationResponseSerializationContext(),
            new GetMetricsForLoadbalancerResponseSerializationContext(),
            new GetMetricsForServerResponseSerializationContext(),
            new GetNetworkResponseSerializationContext(),
            new GetPlacementgroupResponseSerializationContext(),
            new GetPrimaryIpResponseSerializationContext(),
            new GetServerResponseSerializationContext(),
            new GetServerTypeResponseSerializationContext(),
            new GetSshKeyResponseSerializationContext(),
            new GetVolumeResponseSerializationContext(),
            new HttpSerializationContext(),
            new ImageSerializationContext(),
            new ImageOptionalSerializationContext(),
            new IpTypeSerializationContext(),
            new Ipv4SerializationContext(),
            new Ipv6SerializationContext(),
            new IsoSerializationContext(),
            new IsoOptionalSerializationContext(),
            new LabelSelectorSerializationContext(),
            new ListActionsForCertificateResponseSerializationContext(),
            new ListActionsForFirewallResponseSerializationContext(),
            new ListActionsForFloatingIpResponseSerializationContext(),
            new ListActionsForImageResponseSerializationContext(),
            new ListActionsForLoadBalancerResponseSerializationContext(),
            new ListActionsForNetworkResponseSerializationContext(),
            new ListActionsForServerResponseSerializationContext(),
            new ListActionsForVolumeResponseSerializationContext(),
            new ListActionsResponseSerializationContext(),
            new ListCertificatesResponseSerializationContext(),
            new ListDatacentersResponseSerializationContext(),
            new ListFirewallsResponseSerializationContext(),
            new ListFloatingIpsResponseSerializationContext(),
            new ListImagesResponseSerializationContext(),
            new ListIsosResponseSerializationContext(),
            new ListLoadBalancerTypesResponseSerializationContext(),
            new ListLoadBalancersResponseSerializationContext(),
            new ListLocationsResponseSerializationContext(),
            new ListNetworksResponseSerializationContext(),
            new ListPlacementgroupsResponseSerializationContext(),
            new ListPricesResponseSerializationContext(),
            new ListPricesResponsePricingSerializationContext(),
            new ListPricesResponsePricingFloatingIpSerializationContext(),
            new ListPricesResponsePricingFloatingIpsSerializationContext(),
            new ListPricesResponsePricingImageSerializationContext(),
            new ListPricesResponsePricingLoadBalancerTypesSerializationContext(),
            new ListPricesResponsePricingPrimaryIpsSerializationContext(),
            new ListPricesResponsePricingServerBackupSerializationContext(),
            new ListPricesResponsePricingServerTypesSerializationContext(),
            new ListPricesResponsePricingVolumeSerializationContext(),
            new ListPrimaryIpsResponseSerializationContext(),
            new ListServerTypesResponseSerializationContext(),
            new ListServersResponseSerializationContext(),
            new ListSshKeysResponseSerializationContext(),
            new ListVolumesResponseSerializationContext(),
            new LoadBalancerSerializationContext(),
            new LoadBalancerAddTargetSerializationContext(),
            new LoadBalancerAlgorithmSerializationContext(),
            new LoadBalancerPrivateNetSerializationContext(),
            new LoadBalancerPublicNetSerializationContext(),
            new LoadBalancerPublicNetIpv4SerializationContext(),
            new LoadBalancerPublicNetIpv6SerializationContext(),
            new LoadBalancerSelectedTargetSerializationContext(),
            new LoadBalancerServiceSerializationContext(),
            new LoadBalancerServiceHealthCheckSerializationContext(),
            new LoadBalancerServiceHealthCheckHttpSerializationContext(),
            new LoadBalancerTargetSerializationContext(),
            new LoadBalancerTargetHealthStatusSerializationContext(),
            new LoadBalancerTargetIpSerializationContext(),
            new LoadBalancerTypeSerializationContext(),
            new LocationSerializationContext(),
            new MetaSerializationContext(),
            new MetricsSerializationContext(),
            new MetricsTimeSeriesValueSerializationContext(),
            new NetworkSerializationContext(),
            new PaginationSerializationContext(),
            new PlacementGroupSerializationContext(),
            new PlacementGroupNullableSerializationContext(),
            new PowerOffServerResponseSerializationContext(),
            new PowerOnServerResponseSerializationContext(),
            new PriceSerializationContext(),
            new PricePerTimeSerializationContext(),
            new PricePerTimeMonthlySerializationContext(),
            new PricePerTimeWithoutTrafficSerializationContext(),
            new PrimaryIPSerializationContext(),
            new ProtectionSerializationContext(),
            new RebuildServerFromImageRequestSerializationContext(),
            new RebuildServerFromImageResponseSerializationContext(),
            new RemoveFromPlacementGroupResponseSerializationContext(),
            new RemoveFromResourcesRequestSerializationContext(),
            new RemoveFromResourcesResponseSerializationContext(),
            new RemoveTargetRequestSerializationContext(),
            new RemoveTargetResponseSerializationContext(),
            new ReplaceCertificateRequestSerializationContext(),
            new ReplaceCertificateResponseSerializationContext(),
            new ReplaceFirewallRequestSerializationContext(),
            new ReplaceFirewallResponseSerializationContext(),
            new ReplaceFloatingIpRequestSerializationContext(),
            new ReplaceFloatingIpResponseSerializationContext(),
            new ReplaceImageRequestSerializationContext(),
            new ReplaceImageResponseSerializationContext(),
            new ReplaceLoadBalancerRequestSerializationContext(),
            new ReplaceLoadBalancerResponseSerializationContext(),
            new ReplaceNetworkRequestSerializationContext(),
            new ReplaceNetworkResponseSerializationContext(),
            new ReplacePlacementgroupRequestSerializationContext(),
            new ReplacePlacementgroupResponseSerializationContext(),
            new ReplacePrimaryIpRequestSerializationContext(),
            new ReplacePrimaryIpResponseSerializationContext(),
            new ReplaceServerRequestSerializationContext(),
            new ReplaceServerResponseSerializationContext(),
            new ReplaceSshKeyRequestSerializationContext(),
            new ReplaceSshKeyResponseSerializationContext(),
            new ReplaceVolumeRequestSerializationContext(),
            new ReplaceVolumeResponseSerializationContext(),
            new RequestConsoleForServerResponseSerializationContext(),
            new ResetRootPasswordOfServerResponseSerializationContext(),
            new ResetServerResponseSerializationContext(),
            new ResizeVolumeRequestSerializationContext(),
            new ResizeVolumeResponseSerializationContext(),
            new ResourceSerializationContext(),
            new ResourceIdSerializationContext(),
            new RetryIssuanceOrRenewalResponseSerializationContext(),
            new RouteSerializationContext(),
            new RuleSerializationContext(),
            new RuleResponseSerializationContext(),
            new ServerSerializationContext(),
            new ServerPrivateNetSerializationContext(),
            new ServerProtectionSerializationContext(),
            new ServerPublicNetSerializationContext(),
            new ServerPublicNetFirewallSerializationContext(),
            new ServerTypeSerializationContext(),
            new SetRulesRequestSerializationContext(),
            new SetRulesResponseSerializationContext(),
            new ShutdownServerResponseSerializationContext(),
            new SoftRebootServerResponseSerializationContext(),
            new SshKeySerializationContext(),
            new SubnetSerializationContext(),
            new SubnetWithGatewaySerializationContext(),
            new UnassignFloatingIpResponseSerializationContext(),
            new UnassignPrimaryIpFromResourceResponseSerializationContext(),
            new UpdateLoadBalancerServiceSerializationContext(),
            new UpdateLoadBalancerServiceHealthCheckSerializationContext(),
            new UpdateLoadBalancerServiceHealthCheckHttpSerializationContext(),
            new UpdateServiceResponseSerializationContext(),
            new VolumeSerializationContext(),
            new DefaultJsonTypeInfoResolver()
        );
    }
}