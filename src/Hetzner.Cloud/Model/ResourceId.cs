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
    /// ID of the Resource
    /// </summary>
    public partial class ResourceId : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceId" /> class.
        /// </summary>
        /// <param name="id">ID of the Server. | ID of the [Server](#servers). | ID of the Server</param>
        [JsonConstructor]
        public ResourceId(long id)
        {
            Id = id;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// ID of the Server. | ID of the [Server](#servers). | ID of the Server
        /// </summary>
        /// <value>ID of the Server. | ID of the [Server](#servers). | ID of the Server</value>
        /* <example>42</example> */
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceId {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
    /// A Json converter for type <see cref="ResourceId" />
    /// </summary>
    public class ResourceIdJsonConverter : JsonConverter<ResourceId>
    {
        /// <summary>
        /// Deserializes json to <see cref="ResourceId" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ResourceId Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;

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
                        case "id":
                            id = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class ResourceId.", nameof(id));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ResourceId.");

            return new ResourceId(id.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ResourceId" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="resourceId"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ResourceId resourceId, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, resourceId, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ResourceId" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="resourceId"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ResourceId resourceId, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("id", resourceId.Id);
        }
    }

    /// <summary>
    /// The ResourceIdSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ResourceId))]
    public partial class ResourceIdSerializationContext : JsonSerializerContext { }
}
