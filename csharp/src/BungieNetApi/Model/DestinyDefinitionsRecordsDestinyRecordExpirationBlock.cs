/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// If this record has an expiration after which it cannot be earned, this is some information about that expiration.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsRecordsDestinyRecordExpirationBlock :  IEquatable<DestinyDefinitionsRecordsDestinyRecordExpirationBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsRecordsDestinyRecordExpirationBlock" /> class.
        /// </summary>
        /// <param name="hasExpiration">hasExpiration.</param>
        /// <param name="description">description.</param>
        /// <param name="icon">icon.</param>
        public DestinyDefinitionsRecordsDestinyRecordExpirationBlock(bool hasExpiration = default(bool), string description = default(string), string icon = default(string))
        {
            this.HasExpiration = hasExpiration;
            this.Description = description;
            this.Icon = icon;
        }
        
        /// <summary>
        /// Gets or Sets HasExpiration
        /// </summary>
        [DataMember(Name="hasExpiration", EmitDefaultValue=false)]
        public bool HasExpiration { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsRecordsDestinyRecordExpirationBlock {\n");
            sb.Append("  HasExpiration: ").Append(HasExpiration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as DestinyDefinitionsRecordsDestinyRecordExpirationBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsRecordsDestinyRecordExpirationBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsRecordsDestinyRecordExpirationBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsRecordsDestinyRecordExpirationBlock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasExpiration == input.HasExpiration ||
                    (this.HasExpiration != null &&
                    this.HasExpiration.Equals(input.HasExpiration))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
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
                if (this.HasExpiration != null)
                    hashCode = hashCode * 59 + this.HasExpiration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
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
