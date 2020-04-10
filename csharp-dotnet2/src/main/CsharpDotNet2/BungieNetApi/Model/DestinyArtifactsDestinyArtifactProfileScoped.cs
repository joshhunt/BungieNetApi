using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a Seasonal Artifact and all data related to it for the requested Account.  It can be combined with Character-scoped data for a full picture of what a character has available/has chosen, or just these settings can be used for overview information.
  /// </summary>
  [DataContract]
  public class DestinyArtifactsDestinyArtifactProfileScoped {
    /// <summary>
    /// Gets or Sets ArtifactHash
    /// </summary>
    [DataMember(Name="artifactHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactHash")]
    public int? ArtifactHash { get; set; }

    /// <summary>
    /// Gets or Sets PointProgression
    /// </summary>
    [DataMember(Name="pointProgression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pointProgression")]
    public DestinyDestinyProgression PointProgression { get; set; }

    /// <summary>
    /// Gets or Sets PointsAcquired
    /// </summary>
    [DataMember(Name="pointsAcquired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pointsAcquired")]
    public int? PointsAcquired { get; set; }

    /// <summary>
    /// Gets or Sets PowerBonusProgression
    /// </summary>
    [DataMember(Name="powerBonusProgression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "powerBonusProgression")]
    public DestinyDestinyProgression PowerBonusProgression { get; set; }

    /// <summary>
    /// Gets or Sets PowerBonus
    /// </summary>
    [DataMember(Name="powerBonus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "powerBonus")]
    public int? PowerBonus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyArtifactsDestinyArtifactProfileScoped {\n");
      sb.Append("  ArtifactHash: ").Append(ArtifactHash).Append("\n");
      sb.Append("  PointProgression: ").Append(PointProgression).Append("\n");
      sb.Append("  PointsAcquired: ").Append(PointsAcquired).Append("\n");
      sb.Append("  PowerBonusProgression: ").Append(PowerBonusProgression).Append("\n");
      sb.Append("  PowerBonus: ").Append(PowerBonus).Append("\n");
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
