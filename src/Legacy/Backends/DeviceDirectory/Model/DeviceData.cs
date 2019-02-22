/* 
 * <auto-generated>
 * Device Directory API
 *
 * This is the API Documentation for the Mbed Device Directory service.
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
using SwaggerDateConverter = device_directory.Client.SwaggerDateConverter;

namespace device_directory.Model
{
    /// <summary>
    /// DeviceData
    /// </summary>
    [DataContract]
    public partial class DeviceData :  IEquatable<DeviceData>, IValidatableObject
    {
        /// <summary>
        /// DEPRECATED: The state of the device&#39;s deployment.
        /// </summary>
        /// <value>DEPRECATED: The state of the device&#39;s deployment.</value>
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
        /// DEPRECATED: The state of the device&#39;s deployment.
        /// </summary>
        /// <value>DEPRECATED: The state of the device&#39;s deployment.</value>
        [DataMember(Name="deployed_state", EmitDefaultValue=false)]
        public DeployedStateEnum? DeployedState { get; set; }
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
        /// Initializes a new instance of the <see cref="DeviceData" /> class.
        /// </summary>
        /// <param name="AccountId">The ID of the associated account..</param>
        /// <param name="AutoUpdate">DEPRECATED: Mark this device for automatic firmware update..</param>
        /// <param name="BootstrapExpirationDate">The expiration date of the certificate used to connect to bootstrap server..</param>
        /// <param name="BootstrappedTimestamp">The timestamp of the device&#39;s most recent bootstrap process..</param>
        /// <param name="CaId">The certificate issuer&#39;s ID..</param>
        /// <param name="ConnectorExpirationDate">The expiration date of the certificate used to connect to LWM2M server..</param>
        /// <param name="CreatedAt">The timestamp of when the device was created in the device directory..</param>
        /// <param name="CustomAttributes">Up to five custom key-value attributes..</param>
        /// <param name="DeployedState">DEPRECATED: The state of the device&#39;s deployment..</param>
        /// <param name="Deployment">DEPRECATED: The last deployment used on the device..</param>
        /// <param name="Description">The description of the device..</param>
        /// <param name="DeviceClass">An ID representing the model and hardware revision of the device..</param>
        /// <param name="DeviceExecutionMode">The execution mode from the certificate of the device. Defaults to inheriting from host_gateway device. Permitted values:   - 0 - unspecified execution mode (default if host_gateway invalid or not set)   - 1 - development devices   - 5 - production devices.</param>
        /// <param name="DeviceKey">The fingerprint of the device certificate..</param>
        /// <param name="EndpointName">The endpoint name given to the device..</param>
        /// <param name="EndpointType">The endpoint type of the device. For example, the device is a gateway..</param>
        /// <param name="EnrolmentListTimestamp">The claim date/time..</param>
        /// <param name="Etag">The entity instance signature..</param>
        /// <param name="FirmwareChecksum">The SHA256 checksum of the current firmware image..</param>
        /// <param name="HostGateway">The &#x60;endpoint_name&#x60; of the host gateway, if appropriate..</param>
        /// <param name="Id">The ID of the device. The device ID is used to manage a device across all Mbed Cloud APIs..</param>
        /// <param name="Manifest">DEPRECATED: The URL for the current device manifest..</param>
        /// <param name="ManifestTimestamp">The timestamp of the current manifest version..</param>
        /// <param name="Mechanism">The ID of the channel used to communicate with the device..</param>
        /// <param name="MechanismUrl">The address of the connector to use..</param>
        /// <param name="Name">The name of the device..</param>
        /// <param name="_Object">The API resource entity..</param>
        /// <param name="SerialNumber">The serial number of the device..</param>
        /// <param name="State">The current state of the device..</param>
        /// <param name="UpdatedAt">The time the object was updated..</param>
        /// <param name="VendorId">The device vendor ID..</param>
        public DeviceData(string AccountId = default(string), bool? AutoUpdate = default(bool?), DateTime? BootstrapExpirationDate = default(DateTime?), DateTime? BootstrappedTimestamp = default(DateTime?), string CaId = default(string), DateTime? ConnectorExpirationDate = default(DateTime?), DateTime? CreatedAt = default(DateTime?), Dictionary<string, string> CustomAttributes = default(Dictionary<string, string>), DeployedStateEnum? DeployedState = default(DeployedStateEnum?), string Deployment = default(string), string Description = default(string), string DeviceClass = default(string), int? DeviceExecutionMode = default(int?), string DeviceKey = default(string), string EndpointName = default(string), string EndpointType = default(string), DateTime? EnrolmentListTimestamp = default(DateTime?), DateTime? Etag = default(DateTime?), string FirmwareChecksum = default(string), string HostGateway = default(string), string Id = default(string), string Manifest = default(string), DateTime? ManifestTimestamp = default(DateTime?), MechanismEnum? Mechanism = default(MechanismEnum?), string MechanismUrl = default(string), string Name = default(string), string _Object = default(string), string SerialNumber = default(string), StateEnum? State = default(StateEnum?), DateTime? UpdatedAt = default(DateTime?), string VendorId = default(string))
        {
            this.AccountId = AccountId;
            this.AutoUpdate = AutoUpdate;
            this.BootstrapExpirationDate = BootstrapExpirationDate;
            this.BootstrappedTimestamp = BootstrappedTimestamp;
            this.CaId = CaId;
            this.ConnectorExpirationDate = ConnectorExpirationDate;
            this.CreatedAt = CreatedAt;
            this.CustomAttributes = CustomAttributes;
            this.DeployedState = DeployedState;
            this.Deployment = Deployment;
            this.Description = Description;
            this.DeviceClass = DeviceClass;
            this.DeviceExecutionMode = DeviceExecutionMode;
            this.DeviceKey = DeviceKey;
            this.EndpointName = EndpointName;
            this.EndpointType = EndpointType;
            this.EnrolmentListTimestamp = EnrolmentListTimestamp;
            this.Etag = Etag;
            this.FirmwareChecksum = FirmwareChecksum;
            this.HostGateway = HostGateway;
            this.Id = Id;
            this.Manifest = Manifest;
            this.ManifestTimestamp = ManifestTimestamp;
            this.Mechanism = Mechanism;
            this.MechanismUrl = MechanismUrl;
            this.Name = Name;
            this._Object = _Object;
            this.SerialNumber = SerialNumber;
            this.State = State;
            this.UpdatedAt = UpdatedAt;
            this.VendorId = VendorId;
        }
        
        /// <summary>
        /// The ID of the associated account.
        /// </summary>
        /// <value>The ID of the associated account.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// DEPRECATED: Mark this device for automatic firmware update.
        /// </summary>
        /// <value>DEPRECATED: Mark this device for automatic firmware update.</value>
        [DataMember(Name="auto_update", EmitDefaultValue=false)]
        public bool? AutoUpdate { get; set; }

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
        /// The certificate issuer&#39;s ID.
        /// </summary>
        /// <value>The certificate issuer&#39;s ID.</value>
        [DataMember(Name="ca_id", EmitDefaultValue=false)]
        public string CaId { get; set; }

        /// <summary>
        /// The expiration date of the certificate used to connect to LWM2M server.
        /// </summary>
        /// <value>The expiration date of the certificate used to connect to LWM2M server.</value>
        [DataMember(Name="connector_expiration_date", EmitDefaultValue=false)]
        public DateTime? ConnectorExpirationDate { get; set; }

        /// <summary>
        /// The timestamp of when the device was created in the device directory.
        /// </summary>
        /// <value>The timestamp of when the device was created in the device directory.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Up to five custom key-value attributes.
        /// </summary>
        /// <value>Up to five custom key-value attributes.</value>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributes { get; set; }


        /// <summary>
        /// DEPRECATED: The last deployment used on the device.
        /// </summary>
        /// <value>DEPRECATED: The last deployment used on the device.</value>
        [DataMember(Name="deployment", EmitDefaultValue=false)]
        public string Deployment { get; set; }

        /// <summary>
        /// The description of the device.
        /// </summary>
        /// <value>The description of the device.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An ID representing the model and hardware revision of the device.
        /// </summary>
        /// <value>An ID representing the model and hardware revision of the device.</value>
        [DataMember(Name="device_class", EmitDefaultValue=false)]
        public string DeviceClass { get; set; }

        /// <summary>
        /// The execution mode from the certificate of the device. Defaults to inheriting from host_gateway device. Permitted values:   - 0 - unspecified execution mode (default if host_gateway invalid or not set)   - 1 - development devices   - 5 - production devices
        /// </summary>
        /// <value>The execution mode from the certificate of the device. Defaults to inheriting from host_gateway device. Permitted values:   - 0 - unspecified execution mode (default if host_gateway invalid or not set)   - 1 - development devices   - 5 - production devices</value>
        [DataMember(Name="device_execution_mode", EmitDefaultValue=false)]
        public int? DeviceExecutionMode { get; set; }

        /// <summary>
        /// The fingerprint of the device certificate.
        /// </summary>
        /// <value>The fingerprint of the device certificate.</value>
        [DataMember(Name="device_key", EmitDefaultValue=false)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// The endpoint name given to the device.
        /// </summary>
        /// <value>The endpoint name given to the device.</value>
        [DataMember(Name="endpoint_name", EmitDefaultValue=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// The endpoint type of the device. For example, the device is a gateway.
        /// </summary>
        /// <value>The endpoint type of the device. For example, the device is a gateway.</value>
        [DataMember(Name="endpoint_type", EmitDefaultValue=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The claim date/time.
        /// </summary>
        /// <value>The claim date/time.</value>
        [DataMember(Name="enrolment_list_timestamp", EmitDefaultValue=false)]
        public DateTime? EnrolmentListTimestamp { get; set; }

        /// <summary>
        /// The entity instance signature.
        /// </summary>
        /// <value>The entity instance signature.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }

        /// <summary>
        /// The SHA256 checksum of the current firmware image.
        /// </summary>
        /// <value>The SHA256 checksum of the current firmware image.</value>
        [DataMember(Name="firmware_checksum", EmitDefaultValue=false)]
        public string FirmwareChecksum { get; set; }

        /// <summary>
        /// The &#x60;endpoint_name&#x60; of the host gateway, if appropriate.
        /// </summary>
        /// <value>The &#x60;endpoint_name&#x60; of the host gateway, if appropriate.</value>
        [DataMember(Name="host_gateway", EmitDefaultValue=false)]
        public string HostGateway { get; set; }

        /// <summary>
        /// The ID of the device. The device ID is used to manage a device across all Mbed Cloud APIs.
        /// </summary>
        /// <value>The ID of the device. The device ID is used to manage a device across all Mbed Cloud APIs.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// DEPRECATED: The URL for the current device manifest.
        /// </summary>
        /// <value>DEPRECATED: The URL for the current device manifest.</value>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        public string Manifest { get; set; }

        /// <summary>
        /// The timestamp of the current manifest version.
        /// </summary>
        /// <value>The timestamp of the current manifest version.</value>
        [DataMember(Name="manifest_timestamp", EmitDefaultValue=false)]
        public DateTime? ManifestTimestamp { get; set; }


        /// <summary>
        /// The address of the connector to use.
        /// </summary>
        /// <value>The address of the connector to use.</value>
        [DataMember(Name="mechanism_url", EmitDefaultValue=false)]
        public string MechanismUrl { get; set; }

        /// <summary>
        /// The name of the device.
        /// </summary>
        /// <value>The name of the device.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The API resource entity.
        /// </summary>
        /// <value>The API resource entity.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// The serial number of the device.
        /// </summary>
        /// <value>The serial number of the device.</value>
        [DataMember(Name="serial_number", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }


        /// <summary>
        /// The time the object was updated.
        /// </summary>
        /// <value>The time the object was updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The device vendor ID.
        /// </summary>
        /// <value>The device vendor ID.</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public string VendorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceData {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
            sb.Append("  BootstrapExpirationDate: ").Append(BootstrapExpirationDate).Append("\n");
            sb.Append("  BootstrappedTimestamp: ").Append(BootstrappedTimestamp).Append("\n");
            sb.Append("  CaId: ").Append(CaId).Append("\n");
            sb.Append("  ConnectorExpirationDate: ").Append(ConnectorExpirationDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  DeployedState: ").Append(DeployedState).Append("\n");
            sb.Append("  Deployment: ").Append(Deployment).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  DeviceExecutionMode: ").Append(DeviceExecutionMode).Append("\n");
            sb.Append("  DeviceKey: ").Append(DeviceKey).Append("\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
            sb.Append("  EndpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  EnrolmentListTimestamp: ").Append(EnrolmentListTimestamp).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  FirmwareChecksum: ").Append(FirmwareChecksum).Append("\n");
            sb.Append("  HostGateway: ").Append(HostGateway).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  ManifestTimestamp: ").Append(ManifestTimestamp).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  MechanismUrl: ").Append(MechanismUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
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
            return this.Equals(input as DeviceData);
        }

        /// <summary>
        /// Returns true if DeviceData instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceData input)
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
                    this.AutoUpdate == input.AutoUpdate ||
                    (this.AutoUpdate != null &&
                    this.AutoUpdate.Equals(input.AutoUpdate))
                ) && 
                (
                    this.BootstrapExpirationDate == input.BootstrapExpirationDate ||
                    (this.BootstrapExpirationDate != null &&
                    this.BootstrapExpirationDate.Equals(input.BootstrapExpirationDate))
                ) && 
                (
                    this.BootstrappedTimestamp == input.BootstrappedTimestamp ||
                    (this.BootstrappedTimestamp != null &&
                    this.BootstrappedTimestamp.Equals(input.BootstrappedTimestamp))
                ) && 
                (
                    this.CaId == input.CaId ||
                    (this.CaId != null &&
                    this.CaId.Equals(input.CaId))
                ) && 
                (
                    this.ConnectorExpirationDate == input.ConnectorExpirationDate ||
                    (this.ConnectorExpirationDate != null &&
                    this.ConnectorExpirationDate.Equals(input.ConnectorExpirationDate))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.DeployedState == input.DeployedState ||
                    (this.DeployedState != null &&
                    this.DeployedState.Equals(input.DeployedState))
                ) && 
                (
                    this.Deployment == input.Deployment ||
                    (this.Deployment != null &&
                    this.Deployment.Equals(input.Deployment))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeviceClass == input.DeviceClass ||
                    (this.DeviceClass != null &&
                    this.DeviceClass.Equals(input.DeviceClass))
                ) && 
                (
                    this.DeviceExecutionMode == input.DeviceExecutionMode ||
                    (this.DeviceExecutionMode != null &&
                    this.DeviceExecutionMode.Equals(input.DeviceExecutionMode))
                ) && 
                (
                    this.DeviceKey == input.DeviceKey ||
                    (this.DeviceKey != null &&
                    this.DeviceKey.Equals(input.DeviceKey))
                ) && 
                (
                    this.EndpointName == input.EndpointName ||
                    (this.EndpointName != null &&
                    this.EndpointName.Equals(input.EndpointName))
                ) && 
                (
                    this.EndpointType == input.EndpointType ||
                    (this.EndpointType != null &&
                    this.EndpointType.Equals(input.EndpointType))
                ) && 
                (
                    this.EnrolmentListTimestamp == input.EnrolmentListTimestamp ||
                    (this.EnrolmentListTimestamp != null &&
                    this.EnrolmentListTimestamp.Equals(input.EnrolmentListTimestamp))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.FirmwareChecksum == input.FirmwareChecksum ||
                    (this.FirmwareChecksum != null &&
                    this.FirmwareChecksum.Equals(input.FirmwareChecksum))
                ) && 
                (
                    this.HostGateway == input.HostGateway ||
                    (this.HostGateway != null &&
                    this.HostGateway.Equals(input.HostGateway))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
                ) && 
                (
                    this.ManifestTimestamp == input.ManifestTimestamp ||
                    (this.ManifestTimestamp != null &&
                    this.ManifestTimestamp.Equals(input.ManifestTimestamp))
                ) && 
                (
                    this.Mechanism == input.Mechanism ||
                    (this.Mechanism != null &&
                    this.Mechanism.Equals(input.Mechanism))
                ) && 
                (
                    this.MechanismUrl == input.MechanismUrl ||
                    (this.MechanismUrl != null &&
                    this.MechanismUrl.Equals(input.MechanismUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
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
                if (this.AutoUpdate != null)
                    hashCode = hashCode * 59 + this.AutoUpdate.GetHashCode();
                if (this.BootstrapExpirationDate != null)
                    hashCode = hashCode * 59 + this.BootstrapExpirationDate.GetHashCode();
                if (this.BootstrappedTimestamp != null)
                    hashCode = hashCode * 59 + this.BootstrappedTimestamp.GetHashCode();
                if (this.CaId != null)
                    hashCode = hashCode * 59 + this.CaId.GetHashCode();
                if (this.ConnectorExpirationDate != null)
                    hashCode = hashCode * 59 + this.ConnectorExpirationDate.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.DeployedState != null)
                    hashCode = hashCode * 59 + this.DeployedState.GetHashCode();
                if (this.Deployment != null)
                    hashCode = hashCode * 59 + this.Deployment.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeviceClass != null)
                    hashCode = hashCode * 59 + this.DeviceClass.GetHashCode();
                if (this.DeviceExecutionMode != null)
                    hashCode = hashCode * 59 + this.DeviceExecutionMode.GetHashCode();
                if (this.DeviceKey != null)
                    hashCode = hashCode * 59 + this.DeviceKey.GetHashCode();
                if (this.EndpointName != null)
                    hashCode = hashCode * 59 + this.EndpointName.GetHashCode();
                if (this.EndpointType != null)
                    hashCode = hashCode * 59 + this.EndpointType.GetHashCode();
                if (this.EnrolmentListTimestamp != null)
                    hashCode = hashCode * 59 + this.EnrolmentListTimestamp.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.FirmwareChecksum != null)
                    hashCode = hashCode * 59 + this.FirmwareChecksum.GetHashCode();
                if (this.HostGateway != null)
                    hashCode = hashCode * 59 + this.HostGateway.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
                if (this.ManifestTimestamp != null)
                    hashCode = hashCode * 59 + this.ManifestTimestamp.GetHashCode();
                if (this.Mechanism != null)
                    hashCode = hashCode * 59 + this.Mechanism.GetHashCode();
                if (this.MechanismUrl != null)
                    hashCode = hashCode * 59 + this.MechanismUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
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
            // CaId (string) maxLength
            if(this.CaId != null && this.CaId.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CaId, length must be less than 500.", new [] { "CaId" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 2000.", new [] { "Description" });
            }

            // DeviceClass (string) maxLength
            if(this.DeviceClass != null && this.DeviceClass.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeviceClass, length must be less than 32.", new [] { "DeviceClass" });
            }

            // DeviceKey (string) maxLength
            if(this.DeviceKey != null && this.DeviceKey.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeviceKey, length must be less than 512.", new [] { "DeviceKey" });
            }

            // EndpointType (string) maxLength
            if(this.EndpointType != null && this.EndpointType.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndpointType, length must be less than 64.", new [] { "EndpointType" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

}