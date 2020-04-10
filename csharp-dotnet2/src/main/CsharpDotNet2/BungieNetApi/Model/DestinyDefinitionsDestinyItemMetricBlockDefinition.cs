using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The metrics available for display and selection on an item.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemMetricBlockDefinition {
    /// <summary>
    /// Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list available metrics. Any metric listed directly below these nodes, or in any of these nodes' children will be made available for selection.
    /// </summary>
    /// <value>Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list available metrics. Any metric listed directly below these nodes, or in any of these nodes' children will be made available for selection.</value>
    [DataMember(Name="availableMetricCategoryNodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableMetricCategoryNodeHashes")]
    public List<int?> AvailableMetricCategoryNodeHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemMetricBlockDefinition {\n");
      sb.Append("  AvailableMetricCategoryNodeHashes: ").Append(AvailableMetricCategoryNodeHashes).Append("\n");
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
