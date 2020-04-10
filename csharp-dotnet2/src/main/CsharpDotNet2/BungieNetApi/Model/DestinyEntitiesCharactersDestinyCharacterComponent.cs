using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This component contains base properties of the character. You&#39;ll probably want to always request this component, but hey you do you.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesCharactersDestinyCharacterComponent {
    /// <summary>
    /// Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.
    /// </summary>
    /// <value>Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.</value>
    [DataMember(Name="membershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipId")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.
    /// </summary>
    /// <value>membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.</value>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }

    /// <summary>
    /// The unique identifier for the character.
    /// </summary>
    /// <value>The unique identifier for the character.</value>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }

    /// <summary>
    /// The last date that the user played Destiny.
    /// </summary>
    /// <value>The last date that the user played Destiny.</value>
    [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateLastPlayed")]
    public DateTime? DateLastPlayed { get; set; }

    /// <summary>
    /// If the user is currently playing, this is how long they've been playing.
    /// </summary>
    /// <value>If the user is currently playing, this is how long they've been playing.</value>
    [DataMember(Name="minutesPlayedThisSession", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minutesPlayedThisSession")]
    public long? MinutesPlayedThisSession { get; set; }

    /// <summary>
    /// If this value is 525,600, then they played Destiny for a year. Or they're a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.
    /// </summary>
    /// <value>If this value is 525,600, then they played Destiny for a year. Or they're a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.</value>
    [DataMember(Name="minutesPlayedTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minutesPlayedTotal")]
    public long? MinutesPlayedTotal { get; set; }

    /// <summary>
    /// The user's calculated \"Light Level\". Light level is an indicator of your power that mostly matters in the end game, once you've reached the maximum character level: it's a level that's dependent on the average Attack/Defense power of your items.
    /// </summary>
    /// <value>The user's calculated \"Light Level\". Light level is an indicator of your power that mostly matters in the end game, once you've reached the maximum character level: it's a level that's dependent on the average Attack/Defense power of your items.</value>
    [DataMember(Name="light", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "light")]
    public int? Light { get; set; }

    /// <summary>
    /// Your character's stats, such as Agility, Resilience, etc... *not* historical stats.  You'll have to call a different endpoint for those.
    /// </summary>
    /// <value>Your character's stats, such as Agility, Resilience, etc... *not* historical stats.  You'll have to call a different endpoint for those.</value>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public Dictionary<string, int?> Stats { get; set; }

    /// <summary>
    /// Use this hash to look up the character's DestinyRaceDefinition.
    /// </summary>
    /// <value>Use this hash to look up the character's DestinyRaceDefinition.</value>
    [DataMember(Name="raceHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raceHash")]
    public int? RaceHash { get; set; }

    /// <summary>
    /// Use this hash to look up the character's DestinyGenderDefinition.
    /// </summary>
    /// <value>Use this hash to look up the character's DestinyGenderDefinition.</value>
    [DataMember(Name="genderHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderHash")]
    public int? GenderHash { get; set; }

    /// <summary>
    /// Use this hash to look up the character's DestinyClassDefinition.
    /// </summary>
    /// <value>Use this hash to look up the character's DestinyClassDefinition.</value>
    [DataMember(Name="classHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classHash")]
    public int? ClassHash { get; set; }

    /// <summary>
    /// Mostly for historical purposes at this point, this is an enumeration for the character's race.  It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
    /// </summary>
    /// <value>Mostly for historical purposes at this point, this is an enumeration for the character's race.  It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.</value>
    [DataMember(Name="raceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raceType")]
    public int? RaceType { get; set; }

    /// <summary>
    /// Mostly for historical purposes at this point, this is an enumeration for the character's class.  It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
    /// </summary>
    /// <value>Mostly for historical purposes at this point, this is an enumeration for the character's class.  It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.</value>
    [DataMember(Name="classType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classType")]
    public int? ClassType { get; set; }

    /// <summary>
    /// Mostly for historical purposes at this point, this is an enumeration for the character's Gender.  It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it's an enumeration and not a boolean. Fight me.
    /// </summary>
    /// <value>Mostly for historical purposes at this point, this is an enumeration for the character's Gender.  It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it's an enumeration and not a boolean. Fight me.</value>
    [DataMember(Name="genderType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderType")]
    public int? GenderType { get; set; }

    /// <summary>
    /// A shortcut path to the user's currently equipped emblem image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
    /// </summary>
    /// <value>A shortcut path to the user's currently equipped emblem image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.</value>
    [DataMember(Name="emblemPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemPath")]
    public string EmblemPath { get; set; }

    /// <summary>
    /// A shortcut path to the user's currently equipped emblem background image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
    /// </summary>
    /// <value>A shortcut path to the user's currently equipped emblem background image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.</value>
    [DataMember(Name="emblemBackgroundPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemBackgroundPath")]
    public string EmblemBackgroundPath { get; set; }

    /// <summary>
    /// The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
    /// </summary>
    /// <value>The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.</value>
    [DataMember(Name="emblemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemHash")]
    public int? EmblemHash { get; set; }

    /// <summary>
    /// A shortcut for getting the background color of the user's currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.
    /// </summary>
    /// <value>A shortcut for getting the background color of the user's currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.</value>
    [DataMember(Name="emblemColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemColor")]
    public DestinyMiscDestinyColor EmblemColor { get; set; }

    /// <summary>
    /// The progression that indicates your character's level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.
    /// </summary>
    /// <value>The progression that indicates your character's level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.</value>
    [DataMember(Name="levelProgression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "levelProgression")]
    public DestinyDestinyProgression LevelProgression { get; set; }

    /// <summary>
    /// The \"base\" level of your character, not accounting for any light level.
    /// </summary>
    /// <value>The \"base\" level of your character, not accounting for any light level.</value>
    [DataMember(Name="baseCharacterLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseCharacterLevel")]
    public int? BaseCharacterLevel { get; set; }

    /// <summary>
    /// A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.
    /// </summary>
    /// <value>A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.</value>
    [DataMember(Name="percentToNextLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentToNextLevel")]
    public float? PercentToNextLevel { get; set; }

    /// <summary>
    /// If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
    /// </summary>
    /// <value>If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.</value>
    [DataMember(Name="titleRecordHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titleRecordHash")]
    public int? TitleRecordHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesCharactersDestinyCharacterComponent {\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
      sb.Append("  MinutesPlayedThisSession: ").Append(MinutesPlayedThisSession).Append("\n");
      sb.Append("  MinutesPlayedTotal: ").Append(MinutesPlayedTotal).Append("\n");
      sb.Append("  Light: ").Append(Light).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  RaceHash: ").Append(RaceHash).Append("\n");
      sb.Append("  GenderHash: ").Append(GenderHash).Append("\n");
      sb.Append("  ClassHash: ").Append(ClassHash).Append("\n");
      sb.Append("  RaceType: ").Append(RaceType).Append("\n");
      sb.Append("  ClassType: ").Append(ClassType).Append("\n");
      sb.Append("  GenderType: ").Append(GenderType).Append("\n");
      sb.Append("  EmblemPath: ").Append(EmblemPath).Append("\n");
      sb.Append("  EmblemBackgroundPath: ").Append(EmblemBackgroundPath).Append("\n");
      sb.Append("  EmblemHash: ").Append(EmblemHash).Append("\n");
      sb.Append("  EmblemColor: ").Append(EmblemColor).Append("\n");
      sb.Append("  LevelProgression: ").Append(LevelProgression).Append("\n");
      sb.Append("  BaseCharacterLevel: ").Append(BaseCharacterLevel).Append("\n");
      sb.Append("  PercentToNextLevel: ").Append(PercentToNextLevel).Append("\n");
      sb.Append("  TitleRecordHash: ").Append(TitleRecordHash).Append("\n");
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
