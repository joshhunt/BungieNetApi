using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a status string that could be conditionally displayed about an activity. Note that externally, you can only see the strings themselves. Internally we combine this information with server state to determine which strings should be shown.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityUnlockStringDefinition {
    /// <summary>
    /// The string to be displayed if the conditions are met.
    /// </summary>
    /// <value>The string to be displayed if the conditions are met.</value>
    [DataMember(Name="displayString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayString")]
    public string DisplayString { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityUnlockStringDefinition {\n");
      sb.Append("  DisplayString: ").Append(DisplayString).Append("\n");
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
