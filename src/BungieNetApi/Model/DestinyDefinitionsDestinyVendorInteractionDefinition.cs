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
    /// A Vendor Interaction is a dialog shown by the vendor other than sale items or transfer screens. The vendor is showing you something, and asking you to reply to it by choosing an option or reward.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyVendorInteractionDefinition :  IEquatable<DestinyDefinitionsDestinyVendorInteractionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyVendorInteractionDefinition" /> class.
        /// </summary>
        /// <param name="interactionIndex">The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such..</param>
        /// <param name="replies">The potential replies that the user can make to the interaction..</param>
        /// <param name="vendorCategoryIndex">If &gt;&#x3D; 0, this is the category of sale items to show along with this interaction dialog..</param>
        /// <param name="questlineItemHash">If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character&#39;s status with the quest if you use it to find the character&#39;s current Quest Step by checking their inventory against this questlineItemHash&#39;s DestinyInventoryItemDefinition.setData..</param>
        /// <param name="sackInteractionList">If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks..</param>
        /// <param name="uiInteractionType">A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn&#39;t as useful as the Enum in retrospect, well what can you do. Try using interactionType instead..</param>
        /// <param name="interactionType">The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType..</param>
        /// <param name="rewardBlockLabel">If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction..</param>
        /// <param name="rewardVendorCategoryIndex">If the vendor&#39;s reward list is sourced from one of his categories, this is the index into the category array of items to show..</param>
        /// <param name="flavorLineOne">If the vendor interaction has flavor text, this is some of it..</param>
        /// <param name="flavorLineTwo">If the vendor interaction has flavor text, this is the rest of it..</param>
        /// <param name="headerDisplayProperties">The header for the interaction dialog..</param>
        /// <param name="instructions">The localized text telling the player what to do when they see this dialog..</param>
        public DestinyDefinitionsDestinyVendorInteractionDefinition(int interactionIndex = default(int), List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> replies = default(List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition>), int vendorCategoryIndex = default(int), int questlineItemHash = default(int), List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> sackInteractionList = default(List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition>), int uiInteractionType = default(int), int interactionType = default(int), string rewardBlockLabel = default(string), int rewardVendorCategoryIndex = default(int), string flavorLineOne = default(string), string flavorLineTwo = default(string), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition headerDisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string instructions = default(string))
        {
            this.InteractionIndex = interactionIndex;
            this.Replies = replies;
            this.VendorCategoryIndex = vendorCategoryIndex;
            this.QuestlineItemHash = questlineItemHash;
            this.SackInteractionList = sackInteractionList;
            this.UiInteractionType = uiInteractionType;
            this.InteractionType = interactionType;
            this.RewardBlockLabel = rewardBlockLabel;
            this.RewardVendorCategoryIndex = rewardVendorCategoryIndex;
            this.FlavorLineOne = flavorLineOne;
            this.FlavorLineTwo = flavorLineTwo;
            this.HeaderDisplayProperties = headerDisplayProperties;
            this.Instructions = instructions;
        }
        
        /// <summary>
        /// The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.
        /// </summary>
        /// <value>The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.</value>
        [DataMember(Name="interactionIndex", EmitDefaultValue=false)]
        public int InteractionIndex { get; set; }

        /// <summary>
        /// The potential replies that the user can make to the interaction.
        /// </summary>
        /// <value>The potential replies that the user can make to the interaction.</value>
        [DataMember(Name="replies", EmitDefaultValue=false)]
        public List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> Replies { get; set; }

        /// <summary>
        /// If &gt;&#x3D; 0, this is the category of sale items to show along with this interaction dialog.
        /// </summary>
        /// <value>If &gt;&#x3D; 0, this is the category of sale items to show along with this interaction dialog.</value>
        [DataMember(Name="vendorCategoryIndex", EmitDefaultValue=false)]
        public int VendorCategoryIndex { get; set; }

        /// <summary>
        /// If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character&#39;s status with the quest if you use it to find the character&#39;s current Quest Step by checking their inventory against this questlineItemHash&#39;s DestinyInventoryItemDefinition.setData.
        /// </summary>
        /// <value>If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character&#39;s status with the quest if you use it to find the character&#39;s current Quest Step by checking their inventory against this questlineItemHash&#39;s DestinyInventoryItemDefinition.setData.</value>
        [DataMember(Name="questlineItemHash", EmitDefaultValue=false)]
        public int QuestlineItemHash { get; set; }

        /// <summary>
        /// If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.
        /// </summary>
        /// <value>If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.</value>
        [DataMember(Name="sackInteractionList", EmitDefaultValue=false)]
        public List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> SackInteractionList { get; set; }

        /// <summary>
        /// A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn&#39;t as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.
        /// </summary>
        /// <value>A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn&#39;t as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.</value>
        [DataMember(Name="uiInteractionType", EmitDefaultValue=false)]
        public int UiInteractionType { get; set; }

        /// <summary>
        /// The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.
        /// </summary>
        /// <value>The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.</value>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public int InteractionType { get; set; }

        /// <summary>
        /// If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.
        /// </summary>
        /// <value>If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.</value>
        [DataMember(Name="rewardBlockLabel", EmitDefaultValue=false)]
        public string RewardBlockLabel { get; set; }

        /// <summary>
        /// If the vendor&#39;s reward list is sourced from one of his categories, this is the index into the category array of items to show.
        /// </summary>
        /// <value>If the vendor&#39;s reward list is sourced from one of his categories, this is the index into the category array of items to show.</value>
        [DataMember(Name="rewardVendorCategoryIndex", EmitDefaultValue=false)]
        public int RewardVendorCategoryIndex { get; set; }

        /// <summary>
        /// If the vendor interaction has flavor text, this is some of it.
        /// </summary>
        /// <value>If the vendor interaction has flavor text, this is some of it.</value>
        [DataMember(Name="flavorLineOne", EmitDefaultValue=false)]
        public string FlavorLineOne { get; set; }

        /// <summary>
        /// If the vendor interaction has flavor text, this is the rest of it.
        /// </summary>
        /// <value>If the vendor interaction has flavor text, this is the rest of it.</value>
        [DataMember(Name="flavorLineTwo", EmitDefaultValue=false)]
        public string FlavorLineTwo { get; set; }

        /// <summary>
        /// The header for the interaction dialog.
        /// </summary>
        /// <value>The header for the interaction dialog.</value>
        [DataMember(Name="headerDisplayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition HeaderDisplayProperties { get; set; }

        /// <summary>
        /// The localized text telling the player what to do when they see this dialog.
        /// </summary>
        /// <value>The localized text telling the player what to do when they see this dialog.</value>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyVendorInteractionDefinition {\n");
            sb.Append("  InteractionIndex: ").Append(InteractionIndex).Append("\n");
            sb.Append("  Replies: ").Append(Replies).Append("\n");
            sb.Append("  VendorCategoryIndex: ").Append(VendorCategoryIndex).Append("\n");
            sb.Append("  QuestlineItemHash: ").Append(QuestlineItemHash).Append("\n");
            sb.Append("  SackInteractionList: ").Append(SackInteractionList).Append("\n");
            sb.Append("  UiInteractionType: ").Append(UiInteractionType).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  RewardBlockLabel: ").Append(RewardBlockLabel).Append("\n");
            sb.Append("  RewardVendorCategoryIndex: ").Append(RewardVendorCategoryIndex).Append("\n");
            sb.Append("  FlavorLineOne: ").Append(FlavorLineOne).Append("\n");
            sb.Append("  FlavorLineTwo: ").Append(FlavorLineTwo).Append("\n");
            sb.Append("  HeaderDisplayProperties: ").Append(HeaderDisplayProperties).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyVendorInteractionDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyVendorInteractionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyVendorInteractionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyVendorInteractionDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InteractionIndex == input.InteractionIndex ||
                    (this.InteractionIndex != null &&
                    this.InteractionIndex.Equals(input.InteractionIndex))
                ) && 
                (
                    this.Replies == input.Replies ||
                    this.Replies != null &&
                    input.Replies != null &&
                    this.Replies.SequenceEqual(input.Replies)
                ) && 
                (
                    this.VendorCategoryIndex == input.VendorCategoryIndex ||
                    (this.VendorCategoryIndex != null &&
                    this.VendorCategoryIndex.Equals(input.VendorCategoryIndex))
                ) && 
                (
                    this.QuestlineItemHash == input.QuestlineItemHash ||
                    (this.QuestlineItemHash != null &&
                    this.QuestlineItemHash.Equals(input.QuestlineItemHash))
                ) && 
                (
                    this.SackInteractionList == input.SackInteractionList ||
                    this.SackInteractionList != null &&
                    input.SackInteractionList != null &&
                    this.SackInteractionList.SequenceEqual(input.SackInteractionList)
                ) && 
                (
                    this.UiInteractionType == input.UiInteractionType ||
                    (this.UiInteractionType != null &&
                    this.UiInteractionType.Equals(input.UiInteractionType))
                ) && 
                (
                    this.InteractionType == input.InteractionType ||
                    (this.InteractionType != null &&
                    this.InteractionType.Equals(input.InteractionType))
                ) && 
                (
                    this.RewardBlockLabel == input.RewardBlockLabel ||
                    (this.RewardBlockLabel != null &&
                    this.RewardBlockLabel.Equals(input.RewardBlockLabel))
                ) && 
                (
                    this.RewardVendorCategoryIndex == input.RewardVendorCategoryIndex ||
                    (this.RewardVendorCategoryIndex != null &&
                    this.RewardVendorCategoryIndex.Equals(input.RewardVendorCategoryIndex))
                ) && 
                (
                    this.FlavorLineOne == input.FlavorLineOne ||
                    (this.FlavorLineOne != null &&
                    this.FlavorLineOne.Equals(input.FlavorLineOne))
                ) && 
                (
                    this.FlavorLineTwo == input.FlavorLineTwo ||
                    (this.FlavorLineTwo != null &&
                    this.FlavorLineTwo.Equals(input.FlavorLineTwo))
                ) && 
                (
                    this.HeaderDisplayProperties == input.HeaderDisplayProperties ||
                    (this.HeaderDisplayProperties != null &&
                    this.HeaderDisplayProperties.Equals(input.HeaderDisplayProperties))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
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
                if (this.InteractionIndex != null)
                    hashCode = hashCode * 59 + this.InteractionIndex.GetHashCode();
                if (this.Replies != null)
                    hashCode = hashCode * 59 + this.Replies.GetHashCode();
                if (this.VendorCategoryIndex != null)
                    hashCode = hashCode * 59 + this.VendorCategoryIndex.GetHashCode();
                if (this.QuestlineItemHash != null)
                    hashCode = hashCode * 59 + this.QuestlineItemHash.GetHashCode();
                if (this.SackInteractionList != null)
                    hashCode = hashCode * 59 + this.SackInteractionList.GetHashCode();
                if (this.UiInteractionType != null)
                    hashCode = hashCode * 59 + this.UiInteractionType.GetHashCode();
                if (this.InteractionType != null)
                    hashCode = hashCode * 59 + this.InteractionType.GetHashCode();
                if (this.RewardBlockLabel != null)
                    hashCode = hashCode * 59 + this.RewardBlockLabel.GetHashCode();
                if (this.RewardVendorCategoryIndex != null)
                    hashCode = hashCode * 59 + this.RewardVendorCategoryIndex.GetHashCode();
                if (this.FlavorLineOne != null)
                    hashCode = hashCode * 59 + this.FlavorLineOne.GetHashCode();
                if (this.FlavorLineTwo != null)
                    hashCode = hashCode * 59 + this.FlavorLineTwo.GetHashCode();
                if (this.HeaderDisplayProperties != null)
                    hashCode = hashCode * 59 + this.HeaderDisplayProperties.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
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
