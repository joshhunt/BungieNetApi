using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This appears to be information used when rendering rewards. We don&#39;t currently use it on BNet.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSummaryBlockDefinition {
    /// <summary>
    /// Apparently when rendering an item in a reward, this should be used as a sort priority. We're not doing it presently.
    /// </summary>
    /// <value>Apparently when rendering an item in a reward, this should be used as a sort priority. We're not doing it presently.</value>
    [DataMember(Name="sortPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortPriority")]
    public int? SortPriority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSummaryBlockDefinition {\n");
      sb.Append("  SortPriority: ").Append(SortPriority).Append("\n");
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
