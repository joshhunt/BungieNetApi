using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If a Destiny Profile can&#39;t be returned, but we&#39;re pretty certain it&#39;s a valid Destiny account, this will contain as much info as we can get about the profile for your use.  Assume that the most you&#39;ll get is the Error Code, the Membership Type and the Membership ID.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyErrorProfile {
    /// <summary>
    /// The error that we encountered. You should be able to look up localized text to show to the user for these failures.
    /// </summary>
    /// <value>The error that we encountered. You should be able to look up localized text to show to the user for these failures.</value>
    [DataMember(Name="errorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCode")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// Basic info about the account that failed. Don't expect anything other than membership ID, Membership Type, and displayName to be populated.
    /// </summary>
    /// <value>Basic info about the account that failed. Don't expect anything other than membership ID, Membership Type, and displayName to be populated.</value>
    [DataMember(Name="infoCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infoCard")]
    public UserUserInfoCard InfoCard { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyErrorProfile {\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  InfoCard: ").Append(InfoCard).Append("\n");
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
