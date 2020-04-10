using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This is an experimental set of data that Bungie considers to be \&quot;transitory\&quot; - information that may be useful for API users, but that is coming from a non-authoritative data source about information that could potentially change at a more frequent pace than Bungie.net will receive updates about it.  This information is provided exclusively for convenience should any of it be useful to users: we provide no guarantees to the accuracy or timeliness of data that comes from this source. Know that this data can potentially be out-of-date or even wrong entirely if the user disconnected from the game or suddenly changed their status before we can receive refreshed data.
  /// </summary>
  [DataContract]
  public class DestinyComponentsProfilesDestinyProfileTransitoryComponent {
    /// <summary>
    /// If you have any members currently in your party, this is some (very) bare-bones information about those members.
    /// </summary>
    /// <value>If you have any members currently in your party, this is some (very) bare-bones information about those members.</value>
    [DataMember(Name="partyMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partyMembers")]
    public List<DestinyComponentsProfilesDestinyProfileTransitoryPartyMember> PartyMembers { get; set; }

    /// <summary>
    /// If you are in an activity, this is some transitory info about the activity currently being played.
    /// </summary>
    /// <value>If you are in an activity, this is some transitory info about the activity currently being played.</value>
    [DataMember(Name="currentActivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentActivity")]
    public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity CurrentActivity { get; set; }

    /// <summary>
    /// Information about whether and what might prevent you from joining this person on a fireteam.
    /// </summary>
    /// <value>Information about whether and what might prevent you from joining this person on a fireteam.</value>
    [DataMember(Name="joinability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "joinability")]
    public DestinyComponentsProfilesDestinyProfileTransitoryJoinability Joinability { get; set; }

    /// <summary>
    /// Information about tracked entities.
    /// </summary>
    /// <value>Information about tracked entities.</value>
    [DataMember(Name="tracking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking")]
    public List<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry> Tracking { get; set; }

    /// <summary>
    /// The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.
    /// </summary>
    /// <value>The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.</value>
    [DataMember(Name="lastOrbitedDestinationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastOrbitedDestinationHash")]
    public int? LastOrbitedDestinationHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryComponent {\n");
      sb.Append("  PartyMembers: ").Append(PartyMembers).Append("\n");
      sb.Append("  CurrentActivity: ").Append(CurrentActivity).Append("\n");
      sb.Append("  Joinability: ").Append(Joinability).Append("\n");
      sb.Append("  Tracking: ").Append(Tracking).Append("\n");
      sb.Append("  LastOrbitedDestinationHash: ").Append(LastOrbitedDestinationHash).Append("\n");
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
