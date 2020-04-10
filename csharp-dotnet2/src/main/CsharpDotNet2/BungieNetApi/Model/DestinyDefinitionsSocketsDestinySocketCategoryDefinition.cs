using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Sockets on an item are organized into Categories visually.  You can find references to the socket category defined on an item&#39;s DestinyInventoryItemDefinition.sockets.socketCategories property.  This has the display information for rendering the categories&#39; header, and a hint for how the UI should handle showing this category.  The shitty thing about this, however, is that the socket categories&#39; UI style can be overridden by the item&#39;s UI style. For instance, the Socket Category used by Emote Sockets says it&#39;s \&quot;consumable,\&quot; but that&#39;s a lie: they&#39;re all reusable, and overridden by the detail UI pages in ways that we can&#39;t easily account for in the API.  As a result, I will try to compile these rules into the individual sockets on items, and provide the best hint possible there through the plugSources property. In the future, I may attempt to use this information in conjunction with the item to provide a more usable UI hint on the socket layer, but for now improving the consistency of plugSources is the best I have time to provide. (See https://github.com/Bungie-net/api/issues/522 for more info)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsSocketsDestinySocketCategoryDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// A string hinting to the game's UI system about how the sockets in this category should be displayed.  BNet doesn't use it: it's up to you to find valid values and make your own special UI if you want to honor this category style.
    /// </summary>
    /// <value>A string hinting to the game's UI system about how the sockets in this category should be displayed.  BNet doesn't use it: it's up to you to find valid values and make your own special UI if you want to honor this category style.</value>
    [DataMember(Name="uiCategoryStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uiCategoryStyle")]
    public int? UiCategoryStyle { get; set; }

    /// <summary>
    /// Same as uiCategoryStyle, but in a more usable enumeration form.
    /// </summary>
    /// <value>Same as uiCategoryStyle, but in a more usable enumeration form.</value>
    [DataMember(Name="categoryStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryStyle")]
    public int? CategoryStyle { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsSocketsDestinySocketCategoryDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  UiCategoryStyle: ").Append(UiCategoryStyle).Append("\n");
      sb.Append("  CategoryStyle: ").Append(CategoryStyle).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
