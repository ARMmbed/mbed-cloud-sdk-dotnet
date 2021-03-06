/* 
 * <auto-generated>
 * Billing API
 *
 * Billing API allows users to retrieve billing reports and service package details.
 *
 * OpenAPI spec version: 1.4.7
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
using SwaggerDateConverter = billing.Client.SwaggerDateConverter;

namespace billing.Model
{
    /// <summary>
    /// Quota history of the service package.
    /// </summary>
    [DataContract]
    public partial class ServicePackageQuotaHistoryResponse :  IEquatable<ServicePackageQuotaHistoryResponse>, IValidatableObject
    {
        /// <summary>
        /// Always set to &#39;service-package-quota-history&#39;.
        /// </summary>
        /// <value>Always set to &#39;service-package-quota-history&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum History for "service-package-quota-history"
            /// </summary>
            [EnumMember(Value = "service-package-quota-history")]
            History
        }

        /// <summary>
        /// Always set to &#39;service-package-quota-history&#39;.
        /// </summary>
        /// <value>Always set to &#39;service-package-quota-history&#39;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePackageQuotaHistoryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServicePackageQuotaHistoryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePackageQuotaHistoryResponse" /> class.
        /// </summary>
        /// <param name="After">After which quota history ID this paged response is fetched..</param>
        /// <param name="Data">List of history items, empty list if no entries are available. (required).</param>
        /// <param name="HasMore">If there is next available quota history paged response to be fetched. (required).</param>
        /// <param name="Limit">Maximum amount of quota history entries contained in one paged response. (required).</param>
        /// <param name="_Object">Always set to &#39;service-package-quota-history&#39;. (required).</param>
        /// <param name="TotalCount">Sum of all quota history entries that should be returned (required).</param>
        public ServicePackageQuotaHistoryResponse(string After = default(string), List<ServicePackageQuotaHistoryItem> Data = default(List<ServicePackageQuotaHistoryItem>), bool? HasMore = default(bool?), int? Limit = default(int?), ObjectEnum? _Object = default(ObjectEnum?), int? TotalCount = default(int?))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for ServicePackageQuotaHistoryResponse and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            // to ensure "HasMore" is required (not null)
            if (HasMore == null)
            {
                throw new InvalidDataException("HasMore is a required property for ServicePackageQuotaHistoryResponse and cannot be null");
            }
            else
            {
                this.HasMore = HasMore;
            }
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for ServicePackageQuotaHistoryResponse and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for ServicePackageQuotaHistoryResponse and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "TotalCount" is required (not null)
            if (TotalCount == null)
            {
                throw new InvalidDataException("TotalCount is a required property for ServicePackageQuotaHistoryResponse and cannot be null");
            }
            else
            {
                this.TotalCount = TotalCount;
            }
            this.After = After;
        }
        
        /// <summary>
        /// After which quota history ID this paged response is fetched.
        /// </summary>
        /// <value>After which quota history ID this paged response is fetched.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }

        /// <summary>
        /// List of history items, empty list if no entries are available.
        /// </summary>
        /// <value>List of history items, empty list if no entries are available.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<ServicePackageQuotaHistoryItem> Data { get; set; }

        /// <summary>
        /// If there is next available quota history paged response to be fetched.
        /// </summary>
        /// <value>If there is next available quota history paged response to be fetched.</value>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Maximum amount of quota history entries contained in one paged response.
        /// </summary>
        /// <value>Maximum amount of quota history entries contained in one paged response.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }


        /// <summary>
        /// Sum of all quota history entries that should be returned
        /// </summary>
        /// <value>Sum of all quota history entries that should be returned</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePackageQuotaHistoryResponse {\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
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
            return this.Equals(input as ServicePackageQuotaHistoryResponse);
        }

        /// <summary>
        /// Returns true if ServicePackageQuotaHistoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicePackageQuotaHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePackageQuotaHistoryResponse input)
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
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
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
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
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
            // After (string) maxLength
            if(this.After != null && this.After.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for After, length must be less than 32.", new [] { "After" });
            }

            // After (string) minLength
            if(this.After != null && this.After.Length < 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for After, length must be greater than 32.", new [] { "After" });
            }

            // Limit (int?) maximum
            if(this.Limit > (int?)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value less than or equal to 1000.", new [] { "Limit" });
            }

            // Limit (int?) minimum
            if(this.Limit < (int?)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 2.", new [] { "Limit" });
            }

            // TotalCount (int?) minimum
            if(this.TotalCount < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalCount, must be a value greater than or equal to 0.", new [] { "TotalCount" });
            }

            yield break;
        }
    }

}
