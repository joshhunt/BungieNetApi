using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Well, we&#39;re here in Destiny 2, and Talent Grids are unfortunately still around.  The good news is that they&#39;re pretty much only being used for certain base information on items and for Builds/Subclasses. The bad news is that they still suck. If you really want this information, grab this component.  An important note is that talent grids are defined as such:  A Grid has 1:M Nodes, which has 1:M Steps.  Any given node can only have a single step active at one time, which represents the actual visual contents and effects of the Node (for instance, if you see a \&quot;Super Cool Bonus\&quot; node, the actual icon and text for the node is coming from the current Step of that node).  Nodes can be grouped into exclusivity sets *and* as of D2, exclusivity groups (which are collections of exclusivity sets that affect each other).  See DestinyTalentGridDefinition for more information. Brace yourself, the water&#39;s cold out there in the deep end.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemTalentGridComponent {
    /// <summary>
    /// Most items don't have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.
    /// </summary>
    /// <value>Most items don't have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.</value>
    [DataMember(Name="talentGridHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "talentGridHash")]
    public int? TalentGridHash { get; set; }

    /// <summary>
    /// Detailed information about the individual nodes in the talent grid.  A node represents a single visual \"pip\" in the talent grid or Build detail view, though each node may have multiple \"steps\" which indicate the actual bonuses and visual representation of that node.
    /// </summary>
    /// <value>Detailed information about the individual nodes in the talent grid.  A node represents a single visual \"pip\" in the talent grid or Build detail view, though each node may have multiple \"steps\" which indicate the actual bonuses and visual representation of that node.</value>
    [DataMember(Name="nodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodes")]
    public List<DestinyDestinyTalentNode> Nodes { get; set; }

    /// <summary>
    /// Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)
    /// </summary>
    /// <value>Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)</value>
    [DataMember(Name="isGridComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isGridComplete")]
    public bool? IsGridComplete { get; set; }

    /// <summary>
    /// If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.
    /// </summary>
    /// <value>If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.</value>
    [DataMember(Name="gridProgression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gridProgression")]
    public DestinyDestinyProgression GridProgression { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemTalentGridComponent {\n");
      sb.Append("  TalentGridHash: ").Append(TalentGridHash).Append("\n");
      sb.Append("  Nodes: ").Append(Nodes).Append("\n");
      sb.Append("  IsGridComplete: ").Append(IsGridComplete).Append("\n");
      sb.Append("  GridProgression: ").Append(GridProgression).Append("\n");
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
