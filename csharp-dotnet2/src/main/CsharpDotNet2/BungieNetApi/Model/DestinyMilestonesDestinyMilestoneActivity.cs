using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Sometimes, we know the specific activity that the Milestone wants you to play. This entity provides additional information about that Activity and all of its variants. (sometimes there&#39;s only one variant, but I think you get the point)
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneActivity {
    /// <summary>
    /// The hash of an arbitrarily chosen variant of this activity. We'll go ahead and call that the \"canonical\" activity, because if you're using this value you should only use it for properties that are common across the variants: things like the name of the activity, it's location, etc... Use this hash to look up the DestinyActivityDefinition of this activity for rendering data.
    /// </summary>
    /// <value>The hash of an arbitrarily chosen variant of this activity. We'll go ahead and call that the \"canonical\" activity, because if you're using this value you should only use it for properties that are common across the variants: things like the name of the activity, it's location, etc... Use this hash to look up the DestinyActivityDefinition of this activity for rendering data.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
    /// </summary>
    /// <value>The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.</value>
    [DataMember(Name="activityModeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeHash")]
    public int? ActivityModeHash { get; set; }

    /// <summary>
    /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
    /// </summary>
    /// <value>The enumeration equivalent of the most specific Activity Mode under which this activity is played.</value>
    [DataMember(Name="activityModeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeType")]
    public int? ActivityModeType { get; set; }

    /// <summary>
    /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data. Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
    /// </summary>
    /// <value>If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data. Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.</value>
    [DataMember(Name="modifierHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifierHashes")]
    public List<int?> ModifierHashes { get; set; }

    /// <summary>
    /// If you want more than just name/location/etc... you're going to have to dig into and show the variants of the conceptual activity. These will differ in seemingly arbitrary ways, like difficulty level and modifiers applied. Show it in whatever way tickles your fancy.
    /// </summary>
    /// <value>If you want more than just name/location/etc... you're going to have to dig into and show the variants of the conceptual activity. These will differ in seemingly arbitrary ways, like difficulty level and modifiers applied. Show it in whatever way tickles your fancy.</value>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variants")]
    public List<DestinyMilestonesDestinyMilestoneActivityVariant> Variants { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneActivity {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  ActivityModeHash: ").Append(ActivityModeHash).Append("\n");
      sb.Append("  ActivityModeType: ").Append(ActivityModeType).Append("\n");
      sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
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
