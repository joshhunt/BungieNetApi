using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Talent nodes have requirements that must be met before they can be activated.  This describes the material costs, the Level of the Talent Grid&#39;s progression required, and other conditional information that limits whether a talent node can be activated.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyNodeActivationRequirement {
    /// <summary>
    /// The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition's documentation to learn more about Progressions.
    /// </summary>
    /// <value>The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition's documentation to learn more about Progressions.</value>
    [DataMember(Name="gridLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gridLevel")]
    public int? GridLevel { get; set; }

    /// <summary>
    /// The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won't know which one will be chosen until an instance of the item is created.
    /// </summary>
    /// <value>The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won't know which one will be chosen until an instance of the item is created.</value>
    [DataMember(Name="materialRequirementHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "materialRequirementHashes")]
    public List<int?> MaterialRequirementHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyNodeActivationRequirement {\n");
      sb.Append("  GridLevel: ").Append(GridLevel).Append("\n");
      sb.Append("  MaterialRequirementHashes: ").Append(MaterialRequirementHashes).Append("\n");
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
