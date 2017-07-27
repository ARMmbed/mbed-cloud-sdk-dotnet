/* 
 * Update Service API
 *
 * This is the API Documentation for the mbed deployment service which is part of the update service.
 *
 * OpenAPI spec version: 3
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

namespace update_service.Model
{
    /// <summary>
    /// ManifestContents
    /// </summary>
    [DataContract]
    public partial class ManifestContents :  IEquatable<ManifestContents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestContents" /> class.
        /// </summary>
        /// <param name="Nonce">A 128-bit random field.</param>
        /// <param name="VendorId">Hex representation of the 128-bit RFC4122 GUID that represents the vendor..</param>
        /// <param name="ManifestVersion">The version of the manifest format being used..</param>
        /// <param name="Description">A short description of the update..</param>
        /// <param name="PayloadInfo">PayloadInfo.</param>
        /// <param name="DigestAlgorithm">DigestAlgorithm.</param>
        /// <param name="Text">Text.</param>
        /// <param name="EncryptionMode">EncryptionMode.</param>
        /// <param name="ApplyImmediately">A flag that indicates that the update described by the manifest should be applied as soon as possible..</param>
        /// <param name="Directives">Directives.</param>
        /// <param name="DeviceId">Hex representation of the 128-bit RFC4122 GUID that uniquely identifies the device. Each device has a single, unique device ID..</param>
        /// <param name="Timestamp">The time the manifest was created. The timestamp is stored as Unix time..</param>
        /// <param name="ClassId">Hex representation of the 128-bit RFC4122 GUID that represents the device class that the update targets..</param>
        /// <param name="Dependenices">Dependenices.</param>
        /// <param name="Conditions">Conditions.</param>
        /// <param name="Payload">Payload.</param>
        /// <param name="Aliases">Aliases.</param>
        public ManifestContents(string Nonce = default(string), string VendorId = default(string), string ManifestVersion = default(string), string Description = default(string), ManifestContentsPayloadInfo PayloadInfo = default(ManifestContentsPayloadInfo), ManifestContentsDigestAlgorithm DigestAlgorithm = default(ManifestContentsDigestAlgorithm), List<ManifestContentsText> Text = default(List<ManifestContentsText>), ManifestContentsEncryptionMode EncryptionMode = default(ManifestContentsEncryptionMode), bool? ApplyImmediately = default(bool?), List<ManifestContentsDirectives> Directives = default(List<ManifestContentsDirectives>), string DeviceId = default(string), int? Timestamp = default(int?), string ClassId = default(string), List<ManifestContentsPayloadInfoPayloadReference> Dependenices = default(List<ManifestContentsPayloadInfoPayloadReference>), List<ManifestContentsConditions> Conditions = default(List<ManifestContentsConditions>), ManifestContentsPayload Payload = default(ManifestContentsPayload), List<ManifestContentsPayloadInfoPayloadReference> Aliases = default(List<ManifestContentsPayloadInfoPayloadReference>))
        {
            this.Nonce = Nonce;
            this.VendorId = VendorId;
            this.ManifestVersion = ManifestVersion;
            this.Description = Description;
            this.PayloadInfo = PayloadInfo;
            this.DigestAlgorithm = DigestAlgorithm;
            this.Text = Text;
            this.EncryptionMode = EncryptionMode;
            this.ApplyImmediately = ApplyImmediately;
            this.Directives = Directives;
            this.DeviceId = DeviceId;
            this.Timestamp = Timestamp;
            this.ClassId = ClassId;
            this.Dependenices = Dependenices;
            this.Conditions = Conditions;
            this.Payload = Payload;
            this.Aliases = Aliases;
        }
        
        /// <summary>
        /// A 128-bit random field
        /// </summary>
        /// <value>A 128-bit random field</value>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; set; }
        /// <summary>
        /// Hex representation of the 128-bit RFC4122 GUID that represents the vendor.
        /// </summary>
        /// <value>Hex representation of the 128-bit RFC4122 GUID that represents the vendor.</value>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public string VendorId { get; set; }
        /// <summary>
        /// The version of the manifest format being used.
        /// </summary>
        /// <value>The version of the manifest format being used.</value>
        [DataMember(Name="manifestVersion", EmitDefaultValue=false)]
        public string ManifestVersion { get; set; }
        /// <summary>
        /// A short description of the update.
        /// </summary>
        /// <value>A short description of the update.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets PayloadInfo
        /// </summary>
        [DataMember(Name="payloadInfo", EmitDefaultValue=false)]
        public ManifestContentsPayloadInfo PayloadInfo { get; set; }
        /// <summary>
        /// Gets or Sets DigestAlgorithm
        /// </summary>
        [DataMember(Name="digestAlgorithm", EmitDefaultValue=false)]
        public ManifestContentsDigestAlgorithm DigestAlgorithm { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public List<ManifestContentsText> Text { get; set; }
        /// <summary>
        /// Gets or Sets EncryptionMode
        /// </summary>
        [DataMember(Name="encryptionMode", EmitDefaultValue=false)]
        public ManifestContentsEncryptionMode EncryptionMode { get; set; }
        /// <summary>
        /// A flag that indicates that the update described by the manifest should be applied as soon as possible.
        /// </summary>
        /// <value>A flag that indicates that the update described by the manifest should be applied as soon as possible.</value>
        [DataMember(Name="applyImmediately", EmitDefaultValue=false)]
        public bool? ApplyImmediately { get; set; }
        /// <summary>
        /// Gets or Sets Directives
        /// </summary>
        [DataMember(Name="directives", EmitDefaultValue=false)]
        public List<ManifestContentsDirectives> Directives { get; set; }
        /// <summary>
        /// Hex representation of the 128-bit RFC4122 GUID that uniquely identifies the device. Each device has a single, unique device ID.
        /// </summary>
        /// <value>Hex representation of the 128-bit RFC4122 GUID that uniquely identifies the device. Each device has a single, unique device ID.</value>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
        /// <summary>
        /// The time the manifest was created. The timestamp is stored as Unix time.
        /// </summary>
        /// <value>The time the manifest was created. The timestamp is stored as Unix time.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }
        /// <summary>
        /// Hex representation of the 128-bit RFC4122 GUID that represents the device class that the update targets.
        /// </summary>
        /// <value>Hex representation of the 128-bit RFC4122 GUID that represents the device class that the update targets.</value>
        [DataMember(Name="classId", EmitDefaultValue=false)]
        public string ClassId { get; set; }
        /// <summary>
        /// Gets or Sets Dependenices
        /// </summary>
        [DataMember(Name="dependenices", EmitDefaultValue=false)]
        public List<ManifestContentsPayloadInfoPayloadReference> Dependenices { get; set; }
        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<ManifestContentsConditions> Conditions { get; set; }
        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public ManifestContentsPayload Payload { get; set; }
        /// <summary>
        /// Gets or Sets Aliases
        /// </summary>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public List<ManifestContentsPayloadInfoPayloadReference> Aliases { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestContents {\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  ManifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PayloadInfo: ").Append(PayloadInfo).Append("\n");
            sb.Append("  DigestAlgorithm: ").Append(DigestAlgorithm).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  EncryptionMode: ").Append(EncryptionMode).Append("\n");
            sb.Append("  ApplyImmediately: ").Append(ApplyImmediately).Append("\n");
            sb.Append("  Directives: ").Append(Directives).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ClassId: ").Append(ClassId).Append("\n");
            sb.Append("  Dependenices: ").Append(Dependenices).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
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
            return this.Equals(obj as ManifestContents);
        }

        /// <summary>
        /// Returns true if ManifestContents instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestContents other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nonce == other.Nonce ||
                    this.Nonce != null &&
                    this.Nonce.Equals(other.Nonce)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.ManifestVersion == other.ManifestVersion ||
                    this.ManifestVersion != null &&
                    this.ManifestVersion.Equals(other.ManifestVersion)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.PayloadInfo == other.PayloadInfo ||
                    this.PayloadInfo != null &&
                    this.PayloadInfo.Equals(other.PayloadInfo)
                ) && 
                (
                    this.DigestAlgorithm == other.DigestAlgorithm ||
                    this.DigestAlgorithm != null &&
                    this.DigestAlgorithm.Equals(other.DigestAlgorithm)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.SequenceEqual(other.Text)
                ) && 
                (
                    this.EncryptionMode == other.EncryptionMode ||
                    this.EncryptionMode != null &&
                    this.EncryptionMode.Equals(other.EncryptionMode)
                ) && 
                (
                    this.ApplyImmediately == other.ApplyImmediately ||
                    this.ApplyImmediately != null &&
                    this.ApplyImmediately.Equals(other.ApplyImmediately)
                ) && 
                (
                    this.Directives == other.Directives ||
                    this.Directives != null &&
                    this.Directives.SequenceEqual(other.Directives)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.ClassId == other.ClassId ||
                    this.ClassId != null &&
                    this.ClassId.Equals(other.ClassId)
                ) && 
                (
                    this.Dependenices == other.Dependenices ||
                    this.Dependenices != null &&
                    this.Dependenices.SequenceEqual(other.Dependenices)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) && 
                (
                    this.Aliases == other.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.SequenceEqual(other.Aliases)
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
                if (this.Nonce != null)
                    hash = hash * 59 + this.Nonce.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                if (this.ManifestVersion != null)
                    hash = hash * 59 + this.ManifestVersion.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.PayloadInfo != null)
                    hash = hash * 59 + this.PayloadInfo.GetHashCode();
                if (this.DigestAlgorithm != null)
                    hash = hash * 59 + this.DigestAlgorithm.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.EncryptionMode != null)
                    hash = hash * 59 + this.EncryptionMode.GetHashCode();
                if (this.ApplyImmediately != null)
                    hash = hash * 59 + this.ApplyImmediately.GetHashCode();
                if (this.Directives != null)
                    hash = hash * 59 + this.Directives.GetHashCode();
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.ClassId != null)
                    hash = hash * 59 + this.ClassId.GetHashCode();
                if (this.Dependenices != null)
                    hash = hash * 59 + this.Dependenices.GetHashCode();
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                if (this.Aliases != null)
                    hash = hash * 59 + this.Aliases.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
