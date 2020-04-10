using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Indicates the status of an \&quot;Unlock Flag\&quot; on a Character or Profile.  These are individual bits of state that can be either set or not set, and sometimes provide interesting human-readable information in their related DestinyUnlockDefinition.
  /// </summary>
  [DataContract]
  public class DestinyDestinyUnlockStatus {
    /// <summary>
    /// The hash identifier for the Unlock Flag. Use to lookup DestinyUnlockDefinition for static data. Not all unlocks have human readable data - in fact, most don't. But when they do, it can be very useful to show. Even if they don't have human readable data, you might be able to infer the meaning of an unlock flag with a bit of experimentation...
    /// </summary>
    /// <value>The hash identifier for the Unlock Flag. Use to lookup DestinyUnlockDefinition for static data. Not all unlocks have human readable data - in fact, most don't. But when they do, it can be very useful to show. Even if they don't have human readable data, you might be able to infer the meaning of an unlock flag with a bit of experimentation...</value>
    [DataMember(Name="unlockHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unlockHash")]
    public int? UnlockHash { get; set; }

    /// <summary>
    /// Whether the unlock flag is set.
    /// </summary>
    /// <value>Whether the unlock flag is set.</value>
    [DataMember(Name="isSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSet")]
    public bool? IsSet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyUnlockStatus {\n");
      sb.Append("  UnlockHash: ").Append(UnlockHash).Append("\n");
      sb.Append("  IsSet: ").Append(IsSet).Append("\n");
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
