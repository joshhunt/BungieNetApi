using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A PresentationNode is an entity that represents a logical grouping of other entities visually/organizationally.  For now, Presentation Nodes may contain the following... but it may be used for more in the future:  - Collectibles - Records (Or, as the public will call them, \&quot;Triumphs.\&quot; Don&#39;t ask me why we&#39;re overloading the term \&quot;Triumph\&quot;, it still hurts me to think about it) - Metrics (aka Stat Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created  Part of me wants to break these into conceptual definitions per entity being collected, but the possibility of these different types being mixed in the same UI and the possibility that it could actually be more useful to return the \&quot;bare metal\&quot; presentation node concept has resulted in me deciding against that for the time being.  We&#39;ll see if I come to regret this as well.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsPresentationDestinyPresentationNodeDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The original icon for this presentation node, before we futzed with it.
    /// </summary>
    /// <value>The original icon for this presentation node, before we futzed with it.</value>
    [DataMember(Name="originalIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalIcon")]
    public string OriginalIcon { get; set; }

    /// <summary>
    /// Some presentation nodes are meant to be explicitly shown on the \"root\" or \"entry\" screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \"entry point\" view in your UI. If you don't have a UI, then I guess it doesn't matter either way does it?
    /// </summary>
    /// <value>Some presentation nodes are meant to be explicitly shown on the \"root\" or \"entry\" screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \"entry point\" view in your UI. If you don't have a UI, then I guess it doesn't matter either way does it?</value>
    [DataMember(Name="rootViewIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rootViewIcon")]
    public string RootViewIcon { get; set; }

    /// <summary>
    /// Gets or Sets NodeType
    /// </summary>
    [DataMember(Name="nodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeType")]
    public int? NodeType { get; set; }

    /// <summary>
    /// Indicates whether this presentation node's state is determined on a per-character or on an account-wide basis.
    /// </summary>
    /// <value>Indicates whether this presentation node's state is determined on a per-character or on an account-wide basis.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.
    /// </summary>
    /// <value>If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.</value>
    [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHash")]
    public int? ObjectiveHash { get; set; }

    /// <summary>
    /// If this presentation node has an associated \"Record\" that you can accomplish for completing its children, this is the identifier of that Record.
    /// </summary>
    /// <value>If this presentation node has an associated \"Record\" that you can accomplish for completing its children, this is the identifier of that Record.</value>
    [DataMember(Name="completionRecordHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionRecordHash")]
    public int? CompletionRecordHash { get; set; }

    /// <summary>
    /// The child entities contained by this presentation node.
    /// </summary>
    /// <value>The child entities contained by this presentation node.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock Children { get; set; }

    /// <summary>
    /// A hint for how to display this presentation node when it's shown in a list.
    /// </summary>
    /// <value>A hint for how to display this presentation node when it's shown in a list.</value>
    [DataMember(Name="displayStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayStyle")]
    public int? DisplayStyle { get; set; }

    /// <summary>
    /// A hint for how to display this presentation node when it's shown in its own detail screen.
    /// </summary>
    /// <value>A hint for how to display this presentation node when it's shown in its own detail screen.</value>
    [DataMember(Name="screenStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screenStyle")]
    public int? ScreenStyle { get; set; }

    /// <summary>
    /// The requirements for being able to interact with this presentation node and its children.
    /// </summary>
    /// <value>The requirements for being able to interact with this presentation node and its children.</value>
    [DataMember(Name="requirements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirements")]
    public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; set; }

    /// <summary>
    /// If this presentation node has children, but the game doesn't let you inspect the details of those children, that is indicated here.
    /// </summary>
    /// <value>If this presentation node has children, but the game doesn't let you inspect the details of those children, that is indicated here.</value>
    [DataMember(Name="disableChildSubscreenNavigation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disableChildSubscreenNavigation")]
    public bool? DisableChildSubscreenNavigation { get; set; }

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
      sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  OriginalIcon: ").Append(OriginalIcon).Append("\n");
      sb.Append("  RootViewIcon: ").Append(RootViewIcon).Append("\n");
      sb.Append("  NodeType: ").Append(NodeType).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
      sb.Append("  CompletionRecordHash: ").Append(CompletionRecordHash).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  DisplayStyle: ").Append(DisplayStyle).Append("\n");
      sb.Append("  ScreenStyle: ").Append(ScreenStyle).Append("\n");
      sb.Append("  Requirements: ").Append(Requirements).Append("\n");
      sb.Append("  DisableChildSubscreenNavigation: ").Append(DisableChildSubscreenNavigation).Append("\n");
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
