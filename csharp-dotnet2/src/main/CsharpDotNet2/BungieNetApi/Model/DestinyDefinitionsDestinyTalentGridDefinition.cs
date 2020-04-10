using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The time has unfortunately come to talk about Talent Grids.  Talent Grids are the most complex and unintuitive part of the Destiny Definition data. Grab a cup of coffee before we begin, I can wait.  Talent Grids were the primary way that items could be customized in Destiny 1. In Destiny 2, for now, talent grids have become exclusively used by Subclass/Build items: but the system is still in place for it to be used by items should the direction change back toward talent grids.  Talent Grids have Nodes: the visual circles on the talent grid detail screen that have icons and can be activated if you meet certain requirements and pay costs. The actual visual data and effects, however, are driven by the \&quot;Steps\&quot; on Talent Nodes. Any given node will have 1:M of these steps, and the specific step that will be considered the \&quot;current\&quot; step (and thus the dictator of all benefits, visual state, and activation requirements on the Node) will almost always not be determined until an instance of the item is created. This is how, in Destiny 1, items were able to have such a wide variety of what users saw as \&quot;Perks\&quot;: they were actually Talent Grids with nodes that had a wide variety of Steps, randomly chosen at the time of item creation.  Now that Talent Grids are used exclusively by subclasses and builds, all of the properties within still apply: but there are additional visual elements on the Subclass/Build screens that are superimposed on top of the talent nodes. Unfortunately, BNet doesn&#39;t have this data: if you want to build a subclass screen, you will have to provide your own \&quot;decorative\&quot; assets, such as the visual connectors between nodes and the fancy colored-fire-bathed character standing behind the nodes.  DestinyInventoryItem.talentGrid.talentGridHash defines an item&#39;s linked Talent Grid, which brings you to this definition that contains enough satic data about talent grids to make your head spin. These *must* be combined with instanced data - found when live data returns DestinyItemTalentGridComponent - in order to derive meaning. The instanced data will reference nodes and steps within these definitions, which you will then have to look up in the definition and combine with the instanced data to give the user the visual representation of their item&#39;s talent grid.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyTalentGridDefinition {
    /// <summary>
    /// The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.
    /// </summary>
    /// <value>The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.</value>
    [DataMember(Name="maxGridLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxGridLevel")]
    public int? MaxGridLevel { get; set; }

    /// <summary>
    /// The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \"column\" of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it's just a bit of interesting history.
    /// </summary>
    /// <value>The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \"column\" of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it's just a bit of interesting history.</value>
    [DataMember(Name="gridLevelPerColumn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gridLevelPerColumn")]
    public int? GridLevelPerColumn { get; set; }

    /// <summary>
    /// The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid's level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition's activation requirements for more information.
    /// </summary>
    /// <value>The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid's level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition's activation requirements for more information.</value>
    [DataMember(Name="progressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionHash")]
    public int? ProgressionHash { get; set; }

    /// <summary>
    /// The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).
    /// </summary>
    /// <value>The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).</value>
    [DataMember(Name="nodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodes")]
    public List<DestinyDefinitionsDestinyTalentNodeDefinition> Nodes { get; set; }

    /// <summary>
    /// Talent Nodes can exist in \"exclusive sets\": these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \"Swap\").  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.
    /// </summary>
    /// <value>Talent Nodes can exist in \"exclusive sets\": these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \"Swap\").  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.</value>
    [DataMember(Name="exclusiveSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclusiveSets")]
    public List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> ExclusiveSets { get; set; }

    /// <summary>
    /// This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.
    /// </summary>
    /// <value>This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.</value>
    [DataMember(Name="independentNodeIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "independentNodeIndexes")]
    public List<int?> IndependentNodeIndexes { get; set; }

    /// <summary>
    /// Talent Nodes can have \"Exclusive Groups\". These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \"groupHash\" from DestinyTalentExclusiveGroup.
    /// </summary>
    /// <value>Talent Nodes can have \"Exclusive Groups\". These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \"groupHash\" from DestinyTalentExclusiveGroup.</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> Groups { get; set; }

    /// <summary>
    /// BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \"Independent\" nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.
    /// </summary>
    /// <value>BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \"Independent\" nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.</value>
    [DataMember(Name="nodeCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeCategories")]
    public List<DestinyDefinitionsDestinyTalentNodeCategory> NodeCategories { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyTalentGridDefinition {\n");
      sb.Append("  MaxGridLevel: ").Append(MaxGridLevel).Append("\n");
      sb.Append("  GridLevelPerColumn: ").Append(GridLevelPerColumn).Append("\n");
      sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
      sb.Append("  Nodes: ").Append(Nodes).Append("\n");
      sb.Append("  ExclusiveSets: ").Append(ExclusiveSets).Append("\n");
      sb.Append("  IndependentNodeIndexes: ").Append(IndependentNodeIndexes).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  NodeCategories: ").Append(NodeCategories).Append("\n");
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
