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
  public class DestinyDefinitionsRecordsSchemaRecordStateBlock {
    /// <summary>
    /// Gets or Sets FeaturedPriority
    /// </summary>
    [DataMember(Name="featuredPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featuredPriority")]
    public int? FeaturedPriority { get; set; }

    /// <summary>
    /// Gets or Sets ObscuredString
    /// </summary>
    [DataMember(Name="obscuredString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obscuredString")]
    public string ObscuredString { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsRecordsSchemaRecordStateBlock {\n");
      sb.Append("  FeaturedPriority: ").Append(FeaturedPriority).Append("\n");
      sb.Append("  ObscuredString: ").Append(ObscuredString).Append("\n");
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
