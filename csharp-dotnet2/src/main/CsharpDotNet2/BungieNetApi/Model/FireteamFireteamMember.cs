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
  public class FireteamFireteamMember {
    /// <summary>
    /// Gets or Sets DestinyUserInfo
    /// </summary>
    [DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyUserInfo")]
    public FireteamFireteamUserInfoCard DestinyUserInfo { get; set; }

    /// <summary>
    /// Gets or Sets BungieNetUserInfo
    /// </summary>
    [DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bungieNetUserInfo")]
    public UserUserInfoCard BungieNetUserInfo { get; set; }

    /// <summary>
    /// Gets or Sets CharacterId
    /// </summary>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }

    /// <summary>
    /// Gets or Sets DateJoined
    /// </summary>
    [DataMember(Name="dateJoined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateJoined")]
    public DateTime? DateJoined { get; set; }

    /// <summary>
    /// Gets or Sets HasMicrophone
    /// </summary>
    [DataMember(Name="hasMicrophone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasMicrophone")]
    public bool? HasMicrophone { get; set; }

    /// <summary>
    /// Gets or Sets LastPlatformInviteAttemptDate
    /// </summary>
    [DataMember(Name="lastPlatformInviteAttemptDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPlatformInviteAttemptDate")]
    public DateTime? LastPlatformInviteAttemptDate { get; set; }

    /// <summary>
    /// Gets or Sets LastPlatformInviteAttemptResult
    /// </summary>
    [DataMember(Name="lastPlatformInviteAttemptResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPlatformInviteAttemptResult")]
    public int? LastPlatformInviteAttemptResult { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FireteamFireteamMember {\n");
      sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
      sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
      sb.Append("  HasMicrophone: ").Append(HasMicrophone).Append("\n");
      sb.Append("  LastPlatformInviteAttemptDate: ").Append(LastPlatformInviteAttemptDate).Append("\n");
      sb.Append("  LastPlatformInviteAttemptResult: ").Append(LastPlatformInviteAttemptResult).Append("\n");
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
