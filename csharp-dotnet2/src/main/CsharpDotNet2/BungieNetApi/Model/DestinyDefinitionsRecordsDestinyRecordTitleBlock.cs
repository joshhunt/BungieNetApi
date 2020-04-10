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
  public class DestinyDefinitionsRecordsDestinyRecordTitleBlock {
    /// <summary>
    /// Gets or Sets HasTitle
    /// </summary>
    [DataMember(Name="hasTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasTitle")]
    public bool? HasTitle { get; set; }

    /// <summary>
    /// Gets or Sets TitlesByGender
    /// </summary>
    [DataMember(Name="titlesByGender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titlesByGender")]
    public Dictionary<string, string> TitlesByGender { get; set; }

    /// <summary>
    /// For those who prefer to use the definitions.
    /// </summary>
    /// <value>For those who prefer to use the definitions.</value>
    [DataMember(Name="titlesByGenderHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titlesByGenderHash")]
    public Dictionary<string, string> TitlesByGenderHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsRecordsDestinyRecordTitleBlock {\n");
      sb.Append("  HasTitle: ").Append(HasTitle).Append("\n");
      sb.Append("  TitlesByGender: ").Append(TitlesByGender).Append("\n");
      sb.Append("  TitlesByGenderHash: ").Append(TitlesByGenderHash).Append("\n");
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
