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
  public class ForumForumRecruitmentDetail {
    /// <summary>
    /// Gets or Sets TopicId
    /// </summary>
    [DataMember(Name="topicId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topicId")]
    public long? TopicId { get; set; }

    /// <summary>
    /// Gets or Sets MicrophoneRequired
    /// </summary>
    [DataMember(Name="microphoneRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microphoneRequired")]
    public bool? MicrophoneRequired { get; set; }

    /// <summary>
    /// Gets or Sets Intensity
    /// </summary>
    [DataMember(Name="intensity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intensity")]
    public int? Intensity { get; set; }

    /// <summary>
    /// Gets or Sets Tone
    /// </summary>
    [DataMember(Name="tone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tone")]
    public int? Tone { get; set; }

    /// <summary>
    /// Gets or Sets Approved
    /// </summary>
    [DataMember(Name="approved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approved")]
    public bool? Approved { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name="conversationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversationId")]
    public long? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets PlayerSlotsTotal
    /// </summary>
    [DataMember(Name="playerSlotsTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerSlotsTotal")]
    public int? PlayerSlotsTotal { get; set; }

    /// <summary>
    /// Gets or Sets PlayerSlotsRemaining
    /// </summary>
    [DataMember(Name="playerSlotsRemaining", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerSlotsRemaining")]
    public int? PlayerSlotsRemaining { get; set; }

    /// <summary>
    /// Gets or Sets Fireteam
    /// </summary>
    [DataMember(Name="Fireteam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fireteam")]
    public List<UserGeneralUser> Fireteam { get; set; }

    /// <summary>
    /// Gets or Sets KickedPlayerIds
    /// </summary>
    [DataMember(Name="kickedPlayerIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kickedPlayerIds")]
    public List<long?> KickedPlayerIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ForumForumRecruitmentDetail {\n");
      sb.Append("  TopicId: ").Append(TopicId).Append("\n");
      sb.Append("  MicrophoneRequired: ").Append(MicrophoneRequired).Append("\n");
      sb.Append("  Intensity: ").Append(Intensity).Append("\n");
      sb.Append("  Tone: ").Append(Tone).Append("\n");
      sb.Append("  Approved: ").Append(Approved).Append("\n");
      sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
      sb.Append("  PlayerSlotsTotal: ").Append(PlayerSlotsTotal).Append("\n");
      sb.Append("  PlayerSlotsRemaining: ").Append(PlayerSlotsRemaining).Append("\n");
      sb.Append("  Fireteam: ").Append(Fireteam).Append("\n");
      sb.Append("  KickedPlayerIds: ").Append(KickedPlayerIds).Append("\n");
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
