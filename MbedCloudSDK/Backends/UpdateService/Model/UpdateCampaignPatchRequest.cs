/* 
 * <auto-generated>
 * Update Service API
 *
 * This is the API documentation for the Mbed deployment service, which is part of the update service.
 *
 * OpenAPI spec version: 3
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

namespace update_service.Model
{
    /// <summary>
    /// UpdateCampaignPatchRequest
    /// </summary>
    [DataContract]
    public partial class UpdateCampaignPatchRequest :  IEquatable<UpdateCampaignPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
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
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignPatchRequest" /> class.
        /// </summary>
        /// <param name="Description">The optional description of the campaign.</param>
        /// <param name="RootManifestId">RootManifestId.</param>
        /// <param name="_Object">The API resource entity.</param>
        /// <param name="When">The scheduled start time for the update campaign.</param>
        /// <param name="State">The state of the campaign.</param>
        /// <param name="DeviceFilter">The filter for the devices the campaign will target.</param>
        /// <param name="Name">The campaign name.</param>
        public UpdateCampaignPatchRequest(string Description = default(string), string RootManifestId = default(string), string _Object = default(string), DateTime? When = default(DateTime?), StateEnum? State = default(StateEnum?), string DeviceFilter = default(string), string Name = default(string))
        {
            this.Description = Description;
            this.RootManifestId = RootManifestId;
            this._Object = _Object;
            this.When = When;
            this.State = State;
            this.DeviceFilter = DeviceFilter;
            this.Name = Name;
        }
        
        /// <summary>
        /// The optional description of the campaign
        /// </summary>
        /// <value>The optional description of the campaign</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets RootManifestId
        /// </summary>
        [DataMember(Name="root_manifest_id", EmitDefaultValue=false)]
        public string RootManifestId { get; set; }
        /// <summary>
        /// The API resource entity
        /// </summary>
        /// <value>The API resource entity</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// The scheduled start time for the update campaign
        /// </summary>
        /// <value>The scheduled start time for the update campaign</value>
        [DataMember(Name="when", EmitDefaultValue=false)]
        public DateTime? When { get; set; }
        /// <summary>
        /// The filter for the devices the campaign will target
        /// </summary>
        /// <value>The filter for the devices the campaign will target</value>
        [DataMember(Name="device_filter", EmitDefaultValue=false)]
        public string DeviceFilter { get; set; }
        /// <summary>
        /// The campaign name
        /// </summary>
        /// <value>The campaign name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCampaignPatchRequest {\n");
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
            return this.Equals(obj as UpdateCampaignPatchRequest);
        }

        /// <summary>
        /// Returns true if UpdateCampaignPatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCampaignPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCampaignPatchRequest other)
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 2000.", new [] { "Description" });
            }

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
