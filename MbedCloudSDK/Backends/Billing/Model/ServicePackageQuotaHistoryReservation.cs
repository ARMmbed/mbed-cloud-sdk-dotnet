/* 
 * <auto-generated>
 * billing REST API documentation
 *
 * This document contains the public REST API definitions of the mbed-billing service.
 *
 * OpenAPI spec version: 1.4.4
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
using SwaggerDateConverter = billing.Client.SwaggerDateConverter;

namespace billing.Model
{
    /// <summary>
    /// Service package quota history reservation object.
    /// </summary>
    [DataContract]
    public partial class ServicePackageQuotaHistoryReservation :  IEquatable<ServicePackageQuotaHistoryReservation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePackageQuotaHistoryReservation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServicePackageQuotaHistoryReservation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePackageQuotaHistoryReservation" /> class.
        /// </summary>
        /// <param name="AccountId">Account ID. (required).</param>
        /// <param name="CampaignName">Textual campaign name for this reservation. (required).</param>
        /// <param name="Id">Reservation id. (required).</param>
        public ServicePackageQuotaHistoryReservation(string AccountId = default(string), string CampaignName = default(string), string Id = default(string))
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for ServicePackageQuotaHistoryReservation and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "CampaignName" is required (not null)
            if (CampaignName == null)
            {
                throw new InvalidDataException("CampaignName is a required property for ServicePackageQuotaHistoryReservation and cannot be null");
            }
            else
            {
                this.CampaignName = CampaignName;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ServicePackageQuotaHistoryReservation and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
        }
        
        /// <summary>
        /// Account ID.
        /// </summary>
        /// <value>Account ID.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Textual campaign name for this reservation.
        /// </summary>
        /// <value>Textual campaign name for this reservation.</value>
        [DataMember(Name="campaign_name", EmitDefaultValue=false)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Reservation id.
        /// </summary>
        /// <value>Reservation id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePackageQuotaHistoryReservation {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServicePackageQuotaHistoryReservation);
        }

        /// <summary>
        /// Returns true if ServicePackageQuotaHistoryReservation instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicePackageQuotaHistoryReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePackageQuotaHistoryReservation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CampaignName == input.CampaignName ||
                    (this.CampaignName != null &&
                    this.CampaignName.Equals(input.CampaignName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CampaignName != null)
                    hashCode = hashCode * 59 + this.CampaignName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
            // AccountId (string) maxLength
            if(this.AccountId != null && this.AccountId.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be less than 250.", new [] { "AccountId" });
            }

            // AccountId (string) minLength
            if(this.AccountId != null && this.AccountId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be greater than 1.", new [] { "AccountId" });
            }

            // CampaignName (string) maxLength
            if(this.CampaignName != null && this.CampaignName.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignName, length must be less than 250.", new [] { "CampaignName" });
            }

            // CampaignName (string) minLength
            if(this.CampaignName != null && this.CampaignName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignName, length must be greater than 1.", new [] { "CampaignName" });
            }

            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 250.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
