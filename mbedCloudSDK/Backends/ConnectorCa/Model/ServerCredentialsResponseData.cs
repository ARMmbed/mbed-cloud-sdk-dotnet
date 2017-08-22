/* 
 * Connect CA API
 *
 * Connect CA API provides methods to create and get Developer certificate. Also Connect CA provides server-credentials for Bootstarp and LWM2M Server.
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
using SwaggerDateConverter = connector_ca.Client.SwaggerDateConverter;

namespace connector_ca.Model
{
    /// <summary>
    /// ServerCredentialsResponseData
    /// </summary>
    [DataContract]
    public partial class ServerCredentialsResponseData :  IEquatable<ServerCredentialsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerCredentialsResponseData" /> class.
        /// </summary>
        /// <param name="ServerUri">The server URI to which the client needs to connect to..</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="_Object">The entity name, always &#x60;server-credentials&#x60;..</param>
        /// <param name="ServerCertificate">The PEM format X.509 server certificate that is used to validate the server certificate that is received during the TLS/DTLS handshake..</param>
        /// <param name="Etag">API resource entity version..</param>
        /// <param name="Id">The mUUID that uniquely identifies the entity..</param>
        public ServerCredentialsResponseData(string ServerUri = default(string), string CreatedAt = default(string), string _Object = default(string), string ServerCertificate = default(string), string Etag = default(string), string Id = default(string))
        {
            this.ServerUri = ServerUri;
            this.CreatedAt = CreatedAt;
            this._Object = _Object;
            this.ServerCertificate = ServerCertificate;
            this.Etag = Etag;
            this.Id = Id;
        }
        
        /// <summary>
        /// The server URI to which the client needs to connect to.
        /// </summary>
        /// <value>The server URI to which the client needs to connect to.</value>
        [DataMember(Name="server_uri", EmitDefaultValue=false)]
        public string ServerUri { get; set; }

        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The entity name, always &#x60;server-credentials&#x60;.
        /// </summary>
        /// <value>The entity name, always &#x60;server-credentials&#x60;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// The PEM format X.509 server certificate that is used to validate the server certificate that is received during the TLS/DTLS handshake.
        /// </summary>
        /// <value>The PEM format X.509 server certificate that is used to validate the server certificate that is received during the TLS/DTLS handshake.</value>
        [DataMember(Name="server_certificate", EmitDefaultValue=false)]
        public string ServerCertificate { get; set; }

        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// The mUUID that uniquely identifies the entity.
        /// </summary>
        /// <value>The mUUID that uniquely identifies the entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerCredentialsResponseData {\n");
            sb.Append("  ServerUri: ").Append(ServerUri).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  ServerCertificate: ").Append(ServerCertificate).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ServerCredentialsResponseData);
        }

        /// <summary>
        /// Returns true if ServerCredentialsResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerCredentialsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerCredentialsResponseData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServerUri == other.ServerUri ||
                    this.ServerUri != null &&
                    this.ServerUri.Equals(other.ServerUri)
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
                    this.ServerCertificate == other.ServerCertificate ||
                    this.ServerCertificate != null &&
                    this.ServerCertificate.Equals(other.ServerCertificate)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.ServerUri != null)
                    hash = hash * 59 + this.ServerUri.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.ServerCertificate != null)
                    hash = hash * 59 + this.ServerCertificate.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
