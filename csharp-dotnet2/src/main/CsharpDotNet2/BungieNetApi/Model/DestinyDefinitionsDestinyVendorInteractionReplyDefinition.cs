using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// When the interaction is replied to, Reward sites will fire and items potentially selected based on whether the given unlock expression is TRUE.  You can potentially choose one from multiple replies when replying to an interaction: this is how you get either/or rewards from vendors.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorInteractionReplyDefinition {
    /// <summary>
    /// The rewards granted upon responding to the vendor.
    /// </summary>
    /// <value>The rewards granted upon responding to the vendor.</value>
    [DataMember(Name="itemRewardsSelection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemRewardsSelection")]
    public int? ItemRewardsSelection { get; set; }

    /// <summary>
    /// The localized text for the reply.
    /// </summary>
    /// <value>The localized text for the reply.</value>
    [DataMember(Name="reply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reply")]
    public string Reply { get; set; }

    /// <summary>
    /// An enum indicating the type of reply being made.
    /// </summary>
    /// <value>An enum indicating the type of reply being made.</value>
    [DataMember(Name="replyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replyType")]
    public int? ReplyType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorInteractionReplyDefinition {\n");
      sb.Append("  ItemRewardsSelection: ").Append(ItemRewardsSelection).Append("\n");
      sb.Append("  Reply: ").Append(Reply).Append("\n");
      sb.Append("  ReplyType: ").Append(ReplyType).Append("\n");
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
