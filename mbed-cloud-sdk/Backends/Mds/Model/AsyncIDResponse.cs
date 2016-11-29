using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace mds.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AsyncIDResponse :  IEquatable<AsyncIDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncIDResponse" /> class.
        /// Initializes a new instance of the <see cref="AsyncIDResponse" />class.
        /// </summary>
        /// <param name="Status">HTTP status code, for example 200 for OK..</param>
        /// <param name="Payload">Requested data, base64 encoded..</param>
        /// <param name="MaxAge">Determines how long this value will be valid in cache, in seconds. 0 means that value won&#39;t be stored in cache..</param>
        /// <param name="Error">Optional error message, describing error..</param>
        /// <param name="Id">Asynchronous response unique ID..</param>
        /// <param name="Ct">Content type.</param>

        public AsyncIDResponse(int? Status = null, string Payload = null, string MaxAge = null, string Error = null, string Id = null, string Ct = null)
        {
            this.Status = Status;
            this.Payload = Payload;
            this.MaxAge = MaxAge;
            this.Error = Error;
            this.Id = Id;
            this.Ct = Ct;
            
        }
        
    
        /// <summary>
        /// HTTP status code, for example 200 for OK.
        /// </summary>
        /// <value>HTTP status code, for example 200 for OK.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Requested data, base64 encoded.
        /// </summary>
        /// <value>Requested data, base64 encoded.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
    
        /// <summary>
        /// Determines how long this value will be valid in cache, in seconds. 0 means that value won&#39;t be stored in cache.
        /// </summary>
        /// <value>Determines how long this value will be valid in cache, in seconds. 0 means that value won&#39;t be stored in cache.</value>
        [DataMember(Name="max-age", EmitDefaultValue=false)]
        public string MaxAge { get; set; }
    
        /// <summary>
        /// Optional error message, describing error.
        /// </summary>
        /// <value>Optional error message, describing error.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
    
        /// <summary>
        /// Asynchronous response unique ID.
        /// </summary>
        /// <value>Asynchronous response unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Content type
        /// </summary>
        /// <value>Content type</value>
        [DataMember(Name="ct", EmitDefaultValue=false)]
        public string Ct { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncIDResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ct: ").Append(Ct).Append("\n");
            
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
            return this.Equals(obj as AsyncIDResponse);
        }

        /// <summary>
        /// Returns true if AsyncIDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncIDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncIDResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) && 
                (
                    this.MaxAge == other.MaxAge ||
                    this.MaxAge != null &&
                    this.MaxAge.Equals(other.MaxAge)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Ct == other.Ct ||
                    this.Ct != null &&
                    this.Ct.Equals(other.Ct)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                
                if (this.MaxAge != null)
                    hash = hash * 59 + this.MaxAge.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Ct != null)
                    hash = hash * 59 + this.Ct.GetHashCode();
                
                return hash;
            }
        }

    }
}
