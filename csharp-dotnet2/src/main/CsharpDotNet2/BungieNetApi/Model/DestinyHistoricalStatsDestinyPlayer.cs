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
  public class DestinyHistoricalStatsDestinyPlayer {
    /// <summary>
    /// Details about the player as they are known in game (platform display name, Destiny emblem)
    /// </summary>
    /// <value>Details about the player as they are known in game (platform display name, Destiny emblem)</value>
    [DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyUserInfo")]
    public UserUserInfoCard DestinyUserInfo { get; set; }

    /// <summary>
    /// Class of the character if applicable and available.
    /// </summary>
    /// <value>Class of the character if applicable and available.</value>
    [DataMember(Name="characterClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterClass")]
    public string CharacterClass { get; set; }

    /// <summary>
    /// Gets or Sets ClassHash
    /// </summary>
    [DataMember(Name="classHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classHash")]
    public int? ClassHash { get; set; }

    /// <summary>
    /// Gets or Sets RaceHash
    /// </summary>
    [DataMember(Name="raceHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raceHash")]
    public int? RaceHash { get; set; }

    /// <summary>
    /// Gets or Sets GenderHash
    /// </summary>
    [DataMember(Name="genderHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderHash")]
    public int? GenderHash { get; set; }

    /// <summary>
    /// Level of the character if available. Zero if it is not available.
    /// </summary>
    /// <value>Level of the character if available. Zero if it is not available.</value>
    [DataMember(Name="characterLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterLevel")]
    public int? CharacterLevel { get; set; }

    /// <summary>
    /// Light Level of the character if available. Zero if it is not available.
    /// </summary>
    /// <value>Light Level of the character if available. Zero if it is not available.</value>
    [DataMember(Name="lightLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lightLevel")]
    public int? LightLevel { get; set; }

    /// <summary>
    /// Details about the player as they are known on BungieNet. This will be undefined if the player has marked their credential private, or does not have a BungieNet account.
    /// </summary>
    /// <value>Details about the player as they are known on BungieNet. This will be undefined if the player has marked their credential private, or does not have a BungieNet account.</value>
    [DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bungieNetUserInfo")]
    public UserUserInfoCard BungieNetUserInfo { get; set; }

    /// <summary>
    /// Current clan name for the player. This value may be null or an empty string if the user does not have a clan.
    /// </summary>
    /// <value>Current clan name for the player. This value may be null or an empty string if the user does not have a clan.</value>
    [DataMember(Name="clanName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanName")]
    public string ClanName { get; set; }

    /// <summary>
    /// Current clan tag for the player. This value may be null or an empty string if the user does not have a clan.
    /// </summary>
    /// <value>Current clan tag for the player. This value may be null or an empty string if the user does not have a clan.</value>
    [DataMember(Name="clanTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanTag")]
    public string ClanTag { get; set; }

    /// <summary>
    /// If we know the emblem's hash, this can be used to look up the player's emblem at the time of a match when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to obtain it).
    /// </summary>
    /// <value>If we know the emblem's hash, this can be used to look up the player's emblem at the time of a match when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to obtain it).</value>
    [DataMember(Name="emblemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemHash")]
    public int? EmblemHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyPlayer {\n");
      sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
      sb.Append("  CharacterClass: ").Append(CharacterClass).Append("\n");
      sb.Append("  ClassHash: ").Append(ClassHash).Append("\n");
      sb.Append("  RaceHash: ").Append(RaceHash).Append("\n");
      sb.Append("  GenderHash: ").Append(GenderHash).Append("\n");
      sb.Append("  CharacterLevel: ").Append(CharacterLevel).Append("\n");
      sb.Append("  LightLevel: ").Append(LightLevel).Append("\n");
      sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
      sb.Append("  ClanName: ").Append(ClanName).Append("\n");
      sb.Append("  ClanTag: ").Append(ClanTag).Append("\n");
      sb.Append("  EmblemHash: ").Append(EmblemHash).Append("\n");
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
