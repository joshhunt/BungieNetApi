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
  public class DestinyDefinitionsDestinyVendorGroupReference {
    /// <summary>
    /// The DestinyVendorGroupDefinition to which this Vendor can belong.
    /// </summary>
    /// <value>The DestinyVendorGroupDefinition to which this Vendor can belong.</value>
    [DataMember(Name="vendorGroupHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorGroupHash")]
    public int? VendorGroupHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorGroupReference {\n");
      sb.Append("  VendorGroupHash: ").Append(VendorGroupHash).Append("\n");
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
