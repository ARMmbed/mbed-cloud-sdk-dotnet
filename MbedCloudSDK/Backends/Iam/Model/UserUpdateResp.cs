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
    /// This object represents a user update response.
    /// </summary>
    [DataContract]
    public partial class UserUpdateResp :  IEquatable<UserUpdateResp>, IValidatableObject
    {
        /// <summary>
        /// The status of the user. ENROLLING state indicates that the user is in the middle of the enrollment process. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. INACTIVE users are locked out and not permitted to use the system.
        /// </summary>
        /// <value>The status of the user. ENROLLING state indicates that the user is in the middle of the enrollment process. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. INACTIVE users are locked out and not permitted to use the system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ENROLLING for "ENROLLING"
            /// </summary>
            [EnumMember(Value = "ENROLLING")]
            ENROLLING,
            
            /// <summary>
            /// Enum INVITED for "INVITED"
            /// </summary>
            [EnumMember(Value = "INVITED")]
            INVITED,
            
            /// <summary>
            /// Enum ACTIVE for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE,
            
            /// <summary>
            /// Enum RESET for "RESET"
            /// </summary>
            [EnumMember(Value = "RESET")]
            RESET,
            
            /// <summary>
            /// Enum INACTIVE for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE
        }

        /// <summary>
        /// Entity name: always &#39;user&#39;
        /// </summary>
        /// <value>Entity name: always &#39;user&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum ApiKey for "api-key"
            /// </summary>
            [EnumMember(Value = "api-key")]
            ApiKey,
            
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
            /// Enum AccountTemplate for "account-template"
            /// </summary>
            [EnumMember(Value = "account-template")]
            AccountTemplate,
            
            /// <summary>
            /// Enum TrustedCert for "trusted-cert"
            /// </summary>
            [EnumMember(Value = "trusted-cert")]
            TrustedCert,
            
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
            /// Enum Policy for "policy"
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy,
            
            /// <summary>
            /// Enum IdentityProvider for "identity-provider"
            /// </summary>
            [EnumMember(Value = "identity-provider")]
            IdentityProvider
        }

        /// <summary>
        /// The status of the user. ENROLLING state indicates that the user is in the middle of the enrollment process. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. INACTIVE users are locked out and not permitted to use the system.
        /// </summary>
        /// <value>The status of the user. ENROLLING state indicates that the user is in the middle of the enrollment process. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. INACTIVE users are locked out and not permitted to use the system.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Entity name: always &#39;user&#39;
        /// </summary>
        /// <value>Entity name: always &#39;user&#39;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserUpdateResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateResp" /> class.
        /// </summary>
        /// <param name="Username">A username containing alphanumerical letters and -,._@+&#x3D; characters..</param>
        /// <param name="ActiveSessions">List of active user sessions..</param>
        /// <param name="LoginHistory">Timestamps, succeedings, IP addresses and user agent information of the last five logins of the user, with timestamps in RFC3339 format..</param>
        /// <param name="CreationTime">A timestamp of the user creation in the storage, in milliseconds..</param>
        /// <param name="UpdatedAt">Last update UTC time RFC3339..</param>
        /// <param name="FullName">The full name of the user..</param>
        /// <param name="Id">The UUID of the user. (required).</param>
        /// <param name="LastLoginTime">A timestamp of the latest login of the user, in milliseconds..</param>
        /// <param name="IsGtcAccepted">A flag indicating that the General Terms and Conditions has been accepted..</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="IsMarketingAccepted">A flag indicating that receiving marketing information has been accepted..</param>
        /// <param name="PhoneNumber">Phone number..</param>
        /// <param name="Email">The email address. (required).</param>
        /// <param name="Status">The status of the user. ENROLLING state indicates that the user is in the middle of the enrollment process. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. INACTIVE users are locked out and not permitted to use the system. (required).</param>
        /// <param name="AccountId">The UUID of the account. (required).</param>
        /// <param name="TotpScratchCodes">A list of scratch codes for the 2-factor authentication. Visible only when 2FA is requested to be enabled or the codes regenerated..</param>
        /// <param name="_Object">Entity name: always &#39;user&#39; (required).</param>
        /// <param name="Groups">A list of IDs of the groups this user belongs to..</param>
        /// <param name="Address">Address..</param>
        /// <param name="TotpSecret">Secret for the 2-factor authenticator app. Visible only when 2FA is requested to be enabled..</param>
        /// <param name="Password">The password when creating a new user. It will be generated when not present in the request..</param>
        /// <param name="EmailVerified">A flag indicating whether the user&#39;s email address has been verified or not..</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="UserProperties">User&#39;s account specific custom properties..</param>
        /// <param name="IsTotpEnabled">A flag indicating whether 2-factor authentication (TOTP) has been enabled..</param>
        /// <param name="PasswordChangedTime">A timestamp of the latest change of the user password, in milliseconds..</param>
        public UserUpdateResp(string Username = default(string), List<ActiveSession> ActiveSessions = default(List<ActiveSession>), List<LoginHistory> LoginHistory = default(List<LoginHistory>), long? CreationTime = default(long?), DateTime? UpdatedAt = default(DateTime?), string FullName = default(string), string Id = default(string), long? LastLoginTime = default(long?), bool? IsGtcAccepted = default(bool?), string Etag = default(string), bool? IsMarketingAccepted = default(bool?), string PhoneNumber = default(string), string Email = default(string), StatusEnum? Status = default(StatusEnum?), string AccountId = default(string), List<string> TotpScratchCodes = default(List<string>), ObjectEnum? _Object = default(ObjectEnum?), List<string> Groups = default(List<string>), string Address = default(string), string TotpSecret = default(string), string Password = default(string), bool? EmailVerified = default(bool?), DateTime? CreatedAt = default(DateTime?), Dictionary<string, Dictionary<string, string>> UserProperties = default(Dictionary<string, Dictionary<string, string>>), bool? IsTotpEnabled = default(bool?), long? PasswordChangedTime = default(long?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UserUpdateResp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for UserUpdateResp and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserUpdateResp and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for UserUpdateResp and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for UserUpdateResp and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for UserUpdateResp and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            this.Username = Username;
            this.ActiveSessions = ActiveSessions;
            this.LoginHistory = LoginHistory;
            this.CreationTime = CreationTime;
            this.UpdatedAt = UpdatedAt;
            this.FullName = FullName;
            this.LastLoginTime = LastLoginTime;
            this.IsGtcAccepted = IsGtcAccepted;
            this.IsMarketingAccepted = IsMarketingAccepted;
            this.PhoneNumber = PhoneNumber;
            this.TotpScratchCodes = TotpScratchCodes;
            this.Groups = Groups;
            this.Address = Address;
            this.TotpSecret = TotpSecret;
            this.Password = Password;
            this.EmailVerified = EmailVerified;
            this.CreatedAt = CreatedAt;
            this.UserProperties = UserProperties;
            this.IsTotpEnabled = IsTotpEnabled;
            this.PasswordChangedTime = PasswordChangedTime;
        }
        
        /// <summary>
        /// A username containing alphanumerical letters and -,._@+&#x3D; characters.
        /// </summary>
        /// <value>A username containing alphanumerical letters and -,._@+&#x3D; characters.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// List of active user sessions.
        /// </summary>
        /// <value>List of active user sessions.</value>
        [DataMember(Name="active_sessions", EmitDefaultValue=false)]
        public List<ActiveSession> ActiveSessions { get; set; }

        /// <summary>
        /// Timestamps, succeedings, IP addresses and user agent information of the last five logins of the user, with timestamps in RFC3339 format.
        /// </summary>
        /// <value>Timestamps, succeedings, IP addresses and user agent information of the last five logins of the user, with timestamps in RFC3339 format.</value>
        [DataMember(Name="login_history", EmitDefaultValue=false)]
        public List<LoginHistory> LoginHistory { get; set; }

        /// <summary>
        /// A timestamp of the user creation in the storage, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the user creation in the storage, in milliseconds.</value>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// Last update UTC time RFC3339.
        /// </summary>
        /// <value>Last update UTC time RFC3339.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The full name of the user.
        /// </summary>
        /// <value>The full name of the user.</value>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// The UUID of the user.
        /// </summary>
        /// <value>The UUID of the user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A timestamp of the latest login of the user, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the latest login of the user, in milliseconds.</value>
        [DataMember(Name="last_login_time", EmitDefaultValue=false)]
        public long? LastLoginTime { get; set; }

        /// <summary>
        /// A flag indicating that the General Terms and Conditions has been accepted.
        /// </summary>
        /// <value>A flag indicating that the General Terms and Conditions has been accepted.</value>
        [DataMember(Name="is_gtc_accepted", EmitDefaultValue=false)]
        public bool? IsGtcAccepted { get; set; }

        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// A flag indicating that receiving marketing information has been accepted.
        /// </summary>
        /// <value>A flag indicating that receiving marketing information has been accepted.</value>
        [DataMember(Name="is_marketing_accepted", EmitDefaultValue=false)]
        public bool? IsMarketingAccepted { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        /// <value>Phone number.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// The UUID of the account.
        /// </summary>
        /// <value>The UUID of the account.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// A list of scratch codes for the 2-factor authentication. Visible only when 2FA is requested to be enabled or the codes regenerated.
        /// </summary>
        /// <value>A list of scratch codes for the 2-factor authentication. Visible only when 2FA is requested to be enabled or the codes regenerated.</value>
        [DataMember(Name="totp_scratch_codes", EmitDefaultValue=false)]
        public List<string> TotpScratchCodes { get; set; }


        /// <summary>
        /// A list of IDs of the groups this user belongs to.
        /// </summary>
        /// <value>A list of IDs of the groups this user belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        /// <value>Address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Secret for the 2-factor authenticator app. Visible only when 2FA is requested to be enabled.
        /// </summary>
        /// <value>Secret for the 2-factor authenticator app. Visible only when 2FA is requested to be enabled.</value>
        [DataMember(Name="totp_secret", EmitDefaultValue=false)]
        public string TotpSecret { get; set; }

        /// <summary>
        /// The password when creating a new user. It will be generated when not present in the request.
        /// </summary>
        /// <value>The password when creating a new user. It will be generated when not present in the request.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// A flag indicating whether the user&#39;s email address has been verified or not.
        /// </summary>
        /// <value>A flag indicating whether the user&#39;s email address has been verified or not.</value>
        [DataMember(Name="email_verified", EmitDefaultValue=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// User&#39;s account specific custom properties.
        /// </summary>
        /// <value>User&#39;s account specific custom properties.</value>
        [DataMember(Name="user_properties", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> UserProperties { get; set; }

        /// <summary>
        /// A flag indicating whether 2-factor authentication (TOTP) has been enabled.
        /// </summary>
        /// <value>A flag indicating whether 2-factor authentication (TOTP) has been enabled.</value>
        [DataMember(Name="is_totp_enabled", EmitDefaultValue=false)]
        public bool? IsTotpEnabled { get; set; }

        /// <summary>
        /// A timestamp of the latest change of the user password, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the latest change of the user password, in milliseconds.</value>
        [DataMember(Name="password_changed_time", EmitDefaultValue=false)]
        public long? PasswordChangedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUpdateResp {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  ActiveSessions: ").Append(ActiveSessions).Append("\n");
            sb.Append("  LoginHistory: ").Append(LoginHistory).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
            sb.Append("  IsGtcAccepted: ").Append(IsGtcAccepted).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  IsMarketingAccepted: ").Append(IsMarketingAccepted).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  TotpScratchCodes: ").Append(TotpScratchCodes).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  TotpSecret: ").Append(TotpSecret).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  IsTotpEnabled: ").Append(IsTotpEnabled).Append("\n");
            sb.Append("  PasswordChangedTime: ").Append(PasswordChangedTime).Append("\n");
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
            return this.Equals(input as UserUpdateResp);
        }

        /// <summary>
        /// Returns true if UserUpdateResp instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUpdateResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUpdateResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.ActiveSessions == input.ActiveSessions ||
                    this.ActiveSessions != null &&
                    this.ActiveSessions.SequenceEqual(input.ActiveSessions)
                ) && 
                (
                    this.LoginHistory == input.LoginHistory ||
                    this.LoginHistory != null &&
                    this.LoginHistory.SequenceEqual(input.LoginHistory)
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastLoginTime == input.LastLoginTime ||
                    (this.LastLoginTime != null &&
                    this.LastLoginTime.Equals(input.LastLoginTime))
                ) && 
                (
                    this.IsGtcAccepted == input.IsGtcAccepted ||
                    (this.IsGtcAccepted != null &&
                    this.IsGtcAccepted.Equals(input.IsGtcAccepted))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.IsMarketingAccepted == input.IsMarketingAccepted ||
                    (this.IsMarketingAccepted != null &&
                    this.IsMarketingAccepted.Equals(input.IsMarketingAccepted))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.TotpScratchCodes == input.TotpScratchCodes ||
                    this.TotpScratchCodes != null &&
                    this.TotpScratchCodes.SequenceEqual(input.TotpScratchCodes)
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.TotpSecret == input.TotpSecret ||
                    (this.TotpSecret != null &&
                    this.TotpSecret.Equals(input.TotpSecret))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.EmailVerified == input.EmailVerified ||
                    (this.EmailVerified != null &&
                    this.EmailVerified.Equals(input.EmailVerified))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UserProperties == input.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(input.UserProperties)
                ) && 
                (
                    this.IsTotpEnabled == input.IsTotpEnabled ||
                    (this.IsTotpEnabled != null &&
                    this.IsTotpEnabled.Equals(input.IsTotpEnabled))
                ) && 
                (
                    this.PasswordChangedTime == input.PasswordChangedTime ||
                    (this.PasswordChangedTime != null &&
                    this.PasswordChangedTime.Equals(input.PasswordChangedTime))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.ActiveSessions != null)
                    hashCode = hashCode * 59 + this.ActiveSessions.GetHashCode();
                if (this.LoginHistory != null)
                    hashCode = hashCode * 59 + this.LoginHistory.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastLoginTime != null)
                    hashCode = hashCode * 59 + this.LastLoginTime.GetHashCode();
                if (this.IsGtcAccepted != null)
                    hashCode = hashCode * 59 + this.IsGtcAccepted.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.IsMarketingAccepted != null)
                    hashCode = hashCode * 59 + this.IsMarketingAccepted.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.TotpScratchCodes != null)
                    hashCode = hashCode * 59 + this.TotpScratchCodes.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.TotpSecret != null)
                    hashCode = hashCode * 59 + this.TotpSecret.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.EmailVerified != null)
                    hashCode = hashCode * 59 + this.EmailVerified.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                if (this.IsTotpEnabled != null)
                    hashCode = hashCode * 59 + this.IsTotpEnabled.GetHashCode();
                if (this.PasswordChangedTime != null)
                    hashCode = hashCode * 59 + this.PasswordChangedTime.GetHashCode();
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
