using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// DestinyManifest is the external-facing contract for just the properties needed by those calling the Destiny Platform.
  /// </summary>
  [DataContract]
  public class DestinyConfigDestinyManifest {
    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets MobileAssetContentPath
    /// </summary>
    [DataMember(Name="mobileAssetContentPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileAssetContentPath")]
    public string MobileAssetContentPath { get; set; }

    /// <summary>
    /// Gets or Sets MobileGearAssetDataBases
    /// </summary>
    [DataMember(Name="mobileGearAssetDataBases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileGearAssetDataBases")]
    public List<DestinyConfigGearAssetDataBaseDefinition> MobileGearAssetDataBases { get; set; }

    /// <summary>
    /// Gets or Sets MobileWorldContentPaths
    /// </summary>
    [DataMember(Name="mobileWorldContentPaths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileWorldContentPaths")]
    public Dictionary<string, string> MobileWorldContentPaths { get; set; }

    /// <summary>
    /// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)
    /// </summary>
    /// <value>This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)</value>
    [DataMember(Name="jsonWorldContentPaths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jsonWorldContentPaths")]
    public Dictionary<string, string> JsonWorldContentPaths { get; set; }

    /// <summary>
    /// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.
    /// </summary>
    /// <value>This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.</value>
    [DataMember(Name="jsonWorldComponentContentPaths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jsonWorldComponentContentPaths")]
    public Dictionary<string, Dictionary<string, string>> JsonWorldComponentContentPaths { get; set; }

    /// <summary>
    /// Gets or Sets MobileClanBannerDatabasePath
    /// </summary>
    [DataMember(Name="mobileClanBannerDatabasePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileClanBannerDatabasePath")]
    public string MobileClanBannerDatabasePath { get; set; }

    /// <summary>
    /// Gets or Sets MobileGearCDN
    /// </summary>
    [DataMember(Name="mobileGearCDN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileGearCDN")]
    public Dictionary<string, string> MobileGearCDN { get; set; }

    /// <summary>
    /// Information about the \"Image Pyramid\" for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the \"original/full size\" Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable)
    /// </summary>
    /// <value>Information about the \"Image Pyramid\" for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the \"original/full size\" Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable)</value>
    [DataMember(Name="iconImagePyramidInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconImagePyramidInfo")]
    public List<DestinyConfigImagePyramidEntry> IconImagePyramidInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyConfigDestinyManifest {\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  MobileAssetContentPath: ").Append(MobileAssetContentPath).Append("\n");
      sb.Append("  MobileGearAssetDataBases: ").Append(MobileGearAssetDataBases).Append("\n");
      sb.Append("  MobileWorldContentPaths: ").Append(MobileWorldContentPaths).Append("\n");
      sb.Append("  JsonWorldContentPaths: ").Append(JsonWorldContentPaths).Append("\n");
      sb.Append("  JsonWorldComponentContentPaths: ").Append(JsonWorldComponentContentPaths).Append("\n");
      sb.Append("  MobileClanBannerDatabasePath: ").Append(MobileClanBannerDatabasePath).Append("\n");
      sb.Append("  MobileGearCDN: ").Append(MobileGearCDN).Append("\n");
      sb.Append("  IconImagePyramidInfo: ").Append(IconImagePyramidInfo).Append("\n");
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
