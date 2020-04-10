using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// An enumeration that indicates the high-level \&quot;type\&quot; of the item, attempting to iron out the context specific differences for specific instances of an entity. For instance, though a weapon may be of various weapon \&quot;Types\&quot;, in DestinyItemType they are all classified as \&quot;Weapon\&quot;. This allows for better filtering on a higher level of abstraction for the concept of types.   This enum is provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.   NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.   I keep updating these because they&#39;re so damn convenient. I guess I shouldn&#39;t fight it.
  /// </summary>
  [DataContract]
  public class DestinyDestinyItemType {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyItemType {\n");
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
