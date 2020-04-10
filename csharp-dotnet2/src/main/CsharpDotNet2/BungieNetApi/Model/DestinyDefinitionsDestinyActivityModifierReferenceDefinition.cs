using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A reference to an Activity Modifier from another entity, such as an Activity (for now, just Activities).  This defines some
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityModifierReferenceDefinition {
    /// <summary>
    /// The hash identifier for the DestinyActivityModifierDefinition referenced by this activity.
    /// </summary>
    /// <value>The hash identifier for the DestinyActivityModifierDefinition referenced by this activity.</value>
    [DataMember(Name="activityModifierHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModifierHash")]
    public int? ActivityModifierHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityModifierReferenceDefinition {\n");
      sb.Append("  ActivityModifierHash: ").Append(ActivityModifierHash).Append("\n");
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
