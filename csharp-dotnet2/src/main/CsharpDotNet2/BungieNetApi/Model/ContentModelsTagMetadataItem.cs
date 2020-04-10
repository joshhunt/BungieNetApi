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
  public class ContentModelsTagMetadataItem {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets TagText
    /// </summary>
    [DataMember(Name="tagText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagText")]
    public string TagText { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Gets or Sets IsDefault
    /// </summary>
    [DataMember(Name="isDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsTagMetadataItem {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TagText: ").Append(TagText).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
