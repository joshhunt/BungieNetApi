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
  public class ContentModelsContentPreview {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets ItemInSet
    /// </summary>
    [DataMember(Name="itemInSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemInSet")]
    public bool? ItemInSet { get; set; }

    /// <summary>
    /// Gets or Sets SetTag
    /// </summary>
    [DataMember(Name="setTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setTag")]
    public string SetTag { get; set; }

    /// <summary>
    /// Gets or Sets SetNesting
    /// </summary>
    [DataMember(Name="setNesting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setNesting")]
    public int? SetNesting { get; set; }

    /// <summary>
    /// Gets or Sets UseSetId
    /// </summary>
    [DataMember(Name="useSetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useSetId")]
    public int? UseSetId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsContentPreview {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  ItemInSet: ").Append(ItemInSet).Append("\n");
      sb.Append("  SetTag: ").Append(SetTag).Append("\n");
      sb.Append("  SetNesting: ").Append(SetNesting).Append("\n");
      sb.Append("  UseSetId: ").Append(UseSetId).Append("\n");
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
