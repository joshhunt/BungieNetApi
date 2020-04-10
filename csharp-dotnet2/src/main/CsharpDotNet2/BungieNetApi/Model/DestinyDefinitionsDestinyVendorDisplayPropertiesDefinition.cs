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
  public class DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition {
    /// <summary>
    /// I regret calling this a \"large icon\". It's more like a medium-sized image with a picture of the vendor's mug on it, trying their best to look cool. Not what one would call an icon.
    /// </summary>
    /// <value>I regret calling this a \"large icon\". It's more like a medium-sized image with a picture of the vendor's mug on it, trying their best to look cool. Not what one would call an icon.</value>
    [DataMember(Name="largeIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "largeIcon")]
    public string LargeIcon { get; set; }

    /// <summary>
    /// Gets or Sets Subtitle
    /// </summary>
    [DataMember(Name="subtitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtitle")]
    public string Subtitle { get; set; }

    /// <summary>
    /// If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game's content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.
    /// </summary>
    /// <value>If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game's content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.</value>
    [DataMember(Name="originalIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalIcon")]
    public string OriginalIcon { get; set; }

    /// <summary>
    /// Vendors, in addition to expected display property data, may also show some \"common requirements\" as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.
    /// </summary>
    /// <value>Vendors, in addition to expected display property data, may also show some \"common requirements\" as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.</value>
    [DataMember(Name="requirementsDisplay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirementsDisplay")]
    public List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> RequirementsDisplay { get; set; }

    /// <summary>
    /// This is the icon used in parts of the game UI such as the vendor's waypoint.
    /// </summary>
    /// <value>This is the icon used in parts of the game UI such as the vendor's waypoint.</value>
    [DataMember(Name="smallTransparentIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smallTransparentIcon")]
    public string SmallTransparentIcon { get; set; }

    /// <summary>
    /// This is the icon used in the map overview, when the vendor is located on the map.
    /// </summary>
    /// <value>This is the icon used in the map overview, when the vendor is located on the map.</value>
    [DataMember(Name="mapIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapIcon")]
    public string MapIcon { get; set; }

    /// <summary>
    /// This is apparently the \"Watermark\". I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.
    /// </summary>
    /// <value>This is apparently the \"Watermark\". I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.</value>
    [DataMember(Name="largeTransparentIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "largeTransparentIcon")]
    public string LargeTransparentIcon { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition {\n");
      sb.Append("  LargeIcon: ").Append(LargeIcon).Append("\n");
      sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
      sb.Append("  OriginalIcon: ").Append(OriginalIcon).Append("\n");
      sb.Append("  RequirementsDisplay: ").Append(RequirementsDisplay).Append("\n");
      sb.Append("  SmallTransparentIcon: ").Append(SmallTransparentIcon).Append("\n");
      sb.Append("  MapIcon: ").Append(MapIcon).Append("\n");
      sb.Append("  LargeTransparentIcon: ").Append(LargeTransparentIcon).Append("\n");
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
