using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents the status and other related information for a challenge that is - or was - available to a player.   A challenge is a bonus objective, generally tacked onto Quests or Activities, that provide additional variations on play.
  /// </summary>
  [DataContract]
  public class DestinyChallengesDestinyChallengeStatus {
    /// <summary>
    /// The progress - including completion status - of the active challenge.
    /// </summary>
    /// <value>The progress - including completion status - of the active challenge.</value>
    [DataMember(Name="objective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objective")]
    public DestinyQuestsDestinyObjectiveProgress Objective { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyChallengesDestinyChallengeStatus {\n");
      sb.Append("  Objective: ").Append(Objective).Append("\n");
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
