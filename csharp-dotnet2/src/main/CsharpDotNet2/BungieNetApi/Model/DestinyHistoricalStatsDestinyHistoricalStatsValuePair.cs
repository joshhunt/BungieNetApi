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
  public class DestinyHistoricalStatsDestinyHistoricalStatsValuePair {
    /// <summary>
    /// Raw value of the statistic
    /// </summary>
    /// <value>Raw value of the statistic</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public double? Value { get; set; }

    /// <summary>
    /// Localized formated version of the value.
    /// </summary>
    /// <value>Localized formated version of the value.</value>
    [DataMember(Name="displayValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayValue")]
    public string DisplayValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsValuePair {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
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
