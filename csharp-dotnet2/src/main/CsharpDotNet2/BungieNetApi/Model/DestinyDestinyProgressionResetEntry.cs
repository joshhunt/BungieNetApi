using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a season and the number of resets you had in that season.   We do not necessarily - even for progressions with resets - track it over all seasons. So be careful and check the season numbers being returned.
  /// </summary>
  [DataContract]
  public class DestinyDestinyProgressionResetEntry {
    /// <summary>
    /// Gets or Sets Season
    /// </summary>
    [DataMember(Name="season", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "season")]
    public int? Season { get; set; }

    /// <summary>
    /// Gets or Sets Resets
    /// </summary>
    [DataMember(Name="resets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resets")]
    public int? Resets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyProgressionResetEntry {\n");
      sb.Append("  Season: ").Append(Season).Append("\n");
      sb.Append("  Resets: ").Append(Resets).Append("\n");
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
