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
  public class DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock {
    /// <summary>
    /// The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio = base quality transferred.
    /// </summary>
    /// <value>The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio = base quality transferred.</value>
    [DataMember(Name="baseQualityTransferRatio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseQualityTransferRatio")]
    public float? BaseQualityTransferRatio { get; set; }

    /// <summary>
    /// As long as InfuserQuality > InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser's quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)
    /// </summary>
    /// <value>As long as InfuserQuality > InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser's quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)</value>
    [DataMember(Name="minimumQualityIncrement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumQualityIncrement")]
    public int? MinimumQualityIncrement { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock {\n");
      sb.Append("  BaseQualityTransferRatio: ").Append(BaseQualityTransferRatio).Append("\n");
      sb.Append("  MinimumQualityIncrement: ").Append(MinimumQualityIncrement).Append("\n");
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
