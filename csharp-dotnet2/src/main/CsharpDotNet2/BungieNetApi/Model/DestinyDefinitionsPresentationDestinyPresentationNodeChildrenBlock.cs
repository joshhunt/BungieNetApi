using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// As/if presentation nodes begin to host more entities as children, these lists will be added to. One list property exists per type of entity that can be treated as a child of this presentation node, and each holds the identifier of the entity and any associated information needed to display the UI for that entity (if anything)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock {
    /// <summary>
    /// Gets or Sets PresentationNodes
    /// </summary>
    [DataMember(Name="presentationNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationNodes")]
    public List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> PresentationNodes { get; set; }

    /// <summary>
    /// Gets or Sets Collectibles
    /// </summary>
    [DataMember(Name="collectibles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectibles")]
    public List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> Collectibles { get; set; }

    /// <summary>
    /// Gets or Sets Records
    /// </summary>
    [DataMember(Name="records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "records")]
    public List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> Records { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> Metrics { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock {\n");
      sb.Append("  PresentationNodes: ").Append(PresentationNodes).Append("\n");
      sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
      sb.Append("  Records: ").Append(Records).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
