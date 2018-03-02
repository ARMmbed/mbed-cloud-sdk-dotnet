/* 
 * <auto-generated>
 * Connect API
 *
 * Mbed Cloud Connect API allows web applications to communicate with devices. You can subscribe to device resources and read/write values to them. mbed Cloud Connect makes connectivity to devices easy by queuing requests and caching resource values.
 *
 * OpenAPI spec version: 2
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
using SwaggerDateConverter = mds.Client.SwaggerDateConverter;

namespace mds.Model
{
    /// <summary>
    /// ResourcesData
    /// </summary>
    [DataContract]
    public partial class ResourcesData :  IEquatable<ResourcesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesData" /> class.
        /// </summary>
        /// <param name="Rt">Application specific resource type that describes this resource. [It is created by the client side application](/docs/v1.2/collecting/resource-setup-in-mbed-cloud-client.html). Not meant to be a human-readable name for the resource. Multiple resource types may be included, they are separated by a space..</param>
        /// <param name="Path">Resource&#39;s URI path..</param>
        /// <param name="Ct">Content type..</param>
        /// <param name="Obs">Whether the resource is observable or not (true/false)..</param>
        /// <param name="_If">Interface description that defines a name or URI that indicates how to interact with the target resource. It describes a generic interface type, such as a \&quot;sensor\&quot;..</param>
        public ResourcesData(string Rt = default(string), string Path = default(string), string Ct = default(string), bool? Obs = default(bool?), string _If = default(string))
        {
            this.Rt = Rt;
            this.Path = Path;
            this.Ct = Ct;
            this.Obs = Obs;
            this._If = _If;
        }
        
        /// <summary>
        /// Application specific resource type that describes this resource. [It is created by the client side application](/docs/v1.2/collecting/resource-setup-in-mbed-cloud-client.html). Not meant to be a human-readable name for the resource. Multiple resource types may be included, they are separated by a space.
        /// </summary>
        /// <value>Application specific resource type that describes this resource. [It is created by the client side application](/docs/v1.2/collecting/resource-setup-in-mbed-cloud-client.html). Not meant to be a human-readable name for the resource. Multiple resource types may be included, they are separated by a space.</value>
        [DataMember(Name="rt", EmitDefaultValue=false)]
        public string Rt { get; set; }

        /// <summary>
        /// Resource&#39;s URI path.
        /// </summary>
        /// <value>Resource&#39;s URI path.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Content type.
        /// </summary>
        /// <value>Content type.</value>
        [DataMember(Name="ct", EmitDefaultValue=false)]
        public string Ct { get; set; }

        /// <summary>
        /// Whether the resource is observable or not (true/false).
        /// </summary>
        /// <value>Whether the resource is observable or not (true/false).</value>
        [DataMember(Name="obs", EmitDefaultValue=false)]
        public bool? Obs { get; set; }

        /// <summary>
        /// Interface description that defines a name or URI that indicates how to interact with the target resource. It describes a generic interface type, such as a \&quot;sensor\&quot;.
        /// </summary>
        /// <value>Interface description that defines a name or URI that indicates how to interact with the target resource. It describes a generic interface type, such as a \&quot;sensor\&quot;.</value>
        [DataMember(Name="if", EmitDefaultValue=false)]
        public string _If { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesData {\n");
            sb.Append("  Rt: ").Append(Rt).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Ct: ").Append(Ct).Append("\n");
            sb.Append("  Obs: ").Append(Obs).Append("\n");
            sb.Append("  _If: ").Append(_If).Append("\n");
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
            return this.Equals(input as ResourcesData);
        }

        /// <summary>
        /// Returns true if ResourcesData instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourcesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rt == input.Rt ||
                    (this.Rt != null &&
                    this.Rt.Equals(input.Rt))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Ct == input.Ct ||
                    (this.Ct != null &&
                    this.Ct.Equals(input.Ct))
                ) && 
                (
                    this.Obs == input.Obs ||
                    (this.Obs != null &&
                    this.Obs.Equals(input.Obs))
                ) && 
                (
                    this._If == input._If ||
                    (this._If != null &&
                    this._If.Equals(input._If))
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
                if (this.Rt != null)
                    hashCode = hashCode * 59 + this.Rt.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Ct != null)
                    hashCode = hashCode * 59 + this.Ct.GetHashCode();
                if (this.Obs != null)
                    hashCode = hashCode * 59 + this.Obs.GetHashCode();
                if (this._If != null)
                    hashCode = hashCode * 59 + this._If.GetHashCode();
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
            yield break;
        }
    }

}
