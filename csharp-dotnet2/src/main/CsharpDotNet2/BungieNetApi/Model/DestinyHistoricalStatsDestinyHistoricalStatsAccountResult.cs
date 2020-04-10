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
  public class DestinyHistoricalStatsDestinyHistoricalStatsAccountResult {
    /// <summary>
    /// Gets or Sets MergedDeletedCharacters
    /// </summary>
    [DataMember(Name="mergedDeletedCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mergedDeletedCharacters")]
    public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; set; }

    /// <summary>
    /// Gets or Sets MergedAllCharacters
    /// </summary>
    [DataMember(Name="mergedAllCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mergedAllCharacters")]
    public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedAllCharacters { get; set; }

    /// <summary>
    /// Gets or Sets Characters
    /// </summary>
    [DataMember(Name="characters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characters")]
    public List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> Characters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsAccountResult {\n");
      sb.Append("  MergedDeletedCharacters: ").Append(MergedDeletedCharacters).Append("\n");
      sb.Append("  MergedAllCharacters: ").Append(MergedAllCharacters).Append("\n");
      sb.Append("  Characters: ").Append(Characters).Append("\n");
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
