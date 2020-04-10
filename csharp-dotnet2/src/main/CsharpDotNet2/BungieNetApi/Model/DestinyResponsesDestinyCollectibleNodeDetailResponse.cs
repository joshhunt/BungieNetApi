using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Returns the detailed information about a Collectible Presentation Node and any Collectibles that are direct descendants.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyCollectibleNodeDetailResponse {
    /// <summary>
    /// COMPONENT TYPE: Collectibles
    /// </summary>
    /// <value>COMPONENT TYPE: Collectibles</value>
    [DataMember(Name="collectibles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectibles")]
    public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }

    /// <summary>
    /// Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn't have to have a special override to do the collectible -> item lookup once you delve into an item's details, and it also meant that you didn't have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    /// </summary>
    /// <value>Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn't have to have a special override to do the collectible -> item lookup once you delve into an item's details, and it also meant that you didn't have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
    [DataMember(Name="collectibleItemComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectibleItemComponents")]
    public DestinyItemComponentSetOfuint32 CollectibleItemComponents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyCollectibleNodeDetailResponse {\n");
      sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
      sb.Append("  CollectibleItemComponents: ").Append(CollectibleItemComponents).Append("\n");
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
