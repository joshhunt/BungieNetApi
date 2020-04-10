using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This contract contains clan-specific group information. It does not include any investment data.
  /// </summary>
  [DataContract]
  public class GroupsV2GroupV2ClanInfo {
    /// <summary>
    /// Gets or Sets ClanCallsign
    /// </summary>
    [DataMember(Name="clanCallsign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanCallsign")]
    public string ClanCallsign { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerData
    /// </summary>
    [DataMember(Name="clanBannerData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerData")]
    public GroupsV2ClanBanner ClanBannerData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupV2ClanInfo {\n");
      sb.Append("  ClanCallsign: ").Append(ClanCallsign).Append("\n");
      sb.Append("  ClanBannerData: ").Append(ClanBannerData).Append("\n");
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
