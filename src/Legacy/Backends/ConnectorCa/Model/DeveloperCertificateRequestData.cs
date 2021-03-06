/* 
 * <auto-generated>
 * Connect CA API
 *
 * mbed Cloud Connect CA API allows services to get device credentials.
 *
 * OpenAPI spec version: 3
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
using SwaggerDateConverter = connector_ca.Client.SwaggerDateConverter;

namespace connector_ca.Model
{
    /// <summary>
    /// DeveloperCertificateRequestData
    /// </summary>
    [DataContract]
    public partial class DeveloperCertificateRequestData :  IEquatable<DeveloperCertificateRequestData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperCertificateRequestData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeveloperCertificateRequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperCertificateRequestData" /> class.
        /// </summary>
        /// <param name="Description">Description for the developer certificate. There is a limit on the length of the description. Please see [TrustedCertificateReq](/docs/v1.2/api-references/account-management-api.html#trustedcertificatereq).</param>
        /// <param name="Name">Name of the developer certificate, must be unique. There is a limit on the length of the name. Please see [TrustedCertificateReq](/docs/v1.2/api-references/account-management-api.html#trustedcertificatereq) (required).</param>
        public DeveloperCertificateRequestData(string Description = default(string), string Name = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DeveloperCertificateRequestData and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
        }
        
        /// <summary>
        /// Description for the developer certificate. There is a limit on the length of the description. Please see [TrustedCertificateReq](/docs/v1.2/api-references/account-management-api.html#trustedcertificatereq)
        /// </summary>
        /// <value>Description for the developer certificate. There is a limit on the length of the description. Please see [TrustedCertificateReq](/docs/v1.2/api-references/account-management-api.html#trustedcertificatereq)</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the developer certificate, must be unique. There is a limit on the length of the name. Please see [TrustedCertificateReq](/docs/v1.2/api-references/account-management-api.html#trustedcertificatereq)
        /// </summary>
        /// <value>Name of the developer certificate, must be unique. There is a limit on the length of the name. Please see [TrustedCertificateReq](/docs/v1.2/api-references/account-management-api.html#trustedcertificatereq)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeveloperCertificateRequestData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeveloperCertificateRequestData);
        }

        /// <summary>
        /// Returns true if DeveloperCertificateRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of DeveloperCertificateRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeveloperCertificateRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
