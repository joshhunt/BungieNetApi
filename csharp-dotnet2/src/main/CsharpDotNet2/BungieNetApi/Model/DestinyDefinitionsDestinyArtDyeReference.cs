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
  public class DestinyDefinitionsDestinyArtDyeReference {
    /// <summary>
    /// Gets or Sets ArtDyeChannelHash
    /// </summary>
    [DataMember(Name="artDyeChannelHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artDyeChannelHash")]
    public int? ArtDyeChannelHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyArtDyeReference {\n");
      sb.Append("  ArtDyeChannelHash: ").Append(ArtDyeChannelHash).Append("\n");
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
