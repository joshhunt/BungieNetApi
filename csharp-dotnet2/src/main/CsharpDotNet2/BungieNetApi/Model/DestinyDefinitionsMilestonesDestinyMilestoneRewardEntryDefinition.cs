using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The definition of a specific reward, which may be contained in a category of rewards and that has optional information about how it is obtained.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition {
    /// <summary>
    /// The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.
    /// </summary>
    /// <value>The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.</value>
    [DataMember(Name="rewardEntryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardEntryHash")]
    public int? RewardEntryHash { get; set; }

    /// <summary>
    /// The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.
    /// </summary>
    /// <value>The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.</value>
    [DataMember(Name="rewardEntryIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardEntryIdentifier")]
    public string RewardEntryIdentifier { get; set; }

    /// <summary>
    /// The items you will get as rewards, and how much of it you'll get.
    /// </summary>
    /// <value>The items you will get as rewards, and how much of it you'll get.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<DestinyDestinyItemQuantity> Items { get; set; }

    /// <summary>
    /// If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.
    /// </summary>
    /// <value>If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.</value>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }

    /// <summary>
    /// For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.
    /// </summary>
    /// <value>For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// If you want to follow BNet's ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.
    /// </summary>
    /// <value>If you want to follow BNet's ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition {\n");
      sb.Append("  RewardEntryHash: ").Append(RewardEntryHash).Append("\n");
      sb.Append("  RewardEntryIdentifier: ").Append(RewardEntryIdentifier).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
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
