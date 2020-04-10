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
  public class DestinyMilestonesDestinyMilestoneChallengeActivity {
    /// <summary>
    /// Gets or Sets ActivityHash
    /// </summary>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

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
    /// If the Activity has discrete \"phases\" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
    /// </summary>
    /// <value>If the Activity has discrete \"phases\" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.</value>
    [DataMember(Name="phases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phases")]
    public List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneChallengeActivity {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  Challenges: ").Append(Challenges).Append("\n");
      sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
      sb.Append("  BooleanActivityOptions: ").Append(BooleanActivityOptions).Append("\n");
      sb.Append("  LoadoutRequirementIndex: ").Append(LoadoutRequirementIndex).Append("\n");
      sb.Append("  Phases: ").Append(Phases).Append("\n");
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
