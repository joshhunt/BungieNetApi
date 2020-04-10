using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Guided Game information for this activity.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityGuidedBlockDefinition {
    /// <summary>
    /// The maximum amount of people that can be in the waiting lobby.
    /// </summary>
    /// <value>The maximum amount of people that can be in the waiting lobby.</value>
    [DataMember(Name="guidedMaxLobbySize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guidedMaxLobbySize")]
    public int? GuidedMaxLobbySize { get; set; }

    /// <summary>
    /// The minimum amount of people that can be in the waiting lobby.
    /// </summary>
    /// <value>The minimum amount of people that can be in the waiting lobby.</value>
    [DataMember(Name="guidedMinLobbySize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guidedMinLobbySize")]
    public int? GuidedMinLobbySize { get; set; }

    /// <summary>
    /// If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.
    /// </summary>
    /// <value>If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.</value>
    [DataMember(Name="guidedDisbandCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guidedDisbandCount")]
    public int? GuidedDisbandCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityGuidedBlockDefinition {\n");
      sb.Append("  GuidedMaxLobbySize: ").Append(GuidedMaxLobbySize).Append("\n");
      sb.Append("  GuidedMinLobbySize: ").Append(GuidedMinLobbySize).Append("\n");
      sb.Append("  GuidedDisbandCount: ").Append(GuidedDisbandCount).Append("\n");
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
