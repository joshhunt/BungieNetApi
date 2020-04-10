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
  public class DestinyRequestsDestinyItemTransferRequest {
    /// <summary>
    /// Gets or Sets ItemReferenceHash
    /// </summary>
    [DataMember(Name="itemReferenceHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemReferenceHash")]
    public int? ItemReferenceHash { get; set; }

    /// <summary>
    /// Gets or Sets StackSize
    /// </summary>
    [DataMember(Name="stackSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackSize")]
    public int? StackSize { get; set; }

    /// <summary>
    /// Gets or Sets TransferToVault
    /// </summary>
    [DataMember(Name="transferToVault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferToVault")]
    public bool? TransferToVault { get; set; }

    /// <summary>
    /// Gets or Sets ItemId
    /// </summary>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public long? ItemId { get; set; }

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
      sb.Append("class DestinyRequestsDestinyItemTransferRequest {\n");
      sb.Append("  ItemReferenceHash: ").Append(ItemReferenceHash).Append("\n");
      sb.Append("  StackSize: ").Append(StackSize).Append("\n");
      sb.Append("  TransferToVault: ").Append(TransferToVault).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
