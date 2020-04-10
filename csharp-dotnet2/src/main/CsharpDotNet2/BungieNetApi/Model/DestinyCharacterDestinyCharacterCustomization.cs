using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Raw data about the customization options chosen for a character&#39;s face and appearance.  You can look up the relevant class/race/gender combo in DestinyCharacterCustomizationOptionDefinition for the character, and then look up these values within the CustomizationOptions found to pull some data about their choices. Warning: not all of that data is meaningful. Some data has useful icons. Others have nothing, and are only meant for 3D rendering purposes (which we sadly do not expose yet)
  /// </summary>
  [DataContract]
  public class DestinyCharacterDestinyCharacterCustomization {
    /// <summary>
    /// Gets or Sets Personality
    /// </summary>
    [DataMember(Name="personality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personality")]
    public int? Personality { get; set; }

    /// <summary>
    /// Gets or Sets Face
    /// </summary>
    [DataMember(Name="face", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "face")]
    public int? Face { get; set; }

    /// <summary>
    /// Gets or Sets SkinColor
    /// </summary>
    [DataMember(Name="skinColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skinColor")]
    public int? SkinColor { get; set; }

    /// <summary>
    /// Gets or Sets LipColor
    /// </summary>
    [DataMember(Name="lipColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lipColor")]
    public int? LipColor { get; set; }

    /// <summary>
    /// Gets or Sets EyeColor
    /// </summary>
    [DataMember(Name="eyeColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eyeColor")]
    public int? EyeColor { get; set; }

    /// <summary>
    /// Gets or Sets HairColors
    /// </summary>
    [DataMember(Name="hairColors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hairColors")]
    public List<int?> HairColors { get; set; }

    /// <summary>
    /// Gets or Sets FeatureColors
    /// </summary>
    [DataMember(Name="featureColors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureColors")]
    public List<int?> FeatureColors { get; set; }

    /// <summary>
    /// Gets or Sets DecalColor
    /// </summary>
    [DataMember(Name="decalColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decalColor")]
    public int? DecalColor { get; set; }

    /// <summary>
    /// Gets or Sets WearHelmet
    /// </summary>
    [DataMember(Name="wearHelmet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wearHelmet")]
    public bool? WearHelmet { get; set; }

    /// <summary>
    /// Gets or Sets HairIndex
    /// </summary>
    [DataMember(Name="hairIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hairIndex")]
    public int? HairIndex { get; set; }

    /// <summary>
    /// Gets or Sets FeatureIndex
    /// </summary>
    [DataMember(Name="featureIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureIndex")]
    public int? FeatureIndex { get; set; }

    /// <summary>
    /// Gets or Sets DecalIndex
    /// </summary>
    [DataMember(Name="decalIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decalIndex")]
    public int? DecalIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyCharacterDestinyCharacterCustomization {\n");
      sb.Append("  Personality: ").Append(Personality).Append("\n");
      sb.Append("  Face: ").Append(Face).Append("\n");
      sb.Append("  SkinColor: ").Append(SkinColor).Append("\n");
      sb.Append("  LipColor: ").Append(LipColor).Append("\n");
      sb.Append("  EyeColor: ").Append(EyeColor).Append("\n");
      sb.Append("  HairColors: ").Append(HairColors).Append("\n");
      sb.Append("  FeatureColors: ").Append(FeatureColors).Append("\n");
      sb.Append("  DecalColor: ").Append(DecalColor).Append("\n");
      sb.Append("  WearHelmet: ").Append(WearHelmet).Append("\n");
      sb.Append("  HairIndex: ").Append(HairIndex).Append("\n");
      sb.Append("  FeatureIndex: ").Append(FeatureIndex).Append("\n");
      sb.Append("  DecalIndex: ").Append(DecalIndex).Append("\n");
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
