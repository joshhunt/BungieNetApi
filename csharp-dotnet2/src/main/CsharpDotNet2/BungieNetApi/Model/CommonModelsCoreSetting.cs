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
  public class CommonModelsCoreSetting {
    /// <summary>
    /// Gets or Sets Identifier
    /// </summary>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets IsDefault
    /// </summary>
    [DataMember(Name="isDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    /// <summary>
    /// Gets or Sets ImagePath
    /// </summary>
    [DataMember(Name="imagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imagePath")]
    public string ImagePath { get; set; }

    /// <summary>
    /// Gets or Sets ChildSettings
    /// </summary>
    [DataMember(Name="childSettings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childSettings")]
    public List<CommonModelsCoreSetting> ChildSettings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommonModelsCoreSetting {\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
      sb.Append("  ChildSettings: ").Append(ChildSettings).Append("\n");
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
