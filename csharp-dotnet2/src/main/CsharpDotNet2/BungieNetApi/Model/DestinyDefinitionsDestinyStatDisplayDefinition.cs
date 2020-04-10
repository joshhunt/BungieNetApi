using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Describes the way that an Item Stat (see DestinyStatDefinition) is transformed using the DestinyStatGroupDefinition related to that item. See both of the aforementioned definitions for more information about the stages of stat transformation.  This represents the transformation of a stat into a \&quot;Display\&quot; stat (the closest value that BNet can get to the in-game display value of the stat)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyStatDisplayDefinition {
    /// <summary>
    /// The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition's stats property.
    /// </summary>
    /// <value>The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition's stats property.</value>
    [DataMember(Name="statHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statHash")]
    public int? StatHash { get; set; }

    /// <summary>
    /// Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)
    /// </summary>
    /// <value>Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)</value>
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumValue")]
    public int? MaximumValue { get; set; }

    /// <summary>
    /// If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There's no displayAsNumeric police.
    /// </summary>
    /// <value>If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There's no displayAsNumeric police.</value>
    [DataMember(Name="displayAsNumeric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayAsNumeric")]
    public bool? DisplayAsNumeric { get; set; }

    /// <summary>
    /// The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation.
    /// </summary>
    /// <value>The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation.</value>
    [DataMember(Name="displayInterpolation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayInterpolation")]
    public List<InterpolationInterpolationPoint> DisplayInterpolation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyStatDisplayDefinition {\n");
      sb.Append("  StatHash: ").Append(StatHash).Append("\n");
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      sb.Append("  DisplayAsNumeric: ").Append(DisplayAsNumeric).Append("\n");
      sb.Append("  DisplayInterpolation: ").Append(DisplayInterpolation).Append("\n");
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
