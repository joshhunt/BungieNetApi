using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// In Destiny, \&quot;Races\&quot; are really more like \&quot;Species\&quot;. Sort of. I mean, are the Awoken a separate species from humans? I&#39;m not sure. But either way, they&#39;re defined here. You&#39;ll see Exo, Awoken, and Human as examples of these Species. Players will choose one for their character.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyRaceDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// An enumeration defining the existing, known Races/Species for player characters. This value will be the enum value matching this definition.
    /// </summary>
    /// <value>An enumeration defining the existing, known Races/Species for player characters. This value will be the enum value matching this definition.</value>
    [DataMember(Name="raceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raceType")]
    public int? RaceType { get; set; }

    /// <summary>
    /// A localized string referring to the singular form of the Race's name when referred to in gendered form. Keyed by the DestinyGender.
    /// </summary>
    /// <value>A localized string referring to the singular form of the Race's name when referred to in gendered form. Keyed by the DestinyGender.</value>
    [DataMember(Name="genderedRaceNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderedRaceNames")]
    public Dictionary<string, string> GenderedRaceNames { get; set; }

    /// <summary>
    /// Gets or Sets GenderedRaceNamesByGenderHash
    /// </summary>
    [DataMember(Name="genderedRaceNamesByGenderHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderedRaceNamesByGenderHash")]
    public Dictionary<string, string> GenderedRaceNamesByGenderHash { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyRaceDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  RaceType: ").Append(RaceType).Append("\n");
      sb.Append("  GenderedRaceNames: ").Append(GenderedRaceNames).Append("\n");
      sb.Append("  GenderedRaceNamesByGenderHash: ").Append(GenderedRaceNamesByGenderHash).Append("\n");
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
