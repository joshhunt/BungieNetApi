using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This is some bare minimum information about a party member in a Fireteam. Unfortunately, without great computational expense on our side we can only get at the data contained here. I&#39;d like to give you a character ID for example, but we don&#39;t have it. But we do have these three pieces of information. May they help you on your quest to show meaningful data about current Fireteams.  Notably, we don&#39;t and can&#39;t feasibly return info on characters. If you can, try to use just the data below for your UI and purposes. Only hit us with further queries if you absolutely must know the character ID of the currently playing character. Pretty please with sugar on top.
  /// </summary>
  [DataContract]
  public class DestinyComponentsProfilesDestinyProfileTransitoryPartyMember {
    /// <summary>
    /// The Membership ID that matches the party member.
    /// </summary>
    /// <value>The Membership ID that matches the party member.</value>
    [DataMember(Name="membershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipId")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// The identifier for the DestinyInventoryItemDefinition of the player's emblem.
    /// </summary>
    /// <value>The identifier for the DestinyInventoryItemDefinition of the player's emblem.</value>
    [DataMember(Name="emblemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemHash")]
    public int? EmblemHash { get; set; }

    /// <summary>
    /// The player's last known display name.
    /// </summary>
    /// <value>The player's last known display name.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// A Flags Enumeration value indicating the states that the player is in relevant to being on a fireteam.
    /// </summary>
    /// <value>A Flags Enumeration value indicating the states that the player is in relevant to being on a fireteam.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryPartyMember {\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  EmblemHash: ").Append(EmblemHash).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
