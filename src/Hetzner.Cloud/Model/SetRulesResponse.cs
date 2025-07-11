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
    /// Response to POST https://api.hetzner.cloud/v1/firewalls/{id}/actions/set_rules
    /// </summary>
    public partial class SetRulesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetRulesResponse" /> class.
        /// </summary>
        /// <param name="actions">actions</param>
        [JsonConstructor]
        public SetRulesResponse(List<Action> actions)
        {
            Actions = actions;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonPropertyName("actions")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetRulesResponse {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
    /// A Json converter for type <see cref="SetRulesResponse" />
    /// </summary>
    public class SetRulesResponseJsonConverter : JsonConverter<SetRulesResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="SetRulesResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SetRulesResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Action>?> actions = default;

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
                        case "actions":
                            actions = new Option<List<Action>?>(JsonSerializer.Deserialize<List<Action>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!actions.IsSet)
                throw new ArgumentException("Property is required for class SetRulesResponse.", nameof(actions));

            if (actions.IsSet && actions.Value == null)
                throw new ArgumentNullException(nameof(actions), "Property is not nullable for class SetRulesResponse.");

            return new SetRulesResponse(actions.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="SetRulesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="setRulesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SetRulesResponse setRulesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, setRulesResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SetRulesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="setRulesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SetRulesResponse setRulesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (setRulesResponse.Actions == null)
                throw new ArgumentNullException(nameof(setRulesResponse.Actions), "Property is required for class SetRulesResponse.");

            writer.WritePropertyName("actions");
            JsonSerializer.Serialize(writer, setRulesResponse.Actions, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The SetRulesResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(SetRulesResponse))]
    public partial class SetRulesResponseSerializationContext : JsonSerializerContext { }
}
