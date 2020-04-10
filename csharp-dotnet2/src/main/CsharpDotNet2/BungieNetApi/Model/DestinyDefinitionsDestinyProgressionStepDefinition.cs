using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This defines a single Step in a progression (which roughly equates to a level. See DestinyProgressionDefinition for caveats).
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyProgressionStepDefinition {
    /// <summary>
    /// Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.
    /// </summary>
    /// <value>Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.</value>
    [DataMember(Name="stepName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepName")]
    public string StepName { get; set; }

    /// <summary>
    /// This appears to be, when you \"level up\", whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.
    /// </summary>
    /// <value>This appears to be, when you \"level up\", whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.</value>
    [DataMember(Name="displayEffectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayEffectType")]
    public int? DisplayEffectType { get; set; }

    /// <summary>
    /// The total amount of progression points/\"experience\" you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.
    /// </summary>
    /// <value>The total amount of progression points/\"experience\" you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.</value>
    [DataMember(Name="progressTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressTotal")]
    public int? ProgressTotal { get; set; }

    /// <summary>
    /// A listing of items rewarded as a result of reaching this level.
    /// </summary>
    /// <value>A listing of items rewarded as a result of reaching this level.</value>
    [DataMember(Name="rewardItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardItems")]
    public List<DestinyDestinyItemQuantity> RewardItems { get; set; }

    /// <summary>
    /// If this progression step has a specific icon related to it, this is the icon to show.
    /// </summary>
    /// <value>If this progression step has a specific icon related to it, this is the icon to show.</value>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyProgressionStepDefinition {\n");
      sb.Append("  StepName: ").Append(StepName).Append("\n");
      sb.Append("  DisplayEffectType: ").Append(DisplayEffectType).Append("\n");
      sb.Append("  ProgressTotal: ").Append(ProgressTotal).Append("\n");
      sb.Append("  RewardItems: ").Append(RewardItems).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
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
