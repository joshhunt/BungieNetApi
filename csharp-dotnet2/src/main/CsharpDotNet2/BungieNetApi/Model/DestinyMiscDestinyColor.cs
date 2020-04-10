using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a color whose RGBA values are all represented as values between 0 and 255.
  /// </summary>
  [DataContract]
  public class DestinyMiscDestinyColor {
    /// <summary>
    /// Gets or Sets Red
    /// </summary>
    [DataMember(Name="red", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "red")]
    public byte[] Red { get; set; }

    /// <summary>
    /// Gets or Sets Green
    /// </summary>
    [DataMember(Name="green", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "green")]
    public byte[] Green { get; set; }

    /// <summary>
    /// Gets or Sets Blue
    /// </summary>
    [DataMember(Name="blue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blue")]
    public byte[] Blue { get; set; }

    /// <summary>
    /// Gets or Sets Alpha
    /// </summary>
    [DataMember(Name="alpha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alpha")]
    public byte[] Alpha { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMiscDestinyColor {\n");
      sb.Append("  Red: ").Append(Red).Append("\n");
      sb.Append("  Green: ").Append(Green).Append("\n");
      sb.Append("  Blue: ").Append(Blue).Append("\n");
      sb.Append("  Alpha: ").Append(Alpha).Append("\n");
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
