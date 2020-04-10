using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Compare this sackType to the sack identifier in the DestinyInventoryItemDefinition.vendorSackType property of items. If they match, show this sack with this interaction.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition {
    /// <summary>
    /// Gets or Sets SackType
    /// </summary>
    [DataMember(Name="sackType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sackType")]
    public int? SackType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition {\n");
      sb.Append("  SackType: ").Append(SackType).Append("\n");
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
