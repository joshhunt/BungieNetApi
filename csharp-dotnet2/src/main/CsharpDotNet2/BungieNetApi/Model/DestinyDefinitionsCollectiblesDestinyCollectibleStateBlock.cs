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
  public class DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock {
    /// <summary>
    /// Gets or Sets ObscuredOverrideItemHash
    /// </summary>
    [DataMember(Name="obscuredOverrideItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obscuredOverrideItemHash")]
    public int? ObscuredOverrideItemHash { get; set; }

    /// <summary>
    /// Gets or Sets Requirements
    /// </summary>
    [DataMember(Name="requirements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirements")]
    public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock {\n");
      sb.Append("  ObscuredOverrideItemHash: ").Append(ObscuredOverrideItemHash).Append("\n");
      sb.Append("  Requirements: ").Append(Requirements).Append("\n");
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
