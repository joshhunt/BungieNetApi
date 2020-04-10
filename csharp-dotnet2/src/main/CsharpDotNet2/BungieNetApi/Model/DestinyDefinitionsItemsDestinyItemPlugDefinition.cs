using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If an item is a Plug, its DestinyInventoryItemDefinition.plug property will be populated with an instance of one of these bad boys.  This gives information about when it can be inserted, what the plug&#39;s category is (and thus whether it is compatible with a socket... see DestinySocketTypeDefinition for information about Plug Categories and socket compatibility), whether it is enabled and other Plug info.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsItemsDestinyItemPlugDefinition {
    /// <summary>
    /// The rules around when this plug can be inserted into a socket, aside from the socket's individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
    /// </summary>
    /// <value>The rules around when this plug can be inserted into a socket, aside from the socket's individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.</value>
    [DataMember(Name="insertionRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insertionRules")]
    public List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> InsertionRules { get; set; }

    /// <summary>
    /// The string identifier for the plug's category. Use the socket's DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.
    /// </summary>
    /// <value>The string identifier for the plug's category. Use the socket's DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.</value>
    [DataMember(Name="plugCategoryIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugCategoryIdentifier")]
    public string PlugCategoryIdentifier { get; set; }

    /// <summary>
    /// The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.
    /// </summary>
    /// <value>The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.</value>
    [DataMember(Name="plugCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugCategoryHash")]
    public int? PlugCategoryHash { get; set; }

    /// <summary>
    /// If you successfully socket the item, this will determine whether or not you get \"refunded\" on the plug.
    /// </summary>
    /// <value>If you successfully socket the item, this will determine whether or not you get \"refunded\" on the plug.</value>
    [DataMember(Name="onActionRecreateSelf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onActionRecreateSelf")]
    public bool? OnActionRecreateSelf { get; set; }

    /// <summary>
    /// If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.
    /// </summary>
    /// <value>If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.</value>
    [DataMember(Name="insertionMaterialRequirementHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insertionMaterialRequirementHash")]
    public int? InsertionMaterialRequirementHash { get; set; }

    /// <summary>
    /// In the game, if you're inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.
    /// </summary>
    /// <value>In the game, if you're inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.</value>
    [DataMember(Name="previewItemOverrideHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewItemOverrideHash")]
    public int? PreviewItemOverrideHash { get; set; }

    /// <summary>
    /// It's not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.
    /// </summary>
    /// <value>It's not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.</value>
    [DataMember(Name="enabledMaterialRequirementHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabledMaterialRequirementHash")]
    public int? EnabledMaterialRequirementHash { get; set; }

    /// <summary>
    /// The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
    /// </summary>
    /// <value>The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.</value>
    [DataMember(Name="enabledRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabledRules")]
    public List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> EnabledRules { get; set; }

    /// <summary>
    /// Plugs can have arbitrary, UI-defined identifiers that the UI designers use to determine the style applied to plugs. Unfortunately, we have neither a definitive list of these labels nor advance warning of when new labels might be applied or how that relates to how they get rendered. If you want to, you can refer to known labels to change your own styles: but know that new ones can be created arbitrarily, and we have no way of associating the labels with any specific UI style guidance... you'll have to piece that together on your end. Or do what we do, and just show plugs more generically, without specialized styles.
    /// </summary>
    /// <value>Plugs can have arbitrary, UI-defined identifiers that the UI designers use to determine the style applied to plugs. Unfortunately, we have neither a definitive list of these labels nor advance warning of when new labels might be applied or how that relates to how they get rendered. If you want to, you can refer to known labels to change your own styles: but know that new ones can be created arbitrarily, and we have no way of associating the labels with any specific UI style guidance... you'll have to piece that together on your end. Or do what we do, and just show plugs more generically, without specialized styles.</value>
    [DataMember(Name="uiPlugLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uiPlugLabel")]
    public string UiPlugLabel { get; set; }

    /// <summary>
    /// Gets or Sets PlugStyle
    /// </summary>
    [DataMember(Name="plugStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugStyle")]
    public int? PlugStyle { get; set; }

    /// <summary>
    /// Indicates the rules about when this plug can be used. See the PlugAvailabilityMode enumeration for more information!
    /// </summary>
    /// <value>Indicates the rules about when this plug can be used. See the PlugAvailabilityMode enumeration for more information!</value>
    [DataMember(Name="plugAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugAvailability")]
    public int? PlugAvailability { get; set; }

    /// <summary>
    /// If the plug meets certain state requirements, it may have an alternative label applied to it. This is the alternative label that will be applied in such a situation.
    /// </summary>
    /// <value>If the plug meets certain state requirements, it may have an alternative label applied to it. This is the alternative label that will be applied in such a situation.</value>
    [DataMember(Name="alternateUiPlugLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alternateUiPlugLabel")]
    public string AlternateUiPlugLabel { get; set; }

    /// <summary>
    /// The alternate plug of the plug: only applies when the item is in states that only the server can know about and control, unfortunately. See AlternateUiPlugLabel for the related label info.
    /// </summary>
    /// <value>The alternate plug of the plug: only applies when the item is in states that only the server can know about and control, unfortunately. See AlternateUiPlugLabel for the related label info.</value>
    [DataMember(Name="alternatePlugStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alternatePlugStyle")]
    public int? AlternatePlugStyle { get; set; }

    /// <summary>
    /// If TRUE, this plug is used for UI display purposes only, and doesn't have any interesting effects of its own.
    /// </summary>
    /// <value>If TRUE, this plug is used for UI display purposes only, and doesn't have any interesting effects of its own.</value>
    [DataMember(Name="isDummyPlug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDummyPlug")]
    public bool? IsDummyPlug { get; set; }

    /// <summary>
    /// Do you ever get the feeling that a system has become so overburdened by edge cases that it probably should have become some other system entirely? So do I!  In totally unrelated news, Plugs can now override properties of their parent items. This is some of the relevant definition data for those overrides.  If this is populated, it will have the override data to be applied when this plug is applied to an item.
    /// </summary>
    /// <value>Do you ever get the feeling that a system has become so overburdened by edge cases that it probably should have become some other system entirely? So do I!  In totally unrelated news, Plugs can now override properties of their parent items. This is some of the relevant definition data for those overrides.  If this is populated, it will have the override data to be applied when this plug is applied to an item.</value>
    [DataMember(Name="parentItemOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentItemOverride")]
    public DestinyDefinitionsItemsDestinyParentItemOverride ParentItemOverride { get; set; }

    /// <summary>
    /// IF not null, this plug provides Energy capacity to the item in which it is socketed. In Armor 2.0 for example, is implemented in a similar way to Masterworks, where visually it's a single area of the UI being clicked on to \"Upgrade\" to higher energy levels, but it's actually socketing new plugs.
    /// </summary>
    /// <value>IF not null, this plug provides Energy capacity to the item in which it is socketed. In Armor 2.0 for example, is implemented in a similar way to Masterworks, where visually it's a single area of the UI being clicked on to \"Upgrade\" to higher energy levels, but it's actually socketing new plugs.</value>
    [DataMember(Name="energyCapacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyCapacity")]
    public DestinyDefinitionsItemsDestinyEnergyCapacityEntry EnergyCapacity { get; set; }

    /// <summary>
    /// IF not null, this plug has an energy cost. This contains the details of that cost.
    /// </summary>
    /// <value>IF not null, this plug has an energy cost. This contains the details of that cost.</value>
    [DataMember(Name="energyCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyCost")]
    public DestinyDefinitionsItemsDestinyEnergyCostEntry EnergyCost { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyItemPlugDefinition {\n");
      sb.Append("  InsertionRules: ").Append(InsertionRules).Append("\n");
      sb.Append("  PlugCategoryIdentifier: ").Append(PlugCategoryIdentifier).Append("\n");
      sb.Append("  PlugCategoryHash: ").Append(PlugCategoryHash).Append("\n");
      sb.Append("  OnActionRecreateSelf: ").Append(OnActionRecreateSelf).Append("\n");
      sb.Append("  InsertionMaterialRequirementHash: ").Append(InsertionMaterialRequirementHash).Append("\n");
      sb.Append("  PreviewItemOverrideHash: ").Append(PreviewItemOverrideHash).Append("\n");
      sb.Append("  EnabledMaterialRequirementHash: ").Append(EnabledMaterialRequirementHash).Append("\n");
      sb.Append("  EnabledRules: ").Append(EnabledRules).Append("\n");
      sb.Append("  UiPlugLabel: ").Append(UiPlugLabel).Append("\n");
      sb.Append("  PlugStyle: ").Append(PlugStyle).Append("\n");
      sb.Append("  PlugAvailability: ").Append(PlugAvailability).Append("\n");
      sb.Append("  AlternateUiPlugLabel: ").Append(AlternateUiPlugLabel).Append("\n");
      sb.Append("  AlternatePlugStyle: ").Append(AlternatePlugStyle).Append("\n");
      sb.Append("  IsDummyPlug: ").Append(IsDummyPlug).Append("\n");
      sb.Append("  ParentItemOverride: ").Append(ParentItemOverride).Append("\n");
      sb.Append("  EnergyCapacity: ").Append(EnergyCapacity).Append("\n");
      sb.Append("  EnergyCost: ").Append(EnergyCost).Append("\n");
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
