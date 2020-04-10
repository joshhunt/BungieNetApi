using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Some basic information about whether you can be joined, how many slots are left etc. Note that this can change quickly, so it may not actually be useful. But perhaps it will be in some use cases?
  /// </summary>
  [DataContract]
  public class DestinyComponentsProfilesDestinyProfileTransitoryJoinability {
    /// <summary>
    /// The number of slots still available on this person's fireteam.
    /// </summary>
    /// <value>The number of slots still available on this person's fireteam.</value>
    [DataMember(Name="openSlots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openSlots")]
    public int? OpenSlots { get; set; }

    /// <summary>
    /// Who the person is currently allowing invites from.
    /// </summary>
    /// <value>Who the person is currently allowing invites from.</value>
    [DataMember(Name="privacySetting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privacySetting")]
    public int? PrivacySetting { get; set; }

    /// <summary>
    /// Reasons why a person can't join this person's fireteam.
    /// </summary>
    /// <value>Reasons why a person can't join this person's fireteam.</value>
    [DataMember(Name="closedReasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closedReasons")]
    public int? ClosedReasons { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryJoinability {\n");
      sb.Append("  OpenSlots: ").Append(OpenSlots).Append("\n");
      sb.Append("  PrivacySetting: ").Append(PrivacySetting).Append("\n");
      sb.Append("  ClosedReasons: ").Append(ClosedReasons).Append("\n");
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
