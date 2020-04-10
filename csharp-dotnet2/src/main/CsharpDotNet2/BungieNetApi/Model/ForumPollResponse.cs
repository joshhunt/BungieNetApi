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
  public class ForumPollResponse {
    /// <summary>
    /// Gets or Sets TopicId
    /// </summary>
    [DataMember(Name="topicId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topicId")]
    public long? TopicId { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public List<ForumPollResult> Results { get; set; }

    /// <summary>
    /// Gets or Sets TotalVotes
    /// </summary>
    [DataMember(Name="totalVotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalVotes")]
    public int? TotalVotes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ForumPollResponse {\n");
      sb.Append("  TopicId: ").Append(TopicId).Append("\n");
      sb.Append("  Results: ").Append(Results).Append("\n");
      sb.Append("  TotalVotes: ").Append(TotalVotes).Append("\n");
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
