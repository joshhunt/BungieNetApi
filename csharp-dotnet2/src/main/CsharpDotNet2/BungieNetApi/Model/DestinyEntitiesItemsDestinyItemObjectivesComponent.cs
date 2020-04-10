using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Items can have objectives and progression. When you request this block, you will obtain information about any Objectives and progression tied to this item.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemObjectivesComponent {
    /// <summary>
    /// If the item has a hard association with objectives, your progress on them will be defined here.   Objectives are our standard way to describe a series of tasks that have to be completed for a reward.
    /// </summary>
    /// <value>If the item has a hard association with objectives, your progress on them will be defined here.   Objectives are our standard way to describe a series of tasks that have to be completed for a reward.</value>
    [DataMember(Name="objectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectives")]
    public List<DestinyQuestsDestinyObjectiveProgress> Objectives { get; set; }

    /// <summary>
    /// I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for \"flavor\" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
    /// </summary>
    /// <value>I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for \"flavor\" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.</value>
    [DataMember(Name="flavorObjective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavorObjective")]
    public DestinyQuestsDestinyObjectiveProgress FlavorObjective { get; set; }

    /// <summary>
    /// If we have any information on when these objectives were completed, this will be the date of that completion. This won't be on many items, but could be interesting for some items that do store this information.
    /// </summary>
    /// <value>If we have any information on when these objectives were completed, this will be the date of that completion. This won't be on many items, but could be interesting for some items that do store this information.</value>
    [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateCompleted")]
    public DateTime? DateCompleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemObjectivesComponent {\n");
      sb.Append("  Objectives: ").Append(Objectives).Append("\n");
      sb.Append("  FlavorObjective: ").Append(FlavorObjective).Append("\n");
      sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
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
