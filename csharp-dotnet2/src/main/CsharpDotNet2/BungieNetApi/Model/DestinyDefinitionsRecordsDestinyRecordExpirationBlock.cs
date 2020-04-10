using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If this record has an expiration after which it cannot be earned, this is some information about that expiration.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsRecordsDestinyRecordExpirationBlock {
    /// <summary>
    /// Gets or Sets HasExpiration
    /// </summary>
    [DataMember(Name="hasExpiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasExpiration")]
    public bool? HasExpiration { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Icon
    /// </summary>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsRecordsDestinyRecordExpirationBlock {\n");
      sb.Append("  HasExpiration: ").Append(HasExpiration).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
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
