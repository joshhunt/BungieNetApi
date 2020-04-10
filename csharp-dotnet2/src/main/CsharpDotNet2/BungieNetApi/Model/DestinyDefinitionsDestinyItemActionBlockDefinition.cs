using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If an item can have an action performed on it (like \&quot;Dismantle\&quot;), it will be defined here if you care.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemActionBlockDefinition {
    /// <summary>
    /// Localized text for the verb of the action being performed.
    /// </summary>
    /// <value>Localized text for the verb of the action being performed.</value>
    [DataMember(Name="verbName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verbName")]
    public string VerbName { get; set; }

    /// <summary>
    /// Localized text describing the action being performed.
    /// </summary>
    /// <value>Localized text describing the action being performed.</value>
    [DataMember(Name="verbDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verbDescription")]
    public string VerbDescription { get; set; }

    /// <summary>
    /// The content has this property, however it's not entirely clear how it is used.
    /// </summary>
    /// <value>The content has this property, however it's not entirely clear how it is used.</value>
    [DataMember(Name="isPositive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPositive")]
    public bool? IsPositive { get; set; }

    /// <summary>
    /// If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen's data itself.
    /// </summary>
    /// <value>If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen's data itself.</value>
    [DataMember(Name="overlayScreenName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overlayScreenName")]
    public string OverlayScreenName { get; set; }

    /// <summary>
    /// The icon associated with the overlay screen for the action, if any.
    /// </summary>
    /// <value>The icon associated with the overlay screen for the action, if any.</value>
    [DataMember(Name="overlayIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overlayIcon")]
    public string OverlayIcon { get; set; }

    /// <summary>
    /// The number of seconds to delay before allowing this action to be performed again.
    /// </summary>
    /// <value>The number of seconds to delay before allowing this action to be performed again.</value>
    [DataMember(Name="requiredCooldownSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredCooldownSeconds")]
    public int? RequiredCooldownSeconds { get; set; }

    /// <summary>
    /// If the action requires other items to exist or be destroyed, this is the list of those items and requirements.
    /// </summary>
    /// <value>If the action requires other items to exist or be destroyed, this is the list of those items and requirements.</value>
    [DataMember(Name="requiredItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredItems")]
    public List<DestinyDefinitionsDestinyItemActionRequiredItemDefinition> RequiredItems { get; set; }

    /// <summary>
    /// If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action.
    /// </summary>
    /// <value>If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action.</value>
    [DataMember(Name="progressionRewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionRewards")]
    public List<DestinyDefinitionsDestinyProgressionRewardDefinition> ProgressionRewards { get; set; }

    /// <summary>
    /// The internal identifier for the action.
    /// </summary>
    /// <value>The internal identifier for the action.</value>
    [DataMember(Name="actionTypeLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionTypeLabel")]
    public string ActionTypeLabel { get; set; }

    /// <summary>
    /// Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property.
    /// </summary>
    /// <value>Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property.</value>
    [DataMember(Name="requiredLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredLocation")]
    public string RequiredLocation { get; set; }

    /// <summary>
    /// The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns.
    /// </summary>
    /// <value>The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns.</value>
    [DataMember(Name="requiredCooldownHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredCooldownHash")]
    public int? RequiredCooldownHash { get; set; }

    /// <summary>
    /// If true, the item is deleted when the action completes.
    /// </summary>
    /// <value>If true, the item is deleted when the action completes.</value>
    [DataMember(Name="deleteOnAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleteOnAction")]
    public bool? DeleteOnAction { get; set; }

    /// <summary>
    /// If true, the entire stack is deleted when the action completes.
    /// </summary>
    /// <value>If true, the entire stack is deleted when the action completes.</value>
    [DataMember(Name="consumeEntireStack", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consumeEntireStack")]
    public bool? ConsumeEntireStack { get; set; }

    /// <summary>
    /// If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items.
    /// </summary>
    /// <value>If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items.</value>
    [DataMember(Name="useOnAcquire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useOnAcquire")]
    public bool? UseOnAcquire { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemActionBlockDefinition {\n");
      sb.Append("  VerbName: ").Append(VerbName).Append("\n");
      sb.Append("  VerbDescription: ").Append(VerbDescription).Append("\n");
      sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
      sb.Append("  OverlayScreenName: ").Append(OverlayScreenName).Append("\n");
      sb.Append("  OverlayIcon: ").Append(OverlayIcon).Append("\n");
      sb.Append("  RequiredCooldownSeconds: ").Append(RequiredCooldownSeconds).Append("\n");
      sb.Append("  RequiredItems: ").Append(RequiredItems).Append("\n");
      sb.Append("  ProgressionRewards: ").Append(ProgressionRewards).Append("\n");
      sb.Append("  ActionTypeLabel: ").Append(ActionTypeLabel).Append("\n");
      sb.Append("  RequiredLocation: ").Append(RequiredLocation).Append("\n");
      sb.Append("  RequiredCooldownHash: ").Append(RequiredCooldownHash).Append("\n");
      sb.Append("  DeleteOnAction: ").Append(DeleteOnAction).Append("\n");
      sb.Append("  ConsumeEntireStack: ").Append(ConsumeEntireStack).Append("\n");
      sb.Append("  UseOnAcquire: ").Append(UseOnAcquire).Append("\n");
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
