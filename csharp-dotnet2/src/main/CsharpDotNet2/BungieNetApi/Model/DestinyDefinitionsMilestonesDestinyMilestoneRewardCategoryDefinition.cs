using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The definition of a category of rewards, that contains many individual rewards.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition {
    /// <summary>
    /// Identifies the reward category. Only guaranteed unique within this specific component!
    /// </summary>
    /// <value>Identifies the reward category. Only guaranteed unique within this specific component!</value>
    [DataMember(Name="categoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryHash")]
    public int? CategoryHash { get; set; }

    /// <summary>
    /// The string identifier for the category, if you want to use it for some end. Guaranteed unique within the specific component.
    /// </summary>
    /// <value>The string identifier for the category, if you want to use it for some end. Guaranteed unique within the specific component.</value>
    [DataMember(Name="categoryIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryIdentifier")]
    public string CategoryIdentifier { get; set; }

    /// <summary>
    /// Hopefully this is obvious by now.
    /// </summary>
    /// <value>Hopefully this is obvious by now.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// If this milestone can provide rewards, this will define the sets of rewards that can be earned, the conditions under which they can be acquired, internal data that we'll use at runtime to determine whether you've already earned or redeemed this set of rewards, and the category that this reward should be placed under.
    /// </summary>
    /// <value>If this milestone can provide rewards, this will define the sets of rewards that can be earned, the conditions under which they can be acquired, internal data that we'll use at runtime to determine whether you've already earned or redeemed this set of rewards, and the category that this reward should be placed under.</value>
    [DataMember(Name="rewardEntries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardEntries")]
    public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition> RewardEntries { get; set; }

    /// <summary>
    /// If you want to use BNet's recommended order for rendering categories programmatically, use this value and compare it to other categories to determine the order in which they should be rendered. I don't feel great about putting this here, I won't lie.
    /// </summary>
    /// <value>If you want to use BNet's recommended order for rendering categories programmatically, use this value and compare it to other categories to determine the order in which they should be rendered. I don't feel great about putting this here, I won't lie.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition {\n");
      sb.Append("  CategoryHash: ").Append(CategoryHash).Append("\n");
      sb.Append("  CategoryIdentifier: ").Append(CategoryIdentifier).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  RewardEntries: ").Append(RewardEntries).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
