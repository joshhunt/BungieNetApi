using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This component holds activity data for a character. It will tell you about the character&#39;s current activity status, as well as activities that are available to the user.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesCharactersDestinyCharacterActivitiesComponent {
    /// <summary>
    /// The last date that the user started playing an activity.
    /// </summary>
    /// <value>The last date that the user started playing an activity.</value>
    [DataMember(Name="dateActivityStarted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateActivityStarted")]
    public DateTime? DateActivityStarted { get; set; }

    /// <summary>
    /// The list of activities that the user can play.
    /// </summary>
    /// <value>The list of activities that the user can play.</value>
    [DataMember(Name="availableActivities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableActivities")]
    public List<DestinyDestinyActivity> AvailableActivities { get; set; }

    /// <summary>
    /// If the user is in an activity, this will be the hash of the Activity being played. Note that you must combine this info with currentActivityModeHash to get a real picture of what the user is doing right now. For instance, PVP \"Activities\" are just maps: it's the ActivityMode that determines what type of PVP game they're playing.
    /// </summary>
    /// <value>If the user is in an activity, this will be the hash of the Activity being played. Note that you must combine this info with currentActivityModeHash to get a real picture of what the user is doing right now. For instance, PVP \"Activities\" are just maps: it's the ActivityMode that determines what type of PVP game they're playing.</value>
    [DataMember(Name="currentActivityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentActivityHash")]
    public int? CurrentActivityHash { get; set; }

    /// <summary>
    /// If the user is in an activity, this will be the hash of the activity mode being played. Combine with currentActivityHash to give a person a full picture of what they're doing right now.
    /// </summary>
    /// <value>If the user is in an activity, this will be the hash of the activity mode being played. Combine with currentActivityHash to give a person a full picture of what they're doing right now.</value>
    [DataMember(Name="currentActivityModeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentActivityModeHash")]
    public int? CurrentActivityModeHash { get; set; }

    /// <summary>
    /// And the current activity's most specific mode type, if it can be found.
    /// </summary>
    /// <value>And the current activity's most specific mode type, if it can be found.</value>
    [DataMember(Name="currentActivityModeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentActivityModeType")]
    public int? CurrentActivityModeType { get; set; }

    /// <summary>
    /// If the user is in an activity, this will be the hashes of the DestinyActivityModeDefinition being played. Combine with currentActivityHash to give a person a full picture of what they're doing right now.
    /// </summary>
    /// <value>If the user is in an activity, this will be the hashes of the DestinyActivityModeDefinition being played. Combine with currentActivityHash to give a person a full picture of what they're doing right now.</value>
    [DataMember(Name="currentActivityModeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentActivityModeHashes")]
    public List<int?> CurrentActivityModeHashes { get; set; }

    /// <summary>
    /// All Activity Modes that apply to the current activity being played, in enum form.
    /// </summary>
    /// <value>All Activity Modes that apply to the current activity being played, in enum form.</value>
    [DataMember(Name="currentActivityModeTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentActivityModeTypes")]
    public List<int?> CurrentActivityModeTypes { get; set; }

    /// <summary>
    /// If the user is in a playlist, this is the hash identifier for the playlist that they chose.
    /// </summary>
    /// <value>If the user is in a playlist, this is the hash identifier for the playlist that they chose.</value>
    [DataMember(Name="currentPlaylistActivityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPlaylistActivityHash")]
    public int? CurrentPlaylistActivityHash { get; set; }

    /// <summary>
    /// This will have the activity hash of the last completed story/campaign mission, in case you care about that.
    /// </summary>
    /// <value>This will have the activity hash of the last completed story/campaign mission, in case you care about that.</value>
    [DataMember(Name="lastCompletedStoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastCompletedStoryHash")]
    public int? LastCompletedStoryHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesCharactersDestinyCharacterActivitiesComponent {\n");
      sb.Append("  DateActivityStarted: ").Append(DateActivityStarted).Append("\n");
      sb.Append("  AvailableActivities: ").Append(AvailableActivities).Append("\n");
      sb.Append("  CurrentActivityHash: ").Append(CurrentActivityHash).Append("\n");
      sb.Append("  CurrentActivityModeHash: ").Append(CurrentActivityModeHash).Append("\n");
      sb.Append("  CurrentActivityModeType: ").Append(CurrentActivityModeType).Append("\n");
      sb.Append("  CurrentActivityModeHashes: ").Append(CurrentActivityModeHashes).Append("\n");
      sb.Append("  CurrentActivityModeTypes: ").Append(CurrentActivityModeTypes).Append("\n");
      sb.Append("  CurrentPlaylistActivityHash: ").Append(CurrentPlaylistActivityHash).Append("\n");
      sb.Append("  LastCompletedStoryHash: ").Append(LastCompletedStoryHash).Append("\n");
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
