using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The set of progression-related information that applies at a Profile-wide level for your Destiny experience. This differs from the Jimi Hendrix Experience because there&#39;s less guitars on fire. Yet. #spoileralert?  This will include information such as Checklist info.
  /// </summary>
  [DataContract]
  public class DestinyComponentsProfilesDestinyProfileProgressionComponent {
    /// <summary>
    /// The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.
    /// </summary>
    /// <value>The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.</value>
    [DataMember(Name="checklists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checklists")]
    public Dictionary<string, Dictionary<string, bool?>> Checklists { get; set; }

    /// <summary>
    /// Data related to your progress on the current season's artifact that is the same across characters.
    /// </summary>
    /// <value>Data related to your progress on the current season's artifact that is the same across characters.</value>
    [DataMember(Name="seasonalArtifact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonalArtifact")]
    public DestinyArtifactsDestinyArtifactProfileScoped SeasonalArtifact { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsProfilesDestinyProfileProgressionComponent {\n");
      sb.Append("  Checklists: ").Append(Checklists).Append("\n");
      sb.Append("  SeasonalArtifact: ").Append(SeasonalArtifact).Append("\n");
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
