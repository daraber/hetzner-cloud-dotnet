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
    /// Request for POST https://api.hetzner.cloud/v1/certificates
    /// </summary>
    public partial class CreateCertificateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCertificateRequest" /> class.
        /// </summary>
        /// <param name="name">Name of the Certificate</param>
        /// <param name="certificate">Certificate and chain in PEM format, in order so that each record directly certifies the one preceding. Required for type &#x60;uploaded&#x60; Certificates.</param>
        /// <param name="domainNames">Domains and subdomains that should be contained in the Certificate issued by *Let&#39;s Encrypt*. Required for type &#x60;managed&#x60; Certificates.</param>
        /// <param name="labels">User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;. </param>
        /// <param name="privateKey">Certificate key in PEM format. Required for type &#x60;uploaded&#x60; Certificates.</param>
        /// <param name="type">Choose between uploading a Certificate in PEM format or requesting a managed *Let&#39;s Encrypt* Certificate. (default to TypeEnum.Uploaded)</param>
        [JsonConstructor]
        public CreateCertificateRequest(string name, Option<string?> certificate = default, Option<List<string>?> domainNames = default, Option<Dictionary<string, string>?> labels = default, Option<string?> privateKey = default, Option<TypeEnum?> type = default)
        {
            Name = name;
            CertificateOption = certificate;
            DomainNamesOption = domainNames;
            LabelsOption = labels;
            PrivateKeyOption = privateKey;
            TypeOption = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Choose between uploading a Certificate in PEM format or requesting a managed *Let&#39;s Encrypt* Certificate.
        /// </summary>
        /// <value>Choose between uploading a Certificate in PEM format or requesting a managed *Let&#39;s Encrypt* Certificate.</value>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Managed for value: managed
            /// </summary>
            Managed = 1,

            /// <summary>
            /// Enum Uploaded for value: uploaded
            /// </summary>
            Uploaded = 2
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("managed"))
                return TypeEnum.Managed;

            if (value.Equals("uploaded"))
                return TypeEnum.Uploaded;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("managed"))
                return TypeEnum.Managed;

            if (value.Equals("uploaded"))
                return TypeEnum.Uploaded;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum? value)
        {
            if (value == TypeEnum.Managed)
                return "managed";

            if (value == TypeEnum.Uploaded)
                return "uploaded";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TypeEnum?> TypeOption { get; private set; }

        /// <summary>
        /// Choose between uploading a Certificate in PEM format or requesting a managed *Let&#39;s Encrypt* Certificate.
        /// </summary>
        /// <value>Choose between uploading a Certificate in PEM format or requesting a managed *Let&#39;s Encrypt* Certificate.</value>
        /* <example>uploaded</example> */
        [JsonPropertyName("type")]
        public TypeEnum? Type { get { return this.TypeOption; } set { this.TypeOption = new(value); } }

        /// <summary>
        /// Name of the Certificate
        /// </summary>
        /// <value>Name of the Certificate</value>
        /* <example>my website cert</example> */
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Used to track the state of Certificate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CertificateOption { get; private set; }

        /// <summary>
        /// Certificate and chain in PEM format, in order so that each record directly certifies the one preceding. Required for type &#x60;uploaded&#x60; Certificates.
        /// </summary>
        /// <value>Certificate and chain in PEM format, in order so that each record directly certifies the one preceding. Required for type &#x60;uploaded&#x60; Certificates.</value>
        /* <example>-----BEGIN CERTIFICATE-----
...</example> */
        [JsonPropertyName("certificate")]
        public string? Certificate { get { return this.CertificateOption; } set { this.CertificateOption = new(value); } }

        /// <summary>
        /// Used to track the state of DomainNames
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> DomainNamesOption { get; private set; }

        /// <summary>
        /// Domains and subdomains that should be contained in the Certificate issued by *Let&#39;s Encrypt*. Required for type &#x60;managed&#x60; Certificates.
        /// </summary>
        /// <value>Domains and subdomains that should be contained in the Certificate issued by *Let&#39;s Encrypt*. Required for type &#x60;managed&#x60; Certificates.</value>
        [JsonPropertyName("domain_names")]
        public List<string>? DomainNames { get { return this.DomainNamesOption; } set { this.DomainNamesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Labels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, string>?> LabelsOption { get; private set; }

        /// <summary>
        /// User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;. 
        /// </summary>
        /// <value>User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;. </value>
        /* <example>{&quot;environment&quot;:&quot;prod&quot;,&quot;example.com/my&quot;:&quot;label&quot;,&quot;just-a-key&quot;:&quot;&quot;}</example> */
        [JsonPropertyName("labels")]
        public Dictionary<string, string>? Labels { get { return this.LabelsOption; } set { this.LabelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of PrivateKey
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PrivateKeyOption { get; private set; }

        /// <summary>
        /// Certificate key in PEM format. Required for type &#x60;uploaded&#x60; Certificates.
        /// </summary>
        /// <value>Certificate key in PEM format. Required for type &#x60;uploaded&#x60; Certificates.</value>
        /* <example>-----BEGIN PRIVATE KEY-----
...</example> */
        [JsonPropertyName("private_key")]
        public string? PrivateKey { get { return this.PrivateKeyOption; } set { this.PrivateKeyOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCertificateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  DomainNames: ").Append(DomainNames).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="CreateCertificateRequest" />
    /// </summary>
    public class CreateCertificateRequestJsonConverter : JsonConverter<CreateCertificateRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateCertificateRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateCertificateRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> certificate = default;
            Option<List<string>?> domainNames = default;
            Option<Dictionary<string, string>?> labels = default;
            Option<string?> privateKey = default;
            Option<CreateCertificateRequest.TypeEnum?> type = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "certificate":
                            certificate = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "domain_names":
                            domainNames = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "labels":
                            labels = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "private_key":
                            privateKey = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<CreateCertificateRequest.TypeEnum?>(CreateCertificateRequest.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class CreateCertificateRequest.", nameof(name));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class CreateCertificateRequest.");

            if (certificate.IsSet && certificate.Value == null)
                throw new ArgumentNullException(nameof(certificate), "Property is not nullable for class CreateCertificateRequest.");

            if (domainNames.IsSet && domainNames.Value == null)
                throw new ArgumentNullException(nameof(domainNames), "Property is not nullable for class CreateCertificateRequest.");

            if (labels.IsSet && labels.Value == null)
                throw new ArgumentNullException(nameof(labels), "Property is not nullable for class CreateCertificateRequest.");

            if (privateKey.IsSet && privateKey.Value == null)
                throw new ArgumentNullException(nameof(privateKey), "Property is not nullable for class CreateCertificateRequest.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class CreateCertificateRequest.");

            return new CreateCertificateRequest(name.Value!, certificate, domainNames, labels, privateKey, type);
        }

        /// <summary>
        /// Serializes a <see cref="CreateCertificateRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createCertificateRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateCertificateRequest createCertificateRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createCertificateRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateCertificateRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createCertificateRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateCertificateRequest createCertificateRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createCertificateRequest.Name == null)
                throw new ArgumentNullException(nameof(createCertificateRequest.Name), "Property is required for class CreateCertificateRequest.");

            if (createCertificateRequest.CertificateOption.IsSet && createCertificateRequest.Certificate == null)
                throw new ArgumentNullException(nameof(createCertificateRequest.Certificate), "Property is required for class CreateCertificateRequest.");

            if (createCertificateRequest.DomainNamesOption.IsSet && createCertificateRequest.DomainNames == null)
                throw new ArgumentNullException(nameof(createCertificateRequest.DomainNames), "Property is required for class CreateCertificateRequest.");

            if (createCertificateRequest.LabelsOption.IsSet && createCertificateRequest.Labels == null)
                throw new ArgumentNullException(nameof(createCertificateRequest.Labels), "Property is required for class CreateCertificateRequest.");

            if (createCertificateRequest.PrivateKeyOption.IsSet && createCertificateRequest.PrivateKey == null)
                throw new ArgumentNullException(nameof(createCertificateRequest.PrivateKey), "Property is required for class CreateCertificateRequest.");

            writer.WriteString("name", createCertificateRequest.Name);

            if (createCertificateRequest.CertificateOption.IsSet)
                writer.WriteString("certificate", createCertificateRequest.Certificate);

            if (createCertificateRequest.DomainNamesOption.IsSet)
            {
                writer.WritePropertyName("domain_names");
                JsonSerializer.Serialize(writer, createCertificateRequest.DomainNames, jsonSerializerOptions);
            }
            if (createCertificateRequest.LabelsOption.IsSet)
            {
                writer.WritePropertyName("labels");
                JsonSerializer.Serialize(writer, createCertificateRequest.Labels, jsonSerializerOptions);
            }
            if (createCertificateRequest.PrivateKeyOption.IsSet)
                writer.WriteString("private_key", createCertificateRequest.PrivateKey);

            var typeRawValue = CreateCertificateRequest.TypeEnumToJsonValue(createCertificateRequest.TypeOption.Value!.Value);
            writer.WriteString("type", typeRawValue);
        }
    }

    /// <summary>
    /// The CreateCertificateRequestSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(CreateCertificateRequest))]
    public partial class CreateCertificateRequestSerializationContext : JsonSerializerContext { }
}
