using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// An item&#39;s \&quot;Quality\&quot; determines its calculated stats. The Level at which the item spawns is combined with its \&quot;qualityLevel\&quot; along with some additional calculations to determine the value of those stats.  In Destiny 2, most items don&#39;t have default item levels and quality, making this property less useful: these apparently are almost always determined by the complex mechanisms of the Reward system rather than statically. They are still provided here in case they are still useful for people. This also contains some information about Infusion.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemQualityBlockDefinition {
    /// <summary>
    /// The \"base\" defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn't even populated at all. When it's not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.
    /// </summary>
    /// <value>The \"base\" defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn't even populated at all. When it's not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.</value>
    [DataMember(Name="itemLevels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemLevels")]
    public List<int?> ItemLevels { get; set; }

    /// <summary>
    /// qualityLevel is used in combination with the item's level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.
    /// </summary>
    /// <value>qualityLevel is used in combination with the item's level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.</value>
    [DataMember(Name="qualityLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualityLevel")]
    public int? QualityLevel { get; set; }

    /// <summary>
    /// The string identifier for this item's \"infusability\", if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
    /// </summary>
    /// <value>The string identifier for this item's \"infusability\", if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.</value>
    [DataMember(Name="infusionCategoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infusionCategoryName")]
    public string InfusionCategoryName { get; set; }

    /// <summary>
    /// The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
    /// </summary>
    /// <value>The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.</value>
    [DataMember(Name="infusionCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infusionCategoryHash")]
    public int? InfusionCategoryHash { get; set; }

    /// <summary>
    /// If any one of these hashes matches any value in another item's infusionCategoryHashes, the two can infuse with each other.
    /// </summary>
    /// <value>If any one of these hashes matches any value in another item's infusionCategoryHashes, the two can infuse with each other.</value>
    [DataMember(Name="infusionCategoryHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infusionCategoryHashes")]
    public List<int?> InfusionCategoryHashes { get; set; }

    /// <summary>
    /// An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
    /// </summary>
    /// <value>An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.</value>
    [DataMember(Name="progressionLevelRequirementHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionLevelRequirementHash")]
    public int? ProgressionLevelRequirementHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemQualityBlockDefinition {\n");
      sb.Append("  ItemLevels: ").Append(ItemLevels).Append("\n");
      sb.Append("  QualityLevel: ").Append(QualityLevel).Append("\n");
      sb.Append("  InfusionCategoryName: ").Append(InfusionCategoryName).Append("\n");
      sb.Append("  InfusionCategoryHash: ").Append(InfusionCategoryHash).Append("\n");
      sb.Append("  InfusionCategoryHashes: ").Append(InfusionCategoryHashes).Append("\n");
      sb.Append("  ProgressionLevelRequirementHash: ").Append(ProgressionLevelRequirementHash).Append("\n");
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
