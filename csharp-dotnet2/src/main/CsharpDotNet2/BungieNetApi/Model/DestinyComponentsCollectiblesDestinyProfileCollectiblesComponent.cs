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
  public class DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent {
    /// <summary>
    /// The list of collectibles determined by the game as having been \"recently\" acquired.
    /// </summary>
    /// <value>The list of collectibles determined by the game as having been \"recently\" acquired.</value>
    [DataMember(Name="recentCollectibleHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recentCollectibleHashes")]
    public List<int?> RecentCollectibleHashes { get; set; }

    /// <summary>
    /// The list of collectibles determined by the game as having been \"recently\" acquired.  The game client itself actually controls this data, so I personally question whether anyone will get much use out of this: because we can't edit this value through the API. But in case anyone finds it useful, here it is.
    /// </summary>
    /// <value>The list of collectibles determined by the game as having been \"recently\" acquired.  The game client itself actually controls this data, so I personally question whether anyone will get much use out of this: because we can't edit this value through the API. But in case anyone finds it useful, here it is.</value>
    [DataMember(Name="newnessFlaggedCollectibleHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newnessFlaggedCollectibleHashes")]
    public List<int?> NewnessFlaggedCollectibleHashes { get; set; }

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
      sb.Append("class DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent {\n");
      sb.Append("  RecentCollectibleHashes: ").Append(RecentCollectibleHashes).Append("\n");
      sb.Append("  NewnessFlaggedCollectibleHashes: ").Append(NewnessFlaggedCollectibleHashes).Append("\n");
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
