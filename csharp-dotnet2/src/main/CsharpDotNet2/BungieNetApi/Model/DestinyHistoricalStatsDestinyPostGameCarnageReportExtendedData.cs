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
  public class DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData {
    /// <summary>
    /// List of weapons and their perspective values.
    /// </summary>
    /// <value>List of weapons and their perspective values.</value>
    [DataMember(Name="weapons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weapons")]
    public List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons { get; set; }

    /// <summary>
    /// Collection of stats for the player in this activity.
    /// </summary>
    /// <value>Collection of stats for the player in this activity.</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData {\n");
      sb.Append("  Weapons: ").Append(Weapons).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
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
