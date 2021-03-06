/* 
 * <auto-generated>
 * Bootstrap API
 *
 * Mbed Cloud Bootstrap API allows web applications to control the device bootstrapping process.
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
using SwaggerDateConverter = connector_bootstrap.Client.SwaggerDateConverter;

namespace connector_bootstrap.Model
{
    /// <summary>
    /// ListOfPreSharedKeysWithoutSecret
    /// </summary>
    [DataContract]
    public partial class ListOfPreSharedKeysWithoutSecret :  IEquatable<ListOfPreSharedKeysWithoutSecret>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfPreSharedKeysWithoutSecret" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListOfPreSharedKeysWithoutSecret() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfPreSharedKeysWithoutSecret" /> class.
        /// </summary>
        /// <param name="After">An offset token for current page..</param>
        /// <param name="ContinuationMarker">An offset token for fetching the next page. Note that exactly the same limit needs to be used on the request for fetching the subsequent pages..</param>
        /// <param name="Data">Array of the pre-shared key entries. The array is empty if there are no pre-shared keys. (required).</param>
        /// <param name="HasMore">Are there more results available. (required).</param>
        /// <param name="Limit">The value of limit query parameter from the request, or default if not specified. (required).</param>
        /// <param name="_Object">The type of this API object is a \&quot;list\&quot;. (required).</param>
        /// <param name="Order">The creation time based order of the entries. (required).</param>
        public ListOfPreSharedKeysWithoutSecret(string After = default(string), string ContinuationMarker = default(string), List<PreSharedKeyWithoutSecret> Data = default(List<PreSharedKeyWithoutSecret>), bool? HasMore = default(bool?), int? Limit = default(int?), string _Object = default(string), string Order = default(string))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for ListOfPreSharedKeysWithoutSecret and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            // to ensure "HasMore" is required (not null)
            if (HasMore == null)
            {
                throw new InvalidDataException("HasMore is a required property for ListOfPreSharedKeysWithoutSecret and cannot be null");
            }
            else
            {
                this.HasMore = HasMore;
            }
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for ListOfPreSharedKeysWithoutSecret and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for ListOfPreSharedKeysWithoutSecret and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Order" is required (not null)
            if (Order == null)
            {
                throw new InvalidDataException("Order is a required property for ListOfPreSharedKeysWithoutSecret and cannot be null");
            }
            else
            {
                this.Order = Order;
            }
            this.After = After;
            this.ContinuationMarker = ContinuationMarker;
        }
        
        /// <summary>
        /// An offset token for current page.
        /// </summary>
        /// <value>An offset token for current page.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }

        /// <summary>
        /// An offset token for fetching the next page. Note that exactly the same limit needs to be used on the request for fetching the subsequent pages.
        /// </summary>
        /// <value>An offset token for fetching the next page. Note that exactly the same limit needs to be used on the request for fetching the subsequent pages.</value>
        [DataMember(Name="continuation_marker", EmitDefaultValue=false)]
        public string ContinuationMarker { get; set; }

        /// <summary>
        /// Array of the pre-shared key entries. The array is empty if there are no pre-shared keys.
        /// </summary>
        /// <value>Array of the pre-shared key entries. The array is empty if there are no pre-shared keys.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<PreSharedKeyWithoutSecret> Data { get; set; }

        /// <summary>
        /// Are there more results available.
        /// </summary>
        /// <value>Are there more results available.</value>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The value of limit query parameter from the request, or default if not specified.
        /// </summary>
        /// <value>The value of limit query parameter from the request, or default if not specified.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The type of this API object is a \&quot;list\&quot;.
        /// </summary>
        /// <value>The type of this API object is a \&quot;list\&quot;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// The creation time based order of the entries.
        /// </summary>
        /// <value>The creation time based order of the entries.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfPreSharedKeysWithoutSecret {\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  ContinuationMarker: ").Append(ContinuationMarker).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as ListOfPreSharedKeysWithoutSecret);
        }

        /// <summary>
        /// Returns true if ListOfPreSharedKeysWithoutSecret instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfPreSharedKeysWithoutSecret to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfPreSharedKeysWithoutSecret input)
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
                    this.ContinuationMarker == input.ContinuationMarker ||
                    (this.ContinuationMarker != null &&
                    this.ContinuationMarker.Equals(input.ContinuationMarker))
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
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.ContinuationMarker != null)
                    hashCode = hashCode * 59 + this.ContinuationMarker.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
