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
    /// This object represents an account creation response.
    /// </summary>
    [DataContract]
    public partial class AccountCreationResp :  IEquatable<AccountCreationResp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreationResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountCreationResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreationResp" /> class.
        /// </summary>
        /// <param name="AddressLine1">Postal address line 1, not longer than 100 characters. Required for commercial accounts only..</param>
        /// <param name="AddressLine2">Postal address line 2, not longer than 100 characters..</param>
        /// <param name="AdminEmail">The email address of the account admin, not longer than 254 characters..</param>
        /// <param name="AdminFullName">The full name of the admin user to be created..</param>
        /// <param name="AdminId">The ID of the admin user created. (required).</param>
        /// <param name="AdminKey">The admin API key created for the account..</param>
        /// <param name="AdminName">The username of the admin user to be created, containing alphanumerical letters and -,._@+&#x3D; characters. It must be at least 4 but not more than 30 character long..</param>
        /// <param name="AdminPassword">The password when creating a new user. It will be generated when not present in the request..</param>
        /// <param name="Aliases">An array of aliases, not more than 10. An alias is not shorter than 8 and not longer than 100 characters..</param>
        /// <param name="City">The city part of the postal address, not longer than 100 characters. Required for commercial accounts only..</param>
        /// <param name="Company">The name of the company, not longer than 100 characters. Required for commercial accounts only..</param>
        /// <param name="Contact">The name of the contact person for this account, not longer than 100 characters. Required for commercial accounts only..</param>
        /// <param name="ContractNumber">Contract number of the customer..</param>
        /// <param name="Country">The country part of the postal address, not longer than 100 characters. Required for commercial accounts only..</param>
        /// <param name="CustomerNumber">Customer number of the customer..</param>
        /// <param name="DisplayName">The display name for the account, not longer than 100 characters..</param>
        /// <param name="Email">The company email address for this account, not longer than 254 characters. Required for commercial accounts only..</param>
        /// <param name="EndMarket">The end market of the account to be created. (required).</param>
        /// <param name="Id">Account ID. (required).</param>
        /// <param name="PhoneNumber">The phone number of a representative of the company, not longer than 100 characters..</param>
        /// <param name="PostalCode">The postal code part of the postal address, not longer than 100 characters..</param>
        /// <param name="State">The state part of the postal address, not longer than 100 characters..</param>
        public AccountCreationResp(string AddressLine1 = default(string), string AddressLine2 = default(string), string AdminEmail = default(string), string AdminFullName = default(string), string AdminId = default(string), string AdminKey = default(string), string AdminName = default(string), string AdminPassword = default(string), List<string> Aliases = default(List<string>), string City = default(string), string Company = default(string), string Contact = default(string), string ContractNumber = default(string), string Country = default(string), string CustomerNumber = default(string), string DisplayName = default(string), string Email = default(string), string EndMarket = default(string), string Id = default(string), string PhoneNumber = default(string), string PostalCode = default(string), string State = default(string))
        {
            // to ensure "AdminId" is required (not null)
            if (AdminId == null)
            {
                throw new InvalidDataException("AdminId is a required property for AccountCreationResp and cannot be null");
            }
            else
            {
                this.AdminId = AdminId;
            }
            // to ensure "EndMarket" is required (not null)
            if (EndMarket == null)
            {
                throw new InvalidDataException("EndMarket is a required property for AccountCreationResp and cannot be null");
            }
            else
            {
                this.EndMarket = EndMarket;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for AccountCreationResp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.AdminEmail = AdminEmail;
            this.AdminFullName = AdminFullName;
            this.AdminKey = AdminKey;
            this.AdminName = AdminName;
            this.AdminPassword = AdminPassword;
            this.Aliases = Aliases;
            this.City = City;
            this.Company = Company;
            this.Contact = Contact;
            this.ContractNumber = ContractNumber;
            this.Country = Country;
            this.CustomerNumber = CustomerNumber;
            this.DisplayName = DisplayName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.PostalCode = PostalCode;
            this.State = State;
        }
        
        /// <summary>
        /// Postal address line 1, not longer than 100 characters. Required for commercial accounts only.
        /// </summary>
        /// <value>Postal address line 1, not longer than 100 characters. Required for commercial accounts only.</value>
        [DataMember(Name="address_line1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Postal address line 2, not longer than 100 characters.
        /// </summary>
        /// <value>Postal address line 2, not longer than 100 characters.</value>
        [DataMember(Name="address_line2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The email address of the account admin, not longer than 254 characters.
        /// </summary>
        /// <value>The email address of the account admin, not longer than 254 characters.</value>
        [DataMember(Name="admin_email", EmitDefaultValue=false)]
        public string AdminEmail { get; set; }

        /// <summary>
        /// The full name of the admin user to be created.
        /// </summary>
        /// <value>The full name of the admin user to be created.</value>
        [DataMember(Name="admin_full_name", EmitDefaultValue=false)]
        public string AdminFullName { get; set; }

        /// <summary>
        /// The ID of the admin user created.
        /// </summary>
        /// <value>The ID of the admin user created.</value>
        [DataMember(Name="admin_id", EmitDefaultValue=false)]
        public string AdminId { get; set; }

        /// <summary>
        /// The admin API key created for the account.
        /// </summary>
        /// <value>The admin API key created for the account.</value>
        [DataMember(Name="admin_key", EmitDefaultValue=false)]
        public string AdminKey { get; set; }

        /// <summary>
        /// The username of the admin user to be created, containing alphanumerical letters and -,._@+&#x3D; characters. It must be at least 4 but not more than 30 character long.
        /// </summary>
        /// <value>The username of the admin user to be created, containing alphanumerical letters and -,._@+&#x3D; characters. It must be at least 4 but not more than 30 character long.</value>
        [DataMember(Name="admin_name", EmitDefaultValue=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// The password when creating a new user. It will be generated when not present in the request.
        /// </summary>
        /// <value>The password when creating a new user. It will be generated when not present in the request.</value>
        [DataMember(Name="admin_password", EmitDefaultValue=false)]
        public string AdminPassword { get; set; }

        /// <summary>
        /// An array of aliases, not more than 10. An alias is not shorter than 8 and not longer than 100 characters.
        /// </summary>
        /// <value>An array of aliases, not more than 10. An alias is not shorter than 8 and not longer than 100 characters.</value>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public List<string> Aliases { get; set; }

        /// <summary>
        /// The city part of the postal address, not longer than 100 characters. Required for commercial accounts only.
        /// </summary>
        /// <value>The city part of the postal address, not longer than 100 characters. Required for commercial accounts only.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The name of the company, not longer than 100 characters. Required for commercial accounts only.
        /// </summary>
        /// <value>The name of the company, not longer than 100 characters. Required for commercial accounts only.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// The name of the contact person for this account, not longer than 100 characters. Required for commercial accounts only.
        /// </summary>
        /// <value>The name of the contact person for this account, not longer than 100 characters. Required for commercial accounts only.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Contract number of the customer.
        /// </summary>
        /// <value>Contract number of the customer.</value>
        [DataMember(Name="contract_number", EmitDefaultValue=false)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// The country part of the postal address, not longer than 100 characters. Required for commercial accounts only.
        /// </summary>
        /// <value>The country part of the postal address, not longer than 100 characters. Required for commercial accounts only.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Customer number of the customer.
        /// </summary>
        /// <value>Customer number of the customer.</value>
        [DataMember(Name="customer_number", EmitDefaultValue=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// The display name for the account, not longer than 100 characters.
        /// </summary>
        /// <value>The display name for the account, not longer than 100 characters.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The company email address for this account, not longer than 254 characters. Required for commercial accounts only.
        /// </summary>
        /// <value>The company email address for this account, not longer than 254 characters. Required for commercial accounts only.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The end market of the account to be created.
        /// </summary>
        /// <value>The end market of the account to be created.</value>
        [DataMember(Name="end_market", EmitDefaultValue=false)]
        public string EndMarket { get; set; }

        /// <summary>
        /// Account ID.
        /// </summary>
        /// <value>Account ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The phone number of a representative of the company, not longer than 100 characters.
        /// </summary>
        /// <value>The phone number of a representative of the company, not longer than 100 characters.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The postal code part of the postal address, not longer than 100 characters.
        /// </summary>
        /// <value>The postal code part of the postal address, not longer than 100 characters.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state part of the postal address, not longer than 100 characters.
        /// </summary>
        /// <value>The state part of the postal address, not longer than 100 characters.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCreationResp {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AdminEmail: ").Append(AdminEmail).Append("\n");
            sb.Append("  AdminFullName: ").Append(AdminFullName).Append("\n");
            sb.Append("  AdminId: ").Append(AdminId).Append("\n");
            sb.Append("  AdminKey: ").Append(AdminKey).Append("\n");
            sb.Append("  AdminName: ").Append(AdminName).Append("\n");
            sb.Append("  AdminPassword: ").Append(AdminPassword).Append("\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EndMarket: ").Append(EndMarket).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as AccountCreationResp);
        }

        /// <summary>
        /// Returns true if AccountCreationResp instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCreationResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCreationResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AdminEmail == input.AdminEmail ||
                    (this.AdminEmail != null &&
                    this.AdminEmail.Equals(input.AdminEmail))
                ) && 
                (
                    this.AdminFullName == input.AdminFullName ||
                    (this.AdminFullName != null &&
                    this.AdminFullName.Equals(input.AdminFullName))
                ) && 
                (
                    this.AdminId == input.AdminId ||
                    (this.AdminId != null &&
                    this.AdminId.Equals(input.AdminId))
                ) && 
                (
                    this.AdminKey == input.AdminKey ||
                    (this.AdminKey != null &&
                    this.AdminKey.Equals(input.AdminKey))
                ) && 
                (
                    this.AdminName == input.AdminName ||
                    (this.AdminName != null &&
                    this.AdminName.Equals(input.AdminName))
                ) && 
                (
                    this.AdminPassword == input.AdminPassword ||
                    (this.AdminPassword != null &&
                    this.AdminPassword.Equals(input.AdminPassword))
                ) && 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CustomerNumber == input.CustomerNumber ||
                    (this.CustomerNumber != null &&
                    this.CustomerNumber.Equals(input.CustomerNumber))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EndMarket == input.EndMarket ||
                    (this.EndMarket != null &&
                    this.EndMarket.Equals(input.EndMarket))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AdminEmail != null)
                    hashCode = hashCode * 59 + this.AdminEmail.GetHashCode();
                if (this.AdminFullName != null)
                    hashCode = hashCode * 59 + this.AdminFullName.GetHashCode();
                if (this.AdminId != null)
                    hashCode = hashCode * 59 + this.AdminId.GetHashCode();
                if (this.AdminKey != null)
                    hashCode = hashCode * 59 + this.AdminKey.GetHashCode();
                if (this.AdminName != null)
                    hashCode = hashCode * 59 + this.AdminName.GetHashCode();
                if (this.AdminPassword != null)
                    hashCode = hashCode * 59 + this.AdminPassword.GetHashCode();
                if (this.Aliases != null)
                    hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.ContractNumber != null)
                    hashCode = hashCode * 59 + this.ContractNumber.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CustomerNumber != null)
                    hashCode = hashCode * 59 + this.CustomerNumber.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EndMarket != null)
                    hashCode = hashCode * 59 + this.EndMarket.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
