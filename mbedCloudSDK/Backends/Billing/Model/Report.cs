/* 
 * mbed-billing REST API documentation for API-server
 *
 * This document contains the public REST API definitions of the mbed-billing service's API server component.
 *
 * OpenAPI spec version: 1.3.7-SNAPSHOT
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

namespace billing.Model
{
    /// <summary>
    /// Report
    /// </summary>
    [DataContract]
    public partial class Report :  IEquatable<Report>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Report" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Report() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Report" /> class.
        /// </summary>
        /// <param name="AccountReports">AccountReports (required).</param>
        /// <param name="Month">Month (required).</param>
        public Report(List<AccountReport> AccountReports = default(List<AccountReport>), string Month = default(string))
        {
            // to ensure "AccountReports" is required (not null)
            if (AccountReports == null)
            {
                throw new InvalidDataException("AccountReports is a required property for Report and cannot be null");
            }
            else
            {
                this.AccountReports = AccountReports;
            }
            // to ensure "Month" is required (not null)
            if (Month == null)
            {
                throw new InvalidDataException("Month is a required property for Report and cannot be null");
            }
            else
            {
                this.Month = Month;
            }
        }
        
        /// <summary>
        /// Gets or Sets AccountReports
        /// </summary>
        [DataMember(Name="account_reports", EmitDefaultValue=false)]
        public List<AccountReport> AccountReports { get; set; }
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public string Month { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Report {\n");
            sb.Append("  AccountReports: ").Append(AccountReports).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
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
            return this.Equals(obj as Report);
        }

        /// <summary>
        /// Returns true if Report instances are equal
        /// </summary>
        /// <param name="other">Instance of Report to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Report other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountReports == other.AccountReports ||
                    this.AccountReports != null &&
                    this.AccountReports.SequenceEqual(other.AccountReports)
                ) && 
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
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
                if (this.AccountReports != null)
                    hash = hash * 59 + this.AccountReports.GetHashCode();
                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
