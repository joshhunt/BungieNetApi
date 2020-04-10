using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Information about matchmaking and party size for the activity.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition {
    /// <summary>
    /// If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.
    /// </summary>
    /// <value>If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.</value>
    [DataMember(Name="isMatchmade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isMatchmade")]
    public bool? IsMatchmade { get; set; }

    /// <summary>
    /// The minimum # of people in the fireteam for the activity to launch.
    /// </summary>
    /// <value>The minimum # of people in the fireteam for the activity to launch.</value>
    [DataMember(Name="minParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minParty")]
    public int? MinParty { get; set; }

    /// <summary>
    /// The maximum # of people allowed in a Fireteam.
    /// </summary>
    /// <value>The maximum # of people allowed in a Fireteam.</value>
    [DataMember(Name="maxParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxParty")]
    public int? MaxParty { get; set; }

    /// <summary>
    /// The maximum # of people allowed across all teams in the activity.
    /// </summary>
    /// <value>The maximum # of people allowed across all teams in the activity.</value>
    [DataMember(Name="maxPlayers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxPlayers")]
    public int? MaxPlayers { get; set; }

    /// <summary>
    /// If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.
    /// </summary>
    /// <value>If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.</value>
    [DataMember(Name="requiresGuardianOath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiresGuardianOath")]
    public bool? RequiresGuardianOath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition {\n");
      sb.Append("  IsMatchmade: ").Append(IsMatchmade).Append("\n");
      sb.Append("  MinParty: ").Append(MinParty).Append("\n");
      sb.Append("  MaxParty: ").Append(MaxParty).Append("\n");
      sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
      sb.Append("  RequiresGuardianOath: ").Append(RequiresGuardianOath).Append("\n");
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
