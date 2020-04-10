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
  public class TrendingTrendingDetail {
    /// <summary>
    /// Gets or Sets Identifier
    /// </summary>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [DataMember(Name="entityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityType")]
    public int? EntityType { get; set; }

    /// <summary>
    /// Gets or Sets News
    /// </summary>
    [DataMember(Name="news", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "news")]
    public TrendingTrendingEntryNews News { get; set; }

    /// <summary>
    /// Gets or Sets Support
    /// </summary>
    [DataMember(Name="support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support")]
    public TrendingTrendingEntrySupportArticle Support { get; set; }

    /// <summary>
    /// Gets or Sets DestinyItem
    /// </summary>
    [DataMember(Name="destinyItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyItem")]
    public TrendingTrendingEntryDestinyItem DestinyItem { get; set; }

    /// <summary>
    /// Gets or Sets DestinyActivity
    /// </summary>
    [DataMember(Name="destinyActivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyActivity")]
    public TrendingTrendingEntryDestinyActivity DestinyActivity { get; set; }

    /// <summary>
    /// Gets or Sets DestinyRitual
    /// </summary>
    [DataMember(Name="destinyRitual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyRitual")]
    public TrendingTrendingEntryDestinyRitual DestinyRitual { get; set; }

    /// <summary>
    /// Gets or Sets Creation
    /// </summary>
    [DataMember(Name="creation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creation")]
    public TrendingTrendingEntryCommunityCreation Creation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrendingTrendingDetail {\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  EntityType: ").Append(EntityType).Append("\n");
      sb.Append("  News: ").Append(News).Append("\n");
      sb.Append("  Support: ").Append(Support).Append("\n");
      sb.Append("  DestinyItem: ").Append(DestinyItem).Append("\n");
      sb.Append("  DestinyActivity: ").Append(DestinyActivity).Append("\n");
      sb.Append("  DestinyRitual: ").Append(DestinyRitual).Append("\n");
      sb.Append("  Creation: ").Append(Creation).Append("\n");
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
