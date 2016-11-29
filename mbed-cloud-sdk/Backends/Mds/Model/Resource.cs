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
    public partial class Resource :  IEquatable<Resource>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Resource" /> class.
        /// Initializes a new instance of the <see cref="Resource" />class.
        /// </summary>
        /// <param name="Rt">Resource&#39;s type.</param>
        /// <param name="Type">The content type of the resource.\n&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Important&lt;/b&gt;&lt;br/&gt;\nYou are encouraged to use the resource types listed in the LWM2M specification:\nhttp://technical.openmobilealliance.org/Technical/technical-information/omna/lightweight-m2m-lwm2m-object-registry\n.</param>
        /// <param name="Uri">Resource&#39;s url..</param>
        /// <param name="Obs">Observable determines whether you can subscribe to changes for this resource.\nIt can have values \&quot;true\&quot; or \&quot;false\&quot;.\n.</param>

        public Resource(string Rt = null, string Type = null, string Uri = null, bool? Obs = null)
        {
            this.Rt = Rt;
            this.Type = Type;
            this.Uri = Uri;
            this.Obs = Obs;
            
        }
        
    
        /// <summary>
        /// Resource&#39;s type
        /// </summary>
        /// <value>Resource&#39;s type</value>
        [DataMember(Name="rt", EmitDefaultValue=false)]
        public string Rt { get; set; }
    
        /// <summary>
        /// The content type of the resource.\n&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Important&lt;/b&gt;&lt;br/&gt;\nYou are encouraged to use the resource types listed in the LWM2M specification:\nhttp://technical.openmobilealliance.org/Technical/technical-information/omna/lightweight-m2m-lwm2m-object-registry\n
        /// </summary>
        /// <value>The content type of the resource.\n&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Important&lt;/b&gt;&lt;br/&gt;\nYou are encouraged to use the resource types listed in the LWM2M specification:\nhttp://technical.openmobilealliance.org/Technical/technical-information/omna/lightweight-m2m-lwm2m-object-registry\n</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Resource&#39;s url.
        /// </summary>
        /// <value>Resource&#39;s url.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Observable determines whether you can subscribe to changes for this resource.\nIt can have values \&quot;true\&quot; or \&quot;false\&quot;.\n
        /// </summary>
        /// <value>Observable determines whether you can subscribe to changes for this resource.\nIt can have values \&quot;true\&quot; or \&quot;false\&quot;.\n</value>
        [DataMember(Name="obs", EmitDefaultValue=false)]
        public bool? Obs { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  Rt: ").Append(Rt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Obs: ").Append(Obs).Append("\n");
            
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
            return this.Equals(obj as Resource);
        }

        /// <summary>
        /// Returns true if Resource instances are equal
        /// </summary>
        /// <param name="other">Instance of Resource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Resource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rt == other.Rt ||
                    this.Rt != null &&
                    this.Rt.Equals(other.Rt)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Obs == other.Obs ||
                    this.Obs != null &&
                    this.Obs.Equals(other.Obs)
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
                
                if (this.Rt != null)
                    hash = hash * 59 + this.Rt.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.Obs != null)
                    hash = hash * 59 + this.Obs.GetHashCode();
                
                return hash;
            }
        }

    }
}
