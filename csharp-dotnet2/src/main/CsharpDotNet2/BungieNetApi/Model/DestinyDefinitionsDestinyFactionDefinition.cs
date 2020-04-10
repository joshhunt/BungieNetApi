using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// These definitions represent Factions in the game. Factions have ended up unilaterally being related to Vendors that represent them, but that need not necessarily be the case.  A Faction is really just an entity that has a related progression for which a character can gain experience. In Destiny 1, Dead Orbit was an example of a Faction: there happens to be a Vendor that represents Dead Orbit (and indeed, DestinyVendorDefinition.factionHash defines to this relationship), but Dead Orbit could theoretically exist without the Vendor that provides rewards.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyFactionDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The hash identifier for the DestinyProgressionDefinition that indicates the character's relationship with this faction in terms of experience and levels.
    /// </summary>
    /// <value>The hash identifier for the DestinyProgressionDefinition that indicates the character's relationship with this faction in terms of experience and levels.</value>
    [DataMember(Name="progressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionHash")]
    public int? ProgressionHash { get; set; }

    /// <summary>
    /// The faction token item hashes, and their respective progression values.
    /// </summary>
    /// <value>The faction token item hashes, and their respective progression values.</value>
    [DataMember(Name="tokenValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenValues")]
    public Dictionary<string, int?> TokenValues { get; set; }

    /// <summary>
    /// The faction reward item hash, usually an engram.
    /// </summary>
    /// <value>The faction reward item hash, usually an engram.</value>
    [DataMember(Name="rewardItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardItemHash")]
    public int? RewardItemHash { get; set; }

    /// <summary>
    /// The faction reward vendor hash, used for faction engram previews.
    /// </summary>
    /// <value>The faction reward vendor hash, used for faction engram previews.</value>
    [DataMember(Name="rewardVendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardVendorHash")]
    public int? RewardVendorHash { get; set; }

    /// <summary>
    /// List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.
    /// </summary>
    /// <value>List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.</value>
    [DataMember(Name="vendors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendors")]
    public List<DestinyDefinitionsDestinyFactionVendorDefinition> Vendors { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyFactionDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
      sb.Append("  TokenValues: ").Append(TokenValues).Append("\n");
      sb.Append("  RewardItemHash: ").Append(RewardItemHash).Append("\n");
      sb.Append("  RewardVendorHash: ").Append(RewardVendorHash).Append("\n");
      sb.Append("  Vendors: ").Append(Vendors).Append("\n");
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
