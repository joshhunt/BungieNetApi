using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The information for how the vendor purchase should override a given socket with custom plug data.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorItemSocketOverride {
    /// <summary>
    /// If this is populated, the socket will be overridden with a specific plug.  If this isn't populated, it's being overridden by something more complicated that is only known by the Game Server and God, which means we can't tell you in advance what it'll be.
    /// </summary>
    /// <value>If this is populated, the socket will be overridden with a specific plug.  If this isn't populated, it's being overridden by something more complicated that is only known by the Game Server and God, which means we can't tell you in advance what it'll be.</value>
    [DataMember(Name="singleItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singleItemHash")]
    public int? SingleItemHash { get; set; }

    /// <summary>
    /// If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it's set to by default.
    /// </summary>
    /// <value>If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it's set to by default.</value>
    [DataMember(Name="randomizedOptionsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "randomizedOptionsCount")]
    public int? RandomizedOptionsCount { get; set; }

    /// <summary>
    /// This appears to be used to select which socket ultimately gets the override defined here.
    /// </summary>
    /// <value>This appears to be used to select which socket ultimately gets the override defined here.</value>
    [DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketTypeHash")]
    public int? SocketTypeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorItemSocketOverride {\n");
      sb.Append("  SingleItemHash: ").Append(SingleItemHash).Append("\n");
      sb.Append("  RandomizedOptionsCount: ").Append(RandomizedOptionsCount).Append("\n");
      sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
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
