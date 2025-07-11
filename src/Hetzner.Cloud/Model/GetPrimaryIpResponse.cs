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
    /// Response to GET https://api.hetzner.cloud/v1/primary_ips/{id}
    /// </summary>
    public partial class GetPrimaryIpResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrimaryIpResponse" /> class.
        /// </summary>
        /// <param name="primaryIp">primaryIp</param>
        [JsonConstructor]
        public GetPrimaryIpResponse(PrimaryIP primaryIp)
        {
            PrimaryIp = primaryIp;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets PrimaryIp
        /// </summary>
        [JsonPropertyName("primary_ip")]
        public PrimaryIP PrimaryIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPrimaryIpResponse {\n");
            sb.Append("  PrimaryIp: ").Append(PrimaryIp).Append("\n");
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
    /// A Json converter for type <see cref="GetPrimaryIpResponse" />
    /// </summary>
    public class GetPrimaryIpResponseJsonConverter : JsonConverter<GetPrimaryIpResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetPrimaryIpResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetPrimaryIpResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PrimaryIP?> primaryIp = default;

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
                        case "primary_ip":
                            primaryIp = new Option<PrimaryIP?>(JsonSerializer.Deserialize<PrimaryIP>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!primaryIp.IsSet)
                throw new ArgumentException("Property is required for class GetPrimaryIpResponse.", nameof(primaryIp));

            if (primaryIp.IsSet && primaryIp.Value == null)
                throw new ArgumentNullException(nameof(primaryIp), "Property is not nullable for class GetPrimaryIpResponse.");

            return new GetPrimaryIpResponse(primaryIp.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetPrimaryIpResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getPrimaryIpResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetPrimaryIpResponse getPrimaryIpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getPrimaryIpResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetPrimaryIpResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getPrimaryIpResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetPrimaryIpResponse getPrimaryIpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getPrimaryIpResponse.PrimaryIp == null)
                throw new ArgumentNullException(nameof(getPrimaryIpResponse.PrimaryIp), "Property is required for class GetPrimaryIpResponse.");

            writer.WritePropertyName("primary_ip");
            JsonSerializer.Serialize(writer, getPrimaryIpResponse.PrimaryIp, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The GetPrimaryIpResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetPrimaryIpResponse))]
    public partial class GetPrimaryIpResponseSerializationContext : JsonSerializerContext { }
}
