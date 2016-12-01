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
    /// 
    /// </summary>
    [DataContract]
    public partial class UpdateCampaignStatusSerializer :  IEquatable<UpdateCampaignStatusSerializer>
    { 
    
        /// <summary>
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum {
            
            [EnumMember(Value = "draft")]
            Draft,
            
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            [EnumMember(Value = "devicefetch")]
            Devicefetch,
            
            [EnumMember(Value = "devicecopy")]
            Devicecopy,
            
            [EnumMember(Value = "devicecopycomplete")]
            Devicecopycomplete,
            
            [EnumMember(Value = "publishing")]
            Publishing,
            
            [EnumMember(Value = "deploying")]
            Deploying,
            
            [EnumMember(Value = "deployed")]
            Deployed,
            
            [EnumMember(Value = "manifestremoved")]
            Manifestremoved,
            
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
        /// Initializes a new instance of the <see cref="UpdateCampaignStatusSerializer" /> class.
        /// Initializes a new instance of the <see cref="UpdateCampaignStatusSerializer" />class.
        /// </summary>
        /// <param name="DirectDevices">DirectDevices (required).</param>
        /// <param name="ConnectorDevices">ConnectorDevices (required).</param>
        /// <param name="Description">An optional description of the campaign (required).</param>
        /// <param name="State">The state of the campaign (required).</param>
        /// <param name="UpdatingUserId">The updating IAM user ID (required).</param>
        /// <param name="CreatedAt">The time the object was created (required).</param>
        /// <param name="TotalDevices">TotalDevices (required).</param>
        /// <param name="CampaigndevicemetadataSet">CampaigndevicemetadataSet (required).</param>
        /// <param name="CampaignId">DEPRECATED: The ID of the campaign (required).</param>
        /// <param name="DeployedDevices">DeployedDevices (required).</param>
        /// <param name="UpdatedAt">The time the object was updated (required).</param>
        /// <param name="When">The timestamp at which campaign is scheduled to start (required).</param>
        /// <param name="Finished">The timestamp when the update campaign finished (required).</param>
        /// <param name="RootManifestUrl">RootManifestUrl (required).</param>
        /// <param name="UpdatingApiKey">The gateway client API key (required).</param>
        /// <param name="UpdatingAccountId">The updating account ID (required).</param>
        /// <param name="DeviceFilter">The filter for the devices the campaign will target (required).</param>
        /// <param name="Name">A name for this campaign (required).</param>

        public UpdateCampaignStatusSerializer(string DirectDevices = null, string ConnectorDevices = null, string Description = null, StateEnum? State = null, string UpdatingUserId = null, DateTime? CreatedAt = null, string TotalDevices = null, List<CampaignDeviceMetadataSerializer> CampaigndevicemetadataSet = null, string CampaignId = null, string DeployedDevices = null, DateTime? UpdatedAt = null, DateTime? When = null, DateTime? Finished = null, string RootManifestUrl = null, string UpdatingApiKey = null, string UpdatingAccountId = null, string DeviceFilter = null, string Name = null)
        {
            // to ensure "DirectDevices" is required (not null)
            if (DirectDevices == null)
            {
                throw new InvalidDataException("DirectDevices is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.DirectDevices = DirectDevices;
            }
            // to ensure "ConnectorDevices" is required (not null)
            if (ConnectorDevices == null)
            {
                throw new InvalidDataException("ConnectorDevices is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.ConnectorDevices = ConnectorDevices;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "UpdatingUserId" is required (not null)
            if (UpdatingUserId == null)
            {
                throw new InvalidDataException("UpdatingUserId is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.UpdatingUserId = UpdatingUserId;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "TotalDevices" is required (not null)
            if (TotalDevices == null)
            {
                throw new InvalidDataException("TotalDevices is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.TotalDevices = TotalDevices;
            }
            // to ensure "CampaigndevicemetadataSet" is required (not null)
            if (CampaigndevicemetadataSet == null)
            {
                throw new InvalidDataException("CampaigndevicemetadataSet is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.CampaigndevicemetadataSet = CampaigndevicemetadataSet;
            }
            // to ensure "CampaignId" is required (not null)
            if (CampaignId == null)
            {
                throw new InvalidDataException("CampaignId is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.CampaignId = CampaignId;
            }
            // to ensure "DeployedDevices" is required (not null)
            if (DeployedDevices == null)
            {
                throw new InvalidDataException("DeployedDevices is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.DeployedDevices = DeployedDevices;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "When" is required (not null)
            if (When == null)
            {
                throw new InvalidDataException("When is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.When = When;
            }
            // to ensure "Finished" is required (not null)
            if (Finished == null)
            {
                throw new InvalidDataException("Finished is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.Finished = Finished;
            }
            // to ensure "RootManifestUrl" is required (not null)
            if (RootManifestUrl == null)
            {
                throw new InvalidDataException("RootManifestUrl is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.RootManifestUrl = RootManifestUrl;
            }
            // to ensure "UpdatingApiKey" is required (not null)
            if (UpdatingApiKey == null)
            {
                throw new InvalidDataException("UpdatingApiKey is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.UpdatingApiKey = UpdatingApiKey;
            }
            // to ensure "UpdatingAccountId" is required (not null)
            if (UpdatingAccountId == null)
            {
                throw new InvalidDataException("UpdatingAccountId is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.UpdatingAccountId = UpdatingAccountId;
            }
            // to ensure "DeviceFilter" is required (not null)
            if (DeviceFilter == null)
            {
                throw new InvalidDataException("DeviceFilter is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.DeviceFilter = DeviceFilter;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UpdateCampaignStatusSerializer and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets DirectDevices
        /// </summary>
        [DataMember(Name="direct_devices", EmitDefaultValue=false)]
        public string DirectDevices { get; set; }
    
        /// <summary>
        /// Gets or Sets ConnectorDevices
        /// </summary>
        [DataMember(Name="connector_devices", EmitDefaultValue=false)]
        public string ConnectorDevices { get; set; }
    
        /// <summary>
        /// An optional description of the campaign
        /// </summary>
        /// <value>An optional description of the campaign</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// The updating IAM user ID
        /// </summary>
        /// <value>The updating IAM user ID</value>
        [DataMember(Name="updating_user_id", EmitDefaultValue=false)]
        public string UpdatingUserId { get; set; }
    
        /// <summary>
        /// The time the object was created
        /// </summary>
        /// <value>The time the object was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalDevices
        /// </summary>
        [DataMember(Name="total_devices", EmitDefaultValue=false)]
        public string TotalDevices { get; set; }
    
        /// <summary>
        /// Gets or Sets CampaigndevicemetadataSet
        /// </summary>
        [DataMember(Name="campaigndevicemetadata_set", EmitDefaultValue=false)]
        public List<CampaignDeviceMetadataSerializer> CampaigndevicemetadataSet { get; set; }
    
        /// <summary>
        /// DEPRECATED: The ID of the campaign
        /// </summary>
        /// <value>DEPRECATED: The ID of the campaign</value>
        [DataMember(Name="campaign_id", EmitDefaultValue=false)]
        public string CampaignId { get; set; }
    
        /// <summary>
        /// Gets or Sets DeployedDevices
        /// </summary>
        [DataMember(Name="deployed_devices", EmitDefaultValue=false)]
        public string DeployedDevices { get; set; }
    
        /// <summary>
        /// The time the object was updated
        /// </summary>
        /// <value>The time the object was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
    
        /// <summary>
        /// The timestamp at which campaign is scheduled to start
        /// </summary>
        /// <value>The timestamp at which campaign is scheduled to start</value>
        [DataMember(Name="when", EmitDefaultValue=false)]
        public DateTime? When { get; set; }
    
        /// <summary>
        /// The timestamp when the update campaign finished
        /// </summary>
        /// <value>The timestamp when the update campaign finished</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public DateTime? Finished { get; set; }
    
        /// <summary>
        /// Gets or Sets RootManifestUrl
        /// </summary>
        [DataMember(Name="root_manifest_url", EmitDefaultValue=false)]
        public string RootManifestUrl { get; set; }
    
        /// <summary>
        /// The gateway client API key
        /// </summary>
        /// <value>The gateway client API key</value>
        [DataMember(Name="updating_api_key", EmitDefaultValue=false)]
        public string UpdatingApiKey { get; set; }
    
        /// <summary>
        /// The updating account ID
        /// </summary>
        /// <value>The updating account ID</value>
        [DataMember(Name="updating_account_id", EmitDefaultValue=false)]
        public string UpdatingAccountId { get; set; }
    
        /// <summary>
        /// The filter for the devices the campaign will target
        /// </summary>
        /// <value>The filter for the devices the campaign will target</value>
        [DataMember(Name="device_filter", EmitDefaultValue=false)]
        public string DeviceFilter { get; set; }
    
        /// <summary>
        /// A name for this campaign
        /// </summary>
        /// <value>A name for this campaign</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCampaignStatusSerializer {\n");
            sb.Append("  DirectDevices: ").Append(DirectDevices).Append("\n");
            sb.Append("  ConnectorDevices: ").Append(ConnectorDevices).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UpdatingUserId: ").Append(UpdatingUserId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  TotalDevices: ").Append(TotalDevices).Append("\n");
            sb.Append("  CampaigndevicemetadataSet: ").Append(CampaigndevicemetadataSet).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  DeployedDevices: ").Append(DeployedDevices).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  RootManifestUrl: ").Append(RootManifestUrl).Append("\n");
            sb.Append("  UpdatingApiKey: ").Append(UpdatingApiKey).Append("\n");
            sb.Append("  UpdatingAccountId: ").Append(UpdatingAccountId).Append("\n");
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
            return this.Equals(obj as UpdateCampaignStatusSerializer);
        }

        /// <summary>
        /// Returns true if UpdateCampaignStatusSerializer instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCampaignStatusSerializer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCampaignStatusSerializer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DirectDevices == other.DirectDevices ||
                    this.DirectDevices != null &&
                    this.DirectDevices.Equals(other.DirectDevices)
                ) && 
                (
                    this.ConnectorDevices == other.ConnectorDevices ||
                    this.ConnectorDevices != null &&
                    this.ConnectorDevices.Equals(other.ConnectorDevices)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.UpdatingUserId == other.UpdatingUserId ||
                    this.UpdatingUserId != null &&
                    this.UpdatingUserId.Equals(other.UpdatingUserId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.TotalDevices == other.TotalDevices ||
                    this.TotalDevices != null &&
                    this.TotalDevices.Equals(other.TotalDevices)
                ) && 
                (
                    this.CampaigndevicemetadataSet == other.CampaigndevicemetadataSet ||
                    this.CampaigndevicemetadataSet != null &&
                    this.CampaigndevicemetadataSet.SequenceEqual(other.CampaigndevicemetadataSet)
                ) && 
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) && 
                (
                    this.DeployedDevices == other.DeployedDevices ||
                    this.DeployedDevices != null &&
                    this.DeployedDevices.Equals(other.DeployedDevices)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.When == other.When ||
                    this.When != null &&
                    this.When.Equals(other.When)
                ) && 
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
                ) && 
                (
                    this.RootManifestUrl == other.RootManifestUrl ||
                    this.RootManifestUrl != null &&
                    this.RootManifestUrl.Equals(other.RootManifestUrl)
                ) && 
                (
                    this.UpdatingApiKey == other.UpdatingApiKey ||
                    this.UpdatingApiKey != null &&
                    this.UpdatingApiKey.Equals(other.UpdatingApiKey)
                ) && 
                (
                    this.UpdatingAccountId == other.UpdatingAccountId ||
                    this.UpdatingAccountId != null &&
                    this.UpdatingAccountId.Equals(other.UpdatingAccountId)
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
                
                if (this.DirectDevices != null)
                    hash = hash * 59 + this.DirectDevices.GetHashCode();
                
                if (this.ConnectorDevices != null)
                    hash = hash * 59 + this.ConnectorDevices.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.UpdatingUserId != null)
                    hash = hash * 59 + this.UpdatingUserId.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.TotalDevices != null)
                    hash = hash * 59 + this.TotalDevices.GetHashCode();
                
                if (this.CampaigndevicemetadataSet != null)
                    hash = hash * 59 + this.CampaigndevicemetadataSet.GetHashCode();
                
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();
                
                if (this.DeployedDevices != null)
                    hash = hash * 59 + this.DeployedDevices.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                if (this.When != null)
                    hash = hash * 59 + this.When.GetHashCode();
                
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                
                if (this.RootManifestUrl != null)
                    hash = hash * 59 + this.RootManifestUrl.GetHashCode();
                
                if (this.UpdatingApiKey != null)
                    hash = hash * 59 + this.UpdatingApiKey.GetHashCode();
                
                if (this.UpdatingAccountId != null)
                    hash = hash * 59 + this.UpdatingAccountId.GetHashCode();
                
                if (this.DeviceFilter != null)
                    hash = hash * 59 + this.DeviceFilter.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
