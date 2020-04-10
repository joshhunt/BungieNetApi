using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The results of a bulk Equipping operation performed through the Destiny API.
  /// </summary>
  [DataContract]
  public class DestinyDestinyEquipItemResults {
    /// <summary>
    /// Gets or Sets EquipResults
    /// </summary>
    [DataMember(Name="equipResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipResults")]
    public List<DestinyDestinyEquipItemResult> EquipResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyEquipItemResults {\n");
      sb.Append("  EquipResults: ").Append(EquipResults).Append("\n");
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
