/* 
 * IAM Identities REST API
 *
 * REST API to manage accounts, groups, users and API keys
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
    /// This object represents a response to an update request.
    /// </summary>
    [DataContract]
    public partial class UpdatedResponse :  IEquatable<UpdatedResponse>, IValidatableObject
    {
        /// <summary>
        /// Entity name: 'user', 'apikey', 'group' or 'account'.
        /// </summary>
        /// <value>Entity name: 'user', 'apikey', 'group' or 'account'.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Apikey for "api_key"
            /// </summary>
            [EnumMember(Value = "api_key")]
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
            /// Enum Accounttemplate for "account_template"
            /// </summary>
            [EnumMember(Value = "account_template")]
            Accounttemplate,
            
            /// <summary>
            /// Enum Cacert for "ca_cert"
            /// </summary>
            [EnumMember(Value = "ca_cert")]
            Cacert,
            
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
        /// Response type: success.
        /// </summary>
        /// <value>Response type: success.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Success for "success"
            /// </summary>
            [EnumMember(Value = "success")]
            Success,
            
            /// <summary>
            /// Enum Created for "created"
            /// </summary>
            [EnumMember(Value = "created")]
            Created,
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Permanentlydeleted for "permanently_deleted"
            /// </summary>
            [EnumMember(Value = "permanently_deleted")]
            Permanentlydeleted,
            
            /// <summary>
            /// Enum Validationerror for "validation_error"
            /// </summary>
            [EnumMember(Value = "validation_error")]
            Validationerror,
            
            /// <summary>
            /// Enum Invalidtoken for "invalid_token"
            /// </summary>
            [EnumMember(Value = "invalid_token")]
            Invalidtoken,
            
            /// <summary>
            /// Enum Accessdenied for "access_denied"
            /// </summary>
            [EnumMember(Value = "access_denied")]
            Accessdenied,
            
            /// <summary>
            /// Enum Accountlimitexceeded for "account_limit_exceeded"
            /// </summary>
            [EnumMember(Value = "account_limit_exceeded")]
            Accountlimitexceeded,
            
            /// <summary>
            /// Enum Notfound for "not_found"
            /// </summary>
            [EnumMember(Value = "not_found")]
            Notfound,
            
            /// <summary>
            /// Enum Methodnotsupported for "method_not_supported"
            /// </summary>
            [EnumMember(Value = "method_not_supported")]
            Methodnotsupported,
            
            /// <summary>
            /// Enum Notacceptable for "not_acceptable"
            /// </summary>
            [EnumMember(Value = "not_acceptable")]
            Notacceptable,
            
            /// <summary>
            /// Enum Duplicate for "duplicate"
            /// </summary>
            [EnumMember(Value = "duplicate")]
            Duplicate,
            
            /// <summary>
            /// Enum Preconditionfailed for "precondition_failed"
            /// </summary>
            [EnumMember(Value = "precondition_failed")]
            Preconditionfailed,
            
            /// <summary>
            /// Enum Unsupportedmediatype for "unsupported_media_type"
            /// </summary>
            [EnumMember(Value = "unsupported_media_type")]
            Unsupportedmediatype,
            
            /// <summary>
            /// Enum Ratelimitexceeded for "rate_limit_exceeded"
            /// </summary>
            [EnumMember(Value = "rate_limit_exceeded")]
            Ratelimitexceeded,
            
            /// <summary>
            /// Enum Internalservererror for "internal_server_error"
            /// </summary>
            [EnumMember(Value = "internal_server_error")]
            Internalservererror,
            
            /// <summary>
            /// Enum Systemunavailable for "system_unavailable"
            /// </summary>
            [EnumMember(Value = "system_unavailable")]
            Systemunavailable
        }

        /// <summary>
        /// Entity name: 'user', 'apikey', 'group' or 'account'.
        /// </summary>
        /// <value>Entity name: 'user', 'apikey', 'group' or 'account'.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Response type: success.
        /// </summary>
        /// <value>Response type: success.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatedResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedResponse" /> class.
        /// </summary>
        /// <param name="Code">Response code. (required).</param>
        /// <param name="_Object">Entity name: &#39;user&#39;, &#39;apikey&#39;, &#39;group&#39; or &#39;account&#39;. (required).</param>
        /// <param name="RequestId">Request ID. (required).</param>
        /// <param name="Message">A human readable message with detailed info. (required).</param>
        /// <param name="Type">Response type: success. (required).</param>
        /// <param name="Id">Entity ID. (required).</param>
        public UpdatedResponse(int? Code = default(int?), ObjectEnum? _Object = default(ObjectEnum?), string RequestId = default(string), string Message = default(string), TypeEnum? Type = default(TypeEnum?), string Id = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for UpdatedResponse and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for UpdatedResponse and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "RequestId" is required (not null)
            if (RequestId == null)
            {
                throw new InvalidDataException("RequestId is a required property for UpdatedResponse and cannot be null");
            }
            else
            {
                this.RequestId = RequestId;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for UpdatedResponse and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for UpdatedResponse and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UpdatedResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
        }
        
        /// <summary>
        /// Response code.
        /// </summary>
        /// <value>Response code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }
        /// <summary>
        /// Request ID.
        /// </summary>
        /// <value>Request ID.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }
        /// <summary>
        /// A human readable message with detailed info.
        /// </summary>
        /// <value>A human readable message with detailed info.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Entity ID.
        /// </summary>
        /// <value>Entity ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatedResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as UpdatedResponse);
        }

        /// <summary>
        /// Returns true if UpdatedResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdatedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatedResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
