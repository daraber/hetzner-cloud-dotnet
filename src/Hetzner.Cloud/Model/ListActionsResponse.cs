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
    /// Response to GET https://api.hetzner.cloud/v1/{resource}/actions/{id}
    /// </summary>
    public partial class ListActionsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListActionsResponse" /> class.
        /// </summary>
        /// <param name="actions">actions</param>
        /// <param name="meta">meta</param>
        [JsonConstructor]
        public ListActionsResponse(List<Action> actions, Meta meta)
        {
            Actions = actions;
            Meta = meta;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonPropertyName("actions")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListActionsResponse {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
    /// A Json converter for type <see cref="ListActionsResponse" />
    /// </summary>
    public class ListActionsResponseJsonConverter : JsonConverter<ListActionsResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ListActionsResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ListActionsResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Action>?> actions = default;
            Option<Meta?> meta = default;

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
                        case "meta":
                            meta = new Option<Meta?>(JsonSerializer.Deserialize<Meta>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!actions.IsSet)
                throw new ArgumentException("Property is required for class ListActionsResponse.", nameof(actions));

            if (!meta.IsSet)
                throw new ArgumentException("Property is required for class ListActionsResponse.", nameof(meta));

            if (actions.IsSet && actions.Value == null)
                throw new ArgumentNullException(nameof(actions), "Property is not nullable for class ListActionsResponse.");

            if (meta.IsSet && meta.Value == null)
                throw new ArgumentNullException(nameof(meta), "Property is not nullable for class ListActionsResponse.");

            return new ListActionsResponse(actions.Value!, meta.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ListActionsResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listActionsResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ListActionsResponse listActionsResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, listActionsResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ListActionsResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listActionsResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ListActionsResponse listActionsResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (listActionsResponse.Actions == null)
                throw new ArgumentNullException(nameof(listActionsResponse.Actions), "Property is required for class ListActionsResponse.");

            if (listActionsResponse.Meta == null)
                throw new ArgumentNullException(nameof(listActionsResponse.Meta), "Property is required for class ListActionsResponse.");

            writer.WritePropertyName("actions");
            JsonSerializer.Serialize(writer, listActionsResponse.Actions, jsonSerializerOptions);
            writer.WritePropertyName("meta");
            JsonSerializer.Serialize(writer, listActionsResponse.Meta, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The ListActionsResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ListActionsResponse))]
    public partial class ListActionsResponseSerializationContext : JsonSerializerContext { }
}
