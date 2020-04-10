using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This is the position and other data related to nodes in the activity graph that you can click to launch activities. An Activity Graph node will only have one active Activity at a time, which will determine the activity to be launched (and, unless overrideDisplay information is provided, will also determine the tooltip and other UI related to the node)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition {
    /// <summary>
    /// An identifier for the Activity Graph Node, only guaranteed to be unique within its parent Activity Graph.
    /// </summary>
    /// <value>An identifier for the Activity Graph Node, only guaranteed to be unique within its parent Activity Graph.</value>
    [DataMember(Name="nodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeId")]
    public int? NodeId { get; set; }

    /// <summary>
    /// The node *may* have display properties that override the active Activity's display properties.
    /// </summary>
    /// <value>The node *may* have display properties that override the active Activity's display properties.</value>
    [DataMember(Name="overrideDisplay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrideDisplay")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition OverrideDisplay { get; set; }

    /// <summary>
    /// The position on the map for this node.
    /// </summary>
    /// <value>The position on the map for this node.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public DestinyDefinitionsCommonDestinyPositionDefinition Position { get; set; }

    /// <summary>
    /// The node may have various visual accents placed on it, or styles applied. These are the list of possible styles that the Node can have. The game iterates through each, looking for the first one that passes a check of the required game/character/account state in order to show that style, and then renders the node in that style.
    /// </summary>
    /// <value>The node may have various visual accents placed on it, or styles applied. These are the list of possible styles that the Node can have. The game iterates through each, looking for the first one that passes a check of the required game/character/account state in order to show that style, and then renders the node in that style.</value>
    [DataMember(Name="featuringStates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featuringStates")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition> FeaturingStates { get; set; }

    /// <summary>
    /// The node may have various possible activities that could be active for it, however only one may be active at a time. See the DestinyActivityGraphNodeActivityDefinition for details.
    /// </summary>
    /// <value>The node may have various possible activities that could be active for it, however only one may be active at a time. See the DestinyActivityGraphNodeActivityDefinition for details.</value>
    [DataMember(Name="activities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activities")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition> Activities { get; set; }

    /// <summary>
    /// Represents possible states that the graph node can be in. These are combined with some checking that happens in the game client and server to determine which state is actually active at any given time.
    /// </summary>
    /// <value>Represents possible states that the graph node can be in. These are combined with some checking that happens in the game client and server to determine which state is actually active at any given time.</value>
    [DataMember(Name="states", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "states")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry> States { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition {\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  OverrideDisplay: ").Append(OverrideDisplay).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  FeaturingStates: ").Append(FeaturingStates).Append("\n");
      sb.Append("  Activities: ").Append(Activities).Append("\n");
      sb.Append("  States: ").Append(States).Append("\n");
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
