using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyTalentExclusiveGroup {
    /// <summary>
    /// The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.
    /// </summary>
    /// <value>The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.</value>
    [DataMember(Name="groupHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupHash")]
    public int? GroupHash { get; set; }

    /// <summary>
    /// If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.
    /// </summary>
    /// <value>If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.</value>
    [DataMember(Name="loreHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loreHash")]
    public int? LoreHash { get; set; }

    /// <summary>
    /// A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
    /// </summary>
    /// <value>A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)</value>
    [DataMember(Name="nodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeHashes")]
    public List<int?> NodeHashes { get; set; }

    /// <summary>
    /// A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.
    /// </summary>
    /// <value>A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.</value>
    [DataMember(Name="opposingGroupHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opposingGroupHashes")]
    public List<int?> OpposingGroupHashes { get; set; }

    /// <summary>
    /// A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
    /// </summary>
    /// <value>A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)</value>
    [DataMember(Name="opposingNodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opposingNodeHashes")]
    public List<int?> OpposingNodeHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyTalentExclusiveGroup {\n");
      sb.Append("  GroupHash: ").Append(GroupHash).Append("\n");
      sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
      sb.Append("  NodeHashes: ").Append(NodeHashes).Append("\n");
      sb.Append("  OpposingGroupHashes: ").Append(OpposingGroupHashes).Append("\n");
      sb.Append("  OpposingNodeHashes: ").Append(OpposingNodeHashes).Append("\n");
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
