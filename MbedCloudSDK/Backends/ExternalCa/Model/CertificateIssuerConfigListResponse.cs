/* 
 * <auto-generated>
 * Third party CA management API
 *
 * API for managing third party CA for creating certificates on Pelion Device Management
 *
 * OpenAPI spec version: v3
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
using SwaggerDateConverter = external_ca.Client.SwaggerDateConverter;

namespace external_ca.Model
{
    /// <summary>
    /// CertificateIssuerConfigListResponse
    /// </summary>
    [DataContract]
    public partial class CertificateIssuerConfigListResponse :  IEquatable<CertificateIssuerConfigListResponse>, IValidatableObject
    {
        /// <summary>
        /// Describes the type of objects in the list.
        /// </summary>
        /// <value>Describes the type of objects in the list.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum List for "list"
            /// </summary>
            [EnumMember(Value = "list")]
            List
        }

        /// <summary>
        /// The order of results.
        /// </summary>
        /// <value>The order of results.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum ASC for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC,
            
            /// <summary>
            /// Enum DESC for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC
        }

        /// <summary>
        /// Describes the type of objects in the list.
        /// </summary>
        /// <value>Describes the type of objects in the list.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// The order of results.
        /// </summary>
        /// <value>The order of results.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateIssuerConfigListResponse" /> class.
        /// </summary>
        /// <param name="After">The entity ID to fetch after current result set..</param>
        /// <param name="Data">List of certificate issuers..</param>
        /// <param name="Limit">The number of results returned..</param>
        /// <param name="_Object">Describes the type of objects in the list..</param>
        /// <param name="Order">The order of results..</param>
        /// <param name="TotalCount">The total number or records..</param>
        public CertificateIssuerConfigListResponse(string After = default(string), List<CertificateIssuerConfigResponse> Data = default(List<CertificateIssuerConfigResponse>), int? Limit = default(int?), ObjectEnum? _Object = default(ObjectEnum?), OrderEnum? Order = default(OrderEnum?), int? TotalCount = default(int?))
        {
            this.After = After;
            this.Data = Data;
            this.Limit = Limit;
            this._Object = _Object;
            this.Order = Order;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// The entity ID to fetch after current result set.
        /// </summary>
        /// <value>The entity ID to fetch after current result set.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }

        /// <summary>
        /// List of certificate issuers.
        /// </summary>
        /// <value>List of certificate issuers.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<CertificateIssuerConfigResponse> Data { get; set; }

        /// <summary>
        /// The number of results returned.
        /// </summary>
        /// <value>The number of results returned.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }



        /// <summary>
        /// The total number or records.
        /// </summary>
        /// <value>The total number or records.</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateIssuerConfigListResponse {\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as CertificateIssuerConfigListResponse);
        }

        /// <summary>
        /// Returns true if CertificateIssuerConfigListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateIssuerConfigListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateIssuerConfigListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.After == input.After ||
                    (this.After != null &&
                    this.After.Equals(input.After))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.After != null)
                    hashCode = hashCode * 59 + this.After.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
