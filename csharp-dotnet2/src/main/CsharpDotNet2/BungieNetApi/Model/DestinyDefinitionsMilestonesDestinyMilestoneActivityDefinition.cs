using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Milestones can have associated activities which provide additional information about the context, challenges, modifiers, state etc... related to this Milestone.   Information we need to be able to return that data is defined here, along with Tier data to establish a relationship between a conceptual Activity and its difficulty levels and variants.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition {
    /// <summary>
    /// The \"Conceptual\" activity hash. Basically, we picked the lowest level activity and are treating it as the canonical definition of the activity for rendering purposes.  If you care about the specific difficulty modes and variations, use the activities under \"Variants\".
    /// </summary>
    /// <value>The \"Conceptual\" activity hash. Basically, we picked the lowest level activity and are treating it as the canonical definition of the activity for rendering purposes.  If you care about the specific difficulty modes and variations, use the activities under \"Variants\".</value>
    [DataMember(Name="conceptualActivityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conceptualActivityHash")]
    public int? ConceptualActivityHash { get; set; }

    /// <summary>
    /// A milestone-referenced activity can have many variants, such as Tiers or alternative modes of play.  Even if there is only a single variant, the details for these are represented within as a variant definition.  It is assumed that, if this DestinyMilestoneActivityDefinition is active, then all variants should be active.  If a Milestone could ever split the variants' active status conditionally, they should all have their own DestinyMilestoneActivityDefinition instead! The potential duplication will be worth it for the obviousness of processing and use.
    /// </summary>
    /// <value>A milestone-referenced activity can have many variants, such as Tiers or alternative modes of play.  Even if there is only a single variant, the details for these are represented within as a variant definition.  It is assumed that, if this DestinyMilestoneActivityDefinition is active, then all variants should be active.  If a Milestone could ever split the variants' active status conditionally, they should all have their own DestinyMilestoneActivityDefinition instead! The potential duplication will be worth it for the obviousness of processing and use.</value>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variants")]
    public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition> Variants { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition {\n");
      sb.Append("  ConceptualActivityHash: ").Append(ConceptualActivityHash).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
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
