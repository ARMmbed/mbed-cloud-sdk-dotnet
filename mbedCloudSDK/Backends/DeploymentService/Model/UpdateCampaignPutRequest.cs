/* 
 * Deployment Service API
 *
 * This is the API Documentation for the mbed deployment service which is part of the update service.
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

namespace deployment_service.Model
{
    /// <summary>
    /// UpdateCampaignPutRequest
    /// </summary>
    [DataContract]
    public partial class UpdateCampaignPutRequest :  IEquatable<UpdateCampaignPutRequest>, IValidatableObject
    {
        /// <summary>
        /// The state of the campaign.
        /// </summary>
        /// <value>The state of the campaign.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Draft for "draft"
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Devicefetch for "devicefetch"
            /// </summary>
            [EnumMember(Value = "devicefetch")]
            Devicefetch,
            
            /// <summary>
            /// Enum Devicecopy for "devicecopy"
            /// </summary>
            [EnumMember(Value = "devicecopy")]
            Devicecopy,
            
            /// <summary>
            /// Enum Devicecopycomplete for "devicecopycomplete"
            /// </summary>
            [EnumMember(Value = "devicecopycomplete")]
            Devicecopycomplete,
            
            /// <summary>
            /// Enum Publishing for "publishing"
            /// </summary>
            [EnumMember(Value = "publishing")]
            Publishing,
            
            /// <summary>
            /// Enum Deploying for "deploying"
            /// </summary>
            [EnumMember(Value = "deploying")]
            Deploying,
            
            /// <summary>
            /// Enum Deployed for "deployed"
            /// </summary>
            [EnumMember(Value = "deployed")]
            Deployed,
            
            /// <summary>
            /// Enum Manifestremoved for "manifestremoved"
            /// </summary>
            [EnumMember(Value = "manifestremoved")]
            Manifestremoved,
            
            /// <summary>
            /// Enum Expired for "expired"
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired
        }

        /// <summary>
        /// The state of the campaign.
        /// </summary>
        /// <value>The state of the campaign.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignPutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCampaignPutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignPutRequest" /> class.
        /// </summary>
        /// <param name="Description">An optional description of the campaign. (required).</param>
        /// <param name="RootManifestId">RootManifestId (required).</param>
        /// <param name="_Object">The API resource entity. (required).</param>
        /// <param name="When">The timestamp at which update campaign scheduled to start. (required).</param>
        /// <param name="State">The state of the campaign. (required).</param>
        /// <param name="DeviceFilter">The filter for the devices the campaign will target. (required).</param>
        /// <param name="Name">A name for this campaign. (required).</param>
        public UpdateCampaignPutRequest(string Description = default(string), string RootManifestId = default(string), string _Object = default(string), string When = default(string), StateEnum? State = default(StateEnum?), string DeviceFilter = default(string), string Name = default(string))
        {
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "RootManifestId" is required (not null)
            if (RootManifestId == null)
            {
                throw new InvalidDataException("RootManifestId is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this.RootManifestId = RootManifestId;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "When" is required (not null)
            if (When == null)
            {
                throw new InvalidDataException("When is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this.When = When;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "DeviceFilter" is required (not null)
            if (DeviceFilter == null)
            {
                throw new InvalidDataException("DeviceFilter is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this.DeviceFilter = DeviceFilter;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UpdateCampaignPutRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }
        
        /// <summary>
        /// An optional description of the campaign.
        /// </summary>
        /// <value>An optional description of the campaign.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets RootManifestId
        /// </summary>
        [DataMember(Name="root_manifest_id", EmitDefaultValue=false)]
        public string RootManifestId { get; set; }
        /// <summary>
        /// The API resource entity.
        /// </summary>
        /// <value>The API resource entity.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// The timestamp at which update campaign scheduled to start.
        /// </summary>
        /// <value>The timestamp at which update campaign scheduled to start.</value>
        [DataMember(Name="when", EmitDefaultValue=false)]
        public string When { get; set; }
        /// <summary>
        /// The filter for the devices the campaign will target.
        /// </summary>
        /// <value>The filter for the devices the campaign will target.</value>
        [DataMember(Name="device_filter", EmitDefaultValue=false)]
        public string DeviceFilter { get; set; }
        /// <summary>
        /// A name for this campaign.
        /// </summary>
        /// <value>A name for this campaign.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCampaignPutRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RootManifestId: ").Append(RootManifestId).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DeviceFilter: ").Append(DeviceFilter).Append("\n");
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
            return this.Equals(obj as UpdateCampaignPutRequest);
        }

        /// <summary>
        /// Returns true if UpdateCampaignPutRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCampaignPutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCampaignPutRequest other)
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
                    this.RootManifestId == other.RootManifestId ||
                    this.RootManifestId != null &&
                    this.RootManifestId.Equals(other.RootManifestId)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.When == other.When ||
                    this.When != null &&
                    this.When.Equals(other.When)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.DeviceFilter == other.DeviceFilter ||
                    this.DeviceFilter != null &&
                    this.DeviceFilter.Equals(other.DeviceFilter)
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
                if (this.RootManifestId != null)
                    hash = hash * 59 + this.RootManifestId.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.When != null)
                    hash = hash * 59 + this.When.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.DeviceFilter != null)
                    hash = hash * 59 + this.DeviceFilter.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // RootManifestId (string) maxLength
            if(this.RootManifestId != null && this.RootManifestId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for RootManifestId, length must be less than 32.", new [] { "RootManifestId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

}
