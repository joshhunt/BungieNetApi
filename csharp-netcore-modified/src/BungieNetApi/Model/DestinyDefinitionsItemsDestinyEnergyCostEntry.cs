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
    /// Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a \&quot;masterworks-like\&quot; mechanic for upgrading). If a plug has costs, the details of that cost are defined here.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsItemsDestinyEnergyCostEntry :  IEquatable<DestinyDefinitionsItemsDestinyEnergyCostEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsItemsDestinyEnergyCostEntry" /> class.
        /// </summary>
        /// <param name="energyCost">The Energy cost for inserting this plug..</param>
        /// <param name="energyTypeHash">The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type..</param>
        /// <param name="energyType">The type of energy that this plug costs, in enum form..</param>
        public DestinyDefinitionsItemsDestinyEnergyCostEntry(int energyCost = default(int), int energyTypeHash = default(int), int energyType = default(int))
        {
            this.EnergyCost = energyCost;
            this.EnergyTypeHash = energyTypeHash;
            this.EnergyType = energyType;
        }
        
        /// <summary>
        /// The Energy cost for inserting this plug.
        /// </summary>
        /// <value>The Energy cost for inserting this plug.</value>
        [DataMember(Name="energyCost", EmitDefaultValue=false)]
        public int EnergyCost { get; set; }

        /// <summary>
        /// The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.
        /// </summary>
        /// <value>The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.</value>
        [DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
        public int EnergyTypeHash { get; set; }

        /// <summary>
        /// The type of energy that this plug costs, in enum form.
        /// </summary>
        /// <value>The type of energy that this plug costs, in enum form.</value>
        [DataMember(Name="energyType", EmitDefaultValue=false)]
        public int EnergyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsItemsDestinyEnergyCostEntry {\n");
            sb.Append("  EnergyCost: ").Append(EnergyCost).Append("\n");
            sb.Append("  EnergyTypeHash: ").Append(EnergyTypeHash).Append("\n");
            sb.Append("  EnergyType: ").Append(EnergyType).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsItemsDestinyEnergyCostEntry);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsItemsDestinyEnergyCostEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsItemsDestinyEnergyCostEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsItemsDestinyEnergyCostEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnergyCost == input.EnergyCost ||
                    this.EnergyCost.Equals(input.EnergyCost)
                ) && 
                (
                    this.EnergyTypeHash == input.EnergyTypeHash ||
                    this.EnergyTypeHash.Equals(input.EnergyTypeHash)
                ) && 
                (
                    this.EnergyType == input.EnergyType ||
                    this.EnergyType.Equals(input.EnergyType)
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
                hashCode = hashCode * 59 + this.EnergyCost.GetHashCode();
                hashCode = hashCode * 59 + this.EnergyTypeHash.GetHashCode();
                hashCode = hashCode * 59 + this.EnergyType.GetHashCode();
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
