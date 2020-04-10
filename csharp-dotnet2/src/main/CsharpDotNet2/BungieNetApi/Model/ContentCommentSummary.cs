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
  public class ContentCommentSummary {
    /// <summary>
    /// Gets or Sets TopicId
    /// </summary>
    [DataMember(Name="topicId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topicId")]
    public long? TopicId { get; set; }

    /// <summary>
    /// Gets or Sets CommentCount
    /// </summary>
    [DataMember(Name="commentCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commentCount")]
    public int? CommentCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentCommentSummary {\n");
      sb.Append("  TopicId: ").Append(TopicId).Append("\n");
      sb.Append("  CommentCount: ").Append(CommentCount).Append("\n");
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
