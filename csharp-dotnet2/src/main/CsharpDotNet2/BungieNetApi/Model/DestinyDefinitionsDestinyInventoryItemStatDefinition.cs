using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a specific stat value on an item, and the minimum/maximum range that we could compute for the item based on our heuristics for how the item might be generated.  Not guaranteed to match real-world instances of the item, but should hopefully at least be close. If it&#39;s not close, let us know on the Bungie API forums.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyInventoryItemStatDefinition {
    /// <summary>
    /// The hash for the DestinyStatDefinition representing this stat.
    /// </summary>
    /// <value>The hash for the DestinyStatDefinition representing this stat.</value>
    [DataMember(Name="statHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statHash")]
    public int? StatHash { get; set; }

    /// <summary>
    /// This value represents the stat value assuming the minimum possible roll but accounting for any mandatory bonuses that should be applied to the stat on item creation.  In Destiny 1, this was different from the \"minimum\" value because there were certain conditions where an item could be theoretically lower level/value than the initial roll.   In Destiny 2, this is not possible unless Talent Grids begin to be used again for these purposes or some other system change occurs... thus in practice, value and minimum should be the same in Destiny 2. Good riddance.
    /// </summary>
    /// <value>This value represents the stat value assuming the minimum possible roll but accounting for any mandatory bonuses that should be applied to the stat on item creation.  In Destiny 1, this was different from the \"minimum\" value because there were certain conditions where an item could be theoretically lower level/value than the initial roll.   In Destiny 2, this is not possible unless Talent Grids begin to be used again for these purposes or some other system change occurs... thus in practice, value and minimum should be the same in Destiny 2. Good riddance.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public int? Value { get; set; }

    /// <summary>
    /// The minimum possible value for this stat that we think the item can roll.
    /// </summary>
    /// <value>The minimum possible value for this stat that we think the item can roll.</value>
    [DataMember(Name="minimum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum")]
    public int? Minimum { get; set; }

    /// <summary>
    /// The maximum possible value for this stat that we think the item can roll.  WARNING: In Destiny 1, this field was calculated using the potential stat rolls on the item's talent grid. In Destiny 2, items no longer have meaningful talent grids and instead have sockets: but the calculation of this field was never altered to adapt to this change. As such, this field should be considered deprecated until we can address this oversight.
    /// </summary>
    /// <value>The maximum possible value for this stat that we think the item can roll.  WARNING: In Destiny 1, this field was calculated using the potential stat rolls on the item's talent grid. In Destiny 2, items no longer have meaningful talent grids and instead have sockets: but the calculation of this field was never altered to adapt to this change. As such, this field should be considered deprecated until we can address this oversight.</value>
    [DataMember(Name="maximum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum")]
    public int? Maximum { get; set; }

    /// <summary>
    /// The maximum possible value for the stat as shown in the UI, if it is being shown somewhere that reveals maximum in the UI (such as a bar chart-style view).  This is pulled directly from the item's DestinyStatGroupDefinition, and placed here for convenience.  If not returned, there is no maximum to use (and thus the stat should not be shown in a way that assumes there is a limit to the stat)
    /// </summary>
    /// <value>The maximum possible value for the stat as shown in the UI, if it is being shown somewhere that reveals maximum in the UI (such as a bar chart-style view).  This is pulled directly from the item's DestinyStatGroupDefinition, and placed here for convenience.  If not returned, there is no maximum to use (and thus the stat should not be shown in a way that assumes there is a limit to the stat)</value>
    [DataMember(Name="displayMaximum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayMaximum")]
    public int? DisplayMaximum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyInventoryItemStatDefinition {\n");
      sb.Append("  StatHash: ").Append(StatHash).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Minimum: ").Append(Minimum).Append("\n");
      sb.Append("  Maximum: ").Append(Maximum).Append("\n");
      sb.Append("  DisplayMaximum: ").Append(DisplayMaximum).Append("\n");
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
