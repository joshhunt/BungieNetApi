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
  public class DestinyMilestonesDestinyPublicMilestoneChallengeActivity {
    /// <summary>
    /// Gets or Sets ActivityHash
    /// </summary>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// Gets or Sets ChallengeObjectiveHashes
    /// </summary>
    [DataMember(Name="challengeObjectiveHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challengeObjectiveHashes")]
    public List<int?> ChallengeObjectiveHashes { get; set; }

    /// <summary>
    /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
    /// </summary>
    /// <value>If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.</value>
    [DataMember(Name="modifierHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifierHashes")]
    public List<int?> ModifierHashes { get; set; }

    /// <summary>
    /// If returned, this is the index into the DestinyActivityDefinition's \"loadouts\" property, indicating the currently active loadout requirements.
    /// </summary>
    /// <value>If returned, this is the index into the DestinyActivityDefinition's \"loadouts\" property, indicating the currently active loadout requirements.</value>
    [DataMember(Name="loadoutRequirementIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadoutRequirementIndex")]
    public int? LoadoutRequirementIndex { get; set; }

    /// <summary>
    /// The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.
    /// </summary>
    /// <value>The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.</value>
    [DataMember(Name="phaseHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phaseHashes")]
    public List<int?> PhaseHashes { get; set; }

    /// <summary>
    /// The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \"Challenge Mode\".  We have no human readable information for this data, so it's up to you if you want to associate it with such info to show it.
    /// </summary>
    /// <value>The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \"Challenge Mode\".  We have no human readable information for this data, so it's up to you if you want to associate it with such info to show it.</value>
    [DataMember(Name="booleanActivityOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booleanActivityOptions")]
    public Dictionary<string, bool?> BooleanActivityOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyPublicMilestoneChallengeActivity {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  ChallengeObjectiveHashes: ").Append(ChallengeObjectiveHashes).Append("\n");
      sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
      sb.Append("  LoadoutRequirementIndex: ").Append(LoadoutRequirementIndex).Append("\n");
      sb.Append("  PhaseHashes: ").Append(PhaseHashes).Append("\n");
      sb.Append("  BooleanActivityOptions: ").Append(BooleanActivityOptions).Append("\n");
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
