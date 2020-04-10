using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This represents a single \&quot;thing\&quot; being tracked by the player.  This can point to many types of entities, but only a subset of them will actually have a valid hash identifier for whatever it is being pointed to.  It&#39;s up to you to interpret what it means when various combinations of these entries have values being tracked.
  /// </summary>
  [DataContract]
  public class DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry {
    /// <summary>
    /// OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.
    /// </summary>
    /// <value>OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.</value>
    [DataMember(Name="locationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationHash")]
    public int? LocationHash { get; set; }

    /// <summary>
    /// OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.
    /// </summary>
    /// <value>OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.
    /// </summary>
    /// <value>OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.</value>
    [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHash")]
    public int? ObjectiveHash { get; set; }

    /// <summary>
    /// OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.
    /// </summary>
    /// <value>OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.
    /// </summary>
    /// <value>OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.</value>
    [DataMember(Name="questlineItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questlineItemHash")]
    public int? QuestlineItemHash { get; set; }

    /// <summary>
    /// OPTIONAL - I've got to level with you, I don't really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don't know, but we can get at it - when I get time to actually test what it is, I'll update this. In the meantime, bask in the mysterious data.
    /// </summary>
    /// <value>OPTIONAL - I've got to level with you, I don't really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don't know, but we can get at it - when I get time to actually test what it is, I'll update this. In the meantime, bask in the mysterious data.</value>
    [DataMember(Name="trackedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackedDate")]
    public DateTime? TrackedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry {\n");
      sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  QuestlineItemHash: ").Append(QuestlineItemHash).Append("\n");
      sb.Append("  TrackedDate: ").Append(TrackedDate).Append("\n");
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
