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
    /// These definitions represent faction vendors at different points in the game.  A single faction may contain multiple vendors, or the same vendor available at two different locations.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyFactionVendorDefinition :  IEquatable<DestinyDefinitionsDestinyFactionVendorDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyFactionVendorDefinition" /> class.
        /// </summary>
        /// <param name="vendorHash">The faction vendor hash..</param>
        /// <param name="destinationHash">The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry..</param>
        /// <param name="backgroundImagePath">The relative path to the background image representing this Vendor at this location, for use in a banner..</param>
        public DestinyDefinitionsDestinyFactionVendorDefinition(int vendorHash = default(int), int destinationHash = default(int), string backgroundImagePath = default(string))
        {
            this.VendorHash = vendorHash;
            this.DestinationHash = destinationHash;
            this.BackgroundImagePath = backgroundImagePath;
        }
        
        /// <summary>
        /// The faction vendor hash.
        /// </summary>
        /// <value>The faction vendor hash.</value>
        [DataMember(Name="vendorHash", EmitDefaultValue=false)]
        public int VendorHash { get; set; }

        /// <summary>
        /// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
        /// </summary>
        /// <value>The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.</value>
        [DataMember(Name="destinationHash", EmitDefaultValue=false)]
        public int DestinationHash { get; set; }

        /// <summary>
        /// The relative path to the background image representing this Vendor at this location, for use in a banner.
        /// </summary>
        /// <value>The relative path to the background image representing this Vendor at this location, for use in a banner.</value>
        [DataMember(Name="backgroundImagePath", EmitDefaultValue=false)]
        public string BackgroundImagePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyFactionVendorDefinition {\n");
            sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
            sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
            sb.Append("  BackgroundImagePath: ").Append(BackgroundImagePath).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyFactionVendorDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyFactionVendorDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyFactionVendorDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyFactionVendorDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorHash == input.VendorHash ||
                    (this.VendorHash != null &&
                    this.VendorHash.Equals(input.VendorHash))
                ) && 
                (
                    this.DestinationHash == input.DestinationHash ||
                    (this.DestinationHash != null &&
                    this.DestinationHash.Equals(input.DestinationHash))
                ) && 
                (
                    this.BackgroundImagePath == input.BackgroundImagePath ||
                    (this.BackgroundImagePath != null &&
                    this.BackgroundImagePath.Equals(input.BackgroundImagePath))
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
                if (this.VendorHash != null)
                    hashCode = hashCode * 59 + this.VendorHash.GetHashCode();
                if (this.DestinationHash != null)
                    hashCode = hashCode * 59 + this.DestinationHash.GetHashCode();
                if (this.BackgroundImagePath != null)
                    hashCode = hashCode * 59 + this.BackgroundImagePath.GetHashCode();
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
