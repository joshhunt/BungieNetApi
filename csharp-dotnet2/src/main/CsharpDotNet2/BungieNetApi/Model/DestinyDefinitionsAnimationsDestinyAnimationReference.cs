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
  public class DestinyDefinitionsAnimationsDestinyAnimationReference {
    /// <summary>
    /// Gets or Sets AnimName
    /// </summary>
    [DataMember(Name="animName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animName")]
    public string AnimName { get; set; }

    /// <summary>
    /// Gets or Sets AnimIdentifier
    /// </summary>
    [DataMember(Name="animIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animIdentifier")]
    public string AnimIdentifier { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsAnimationsDestinyAnimationReference {\n");
      sb.Append("  AnimName: ").Append(AnimName).Append("\n");
      sb.Append("  AnimIdentifier: ").Append(AnimIdentifier).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
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
