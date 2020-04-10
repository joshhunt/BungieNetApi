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
  public class DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry {
    /// <summary>
    /// Gets or Sets CurrencyItemHash
    /// </summary>
    [DataMember(Name="currencyItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyItemHash")]
    public int? CurrencyItemHash { get; set; }

    /// <summary>
    /// Gets or Sets ScalarValue
    /// </summary>
    [DataMember(Name="scalarValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scalarValue")]
    public int? ScalarValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry {\n");
      sb.Append("  CurrencyItemHash: ").Append(CurrencyItemHash).Append("\n");
      sb.Append("  ScalarValue: ").Append(ScalarValue).Append("\n");
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
