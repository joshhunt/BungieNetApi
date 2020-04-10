using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TrendingTrendingEntryDestinyRitual {
    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets Icon
    /// </summary>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Subtitle
    /// </summary>
    [DataMember(Name="subtitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtitle")]
    public string Subtitle { get; set; }

    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    [DataMember(Name="dateStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateStart")]
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Gets or Sets DateEnd
    /// </summary>
    [DataMember(Name="dateEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateEnd")]
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// A destiny event does not necessarily have a related Milestone, but if it does the details will be returned here.
    /// </summary>
    /// <value>A destiny event does not necessarily have a related Milestone, but if it does the details will be returned here.</value>
    [DataMember(Name="milestoneDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestoneDetails")]
    public DestinyMilestonesDestinyPublicMilestone MilestoneDetails { get; set; }

    /// <summary>
    /// A destiny event will not necessarily have milestone \"custom content\", but if it does the details will be here.
    /// </summary>
    /// <value>A destiny event will not necessarily have milestone \"custom content\", but if it does the details will be here.</value>
    [DataMember(Name="eventContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventContent")]
    public DestinyMilestonesDestinyMilestoneContent EventContent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrendingTrendingEntryDestinyRitual {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
      sb.Append("  DateStart: ").Append(DateStart).Append("\n");
      sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
      sb.Append("  MilestoneDetails: ").Append(MilestoneDetails).Append("\n");
      sb.Append("  EventContent: ").Append(EventContent).Append("\n");
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
