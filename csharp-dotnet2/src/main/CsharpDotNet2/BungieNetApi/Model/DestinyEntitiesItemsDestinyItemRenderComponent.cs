using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Many items can be rendered in 3D. When you request this block, you will obtain the custom data needed to render this specific instance of the item.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemRenderComponent {
    /// <summary>
    /// If you should use custom dyes on this item, it will be indicated here.
    /// </summary>
    /// <value>If you should use custom dyes on this item, it will be indicated here.</value>
    [DataMember(Name="useCustomDyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useCustomDyes")]
    public bool? UseCustomDyes { get; set; }

    /// <summary>
    /// A dictionary for rendering gear components, with:  key = Art Arrangement Region Index  value = The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.
    /// </summary>
    /// <value>A dictionary for rendering gear components, with:  key = Art Arrangement Region Index  value = The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.</value>
    [DataMember(Name="artRegions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artRegions")]
    public Dictionary<string, int?> ArtRegions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemRenderComponent {\n");
      sb.Append("  UseCustomDyes: ").Append(UseCustomDyes).Append("\n");
      sb.Append("  ArtRegions: ").Append(ArtRegions).Append("\n");
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
