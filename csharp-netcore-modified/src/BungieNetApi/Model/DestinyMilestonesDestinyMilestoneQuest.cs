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
    /// If a Milestone has one or more Quests, this will contain the live information for the character&#39;s status with one of those quests.
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyMilestoneQuest :  IEquatable<DestinyMilestonesDestinyMilestoneQuest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneQuest" /> class.
        /// </summary>
        /// <param name="questItemHash">Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data..</param>
        /// <param name="status">The current status of the quest for the character making the request..</param>
        /// <param name="activity">*IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition&#39;s activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from..</param>
        /// <param name="challenges">The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it&#39;s too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision..</param>
        public DestinyMilestonesDestinyMilestoneQuest(long questItemHash = default(long), DestinyQuestsDestinyQuestStatus status = default(DestinyQuestsDestinyQuestStatus), DestinyMilestonesDestinyMilestoneActivity activity = default(DestinyMilestonesDestinyMilestoneActivity), List<DestinyChallengesDestinyChallengeStatus> challenges = default(List<DestinyChallengesDestinyChallengeStatus>))
        {
            this.QuestItemHash = questItemHash;
            this.Status = status;
            this.Activity = activity;
            this.Challenges = challenges;
        }
        
        /// <summary>
        /// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
        /// </summary>
        /// <value>Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.</value>
        [DataMember(Name="questItemHash", EmitDefaultValue=false)]
        public long QuestItemHash { get; set; }

        /// <summary>
        /// The current status of the quest for the character making the request.
        /// </summary>
        /// <value>The current status of the quest for the character making the request.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public DestinyQuestsDestinyQuestStatus Status { get; set; }

        /// <summary>
        /// *IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition&#39;s activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.
        /// </summary>
        /// <value>*IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition&#39;s activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.</value>
        [DataMember(Name="activity", EmitDefaultValue=false)]
        public DestinyMilestonesDestinyMilestoneActivity Activity { get; set; }

        /// <summary>
        /// The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it&#39;s too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision.
        /// </summary>
        /// <value>The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it&#39;s too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision.</value>
        [DataMember(Name="challenges", EmitDefaultValue=false)]
        public List<DestinyChallengesDestinyChallengeStatus> Challenges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestoneQuest {\n");
            sb.Append("  QuestItemHash: ").Append(QuestItemHash).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestoneQuest);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneQuest instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneQuest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneQuest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuestItemHash == input.QuestItemHash ||
                    this.QuestItemHash.Equals(input.QuestItemHash)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
                ) && 
                (
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    input.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
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
                hashCode = hashCode * 59 + this.QuestItemHash.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                if (this.Challenges != null)
                    hashCode = hashCode * 59 + this.Challenges.GetHashCode();
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
