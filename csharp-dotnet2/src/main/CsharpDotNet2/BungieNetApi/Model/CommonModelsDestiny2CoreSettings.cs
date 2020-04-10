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
  public class CommonModelsDestiny2CoreSettings {
    /// <summary>
    /// Gets or Sets CollectionRootNode
    /// </summary>
    [DataMember(Name="collectionRootNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectionRootNode")]
    public int? CollectionRootNode { get; set; }

    /// <summary>
    /// Gets or Sets BadgesRootNode
    /// </summary>
    [DataMember(Name="badgesRootNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "badgesRootNode")]
    public int? BadgesRootNode { get; set; }

    /// <summary>
    /// Gets or Sets RecordsRootNode
    /// </summary>
    [DataMember(Name="recordsRootNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recordsRootNode")]
    public int? RecordsRootNode { get; set; }

    /// <summary>
    /// Gets or Sets MedalsRootNode
    /// </summary>
    [DataMember(Name="medalsRootNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medalsRootNode")]
    public int? MedalsRootNode { get; set; }

    /// <summary>
    /// Gets or Sets MetricsRootNode
    /// </summary>
    [DataMember(Name="metricsRootNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricsRootNode")]
    public int? MetricsRootNode { get; set; }

    /// <summary>
    /// Gets or Sets CurrentRankProgressionHashes
    /// </summary>
    [DataMember(Name="currentRankProgressionHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentRankProgressionHashes")]
    public List<int?> CurrentRankProgressionHashes { get; set; }

    /// <summary>
    /// Gets or Sets UndiscoveredCollectibleImage
    /// </summary>
    [DataMember(Name="undiscoveredCollectibleImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "undiscoveredCollectibleImage")]
    public string UndiscoveredCollectibleImage { get; set; }

    /// <summary>
    /// Gets or Sets AmmoTypeHeavyIcon
    /// </summary>
    [DataMember(Name="ammoTypeHeavyIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ammoTypeHeavyIcon")]
    public string AmmoTypeHeavyIcon { get; set; }

    /// <summary>
    /// Gets or Sets AmmoTypeSpecialIcon
    /// </summary>
    [DataMember(Name="ammoTypeSpecialIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ammoTypeSpecialIcon")]
    public string AmmoTypeSpecialIcon { get; set; }

    /// <summary>
    /// Gets or Sets AmmoTypePrimaryIcon
    /// </summary>
    [DataMember(Name="ammoTypePrimaryIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ammoTypePrimaryIcon")]
    public string AmmoTypePrimaryIcon { get; set; }

    /// <summary>
    /// Gets or Sets CurrentSeasonalArtifactHash
    /// </summary>
    [DataMember(Name="currentSeasonalArtifactHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSeasonalArtifactHash")]
    public int? CurrentSeasonalArtifactHash { get; set; }

    /// <summary>
    /// Gets or Sets CurrentSeasonHash
    /// </summary>
    [DataMember(Name="currentSeasonHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSeasonHash")]
    public int? CurrentSeasonHash { get; set; }

    /// <summary>
    /// Gets or Sets FutureSeasonHashes
    /// </summary>
    [DataMember(Name="futureSeasonHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "futureSeasonHashes")]
    public List<int?> FutureSeasonHashes { get; set; }

    /// <summary>
    /// Gets or Sets PastSeasonHashes
    /// </summary>
    [DataMember(Name="pastSeasonHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pastSeasonHashes")]
    public List<int?> PastSeasonHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommonModelsDestiny2CoreSettings {\n");
      sb.Append("  CollectionRootNode: ").Append(CollectionRootNode).Append("\n");
      sb.Append("  BadgesRootNode: ").Append(BadgesRootNode).Append("\n");
      sb.Append("  RecordsRootNode: ").Append(RecordsRootNode).Append("\n");
      sb.Append("  MedalsRootNode: ").Append(MedalsRootNode).Append("\n");
      sb.Append("  MetricsRootNode: ").Append(MetricsRootNode).Append("\n");
      sb.Append("  CurrentRankProgressionHashes: ").Append(CurrentRankProgressionHashes).Append("\n");
      sb.Append("  UndiscoveredCollectibleImage: ").Append(UndiscoveredCollectibleImage).Append("\n");
      sb.Append("  AmmoTypeHeavyIcon: ").Append(AmmoTypeHeavyIcon).Append("\n");
      sb.Append("  AmmoTypeSpecialIcon: ").Append(AmmoTypeSpecialIcon).Append("\n");
      sb.Append("  AmmoTypePrimaryIcon: ").Append(AmmoTypePrimaryIcon).Append("\n");
      sb.Append("  CurrentSeasonalArtifactHash: ").Append(CurrentSeasonalArtifactHash).Append("\n");
      sb.Append("  CurrentSeasonHash: ").Append(CurrentSeasonHash).Append("\n");
      sb.Append("  FutureSeasonHashes: ").Append(FutureSeasonHashes).Append("\n");
      sb.Append("  PastSeasonHashes: ").Append(PastSeasonHashes).Append("\n");
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
