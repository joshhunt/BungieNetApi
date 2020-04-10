using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Inventory Items can reward progression when actions are performed on them. A common example of this in Destiny 1 was Bounties, which would reward Experience on your Character and the like when you completed the bounty.  Note that this maps to a DestinyProgressionMappingDefinition, and *not* a DestinyProgressionDefinition directly. This is apparently so that multiple progressions can be granted progression points/experience at the same time.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyProgressionRewardDefinition {
    /// <summary>
    /// The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.
    /// </summary>
    /// <value>The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.</value>
    [DataMember(Name="progressionMappingHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionMappingHash")]
    public int? ProgressionMappingHash { get; set; }

    /// <summary>
    /// The amount of experience to give to each of the mapped progressions.
    /// </summary>
    /// <value>The amount of experience to give to each of the mapped progressions.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// If true, the game's internal mechanisms to throttle progression should be applied.
    /// </summary>
    /// <value>If true, the game's internal mechanisms to throttle progression should be applied.</value>
    [DataMember(Name="applyThrottles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyThrottles")]
    public bool? ApplyThrottles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyProgressionRewardDefinition {\n");
      sb.Append("  ProgressionMappingHash: ").Append(ProgressionMappingHash).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ApplyThrottles: ").Append(ApplyThrottles).Append("\n");
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
