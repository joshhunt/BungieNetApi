using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This property has some history. A talent grid can provide stats on both the item it&#39;s related to and the character equipping the item. This returns data about those stat bonuses.
  /// </summary>
  [DataContract]
  public class DestinyDestinyTalentNodeStatBlock {
    /// <summary>
    /// The stat benefits conferred when this talent node is activated for the current Step that is active on the node.
    /// </summary>
    /// <value>The stat benefits conferred when this talent node is activated for the current Step that is active on the node.</value>
    [DataMember(Name="currentStepStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentStepStats")]
    public List<DestinyDestinyStat> CurrentStepStats { get; set; }

    /// <summary>
    /// This is a holdover from the old days of Destiny 1, when a node could be activated multiple times, conferring multiple steps worth of benefits: you would use this property to show what activating the \"next\" step on the node would provide vs. what the current step is providing. While Nodes are currently not being used this way, the underlying system for this functionality still exists. I hesitate to remove this property while the ability for designers to make such a talent grid still exists. Whether you want to show it is up to you.
    /// </summary>
    /// <value>This is a holdover from the old days of Destiny 1, when a node could be activated multiple times, conferring multiple steps worth of benefits: you would use this property to show what activating the \"next\" step on the node would provide vs. what the current step is providing. While Nodes are currently not being used this way, the underlying system for this functionality still exists. I hesitate to remove this property while the ability for designers to make such a talent grid still exists. Whether you want to show it is up to you.</value>
    [DataMember(Name="nextStepStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextStepStats")]
    public List<DestinyDestinyStat> NextStepStats { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyTalentNodeStatBlock {\n");
      sb.Append("  CurrentStepStats: ").Append(CurrentStepStats).Append("\n");
      sb.Append("  NextStepStats: ").Append(NextStepStats).Append("\n");
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
