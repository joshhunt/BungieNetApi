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
  public class DestinyRequestsActionsDestinyInsertPlugsActionRequest {
    /// <summary>
    /// Action token provided by the AwaGetActionToken API call.
    /// </summary>
    /// <value>Action token provided by the AwaGetActionToken API call.</value>
    [DataMember(Name="actionToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionToken")]
    public string ActionToken { get; set; }

    /// <summary>
    /// The instance ID of the item having a plug inserted. Only instanced items can have sockets.
    /// </summary>
    /// <value>The instance ID of the item having a plug inserted. Only instanced items can have sockets.</value>
    [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemInstanceId")]
    public long? ItemInstanceId { get; set; }

    /// <summary>
    /// The plugs being inserted.
    /// </summary>
    /// <value>The plugs being inserted.</value>
    [DataMember(Name="plug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plug")]
    public DestinyRequestsActionsDestinyInsertPlugsRequestEntry Plug { get; set; }

    /// <summary>
    /// Gets or Sets CharacterId
    /// </summary>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }

    /// <summary>
    /// Gets or Sets MembershipType
    /// </summary>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyRequestsActionsDestinyInsertPlugsActionRequest {\n");
      sb.Append("  ActionToken: ").Append(ActionToken).Append("\n");
      sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
      sb.Append("  Plug: ").Append(Plug).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
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
