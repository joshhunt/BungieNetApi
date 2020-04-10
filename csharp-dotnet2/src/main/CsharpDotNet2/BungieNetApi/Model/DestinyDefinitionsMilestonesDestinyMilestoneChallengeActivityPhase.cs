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
  public class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase {
    /// <summary>
    /// The hash identifier of the activity's phase.
    /// </summary>
    /// <value>The hash identifier of the activity's phase.</value>
    [DataMember(Name="phaseHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phaseHash")]
    public int? PhaseHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase {\n");
      sb.Append("  PhaseHash: ").Append(PhaseHash).Append("\n");
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
