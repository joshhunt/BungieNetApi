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
  public class DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition {
    /// <summary>
    /// When progressions show your \"experience\" gained, that bar has units (i.e. \"Experience\", \"Bad Dudes Snuffed Out\", whatever). This is the localized string for that unit of measurement.
    /// </summary>
    /// <value>When progressions show your \"experience\" gained, that bar has units (i.e. \"Experience\", \"Bad Dudes Snuffed Out\", whatever). This is the localized string for that unit of measurement.</value>
    [DataMember(Name="displayUnitsName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayUnitsName")]
    public string DisplayUnitsName { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Note that \"icon\" is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition's icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.
    /// </summary>
    /// <value>Note that \"icon\" is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition's icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.</value>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Gets or Sets IconSequences
    /// </summary>
    [DataMember(Name="iconSequences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconSequences")]
    public List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> IconSequences { get; set; }

    /// <summary>
    /// If this item has a high-res icon (at least for now, many things won't), then the path to that icon will be here.
    /// </summary>
    /// <value>If this item has a high-res icon (at least for now, many things won't), then the path to that icon will be here.</value>
    [DataMember(Name="highResIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highResIcon")]
    public string HighResIcon { get; set; }

    /// <summary>
    /// Gets or Sets HasIcon
    /// </summary>
    [DataMember(Name="hasIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasIcon")]
    public bool? HasIcon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition {\n");
      sb.Append("  DisplayUnitsName: ").Append(DisplayUnitsName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  IconSequences: ").Append(IconSequences).Append("\n");
      sb.Append("  HighResIcon: ").Append(HighResIcon).Append("\n");
      sb.Append("  HasIcon: ").Append(HasIcon).Append("\n");
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
