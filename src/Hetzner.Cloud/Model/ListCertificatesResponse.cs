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
    /// Response to GET https://api.hetzner.cloud/v1/certificates
    /// </summary>
    public partial class ListCertificatesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCertificatesResponse" /> class.
        /// </summary>
        /// <param name="certificates">certificates</param>
        /// <param name="meta">meta</param>
        [JsonConstructor]
        public ListCertificatesResponse(List<Certificate> certificates, Meta meta)
        {
            Certificates = certificates;
            Meta = meta;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Certificates
        /// </summary>
        [JsonPropertyName("certificates")]
        public List<Certificate> Certificates { get; set; }

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
            sb.Append("class ListCertificatesResponse {\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
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
    /// A Json converter for type <see cref="ListCertificatesResponse" />
    /// </summary>
    public class ListCertificatesResponseJsonConverter : JsonConverter<ListCertificatesResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ListCertificatesResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ListCertificatesResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Certificate>?> certificates = default;
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
                        case "certificates":
                            certificates = new Option<List<Certificate>?>(JsonSerializer.Deserialize<List<Certificate>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "meta":
                            meta = new Option<Meta?>(JsonSerializer.Deserialize<Meta>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!certificates.IsSet)
                throw new ArgumentException("Property is required for class ListCertificatesResponse.", nameof(certificates));

            if (!meta.IsSet)
                throw new ArgumentException("Property is required for class ListCertificatesResponse.", nameof(meta));

            if (certificates.IsSet && certificates.Value == null)
                throw new ArgumentNullException(nameof(certificates), "Property is not nullable for class ListCertificatesResponse.");

            if (meta.IsSet && meta.Value == null)
                throw new ArgumentNullException(nameof(meta), "Property is not nullable for class ListCertificatesResponse.");

            return new ListCertificatesResponse(certificates.Value!, meta.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ListCertificatesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listCertificatesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ListCertificatesResponse listCertificatesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, listCertificatesResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ListCertificatesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listCertificatesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ListCertificatesResponse listCertificatesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (listCertificatesResponse.Certificates == null)
                throw new ArgumentNullException(nameof(listCertificatesResponse.Certificates), "Property is required for class ListCertificatesResponse.");

            if (listCertificatesResponse.Meta == null)
                throw new ArgumentNullException(nameof(listCertificatesResponse.Meta), "Property is required for class ListCertificatesResponse.");

            writer.WritePropertyName("certificates");
            JsonSerializer.Serialize(writer, listCertificatesResponse.Certificates, jsonSerializerOptions);
            writer.WritePropertyName("meta");
            JsonSerializer.Serialize(writer, listCertificatesResponse.Meta, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The ListCertificatesResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ListCertificatesResponse))]
    public partial class ListCertificatesResponseSerializationContext : JsonSerializerContext { }
}
