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
  public class DestinyDefinitionsDestinyGearArtArrangementReference {
    /// <summary>
    /// Gets or Sets ClassHash
    /// </summary>
    [DataMember(Name="classHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classHash")]
    public int? ClassHash { get; set; }

    /// <summary>
    /// Gets or Sets ArtArrangementHash
    /// </summary>
    [DataMember(Name="artArrangementHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artArrangementHash")]
    public int? ArtArrangementHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyGearArtArrangementReference {\n");
      sb.Append("  ClassHash: ").Append(ClassHash).Append("\n");
      sb.Append("  ArtArrangementHash: ").Append(ArtArrangementHash).Append("\n");
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
