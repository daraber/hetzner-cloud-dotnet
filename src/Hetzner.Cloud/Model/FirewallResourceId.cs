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
    /// Resource a Firewall should be applied to.
    /// </summary>
    public partial class FirewallResourceId : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallResourceId" /> class.
        /// </summary>
        /// <param name="type">The type of resource to apply.</param>
        /// <param name="appliedToResources">Resources applied to via this [Label Selector](#label-selector). </param>
        /// <param name="labelSelector">labelSelector</param>
        /// <param name="server">server</param>
        [JsonConstructor]
        public FirewallResourceId(TypeEnum type, Option<List<FirewallResourceIdAppliedToResources>?> appliedToResources = default, Option<LabelSelector?> labelSelector = default, Option<ResourceId?> server = default)
        {
            Type = type;
            AppliedToResourcesOption = appliedToResources;
            LabelSelectorOption = labelSelector;
            ServerOption = server;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The type of resource to apply.
        /// </summary>
        /// <value>The type of resource to apply.</value>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum LabelSelector for value: label_selector
            /// </summary>
            LabelSelector = 1,

            /// <summary>
            /// Enum Server for value: server
            /// </summary>
            Server = 2
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("label_selector"))
                return TypeEnum.LabelSelector;

            if (value.Equals("server"))
                return TypeEnum.Server;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("label_selector"))
                return TypeEnum.LabelSelector;

            if (value.Equals("server"))
                return TypeEnum.Server;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.LabelSelector)
                return "label_selector";

            if (value == TypeEnum.Server)
                return "server";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// The type of resource to apply.
        /// </summary>
        /// <value>The type of resource to apply.</value>
        /* <example>server</example> */
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Used to track the state of AppliedToResources
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<FirewallResourceIdAppliedToResources>?> AppliedToResourcesOption { get; private set; }

        /// <summary>
        /// Resources applied to via this [Label Selector](#label-selector). 
        /// </summary>
        /// <value>Resources applied to via this [Label Selector](#label-selector). </value>
        [JsonPropertyName("applied_to_resources")]
        public List<FirewallResourceIdAppliedToResources>? AppliedToResources { get { return this.AppliedToResourcesOption; } set { this.AppliedToResourcesOption = new(value); } }

        /// <summary>
        /// Used to track the state of LabelSelector
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<LabelSelector?> LabelSelectorOption { get; private set; }

        /// <summary>
        /// Gets or Sets LabelSelector
        /// </summary>
        [JsonPropertyName("label_selector")]
        public LabelSelector? LabelSelector { get { return this.LabelSelectorOption; } set { this.LabelSelectorOption = new(value); } }

        /// <summary>
        /// Used to track the state of Server
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ResourceId?> ServerOption { get; private set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [JsonPropertyName("server")]
        public ResourceId? Server { get { return this.ServerOption; } set { this.ServerOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirewallResourceId {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AppliedToResources: ").Append(AppliedToResources).Append("\n");
            sb.Append("  LabelSelector: ").Append(LabelSelector).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FirewallResourceId" />
    /// </summary>
    public class FirewallResourceIdJsonConverter : JsonConverter<FirewallResourceId>
    {
        /// <summary>
        /// Deserializes json to <see cref="FirewallResourceId" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FirewallResourceId Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<FirewallResourceId.TypeEnum?> type = default;
            Option<List<FirewallResourceIdAppliedToResources>?> appliedToResources = default;
            Option<LabelSelector?> labelSelector = default;
            Option<ResourceId?> server = default;

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
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<FirewallResourceId.TypeEnum?>(FirewallResourceId.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "applied_to_resources":
                            appliedToResources = new Option<List<FirewallResourceIdAppliedToResources>?>(JsonSerializer.Deserialize<List<FirewallResourceIdAppliedToResources>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "label_selector":
                            labelSelector = new Option<LabelSelector?>(JsonSerializer.Deserialize<LabelSelector>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "server":
                            server = new Option<ResourceId?>(JsonSerializer.Deserialize<ResourceId>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class FirewallResourceId.", nameof(type));

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class FirewallResourceId.");

            if (appliedToResources.IsSet && appliedToResources.Value == null)
                throw new ArgumentNullException(nameof(appliedToResources), "Property is not nullable for class FirewallResourceId.");

            if (labelSelector.IsSet && labelSelector.Value == null)
                throw new ArgumentNullException(nameof(labelSelector), "Property is not nullable for class FirewallResourceId.");

            if (server.IsSet && server.Value == null)
                throw new ArgumentNullException(nameof(server), "Property is not nullable for class FirewallResourceId.");

            return new FirewallResourceId(type.Value!.Value!, appliedToResources, labelSelector, server);
        }

        /// <summary>
        /// Serializes a <see cref="FirewallResourceId" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="firewallResourceId"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FirewallResourceId firewallResourceId, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, firewallResourceId, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FirewallResourceId" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="firewallResourceId"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FirewallResourceId firewallResourceId, JsonSerializerOptions jsonSerializerOptions)
        {
            if (firewallResourceId.AppliedToResourcesOption.IsSet && firewallResourceId.AppliedToResources == null)
                throw new ArgumentNullException(nameof(firewallResourceId.AppliedToResources), "Property is required for class FirewallResourceId.");

            if (firewallResourceId.LabelSelectorOption.IsSet && firewallResourceId.LabelSelector == null)
                throw new ArgumentNullException(nameof(firewallResourceId.LabelSelector), "Property is required for class FirewallResourceId.");

            if (firewallResourceId.ServerOption.IsSet && firewallResourceId.Server == null)
                throw new ArgumentNullException(nameof(firewallResourceId.Server), "Property is required for class FirewallResourceId.");

            var typeRawValue = FirewallResourceId.TypeEnumToJsonValue(firewallResourceId.Type);
            writer.WriteString("type", typeRawValue);
            if (firewallResourceId.AppliedToResourcesOption.IsSet)
            {
                writer.WritePropertyName("applied_to_resources");
                JsonSerializer.Serialize(writer, firewallResourceId.AppliedToResources, jsonSerializerOptions);
            }
            if (firewallResourceId.LabelSelectorOption.IsSet)
            {
                writer.WritePropertyName("label_selector");
                JsonSerializer.Serialize(writer, firewallResourceId.LabelSelector, jsonSerializerOptions);
            }
            if (firewallResourceId.ServerOption.IsSet)
            {
                writer.WritePropertyName("server");
                JsonSerializer.Serialize(writer, firewallResourceId.Server, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The FirewallResourceIdSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(FirewallResourceId))]
    public partial class FirewallResourceIdSerializationContext : JsonSerializerContext { }
}
