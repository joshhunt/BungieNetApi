using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The list of perks to display in an item tooltip - and whether or not they have been activated.  Perks apply a variety of effects to a character, and are generally either intrinsic to the item or provided in activated talent nodes or sockets.
  /// </summary>
  [DataContract]
  public class DestinyPerksDestinyPerkReference {
    /// <summary>
    /// The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk's definition before you show it to the user.
    /// </summary>
    /// <value>The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk's definition before you show it to the user.</value>
    [DataMember(Name="perkHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkHash")]
    public int? PerkHash { get; set; }

    /// <summary>
    /// The icon for the perk.
    /// </summary>
    /// <value>The icon for the perk.</value>
    [DataMember(Name="iconPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconPath")]
    public string IconPath { get; set; }

    /// <summary>
    /// Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item's tooltip, but that the user has not yet activated.)
    /// </summary>
    /// <value>Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item's tooltip, but that the user has not yet activated.)</value>
    [DataMember(Name="isActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Some perks provide benefits, but aren't visible in the UI. This value will let you know if this is perk should be shown in your UI.
    /// </summary>
    /// <value>Some perks provide benefits, but aren't visible in the UI. This value will let you know if this is perk should be shown in your UI.</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyPerksDestinyPerkReference {\n");
      sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
      sb.Append("  IconPath: ").Append(IconPath).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
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
