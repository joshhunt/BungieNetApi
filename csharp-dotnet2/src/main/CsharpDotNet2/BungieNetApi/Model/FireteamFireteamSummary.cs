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
  public class FireteamFireteamSummary {
    /// <summary>
    /// Gets or Sets FireteamId
    /// </summary>
    [DataMember(Name="fireteamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fireteamId")]
    public long? FireteamId { get; set; }

    /// <summary>
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platform")]
    public int? Platform { get; set; }

    /// <summary>
    /// Gets or Sets ActivityType
    /// </summary>
    [DataMember(Name="activityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityType")]
    public int? ActivityType { get; set; }

    /// <summary>
    /// Gets or Sets IsImmediate
    /// </summary>
    [DataMember(Name="isImmediate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isImmediate")]
    public bool? IsImmediate { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledTime
    /// </summary>
    [DataMember(Name="scheduledTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledTime")]
    public DateTime? ScheduledTime { get; set; }

    /// <summary>
    /// Gets or Sets OwnerMembershipId
    /// </summary>
    [DataMember(Name="ownerMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerMembershipId")]
    public long? OwnerMembershipId { get; set; }

    /// <summary>
    /// Gets or Sets PlayerSlotCount
    /// </summary>
    [DataMember(Name="playerSlotCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerSlotCount")]
    public int? PlayerSlotCount { get; set; }

    /// <summary>
    /// Gets or Sets AlternateSlotCount
    /// </summary>
    [DataMember(Name="alternateSlotCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alternateSlotCount")]
    public int? AlternateSlotCount { get; set; }

    /// <summary>
    /// Gets or Sets AvailablePlayerSlotCount
    /// </summary>
    [DataMember(Name="availablePlayerSlotCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availablePlayerSlotCount")]
    public int? AvailablePlayerSlotCount { get; set; }

    /// <summary>
    /// Gets or Sets AvailableAlternateSlotCount
    /// </summary>
    [DataMember(Name="availableAlternateSlotCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableAlternateSlotCount")]
    public int? AvailableAlternateSlotCount { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name="dateCreated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateCreated")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [DataMember(Name="dateModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateModified")]
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets IsPublic
    /// </summary>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets IsValid
    /// </summary>
    [DataMember(Name="isValid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isValid")]
    public bool? IsValid { get; set; }

    /// <summary>
    /// Gets or Sets DatePlayerModified
    /// </summary>
    [DataMember(Name="datePlayerModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datePlayerModified")]
    public DateTime? DatePlayerModified { get; set; }

    /// <summary>
    /// Gets or Sets TitleBeforeModeration
    /// </summary>
    [DataMember(Name="titleBeforeModeration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titleBeforeModeration")]
    public string TitleBeforeModeration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FireteamFireteamSummary {\n");
      sb.Append("  FireteamId: ").Append(FireteamId).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
      sb.Append("  IsImmediate: ").Append(IsImmediate).Append("\n");
      sb.Append("  ScheduledTime: ").Append(ScheduledTime).Append("\n");
      sb.Append("  OwnerMembershipId: ").Append(OwnerMembershipId).Append("\n");
      sb.Append("  PlayerSlotCount: ").Append(PlayerSlotCount).Append("\n");
      sb.Append("  AlternateSlotCount: ").Append(AlternateSlotCount).Append("\n");
      sb.Append("  AvailablePlayerSlotCount: ").Append(AvailablePlayerSlotCount).Append("\n");
      sb.Append("  AvailableAlternateSlotCount: ").Append(AvailableAlternateSlotCount).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  DateModified: ").Append(DateModified).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  IsValid: ").Append(IsValid).Append("\n");
      sb.Append("  DatePlayerModified: ").Append(DatePlayerModified).Append("\n");
      sb.Append("  TitleBeforeModeration: ").Append(TitleBeforeModeration).Append("\n");
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
