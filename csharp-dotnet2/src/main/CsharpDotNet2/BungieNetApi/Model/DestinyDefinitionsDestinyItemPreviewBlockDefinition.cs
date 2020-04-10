using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Items like Sacks or Boxes can have items that it shows in-game when you view details that represent the items you can obtain if you use or acquire the item.  This defines those categories, and gives some insights into that data&#39;s source.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemPreviewBlockDefinition {
    /// <summary>
    /// A string that the game UI uses as a hint for which detail screen to show for the item. You, too, can leverage this for your own custom screen detail views. Note, however, that these are arbitrarily defined by designers: there's no guarantees of a fixed, known number of these - so fall back to something reasonable if you don't recognize it.
    /// </summary>
    /// <value>A string that the game UI uses as a hint for which detail screen to show for the item. You, too, can leverage this for your own custom screen detail views. Note, however, that these are arbitrarily defined by designers: there's no guarantees of a fixed, known number of these - so fall back to something reasonable if you don't recognize it.</value>
    [DataMember(Name="screenStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screenStyle")]
    public string ScreenStyle { get; set; }

    /// <summary>
    /// If the preview data is derived from a fake \"Preview\" Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.
    /// </summary>
    /// <value>If the preview data is derived from a fake \"Preview\" Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.</value>
    [DataMember(Name="previewVendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewVendorHash")]
    public int? PreviewVendorHash { get; set; }

    /// <summary>
    /// If this item should show you Artifact information when you preview it, this is the hash identifier of the DestinyArtifactDefinition for the artifact whose data should be shown.
    /// </summary>
    /// <value>If this item should show you Artifact information when you preview it, this is the hash identifier of the DestinyArtifactDefinition for the artifact whose data should be shown.</value>
    [DataMember(Name="artifactHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactHash")]
    public int? ArtifactHash { get; set; }

    /// <summary>
    /// If the preview has an associated action (like \"Open\"), this will be the localized string for that action.
    /// </summary>
    /// <value>If the preview has an associated action (like \"Open\"), this will be the localized string for that action.</value>
    [DataMember(Name="previewActionString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewActionString")]
    public string PreviewActionString { get; set; }

    /// <summary>
    /// This is a list of the items being previewed, categorized in the same way as they are in the preview UI.
    /// </summary>
    /// <value>This is a list of the items being previewed, categorized in the same way as they are in the preview UI.</value>
    [DataMember(Name="derivedItemCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "derivedItemCategories")]
    public List<DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition> DerivedItemCategories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemPreviewBlockDefinition {\n");
      sb.Append("  ScreenStyle: ").Append(ScreenStyle).Append("\n");
      sb.Append("  PreviewVendorHash: ").Append(PreviewVendorHash).Append("\n");
      sb.Append("  ArtifactHash: ").Append(ArtifactHash).Append("\n");
      sb.Append("  PreviewActionString: ").Append(PreviewActionString).Append("\n");
      sb.Append("  DerivedItemCategories: ").Append(DerivedItemCategories).Append("\n");
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
