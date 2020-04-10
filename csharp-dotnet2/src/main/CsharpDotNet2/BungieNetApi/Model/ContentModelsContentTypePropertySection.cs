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
  public class ContentModelsContentTypePropertySection {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ReadableName
    /// </summary>
    [DataMember(Name="readableName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readableName")]
    public string ReadableName { get; set; }

    /// <summary>
    /// Gets or Sets Collapsed
    /// </summary>
    [DataMember(Name="collapsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collapsed")]
    public bool? Collapsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsContentTypePropertySection {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ReadableName: ").Append(ReadableName).Append("\n");
      sb.Append("  Collapsed: ").Append(Collapsed).Append("\n");
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
