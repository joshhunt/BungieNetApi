using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This defines information that can only come from a talent grid on an item. Items mostly have negligible talent grid data these days, but instanced items still retain grids as a source for some of this common information.  Builds/Subclasses are the only items left that still have talent grids with meaningful Nodes.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemTalentGridBlockDefinition {
    /// <summary>
    /// The hash identifier of the DestinyTalentGridDefinition attached to this item.
    /// </summary>
    /// <value>The hash identifier of the DestinyTalentGridDefinition attached to this item.</value>
    [DataMember(Name="talentGridHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "talentGridHash")]
    public int? TalentGridHash { get; set; }

    /// <summary>
    /// This is meant to be a subtitle for looking at the talent grid. In practice, somewhat frustratingly, this always merely says the localized word for \"Details\". Great. Maybe it'll have more if talent grids ever get used for more than builds and subclasses again.
    /// </summary>
    /// <value>This is meant to be a subtitle for looking at the talent grid. In practice, somewhat frustratingly, this always merely says the localized word for \"Details\". Great. Maybe it'll have more if talent grids ever get used for more than builds and subclasses again.</value>
    [DataMember(Name="itemDetailString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemDetailString")]
    public string ItemDetailString { get; set; }

    /// <summary>
    /// A shortcut string identifier for the \"build\" in question, if this talent grid has an associated build. Doesn't map to anything we can expose at the moment.
    /// </summary>
    /// <value>A shortcut string identifier for the \"build\" in question, if this talent grid has an associated build. Doesn't map to anything we can expose at the moment.</value>
    [DataMember(Name="buildName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildName")]
    public string BuildName { get; set; }

    /// <summary>
    /// If the talent grid implies a damage type, this is the enum value for that damage type.
    /// </summary>
    /// <value>If the talent grid implies a damage type, this is the enum value for that damage type.</value>
    [DataMember(Name="hudDamageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hudDamageType")]
    public int? HudDamageType { get; set; }

    /// <summary>
    /// If the talent grid has a special icon that's shown in the game UI (like builds, funny that), this is the identifier for that icon. Sadly, we don't actually get that icon right now. I'll be looking to replace this with a path to the actual icon itself.
    /// </summary>
    /// <value>If the talent grid has a special icon that's shown in the game UI (like builds, funny that), this is the identifier for that icon. Sadly, we don't actually get that icon right now. I'll be looking to replace this with a path to the actual icon itself.</value>
    [DataMember(Name="hudIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hudIcon")]
    public string HudIcon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemTalentGridBlockDefinition {\n");
      sb.Append("  TalentGridHash: ").Append(TalentGridHash).Append("\n");
      sb.Append("  ItemDetailString: ").Append(ItemDetailString).Append("\n");
      sb.Append("  BuildName: ").Append(BuildName).Append("\n");
      sb.Append("  HudDamageType: ").Append(HudDamageType).Append("\n");
      sb.Append("  HudIcon: ").Append(HudIcon).Append("\n");
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
