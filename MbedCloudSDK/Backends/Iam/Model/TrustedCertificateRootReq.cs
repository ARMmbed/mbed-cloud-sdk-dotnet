/* 
 * <auto-generated>
 * Account Management API
 *
 * API for managing accounts, users, creating API keys, uploading trusted certificates
 *
 * OpenAPI spec version: v3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * </auto-generated>
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = iam.Client.SwaggerDateConverter;

namespace iam.Model
{
    /// <summary>
    /// This object represents a trusted certificate in upload requests.
    /// </summary>
    [DataContract]
    public partial class TrustedCertificateRootReq :  IEquatable<TrustedCertificateRootReq>, IValidatableObject
    {
        /// <summary>
        /// Status of the certificate.
        /// </summary>
        /// <value>Status of the certificate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACTIVE for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE,
            
            /// <summary>
            /// Enum INACTIVE for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE
        }

        /// <summary>
        /// Service name where the certificate must be used.
        /// </summary>
        /// <value>Service name where the certificate must be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceEnum
        {
            
            /// <summary>
            /// Enum Lwm2m for "lwm2m"
            /// </summary>
            [EnumMember(Value = "lwm2m")]
            Lwm2m,
            
            /// <summary>
            /// Enum Bootstrap for "bootstrap"
            /// </summary>
            [EnumMember(Value = "bootstrap")]
            Bootstrap
        }

        /// <summary>
        /// Status of the certificate.
        /// </summary>
        /// <value>Status of the certificate.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Service name where the certificate must be used.
        /// </summary>
        /// <value>Service name where the certificate must be used.</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificateRootReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustedCertificateRootReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificateRootReq" /> class.
        /// </summary>
        /// <param name="Status">Status of the certificate..</param>
        /// <param name="EnrollmentMode">If true, signature parameter is not required. Default value is false..</param>
        /// <param name="Certificate">X509.v3 trusted certificate in PEM format. (required).</param>
        /// <param name="Name">Certificate name, not longer than 100 characters. (required).</param>
        /// <param name="Service">Service name where the certificate must be used. (required).</param>
        /// <param name="Signature">Base64 encoded signature of the account ID signed by the certificate to be uploaded. Signature must be hashed with SHA256. Optional if enrollment_mode is &#39;true&#39;..</param>
        /// <param name="Description">Human readable description of this certificate, not longer than 500 characters..</param>
        public TrustedCertificateRootReq(StatusEnum? Status = default(StatusEnum?), bool? EnrollmentMode = default(bool?), string Certificate = default(string), string Name = default(string), ServiceEnum? Service = default(ServiceEnum?), string Signature = default(string), string Description = default(string))
        {
            // to ensure "Certificate" is required (not null)
            if (Certificate == null)
            {
                throw new InvalidDataException("Certificate is a required property for TrustedCertificateRootReq and cannot be null");
            }
            else
            {
                this.Certificate = Certificate;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for TrustedCertificateRootReq and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Service" is required (not null)
            if (Service == null)
            {
                throw new InvalidDataException("Service is a required property for TrustedCertificateRootReq and cannot be null");
            }
            else
            {
                this.Service = Service;
            }
            this.Status = Status;
            this.EnrollmentMode = EnrollmentMode;
            this.Signature = Signature;
            this.Description = Description;
        }
        

        /// <summary>
        /// If true, signature parameter is not required. Default value is false.
        /// </summary>
        /// <value>If true, signature parameter is not required. Default value is false.</value>
        [DataMember(Name="enrollment_mode", EmitDefaultValue=false)]
        public bool? EnrollmentMode { get; set; }

        /// <summary>
        /// X509.v3 trusted certificate in PEM format.
        /// </summary>
        /// <value>X509.v3 trusted certificate in PEM format.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Certificate name, not longer than 100 characters.
        /// </summary>
        /// <value>Certificate name, not longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Base64 encoded signature of the account ID signed by the certificate to be uploaded. Signature must be hashed with SHA256. Optional if enrollment_mode is &#39;true&#39;.
        /// </summary>
        /// <value>Base64 encoded signature of the account ID signed by the certificate to be uploaded. Signature must be hashed with SHA256. Optional if enrollment_mode is &#39;true&#39;.</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }

        /// <summary>
        /// Human readable description of this certificate, not longer than 500 characters.
        /// </summary>
        /// <value>Human readable description of this certificate, not longer than 500 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustedCertificateRootReq {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EnrollmentMode: ").Append(EnrollmentMode).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrustedCertificateRootReq);
        }

        /// <summary>
        /// Returns true if TrustedCertificateRootReq instances are equal
        /// </summary>
        /// <param name="input">Instance of TrustedCertificateRootReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustedCertificateRootReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EnrollmentMode == input.EnrollmentMode ||
                    (this.EnrollmentMode != null &&
                    this.EnrollmentMode.Equals(input.EnrollmentMode))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EnrollmentMode != null)
                    hashCode = hashCode * 59 + this.EnrollmentMode.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
