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

namespace iam.Model
{
    /// <summary>
    /// This object represents an array of users and API keys.
    /// </summary>
    [DataContract]
    public partial class SubjectList :  IEquatable<SubjectList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectList" /> class.
        /// </summary>
        /// <param name="Apikeys">An array of API keys..</param>
        /// <param name="Users">An array of user names..</param>
        public SubjectList(List<string> Apikeys = default(List<string>), List<string> Users = default(List<string>))
        {
            this.Apikeys = Apikeys;
            this.Users = Users;
        }
        
        /// <summary>
        /// An array of API keys.
        /// </summary>
        /// <value>An array of API keys.</value>
        [DataMember(Name="apikeys", EmitDefaultValue=false)]
        public List<string> Apikeys { get; set; }
        /// <summary>
        /// An array of user names.
        /// </summary>
        /// <value>An array of user names.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubjectList {\n");
            sb.Append("  Apikeys: ").Append(Apikeys).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as SubjectList);
        }

        /// <summary>
        /// Returns true if SubjectList instances are equal
        /// </summary>
        /// <param name="other">Instance of SubjectList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubjectList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Apikeys == other.Apikeys ||
                    this.Apikeys != null &&
                    this.Apikeys.SequenceEqual(other.Apikeys)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Apikeys != null)
                    hash = hash * 59 + this.Apikeys.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
