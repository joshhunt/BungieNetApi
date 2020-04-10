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
  public class ForumPollResult {
    /// <summary>
    /// Gets or Sets AnswerText
    /// </summary>
    [DataMember(Name="answerText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answerText")]
    public string AnswerText { get; set; }

    /// <summary>
    /// Gets or Sets AnswerSlot
    /// </summary>
    [DataMember(Name="answerSlot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answerSlot")]
    public int? AnswerSlot { get; set; }

    /// <summary>
    /// Gets or Sets LastVoteDate
    /// </summary>
    [DataMember(Name="lastVoteDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastVoteDate")]
    public DateTime? LastVoteDate { get; set; }

    /// <summary>
    /// Gets or Sets Votes
    /// </summary>
    [DataMember(Name="votes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "votes")]
    public int? Votes { get; set; }

    /// <summary>
    /// Gets or Sets RequestingUserVoted
    /// </summary>
    [DataMember(Name="requestingUserVoted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestingUserVoted")]
    public bool? RequestingUserVoted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ForumPollResult {\n");
      sb.Append("  AnswerText: ").Append(AnswerText).Append("\n");
      sb.Append("  AnswerSlot: ").Append(AnswerSlot).Append("\n");
      sb.Append("  LastVoteDate: ").Append(LastVoteDate).Append("\n");
      sb.Append("  Votes: ").Append(Votes).Append("\n");
      sb.Append("  RequestingUserVoted: ").Append(RequestingUserVoted).Append("\n");
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
