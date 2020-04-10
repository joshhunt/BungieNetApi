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
  public class DestinyArtifactsDestinyArtifactTier {
    /// <summary>
    /// Gets or Sets TierHash
    /// </summary>
    [DataMember(Name="tierHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tierHash")]
    public int? TierHash { get; set; }

    /// <summary>
    /// Gets or Sets IsUnlocked
    /// </summary>
    [DataMember(Name="isUnlocked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isUnlocked")]
    public bool? IsUnlocked { get; set; }

    /// <summary>
    /// Gets or Sets PointsToUnlock
    /// </summary>
    [DataMember(Name="pointsToUnlock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pointsToUnlock")]
    public int? PointsToUnlock { get; set; }

    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<DestinyArtifactsDestinyArtifactTierItem> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyArtifactsDestinyArtifactTier {\n");
      sb.Append("  TierHash: ").Append(TierHash).Append("\n");
      sb.Append("  IsUnlocked: ").Append(IsUnlocked).Append("\n");
      sb.Append("  PointsToUnlock: ").Append(PointsToUnlock).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
