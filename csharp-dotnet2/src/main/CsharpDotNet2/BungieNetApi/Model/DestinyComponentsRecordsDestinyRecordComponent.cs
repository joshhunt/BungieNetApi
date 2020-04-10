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
  public class DestinyComponentsRecordsDestinyRecordComponent {
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public int? State { get; set; }

    /// <summary>
    /// Gets or Sets Objectives
    /// </summary>
    [DataMember(Name="objectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectives")]
    public List<DestinyQuestsDestinyObjectiveProgress> Objectives { get; set; }

    /// <summary>
    /// Gets or Sets IntervalObjectives
    /// </summary>
    [DataMember(Name="intervalObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalObjectives")]
    public List<DestinyQuestsDestinyObjectiveProgress> IntervalObjectives { get; set; }

    /// <summary>
    /// Gets or Sets IntervalsRedeemedCount
    /// </summary>
    [DataMember(Name="intervalsRedeemedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalsRedeemedCount")]
    public int? IntervalsRedeemedCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsRecordsDestinyRecordComponent {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Objectives: ").Append(Objectives).Append("\n");
      sb.Append("  IntervalObjectives: ").Append(IntervalObjectives).Append("\n");
      sb.Append("  IntervalsRedeemedCount: ").Append(IntervalsRedeemedCount).Append("\n");
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
