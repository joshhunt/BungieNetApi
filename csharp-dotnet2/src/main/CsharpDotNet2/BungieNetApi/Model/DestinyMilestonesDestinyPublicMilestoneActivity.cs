using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A milestone may have one or more conceptual Activities associated with it, and each of those conceptual activities could have a variety of variants, modes, tiers, what-have-you. Our attempts to determine what qualifies as a conceptual activity are, unfortunately, janky. So if you see missing modes or modes that don&#39;t seem appropriate to you, let us know and I&#39;ll buy you a beer if we ever meet up in person.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyPublicMilestoneActivity {
    /// <summary>
    /// The hash identifier of the activity that's been chosen to be considered the canonical \"conceptual\" activity definition. This may have many variants, defined herein.
    /// </summary>
    /// <value>The hash identifier of the activity that's been chosen to be considered the canonical \"conceptual\" activity definition. This may have many variants, defined herein.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.
    /// </summary>
    /// <value>The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.</value>
    [DataMember(Name="modifierHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifierHashes")]
    public List<int?> ModifierHashes { get; set; }

    /// <summary>
    /// Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.
    /// </summary>
    /// <value>Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.</value>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variants")]
    public List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> Variants { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyPublicMilestoneActivity {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
      sb.Append("  ActivityModeHash: ").Append(ActivityModeHash).Append("\n");
      sb.Append("  ActivityModeType: ").Append(ActivityModeType).Append("\n");
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
