using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Talent Grids on items have Nodes. These nodes have positions in the talent grid&#39;s UI, and contain \&quot;Steps\&quot; (DestinyTalentNodeStepDefinition), one of whom will be the \&quot;Current\&quot; step.  The Current Step determines the visual properties of the node, as well as what the node grants when it is activated.  See DestinyTalentGridDefinition for a more complete overview of how Talent Grids work, and how they are used in Destiny 2 (and how they were used in Destiny 1).
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyTalentNodeDefinition {
    /// <summary>
    /// The index into the DestinyTalentGridDefinition's \"nodes\" property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.
    /// </summary>
    /// <value>The index into the DestinyTalentGridDefinition's \"nodes\" property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.</value>
    [DataMember(Name="nodeIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeIndex")]
    public int? NodeIndex { get; set; }

    /// <summary>
    /// The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!
    /// </summary>
    /// <value>The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!</value>
    [DataMember(Name="nodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeHash")]
    public int? NodeHash { get; set; }

    /// <summary>
    /// The visual \"row\" where the node should be shown in the UI. If negative, then the node is hidden.
    /// </summary>
    /// <value>The visual \"row\" where the node should be shown in the UI. If negative, then the node is hidden.</value>
    [DataMember(Name="row", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "row")]
    public int? Row { get; set; }

    /// <summary>
    /// The visual \"column\" where the node should be shown in the UI. If negative, the node is hidden.
    /// </summary>
    /// <value>The visual \"column\" where the node should be shown in the UI. If negative, the node is hidden.</value>
    [DataMember(Name="column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column")]
    public int? Column { get; set; }

    /// <summary>
    /// Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time.
    /// </summary>
    /// <value>Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time.</value>
    [DataMember(Name="prerequisiteNodeIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prerequisiteNodeIndexes")]
    public List<int?> PrerequisiteNodeIndexes { get; set; }

    /// <summary>
    /// At one point, Talent Nodes supported the idea of \"Binary Pairs\": nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.
    /// </summary>
    /// <value>At one point, Talent Nodes supported the idea of \"Binary Pairs\": nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.</value>
    [DataMember(Name="binaryPairNodeIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "binaryPairNodeIndex")]
    public int? BinaryPairNodeIndex { get; set; }

    /// <summary>
    /// If true, this node will automatically unlock when the Talent Grid's level reaches the required level of the current step of this node.
    /// </summary>
    /// <value>If true, this node will automatically unlock when the Talent Grid's level reaches the required level of the current step of this node.</value>
    [DataMember(Name="autoUnlocks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoUnlocks")]
    public bool? AutoUnlocks { get; set; }

    /// <summary>
    /// At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn't out of the question that this could end up being used again in a theoretical future.
    /// </summary>
    /// <value>At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn't out of the question that this could end up being used again in a theoretical future.</value>
    [DataMember(Name="lastStepRepeats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastStepRepeats")]
    public bool? LastStepRepeats { get; set; }

    /// <summary>
    /// If this is true, the node's step is determined randomly rather than the first step being chosen.
    /// </summary>
    /// <value>If this is true, the node's step is determined randomly rather than the first step being chosen.</value>
    [DataMember(Name="isRandom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isRandom")]
    public bool? IsRandom { get; set; }

    /// <summary>
    /// At one point, you were going to be able to repurchase talent nodes that had random steps, to \"re-roll\" the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!
    /// </summary>
    /// <value>At one point, you were going to be able to repurchase talent nodes that had random steps, to \"re-roll\" the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!</value>
    [DataMember(Name="randomActivationRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "randomActivationRequirement")]
    public DestinyDefinitionsDestinyNodeActivationRequirement RandomActivationRequirement { get; set; }

    /// <summary>
    /// If this is true, the node can be \"re-rolled\" to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.
    /// </summary>
    /// <value>If this is true, the node can be \"re-rolled\" to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.</value>
    [DataMember(Name="isRandomRepurchasable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isRandomRepurchasable")]
    public bool? IsRandomRepurchasable { get; set; }

    /// <summary>
    /// At this point, \"steps\" have been obfuscated into conceptual entities, aggregating the underlying notions of \"properties\" and \"true steps\".  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you'll have to use the \"realSteps\" property below.
    /// </summary>
    /// <value>At this point, \"steps\" have been obfuscated into conceptual entities, aggregating the underlying notions of \"properties\" and \"true steps\".  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you'll have to use the \"realSteps\" property below.</value>
    [DataMember(Name="steps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "steps")]
    public List<DestinyDefinitionsDestinyNodeStepDefinition> Steps { get; set; }

    /// <summary>
    /// The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes.
    /// </summary>
    /// <value>The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes.</value>
    [DataMember(Name="exclusiveWithNodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclusiveWithNodeHashes")]
    public List<int?> ExclusiveWithNodeHashes { get; set; }

    /// <summary>
    /// If the node's step is randomly selected, this is the amount of the Talent Grid's progression experience at which the progression bar for the node should be shown.
    /// </summary>
    /// <value>If the node's step is randomly selected, this is the amount of the Talent Grid's progression experience at which the progression bar for the node should be shown.</value>
    [DataMember(Name="randomStartProgressionBarAtProgression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "randomStartProgressionBarAtProgression")]
    public int? RandomStartProgressionBarAtProgression { get; set; }

    /// <summary>
    /// A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.
    /// </summary>
    /// <value>A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.</value>
    [DataMember(Name="layoutIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "layoutIdentifier")]
    public string LayoutIdentifier { get; set; }

    /// <summary>
    /// As of Destiny 2, nodes can exist as part of \"Exclusive Groups\". These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \"opposing\" nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node's group, if it is part of one.
    /// </summary>
    /// <value>As of Destiny 2, nodes can exist as part of \"Exclusive Groups\". These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \"opposing\" nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node's group, if it is part of one.</value>
    [DataMember(Name="groupHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupHash")]
    public int? GroupHash { get; set; }

    /// <summary>
    /// Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.
    /// </summary>
    /// <value>Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.</value>
    [DataMember(Name="loreHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loreHash")]
    public int? LoreHash { get; set; }

    /// <summary>
    /// Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.
    /// </summary>
    /// <value>Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.</value>
    [DataMember(Name="nodeStyleIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeStyleIdentifier")]
    public string NodeStyleIdentifier { get; set; }

    /// <summary>
    /// Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.
    /// </summary>
    /// <value>Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.</value>
    [DataMember(Name="ignoreForCompletion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreForCompletion")]
    public bool? IgnoreForCompletion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyTalentNodeDefinition {\n");
      sb.Append("  NodeIndex: ").Append(NodeIndex).Append("\n");
      sb.Append("  NodeHash: ").Append(NodeHash).Append("\n");
      sb.Append("  Row: ").Append(Row).Append("\n");
      sb.Append("  Column: ").Append(Column).Append("\n");
      sb.Append("  PrerequisiteNodeIndexes: ").Append(PrerequisiteNodeIndexes).Append("\n");
      sb.Append("  BinaryPairNodeIndex: ").Append(BinaryPairNodeIndex).Append("\n");
      sb.Append("  AutoUnlocks: ").Append(AutoUnlocks).Append("\n");
      sb.Append("  LastStepRepeats: ").Append(LastStepRepeats).Append("\n");
      sb.Append("  IsRandom: ").Append(IsRandom).Append("\n");
      sb.Append("  RandomActivationRequirement: ").Append(RandomActivationRequirement).Append("\n");
      sb.Append("  IsRandomRepurchasable: ").Append(IsRandomRepurchasable).Append("\n");
      sb.Append("  Steps: ").Append(Steps).Append("\n");
      sb.Append("  ExclusiveWithNodeHashes: ").Append(ExclusiveWithNodeHashes).Append("\n");
      sb.Append("  RandomStartProgressionBarAtProgression: ").Append(RandomStartProgressionBarAtProgression).Append("\n");
      sb.Append("  LayoutIdentifier: ").Append(LayoutIdentifier).Append("\n");
      sb.Append("  GroupHash: ").Append(GroupHash).Append("\n");
      sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
      sb.Append("  NodeStyleIdentifier: ").Append(NodeStyleIdentifier).Append("\n");
      sb.Append("  IgnoreForCompletion: ").Append(IgnoreForCompletion).Append("\n");
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
