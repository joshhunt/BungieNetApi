using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Instanced items can have sockets, which are slots on the item where plugs can be inserted.  Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition&#39;s \&quot;socket\&quot; block and elsewhere on these objects for more details.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemSocketsComponent {
    /// <summary>
    /// The list of all sockets on the item, and their status information.
    /// </summary>
    /// <value>The list of all sockets on the item, and their status information.</value>
    [DataMember(Name="sockets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sockets")]
    public List<DestinyEntitiesItemsDestinyItemSocketState> Sockets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemSocketsComponent {\n");
      sb.Append("  Sockets: ").Append(Sockets).Append("\n");
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
