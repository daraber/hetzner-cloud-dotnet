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
    /// Request for POST https://api.hetzner.cloud/v1/load_balancers/{id}/actions/delete_service
    /// </summary>
    public partial class DeleteServiceRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceRequest" /> class.
        /// </summary>
        /// <param name="listenPort">The listen port of the service you want to delete</param>
        [JsonConstructor]
        public DeleteServiceRequest(int listenPort)
        {
            ListenPort = listenPort;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The listen port of the service you want to delete
        /// </summary>
        /// <value>The listen port of the service you want to delete</value>
        /* <example>443</example> */
        [JsonPropertyName("listen_port")]
        public int ListenPort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteServiceRequest {\n");
            sb.Append("  ListenPort: ").Append(ListenPort).Append("\n");
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
    /// A Json converter for type <see cref="DeleteServiceRequest" />
    /// </summary>
    public class DeleteServiceRequestJsonConverter : JsonConverter<DeleteServiceRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="DeleteServiceRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DeleteServiceRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> listenPort = default;

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
                        case "listen_port":
                            listenPort = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!listenPort.IsSet)
                throw new ArgumentException("Property is required for class DeleteServiceRequest.", nameof(listenPort));

            if (listenPort.IsSet && listenPort.Value == null)
                throw new ArgumentNullException(nameof(listenPort), "Property is not nullable for class DeleteServiceRequest.");

            return new DeleteServiceRequest(listenPort.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="DeleteServiceRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="deleteServiceRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DeleteServiceRequest deleteServiceRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, deleteServiceRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DeleteServiceRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="deleteServiceRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DeleteServiceRequest deleteServiceRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("listen_port", deleteServiceRequest.ListenPort);
        }
    }

    /// <summary>
    /// The DeleteServiceRequestSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(DeleteServiceRequest))]
    public partial class DeleteServiceRequestSerializationContext : JsonSerializerContext { }
}
