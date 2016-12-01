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

namespace firmware_catalog.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FirmwareImageSerializer :  IEquatable<FirmwareImageSerializer>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareImageSerializer" /> class.
        /// Initializes a new instance of the <see cref="FirmwareImageSerializer" />class.
        /// </summary>
        /// <param name="Datafile">The binary file of firmware image (required).</param>
        /// <param name="Description">The description of the object (required).</param>
        /// <param name="CreatedAt">The time the object was created (required).</param>
        /// <param name="_Object">The API resource entity (required).</param>
        /// <param name="UpdatedAt">The time the object was updated (required).</param>
        /// <param name="ImageId">DEPRECATED: The ID of the firmware image (required).</param>
        /// <param name="Etag">The entity instance signature (required).</param>
        /// <param name="DatafileChecksum">Checksum generated for the datafile (required).</param>
        /// <param name="Id">The ID of the firmware image (required).</param>
        /// <param name="Name">The name of the object (required).</param>

        public FirmwareImageSerializer(string Datafile = null, string Description = null, DateTime? CreatedAt = null, string _Object = null, DateTime? UpdatedAt = null, string ImageId = null, DateTime? Etag = null, string DatafileChecksum = null, string Id = null, string Name = null)
        {
            // to ensure "Datafile" is required (not null)
            if (Datafile == null)
            {
                throw new InvalidDataException("Datafile is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.Datafile = Datafile;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "ImageId" is required (not null)
            if (ImageId == null)
            {
                throw new InvalidDataException("ImageId is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.ImageId = ImageId;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "DatafileChecksum" is required (not null)
            if (DatafileChecksum == null)
            {
                throw new InvalidDataException("DatafileChecksum is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.DatafileChecksum = DatafileChecksum;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FirmwareImageSerializer and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
        }
        
    
        /// <summary>
        /// The binary file of firmware image
        /// </summary>
        /// <value>The binary file of firmware image</value>
        [DataMember(Name="datafile", EmitDefaultValue=false)]
        public string Datafile { get; set; }
    
        /// <summary>
        /// The description of the object
        /// </summary>
        /// <value>The description of the object</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// The time the object was created
        /// </summary>
        /// <value>The time the object was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
    
        /// <summary>
        /// The API resource entity
        /// </summary>
        /// <value>The API resource entity</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
    
        /// <summary>
        /// The time the object was updated
        /// </summary>
        /// <value>The time the object was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
    
        /// <summary>
        /// DEPRECATED: The ID of the firmware image
        /// </summary>
        /// <value>DEPRECATED: The ID of the firmware image</value>
        [DataMember(Name="image_id", EmitDefaultValue=false)]
        public string ImageId { get; set; }
    
        /// <summary>
        /// The entity instance signature
        /// </summary>
        /// <value>The entity instance signature</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }
    
        /// <summary>
        /// Checksum generated for the datafile
        /// </summary>
        /// <value>Checksum generated for the datafile</value>
        [DataMember(Name="datafile_checksum", EmitDefaultValue=false)]
        public string DatafileChecksum { get; set; }
    
        /// <summary>
        /// The ID of the firmware image
        /// </summary>
        /// <value>The ID of the firmware image</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The name of the object
        /// </summary>
        /// <value>The name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareImageSerializer {\n");
            sb.Append("  Datafile: ").Append(Datafile).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  DatafileChecksum: ").Append(DatafileChecksum).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as FirmwareImageSerializer);
        }

        /// <summary>
        /// Returns true if FirmwareImageSerializer instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareImageSerializer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareImageSerializer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Datafile == other.Datafile ||
                    this.Datafile != null &&
                    this.Datafile.Equals(other.Datafile)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ImageId == other.ImageId ||
                    this.ImageId != null &&
                    this.ImageId.Equals(other.ImageId)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.DatafileChecksum == other.DatafileChecksum ||
                    this.DatafileChecksum != null &&
                    this.DatafileChecksum.Equals(other.DatafileChecksum)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Datafile != null)
                    hash = hash * 59 + this.Datafile.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                if (this.ImageId != null)
                    hash = hash * 59 + this.ImageId.GetHashCode();
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.DatafileChecksum != null)
                    hash = hash * 59 + this.DatafileChecksum.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
