using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a plug \&quot;Category\&quot; that is allowed to be plugged into a socket of this type.  This should be compared against a given plug item&#39;s DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item&#39;s category.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition {
    /// <summary>
    /// The hash identifier of the Plug Category to compare against the plug item's plug.plugCategoryHash.  Note that this does NOT relate to any Definition in itself, it is only used for comparison purposes.
    /// </summary>
    /// <value>The hash identifier of the Plug Category to compare against the plug item's plug.plugCategoryHash.  Note that this does NOT relate to any Definition in itself, it is only used for comparison purposes.</value>
    [DataMember(Name="categoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryHash")]
    public int? CategoryHash { get; set; }

    /// <summary>
    /// The string identifier for the category, which is here mostly for debug purposes.
    /// </summary>
    /// <value>The string identifier for the category, which is here mostly for debug purposes.</value>
    [DataMember(Name="categoryIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryIdentifier")]
    public string CategoryIdentifier { get; set; }

    /// <summary>
    /// The list of all plug items (DestinyInventoryItemDefinition) that the socket may randomly be populated with when reinitialized.  Which ones you should actually show are determined by the plug being inserted into the socket, and the socket’s type.  When you inspect the plug that could go into a Masterwork Socket, look up the socket type of the socket being inspected and find the DestinySocketTypeDefinition.  Then, look at the Plugs that can fit in that socket. Find the Whitelist in the DestinySocketTypeDefinition that matches the plug item’s categoryhash.  That whitelist entry will potentially have a new “reinitializationPossiblePlugHashes” property.If it does, that means we know what it will roll if you try to insert this plug into this socket.
    /// </summary>
    /// <value>The list of all plug items (DestinyInventoryItemDefinition) that the socket may randomly be populated with when reinitialized.  Which ones you should actually show are determined by the plug being inserted into the socket, and the socket’s type.  When you inspect the plug that could go into a Masterwork Socket, look up the socket type of the socket being inspected and find the DestinySocketTypeDefinition.  Then, look at the Plugs that can fit in that socket. Find the Whitelist in the DestinySocketTypeDefinition that matches the plug item’s categoryhash.  That whitelist entry will potentially have a new “reinitializationPossiblePlugHashes” property.If it does, that means we know what it will roll if you try to insert this plug into this socket.</value>
    [DataMember(Name="reinitializationPossiblePlugHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reinitializationPossiblePlugHashes")]
    public List<int?> ReinitializationPossiblePlugHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition {\n");
      sb.Append("  CategoryHash: ").Append(CategoryHash).Append("\n");
      sb.Append("  CategoryIdentifier: ").Append(CategoryIdentifier).Append("\n");
      sb.Append("  ReinitializationPossiblePlugHashes: ").Append(ReinitializationPossiblePlugHashes).Append("\n");
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
