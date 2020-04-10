using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents the \&quot;Live\&quot; data that we can obtain about a Character&#39;s status with a specific Activity. This will tell you whether the character can participate in the activity, as well as some other basic mutable information.   Meant to be combined with static DestinyActivityDefinition data for a full picture of the Activity.
  /// </summary>
  [DataContract]
  public class DestinyDestinyActivity {
    /// <summary>
    /// The hash identifier of the Activity. Use this to look up the DestinyActivityDefinition of the activity.
    /// </summary>
    /// <value>The hash identifier of the Activity. Use this to look up the DestinyActivityDefinition of the activity.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// If true, then the activity should have a \"new\" indicator in the Director UI.
    /// </summary>
    /// <value>If true, then the activity should have a \"new\" indicator in the Director UI.</value>
    [DataMember(Name="isNew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isNew")]
    public bool? IsNew { get; set; }

    /// <summary>
    /// If true, the user is allowed to lead a Fireteam into this activity.
    /// </summary>
    /// <value>If true, the user is allowed to lead a Fireteam into this activity.</value>
    [DataMember(Name="canLead", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canLead")]
    public bool? CanLead { get; set; }

    /// <summary>
    /// If true, the user is allowed to join with another Fireteam in this activity.
    /// </summary>
    /// <value>If true, the user is allowed to join with another Fireteam in this activity.</value>
    [DataMember(Name="canJoin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canJoin")]
    public bool? CanJoin { get; set; }

    /// <summary>
    /// If true, we both have the ability to know that the user has completed this activity and they have completed it. Unfortunately, we can't necessarily know this for all activities. As such, this should probably only be used if you already know in advance which specific activities you wish to check.
    /// </summary>
    /// <value>If true, we both have the ability to know that the user has completed this activity and they have completed it. Unfortunately, we can't necessarily know this for all activities. As such, this should probably only be used if you already know in advance which specific activities you wish to check.</value>
    [DataMember(Name="isCompleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCompleted")]
    public bool? IsCompleted { get; set; }

    /// <summary>
    /// If true, the user should be able to see this activity.
    /// </summary>
    /// <value>If true, the user should be able to see this activity.</value>
    [DataMember(Name="isVisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// The difficulty level of the activity, if applicable.
    /// </summary>
    /// <value>The difficulty level of the activity, if applicable.</value>
    [DataMember(Name="displayLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayLevel")]
    public int? DisplayLevel { get; set; }

    /// <summary>
    /// The recommended light level for the activity, if applicable.
    /// </summary>
    /// <value>The recommended light level for the activity, if applicable.</value>
    [DataMember(Name="recommendedLight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommendedLight")]
    public int? RecommendedLight { get; set; }

    /// <summary>
    /// A DestinyActivityDifficultyTier enum value indicating the difficulty of the activity.
    /// </summary>
    /// <value>A DestinyActivityDifficultyTier enum value indicating the difficulty of the activity.</value>
    [DataMember(Name="difficultyTier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "difficultyTier")]
    public int? DifficultyTier { get; set; }

    /// <summary>
    /// Gets or Sets Challenges
    /// </summary>
    [DataMember(Name="challenges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenges")]
    public List<DestinyChallengesDestinyChallengeStatus> Challenges { get; set; }

    /// <summary>
    /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
    /// </summary>
    /// <value>If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.</value>
    [DataMember(Name="modifierHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifierHashes")]
    public List<int?> ModifierHashes { get; set; }

    /// <summary>
    /// The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \"Challenge Mode\".  We don't have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \"option\" that is enabled/disabled) and the value (whether it's enabled or disabled presently)  On our side, we don't necessarily even know what these are used for (the game designers know, but we don't), and we have no human readable data for them. In order to use them, you will have to do some experimentation.
    /// </summary>
    /// <value>The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \"Challenge Mode\".  We don't have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \"option\" that is enabled/disabled) and the value (whether it's enabled or disabled presently)  On our side, we don't necessarily even know what these are used for (the game designers know, but we don't), and we have no human readable data for them. In order to use them, you will have to do some experimentation.</value>
    [DataMember(Name="booleanActivityOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booleanActivityOptions")]
    public Dictionary<string, bool?> BooleanActivityOptions { get; set; }

    /// <summary>
    /// If returned, this is the index into the DestinyActivityDefinition's \"loadouts\" property, indicating the currently active loadout requirements.
    /// </summary>
    /// <value>If returned, this is the index into the DestinyActivityDefinition's \"loadouts\" property, indicating the currently active loadout requirements.</value>
    [DataMember(Name="loadoutRequirementIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadoutRequirementIndex")]
    public int? LoadoutRequirementIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyActivity {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  IsNew: ").Append(IsNew).Append("\n");
      sb.Append("  CanLead: ").Append(CanLead).Append("\n");
      sb.Append("  CanJoin: ").Append(CanJoin).Append("\n");
      sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
      sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
      sb.Append("  DisplayLevel: ").Append(DisplayLevel).Append("\n");
      sb.Append("  RecommendedLight: ").Append(RecommendedLight).Append("\n");
      sb.Append("  DifficultyTier: ").Append(DifficultyTier).Append("\n");
      sb.Append("  Challenges: ").Append(Challenges).Append("\n");
      sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
      sb.Append("  BooleanActivityOptions: ").Append(BooleanActivityOptions).Append("\n");
      sb.Append("  LoadoutRequirementIndex: ").Append(LoadoutRequirementIndex).Append("\n");
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
