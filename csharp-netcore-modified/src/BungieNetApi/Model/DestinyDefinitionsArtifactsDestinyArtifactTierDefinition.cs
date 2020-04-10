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
    /// DestinyDefinitionsArtifactsDestinyArtifactTierDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsArtifactsDestinyArtifactTierDefinition :  IEquatable<DestinyDefinitionsArtifactsDestinyArtifactTierDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsArtifactsDestinyArtifactTierDefinition" /> class.
        /// </summary>
        /// <param name="tierHash">An identifier, unique within the Artifact, for this specific tier..</param>
        /// <param name="displayTitle">The human readable title of this tier, if any..</param>
        /// <param name="progressRequirementMessage">A string representing the localized minimum requirement text for this Tier, if any..</param>
        /// <param name="items">The items that can be earned within this tier..</param>
        /// <param name="minimumUnlockPointsUsedRequirement">The minimum number of \&quot;unlock points\&quot; that you must have used before you can unlock items from this tier..</param>
        public DestinyDefinitionsArtifactsDestinyArtifactTierDefinition(int tierHash = default(int), string displayTitle = default(string), string progressRequirementMessage = default(string), List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> items = default(List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition>), int minimumUnlockPointsUsedRequirement = default(int))
        {
            this.TierHash = tierHash;
            this.DisplayTitle = displayTitle;
            this.ProgressRequirementMessage = progressRequirementMessage;
            this.Items = items;
            this.MinimumUnlockPointsUsedRequirement = minimumUnlockPointsUsedRequirement;
        }
        
        /// <summary>
        /// An identifier, unique within the Artifact, for this specific tier.
        /// </summary>
        /// <value>An identifier, unique within the Artifact, for this specific tier.</value>
        [DataMember(Name="tierHash", EmitDefaultValue=false)]
        public int TierHash { get; set; }

        /// <summary>
        /// The human readable title of this tier, if any.
        /// </summary>
        /// <value>The human readable title of this tier, if any.</value>
        [DataMember(Name="displayTitle", EmitDefaultValue=false)]
        public string DisplayTitle { get; set; }

        /// <summary>
        /// A string representing the localized minimum requirement text for this Tier, if any.
        /// </summary>
        /// <value>A string representing the localized minimum requirement text for this Tier, if any.</value>
        [DataMember(Name="progressRequirementMessage", EmitDefaultValue=false)]
        public string ProgressRequirementMessage { get; set; }

        /// <summary>
        /// The items that can be earned within this tier.
        /// </summary>
        /// <value>The items that can be earned within this tier.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> Items { get; set; }

        /// <summary>
        /// The minimum number of \&quot;unlock points\&quot; that you must have used before you can unlock items from this tier.
        /// </summary>
        /// <value>The minimum number of \&quot;unlock points\&quot; that you must have used before you can unlock items from this tier.</value>
        [DataMember(Name="minimumUnlockPointsUsedRequirement", EmitDefaultValue=false)]
        public int MinimumUnlockPointsUsedRequirement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsArtifactsDestinyArtifactTierDefinition {\n");
            sb.Append("  TierHash: ").Append(TierHash).Append("\n");
            sb.Append("  DisplayTitle: ").Append(DisplayTitle).Append("\n");
            sb.Append("  ProgressRequirementMessage: ").Append(ProgressRequirementMessage).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MinimumUnlockPointsUsedRequirement: ").Append(MinimumUnlockPointsUsedRequirement).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsArtifactsDestinyArtifactTierDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsArtifactsDestinyArtifactTierDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsArtifactsDestinyArtifactTierDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsArtifactsDestinyArtifactTierDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TierHash == input.TierHash ||
                    this.TierHash.Equals(input.TierHash)
                ) && 
                (
                    this.DisplayTitle == input.DisplayTitle ||
                    (this.DisplayTitle != null &&
                    this.DisplayTitle.Equals(input.DisplayTitle))
                ) && 
                (
                    this.ProgressRequirementMessage == input.ProgressRequirementMessage ||
                    (this.ProgressRequirementMessage != null &&
                    this.ProgressRequirementMessage.Equals(input.ProgressRequirementMessage))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.MinimumUnlockPointsUsedRequirement == input.MinimumUnlockPointsUsedRequirement ||
                    this.MinimumUnlockPointsUsedRequirement.Equals(input.MinimumUnlockPointsUsedRequirement)
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
                hashCode = hashCode * 59 + this.TierHash.GetHashCode();
                if (this.DisplayTitle != null)
                    hashCode = hashCode * 59 + this.DisplayTitle.GetHashCode();
                if (this.ProgressRequirementMessage != null)
                    hashCode = hashCode * 59 + this.ProgressRequirementMessage.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                hashCode = hashCode * 59 + this.MinimumUnlockPointsUsedRequirement.GetHashCode();
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
