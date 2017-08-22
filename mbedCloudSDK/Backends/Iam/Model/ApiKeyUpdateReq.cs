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
    /// This object represents an API key in requests towards mbed Cloud.
    /// </summary>
    [DataContract]
    public partial class ApiKeyUpdateReq :  IEquatable<ApiKeyUpdateReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyUpdateReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyUpdateReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyUpdateReq" /> class.
        /// </summary>
        /// <param name="Owner">The owner of this API key, who is the creator by default..</param>
        /// <param name="Name">The display name for the API key, not longer than 100 characters. (required).</param>
        public ApiKeyUpdateReq(string Owner = default(string), string Name = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ApiKeyUpdateReq and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Owner = Owner;
        }
        
        /// <summary>
        /// The owner of this API key, who is the creator by default.
        /// </summary>
        /// <value>The owner of this API key, who is the creator by default.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The display name for the API key, not longer than 100 characters.
        /// </summary>
        /// <value>The display name for the API key, not longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyUpdateReq {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(obj as ApiKeyUpdateReq);
        }

        /// <summary>
        /// Returns true if ApiKeyUpdateReq instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiKeyUpdateReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyUpdateReq other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
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
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
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
