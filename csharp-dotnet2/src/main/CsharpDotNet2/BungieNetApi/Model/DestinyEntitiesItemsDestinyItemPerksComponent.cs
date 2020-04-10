using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Instanced items can have perks: benefits that the item bestows.  These are related to DestinySandboxPerkDefinition, and sometimes - but not always - have human readable info. When they do, they are the icons and text that you see in an item&#39;s tooltip.  Talent Grids, Sockets, and the item itself can apply Perks, which are then summarized here for your convenience.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemPerksComponent {
    /// <summary>
    /// The list of perks to display in an item tooltip - and whether or not they have been activated.
    /// </summary>
    /// <value>The list of perks to display in an item tooltip - and whether or not they have been activated.</value>
    [DataMember(Name="perks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perks")]
    public List<DestinyPerksDestinyPerkReference> Perks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemPerksComponent {\n");
      sb.Append("  Perks: ").Append(Perks).Append("\n");
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
