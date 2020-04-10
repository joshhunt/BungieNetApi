using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a stat on an item *or* Character (NOT a Historical Stat, but a physical attribute stat like Attack, Defense etc...)
  /// </summary>
  [DataContract]
  public class DestinyDestinyStat {
    /// <summary>
    /// The hash identifier for the Stat. Use it to look up the DestinyStatDefinition for static data about the stat.
    /// </summary>
    /// <value>The hash identifier for the Stat. Use it to look up the DestinyStatDefinition for static data about the stat.</value>
    [DataMember(Name="statHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statHash")]
    public int? StatHash { get; set; }

    /// <summary>
    /// The current value of the Stat.
    /// </summary>
    /// <value>The current value of the Stat.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public int? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyStat {\n");
      sb.Append("  StatHash: ").Append(StatHash).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
