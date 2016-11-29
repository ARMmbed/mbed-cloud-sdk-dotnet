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
    public partial class NotificationMessage :  IEquatable<NotificationMessage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationMessage" /> class.
        /// Initializes a new instance of the <see cref="NotificationMessage" />class.
        /// </summary>
        /// <param name="AsyncResponses">AsyncResponses.</param>
        /// <param name="DeRegistrations">DeRegistrations.</param>
        /// <param name="RegUpdates">RegUpdates.</param>
        /// <param name="Registrations">Registrations.</param>
        /// <param name="Notifications">Notifications.</param>
        /// <param name="RegistrationsExpired">RegistrationsExpired.</param>

        public NotificationMessage(List<AsyncIDResponse> AsyncResponses = null, List<string> DeRegistrations = null, List<EndpointData> RegUpdates = null, List<EndpointData> Registrations = null, List<NotificationData> Notifications = null, List<string> RegistrationsExpired = null)
        {
            this.AsyncResponses = AsyncResponses;
            this.DeRegistrations = DeRegistrations;
            this.RegUpdates = RegUpdates;
            this.Registrations = Registrations;
            this.Notifications = Notifications;
            this.RegistrationsExpired = RegistrationsExpired;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AsyncResponses
        /// </summary>
        [DataMember(Name="async-responses", EmitDefaultValue=false)]
        public List<AsyncIDResponse> AsyncResponses { get; set; }
    
        /// <summary>
        /// Gets or Sets DeRegistrations
        /// </summary>
        [DataMember(Name="de-registrations", EmitDefaultValue=false)]
        public List<string> DeRegistrations { get; set; }
    
        /// <summary>
        /// Gets or Sets RegUpdates
        /// </summary>
        [DataMember(Name="reg-updates", EmitDefaultValue=false)]
        public List<EndpointData> RegUpdates { get; set; }
    
        /// <summary>
        /// Gets or Sets Registrations
        /// </summary>
        [DataMember(Name="registrations", EmitDefaultValue=false)]
        public List<EndpointData> Registrations { get; set; }
    
        /// <summary>
        /// Gets or Sets Notifications
        /// </summary>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public List<NotificationData> Notifications { get; set; }
    
        /// <summary>
        /// Gets or Sets RegistrationsExpired
        /// </summary>
        [DataMember(Name="registrations-expired", EmitDefaultValue=false)]
        public List<string> RegistrationsExpired { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationMessage {\n");
            sb.Append("  AsyncResponses: ").Append(AsyncResponses).Append("\n");
            sb.Append("  DeRegistrations: ").Append(DeRegistrations).Append("\n");
            sb.Append("  RegUpdates: ").Append(RegUpdates).Append("\n");
            sb.Append("  Registrations: ").Append(Registrations).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  RegistrationsExpired: ").Append(RegistrationsExpired).Append("\n");
            
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
            return this.Equals(obj as NotificationMessage);
        }

        /// <summary>
        /// Returns true if NotificationMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AsyncResponses == other.AsyncResponses ||
                    this.AsyncResponses != null &&
                    this.AsyncResponses.SequenceEqual(other.AsyncResponses)
                ) && 
                (
                    this.DeRegistrations == other.DeRegistrations ||
                    this.DeRegistrations != null &&
                    this.DeRegistrations.SequenceEqual(other.DeRegistrations)
                ) && 
                (
                    this.RegUpdates == other.RegUpdates ||
                    this.RegUpdates != null &&
                    this.RegUpdates.SequenceEqual(other.RegUpdates)
                ) && 
                (
                    this.Registrations == other.Registrations ||
                    this.Registrations != null &&
                    this.Registrations.SequenceEqual(other.Registrations)
                ) && 
                (
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.SequenceEqual(other.Notifications)
                ) && 
                (
                    this.RegistrationsExpired == other.RegistrationsExpired ||
                    this.RegistrationsExpired != null &&
                    this.RegistrationsExpired.SequenceEqual(other.RegistrationsExpired)
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
                
                if (this.AsyncResponses != null)
                    hash = hash * 59 + this.AsyncResponses.GetHashCode();
                
                if (this.DeRegistrations != null)
                    hash = hash * 59 + this.DeRegistrations.GetHashCode();
                
                if (this.RegUpdates != null)
                    hash = hash * 59 + this.RegUpdates.GetHashCode();
                
                if (this.Registrations != null)
                    hash = hash * 59 + this.Registrations.GetHashCode();
                
                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();
                
                if (this.RegistrationsExpired != null)
                    hash = hash * 59 + this.RegistrationsExpired.GetHashCode();
                
                return hash;
            }
        }

    }
}
