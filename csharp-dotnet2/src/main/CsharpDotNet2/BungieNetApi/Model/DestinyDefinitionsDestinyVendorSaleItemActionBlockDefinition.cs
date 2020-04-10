using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Not terribly useful, some basic cooldown interaction info.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition {
    /// <summary>
    /// Gets or Sets ExecuteSeconds
    /// </summary>
    [DataMember(Name="executeSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executeSeconds")]
    public float? ExecuteSeconds { get; set; }

    /// <summary>
    /// Gets or Sets IsPositive
    /// </summary>
    [DataMember(Name="isPositive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPositive")]
    public bool? IsPositive { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition {\n");
      sb.Append("  ExecuteSeconds: ").Append(ExecuteSeconds).Append("\n");
      sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
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
