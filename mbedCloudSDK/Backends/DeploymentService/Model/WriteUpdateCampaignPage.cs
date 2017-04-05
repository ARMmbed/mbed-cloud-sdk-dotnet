/* 
 * Deployment Service API
 *
 * This is the API Documentation for the mbed deployment service which is part of the update service.
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

namespace deployment_service.Model
{
    /// <summary>
    /// WriteUpdateCampaignPage
    /// </summary>
    [DataContract]
    public partial class WriteUpdateCampaignPage :  IEquatable<WriteUpdateCampaignPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteUpdateCampaignPage" /> class.
        /// </summary>
        /// <param name="Limit">Limit.</param>
        /// <param name="After">After.</param>
        /// <param name="Data">Data.</param>
        /// <param name="Order">Order.</param>
        public WriteUpdateCampaignPage(long? Limit = default(long?), string After = default(string), List<UpdateCampaign> Data = default(List<UpdateCampaign>), string Order = default(string))
        {
            this.Limit = Limit;
            this.After = After;
            this.Data = Data;
            this.Order = Order;
        }
        
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }
        /// <summary>
        /// Gets or Sets After
        /// </summary>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<UpdateCampaign> Data { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriteUpdateCampaignPage {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WriteUpdateCampaignPage);
        }

        /// <summary>
        /// Returns true if WriteUpdateCampaignPage instances are equal
        /// </summary>
        /// <param name="other">Instance of WriteUpdateCampaignPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteUpdateCampaignPage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
