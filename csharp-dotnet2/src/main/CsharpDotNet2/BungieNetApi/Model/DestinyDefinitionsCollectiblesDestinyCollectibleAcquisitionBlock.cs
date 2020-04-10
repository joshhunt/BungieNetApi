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
  public class DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock {
    /// <summary>
    /// Gets or Sets AcquireMaterialRequirementHash
    /// </summary>
    [DataMember(Name="acquireMaterialRequirementHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquireMaterialRequirementHash")]
    public int? AcquireMaterialRequirementHash { get; set; }

    /// <summary>
    /// Gets or Sets AcquireTimestampUnlockValueHash
    /// </summary>
    [DataMember(Name="acquireTimestampUnlockValueHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquireTimestampUnlockValueHash")]
    public int? AcquireTimestampUnlockValueHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock {\n");
      sb.Append("  AcquireMaterialRequirementHash: ").Append(AcquireMaterialRequirementHash).Append("\n");
      sb.Append("  AcquireTimestampUnlockValueHash: ").Append(AcquireTimestampUnlockValueHash).Append("\n");
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
