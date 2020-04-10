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
  public class DestinyBaseItemComponentSetOfuint32 {
    /// <summary>
    /// Gets or Sets Objectives
    /// </summary>
    [DataMember(Name="objectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectives")]
    public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyBaseItemComponentSetOfuint32 {\n");
      sb.Append("  Objectives: ").Append(Objectives).Append("\n");
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
