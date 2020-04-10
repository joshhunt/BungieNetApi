using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a runtime instance of a user&#39;s milestone status. Live Milestone data should be combined with DestinyMilestoneDefinition data to show the user a picture of what is available for them to do in the game, and their status in regards to said \&quot;things to do.\&quot; Consider it a big, wonky to-do list, or Advisors 3.0 for those who remember the Destiny 1 API.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestone {
    /// <summary>
    /// The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.
    /// </summary>
    /// <value>The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.</value>
    [DataMember(Name="milestoneHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestoneHash")]
    public int? MilestoneHash { get; set; }

    /// <summary>
    /// Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests.
    /// </summary>
    /// <value>Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests.</value>
    [DataMember(Name="availableQuests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableQuests")]
    public List<DestinyMilestonesDestinyMilestoneQuest> AvailableQuests { get; set; }

    /// <summary>
    /// The currently active Activities in this milestone, when the Milestone is driven by Challenges.  Not all Milestones have Challenges, but when they do this will indicate the Activities and Challenges under those Activities related to this Milestone.
    /// </summary>
    /// <value>The currently active Activities in this milestone, when the Milestone is driven by Challenges.  Not all Milestones have Challenges, but when they do this will indicate the Activities and Challenges under those Activities related to this Milestone.</value>
    [DataMember(Name="activities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activities")]
    public List<DestinyMilestonesDestinyMilestoneChallengeActivity> Activities { get; set; }

    /// <summary>
    /// Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn't fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number.
    /// </summary>
    /// <value>Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn't fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number.</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public Dictionary<string, float?> Values { get; set; }

    /// <summary>
    /// A milestone may have one or more active vendors that are \"related\" to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I'm typing it. [I told you I'd regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it's already deprecated! How much of a bummer is that? We need more data.
    /// </summary>
    /// <value>A milestone may have one or more active vendors that are \"related\" to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I'm typing it. [I told you I'd regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it's already deprecated! How much of a bummer is that? We need more data.</value>
    [DataMember(Name="vendorHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHashes")]
    public List<int?> VendorHashes { get; set; }

    /// <summary>
    /// Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.
    /// </summary>
    /// <value>Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.</value>
    [DataMember(Name="vendors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendors")]
    public List<DestinyMilestonesDestinyMilestoneVendor> Vendors { get; set; }

    /// <summary>
    /// If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \"overview/checklist\" rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren't under a specific Quest.
    /// </summary>
    /// <value>If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \"overview/checklist\" rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren't under a specific Quest.</value>
    [DataMember(Name="rewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewards")]
    public List<DestinyMilestonesDestinyMilestoneRewardCategory> Rewards { get; set; }

    /// <summary>
    /// If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates.
    /// </summary>
    /// <value>If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates.
    /// </summary>
    /// <value>If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates.</value>
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
      sb.Append("class DestinyMilestonesDestinyMilestone {\n");
      sb.Append("  MilestoneHash: ").Append(MilestoneHash).Append("\n");
      sb.Append("  AvailableQuests: ").Append(AvailableQuests).Append("\n");
      sb.Append("  Activities: ").Append(Activities).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
      sb.Append("  VendorHashes: ").Append(VendorHashes).Append("\n");
      sb.Append("  Vendors: ").Append(Vendors).Append("\n");
      sb.Append("  Rewards: ").Append(Rewards).Append("\n");
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
