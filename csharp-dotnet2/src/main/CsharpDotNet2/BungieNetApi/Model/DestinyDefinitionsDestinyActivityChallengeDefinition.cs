using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a reference to a Challenge, which for now is just an Objective.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityChallengeDefinition {
    /// <summary>
    /// The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.
    /// </summary>
    /// <value>The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.</value>
    [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHash")]
    public int? ObjectiveHash { get; set; }

    /// <summary>
    /// The rewards as they're represented in the UI. Note that they generally link to \"dummy\" items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don't show the quantity.
    /// </summary>
    /// <value>The rewards as they're represented in the UI. Note that they generally link to \"dummy\" items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don't show the quantity.</value>
    [DataMember(Name="dummyRewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dummyRewards")]
    public List<DestinyDestinyItemQuantity> DummyRewards { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityChallengeDefinition {\n");
      sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
      sb.Append("  DummyRewards: ").Append(DummyRewards).Append("\n");
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
