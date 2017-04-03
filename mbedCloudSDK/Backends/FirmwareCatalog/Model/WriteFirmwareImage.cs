/* 
 * Firmware Catalog API
 *
 * This is the API Documentation for the mbed firmware catalog service which is part of the update service.
 *
 * OpenAPI spec version: 0.1
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

namespace firmware_catalog.Model
{
    /// <summary>
    /// WriteFirmwareImage
    /// </summary>
    [DataContract]
    public partial class WriteFirmwareImage :  IEquatable<WriteFirmwareImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteFirmwareImage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WriteFirmwareImage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteFirmwareImage" /> class.
        /// </summary>
        /// <param name="Description">The description of the object.</param>
        /// <param name="Name">The name of the object (required).</param>
        public WriteFirmwareImage(string Description = default(string), string Name = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for WriteFirmwareImage and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
        }
        
        /// <summary>
        /// The description of the object
        /// </summary>
        /// <value>The description of the object</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The name of the object
        /// </summary>
        /// <value>The name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriteFirmwareImage {\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WriteFirmwareImage);
        }

        /// <summary>
        /// Returns true if WriteFirmwareImage instances are equal
        /// </summary>
        /// <param name="other">Instance of WriteFirmwareImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteFirmwareImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
