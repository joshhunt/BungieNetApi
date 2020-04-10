using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a Map View in the director: be them overview views, destination views, or other.  They have nodes which map to activities, and other various visual elements that we (or others) may or may not be able to use.  Activity graphs, most importantly, have nodes which can have activities in various states of playability.  Unfortunately, activity graphs are combined at runtime with Game UI-only assets such as fragments of map images, various in-game special effects, decals etc... that we don&#39;t get in these definitions.  If we end up having time, we may end up trying to manually populate those here: but the last time we tried that, before the lead-up to D1, it proved to be unmaintainable as the game&#39;s content changed. So don&#39;t bet the farm on us providing that content in this definition.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDirectorDestinyActivityGraphDefinition {
    /// <summary>
    /// These represent the visual \"nodes\" on the map's view. These are the activities you can click on in the map.
    /// </summary>
    /// <value>These represent the visual \"nodes\" on the map's view. These are the activities you can click on in the map.</value>
    [DataMember(Name="nodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodes")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition> Nodes { get; set; }

    /// <summary>
    /// Represents one-off/special UI elements that appear on the map.
    /// </summary>
    /// <value>Represents one-off/special UI elements that appear on the map.</value>
    [DataMember(Name="artElements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artElements")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition> ArtElements { get; set; }

    /// <summary>
    /// Represents connections between graph nodes. However, it lacks context that we'd need to make good use of it.
    /// </summary>
    /// <value>Represents connections between graph nodes. However, it lacks context that we'd need to make good use of it.</value>
    [DataMember(Name="connections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connections")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition> Connections { get; set; }

    /// <summary>
    /// Objectives can display on maps, and this is supposedly metadata for that. I have not had the time to analyze the details of what is useful within however: we could be missing important data to make this work. Expect this property to be expanded on later if possible.
    /// </summary>
    /// <value>Objectives can display on maps, and this is supposedly metadata for that. I have not had the time to analyze the details of what is useful within however: we could be missing important data to make this work. Expect this property to be expanded on later if possible.</value>
    [DataMember(Name="displayObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayObjectives")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition> DisplayObjectives { get; set; }

    /// <summary>
    /// Progressions can also display on maps, but similarly to displayObjectives we appear to lack some required information and context right now. We will have to look into it later and add more data if possible.
    /// </summary>
    /// <value>Progressions can also display on maps, but similarly to displayObjectives we appear to lack some required information and context right now. We will have to look into it later and add more data if possible.</value>
    [DataMember(Name="displayProgressions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProgressions")]
    public List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition> DisplayProgressions { get; set; }

    /// <summary>
    /// Represents links between this Activity Graph and other ones.
    /// </summary>
    /// <value>Represents links between this Activity Graph and other ones.</value>
    [DataMember(Name="linkedGraphs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedGraphs")]
    public List<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition> LinkedGraphs { get; set; }

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
      sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphDefinition {\n");
      sb.Append("  Nodes: ").Append(Nodes).Append("\n");
      sb.Append("  ArtElements: ").Append(ArtElements).Append("\n");
      sb.Append("  Connections: ").Append(Connections).Append("\n");
      sb.Append("  DisplayObjectives: ").Append(DisplayObjectives).Append("\n");
      sb.Append("  DisplayProgressions: ").Append(DisplayProgressions).Append("\n");
      sb.Append("  LinkedGraphs: ").Append(LinkedGraphs).Append("\n");
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
