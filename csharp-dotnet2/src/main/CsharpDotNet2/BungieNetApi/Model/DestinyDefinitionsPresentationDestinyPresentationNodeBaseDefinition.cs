using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This is the base class for all presentation system children. Presentation Nodes, Records, Collectibles, and Metrics.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition {
    /// <summary>
    /// Gets or Sets PresentationNodeType
    /// </summary>
    [DataMember(Name="presentationNodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationNodeType")]
    public int? PresentationNodeType { get; set; }

    /// <summary>
    /// Gets or Sets TraitIds
    /// </summary>
    [DataMember(Name="traitIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traitIds")]
    public List<string> TraitIds { get; set; }

    /// <summary>
    /// Gets or Sets TraitHashes
    /// </summary>
    [DataMember(Name="traitHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traitHashes")]
    public List<int?> TraitHashes { get; set; }

    /// <summary>
    /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
    /// </summary>
    /// <value>A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</value>
    [DataMember(Name="parentNodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentNodeHashes")]
    public List<int?> ParentNodeHashes { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition {\n");
      sb.Append("  PresentationNodeType: ").Append(PresentationNodeType).Append("\n");
      sb.Append("  TraitIds: ").Append(TraitIds).Append("\n");
      sb.Append("  TraitHashes: ").Append(TraitHashes).Append("\n");
      sb.Append("  ParentNodeHashes: ").Append(ParentNodeHashes).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
