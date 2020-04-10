using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a specific group of vendors that can be rendered in the recommended order.  How do we figure out this order? It&#39;s a long story, and will likely get more complicated over time.
  /// </summary>
  [DataContract]
  public class DestinyComponentsVendorsDestinyVendorGroup {
    /// <summary>
    /// Gets or Sets VendorGroupHash
    /// </summary>
    [DataMember(Name="vendorGroupHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorGroupHash")]
    public int? VendorGroupHash { get; set; }

    /// <summary>
    /// The ordered list of vendors within a particular group.
    /// </summary>
    /// <value>The ordered list of vendors within a particular group.</value>
    [DataMember(Name="vendorHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHashes")]
    public List<int?> VendorHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsVendorsDestinyVendorGroup {\n");
      sb.Append("  VendorGroupHash: ").Append(VendorGroupHash).Append("\n");
      sb.Append("  VendorHashes: ").Append(VendorHashes).Append("\n");
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
