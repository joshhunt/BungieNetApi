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
  public class DestinyDefinitionsRecordsDestinyRecordIntervalBlock {
    /// <summary>
    /// Gets or Sets IntervalObjectives
    /// </summary>
    [DataMember(Name="intervalObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalObjectives")]
    public List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> IntervalObjectives { get; set; }

    /// <summary>
    /// Gets or Sets OriginalObjectiveArrayInsertionIndex
    /// </summary>
    [DataMember(Name="originalObjectiveArrayInsertionIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalObjectiveArrayInsertionIndex")]
    public int? OriginalObjectiveArrayInsertionIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsRecordsDestinyRecordIntervalBlock {\n");
      sb.Append("  IntervalObjectives: ").Append(IntervalObjectives).Append("\n");
      sb.Append("  OriginalObjectiveArrayInsertionIndex: ").Append(OriginalObjectiveArrayInsertionIndex).Append("\n");
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
