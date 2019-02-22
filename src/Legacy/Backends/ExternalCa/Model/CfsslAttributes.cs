/* 
 * <auto-generated>
 * Third party CA management API
 *
 * API for managing third party CA for creating certificates on Pelion Device Management
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
using SwaggerDateConverter = external_ca.Client.SwaggerDateConverter;

namespace external_ca.Model
{
    /// <summary>
    /// Describes the attributes required to connect to the CFSSL server. 
    /// </summary>
    [DataContract]
    public partial class CfsslAttributes :  IEquatable<CfsslAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfsslAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfsslAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfsslAttributes" /> class.
        /// </summary>
        /// <param name="CfsslLabel">The label that is used by CFSSL when creating the certificate. .</param>
        /// <param name="CfsslProfile">The profile that is configured on the CFSSL server and is used by CFSSL when creating the certificate. .</param>
        /// <param name="HostUrl">The URL to connect to the CFSSL server.  (required).</param>
        public CfsslAttributes(string CfsslLabel = default(string), string CfsslProfile = default(string), string HostUrl = default(string))
        {
            // to ensure "HostUrl" is required (not null)
            if (HostUrl == null)
            {
                throw new InvalidDataException("HostUrl is a required property for CfsslAttributes and cannot be null");
            }
            else
            {
                this.HostUrl = HostUrl;
            }
            this.CfsslLabel = CfsslLabel;
            this.CfsslProfile = CfsslProfile;
        }
        
        /// <summary>
        /// The label that is used by CFSSL when creating the certificate. 
        /// </summary>
        /// <value>The label that is used by CFSSL when creating the certificate. </value>
        [DataMember(Name="cfssl_label", EmitDefaultValue=false)]
        public string CfsslLabel { get; set; }

        /// <summary>
        /// The profile that is configured on the CFSSL server and is used by CFSSL when creating the certificate. 
        /// </summary>
        /// <value>The profile that is configured on the CFSSL server and is used by CFSSL when creating the certificate. </value>
        [DataMember(Name="cfssl_profile", EmitDefaultValue=false)]
        public string CfsslProfile { get; set; }

        /// <summary>
        /// The URL to connect to the CFSSL server. 
        /// </summary>
        /// <value>The URL to connect to the CFSSL server. </value>
        [DataMember(Name="host_url", EmitDefaultValue=false)]
        public string HostUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CfsslAttributes {\n");
            sb.Append("  CfsslLabel: ").Append(CfsslLabel).Append("\n");
            sb.Append("  CfsslProfile: ").Append(CfsslProfile).Append("\n");
            sb.Append("  HostUrl: ").Append(HostUrl).Append("\n");
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
            return this.Equals(input as CfsslAttributes);
        }

        /// <summary>
        /// Returns true if CfsslAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CfsslAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CfsslAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CfsslLabel == input.CfsslLabel ||
                    (this.CfsslLabel != null &&
                    this.CfsslLabel.Equals(input.CfsslLabel))
                ) && 
                (
                    this.CfsslProfile == input.CfsslProfile ||
                    (this.CfsslProfile != null &&
                    this.CfsslProfile.Equals(input.CfsslProfile))
                ) && 
                (
                    this.HostUrl == input.HostUrl ||
                    (this.HostUrl != null &&
                    this.HostUrl.Equals(input.HostUrl))
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
                if (this.CfsslLabel != null)
                    hashCode = hashCode * 59 + this.CfsslLabel.GetHashCode();
                if (this.CfsslProfile != null)
                    hashCode = hashCode * 59 + this.CfsslProfile.GetHashCode();
                if (this.HostUrl != null)
                    hashCode = hashCode * 59 + this.HostUrl.GetHashCode();
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