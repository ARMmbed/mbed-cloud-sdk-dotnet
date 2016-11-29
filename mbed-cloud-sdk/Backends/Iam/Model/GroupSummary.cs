using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace iam.Model
{
    /// <summary>
    /// This object contains basic information about groups.
    /// </summary>
    [DataContract]
    public partial class GroupSummary :  IEquatable<GroupSummary>
    { 
    
        /// <summary>
        /// entity name: always 'group'
        /// </summary>
        /// <value>entity name: always 'group'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum _ObjectEnum {
            
            [EnumMember(Value = "user")]
            User,
            
            [EnumMember(Value = "apikey")]
            Apikey,
            
            [EnumMember(Value = "group")]
            Group,
            
            [EnumMember(Value = "account")]
            Account,
            
            [EnumMember(Value = "list")]
            List,
            
            [EnumMember(Value = "error")]
            Error
        }

    
        /// <summary>
        /// entity name: always 'group'
        /// </summary>
        /// <value>entity name: always 'group'</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public _ObjectEnum? _Object { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSummary" /> class.
        /// Initializes a new instance of the <see cref="GroupSummary" />class.
        /// </summary>
        /// <param name="Name">The name of the group. (required).</param>
        /// <param name="LastUpdateTime">A timestamp of the latest group update, in milliseconds..</param>
        /// <param name="ApiKeyCount">The number of API keys in this group. (required).</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="_Object">entity name: always &#39;group&#39; (required).</param>
        /// <param name="CreationTime">A timestamp of the group creation in the storage, in milliseconds..</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="Id">The UUID of the group. (required).</param>
        /// <param name="UserCount">The number of users in this group. (required).</param>

        public GroupSummary(string Name = null, long? LastUpdateTime = null, int? ApiKeyCount = null, string CreatedAt = null, _ObjectEnum? _Object = null, long? CreationTime = null, string Etag = null, string Id = null, int? UserCount = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GroupSummary and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ApiKeyCount" is required (not null)
            if (ApiKeyCount == null)
            {
                throw new InvalidDataException("ApiKeyCount is a required property for GroupSummary and cannot be null");
            }
            else
            {
                this.ApiKeyCount = ApiKeyCount;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for GroupSummary and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for GroupSummary and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for GroupSummary and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "UserCount" is required (not null)
            if (UserCount == null)
            {
                throw new InvalidDataException("UserCount is a required property for GroupSummary and cannot be null");
            }
            else
            {
                this.UserCount = UserCount;
            }
            this.LastUpdateTime = LastUpdateTime;
            this.CreatedAt = CreatedAt;
            this.CreationTime = CreationTime;
            
        }
        
    
        /// <summary>
        /// The name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// A timestamp of the latest group update, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the latest group update, in milliseconds.</value>
        [DataMember(Name="lastUpdateTime", EmitDefaultValue=false)]
        public long? LastUpdateTime { get; set; }
    
        /// <summary>
        /// The number of API keys in this group.
        /// </summary>
        /// <value>The number of API keys in this group.</value>
        [DataMember(Name="apiKeyCount", EmitDefaultValue=false)]
        public int? ApiKeyCount { get; set; }
    
        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// A timestamp of the group creation in the storage, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the group creation in the storage, in milliseconds.</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }
    
        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
    
        /// <summary>
        /// The UUID of the group.
        /// </summary>
        /// <value>The UUID of the group.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The number of users in this group.
        /// </summary>
        /// <value>The number of users in this group.</value>
        [DataMember(Name="userCount", EmitDefaultValue=false)]
        public int? UserCount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSummary {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  ApiKeyCount: ").Append(ApiKeyCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            
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
            return this.Equals(obj as GroupSummary);
        }

        /// <summary>
        /// Returns true if GroupSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.LastUpdateTime == other.LastUpdateTime ||
                    this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    this.ApiKeyCount == other.ApiKeyCount ||
                    this.ApiKeyCount != null &&
                    this.ApiKeyCount.Equals(other.ApiKeyCount)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.LastUpdateTime != null)
                    hash = hash * 59 + this.LastUpdateTime.GetHashCode();
                
                if (this.ApiKeyCount != null)
                    hash = hash * 59 + this.ApiKeyCount.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.UserCount != null)
                    hash = hash * 59 + this.UserCount.GetHashCode();
                
                return hash;
            }
        }

    }
}
