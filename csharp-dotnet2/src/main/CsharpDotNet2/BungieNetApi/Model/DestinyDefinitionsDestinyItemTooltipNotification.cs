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
  public class DestinyDefinitionsDestinyItemTooltipNotification {
    /// <summary>
    /// Gets or Sets DisplayString
    /// </summary>
    [DataMember(Name="displayString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayString")]
    public string DisplayString { get; set; }

    /// <summary>
    /// Gets or Sets DisplayStyle
    /// </summary>
    [DataMember(Name="displayStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayStyle")]
    public string DisplayStyle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemTooltipNotification {\n");
      sb.Append("  DisplayString: ").Append(DisplayString).Append("\n");
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
