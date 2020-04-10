using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// I know what you seek. You seek linked accounts. Found them, you have.  This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyLinkedProfilesResponse {
    /// <summary>
    /// Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)
    /// </summary>
    /// <value>Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)</value>
    [DataMember(Name="profiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profiles")]
    public List<DestinyResponsesDestinyProfileUserInfoCard> Profiles { get; set; }

    /// <summary>
    /// If the requested membership had a linked Bungie.Net membership ID, this is the basic information about that BNet account.  I know, Tetron; I know this is mixing UserServices concerns with DestinyServices concerns. But it's so damn convenient! https://www.youtube.com/watch?v=X5R-bB-gKVI
    /// </summary>
    /// <value>If the requested membership had a linked Bungie.Net membership ID, this is the basic information about that BNet account.  I know, Tetron; I know this is mixing UserServices concerns with DestinyServices concerns. But it's so damn convenient! https://www.youtube.com/watch?v=X5R-bB-gKVI</value>
    [DataMember(Name="bnetMembership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bnetMembership")]
    public UserUserInfoCard BnetMembership { get; set; }

    /// <summary>
    /// This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.
    /// </summary>
    /// <value>This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.</value>
    [DataMember(Name="profilesWithErrors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profilesWithErrors")]
    public List<DestinyResponsesDestinyErrorProfile> ProfilesWithErrors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyLinkedProfilesResponse {\n");
      sb.Append("  Profiles: ").Append(Profiles).Append("\n");
      sb.Append("  BnetMembership: ").Append(BnetMembership).Append("\n");
      sb.Append("  ProfilesWithErrors: ").Append(ProfilesWithErrors).Append("\n");
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
