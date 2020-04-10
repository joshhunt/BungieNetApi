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
  public class DestinyArtifactsDestinyArtifactCharacterScoped {
    /// <summary>
    /// Gets or Sets ArtifactHash
    /// </summary>
    [DataMember(Name="artifactHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactHash")]
    public int? ArtifactHash { get; set; }

    /// <summary>
    /// Gets or Sets PointsUsed
    /// </summary>
    [DataMember(Name="pointsUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pointsUsed")]
    public int? PointsUsed { get; set; }

    /// <summary>
    /// Gets or Sets ResetCount
    /// </summary>
    [DataMember(Name="resetCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetCount")]
    public int? ResetCount { get; set; }

    /// <summary>
    /// Gets or Sets Tiers
    /// </summary>
    [DataMember(Name="tiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tiers")]
    public List<DestinyArtifactsDestinyArtifactTier> Tiers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyArtifactsDestinyArtifactCharacterScoped {\n");
      sb.Append("  ArtifactHash: ").Append(ArtifactHash).Append("\n");
      sb.Append("  PointsUsed: ").Append(PointsUsed).Append("\n");
      sb.Append("  ResetCount: ").Append(ResetCount).Append("\n");
      sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
