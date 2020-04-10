using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a canonical \&quot;Season\&quot; of Destiny: a range of a few months where the game highlights certain challenges, provides new loot, has new Clan-related rewards and celebrates various seasonal events.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsSeasonsDestinySeasonDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Gets or Sets BackgroundImagePath
    /// </summary>
    [DataMember(Name="backgroundImagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundImagePath")]
    public string BackgroundImagePath { get; set; }

    /// <summary>
    /// Gets or Sets SeasonNumber
    /// </summary>
    [DataMember(Name="seasonNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonNumber")]
    public int? SeasonNumber { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets SeasonPassHash
    /// </summary>
    [DataMember(Name="seasonPassHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonPassHash")]
    public int? SeasonPassHash { get; set; }

    /// <summary>
    /// Gets or Sets SeasonPassProgressionHash
    /// </summary>
    [DataMember(Name="seasonPassProgressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonPassProgressionHash")]
    public int? SeasonPassProgressionHash { get; set; }

    /// <summary>
    /// Gets or Sets ArtifactItemHash
    /// </summary>
    [DataMember(Name="artifactItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactItemHash")]
    public int? ArtifactItemHash { get; set; }

    /// <summary>
    /// Gets or Sets SealPresentationNodeHash
    /// </summary>
    [DataMember(Name="sealPresentationNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sealPresentationNodeHash")]
    public int? SealPresentationNodeHash { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsSeasonsDestinySeasonDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  BackgroundImagePath: ").Append(BackgroundImagePath).Append("\n");
      sb.Append("  SeasonNumber: ").Append(SeasonNumber).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  SeasonPassHash: ").Append(SeasonPassHash).Append("\n");
      sb.Append("  SeasonPassProgressionHash: ").Append(SeasonPassProgressionHash).Append("\n");
      sb.Append("  ArtifactItemHash: ").Append(ArtifactItemHash).Append("\n");
      sb.Append("  SealPresentationNodeHash: ").Append(SealPresentationNodeHash).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
