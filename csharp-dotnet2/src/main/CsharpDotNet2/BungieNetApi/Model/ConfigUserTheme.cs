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
  public class ConfigUserTheme {
    /// <summary>
    /// Gets or Sets UserThemeId
    /// </summary>
    [DataMember(Name="userThemeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userThemeId")]
    public int? UserThemeId { get; set; }

    /// <summary>
    /// Gets or Sets UserThemeName
    /// </summary>
    [DataMember(Name="userThemeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userThemeName")]
    public string UserThemeName { get; set; }

    /// <summary>
    /// Gets or Sets UserThemeDescription
    /// </summary>
    [DataMember(Name="userThemeDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userThemeDescription")]
    public string UserThemeDescription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigUserTheme {\n");
      sb.Append("  UserThemeId: ").Append(UserThemeId).Append("\n");
      sb.Append("  UserThemeName: ").Append(UserThemeName).Append("\n");
      sb.Append("  UserThemeDescription: ").Append(UserThemeDescription).Append("\n");
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
