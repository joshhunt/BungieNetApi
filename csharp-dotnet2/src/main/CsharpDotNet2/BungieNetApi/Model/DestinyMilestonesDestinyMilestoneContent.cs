using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents localized, extended content related to Milestones. This is intentionally returned by a separate endpoint and not with Character-level Milestone data because we do not put localized data into standard Destiny responses, both for brevity of response and for caching purposes. If you really need this data, hit the Milestone Content endpoint.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneContent {
    /// <summary>
    /// The \"About this Milestone\" text from the Firehose.
    /// </summary>
    /// <value>The \"About this Milestone\" text from the Firehose.</value>
    [DataMember(Name="about", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "about")]
    public string About { get; set; }

    /// <summary>
    /// The Current Status of the Milestone, as driven by the Firehose.
    /// </summary>
    /// <value>The Current Status of the Milestone, as driven by the Firehose.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// A list of tips, provided by the Firehose.
    /// </summary>
    /// <value>A list of tips, provided by the Firehose.</value>
    [DataMember(Name="tips", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tips")]
    public List<string> Tips { get; set; }

    /// <summary>
    /// If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.
    /// </summary>
    /// <value>If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.</value>
    [DataMember(Name="itemCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemCategories")]
    public List<DestinyMilestonesDestinyMilestoneContentItemCategory> ItemCategories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneContent {\n");
      sb.Append("  About: ").Append(About).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Tips: ").Append(Tips).Append("\n");
      sb.Append("  ItemCategories: ").Append(ItemCategories).Append("\n");
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
