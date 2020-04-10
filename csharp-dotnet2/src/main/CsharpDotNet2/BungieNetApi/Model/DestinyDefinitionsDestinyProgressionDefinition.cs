using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A \&quot;Progression\&quot; in Destiny is best explained by an example.  A Character&#39;s \&quot;Level\&quot; is a progression: it has Experience that can be earned, levels that can be gained, and is evaluated and displayed at various points in the game. A Character&#39;s \&quot;Faction Reputation\&quot; is also a progression for much the same reason.  Progression is used by a variety of systems, and the definition of a Progression will generally only be useful if combining with live data (such as a character&#39;s DestinyCharacterProgressionComponent.progressions property, which holds that character&#39;s live Progression states).  Fundamentally, a Progression measures your \&quot;Level\&quot; by evaluating the thresholds in its Steps (one step per level, except for the last step which can be repeated indefinitely for \&quot;Levels\&quot; that have no ceiling) against the total earned \&quot;progression points\&quot;/experience. (for simplicity purposes, we will henceforth refer to earned progression points as experience, though it need not be a mechanic that in any way resembles Experience in a traditional sense).  Earned experience is calculated in a variety of ways, determined by the Progression&#39;s scope. These go from looking up a stored value to performing exceedingly obtuse calculations. This is why we provide live data in DestinyCharacterProgressionComponent.progressions, so you don&#39;t have to worry about those.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyProgressionDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The \"Scope\" of the progression indicates the source of the progression's live data.  See the DestinyProgressionScope enum for more info: but essentially, a Progression can either be backed by a stored value, or it can be a calculated derivative of other values.
    /// </summary>
    /// <value>The \"Scope\" of the progression indicates the source of the progression's live data.  See the DestinyProgressionScope enum for more info: but essentially, a Progression can either be backed by a stored value, or it can be a calculated derivative of other values.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// If this is True, then the progression doesn't have a maximum level.
    /// </summary>
    /// <value>If this is True, then the progression doesn't have a maximum level.</value>
    [DataMember(Name="repeatLastStep", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repeatLastStep")]
    public bool? RepeatLastStep { get; set; }

    /// <summary>
    /// If there's a description of how to earn this progression in the local config, this will be that localized description.
    /// </summary>
    /// <value>If there's a description of how to earn this progression in the local config, this will be that localized description.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Progressions are divided into Steps, which roughly equate to \"Levels\" in the traditional sense of a Progression. Notably, the last step can be repeated indefinitely if repeatLastStep is true, meaning that the calculation for your level is not as simple as comparing your current progress to the max progress of the steps.   These and more calculations are done for you if you grab live character progression data, such as in the DestinyCharacterProgressionComponent.
    /// </summary>
    /// <value>Progressions are divided into Steps, which roughly equate to \"Levels\" in the traditional sense of a Progression. Notably, the last step can be repeated indefinitely if repeatLastStep is true, meaning that the calculation for your level is not as simple as comparing your current progress to the max progress of the steps.   These and more calculations are done for you if you grab live character progression data, such as in the DestinyCharacterProgressionComponent.</value>
    [DataMember(Name="steps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "steps")]
    public List<DestinyDefinitionsDestinyProgressionStepDefinition> Steps { get; set; }

    /// <summary>
    /// If true, the Progression is something worth showing to users.  If false, BNet isn't going to show it. But that doesn't mean you can't. We're all friends here.
    /// </summary>
    /// <value>If true, the Progression is something worth showing to users.  If false, BNet isn't going to show it. But that doesn't mean you can't. We're all friends here.</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// If the value exists, this is the hash identifier for the Faction that owns this Progression.  This is purely for convenience, if you're looking at a progression and want to know if and who it's related to in terms of Faction Reputation.
    /// </summary>
    /// <value>If the value exists, this is the hash identifier for the Faction that owns this Progression.  This is purely for convenience, if you're looking at a progression and want to know if and who it's related to in terms of Faction Reputation.</value>
    [DataMember(Name="factionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factionHash")]
    public int? FactionHash { get; set; }

    /// <summary>
    /// The #RGB string value for the color related to this progression, if there is one.
    /// </summary>
    /// <value>The #RGB string value for the color related to this progression, if there is one.</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public DestinyMiscDestinyColor Color { get; set; }

    /// <summary>
    /// For progressions that have it, this is the rank icon we use in the Companion, displayed above the progressions' rank value.
    /// </summary>
    /// <value>For progressions that have it, this is the rank icon we use in the Companion, displayed above the progressions' rank value.</value>
    [DataMember(Name="rankIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rankIcon")]
    public string RankIcon { get; set; }

    /// <summary>
    /// Gets or Sets RewardItems
    /// </summary>
    [DataMember(Name="rewardItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardItems")]
    public List<DestinyDefinitionsDestinyProgressionRewardItemQuantity> RewardItems { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyProgressionDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  RepeatLastStep: ").Append(RepeatLastStep).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Steps: ").Append(Steps).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  FactionHash: ").Append(FactionHash).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  RankIcon: ").Append(RankIcon).Append("\n");
      sb.Append("  RewardItems: ").Append(RewardItems).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
