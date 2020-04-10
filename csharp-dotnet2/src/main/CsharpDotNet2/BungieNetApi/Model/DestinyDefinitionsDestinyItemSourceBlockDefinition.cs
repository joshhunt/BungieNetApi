using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Data about an item&#39;s \&quot;sources\&quot;: ways that the item can be obtained.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSourceBlockDefinition {
    /// <summary>
    /// The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).
    /// </summary>
    /// <value>The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).</value>
    [DataMember(Name="sourceHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceHashes")]
    public List<int?> SourceHashes { get; set; }

    /// <summary>
    /// A collection of details about the stats that were computed for the ways we found that the item could be spawned.
    /// </summary>
    /// <value>A collection of details about the stats that were computed for the ways we found that the item could be spawned.</value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sources")]
    public List<DestinyDefinitionsSourcesDestinyItemSourceDefinition> Sources { get; set; }

    /// <summary>
    /// If we found that this item is exclusive to a specific platform, this will be set to the BungieMembershipType enumeration that matches that platform.
    /// </summary>
    /// <value>If we found that this item is exclusive to a specific platform, this will be set to the BungieMembershipType enumeration that matches that platform.</value>
    [DataMember(Name="exclusive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclusive")]
    public int? Exclusive { get; set; }

    /// <summary>
    /// A denormalized reference back to vendors that potentially sell this item.
    /// </summary>
    /// <value>A denormalized reference back to vendors that potentially sell this item.</value>
    [DataMember(Name="vendorSources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorSources")]
    public List<DestinyDefinitionsDestinyItemVendorSourceReference> VendorSources { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSourceBlockDefinition {\n");
      sb.Append("  SourceHashes: ").Append(SourceHashes).Append("\n");
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
      sb.Append("  VendorSources: ").Append(VendorSources).Append("\n");
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
