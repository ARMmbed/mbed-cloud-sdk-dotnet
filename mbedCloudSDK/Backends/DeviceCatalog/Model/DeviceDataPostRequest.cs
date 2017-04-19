/* 
 * Device Catalog API
 *
 * This is the API Documentation for the mbed device catalog update service.
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

namespace device_catalog.Model
{
    /// <summary>
    /// DeviceDataPostRequest
    /// </summary>
    [DataContract]
    public partial class DeviceDataPostRequest :  IEquatable<DeviceDataPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MechanismEnum
        {
            
            /// <summary>
            /// Enum Connector for "connector"
            /// </summary>
            [EnumMember(Value = "connector")]
            Connector,
            
            /// <summary>
            /// Enum Direct for "direct"
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Unenrolled for "unenrolled"
            /// </summary>
            [EnumMember(Value = "unenrolled")]
            Unenrolled,
            
            /// <summary>
            /// Enum Cloudenrolling for "cloud_enrolling"
            /// </summary>
            [EnumMember(Value = "cloud_enrolling")]
            Cloudenrolling,
            
            /// <summary>
            /// Enum Bootstrapped for "bootstrapped"
            /// </summary>
            [EnumMember(Value = "bootstrapped")]
            Bootstrapped,
            
            /// <summary>
            /// Enum Registered for "registered"
            /// </summary>
            [EnumMember(Value = "registered")]
            Registered,
            
            /// <summary>
            /// Enum Deregistered for "deregistered"
            /// </summary>
            [EnumMember(Value = "deregistered")]
            Deregistered
        }

        /// <summary>
        /// Gets or Sets DeployedState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeployedStateEnum
        {
            
            /// <summary>
            /// Enum Development for "development"
            /// </summary>
            [EnumMember(Value = "development")]
            Development,
            
            /// <summary>
            /// Enum Production for "production"
            /// </summary>
            [EnumMember(Value = "production")]
            Production
        }

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name="mechanism", EmitDefaultValue=false)]
        public MechanismEnum? Mechanism { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets DeployedState
        /// </summary>
        [DataMember(Name="deployed_state", EmitDefaultValue=false)]
        public DeployedStateEnum? DeployedState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDataPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceDataPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDataPostRequest" /> class.
        /// </summary>
        /// <param name="BootstrapExpirationDate">BootstrapExpirationDate.</param>
        /// <param name="BootstrappedTimestamp">BootstrappedTimestamp.</param>
        /// <param name="ConnectorExpirationDate">ConnectorExpirationDate.</param>
        /// <param name="Mechanism">Mechanism.</param>
        /// <param name="DeviceClass">DeviceClass.</param>
        /// <param name="EndpointName">EndpointName.</param>
        /// <param name="AutoUpdate">AutoUpdate.</param>
        /// <param name="DeviceExecutionMode">DeviceExecutionMode.</param>
        /// <param name="CustomAttributes">CustomAttributes.</param>
        /// <param name="State">State.</param>
        /// <param name="SerialNumber">SerialNumber.</param>
        /// <param name="FirmwareChecksum">FirmwareChecksum.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DeployedState">DeployedState.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="Deployment">Deployment.</param>
        /// <param name="MechanismUrl">MechanismUrl.</param>
        /// <param name="TrustLevel">TrustLevel.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DeviceKey">DeviceKey (required).</param>
        /// <param name="Manifest">Manifest.</param>
        /// <param name="CaId">CaId (required).</param>
        public DeviceDataPostRequest(DateTime? BootstrapExpirationDate = default(DateTime?), DateTime? BootstrappedTimestamp = default(DateTime?), DateTime? ConnectorExpirationDate = default(DateTime?), MechanismEnum? Mechanism = default(MechanismEnum?), string DeviceClass = default(string), string EndpointName = default(string), bool? AutoUpdate = default(bool?), int? DeviceExecutionMode = default(int?), Object CustomAttributes = default(Object), StateEnum? State = default(StateEnum?), string SerialNumber = default(string), string FirmwareChecksum = default(string), string VendorId = default(string), string Description = default(string), DeployedStateEnum? DeployedState = default(DeployedStateEnum?), string _Object = default(string), string Deployment = default(string), string MechanismUrl = default(string), int? TrustLevel = default(int?), string Name = default(string), string DeviceKey = default(string), string Manifest = default(string), string CaId = default(string))
        {
            // to ensure "DeviceKey" is required (not null)
            if (DeviceKey == null)
            {
                throw new InvalidDataException("DeviceKey is a required property for DeviceDataPostRequest and cannot be null");
            }
            else
            {
                this.DeviceKey = DeviceKey;
            }
            // to ensure "CaId" is required (not null)
            if (CaId == null)
            {
                throw new InvalidDataException("CaId is a required property for DeviceDataPostRequest and cannot be null");
            }
            else
            {
                this.CaId = CaId;
            }
            this.BootstrapExpirationDate = BootstrapExpirationDate;
            this.BootstrappedTimestamp = BootstrappedTimestamp;
            this.ConnectorExpirationDate = ConnectorExpirationDate;
            this.Mechanism = Mechanism;
            this.DeviceClass = DeviceClass;
            this.EndpointName = EndpointName;
            this.AutoUpdate = AutoUpdate;
            this.DeviceExecutionMode = DeviceExecutionMode;
            this.CustomAttributes = CustomAttributes;
            this.State = State;
            this.SerialNumber = SerialNumber;
            this.FirmwareChecksum = FirmwareChecksum;
            this.VendorId = VendorId;
            this.Description = Description;
            this.DeployedState = DeployedState;
            this._Object = _Object;
            this.Deployment = Deployment;
            this.MechanismUrl = MechanismUrl;
            this.TrustLevel = TrustLevel;
            this.Name = Name;
            this.Manifest = Manifest;
        }
        
        /// <summary>
        /// Gets or Sets BootstrapExpirationDate
        /// </summary>
        [DataMember(Name="bootstrap_expiration_date", EmitDefaultValue=false)]
        public DateTime? BootstrapExpirationDate { get; set; }
        /// <summary>
        /// Gets or Sets BootstrappedTimestamp
        /// </summary>
        [DataMember(Name="bootstrapped_timestamp", EmitDefaultValue=false)]
        public DateTime? BootstrappedTimestamp { get; set; }
        /// <summary>
        /// Gets or Sets ConnectorExpirationDate
        /// </summary>
        [DataMember(Name="connector_expiration_date", EmitDefaultValue=false)]
        public DateTime? ConnectorExpirationDate { get; set; }
        /// <summary>
        /// Gets or Sets DeviceClass
        /// </summary>
        [DataMember(Name="device_class", EmitDefaultValue=false)]
        public string DeviceClass { get; set; }
        /// <summary>
        /// Gets or Sets EndpointName
        /// </summary>
        [DataMember(Name="endpoint_name", EmitDefaultValue=false)]
        public string EndpointName { get; set; }
        /// <summary>
        /// Gets or Sets AutoUpdate
        /// </summary>
        [DataMember(Name="auto_update", EmitDefaultValue=false)]
        public bool? AutoUpdate { get; set; }
        /// <summary>
        /// Gets or Sets DeviceExecutionMode
        /// </summary>
        [DataMember(Name="device_execution_mode", EmitDefaultValue=false)]
        public int? DeviceExecutionMode { get; set; }
        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Object CustomAttributes { get; set; }
        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serial_number", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }
        /// <summary>
        /// Gets or Sets FirmwareChecksum
        /// </summary>
        [DataMember(Name="firmware_checksum", EmitDefaultValue=false)]
        public string FirmwareChecksum { get; set; }
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public string VendorId { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// Gets or Sets Deployment
        /// </summary>
        [DataMember(Name="deployment", EmitDefaultValue=false)]
        public string Deployment { get; set; }
        /// <summary>
        /// Gets or Sets MechanismUrl
        /// </summary>
        [DataMember(Name="mechanism_url", EmitDefaultValue=false)]
        public string MechanismUrl { get; set; }
        /// <summary>
        /// Gets or Sets TrustLevel
        /// </summary>
        [DataMember(Name="trust_level", EmitDefaultValue=false)]
        public int? TrustLevel { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets DeviceKey
        /// </summary>
        [DataMember(Name="device_key", EmitDefaultValue=false)]
        public string DeviceKey { get; set; }
        /// <summary>
        /// Gets or Sets Manifest
        /// </summary>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        public string Manifest { get; set; }
        /// <summary>
        /// Gets or Sets CaId
        /// </summary>
        [DataMember(Name="ca_id", EmitDefaultValue=false)]
        public string CaId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceDataPostRequest {\n");
            sb.Append("  BootstrapExpirationDate: ").Append(BootstrapExpirationDate).Append("\n");
            sb.Append("  BootstrappedTimestamp: ").Append(BootstrappedTimestamp).Append("\n");
            sb.Append("  ConnectorExpirationDate: ").Append(ConnectorExpirationDate).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
            sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
            sb.Append("  DeviceExecutionMode: ").Append(DeviceExecutionMode).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  FirmwareChecksum: ").Append(FirmwareChecksum).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeployedState: ").Append(DeployedState).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Deployment: ").Append(Deployment).Append("\n");
            sb.Append("  MechanismUrl: ").Append(MechanismUrl).Append("\n");
            sb.Append("  TrustLevel: ").Append(TrustLevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeviceKey: ").Append(DeviceKey).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  CaId: ").Append(CaId).Append("\n");
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
            return this.Equals(obj as DeviceDataPostRequest);
        }

        /// <summary>
        /// Returns true if DeviceDataPostRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceDataPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceDataPostRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BootstrapExpirationDate == other.BootstrapExpirationDate ||
                    this.BootstrapExpirationDate != null &&
                    this.BootstrapExpirationDate.Equals(other.BootstrapExpirationDate)
                ) && 
                (
                    this.BootstrappedTimestamp == other.BootstrappedTimestamp ||
                    this.BootstrappedTimestamp != null &&
                    this.BootstrappedTimestamp.Equals(other.BootstrappedTimestamp)
                ) && 
                (
                    this.ConnectorExpirationDate == other.ConnectorExpirationDate ||
                    this.ConnectorExpirationDate != null &&
                    this.ConnectorExpirationDate.Equals(other.ConnectorExpirationDate)
                ) && 
                (
                    this.Mechanism == other.Mechanism ||
                    this.Mechanism != null &&
                    this.Mechanism.Equals(other.Mechanism)
                ) && 
                (
                    this.DeviceClass == other.DeviceClass ||
                    this.DeviceClass != null &&
                    this.DeviceClass.Equals(other.DeviceClass)
                ) && 
                (
                    this.EndpointName == other.EndpointName ||
                    this.EndpointName != null &&
                    this.EndpointName.Equals(other.EndpointName)
                ) && 
                (
                    this.AutoUpdate == other.AutoUpdate ||
                    this.AutoUpdate != null &&
                    this.AutoUpdate.Equals(other.AutoUpdate)
                ) && 
                (
                    this.DeviceExecutionMode == other.DeviceExecutionMode ||
                    this.DeviceExecutionMode != null &&
                    this.DeviceExecutionMode.Equals(other.DeviceExecutionMode)
                ) && 
                (
                    this.CustomAttributes == other.CustomAttributes ||
                    this.CustomAttributes != null &&
                    this.CustomAttributes.Equals(other.CustomAttributes)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SerialNumber == other.SerialNumber ||
                    this.SerialNumber != null &&
                    this.SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    this.FirmwareChecksum == other.FirmwareChecksum ||
                    this.FirmwareChecksum != null &&
                    this.FirmwareChecksum.Equals(other.FirmwareChecksum)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DeployedState == other.DeployedState ||
                    this.DeployedState != null &&
                    this.DeployedState.Equals(other.DeployedState)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Deployment == other.Deployment ||
                    this.Deployment != null &&
                    this.Deployment.Equals(other.Deployment)
                ) && 
                (
                    this.MechanismUrl == other.MechanismUrl ||
                    this.MechanismUrl != null &&
                    this.MechanismUrl.Equals(other.MechanismUrl)
                ) && 
                (
                    this.TrustLevel == other.TrustLevel ||
                    this.TrustLevel != null &&
                    this.TrustLevel.Equals(other.TrustLevel)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DeviceKey == other.DeviceKey ||
                    this.DeviceKey != null &&
                    this.DeviceKey.Equals(other.DeviceKey)
                ) && 
                (
                    this.Manifest == other.Manifest ||
                    this.Manifest != null &&
                    this.Manifest.Equals(other.Manifest)
                ) && 
                (
                    this.CaId == other.CaId ||
                    this.CaId != null &&
                    this.CaId.Equals(other.CaId)
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
                if (this.BootstrapExpirationDate != null)
                    hash = hash * 59 + this.BootstrapExpirationDate.GetHashCode();
                if (this.BootstrappedTimestamp != null)
                    hash = hash * 59 + this.BootstrappedTimestamp.GetHashCode();
                if (this.ConnectorExpirationDate != null)
                    hash = hash * 59 + this.ConnectorExpirationDate.GetHashCode();
                if (this.Mechanism != null)
                    hash = hash * 59 + this.Mechanism.GetHashCode();
                if (this.DeviceClass != null)
                    hash = hash * 59 + this.DeviceClass.GetHashCode();
                if (this.EndpointName != null)
                    hash = hash * 59 + this.EndpointName.GetHashCode();
                if (this.AutoUpdate != null)
                    hash = hash * 59 + this.AutoUpdate.GetHashCode();
                if (this.DeviceExecutionMode != null)
                    hash = hash * 59 + this.DeviceExecutionMode.GetHashCode();
                if (this.CustomAttributes != null)
                    hash = hash * 59 + this.CustomAttributes.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();
                if (this.FirmwareChecksum != null)
                    hash = hash * 59 + this.FirmwareChecksum.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DeployedState != null)
                    hash = hash * 59 + this.DeployedState.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Deployment != null)
                    hash = hash * 59 + this.Deployment.GetHashCode();
                if (this.MechanismUrl != null)
                    hash = hash * 59 + this.MechanismUrl.GetHashCode();
                if (this.TrustLevel != null)
                    hash = hash * 59 + this.TrustLevel.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DeviceKey != null)
                    hash = hash * 59 + this.DeviceKey.GetHashCode();
                if (this.Manifest != null)
                    hash = hash * 59 + this.Manifest.GetHashCode();
                if (this.CaId != null)
                    hash = hash * 59 + this.CaId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // DeviceClass (string) maxLength
            if(this.DeviceClass != null && this.DeviceClass.Length > 500)
            {
                yield return new ValidationResult("Invalid value for DeviceClass, length must be less than 500.", new [] { "DeviceClass" });
            }

            // EndpointName (string) maxLength
            if(this.EndpointName != null && this.EndpointName.Length > 64)
            {
                yield return new ValidationResult("Invalid value for EndpointName, length must be less than 64.", new [] { "EndpointName" });
            }

            // SerialNumber (string) maxLength
            if(this.SerialNumber != null && this.SerialNumber.Length > 64)
            {
                yield return new ValidationResult("Invalid value for SerialNumber, length must be less than 64.", new [] { "SerialNumber" });
            }

            // FirmwareChecksum (string) maxLength
            if(this.FirmwareChecksum != null && this.FirmwareChecksum.Length > 64)
            {
                yield return new ValidationResult("Invalid value for FirmwareChecksum, length must be less than 64.", new [] { "FirmwareChecksum" });
            }

            // VendorId (string) maxLength
            if(this.VendorId != null && this.VendorId.Length > 255)
            {
                yield return new ValidationResult("Invalid value for VendorId, length must be less than 255.", new [] { "VendorId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // DeviceKey (string) maxLength
            if(this.DeviceKey != null && this.DeviceKey.Length > 512)
            {
                yield return new ValidationResult("Invalid value for DeviceKey, length must be less than 512.", new [] { "DeviceKey" });
            }

            // CaId (string) maxLength
            if(this.CaId != null && this.CaId.Length > 500)
            {
                yield return new ValidationResult("Invalid value for CaId, length must be less than 500.", new [] { "CaId" });
            }

            yield break;
        }
    }

}
