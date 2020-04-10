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
  public class DestinyDefinitionsItemsDestinyParentItemOverride {
    /// <summary>
    /// Gets or Sets AdditionalEquipRequirementsDisplayStrings
    /// </summary>
    [DataMember(Name="additionalEquipRequirementsDisplayStrings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalEquipRequirementsDisplayStrings")]
    public List<string> AdditionalEquipRequirementsDisplayStrings { get; set; }

    /// <summary>
    /// Gets or Sets PipIcon
    /// </summary>
    [DataMember(Name="pipIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pipIcon")]
    public string PipIcon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyParentItemOverride {\n");
      sb.Append("  AdditionalEquipRequirementsDisplayStrings: ").Append(AdditionalEquipRequirementsDisplayStrings).Append("\n");
      sb.Append("  PipIcon: ").Append(PipIcon).Append("\n");
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
