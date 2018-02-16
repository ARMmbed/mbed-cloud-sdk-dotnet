/* 
 * <auto-generated>
 * Account Management API
 *
 * API for managing accounts, users, creating API keys, uploading trusted certificates
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
using SwaggerDateConverter = iam.Client.SwaggerDateConverter;

namespace iam.Model
{
    /// <summary>
    /// This object represents an active user session.
    /// </summary>
    [DataContract]
    public partial class ActiveSession :  IEquatable<ActiveSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActiveSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveSession" /> class.
        /// </summary>
        /// <param name="UserAgent">User Agent header from the login request. (required).</param>
        /// <param name="IpAddress">IP address of the client. (required).</param>
        /// <param name="AccountId">The UUID of the account. (required).</param>
        /// <param name="ReferenceToken">The reference token. (required).</param>
        /// <param name="LoginTime">The login time of the user. (required).</param>
        public ActiveSession(string UserAgent = default(string), string IpAddress = default(string), string AccountId = default(string), string ReferenceToken = default(string), DateTime? LoginTime = default(DateTime?))
        {
            // to ensure "UserAgent" is required (not null)
            if (UserAgent == null)
            {
                throw new InvalidDataException("UserAgent is a required property for ActiveSession and cannot be null");
            }
            else
            {
                this.UserAgent = UserAgent;
            }
            // to ensure "IpAddress" is required (not null)
            if (IpAddress == null)
            {
                throw new InvalidDataException("IpAddress is a required property for ActiveSession and cannot be null");
            }
            else
            {
                this.IpAddress = IpAddress;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for ActiveSession and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "ReferenceToken" is required (not null)
            if (ReferenceToken == null)
            {
                throw new InvalidDataException("ReferenceToken is a required property for ActiveSession and cannot be null");
            }
            else
            {
                this.ReferenceToken = ReferenceToken;
            }
            // to ensure "LoginTime" is required (not null)
            if (LoginTime == null)
            {
                throw new InvalidDataException("LoginTime is a required property for ActiveSession and cannot be null");
            }
            else
            {
                this.LoginTime = LoginTime;
            }
        }
        
        /// <summary>
        /// User Agent header from the login request.
        /// </summary>
        /// <value>User Agent header from the login request.</value>
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// IP address of the client.
        /// </summary>
        /// <value>IP address of the client.</value>
        [DataMember(Name="ip_address", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The UUID of the account.
        /// </summary>
        /// <value>The UUID of the account.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The reference token.
        /// </summary>
        /// <value>The reference token.</value>
        [DataMember(Name="reference_token", EmitDefaultValue=false)]
        public string ReferenceToken { get; set; }

        /// <summary>
        /// The login time of the user.
        /// </summary>
        /// <value>The login time of the user.</value>
        [DataMember(Name="login_time", EmitDefaultValue=false)]
        public DateTime? LoginTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveSession {\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ReferenceToken: ").Append(ReferenceToken).Append("\n");
            sb.Append("  LoginTime: ").Append(LoginTime).Append("\n");
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
            return this.Equals(input as ActiveSession);
        }

        /// <summary>
        /// Returns true if ActiveSession instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ReferenceToken == input.ReferenceToken ||
                    (this.ReferenceToken != null &&
                    this.ReferenceToken.Equals(input.ReferenceToken))
                ) && 
                (
                    this.LoginTime == input.LoginTime ||
                    (this.LoginTime != null &&
                    this.LoginTime.Equals(input.LoginTime))
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
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ReferenceToken != null)
                    hashCode = hashCode * 59 + this.ReferenceToken.GetHashCode();
                if (this.LoginTime != null)
                    hashCode = hashCode * 59 + this.LoginTime.GetHashCode();
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