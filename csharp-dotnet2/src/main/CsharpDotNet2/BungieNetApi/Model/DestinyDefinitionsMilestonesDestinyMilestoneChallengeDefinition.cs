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
  public class DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition {
    /// <summary>
    /// The challenge related to this milestone.
    /// </summary>
    /// <value>The challenge related to this milestone.</value>
    [DataMember(Name="challengeObjectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challengeObjectiveHash")]
    public int? ChallengeObjectiveHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition {\n");
      sb.Append("  ChallengeObjectiveHash: ").Append(ChallengeObjectiveHash).Append("\n");
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
