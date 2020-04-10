using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsRecordsDestinyRecordIntervalObjective {
    /// <summary>
    /// Gets or Sets IntervalObjectiveHash
    /// </summary>
    [DataMember(Name="intervalObjectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalObjectiveHash")]
    public int? IntervalObjectiveHash { get; set; }

    /// <summary>
    /// Gets or Sets IntervalScoreValue
    /// </summary>
    [DataMember(Name="intervalScoreValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalScoreValue")]
    public int? IntervalScoreValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsRecordsDestinyRecordIntervalObjective {\n");
      sb.Append("  IntervalObjectiveHash: ").Append(IntervalObjectiveHash).Append("\n");
      sb.Append("  IntervalScoreValue: ").Append(IntervalScoreValue).Append("\n");
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
