using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The status of a given item&#39;s socket. (which plug is inserted, if any: whether it is enabled, what \&quot;reusable\&quot; plugs can be inserted, etc...)  If I had it to do over, this would probably have a DestinyItemPlug representing the inserted item instead of most of these properties. :shrug:
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemSocketState {
    /// <summary>
    /// The currently active plug, if any.  Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item's definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item.
    /// </summary>
    /// <value>The currently active plug, if any.  Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item's definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item.</value>
    [DataMember(Name="plugHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugHash")]
    public int? PlugHash { get; set; }

    /// <summary>
    /// Even if a plug is inserted, it doesn't mean it's enabled.  This flag indicates whether the plug is active and providing its benefits.
    /// </summary>
    /// <value>Even if a plug is inserted, it doesn't mean it's enabled.  This flag indicates whether the plug is active and providing its benefits.</value>
    [DataMember(Name="isEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// A plug may theoretically provide benefits but not be visible - for instance, some older items use a plug's damage type perk to modify their own damage type. These, though they are not visible, still affect the item. This field indicates that state.  An invisible plug, while it provides benefits if it is Enabled, cannot be directly modified by the user.
    /// </summary>
    /// <value>A plug may theoretically provide benefits but not be visible - for instance, some older items use a plug's damage type perk to modify their own damage type. These, though they are not visible, still affect the item. This field indicates that state.  An invisible plug, while it provides benefits if it is Enabled, cannot be directly modified by the user.</value>
    [DataMember(Name="isVisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// If a plug is inserted but not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.
    /// </summary>
    /// <value>If a plug is inserted but not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.</value>
    [DataMember(Name="enableFailIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableFailIndexes")]
    public List<int?> EnableFailIndexes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemSocketState {\n");
      sb.Append("  PlugHash: ").Append(PlugHash).Append("\n");
      sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
      sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
      sb.Append("  EnableFailIndexes: ").Append(EnableFailIndexes).Append("\n");
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
