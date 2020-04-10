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
    /// Items can have Energy Capacity, and plugs can provide that capacity such as on a piece of Armor in Armor 2.0. This is how much \&quot;Energy\&quot; can be spent on activating plugs for this item.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsItemsDestinyEnergyCapacityEntry :  IEquatable<DestinyDefinitionsItemsDestinyEnergyCapacityEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsItemsDestinyEnergyCapacityEntry" /> class.
        /// </summary>
        /// <param name="capacityValue">How much energy capacity this plug provides..</param>
        /// <param name="energyTypeHash">Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity..</param>
        /// <param name="energyType">The Energy Type for this energy capacity, in enum form for easy use..</param>
        public DestinyDefinitionsItemsDestinyEnergyCapacityEntry(int capacityValue = default(int), int energyTypeHash = default(int), int energyType = default(int))
        {
            this.CapacityValue = capacityValue;
            this.EnergyTypeHash = energyTypeHash;
            this.EnergyType = energyType;
        }
        
        /// <summary>
        /// How much energy capacity this plug provides.
        /// </summary>
        /// <value>How much energy capacity this plug provides.</value>
        [DataMember(Name="capacityValue", EmitDefaultValue=false)]
        public int CapacityValue { get; set; }

        /// <summary>
        /// Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.
        /// </summary>
        /// <value>Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.</value>
        [DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
        public int EnergyTypeHash { get; set; }

        /// <summary>
        /// The Energy Type for this energy capacity, in enum form for easy use.
        /// </summary>
        /// <value>The Energy Type for this energy capacity, in enum form for easy use.</value>
        [DataMember(Name="energyType", EmitDefaultValue=false)]
        public int EnergyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsItemsDestinyEnergyCapacityEntry {\n");
            sb.Append("  CapacityValue: ").Append(CapacityValue).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsItemsDestinyEnergyCapacityEntry);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsItemsDestinyEnergyCapacityEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsItemsDestinyEnergyCapacityEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsItemsDestinyEnergyCapacityEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityValue == input.CapacityValue ||
                    this.CapacityValue.Equals(input.CapacityValue)
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
                hashCode = hashCode * 59 + this.CapacityValue.GetHashCode();
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
