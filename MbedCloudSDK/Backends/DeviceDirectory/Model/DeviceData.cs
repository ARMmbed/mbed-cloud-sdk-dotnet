/* 
 * <auto-generated>
 * Device Directory API
 *
 * This is the API Documentation for the Mbed device directory update service.
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

namespace device_directory.Model
{
    /// <summary>
    /// DeviceData
    /// </summary>
    [DataContract]
    public partial class DeviceData :  IEquatable<DeviceData>, IValidatableObject
    {
        /// <summary>
        /// The ID of the channel used to communicate with the device.
        /// </summary>
        /// <value>The ID of the channel used to communicate with the device.</value>
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
        /// The current state of the device.
        /// </summary>
        /// <value>The current state of the device.</value>
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
        /// DEPRECATED: The state of the device's deployment.
        /// </summary>
        /// <value>DEPRECATED: The state of the device's deployment.</value>
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
        /// The ID of the channel used to communicate with the device.
        /// </summary>
        /// <value>The ID of the channel used to communicate with the device.</value>
        [DataMember(Name="mechanism", EmitDefaultValue=false)]
        public MechanismEnum? Mechanism { get; set; }
        /// <summary>
        /// The current state of the device.
        /// </summary>
        /// <value>The current state of the device.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// DEPRECATED: The state of the device's deployment.
        /// </summary>
        /// <value>DEPRECATED: The state of the device's deployment.</value>
        [DataMember(Name="deployed_state", EmitDefaultValue=false)]
        public DeployedStateEnum? DeployedState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceData" /> class.
        /// </summary>
        /// <param name="BootstrapExpirationDate">The expiration date of the certificate used to connect to bootstrap server..</param>
        /// <param name="BootstrappedTimestamp">The timestamp of the device&#39;s most recent bootstrap process..</param>
        /// <param name="ConnectorExpirationDate">The expiration date of the certificate used to connect to LWM2M server..</param>
        /// <param name="UpdatedAt">The time the object was updated..</param>
        /// <param name="CaId">The certificate issuer&#39;s ID..</param>
        /// <param name="DeviceClass">An ID representing the model and hardware revision of the device..</param>
        /// <param name="Id">The ID of the device. The device ID is used to manage a device across all Mbed Cloud APIs..</param>
        /// <param name="AccountId">The ID of the associated account..</param>
        /// <param name="EndpointName">The endpoint name given to the device..</param>
        /// <param name="AutoUpdate">DEPRECATED: Mark this device for automatic firmware update..</param>
        /// <param name="HostGateway">The &#x60;endpoint_name&#x60; of the host gateway, if appropriate..</param>
        /// <param name="DeviceExecutionMode">The execution mode from the certificate of the device. Permitted values:   - 0 - unspecified execution mode (default)   - 1 - development devices   - 5 - production devices.</param>
        /// <param name="Mechanism">The ID of the channel used to communicate with the device..</param>
        /// <param name="State">The current state of the device..</param>
        /// <param name="Etag">The entity instance signature..</param>
        /// <param name="SerialNumber">The serial number of the device..</param>
        /// <param name="FirmwareChecksum">The SHA256 checksum of the current firmware image..</param>
        /// <param name="ManifestTimestamp">The timestamp of the current manifest version..</param>
        /// <param name="VendorId">The device vendor ID..</param>
        /// <param name="Description">The description of the device..</param>
        /// <param name="DeployedState">DEPRECATED: The state of the device&#39;s deployment..</param>
        /// <param name="_Object">The API resource entity..</param>
        /// <param name="EndpointType">The endpoint type of the device. For example, the device is a gateway..</param>
        /// <param name="Deployment">DEPRECATED: The last deployment used on the device..</param>
        /// <param name="MechanismUrl">The address of the connector to use..</param>
        /// <param name="TrustLevel">The device trust level..</param>
        /// <param name="Name">The name of the device..</param>
        /// <param name="DeviceKey">The fingerprint of the device certificate..</param>
        /// <param name="CreatedAt">The timestamp of when the device was created in the device directory..</param>
        /// <param name="Manifest">DEPRECATED: The URL for the current device manifest..</param>
        /// <param name="CustomAttributes">Up to five custom key-value attributes..</param>
        public DeviceData(DateTime? BootstrapExpirationDate = default(DateTime?), DateTime? BootstrappedTimestamp = default(DateTime?), DateTime? ConnectorExpirationDate = default(DateTime?), DateTime? UpdatedAt = default(DateTime?), string CaId = default(string), string DeviceClass = default(string), string Id = default(string), string AccountId = default(string), string EndpointName = default(string), bool? AutoUpdate = default(bool?), string HostGateway = default(string), int? DeviceExecutionMode = default(int?), MechanismEnum? Mechanism = default(MechanismEnum?), StateEnum? State = default(StateEnum?), DateTime? Etag = default(DateTime?), string SerialNumber = default(string), string FirmwareChecksum = default(string), DateTime? ManifestTimestamp = default(DateTime?), string VendorId = default(string), string Description = default(string), DeployedStateEnum? DeployedState = default(DeployedStateEnum?), string _Object = default(string), string EndpointType = default(string), string Deployment = default(string), string MechanismUrl = default(string), int? TrustLevel = default(int?), string Name = default(string), string DeviceKey = default(string), DateTime? CreatedAt = default(DateTime?), string Manifest = default(string), Dictionary<string, string> CustomAttributes = default(Dictionary<string, string>))
        {
            this.BootstrapExpirationDate = BootstrapExpirationDate;
            this.BootstrappedTimestamp = BootstrappedTimestamp;
            this.ConnectorExpirationDate = ConnectorExpirationDate;
            this.UpdatedAt = UpdatedAt;
            this.CaId = CaId;
            this.DeviceClass = DeviceClass;
            this.Id = Id;
            this.AccountId = AccountId;
            this.EndpointName = EndpointName;
            this.AutoUpdate = AutoUpdate;
            this.HostGateway = HostGateway;
            this.DeviceExecutionMode = DeviceExecutionMode;
            this.Mechanism = Mechanism;
            this.State = State;
            this.Etag = Etag;
            this.SerialNumber = SerialNumber;
            this.FirmwareChecksum = FirmwareChecksum;
            this.ManifestTimestamp = ManifestTimestamp;
            this.VendorId = VendorId;
            this.Description = Description;
            this.DeployedState = DeployedState;
            this._Object = _Object;
            this.EndpointType = EndpointType;
            this.Deployment = Deployment;
            this.MechanismUrl = MechanismUrl;
            this.TrustLevel = TrustLevel;
            this.Name = Name;
            this.DeviceKey = DeviceKey;
            this.CreatedAt = CreatedAt;
            this.Manifest = Manifest;
            this.CustomAttributes = CustomAttributes;
        }
        
        /// <summary>
        /// The expiration date of the certificate used to connect to bootstrap server.
        /// </summary>
        /// <value>The expiration date of the certificate used to connect to bootstrap server.</value>
        [DataMember(Name="bootstrap_expiration_date", EmitDefaultValue=false)]
        public DateTime? BootstrapExpirationDate { get; set; }
        /// <summary>
        /// The timestamp of the device&#39;s most recent bootstrap process.
        /// </summary>
        /// <value>The timestamp of the device&#39;s most recent bootstrap process.</value>
        [DataMember(Name="bootstrapped_timestamp", EmitDefaultValue=false)]
        public DateTime? BootstrappedTimestamp { get; set; }
        /// <summary>
        /// The expiration date of the certificate used to connect to LWM2M server.
        /// </summary>
        /// <value>The expiration date of the certificate used to connect to LWM2M server.</value>
        [DataMember(Name="connector_expiration_date", EmitDefaultValue=false)]
        public DateTime? ConnectorExpirationDate { get; set; }
        /// <summary>
        /// The time the object was updated.
        /// </summary>
        /// <value>The time the object was updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// The certificate issuer&#39;s ID.
        /// </summary>
        /// <value>The certificate issuer&#39;s ID.</value>
        [DataMember(Name="ca_id", EmitDefaultValue=false)]
        public string CaId { get; set; }
        /// <summary>
        /// An ID representing the model and hardware revision of the device.
        /// </summary>
        /// <value>An ID representing the model and hardware revision of the device.</value>
        [DataMember(Name="device_class", EmitDefaultValue=false)]
        public string DeviceClass { get; set; }
        /// <summary>
        /// The ID of the device. The device ID is used to manage a device across all Mbed Cloud APIs.
        /// </summary>
        /// <value>The ID of the device. The device ID is used to manage a device across all Mbed Cloud APIs.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the associated account.
        /// </summary>
        /// <value>The ID of the associated account.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// The endpoint name given to the device.
        /// </summary>
        /// <value>The endpoint name given to the device.</value>
        [DataMember(Name="endpoint_name", EmitDefaultValue=false)]
        public string EndpointName { get; set; }
        /// <summary>
        /// DEPRECATED: Mark this device for automatic firmware update.
        /// </summary>
        /// <value>DEPRECATED: Mark this device for automatic firmware update.</value>
        [DataMember(Name="auto_update", EmitDefaultValue=false)]
        public bool? AutoUpdate { get; set; }
        /// <summary>
        /// The &#x60;endpoint_name&#x60; of the host gateway, if appropriate.
        /// </summary>
        /// <value>The &#x60;endpoint_name&#x60; of the host gateway, if appropriate.</value>
        [DataMember(Name="host_gateway", EmitDefaultValue=false)]
        public string HostGateway { get; set; }
        /// <summary>
        /// The execution mode from the certificate of the device. Permitted values:   - 0 - unspecified execution mode (default)   - 1 - development devices   - 5 - production devices
        /// </summary>
        /// <value>The execution mode from the certificate of the device. Permitted values:   - 0 - unspecified execution mode (default)   - 1 - development devices   - 5 - production devices</value>
        [DataMember(Name="device_execution_mode", EmitDefaultValue=false)]
        public int? DeviceExecutionMode { get; set; }
        /// <summary>
        /// The entity instance signature.
        /// </summary>
        /// <value>The entity instance signature.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }
        /// <summary>
        /// The serial number of the device.
        /// </summary>
        /// <value>The serial number of the device.</value>
        [DataMember(Name="serial_number", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }
        /// <summary>
        /// The SHA256 checksum of the current firmware image.
        /// </summary>
        /// <value>The SHA256 checksum of the current firmware image.</value>
        [DataMember(Name="firmware_checksum", EmitDefaultValue=false)]
        public string FirmwareChecksum { get; set; }
        /// <summary>
        /// The timestamp of the current manifest version.
        /// </summary>
        /// <value>The timestamp of the current manifest version.</value>
        [DataMember(Name="manifest_timestamp", EmitDefaultValue=false)]
        public DateTime? ManifestTimestamp { get; set; }
        /// <summary>
        /// The device vendor ID.
        /// </summary>
        /// <value>The device vendor ID.</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public string VendorId { get; set; }
        /// <summary>
        /// The description of the device.
        /// </summary>
        /// <value>The description of the device.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The API resource entity.
        /// </summary>
        /// <value>The API resource entity.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// The endpoint type of the device. For example, the device is a gateway.
        /// </summary>
        /// <value>The endpoint type of the device. For example, the device is a gateway.</value>
        [DataMember(Name="endpoint_type", EmitDefaultValue=false)]
        public string EndpointType { get; set; }
        /// <summary>
        /// DEPRECATED: The last deployment used on the device.
        /// </summary>
        /// <value>DEPRECATED: The last deployment used on the device.</value>
        [DataMember(Name="deployment", EmitDefaultValue=false)]
        public string Deployment { get; set; }
        /// <summary>
        /// The address of the connector to use.
        /// </summary>
        /// <value>The address of the connector to use.</value>
        [DataMember(Name="mechanism_url", EmitDefaultValue=false)]
        public string MechanismUrl { get; set; }
        /// <summary>
        /// The device trust level.
        /// </summary>
        /// <value>The device trust level.</value>
        [DataMember(Name="trust_level", EmitDefaultValue=false)]
        public int? TrustLevel { get; set; }
        /// <summary>
        /// The name of the device.
        /// </summary>
        /// <value>The name of the device.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The fingerprint of the device certificate.
        /// </summary>
        /// <value>The fingerprint of the device certificate.</value>
        [DataMember(Name="device_key", EmitDefaultValue=false)]
        public string DeviceKey { get; set; }
        /// <summary>
        /// The timestamp of when the device was created in the device directory.
        /// </summary>
        /// <value>The timestamp of when the device was created in the device directory.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// DEPRECATED: The URL for the current device manifest.
        /// </summary>
        /// <value>DEPRECATED: The URL for the current device manifest.</value>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        public string Manifest { get; set; }
        /// <summary>
        /// Up to five custom key-value attributes.
        /// </summary>
        /// <value>Up to five custom key-value attributes.</value>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceData {\n");
            sb.Append("  BootstrapExpirationDate: ").Append(BootstrapExpirationDate).Append("\n");
            sb.Append("  BootstrappedTimestamp: ").Append(BootstrappedTimestamp).Append("\n");
            sb.Append("  ConnectorExpirationDate: ").Append(ConnectorExpirationDate).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CaId: ").Append(CaId).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
            sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
            sb.Append("  HostGateway: ").Append(HostGateway).Append("\n");
            sb.Append("  DeviceExecutionMode: ").Append(DeviceExecutionMode).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  FirmwareChecksum: ").Append(FirmwareChecksum).Append("\n");
            sb.Append("  ManifestTimestamp: ").Append(ManifestTimestamp).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeployedState: ").Append(DeployedState).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  EndpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  Deployment: ").Append(Deployment).Append("\n");
            sb.Append("  MechanismUrl: ").Append(MechanismUrl).Append("\n");
            sb.Append("  TrustLevel: ").Append(TrustLevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeviceKey: ").Append(DeviceKey).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
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
            return this.Equals(obj as DeviceData);
        }

        /// <summary>
        /// Returns true if DeviceData instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceData other)
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
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.CaId == other.CaId ||
                    this.CaId != null &&
                    this.CaId.Equals(other.CaId)
                ) && 
                (
                    this.DeviceClass == other.DeviceClass ||
                    this.DeviceClass != null &&
                    this.DeviceClass.Equals(other.DeviceClass)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
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
                    this.HostGateway == other.HostGateway ||
                    this.HostGateway != null &&
                    this.HostGateway.Equals(other.HostGateway)
                ) && 
                (
                    this.DeviceExecutionMode == other.DeviceExecutionMode ||
                    this.DeviceExecutionMode != null &&
                    this.DeviceExecutionMode.Equals(other.DeviceExecutionMode)
                ) && 
                (
                    this.Mechanism == other.Mechanism ||
                    this.Mechanism != null &&
                    this.Mechanism.Equals(other.Mechanism)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
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
                    this.ManifestTimestamp == other.ManifestTimestamp ||
                    this.ManifestTimestamp != null &&
                    this.ManifestTimestamp.Equals(other.ManifestTimestamp)
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
                    this.EndpointType == other.EndpointType ||
                    this.EndpointType != null &&
                    this.EndpointType.Equals(other.EndpointType)
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
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Manifest == other.Manifest ||
                    this.Manifest != null &&
                    this.Manifest.Equals(other.Manifest)
                ) && 
                (
                    this.CustomAttributes == other.CustomAttributes ||
                    this.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(other.CustomAttributes)
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
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.CaId != null)
                    hash = hash * 59 + this.CaId.GetHashCode();
                if (this.DeviceClass != null)
                    hash = hash * 59 + this.DeviceClass.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.EndpointName != null)
                    hash = hash * 59 + this.EndpointName.GetHashCode();
                if (this.AutoUpdate != null)
                    hash = hash * 59 + this.AutoUpdate.GetHashCode();
                if (this.HostGateway != null)
                    hash = hash * 59 + this.HostGateway.GetHashCode();
                if (this.DeviceExecutionMode != null)
                    hash = hash * 59 + this.DeviceExecutionMode.GetHashCode();
                if (this.Mechanism != null)
                    hash = hash * 59 + this.Mechanism.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();
                if (this.FirmwareChecksum != null)
                    hash = hash * 59 + this.FirmwareChecksum.GetHashCode();
                if (this.ManifestTimestamp != null)
                    hash = hash * 59 + this.ManifestTimestamp.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DeployedState != null)
                    hash = hash * 59 + this.DeployedState.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.EndpointType != null)
                    hash = hash * 59 + this.EndpointType.GetHashCode();
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Manifest != null)
                    hash = hash * 59 + this.Manifest.GetHashCode();
                if (this.CustomAttributes != null)
                    hash = hash * 59 + this.CustomAttributes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // CaId (string) maxLength
            if(this.CaId != null && this.CaId.Length > 500)
            {
                yield return new ValidationResult("Invalid value for CaId, length must be less than 500.", new [] { "CaId" });
            }

            // DeviceClass (string) maxLength
            if(this.DeviceClass != null && this.DeviceClass.Length > 500)
            {
                yield return new ValidationResult("Invalid value for DeviceClass, length must be less than 500.", new [] { "DeviceClass" });
            }

            // EndpointType (string) maxLength
            if(this.EndpointType != null && this.EndpointType.Length > 64)
            {
                yield return new ValidationResult("Invalid value for EndpointType, length must be less than 64.", new [] { "EndpointType" });
            }

            // DeviceKey (string) maxLength
            if(this.DeviceKey != null && this.DeviceKey.Length > 512)
            {
                yield return new ValidationResult("Invalid value for DeviceKey, length must be less than 512.", new [] { "DeviceKey" });
            }

            yield break;
        }
    }

}
