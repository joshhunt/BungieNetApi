using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Destinations and Activities may have default Activity Graphs that should be shown when you bring up the Director and are playing in either.  This contract defines the graph referred to and the gating for when it is relevant.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityGraphListEntryDefinition {
    /// <summary>
    /// The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening the director.
    /// </summary>
    /// <value>The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening the director.</value>
    [DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphHash")]
    public int? ActivityGraphHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityGraphListEntryDefinition {\n");
      sb.Append("  ActivityGraphHash: ").Append(ActivityGraphHash).Append("\n");
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
