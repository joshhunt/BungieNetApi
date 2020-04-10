using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Data related to what happens while a plug is being inserted, mostly for UI purposes.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition {
    /// <summary>
    /// How long it takes for the Plugging of the item to be completed once it is initiated, if you care.
    /// </summary>
    /// <value>How long it takes for the Plugging of the item to be completed once it is initiated, if you care.</value>
    [DataMember(Name="actionExecuteSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionExecuteSeconds")]
    public int? ActionExecuteSeconds { get; set; }

    /// <summary>
    /// The type of action being performed when you act on this Socket Type. The most common value is \"insert plug\", but there are others as well (for instance, a \"Masterwork\" socket may allow for Re-initialization, and an Infusion socket allows for items to be consumed to upgrade the item)
    /// </summary>
    /// <value>The type of action being performed when you act on this Socket Type. The most common value is \"insert plug\", but there are others as well (for instance, a \"Masterwork\" socket may allow for Re-initialization, and an Infusion socket allows for items to be consumed to upgrade the item)</value>
    [DataMember(Name="actionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionType")]
    public int? ActionType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition {\n");
      sb.Append("  ActionExecuteSeconds: ").Append(ActionExecuteSeconds).Append("\n");
      sb.Append("  ActionType: ").Append(ActionType).Append("\n");
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
