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
  public class DestinyAdvancedAwaPermissionRequested {
    /// <summary>
    /// Type of advanced write action.
    /// </summary>
    /// <value>Type of advanced write action.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.
    /// </summary>
    /// <value>Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.</value>
    [DataMember(Name="affectedItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affectedItemId")]
    public long? AffectedItemId { get; set; }

    /// <summary>
    /// Destiny membership type of the account to modify.
    /// </summary>
    /// <value>Destiny membership type of the account to modify.</value>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }

    /// <summary>
    /// Destiny character ID, if applicable, that will be affected by the action.
    /// </summary>
    /// <value>Destiny character ID, if applicable, that will be affected by the action.</value>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyAdvancedAwaPermissionRequested {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AffectedItemId: ").Append(AffectedItemId).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
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
