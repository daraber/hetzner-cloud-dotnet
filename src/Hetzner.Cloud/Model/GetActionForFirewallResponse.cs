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
    /// Response to GET https://api.hetzner.cloud/v1/firewalls/{id}/actions/{action_id}
    /// </summary>
    public partial class GetActionForFirewallResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetActionForFirewallResponse" /> class.
        /// </summary>
        /// <param name="action">action</param>
        [JsonConstructor]
        public GetActionForFirewallResponse(Action action)
        {
            Action = action;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [JsonPropertyName("action")]
        public Action Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetActionForFirewallResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
    /// A Json converter for type <see cref="GetActionForFirewallResponse" />
    /// </summary>
    public class GetActionForFirewallResponseJsonConverter : JsonConverter<GetActionForFirewallResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetActionForFirewallResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetActionForFirewallResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Action?> action = default;

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
                        case "action":
                            action = new Option<Action?>(JsonSerializer.Deserialize<Action>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!action.IsSet)
                throw new ArgumentException("Property is required for class GetActionForFirewallResponse.", nameof(action));

            if (action.IsSet && action.Value == null)
                throw new ArgumentNullException(nameof(action), "Property is not nullable for class GetActionForFirewallResponse.");

            return new GetActionForFirewallResponse(action.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetActionForFirewallResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getActionForFirewallResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetActionForFirewallResponse getActionForFirewallResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getActionForFirewallResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetActionForFirewallResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getActionForFirewallResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetActionForFirewallResponse getActionForFirewallResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getActionForFirewallResponse.Action == null)
                throw new ArgumentNullException(nameof(getActionForFirewallResponse.Action), "Property is required for class GetActionForFirewallResponse.");

            writer.WritePropertyName("action");
            JsonSerializer.Serialize(writer, getActionForFirewallResponse.Action, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The GetActionForFirewallResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetActionForFirewallResponse))]
    public partial class GetActionForFirewallResponseSerializationContext : JsonSerializerContext { }
}
