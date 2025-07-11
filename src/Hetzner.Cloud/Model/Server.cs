// <auto-generated>
/*
 * Hetzner Cloud API
 *
 * Copied from the official API documentation for the Public Hetzner Cloud.
 *
 * The version of the OpenAPI document: 0.22.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization.Metadata;
using Hetzner.Cloud.Client;

namespace Hetzner.Cloud.Model
{
    /// <summary>
    /// Servers are virtual machines that can be provisioned.
    /// </summary>
    public partial class Server : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        /// <param name="created">Point in time when the Resource was created (in ISO-8601 format).</param>
        /// <param name="datacenter">datacenter</param>
        /// <param name="id">ID of the Server.</param>
        /// <param name="labels">User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;. </param>
        /// <param name="locked">True if Server has been locked and is not available to user</param>
        /// <param name="name">Name of the Server (must be unique per Project and a valid hostname as per RFC 1123)</param>
        /// <param name="primaryDiskSize">Size of the primary Disk</param>
        /// <param name="privateNet">Private networks information</param>
        /// <param name="protection">protection</param>
        /// <param name="publicNet">publicNet</param>
        /// <param name="rescueEnabled">True if rescue mode is enabled. Server will then boot into rescue system on next reboot</param>
        /// <param name="serverType">serverType</param>
        /// <param name="status">Status of the Server</param>
        /// <param name="backupWindow">Time window (UTC) in which the backup will run, or null if the backups are not enabled</param>
        /// <param name="image">image</param>
        /// <param name="includedTraffic">Free Traffic for the current billing period in bytes</param>
        /// <param name="ingoingTraffic">Inbound Traffic for the current billing period in bytes</param>
        /// <param name="iso">iso</param>
        /// <param name="loadBalancers">Load Balancer IDs assigned to the server.</param>
        /// <param name="outgoingTraffic">Outbound Traffic for the current billing period in bytes</param>
        /// <param name="placementGroup">placementGroup</param>
        /// <param name="volumes">IDs of Volumes assigned to this Server</param>
        [JsonConstructor]
        public Server(string created, Datacenter datacenter, long id, Dictionary<string, string> labels, bool locked, string name, int primaryDiskSize, List<ServerPrivateNet> privateNet, ServerProtection protection, ServerPublicNet publicNet, bool rescueEnabled, ServerType serverType, StatusEnum status, string? backupWindow = default, ImageOptional? image = default, long? includedTraffic = default, long? ingoingTraffic = default, IsoOptional? iso = default, Option<List<long>?> loadBalancers = default, long? outgoingTraffic = default, Option<PlacementGroupNullable?> placementGroup = default, Option<List<long>?> volumes = default)
        {
            Created = created;
            Datacenter = datacenter;
            Id = id;
            Labels = labels;
            Locked = locked;
            Name = name;
            PrimaryDiskSize = primaryDiskSize;
            PrivateNet = privateNet;
            Protection = protection;
            PublicNet = publicNet;
            RescueEnabled = rescueEnabled;
            ServerType = serverType;
            Status = status;
            BackupWindow = backupWindow;
            Image = image;
            IncludedTraffic = includedTraffic;
            IngoingTraffic = ingoingTraffic;
            Iso = iso;
            LoadBalancersOption = loadBalancers;
            OutgoingTraffic = outgoingTraffic;
            PlacementGroupOption = placementGroup;
            VolumesOption = volumes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Status of the Server
        /// </summary>
        /// <value>Status of the Server</value>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Deleting for value: deleting
            /// </summary>
            Deleting = 1,

            /// <summary>
            /// Enum Initializing for value: initializing
            /// </summary>
            Initializing = 2,

            /// <summary>
            /// Enum Migrating for value: migrating
            /// </summary>
            Migrating = 3,

            /// <summary>
            /// Enum Off for value: off
            /// </summary>
            Off = 4,

            /// <summary>
            /// Enum Rebuilding for value: rebuilding
            /// </summary>
            Rebuilding = 5,

            /// <summary>
            /// Enum Running for value: running
            /// </summary>
            Running = 6,

            /// <summary>
            /// Enum Starting for value: starting
            /// </summary>
            Starting = 7,

            /// <summary>
            /// Enum Stopping for value: stopping
            /// </summary>
            Stopping = 8,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            Unknown = 9
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("deleting"))
                return StatusEnum.Deleting;

            if (value.Equals("initializing"))
                return StatusEnum.Initializing;

            if (value.Equals("migrating"))
                return StatusEnum.Migrating;

            if (value.Equals("off"))
                return StatusEnum.Off;

            if (value.Equals("rebuilding"))
                return StatusEnum.Rebuilding;

            if (value.Equals("running"))
                return StatusEnum.Running;

            if (value.Equals("starting"))
                return StatusEnum.Starting;

            if (value.Equals("stopping"))
                return StatusEnum.Stopping;

            if (value.Equals("unknown"))
                return StatusEnum.Unknown;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("deleting"))
                return StatusEnum.Deleting;

            if (value.Equals("initializing"))
                return StatusEnum.Initializing;

            if (value.Equals("migrating"))
                return StatusEnum.Migrating;

            if (value.Equals("off"))
                return StatusEnum.Off;

            if (value.Equals("rebuilding"))
                return StatusEnum.Rebuilding;

            if (value.Equals("running"))
                return StatusEnum.Running;

            if (value.Equals("starting"))
                return StatusEnum.Starting;

            if (value.Equals("stopping"))
                return StatusEnum.Stopping;

            if (value.Equals("unknown"))
                return StatusEnum.Unknown;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Deleting)
                return "deleting";

            if (value == StatusEnum.Initializing)
                return "initializing";

            if (value == StatusEnum.Migrating)
                return "migrating";

            if (value == StatusEnum.Off)
                return "off";

            if (value == StatusEnum.Rebuilding)
                return "rebuilding";

            if (value == StatusEnum.Running)
                return "running";

            if (value == StatusEnum.Starting)
                return "starting";

            if (value == StatusEnum.Stopping)
                return "stopping";

            if (value == StatusEnum.Unknown)
                return "unknown";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Status of the Server
        /// </summary>
        /// <value>Status of the Server</value>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Point in time when the Resource was created (in ISO-8601 format).
        /// </summary>
        /// <value>Point in time when the Resource was created (in ISO-8601 format).</value>
        /* <example>2016-01-30T23:55:00+00:00</example> */
        [JsonPropertyName("created")]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Datacenter
        /// </summary>
        [JsonPropertyName("datacenter")]
        public Datacenter Datacenter { get; set; }

        /// <summary>
        /// ID of the Server.
        /// </summary>
        /// <value>ID of the Server.</value>
        /* <example>42</example> */
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;. 
        /// </summary>
        /// <value>User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;. </value>
        /* <example>{&quot;environment&quot;:&quot;prod&quot;,&quot;example.com/my&quot;:&quot;label&quot;,&quot;just-a-key&quot;:&quot;&quot;}</example> */
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// True if Server has been locked and is not available to user
        /// </summary>
        /// <value>True if Server has been locked and is not available to user</value>
        /* <example>false</example> */
        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Name of the Server (must be unique per Project and a valid hostname as per RFC 1123)
        /// </summary>
        /// <value>Name of the Server (must be unique per Project and a valid hostname as per RFC 1123)</value>
        /* <example>my-resource</example> */
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Size of the primary Disk
        /// </summary>
        /// <value>Size of the primary Disk</value>
        /* <example>50</example> */
        [JsonPropertyName("primary_disk_size")]
        public int PrimaryDiskSize { get; set; }

        /// <summary>
        /// Private networks information
        /// </summary>
        /// <value>Private networks information</value>
        [JsonPropertyName("private_net")]
        public List<ServerPrivateNet> PrivateNet { get; set; }

        /// <summary>
        /// Gets or Sets Protection
        /// </summary>
        [JsonPropertyName("protection")]
        public ServerProtection Protection { get; set; }

        /// <summary>
        /// Gets or Sets PublicNet
        /// </summary>
        [JsonPropertyName("public_net")]
        public ServerPublicNet PublicNet { get; set; }

        /// <summary>
        /// True if rescue mode is enabled. Server will then boot into rescue system on next reboot
        /// </summary>
        /// <value>True if rescue mode is enabled. Server will then boot into rescue system on next reboot</value>
        /* <example>false</example> */
        [JsonPropertyName("rescue_enabled")]
        public bool RescueEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ServerType
        /// </summary>
        [JsonPropertyName("server_type")]
        public ServerType ServerType { get; set; }

        /// <summary>
        /// Time window (UTC) in which the backup will run, or null if the backups are not enabled
        /// </summary>
        /// <value>Time window (UTC) in which the backup will run, or null if the backups are not enabled</value>
        /* <example>22-02</example> */
        [JsonPropertyName("backup_window")]
        public string? BackupWindow { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [JsonPropertyName("image")]
        public ImageOptional? Image { get; set; }

        /// <summary>
        /// Free Traffic for the current billing period in bytes
        /// </summary>
        /// <value>Free Traffic for the current billing period in bytes</value>
        /* <example>654321</example> */
        [JsonPropertyName("included_traffic")]
        public long? IncludedTraffic { get; set; }

        /// <summary>
        /// Inbound Traffic for the current billing period in bytes
        /// </summary>
        /// <value>Inbound Traffic for the current billing period in bytes</value>
        /* <example>123456</example> */
        [JsonPropertyName("ingoing_traffic")]
        public long? IngoingTraffic { get; set; }

        /// <summary>
        /// Gets or Sets Iso
        /// </summary>
        [JsonPropertyName("iso")]
        public IsoOptional? Iso { get; set; }

        /// <summary>
        /// Used to track the state of LoadBalancers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<long>?> LoadBalancersOption { get; private set; }

        /// <summary>
        /// Load Balancer IDs assigned to the server.
        /// </summary>
        /// <value>Load Balancer IDs assigned to the server.</value>
        [JsonPropertyName("load_balancers")]
        public List<long>? LoadBalancers { get { return this.LoadBalancersOption; } set { this.LoadBalancersOption = new(value); } }

        /// <summary>
        /// Outbound Traffic for the current billing period in bytes
        /// </summary>
        /// <value>Outbound Traffic for the current billing period in bytes</value>
        /* <example>123456</example> */
        [JsonPropertyName("outgoing_traffic")]
        public long? OutgoingTraffic { get; set; }

        /// <summary>
        /// Used to track the state of PlacementGroup
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlacementGroupNullable?> PlacementGroupOption { get; private set; }

        /// <summary>
        /// Gets or Sets PlacementGroup
        /// </summary>
        [JsonPropertyName("placement_group")]
        public PlacementGroupNullable? PlacementGroup { get { return this.PlacementGroupOption; } set { this.PlacementGroupOption = new(value); } }

        /// <summary>
        /// Used to track the state of Volumes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<long>?> VolumesOption { get; private set; }

        /// <summary>
        /// IDs of Volumes assigned to this Server
        /// </summary>
        /// <value>IDs of Volumes assigned to this Server</value>
        [JsonPropertyName("volumes")]
        public List<long>? Volumes { get { return this.VolumesOption; } set { this.VolumesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Server {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Datacenter: ").Append(Datacenter).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryDiskSize: ").Append(PrimaryDiskSize).Append("\n");
            sb.Append("  PrivateNet: ").Append(PrivateNet).Append("\n");
            sb.Append("  Protection: ").Append(Protection).Append("\n");
            sb.Append("  PublicNet: ").Append(PublicNet).Append("\n");
            sb.Append("  RescueEnabled: ").Append(RescueEnabled).Append("\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BackupWindow: ").Append(BackupWindow).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  IncludedTraffic: ").Append(IncludedTraffic).Append("\n");
            sb.Append("  IngoingTraffic: ").Append(IngoingTraffic).Append("\n");
            sb.Append("  Iso: ").Append(Iso).Append("\n");
            sb.Append("  LoadBalancers: ").Append(LoadBalancers).Append("\n");
            sb.Append("  OutgoingTraffic: ").Append(OutgoingTraffic).Append("\n");
            sb.Append("  PlacementGroup: ").Append(PlacementGroup).Append("\n");
            sb.Append("  Volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Id (long) maximum
            if (this.Id > (long)9007199254740991)
            {
                yield return new ValidationResult("Invalid value for Id, must be a value less than or equal to 9007199254740991.", new [] { "Id" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Server" />
    /// </summary>
    public class ServerJsonConverter : JsonConverter<Server>
    {
        /// <summary>
        /// Deserializes json to <see cref="Server" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Server Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> created = default;
            Option<Datacenter?> datacenter = default;
            Option<long?> id = default;
            Option<Dictionary<string, string>?> labels = default;
            Option<bool?> locked = default;
            Option<string?> name = default;
            Option<int?> primaryDiskSize = default;
            Option<List<ServerPrivateNet>?> privateNet = default;
            Option<ServerProtection?> protection = default;
            Option<ServerPublicNet?> publicNet = default;
            Option<bool?> rescueEnabled = default;
            Option<ServerType?> serverType = default;
            Option<Server.StatusEnum?> status = default;
            Option<string?> backupWindow = default;
            Option<ImageOptional?> image = default;
            Option<long?> includedTraffic = default;
            Option<long?> ingoingTraffic = default;
            Option<IsoOptional?> iso = default;
            Option<List<long>?> loadBalancers = default;
            Option<long?> outgoingTraffic = default;
            Option<PlacementGroupNullable?> placementGroup = default;
            Option<List<long>?> volumes = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "created":
                            created = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "datacenter":
                            datacenter = new Option<Datacenter?>(JsonSerializer.Deserialize<Datacenter>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "labels":
                            labels = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "locked":
                            locked = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "primary_disk_size":
                            primaryDiskSize = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "private_net":
                            privateNet = new Option<List<ServerPrivateNet>?>(JsonSerializer.Deserialize<List<ServerPrivateNet>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "protection":
                            protection = new Option<ServerProtection?>(JsonSerializer.Deserialize<ServerProtection>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "public_net":
                            publicNet = new Option<ServerPublicNet?>(JsonSerializer.Deserialize<ServerPublicNet>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "rescue_enabled":
                            rescueEnabled = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "server_type":
                            serverType = new Option<ServerType?>(JsonSerializer.Deserialize<ServerType>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<Server.StatusEnum?>(Server.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "backup_window":
                            backupWindow = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "image":
                            image = new Option<ImageOptional?>(JsonSerializer.Deserialize<ImageOptional>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "included_traffic":
                            includedTraffic = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "ingoing_traffic":
                            ingoingTraffic = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "iso":
                            iso = new Option<IsoOptional?>(JsonSerializer.Deserialize<IsoOptional>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "load_balancers":
                            loadBalancers = new Option<List<long>?>(JsonSerializer.Deserialize<List<long>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "outgoing_traffic":
                            outgoingTraffic = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "placement_group":
                            placementGroup = new Option<PlacementGroupNullable?>(JsonSerializer.Deserialize<PlacementGroupNullable>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "volumes":
                            volumes = new Option<List<long>?>(JsonSerializer.Deserialize<List<long>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!created.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(created));

            if (!datacenter.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(datacenter));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(id));

            if (!labels.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(labels));

            if (!locked.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(locked));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(name));

            if (!primaryDiskSize.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(primaryDiskSize));

            if (!privateNet.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(privateNet));

            if (!protection.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(protection));

            if (!publicNet.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(publicNet));

            if (!rescueEnabled.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(rescueEnabled));

            if (!serverType.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(serverType));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(status));

            if (!backupWindow.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(backupWindow));

            if (!image.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(image));

            if (!includedTraffic.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(includedTraffic));

            if (!ingoingTraffic.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(ingoingTraffic));

            if (!iso.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(iso));

            if (!outgoingTraffic.IsSet)
                throw new ArgumentException("Property is required for class Server.", nameof(outgoingTraffic));

            if (created.IsSet && created.Value == null)
                throw new ArgumentNullException(nameof(created), "Property is not nullable for class Server.");

            if (datacenter.IsSet && datacenter.Value == null)
                throw new ArgumentNullException(nameof(datacenter), "Property is not nullable for class Server.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Server.");

            if (labels.IsSet && labels.Value == null)
                throw new ArgumentNullException(nameof(labels), "Property is not nullable for class Server.");

            if (locked.IsSet && locked.Value == null)
                throw new ArgumentNullException(nameof(locked), "Property is not nullable for class Server.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Server.");

            if (primaryDiskSize.IsSet && primaryDiskSize.Value == null)
                throw new ArgumentNullException(nameof(primaryDiskSize), "Property is not nullable for class Server.");

            if (privateNet.IsSet && privateNet.Value == null)
                throw new ArgumentNullException(nameof(privateNet), "Property is not nullable for class Server.");

            if (protection.IsSet && protection.Value == null)
                throw new ArgumentNullException(nameof(protection), "Property is not nullable for class Server.");

            if (publicNet.IsSet && publicNet.Value == null)
                throw new ArgumentNullException(nameof(publicNet), "Property is not nullable for class Server.");

            if (rescueEnabled.IsSet && rescueEnabled.Value == null)
                throw new ArgumentNullException(nameof(rescueEnabled), "Property is not nullable for class Server.");

            if (serverType.IsSet && serverType.Value == null)
                throw new ArgumentNullException(nameof(serverType), "Property is not nullable for class Server.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class Server.");

            if (loadBalancers.IsSet && loadBalancers.Value == null)
                throw new ArgumentNullException(nameof(loadBalancers), "Property is not nullable for class Server.");

            if (volumes.IsSet && volumes.Value == null)
                throw new ArgumentNullException(nameof(volumes), "Property is not nullable for class Server.");

            return new Server(created.Value!, datacenter.Value!, id.Value!.Value!, labels.Value!, locked.Value!.Value!, name.Value!, primaryDiskSize.Value!.Value!, privateNet.Value!, protection.Value!, publicNet.Value!, rescueEnabled.Value!.Value!, serverType.Value!, status.Value!.Value!, backupWindow.Value!, image.Value!, includedTraffic.Value!, ingoingTraffic.Value!, iso.Value!, loadBalancers, outgoingTraffic.Value!, placementGroup, volumes);
        }

        /// <summary>
        /// Serializes a <see cref="Server" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="server"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Server server, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, server, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Server" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="server"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Server server, JsonSerializerOptions jsonSerializerOptions)
        {
            if (server.Created == null)
                throw new ArgumentNullException(nameof(server.Created), "Property is required for class Server.");

            if (server.Datacenter == null)
                throw new ArgumentNullException(nameof(server.Datacenter), "Property is required for class Server.");

            if (server.Labels == null)
                throw new ArgumentNullException(nameof(server.Labels), "Property is required for class Server.");

            if (server.Name == null)
                throw new ArgumentNullException(nameof(server.Name), "Property is required for class Server.");

            if (server.PrivateNet == null)
                throw new ArgumentNullException(nameof(server.PrivateNet), "Property is required for class Server.");

            if (server.Protection == null)
                throw new ArgumentNullException(nameof(server.Protection), "Property is required for class Server.");

            if (server.PublicNet == null)
                throw new ArgumentNullException(nameof(server.PublicNet), "Property is required for class Server.");

            if (server.ServerType == null)
                throw new ArgumentNullException(nameof(server.ServerType), "Property is required for class Server.");

            if (server.LoadBalancersOption.IsSet && server.LoadBalancers == null)
                throw new ArgumentNullException(nameof(server.LoadBalancers), "Property is required for class Server.");

            if (server.VolumesOption.IsSet && server.Volumes == null)
                throw new ArgumentNullException(nameof(server.Volumes), "Property is required for class Server.");

            writer.WriteString("created", server.Created);

            writer.WritePropertyName("datacenter");
            JsonSerializer.Serialize(writer, server.Datacenter, jsonSerializerOptions);
            writer.WriteNumber("id", server.Id);

            writer.WritePropertyName("labels");
            JsonSerializer.Serialize(writer, server.Labels, jsonSerializerOptions);
            writer.WriteBoolean("locked", server.Locked);

            writer.WriteString("name", server.Name);

            writer.WriteNumber("primary_disk_size", server.PrimaryDiskSize);

            writer.WritePropertyName("private_net");
            JsonSerializer.Serialize(writer, server.PrivateNet, jsonSerializerOptions);
            writer.WritePropertyName("protection");
            JsonSerializer.Serialize(writer, server.Protection, jsonSerializerOptions);
            writer.WritePropertyName("public_net");
            JsonSerializer.Serialize(writer, server.PublicNet, jsonSerializerOptions);
            writer.WriteBoolean("rescue_enabled", server.RescueEnabled);

            writer.WritePropertyName("server_type");
            JsonSerializer.Serialize(writer, server.ServerType, jsonSerializerOptions);
            var statusRawValue = Server.StatusEnumToJsonValue(server.Status);
            writer.WriteString("status", statusRawValue);
            if (server.BackupWindow != null)
                writer.WriteString("backup_window", server.BackupWindow);
            else
                writer.WriteNull("backup_window");

            if (server.Image != null)
            {
                writer.WritePropertyName("image");
                JsonSerializer.Serialize(writer, server.Image, jsonSerializerOptions);
            }
            else
                writer.WriteNull("image");
            if (server.IncludedTraffic != null)
                writer.WriteNumber("included_traffic", server.IncludedTraffic.Value);
            else
                writer.WriteNull("included_traffic");

            if (server.IngoingTraffic != null)
                writer.WriteNumber("ingoing_traffic", server.IngoingTraffic.Value);
            else
                writer.WriteNull("ingoing_traffic");

            if (server.Iso != null)
            {
                writer.WritePropertyName("iso");
                JsonSerializer.Serialize(writer, server.Iso, jsonSerializerOptions);
            }
            else
                writer.WriteNull("iso");
            if (server.LoadBalancersOption.IsSet)
            {
                writer.WritePropertyName("load_balancers");
                JsonSerializer.Serialize(writer, server.LoadBalancers, jsonSerializerOptions);
            }
            if (server.OutgoingTraffic != null)
                writer.WriteNumber("outgoing_traffic", server.OutgoingTraffic.Value);
            else
                writer.WriteNull("outgoing_traffic");

            if (server.PlacementGroupOption.IsSet)
                if (server.PlacementGroupOption.Value != null)
                {
                    writer.WritePropertyName("placement_group");
                    JsonSerializer.Serialize(writer, server.PlacementGroup, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("placement_group");
            if (server.VolumesOption.IsSet)
            {
                writer.WritePropertyName("volumes");
                JsonSerializer.Serialize(writer, server.Volumes, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The ServerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Server))]
    public partial class ServerSerializationContext : JsonSerializerContext { }
}
