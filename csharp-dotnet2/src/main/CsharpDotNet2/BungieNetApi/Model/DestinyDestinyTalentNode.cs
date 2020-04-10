using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// I see you&#39;ve come to find out more about Talent Nodes. I&#39;m so sorry. Talent Nodes are the conceptual, visual nodes that appear on Talent Grids. Talent Grids, in Destiny 1, were found on almost every instanced item: they had Nodes that could be activated to change the properties of the item. In Destiny 2, Talent Grids only exist for Builds/Subclasses, and while the basic concept is the same (Nodes can be activated once you&#39;ve gained sufficient Experience on the Item, and provide effects), there are some new concepts from Destiny 1. Examine DestinyTalentGridDefinition and its subordinates for more information. This is the \&quot;Live\&quot; information for the current status of a Talent Node on a specific item. Talent Nodes have many Steps, but only one can be active at any one time: and it is the Step that determines both the visual and the game state-changing properties that the Node provides. Examine this and DestinyTalentNodeStepDefinition carefully. *IMPORTANT NOTE* Talent Nodes are, unfortunately, Content Version DEPENDENT. Though they refer to hashes for Nodes and Steps, those hashes are not guaranteed to be immutable across content versions. This is a source of great exasperation for me, but as a result anyone using Talent Grid data must ensure that the content version of their static content matches that of the server responses before showing or making decisions based on talent grid data.
  /// </summary>
  [DataContract]
  public class DestinyDestinyTalentNode {
    /// <summary>
    /// The index of the Talent Node being referred to (an index into DestinyTalentGridDefinition.nodes[]). CONTENT VERSION DEPENDENT.
    /// </summary>
    /// <value>The index of the Talent Node being referred to (an index into DestinyTalentGridDefinition.nodes[]). CONTENT VERSION DEPENDENT.</value>
    [DataMember(Name="nodeIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeIndex")]
    public int? NodeIndex { get; set; }

    /// <summary>
    /// The hash of the Talent Node being referred to (in DestinyTalentGridDefinition.nodes). Deceptively CONTENT VERSION DEPENDENT. We have no guarantee of the hash's immutability between content versions.
    /// </summary>
    /// <value>The hash of the Talent Node being referred to (in DestinyTalentGridDefinition.nodes). Deceptively CONTENT VERSION DEPENDENT. We have no guarantee of the hash's immutability between content versions.</value>
    [DataMember(Name="nodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeHash")]
    public int? NodeHash { get; set; }

    /// <summary>
    /// An DestinyTalentNodeState enum value indicating the node's state: whether it can be activated or swapped, and why not if neither can be performed.
    /// </summary>
    /// <value>An DestinyTalentNodeState enum value indicating the node's state: whether it can be activated or swapped, and why not if neither can be performed.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public int? State { get; set; }

    /// <summary>
    /// If true, the node is activated: it's current step then provides its benefits.
    /// </summary>
    /// <value>If true, the node is activated: it's current step then provides its benefits.</value>
    [DataMember(Name="isActivated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isActivated")]
    public bool? IsActivated { get; set; }

    /// <summary>
    /// The currently relevant Step for the node. It is this step that has rendering data for the node and the benefits that are provided if the node is activated. (the actual rules for benefits provided are extremely complicated in theory, but with how Talent Grids are being used in Destiny 2 you don't have to worry about a lot of those old Destiny 1 rules.) This is an index into: DestinyTalentGridDefinition.nodes[nodeIndex].steps[stepIndex]
    /// </summary>
    /// <value>The currently relevant Step for the node. It is this step that has rendering data for the node and the benefits that are provided if the node is activated. (the actual rules for benefits provided are extremely complicated in theory, but with how Talent Grids are being used in Destiny 2 you don't have to worry about a lot of those old Destiny 1 rules.) This is an index into: DestinyTalentGridDefinition.nodes[nodeIndex].steps[stepIndex]</value>
    [DataMember(Name="stepIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepIndex")]
    public int? StepIndex { get; set; }

    /// <summary>
    /// If the node has material requirements to be activated, this is the list of those requirements.
    /// </summary>
    /// <value>If the node has material requirements to be activated, this is the list of those requirements.</value>
    [DataMember(Name="materialsToUpgrade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "materialsToUpgrade")]
    public List<DestinyDefinitionsDestinyMaterialRequirement> MaterialsToUpgrade { get; set; }

    /// <summary>
    /// The progression level required on the Talent Grid in order to be able to activate this talent node. Talent Grids have their own Progression - similar to Character Level, but in this case it is experience related to the item itself.
    /// </summary>
    /// <value>The progression level required on the Talent Grid in order to be able to activate this talent node. Talent Grids have their own Progression - similar to Character Level, but in this case it is experience related to the item itself.</value>
    [DataMember(Name="activationGridLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activationGridLevel")]
    public int? ActivationGridLevel { get; set; }

    /// <summary>
    /// If you want to show a progress bar or circle for how close this talent node is to being activate-able, this is the percentage to show. It follows the node's underlying rules about when the progress bar should first show up, and when it should be filled.
    /// </summary>
    /// <value>If you want to show a progress bar or circle for how close this talent node is to being activate-able, this is the percentage to show. It follows the node's underlying rules about when the progress bar should first show up, and when it should be filled.</value>
    [DataMember(Name="progressPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressPercent")]
    public float? ProgressPercent { get; set; }

    /// <summary>
    /// Whether or not the talent node is actually visible in the game's UI. Whether you want to show it in your own UI is up to you! I'm not gonna tell you who to sock it to.
    /// </summary>
    /// <value>Whether or not the talent node is actually visible in the game's UI. Whether you want to show it in your own UI is up to you! I'm not gonna tell you who to sock it to.</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// This property has some history. A talent grid can provide stats on both the item it's related to and the character equipping the item. This returns data about those stat bonuses.
    /// </summary>
    /// <value>This property has some history. A talent grid can provide stats on both the item it's related to and the character equipping the item. This returns data about those stat bonuses.</value>
    [DataMember(Name="nodeStatsBlock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeStatsBlock")]
    public DestinyDestinyTalentNodeStatBlock NodeStatsBlock { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyTalentNode {\n");
      sb.Append("  NodeIndex: ").Append(NodeIndex).Append("\n");
      sb.Append("  NodeHash: ").Append(NodeHash).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  IsActivated: ").Append(IsActivated).Append("\n");
      sb.Append("  StepIndex: ").Append(StepIndex).Append("\n");
      sb.Append("  MaterialsToUpgrade: ").Append(MaterialsToUpgrade).Append("\n");
      sb.Append("  ActivationGridLevel: ").Append(ActivationGridLevel).Append("\n");
      sb.Append("  ProgressPercent: ").Append(ProgressPercent).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  NodeStatsBlock: ").Append(NodeStatsBlock).Append("\n");
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
