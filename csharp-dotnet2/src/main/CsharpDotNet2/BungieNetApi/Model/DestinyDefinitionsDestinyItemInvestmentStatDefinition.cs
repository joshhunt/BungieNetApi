using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a \&quot;raw\&quot; investment stat, before calculated stats are calculated and before any DestinyStatGroupDefinition is applied to transform the stat into something closer to what you see in-game.  Because these won&#39;t match what you see in-game, consider carefully whether you really want to use these stats. I have left them in case someone can do something useful or interesting with the pre-processed statistics.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemInvestmentStatDefinition {
    /// <summary>
    /// The hash identifier for the DestinyStatDefinition defining this stat.
    /// </summary>
    /// <value>The hash identifier for the DestinyStatDefinition defining this stat.</value>
    [DataMember(Name="statTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statTypeHash")]
    public int? StatTypeHash { get; set; }

    /// <summary>
    /// The raw \"Investment\" value for the stat, before transformations are performed to turn this raw stat into stats that are displayed in the game UI.
    /// </summary>
    /// <value>The raw \"Investment\" value for the stat, before transformations are performed to turn this raw stat into stats that are displayed in the game UI.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public int? Value { get; set; }

    /// <summary>
    /// If this is true, the stat will only be applied on the item in certain game state conditions, and we can't know statically whether or not this stat will be applied. Check the \"live\" API data instead for whether this value is being applied on a specific instance of the item in question, and you can use this to decide whether you want to show the stat on the generic view of the item, or whether you want to show some kind of caveat or warning about the stat value being conditional on game state.
    /// </summary>
    /// <value>If this is true, the stat will only be applied on the item in certain game state conditions, and we can't know statically whether or not this stat will be applied. Check the \"live\" API data instead for whether this value is being applied on a specific instance of the item in question, and you can use this to decide whether you want to show the stat on the generic view of the item, or whether you want to show some kind of caveat or warning about the stat value being conditional on game state.</value>
    [DataMember(Name="isConditionallyActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isConditionallyActive")]
    public bool? IsConditionallyActive { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemInvestmentStatDefinition {\n");
      sb.Append("  StatTypeHash: ").Append(StatTypeHash).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  IsConditionallyActive: ").Append(IsConditionallyActive).Append("\n");
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
