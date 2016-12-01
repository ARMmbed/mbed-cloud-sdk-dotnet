/* 
 * Deployment Service API
 *
 * This is the API Documentation for the mbed deployment service which is part of the update service.
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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

namespace deployment_service.Model
{
    /// <summary>
    /// CampaignDeviceMetadataSerializer
    /// </summary>
    [DataContract]
    public partial class CampaignDeviceMetadataSerializer :  IEquatable<CampaignDeviceMetadataSerializer>
    {
        /// <summary>
        /// The state of the deployment
        /// </summary>
        /// <value>The state of the deployment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeploymentStateEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Updateddevicecatalog for "updated_device_catalog"
            /// </summary>
            [EnumMember(Value = "updated_device_catalog")]
            Updateddevicecatalog,
            
            /// <summary>
            /// Enum Updatedconnectorchannel for "updated_connector_channel"
            /// </summary>
            [EnumMember(Value = "updated_connector_channel")]
            Updatedconnectorchannel,
            
            /// <summary>
            /// Enum Deployed for "deployed"
            /// </summary>
            [EnumMember(Value = "deployed")]
            Deployed,
            
            /// <summary>
            /// Enum Manifestremoved for "manifestremoved"
            /// </summary>
            [EnumMember(Value = "manifestremoved")]
            Manifestremoved
        }

        /// <summary>
        /// The state of the deployment
        /// </summary>
        /// <value>The state of the deployment</value>
        [DataMember(Name="deployment_state", EmitDefaultValue=false)]
        public DeploymentStateEnum? DeploymentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDeviceMetadataSerializer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignDeviceMetadataSerializer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDeviceMetadataSerializer" /> class.
        /// </summary>
        /// <param name="Description">The description of the object (required).</param>
        /// <param name="Campaign">The update campaign to which this device belongs (required).</param>
        /// <param name="CreatedAt">The time the object was created (required).</param>
        /// <param name="_Object">The API resource entity (required).</param>
        /// <param name="UpdatedAt">The time the object was updated (required).</param>
        /// <param name="Mechanism">The ID of the channel used to communicated with the device (required).</param>
        /// <param name="Name">The name of the object (required).</param>
        /// <param name="Etag">The entity instance signature (required).</param>
        /// <param name="MechanismUrl">The address of the Connector to use (required).</param>
        /// <param name="DeploymentState">The state of the deployment (required).</param>
        /// <param name="Id">The ID of the metadata concerning this device/campaign (required).</param>
        /// <param name="DeviceId">The ID of the device to deploy (required).</param>
        public CampaignDeviceMetadataSerializer(string Description = null, string Campaign = null, DateTime? CreatedAt = null, string _Object = null, DateTime? UpdatedAt = null, string Mechanism = null, string Name = null, DateTime? Etag = null, string MechanismUrl = null, DeploymentStateEnum? DeploymentState = null, string Id = null, string DeviceId = null)
        {
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Campaign" is required (not null)
            if (Campaign == null)
            {
                throw new InvalidDataException("Campaign is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.Campaign = Campaign;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "Mechanism" is required (not null)
            if (Mechanism == null)
            {
                throw new InvalidDataException("Mechanism is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.Mechanism = Mechanism;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "MechanismUrl" is required (not null)
            if (MechanismUrl == null)
            {
                throw new InvalidDataException("MechanismUrl is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.MechanismUrl = MechanismUrl;
            }
            // to ensure "DeploymentState" is required (not null)
            if (DeploymentState == null)
            {
                throw new InvalidDataException("DeploymentState is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.DeploymentState = DeploymentState;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "DeviceId" is required (not null)
            if (DeviceId == null)
            {
                throw new InvalidDataException("DeviceId is a required property for CampaignDeviceMetadataSerializer and cannot be null");
            }
            else
            {
                this.DeviceId = DeviceId;
            }
        }
        
        /// <summary>
        /// The description of the object
        /// </summary>
        /// <value>The description of the object</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The update campaign to which this device belongs
        /// </summary>
        /// <value>The update campaign to which this device belongs</value>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public string Campaign { get; set; }
        /// <summary>
        /// The time the object was created
        /// </summary>
        /// <value>The time the object was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// The API resource entity
        /// </summary>
        /// <value>The API resource entity</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// The time the object was updated
        /// </summary>
        /// <value>The time the object was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// The ID of the channel used to communicated with the device
        /// </summary>
        /// <value>The ID of the channel used to communicated with the device</value>
        [DataMember(Name="mechanism", EmitDefaultValue=false)]
        public string Mechanism { get; set; }
        /// <summary>
        /// The name of the object
        /// </summary>
        /// <value>The name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The entity instance signature
        /// </summary>
        /// <value>The entity instance signature</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }
        /// <summary>
        /// The address of the Connector to use
        /// </summary>
        /// <value>The address of the Connector to use</value>
        [DataMember(Name="mechanism_url", EmitDefaultValue=false)]
        public string MechanismUrl { get; set; }
        /// <summary>
        /// The ID of the metadata concerning this device/campaign
        /// </summary>
        /// <value>The ID of the metadata concerning this device/campaign</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the device to deploy
        /// </summary>
        /// <value>The ID of the device to deploy</value>
        [DataMember(Name="device_id", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignDeviceMetadataSerializer {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  MechanismUrl: ").Append(MechanismUrl).Append("\n");
            sb.Append("  DeploymentState: ").Append(DeploymentState).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(obj as CampaignDeviceMetadataSerializer);
        }

        /// <summary>
        /// Returns true if CampaignDeviceMetadataSerializer instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignDeviceMetadataSerializer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDeviceMetadataSerializer other)
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
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
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
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Mechanism == other.Mechanism ||
                    this.Mechanism != null &&
                    this.Mechanism.Equals(other.Mechanism)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.MechanismUrl == other.MechanismUrl ||
                    this.MechanismUrl != null &&
                    this.MechanismUrl.Equals(other.MechanismUrl)
                ) && 
                (
                    this.DeploymentState == other.DeploymentState ||
                    this.DeploymentState != null &&
                    this.DeploymentState.Equals(other.DeploymentState)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
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
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.Mechanism != null)
                    hash = hash * 59 + this.Mechanism.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.MechanismUrl != null)
                    hash = hash * 59 + this.MechanismUrl.GetHashCode();
                if (this.DeploymentState != null)
                    hash = hash * 59 + this.DeploymentState.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                return hash;
            }
        }
    }

}
