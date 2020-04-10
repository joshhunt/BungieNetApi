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
  public class DestinyComponentsCollectiblesDestinyCollectiblesComponent {
    /// <summary>
    /// Gets or Sets Collectibles
    /// </summary>
    [DataMember(Name="collectibles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectibles")]
    public Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> Collectibles { get; set; }

    /// <summary>
    /// The hash for the root presentation node definition of Collection categories.
    /// </summary>
    /// <value>The hash for the root presentation node definition of Collection categories.</value>
    [DataMember(Name="collectionCategoriesRootNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectionCategoriesRootNodeHash")]
    public int? CollectionCategoriesRootNodeHash { get; set; }

    /// <summary>
    /// The hash for the root presentation node definition of Collection Badges.
    /// </summary>
    /// <value>The hash for the root presentation node definition of Collection Badges.</value>
    [DataMember(Name="collectionBadgesRootNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectionBadgesRootNodeHash")]
    public int? CollectionBadgesRootNodeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsCollectiblesDestinyCollectiblesComponent {\n");
      sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
      sb.Append("  CollectionCategoriesRootNodeHash: ").Append(CollectionCategoriesRootNodeHash).Append("\n");
      sb.Append("  CollectionBadgesRootNodeHash: ").Append(CollectionBadgesRootNodeHash).Append("\n");
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
