using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Information about milestones, presented in a character state-agnostic manner. Combine this data with DestinyMilestoneDefinition to get a full picture of the milestone, which is basically a checklist of things to do in the game. Think of this as GetPublicAdvisors 3.0, for those who used the Destiny 1 API.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyPublicMilestone {
    /// <summary>
    /// The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.
    /// </summary>
    /// <value>The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.</value>
    [DataMember(Name="milestoneHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestoneHash")]
    public int? MilestoneHash { get; set; }

    /// <summary>
    /// A milestone not need have even a single quest, but if there are active quests they will be returned here.
    /// </summary>
    /// <value>A milestone not need have even a single quest, but if there are active quests they will be returned here.</value>
    [DataMember(Name="availableQuests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableQuests")]
    public List<DestinyMilestonesDestinyPublicMilestoneQuest> AvailableQuests { get; set; }

    /// <summary>
    /// Gets or Sets Activities
    /// </summary>
    [DataMember(Name="activities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activities")]
    public List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> Activities { get; set; }

    /// <summary>
    /// Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \"vendors\" property that has more data. What was I thinking.
    /// </summary>
    /// <value>Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \"vendors\" property that has more data. What was I thinking.</value>
    [DataMember(Name="vendorHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHashes")]
    public List<int?> VendorHashes { get; set; }

    /// <summary>
    /// This is why we can't have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.
    /// </summary>
    /// <value>This is why we can't have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.</value>
    [DataMember(Name="vendors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendors")]
    public List<DestinyMilestonesDestinyPublicMilestoneVendor> Vendors { get; set; }

    /// <summary>
    /// If known, this is the date when the Milestone started/became active.
    /// </summary>
    /// <value>If known, this is the date when the Milestone started/became active.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// If known, this is the date when the Milestone will expire/recycle/end.
    /// </summary>
    /// <value>If known, this is the date when the Milestone will expire/recycle/end.</value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.
    /// </summary>
    /// <value>Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyPublicMilestone {\n");
      sb.Append("  MilestoneHash: ").Append(MilestoneHash).Append("\n");
      sb.Append("  AvailableQuests: ").Append(AvailableQuests).Append("\n");
      sb.Append("  Activities: ").Append(Activities).Append("\n");
      sb.Append("  VendorHashes: ").Append(VendorHashes).Append("\n");
      sb.Append("  Vendors: ").Append(Vendors).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
