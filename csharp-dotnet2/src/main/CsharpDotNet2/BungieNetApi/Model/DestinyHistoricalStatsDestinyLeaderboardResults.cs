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
  public class DestinyHistoricalStatsDestinyLeaderboardResults : Dictionary<String, Dictionary> {
    /// <summary>
    /// Indicate the membership ID of the account that is the focal point of the provided leaderboards.
    /// </summary>
    /// <value>Indicate the membership ID of the account that is the focal point of the provided leaderboards.</value>
    [DataMember(Name="focusMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "focusMembershipId")]
    public long? FocusMembershipId { get; set; }

    /// <summary>
    /// Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.
    /// </summary>
    /// <value>Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.</value>
    [DataMember(Name="focusCharacterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "focusCharacterId")]
    public long? FocusCharacterId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyLeaderboardResults {\n");
      sb.Append("  FocusMembershipId: ").Append(FocusMembershipId).Append("\n");
      sb.Append("  FocusCharacterId: ").Append(FocusCharacterId).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
