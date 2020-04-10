using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Display Categories are different from \&quot;categories\&quot; in that these are specifically for visual grouping and display of categories in Vendor UI. The \&quot;categories\&quot; structure is for validation of the contained items, and can be categorized entirely separately from \&quot;Display Categories\&quot;, there need be and often will be no meaningful relationship between the two.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyDisplayCategoryDefinition {
    /// <summary>
    /// Gets or Sets Index
    /// </summary>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// A string identifier for the display category.
    /// </summary>
    /// <value>A string identifier for the display category.</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets DisplayCategoryHash
    /// </summary>
    [DataMember(Name="displayCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayCategoryHash")]
    public int? DisplayCategoryHash { get; set; }

    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// If true, this category should be displayed in the \"Banner\" section of the vendor's UI.
    /// </summary>
    /// <value>If true, this category should be displayed in the \"Banner\" section of the vendor's UI.</value>
    [DataMember(Name="displayInBanner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayInBanner")]
    public bool? DisplayInBanner { get; set; }

    /// <summary>
    /// If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that's cool.
    /// </summary>
    /// <value>If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that's cool.</value>
    [DataMember(Name="progressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionHash")]
    public int? ProgressionHash { get; set; }

    /// <summary>
    /// If this category sorts items in a nonstandard way, this will be the way we sort.
    /// </summary>
    /// <value>If this category sorts items in a nonstandard way, this will be the way we sort.</value>
    [DataMember(Name="sortOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortOrder")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// An indicator of how the category will be displayed in the UI. It's up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
    /// </summary>
    /// <value>An indicator of how the category will be displayed in the UI. It's up to you to do something cool or interesting in response to this, or just to treat it as a normal category.</value>
    [DataMember(Name="displayStyleHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayStyleHash")]
    public int? DisplayStyleHash { get; set; }

    /// <summary>
    /// An indicator of how the category will be displayed in the UI. It's up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
    /// </summary>
    /// <value>An indicator of how the category will be displayed in the UI. It's up to you to do something cool or interesting in response to this, or just to treat it as a normal category.</value>
    [DataMember(Name="displayStyleIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayStyleIdentifier")]
    public string DisplayStyleIdentifier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyDisplayCategoryDefinition {\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  DisplayCategoryHash: ").Append(DisplayCategoryHash).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  DisplayInBanner: ").Append(DisplayInBanner).Append("\n");
      sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  DisplayStyleHash: ").Append(DisplayStyleHash).Append("\n");
      sb.Append("  DisplayStyleIdentifier: ").Append(DisplayStyleIdentifier).Append("\n");
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
