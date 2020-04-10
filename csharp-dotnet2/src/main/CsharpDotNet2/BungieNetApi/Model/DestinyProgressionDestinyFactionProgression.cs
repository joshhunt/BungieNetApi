using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Mostly for historical purposes, we segregate Faction progressions from other progressions. This is just a DestinyProgression with a shortcut for finding the DestinyFactionDefinition of the faction related to the progression.
  /// </summary>
  [DataContract]
  public class DestinyProgressionDestinyFactionProgression {
    /// <summary>
    /// The hash identifier of the Faction related to this progression. Use it to look up the DestinyFactionDefinition for more rendering info.
    /// </summary>
    /// <value>The hash identifier of the Faction related to this progression. Use it to look up the DestinyFactionDefinition for more rendering info.</value>
    [DataMember(Name="factionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factionHash")]
    public int? FactionHash { get; set; }

    /// <summary>
    /// The index of the Faction vendor that is currently available. Will be set to -1 if no vendors are available.
    /// </summary>
    /// <value>The index of the Faction vendor that is currently available. Will be set to -1 if no vendors are available.</value>
    [DataMember(Name="factionVendorIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factionVendorIndex")]
    public int? FactionVendorIndex { get; set; }

    /// <summary>
    /// The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.
    /// </summary>
    /// <value>The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.</value>
    [DataMember(Name="progressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionHash")]
    public int? ProgressionHash { get; set; }

    /// <summary>
    /// The amount of progress earned today for this progression.
    /// </summary>
    /// <value>The amount of progress earned today for this progression.</value>
    [DataMember(Name="dailyProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dailyProgress")]
    public int? DailyProgress { get; set; }

    /// <summary>
    /// If this progression has a daily limit, this is that limit.
    /// </summary>
    /// <value>If this progression has a daily limit, this is that limit.</value>
    [DataMember(Name="dailyLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dailyLimit")]
    public int? DailyLimit { get; set; }

    /// <summary>
    /// The amount of progress earned toward this progression in the current week.
    /// </summary>
    /// <value>The amount of progress earned toward this progression in the current week.</value>
    [DataMember(Name="weeklyProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weeklyProgress")]
    public int? WeeklyProgress { get; set; }

    /// <summary>
    /// If this progression has a weekly limit, this is that limit.
    /// </summary>
    /// <value>If this progression has a weekly limit, this is that limit.</value>
    [DataMember(Name="weeklyLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weeklyLimit")]
    public int? WeeklyLimit { get; set; }

    /// <summary>
    /// This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)
    /// </summary>
    /// <value>This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)</value>
    [DataMember(Name="currentProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentProgress")]
    public int? CurrentProgress { get; set; }

    /// <summary>
    /// This is the level of the progression (for instance, the Character Level).
    /// </summary>
    /// <value>This is the level of the progression (for instance, the Character Level).</value>
    [DataMember(Name="level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level")]
    public int? Level { get; set; }

    /// <summary>
    /// This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)
    /// </summary>
    /// <value>This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)</value>
    [DataMember(Name="levelCap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "levelCap")]
    public int? LevelCap { get; set; }

    /// <summary>
    /// Progressions define their levels in \"steps\". Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \"steps\" property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)
    /// </summary>
    /// <value>Progressions define their levels in \"steps\". Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \"steps\" property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)</value>
    [DataMember(Name="stepIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepIndex")]
    public int? StepIndex { get; set; }

    /// <summary>
    /// The amount of progression (i.e. \"Experience\") needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.
    /// </summary>
    /// <value>The amount of progression (i.e. \"Experience\") needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.</value>
    [DataMember(Name="progressToNextLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressToNextLevel")]
    public int? ProgressToNextLevel { get; set; }

    /// <summary>
    /// The total amount of progression (i.e. \"Experience\") needed in order to reach the next level.
    /// </summary>
    /// <value>The total amount of progression (i.e. \"Experience\") needed in order to reach the next level.</value>
    [DataMember(Name="nextLevelAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextLevelAt")]
    public int? NextLevelAt { get; set; }

    /// <summary>
    /// The number of resets of this progression you've executed this season, if applicable to this progression.
    /// </summary>
    /// <value>The number of resets of this progression you've executed this season, if applicable to this progression.</value>
    [DataMember(Name="currentResetCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentResetCount")]
    public int? CurrentResetCount { get; set; }

    /// <summary>
    /// Information about historical resets of this progression, if there is any data for it.
    /// </summary>
    /// <value>Information about historical resets of this progression, if there is any data for it.</value>
    [DataMember(Name="seasonResets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonResets")]
    public List<DestinyDestinyProgressionResetEntry> SeasonResets { get; set; }

    /// <summary>
    /// Information about historical rewards for this progression, if there is any data for it.
    /// </summary>
    /// <value>Information about historical rewards for this progression, if there is any data for it.</value>
    [DataMember(Name="rewardItemStates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardItemStates")]
    public List<int?> RewardItemStates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyProgressionDestinyFactionProgression {\n");
      sb.Append("  FactionHash: ").Append(FactionHash).Append("\n");
      sb.Append("  FactionVendorIndex: ").Append(FactionVendorIndex).Append("\n");
      sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
      sb.Append("  DailyProgress: ").Append(DailyProgress).Append("\n");
      sb.Append("  DailyLimit: ").Append(DailyLimit).Append("\n");
      sb.Append("  WeeklyProgress: ").Append(WeeklyProgress).Append("\n");
      sb.Append("  WeeklyLimit: ").Append(WeeklyLimit).Append("\n");
      sb.Append("  CurrentProgress: ").Append(CurrentProgress).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  LevelCap: ").Append(LevelCap).Append("\n");
      sb.Append("  StepIndex: ").Append(StepIndex).Append("\n");
      sb.Append("  ProgressToNextLevel: ").Append(ProgressToNextLevel).Append("\n");
      sb.Append("  NextLevelAt: ").Append(NextLevelAt).Append("\n");
      sb.Append("  CurrentResetCount: ").Append(CurrentResetCount).Append("\n");
      sb.Append("  SeasonResets: ").Append(SeasonResets).Append("\n");
      sb.Append("  RewardItemStates: ").Append(RewardItemStates).Append("\n");
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
