using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A minimal view of a character&#39;s equipped items, for the purpose of rendering a summary screen or showing the character in 3D.
  /// </summary>
  [DataContract]
  public class DestinyCharacterDestinyCharacterPeerView {
    /// <summary>
    /// Gets or Sets Equipment
    /// </summary>
    [DataMember(Name="equipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipment")]
    public List<DestinyCharacterDestinyItemPeerView> Equipment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyCharacterDestinyCharacterPeerView {\n");
      sb.Append("  Equipment: ").Append(Equipment).Append("\n");
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
