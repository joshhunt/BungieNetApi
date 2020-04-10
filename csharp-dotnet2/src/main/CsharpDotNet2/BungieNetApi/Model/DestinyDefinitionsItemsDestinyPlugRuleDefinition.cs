using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Dictates a rule around whether the plug is enabled or insertable.  In practice, the live Destiny data will refer to these entries by index. You can then look up that index in the appropriate property (enabledRules or insertionRules) to get the localized string for the failure message if it failed.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsItemsDestinyPlugRuleDefinition {
    /// <summary>
    /// The localized string to show if this rule fails.
    /// </summary>
    /// <value>The localized string to show if this rule fails.</value>
    [DataMember(Name="failureMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureMessage")]
    public string FailureMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyPlugRuleDefinition {\n");
      sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
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
