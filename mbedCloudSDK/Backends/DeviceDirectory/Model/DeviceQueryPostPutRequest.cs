/* 
 * Device Directory API
 *
 * This is the API Documentation for the mbed device directory update service.
 *
 * OpenAPI spec version: 3
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
using SwaggerDateConverter = device_directory.Client.SwaggerDateConverter;

namespace device_directory.Model
{
    /// <summary>
    /// DeviceQueryPostPutRequest
    /// </summary>
    [DataContract]
    public partial class DeviceQueryPostPutRequest :  IEquatable<DeviceQueryPostPutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceQueryPostPutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceQueryPostPutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceQueryPostPutRequest" /> class.
        /// </summary>
        /// <param name="Query">The device query. (required).</param>
        /// <param name="Name">The name of the query. (required).</param>
        public DeviceQueryPostPutRequest(string Query = default(string), string Name = default(string))
        {
            // to ensure "Query" is required (not null)
            if (Query == null)
            {
                throw new InvalidDataException("Query is a required property for DeviceQueryPostPutRequest and cannot be null");
            }
            else
            {
                this.Query = Query;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DeviceQueryPostPutRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }
        
        /// <summary>
        /// The device query.
        /// </summary>
        /// <value>The device query.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// The name of the query.
        /// </summary>
        /// <value>The name of the query.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceQueryPostPutRequest {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(obj as DeviceQueryPostPutRequest);
        }

        /// <summary>
        /// Returns true if DeviceQueryPostPutRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceQueryPostPutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceQueryPostPutRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
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
            // Query (string) maxLength
            if(this.Query != null && this.Query.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Query, length must be less than 1000.", new [] { "Query" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            yield break;
        }
    }

}
