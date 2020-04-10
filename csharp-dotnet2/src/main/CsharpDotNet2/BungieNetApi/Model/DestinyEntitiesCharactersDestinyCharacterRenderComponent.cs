using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Only really useful if you&#39;re attempting to render the character&#39;s current appearance in 3D, this returns a bare minimum of information, pre-aggregated, that you&#39;ll need to perform that rendering. Note that you need to combine this with other 3D assets and data from our servers.  Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use this data, but be warned: the rabbit hole goes pretty deep.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesCharactersDestinyCharacterRenderComponent {
    /// <summary>
    /// Custom dyes, calculated by iterating over the character's equipped items. Useful for pre-fetching all of the dye data needed from our server.
    /// </summary>
    /// <value>Custom dyes, calculated by iterating over the character's equipped items. Useful for pre-fetching all of the dye data needed from our server.</value>
    [DataMember(Name="customDyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customDyes")]
    public List<DestinyDyeReference> CustomDyes { get; set; }

    /// <summary>
    /// This is actually something that Spasm.js *doesn't* do right now, and that we don't return assets for yet. This is the data about what character customization options you picked. You can combine this with DestinyCharacterCustomizationOptionDefinition to show some cool info, and hopefully someday to actually render a user's face in 3D. We'll see if we ever end up with time for that.
    /// </summary>
    /// <value>This is actually something that Spasm.js *doesn't* do right now, and that we don't return assets for yet. This is the data about what character customization options you picked. You can combine this with DestinyCharacterCustomizationOptionDefinition to show some cool info, and hopefully someday to actually render a user's face in 3D. We'll see if we ever end up with time for that.</value>
    [DataMember(Name="customization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customization")]
    public DestinyCharacterDestinyCharacterCustomization Customization { get; set; }

    /// <summary>
    /// A minimal view of:  - Equipped items  - The rendering-related custom options on those equipped items  Combined, that should be enough to render all of the items on the equipped character.
    /// </summary>
    /// <value>A minimal view of:  - Equipped items  - The rendering-related custom options on those equipped items  Combined, that should be enough to render all of the items on the equipped character.</value>
    [DataMember(Name="peerView", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "peerView")]
    public DestinyCharacterDestinyCharacterPeerView PeerView { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesCharactersDestinyCharacterRenderComponent {\n");
      sb.Append("  CustomDyes: ").Append(CustomDyes).Append("\n");
      sb.Append("  Customization: ").Append(Customization).Append("\n");
      sb.Append("  PeerView: ").Append(PeerView).Append("\n");
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
