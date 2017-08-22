/* 
 * Account Management API
 *
 * API for managing accounts, users, creating API keys, uploading trusted certificates
 *
 * OpenAPI spec version: v3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    /// This object represents a trusted certificate in responses.
    /// </summary>
    [DataContract]
    public partial class TrustedCertificateResp :  IEquatable<TrustedCertificateResp>, IValidatableObject
    {
        /// <summary>
        /// Service name where the certificate is to be used.
        /// </summary>
        /// <value>Service name where the certificate is to be used.</value>
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
        /// Entity name: always &#39;trusted-cert&#39;
        /// </summary>
        /// <value>Entity name: always &#39;trusted-cert&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Apikey for "api-key"
            /// </summary>
            [EnumMember(Value = "api-key")]
            Apikey,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Account for "account"
            /// </summary>
            [EnumMember(Value = "account")]
            Account,
            
            /// <summary>
            /// Enum Accounttemplate for "account-template"
            /// </summary>
            [EnumMember(Value = "account-template")]
            Accounttemplate,
            
            /// <summary>
            /// Enum Trustedcert for "trusted-cert"
            /// </summary>
            [EnumMember(Value = "trusted-cert")]
            Trustedcert,
            
            /// <summary>
            /// Enum List for "list"
            /// </summary>
            [EnumMember(Value = "list")]
            List,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error
        }

        /// <summary>
        /// Service name where the certificate is to be used.
        /// </summary>
        /// <value>Service name where the certificate is to be used.</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// Status of the certificate.
        /// </summary>
        /// <value>Status of the certificate.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Entity name: always &#39;trusted-cert&#39;
        /// </summary>
        /// <value>Entity name: always &#39;trusted-cert&#39;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificateResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustedCertificateResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificateResp" /> class.
        /// </summary>
        /// <param name="Service">Service name where the certificate is to be used. (required).</param>
        /// <param name="Status">Status of the certificate..</param>
        /// <param name="Description">Human readable description of this certificate..</param>
        /// <param name="Certificate">X509.v3 trusted certificate in PEM format. (required).</param>
        /// <param name="Issuer">Issuer of the certificate. (required).</param>
        /// <param name="DeviceExecutionMode">Device execution mode where 1 means a developer certificate..</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="_Object">Entity name: always &#39;trusted-cert&#39; (required).</param>
        /// <param name="Subject">Subject of the certificate. (required).</param>
        /// <param name="AccountId">The UUID of the account. (required).</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="Validity">Expiration time in UTC formatted as RFC3339. (required).</param>
        /// <param name="OwnerId">The UUID of the owner..</param>
        /// <param name="Id">Entity ID. (required).</param>
        /// <param name="Name">Certificate name. (required).</param>
        public TrustedCertificateResp(ServiceEnum? Service = default(ServiceEnum?), StatusEnum? Status = default(StatusEnum?), string Description = default(string), string Certificate = default(string), string Issuer = default(string), int? DeviceExecutionMode = default(int?), DateTime? CreatedAt = default(DateTime?), ObjectEnum? _Object = default(ObjectEnum?), string Subject = default(string), string AccountId = default(string), string Etag = default(string), DateTime? Validity = default(DateTime?), string OwnerId = default(string), string Id = default(string), string Name = default(string))
        {
            // to ensure "Service" is required (not null)
            if (Service == null)
            {
                throw new InvalidDataException("Service is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Service = Service;
            }
            // to ensure "Certificate" is required (not null)
            if (Certificate == null)
            {
                throw new InvalidDataException("Certificate is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Certificate = Certificate;
            }
            // to ensure "Issuer" is required (not null)
            if (Issuer == null)
            {
                throw new InvalidDataException("Issuer is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Issuer = Issuer;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Subject" is required (not null)
            if (Subject == null)
            {
                throw new InvalidDataException("Subject is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Subject = Subject;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Validity" is required (not null)
            if (Validity == null)
            {
                throw new InvalidDataException("Validity is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Validity = Validity;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for TrustedCertificateResp and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Status = Status;
            this.Description = Description;
            this.DeviceExecutionMode = DeviceExecutionMode;
            this.CreatedAt = CreatedAt;
            this.OwnerId = OwnerId;
        }
        


        /// <summary>
        /// Human readable description of this certificate.
        /// </summary>
        /// <value>Human readable description of this certificate.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// X509.v3 trusted certificate in PEM format.
        /// </summary>
        /// <value>X509.v3 trusted certificate in PEM format.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Issuer of the certificate.
        /// </summary>
        /// <value>Issuer of the certificate.</value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Device execution mode where 1 means a developer certificate.
        /// </summary>
        /// <value>Device execution mode where 1 means a developer certificate.</value>
        [DataMember(Name="device_execution_mode", EmitDefaultValue=false)]
        public int? DeviceExecutionMode { get; set; }

        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }


        /// <summary>
        /// Subject of the certificate.
        /// </summary>
        /// <value>Subject of the certificate.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// The UUID of the account.
        /// </summary>
        /// <value>The UUID of the account.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Expiration time in UTC formatted as RFC3339.
        /// </summary>
        /// <value>Expiration time in UTC formatted as RFC3339.</value>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        public DateTime? Validity { get; set; }

        /// <summary>
        /// The UUID of the owner.
        /// </summary>
        /// <value>The UUID of the owner.</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Entity ID.
        /// </summary>
        /// <value>Entity ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Certificate name.
        /// </summary>
        /// <value>Certificate name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustedCertificateResp {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  DeviceExecutionMode: ").Append(DeviceExecutionMode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TrustedCertificateResp);
        }

        /// <summary>
        /// Returns true if TrustedCertificateResp instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustedCertificateResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustedCertificateResp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Certificate == other.Certificate ||
                    this.Certificate != null &&
                    this.Certificate.Equals(other.Certificate)
                ) && 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.DeviceExecutionMode == other.DeviceExecutionMode ||
                    this.DeviceExecutionMode != null &&
                    this.DeviceExecutionMode.Equals(other.DeviceExecutionMode)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.Validity == other.Validity ||
                    this.Validity != null &&
                    this.Validity.Equals(other.Validity)
                ) && 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Certificate != null)
                    hash = hash * 59 + this.Certificate.GetHashCode();
                if (this.Issuer != null)
                    hash = hash * 59 + this.Issuer.GetHashCode();
                if (this.DeviceExecutionMode != null)
                    hash = hash * 59 + this.DeviceExecutionMode.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.Validity != null)
                    hash = hash * 59 + this.Validity.GetHashCode();
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
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
