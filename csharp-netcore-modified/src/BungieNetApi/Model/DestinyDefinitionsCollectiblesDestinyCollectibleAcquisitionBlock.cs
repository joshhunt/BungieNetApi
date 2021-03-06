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
    /// DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock :  IEquatable<DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock" /> class.
        /// </summary>
        /// <param name="acquireMaterialRequirementHash">acquireMaterialRequirementHash.</param>
        /// <param name="acquireTimestampUnlockValueHash">acquireTimestampUnlockValueHash.</param>
        public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock(long acquireMaterialRequirementHash = default(long), long acquireTimestampUnlockValueHash = default(long))
        {
            this.AcquireMaterialRequirementHash = acquireMaterialRequirementHash;
            this.AcquireTimestampUnlockValueHash = acquireTimestampUnlockValueHash;
        }
        
        /// <summary>
        /// Gets or Sets AcquireMaterialRequirementHash
        /// </summary>
        [DataMember(Name="acquireMaterialRequirementHash", EmitDefaultValue=false)]
        public long AcquireMaterialRequirementHash { get; set; }

        /// <summary>
        /// Gets or Sets AcquireTimestampUnlockValueHash
        /// </summary>
        [DataMember(Name="acquireTimestampUnlockValueHash", EmitDefaultValue=false)]
        public long AcquireTimestampUnlockValueHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock {\n");
            sb.Append("  AcquireMaterialRequirementHash: ").Append(AcquireMaterialRequirementHash).Append("\n");
            sb.Append("  AcquireTimestampUnlockValueHash: ").Append(AcquireTimestampUnlockValueHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcquireMaterialRequirementHash == input.AcquireMaterialRequirementHash ||
                    this.AcquireMaterialRequirementHash.Equals(input.AcquireMaterialRequirementHash)
                ) && 
                (
                    this.AcquireTimestampUnlockValueHash == input.AcquireTimestampUnlockValueHash ||
                    this.AcquireTimestampUnlockValueHash.Equals(input.AcquireTimestampUnlockValueHash)
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
                hashCode = hashCode * 59 + this.AcquireMaterialRequirementHash.GetHashCode();
                hashCode = hashCode * 59 + this.AcquireTimestampUnlockValueHash.GetHashCode();
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
