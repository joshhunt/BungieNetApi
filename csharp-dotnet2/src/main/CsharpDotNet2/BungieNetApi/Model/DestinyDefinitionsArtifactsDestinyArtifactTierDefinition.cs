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
  public class DestinyDefinitionsArtifactsDestinyArtifactTierDefinition {
    /// <summary>
    /// An identifier, unique within the Artifact, for this specific tier.
    /// </summary>
    /// <value>An identifier, unique within the Artifact, for this specific tier.</value>
    [DataMember(Name="tierHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tierHash")]
    public int? TierHash { get; set; }

    /// <summary>
    /// The human readable title of this tier, if any.
    /// </summary>
    /// <value>The human readable title of this tier, if any.</value>
    [DataMember(Name="displayTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayTitle")]
    public string DisplayTitle { get; set; }

    /// <summary>
    /// A string representing the localized minimum requirement text for this Tier, if any.
    /// </summary>
    /// <value>A string representing the localized minimum requirement text for this Tier, if any.</value>
    [DataMember(Name="progressRequirementMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressRequirementMessage")]
    public string ProgressRequirementMessage { get; set; }

    /// <summary>
    /// The items that can be earned within this tier.
    /// </summary>
    /// <value>The items that can be earned within this tier.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> Items { get; set; }

    /// <summary>
    /// The minimum number of \"unlock points\" that you must have used before you can unlock items from this tier.
    /// </summary>
    /// <value>The minimum number of \"unlock points\" that you must have used before you can unlock items from this tier.</value>
    [DataMember(Name="minimumUnlockPointsUsedRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumUnlockPointsUsedRequirement")]
    public int? MinimumUnlockPointsUsedRequirement { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsArtifactsDestinyArtifactTierDefinition {\n");
      sb.Append("  TierHash: ").Append(TierHash).Append("\n");
      sb.Append("  DisplayTitle: ").Append(DisplayTitle).Append("\n");
      sb.Append("  ProgressRequirementMessage: ").Append(ProgressRequirementMessage).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  MinimumUnlockPointsUsedRequirement: ").Append(MinimumUnlockPointsUsedRequirement).Append("\n");
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
