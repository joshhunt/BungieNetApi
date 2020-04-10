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
  public class FireteamFireteamResponse {
    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [DataMember(Name="Summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Summary")]
    public FireteamFireteamSummary Summary { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<FireteamFireteamMember> Members { get; set; }

    /// <summary>
    /// Gets or Sets Alternates
    /// </summary>
    [DataMember(Name="Alternates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Alternates")]
    public List<FireteamFireteamMember> Alternates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FireteamFireteamResponse {\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
      sb.Append("  Alternates: ").Append(Alternates).Append("\n");
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
