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
  public class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry {
    /// <summary>
    /// Gets or Sets ActivityGraphHash
    /// </summary>
    [DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphHash")]
    public int? ActivityGraphHash { get; set; }

    /// <summary>
    /// Gets or Sets ActivityGraphNodeHash
    /// </summary>
    [DataMember(Name="activityGraphNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphNodeHash")]
    public int? ActivityGraphNodeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry {\n");
      sb.Append("  ActivityGraphHash: ").Append(ActivityGraphHash).Append("\n");
      sb.Append("  ActivityGraphNodeHash: ").Append(ActivityGraphNodeHash).Append("\n");
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
