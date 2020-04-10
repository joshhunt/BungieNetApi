using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a particular entry in an ItemSet (AKA a particular Quest Step in a Quest)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSetBlockEntryDefinition {
    /// <summary>
    /// Used for tracking which step a user reached. These values will be populated in the user's internal state, which we expose externally as a more usable DestinyQuestStatus object. If this item has been obtained, this value will be set in trackingUnlockValueHash.
    /// </summary>
    /// <value>Used for tracking which step a user reached. These values will be populated in the user's internal state, which we expose externally as a more usable DestinyQuestStatus object. If this item has been obtained, this value will be set in trackingUnlockValueHash.</value>
    [DataMember(Name="trackingValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackingValue")]
    public int? TrackingValue { get; set; }

    /// <summary>
    /// This is the hash identifier for a DestinyInventoryItemDefinition representing this quest step.
    /// </summary>
    /// <value>This is the hash identifier for a DestinyInventoryItemDefinition representing this quest step.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSetBlockEntryDefinition {\n");
      sb.Append("  TrackingValue: ").Append(TrackingValue).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
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
