using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If the Milestone or a component has vendors whose inventories could/should be displayed that are relevant to it, this will return the vendor in question.   It also contains information we need to determine whether that vendor is actually relevant at the moment, given the user&#39;s current state.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition {
    /// <summary>
    /// The hash of the vendor whose wares should be shown as associated with the Milestone.
    /// </summary>
    /// <value>The hash of the vendor whose wares should be shown as associated with the Milestone.</value>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition {\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
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
