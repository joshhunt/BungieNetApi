using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The base class for any component-returning object that may need to indicate information about the state of the component being returned.
  /// </summary>
  [DataContract]
  public class ComponentsComponentResponse {
    /// <summary>
    /// Gets or Sets Privacy
    /// </summary>
    [DataMember(Name="privacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privacy")]
    public int? Privacy { get; set; }

    /// <summary>
    /// If true, this component is disabled.
    /// </summary>
    /// <value>If true, this component is disabled.</value>
    [DataMember(Name="disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabled")]
    public bool? Disabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComponentsComponentResponse {\n");
      sb.Append("  Privacy: ").Append(Privacy).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
