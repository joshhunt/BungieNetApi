using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If the activity is a playlist, this is the definition for a specific entry in the playlist: a single possible combination of Activity and Activity Mode that can be chosen.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityPlaylistItemDefinition {
    /// <summary>
    /// The hash identifier of the Activity that can be played. Use it to look up the DestinyActivityDefinition.
    /// </summary>
    /// <value>The hash identifier of the Activity that can be played. Use it to look up the DestinyActivityDefinition.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// If this playlist entry had an activity mode directly defined on it, this will be the hash of that mode.
    /// </summary>
    /// <value>If this playlist entry had an activity mode directly defined on it, this will be the hash of that mode.</value>
    [DataMember(Name="directActivityModeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directActivityModeHash")]
    public int? DirectActivityModeHash { get; set; }

    /// <summary>
    /// If the playlist entry had an activity mode directly defined on it, this will be the enum value of that mode.
    /// </summary>
    /// <value>If the playlist entry had an activity mode directly defined on it, this will be the enum value of that mode.</value>
    [DataMember(Name="directActivityModeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directActivityModeType")]
    public int? DirectActivityModeType { get; set; }

    /// <summary>
    /// The hash identifiers for Activity Modes relevant to this entry.
    /// </summary>
    /// <value>The hash identifiers for Activity Modes relevant to this entry.</value>
    [DataMember(Name="activityModeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeHashes")]
    public List<int?> ActivityModeHashes { get; set; }

    /// <summary>
    /// The activity modes - if any - in enum form. Because we can't seem to escape the enums.
    /// </summary>
    /// <value>The activity modes - if any - in enum form. Because we can't seem to escape the enums.</value>
    [DataMember(Name="activityModeTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeTypes")]
    public List<int?> ActivityModeTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityPlaylistItemDefinition {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  DirectActivityModeHash: ").Append(DirectActivityModeHash).Append("\n");
      sb.Append("  DirectActivityModeType: ").Append(DirectActivityModeType).Append("\n");
      sb.Append("  ActivityModeHashes: ").Append(ActivityModeHashes).Append("\n");
      sb.Append("  ActivityModeTypes: ").Append(ActivityModeTypes).Append("\n");
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
