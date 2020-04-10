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
    /// Represents a category of \&quot;summary\&quot; rewards that can be earned for the Milestone regardless of specific quest rewards that can be earned.
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyMilestoneRewardCategory :  IEquatable<DestinyMilestonesDestinyMilestoneRewardCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneRewardCategory" /> class.
        /// </summary>
        /// <param name="rewardCategoryHash">Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards..</param>
        /// <param name="entries">The individual reward entries for this category, and their status..</param>
        public DestinyMilestonesDestinyMilestoneRewardCategory(int rewardCategoryHash = default(int), List<DestinyMilestonesDestinyMilestoneRewardEntry> entries = default(List<DestinyMilestonesDestinyMilestoneRewardEntry>))
        {
            this.RewardCategoryHash = rewardCategoryHash;
            this.Entries = entries;
        }
        
        /// <summary>
        /// Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.
        /// </summary>
        /// <value>Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.</value>
        [DataMember(Name="rewardCategoryHash", EmitDefaultValue=false)]
        public int RewardCategoryHash { get; set; }

        /// <summary>
        /// The individual reward entries for this category, and their status.
        /// </summary>
        /// <value>The individual reward entries for this category, and their status.</value>
        [DataMember(Name="entries", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyMilestoneRewardEntry> Entries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestoneRewardCategory {\n");
            sb.Append("  RewardCategoryHash: ").Append(RewardCategoryHash).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestoneRewardCategory);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneRewardCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneRewardCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneRewardCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RewardCategoryHash == input.RewardCategoryHash ||
                    (this.RewardCategoryHash != null &&
                    this.RewardCategoryHash.Equals(input.RewardCategoryHash))
                ) && 
                (
                    this.Entries == input.Entries ||
                    this.Entries != null &&
                    input.Entries != null &&
                    this.Entries.SequenceEqual(input.Entries)
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
                if (this.RewardCategoryHash != null)
                    hashCode = hashCode * 59 + this.RewardCategoryHash.GetHashCode();
                if (this.Entries != null)
                    hashCode = hashCode * 59 + this.Entries.GetHashCode();
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
