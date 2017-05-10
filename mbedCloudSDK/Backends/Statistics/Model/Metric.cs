/* 
 * Connect Statistics API
 *
 * mbed Cloud Connect Statistics API provides statistics about other cloud services through defined counters.
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

namespace statistics.Model
{
    /// <summary>
    /// Metric
    /// </summary>
    [DataContract]
    public partial class Metric :  IEquatable<Metric>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Metric" /> class.
        /// </summary>
        /// <param name="DeviceServerRestApiError">Number of failed device server REST API requests the account has used..</param>
        /// <param name="BootstrapsFailed">Number of failed bootstraps the account has used..</param>
        /// <param name="Transactions">Number of transaction events from devices linked to the account..</param>
        /// <param name="Timestamp">UTC time in RFC3339 format.</param>
        /// <param name="RegisteredDevices">Maximum number of registered devices linked to the account..</param>
        /// <param name="BootstrapsPending">Number of pending bootstraps the account has used..</param>
        /// <param name="HandshakesFailed">Number of failed handshakes the account has used..</param>
        /// <param name="HandshakesSuccessful">Number of successful handshakes the account has used..</param>
        /// <param name="BootstrapsSuccessful">Number of successful bootstraps the account has used..</param>
        /// <param name="DeviceServerRestApiSuccess">Number of successful device server REST API requests the account has used..</param>
        public Metric(long? DeviceServerRestApiError = default(long?), long? BootstrapsFailed = default(long?), long? Transactions = default(long?), string Timestamp = default(string), long? RegisteredDevices = default(long?), long? BootstrapsPending = default(long?), long? HandshakesFailed = default(long?), long? HandshakesSuccessful = default(long?), long? BootstrapsSuccessful = default(long?), long? DeviceServerRestApiSuccess = default(long?))
        {
            this.DeviceServerRestApiError = DeviceServerRestApiError;
            this.BootstrapsFailed = BootstrapsFailed;
            this.Transactions = Transactions;
            this.Timestamp = Timestamp;
            this.RegisteredDevices = RegisteredDevices;
            this.BootstrapsPending = BootstrapsPending;
            this.HandshakesFailed = HandshakesFailed;
            this.HandshakesSuccessful = HandshakesSuccessful;
            this.BootstrapsSuccessful = BootstrapsSuccessful;
            this.DeviceServerRestApiSuccess = DeviceServerRestApiSuccess;
        }
        
        /// <summary>
        /// Number of failed device server REST API requests the account has used.
        /// </summary>
        /// <value>Number of failed device server REST API requests the account has used.</value>
        [DataMember(Name="device_server_rest_api_error", EmitDefaultValue=false)]
        public long? DeviceServerRestApiError { get; set; }
        /// <summary>
        /// Number of failed bootstraps the account has used.
        /// </summary>
        /// <value>Number of failed bootstraps the account has used.</value>
        [DataMember(Name="bootstraps_failed", EmitDefaultValue=false)]
        public long? BootstrapsFailed { get; set; }
        /// <summary>
        /// Number of transaction events from devices linked to the account.
        /// </summary>
        /// <value>Number of transaction events from devices linked to the account.</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public long? Transactions { get; set; }
        /// <summary>
        /// UTC time in RFC3339 format
        /// </summary>
        /// <value>UTC time in RFC3339 format</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Maximum number of registered devices linked to the account.
        /// </summary>
        /// <value>Maximum number of registered devices linked to the account.</value>
        [DataMember(Name="registered_devices", EmitDefaultValue=false)]
        public long? RegisteredDevices { get; set; }
        /// <summary>
        /// Number of pending bootstraps the account has used.
        /// </summary>
        /// <value>Number of pending bootstraps the account has used.</value>
        [DataMember(Name="bootstraps_pending", EmitDefaultValue=false)]
        public long? BootstrapsPending { get; set; }
        /// <summary>
        /// Number of failed handshakes the account has used.
        /// </summary>
        /// <value>Number of failed handshakes the account has used.</value>
        [DataMember(Name="handshakes_failed", EmitDefaultValue=false)]
        public long? HandshakesFailed { get; set; }
        /// <summary>
        /// Number of successful handshakes the account has used.
        /// </summary>
        /// <value>Number of successful handshakes the account has used.</value>
        [DataMember(Name="handshakes_successful", EmitDefaultValue=false)]
        public long? HandshakesSuccessful { get; set; }
        /// <summary>
        /// Number of successful bootstraps the account has used.
        /// </summary>
        /// <value>Number of successful bootstraps the account has used.</value>
        [DataMember(Name="bootstraps_successful", EmitDefaultValue=false)]
        public long? BootstrapsSuccessful { get; set; }
        /// <summary>
        /// Number of successful device server REST API requests the account has used.
        /// </summary>
        /// <value>Number of successful device server REST API requests the account has used.</value>
        [DataMember(Name="device_server_rest_api_success", EmitDefaultValue=false)]
        public long? DeviceServerRestApiSuccess { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metric {\n");
            sb.Append("  DeviceServerRestApiError: ").Append(DeviceServerRestApiError).Append("\n");
            sb.Append("  BootstrapsFailed: ").Append(BootstrapsFailed).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  RegisteredDevices: ").Append(RegisteredDevices).Append("\n");
            sb.Append("  BootstrapsPending: ").Append(BootstrapsPending).Append("\n");
            sb.Append("  HandshakesFailed: ").Append(HandshakesFailed).Append("\n");
            sb.Append("  HandshakesSuccessful: ").Append(HandshakesSuccessful).Append("\n");
            sb.Append("  BootstrapsSuccessful: ").Append(BootstrapsSuccessful).Append("\n");
            sb.Append("  DeviceServerRestApiSuccess: ").Append(DeviceServerRestApiSuccess).Append("\n");
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
            return this.Equals(obj as Metric);
        }

        /// <summary>
        /// Returns true if Metric instances are equal
        /// </summary>
        /// <param name="other">Instance of Metric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Metric other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceServerRestApiError == other.DeviceServerRestApiError ||
                    this.DeviceServerRestApiError != null &&
                    this.DeviceServerRestApiError.Equals(other.DeviceServerRestApiError)
                ) && 
                (
                    this.BootstrapsFailed == other.BootstrapsFailed ||
                    this.BootstrapsFailed != null &&
                    this.BootstrapsFailed.Equals(other.BootstrapsFailed)
                ) && 
                (
                    this.Transactions == other.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.Equals(other.Transactions)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.RegisteredDevices == other.RegisteredDevices ||
                    this.RegisteredDevices != null &&
                    this.RegisteredDevices.Equals(other.RegisteredDevices)
                ) && 
                (
                    this.BootstrapsPending == other.BootstrapsPending ||
                    this.BootstrapsPending != null &&
                    this.BootstrapsPending.Equals(other.BootstrapsPending)
                ) && 
                (
                    this.HandshakesFailed == other.HandshakesFailed ||
                    this.HandshakesFailed != null &&
                    this.HandshakesFailed.Equals(other.HandshakesFailed)
                ) && 
                (
                    this.HandshakesSuccessful == other.HandshakesSuccessful ||
                    this.HandshakesSuccessful != null &&
                    this.HandshakesSuccessful.Equals(other.HandshakesSuccessful)
                ) && 
                (
                    this.BootstrapsSuccessful == other.BootstrapsSuccessful ||
                    this.BootstrapsSuccessful != null &&
                    this.BootstrapsSuccessful.Equals(other.BootstrapsSuccessful)
                ) && 
                (
                    this.DeviceServerRestApiSuccess == other.DeviceServerRestApiSuccess ||
                    this.DeviceServerRestApiSuccess != null &&
                    this.DeviceServerRestApiSuccess.Equals(other.DeviceServerRestApiSuccess)
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
                if (this.DeviceServerRestApiError != null)
                    hash = hash * 59 + this.DeviceServerRestApiError.GetHashCode();
                if (this.BootstrapsFailed != null)
                    hash = hash * 59 + this.BootstrapsFailed.GetHashCode();
                if (this.Transactions != null)
                    hash = hash * 59 + this.Transactions.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.RegisteredDevices != null)
                    hash = hash * 59 + this.RegisteredDevices.GetHashCode();
                if (this.BootstrapsPending != null)
                    hash = hash * 59 + this.BootstrapsPending.GetHashCode();
                if (this.HandshakesFailed != null)
                    hash = hash * 59 + this.HandshakesFailed.GetHashCode();
                if (this.HandshakesSuccessful != null)
                    hash = hash * 59 + this.HandshakesSuccessful.GetHashCode();
                if (this.BootstrapsSuccessful != null)
                    hash = hash * 59 + this.BootstrapsSuccessful.GetHashCode();
                if (this.DeviceServerRestApiSuccess != null)
                    hash = hash * 59 + this.DeviceServerRestApiSuccess.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
