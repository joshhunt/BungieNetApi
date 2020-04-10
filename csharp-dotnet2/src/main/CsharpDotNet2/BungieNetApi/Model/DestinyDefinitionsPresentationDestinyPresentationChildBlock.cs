using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsPresentationDestinyPresentationChildBlock {
    /// <summary>
    /// Gets or Sets PresentationNodeType
    /// </summary>
    [DataMember(Name="presentationNodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationNodeType")]
    public int? PresentationNodeType { get; set; }

    /// <summary>
    /// Gets or Sets ParentPresentationNodeHashes
    /// </summary>
    [DataMember(Name="parentPresentationNodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentPresentationNodeHashes")]
    public List<int?> ParentPresentationNodeHashes { get; set; }

    /// <summary>
    /// Gets or Sets DisplayStyle
    /// </summary>
    [DataMember(Name="displayStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayStyle")]
    public int? DisplayStyle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsPresentationDestinyPresentationChildBlock {\n");
      sb.Append("  PresentationNodeType: ").Append(PresentationNodeType).Append("\n");
      sb.Append("  ParentPresentationNodeHashes: ").Append(ParentPresentationNodeHashes).Append("\n");
      sb.Append("  DisplayStyle: ").Append(DisplayStyle).Append("\n");
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
