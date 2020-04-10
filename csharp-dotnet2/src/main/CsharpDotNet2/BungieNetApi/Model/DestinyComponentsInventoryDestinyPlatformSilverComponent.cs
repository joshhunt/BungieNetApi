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
  public class DestinyComponentsInventoryDestinyPlatformSilverComponent {
    /// <summary>
    /// If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.
    /// </summary>
    /// <value>If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.</value>
    [DataMember(Name="platformSilver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformSilver")]
    public Dictionary<string, DestinyEntitiesItemsDestinyItemComponent> PlatformSilver { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsInventoryDestinyPlatformSilverComponent {\n");
      sb.Append("  PlatformSilver: ").Append(PlatformSilver).Append("\n");
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
