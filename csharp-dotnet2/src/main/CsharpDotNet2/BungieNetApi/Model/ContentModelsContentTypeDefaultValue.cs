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
  public class ContentModelsContentTypeDefaultValue {
    /// <summary>
    /// Gets or Sets WhenClause
    /// </summary>
    [DataMember(Name="whenClause", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whenClause")]
    public string WhenClause { get; set; }

    /// <summary>
    /// Gets or Sets WhenValue
    /// </summary>
    [DataMember(Name="whenValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whenValue")]
    public string WhenValue { get; set; }

    /// <summary>
    /// Gets or Sets DefaultValue
    /// </summary>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsContentTypeDefaultValue {\n");
      sb.Append("  WhenClause: ").Append(WhenClause).Append("\n");
      sb.Append("  WhenValue: ").Append(WhenValue).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
