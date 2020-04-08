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
    /// Talent nodes have requirements that must be met before they can be activated.  This describes the material costs, the Level of the Talent Grid&#39;s progression required, and other conditional information that limits whether a talent node can be activated.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyNodeActivationRequirement :  IEquatable<DestinyDefinitionsDestinyNodeActivationRequirement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyNodeActivationRequirement" /> class.
        /// </summary>
        /// <param name="gridLevel">The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition&#39;s documentation to learn more about Progressions..</param>
        /// <param name="materialRequirementHashes">The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won&#39;t know which one will be chosen until an instance of the item is created..</param>
        public DestinyDefinitionsDestinyNodeActivationRequirement(int gridLevel = default(int), List<int> materialRequirementHashes = default(List<int>))
        {
            this.GridLevel = gridLevel;
            this.MaterialRequirementHashes = materialRequirementHashes;
        }
        
        /// <summary>
        /// The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition&#39;s documentation to learn more about Progressions.
        /// </summary>
        /// <value>The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition&#39;s documentation to learn more about Progressions.</value>
        [DataMember(Name="gridLevel", EmitDefaultValue=false)]
        public int GridLevel { get; set; }

        /// <summary>
        /// The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won&#39;t know which one will be chosen until an instance of the item is created.
        /// </summary>
        /// <value>The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won&#39;t know which one will be chosen until an instance of the item is created.</value>
        [DataMember(Name="materialRequirementHashes", EmitDefaultValue=false)]
        public List<int> MaterialRequirementHashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyNodeActivationRequirement {\n");
            sb.Append("  GridLevel: ").Append(GridLevel).Append("\n");
            sb.Append("  MaterialRequirementHashes: ").Append(MaterialRequirementHashes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyNodeActivationRequirement);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyNodeActivationRequirement instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyNodeActivationRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyNodeActivationRequirement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GridLevel == input.GridLevel ||
                    (this.GridLevel != null &&
                    this.GridLevel.Equals(input.GridLevel))
                ) && 
                (
                    this.MaterialRequirementHashes == input.MaterialRequirementHashes ||
                    this.MaterialRequirementHashes != null &&
                    input.MaterialRequirementHashes != null &&
                    this.MaterialRequirementHashes.SequenceEqual(input.MaterialRequirementHashes)
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
                if (this.GridLevel != null)
                    hashCode = hashCode * 59 + this.GridLevel.GetHashCode();
                if (this.MaterialRequirementHashes != null)
                    hashCode = hashCode * 59 + this.MaterialRequirementHashes.GetHashCode();
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
