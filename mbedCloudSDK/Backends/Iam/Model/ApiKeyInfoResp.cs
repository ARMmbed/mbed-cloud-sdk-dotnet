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
    /// This object represents an API key in mbed Cloud.
    /// </summary>
    [DataContract]
    public partial class ApiKeyInfoResp :  IEquatable<ApiKeyInfoResp>, IValidatableObject
    {
        /// <summary>
        /// The status of the API key.
        /// </summary>
        /// <value>The status of the API key.</value>
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
        /// Entity name: always 'api-key'
        /// </summary>
        /// <value>Entity name: always 'api-key'</value>
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
            Error,
            
            /// <summary>
            /// Enum Agreement for "agreement"
            /// </summary>
            [EnumMember(Value = "agreement")]
            Agreement,
            
            /// <summary>
            /// Enum Signedagreement for "signed-agreement"
            /// </summary>
            [EnumMember(Value = "signed-agreement")]
            Signedagreement
        }

        /// <summary>
        /// The status of the API key.
        /// </summary>
        /// <value>The status of the API key.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Entity name: always 'api-key'
        /// </summary>
        /// <value>Entity name: always 'api-key'</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfoResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyInfoResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfoResp" /> class.
        /// </summary>
        /// <param name="Groups">A list of group IDs this API key belongs to..</param>
        /// <param name="Status">The status of the API key..</param>
        /// <param name="Name">The display name for the API key. (required).</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="_Object">Entity name: always &#39;api-key&#39; (required).</param>
        /// <param name="CreationTime">The timestamp of the API key creation in the storage, in milliseconds..</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="Key">The API key. (required).</param>
        /// <param name="Owner">The owner of this API key, who is the creator by default..</param>
        /// <param name="Id">The UUID of the API key. (required).</param>
        /// <param name="LastLoginTime">The timestamp of the latest API key usage, in milliseconds..</param>
        public ApiKeyInfoResp(List<string> Groups = default(List<string>), StatusEnum? Status = default(StatusEnum?), string Name = default(string), DateTime? CreatedAt = default(DateTime?), ObjectEnum? _Object = default(ObjectEnum?), long? CreationTime = default(long?), string Etag = default(string), string Key = default(string), string Owner = default(string), string Id = default(string), long? LastLoginTime = default(long?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Groups = Groups;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.CreationTime = CreationTime;
            this.Owner = Owner;
            this.LastLoginTime = LastLoginTime;
        }
        
        /// <summary>
        /// A list of group IDs this API key belongs to.
        /// </summary>
        /// <value>A list of group IDs this API key belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
        /// <summary>
        /// The display name for the API key.
        /// </summary>
        /// <value>The display name for the API key.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// The timestamp of the API key creation in the storage, in milliseconds.
        /// </summary>
        /// <value>The timestamp of the API key creation in the storage, in milliseconds.</value>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }
        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
        /// <summary>
        /// The API key.
        /// </summary>
        /// <value>The API key.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// The owner of this API key, who is the creator by default.
        /// </summary>
        /// <value>The owner of this API key, who is the creator by default.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }
        /// <summary>
        /// The UUID of the API key.
        /// </summary>
        /// <value>The UUID of the API key.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The timestamp of the latest API key usage, in milliseconds.
        /// </summary>
        /// <value>The timestamp of the latest API key usage, in milliseconds.</value>
        [DataMember(Name="last_login_time", EmitDefaultValue=false)]
        public long? LastLoginTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyInfoResp {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
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
            return this.Equals(obj as ApiKeyInfoResp);
        }

        /// <summary>
        /// Returns true if ApiKeyInfoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiKeyInfoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyInfoResp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastLoginTime == other.LastLoginTime ||
                    this.LastLoginTime != null &&
                    this.LastLoginTime.Equals(other.LastLoginTime)
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
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastLoginTime != null)
                    hash = hash * 59 + this.LastLoginTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
