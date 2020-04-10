using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A Vendor Interaction is a dialog shown by the vendor other than sale items or transfer screens. The vendor is showing you something, and asking you to reply to it by choosing an option or reward.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorInteractionDefinition {
    /// <summary>
    /// The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.
    /// </summary>
    /// <value>The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.</value>
    [DataMember(Name="interactionIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interactionIndex")]
    public int? InteractionIndex { get; set; }

    /// <summary>
    /// The potential replies that the user can make to the interaction.
    /// </summary>
    /// <value>The potential replies that the user can make to the interaction.</value>
    [DataMember(Name="replies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replies")]
    public List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> Replies { get; set; }

    /// <summary>
    /// If >= 0, this is the category of sale items to show along with this interaction dialog.
    /// </summary>
    /// <value>If >= 0, this is the category of sale items to show along with this interaction dialog.</value>
    [DataMember(Name="vendorCategoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorCategoryIndex")]
    public int? VendorCategoryIndex { get; set; }

    /// <summary>
    /// If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character's status with the quest if you use it to find the character's current Quest Step by checking their inventory against this questlineItemHash's DestinyInventoryItemDefinition.setData.
    /// </summary>
    /// <value>If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character's status with the quest if you use it to find the character's current Quest Step by checking their inventory against this questlineItemHash's DestinyInventoryItemDefinition.setData.</value>
    [DataMember(Name="questlineItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questlineItemHash")]
    public int? QuestlineItemHash { get; set; }

    /// <summary>
    /// If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.
    /// </summary>
    /// <value>If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.</value>
    [DataMember(Name="sackInteractionList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sackInteractionList")]
    public List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> SackInteractionList { get; set; }

    /// <summary>
    /// A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn't as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.
    /// </summary>
    /// <value>A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn't as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.</value>
    [DataMember(Name="uiInteractionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uiInteractionType")]
    public int? UiInteractionType { get; set; }

    /// <summary>
    /// The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.
    /// </summary>
    /// <value>The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.</value>
    [DataMember(Name="interactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interactionType")]
    public int? InteractionType { get; set; }

    /// <summary>
    /// If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.
    /// </summary>
    /// <value>If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.</value>
    [DataMember(Name="rewardBlockLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardBlockLabel")]
    public string RewardBlockLabel { get; set; }

    /// <summary>
    /// If the vendor's reward list is sourced from one of his categories, this is the index into the category array of items to show.
    /// </summary>
    /// <value>If the vendor's reward list is sourced from one of his categories, this is the index into the category array of items to show.</value>
    [DataMember(Name="rewardVendorCategoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardVendorCategoryIndex")]
    public int? RewardVendorCategoryIndex { get; set; }

    /// <summary>
    /// If the vendor interaction has flavor text, this is some of it.
    /// </summary>
    /// <value>If the vendor interaction has flavor text, this is some of it.</value>
    [DataMember(Name="flavorLineOne", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavorLineOne")]
    public string FlavorLineOne { get; set; }

    /// <summary>
    /// If the vendor interaction has flavor text, this is the rest of it.
    /// </summary>
    /// <value>If the vendor interaction has flavor text, this is the rest of it.</value>
    [DataMember(Name="flavorLineTwo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavorLineTwo")]
    public string FlavorLineTwo { get; set; }

    /// <summary>
    /// The header for the interaction dialog.
    /// </summary>
    /// <value>The header for the interaction dialog.</value>
    [DataMember(Name="headerDisplayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headerDisplayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition HeaderDisplayProperties { get; set; }

    /// <summary>
    /// The localized text telling the player what to do when they see this dialog.
    /// </summary>
    /// <value>The localized text telling the player what to do when they see this dialog.</value>
    [DataMember(Name="instructions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instructions")]
    public string Instructions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
