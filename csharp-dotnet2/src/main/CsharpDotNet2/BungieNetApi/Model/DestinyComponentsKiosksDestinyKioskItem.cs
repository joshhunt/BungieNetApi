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
  public class DestinyComponentsKiosksDestinyKioskItem {
    /// <summary>
    /// The index of the item in the related DestinyVendorDefintion's itemList property, representing the sale.
    /// </summary>
    /// <value>The index of the item in the related DestinyVendorDefintion's itemList property, representing the sale.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.
    /// </summary>
    /// <value>If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.</value>
    [DataMember(Name="canAcquire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canAcquire")]
    public bool? CanAcquire { get; set; }

    /// <summary>
    /// Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.
    /// </summary>
    /// <value>Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.</value>
    [DataMember(Name="failureIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureIndexes")]
    public List<int?> FailureIndexes { get; set; }

    /// <summary>
    /// I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for \"flavor\" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
    /// </summary>
    /// <value>I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for \"flavor\" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.</value>
    [DataMember(Name="flavorObjective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavorObjective")]
    public DestinyQuestsDestinyObjectiveProgress FlavorObjective { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsKiosksDestinyKioskItem {\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  CanAcquire: ").Append(CanAcquire).Append("\n");
      sb.Append("  FailureIndexes: ").Append(FailureIndexes).Append("\n");
      sb.Append("  FlavorObjective: ").Append(FlavorObjective).Append("\n");
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
