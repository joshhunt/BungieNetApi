using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a data-driven view for Email settings. Web/Mobile UI can use this data to show new EMail settings consistently without further manual work.
  /// </summary>
  [DataContract]
  public class UserEmailViewDefinition {
    /// <summary>
    /// The identifier for this view.
    /// </summary>
    /// <value>The identifier for this view.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The ordered list of settings to show in this view.
    /// </summary>
    /// <value>The ordered list of settings to show in this view.</value>
    [DataMember(Name="viewSettings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewSettings")]
    public List<UserEmailViewDefinitionSetting> ViewSettings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserEmailViewDefinition {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ViewSettings: ").Append(ViewSettings).Append("\n");
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
