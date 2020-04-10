using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This definition represents an \&quot;Activity Mode\&quot; as it exists in the Historical Stats endpoints. An individual Activity Mode represents a collection of activities that are played in a certain way. For example, Nightfall Strikes are part of a \&quot;Nightfall\&quot; activity mode, and any activities played as the PVP mode \&quot;Clash\&quot; are part of the \&quot;Clash activity mode.  Activity modes are nested under each other in a hierarchy, so that if you ask for - for example - \&quot;AllPvP\&quot;, you will get any PVP activities that the user has played, regardless of what specific PVP mode was being played.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityModeDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// If this activity mode has a related PGCR image, this will be the path to said image.
    /// </summary>
    /// <value>If this activity mode has a related PGCR image, this will be the path to said image.</value>
    [DataMember(Name="pgcrImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pgcrImage")]
    public string PgcrImage { get; set; }

    /// <summary>
    /// The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.
    /// </summary>
    /// <value>The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.</value>
    [DataMember(Name="modeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modeType")]
    public int? ModeType { get; set; }

    /// <summary>
    /// The type of play being performed in broad terms (PVP, PVE)
    /// </summary>
    /// <value>The type of play being performed in broad terms (PVP, PVE)</value>
    [DataMember(Name="activityModeCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeCategory")]
    public int? ActivityModeCategory { get; set; }

    /// <summary>
    /// If True, this mode has oppositional teams fighting against each other rather than \"Free-For-All\" or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren't team based, and then this boolean won't make much sense (the aggregation would become \"sometimes team based\"). Let's not deal with that right now.
    /// </summary>
    /// <value>If True, this mode has oppositional teams fighting against each other rather than \"Free-For-All\" or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren't team based, and then this boolean won't make much sense (the aggregation would become \"sometimes team based\"). Let's not deal with that right now.</value>
    [DataMember(Name="isTeamBased", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTeamBased")]
    public bool? IsTeamBased { get; set; }

    /// <summary>
    /// If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.
    /// </summary>
    /// <value>If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.</value>
    [DataMember(Name="isAggregateMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAggregateMode")]
    public bool? IsAggregateMode { get; set; }

    /// <summary>
    /// The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \"parent\" modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.
    /// </summary>
    /// <value>The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \"parent\" modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.</value>
    [DataMember(Name="parentHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentHashes")]
    public List<int?> ParentHashes { get; set; }

    /// <summary>
    /// A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it's worth.
    /// </summary>
    /// <value>A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it's worth.</value>
    [DataMember(Name="friendlyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "friendlyName")]
    public string FriendlyName { get; set; }

    /// <summary>
    /// If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.
    /// </summary>
    /// <value>If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.</value>
    [DataMember(Name="activityModeMappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeMappings")]
    public Dictionary<string, int?> ActivityModeMappings { get; set; }

    /// <summary>
    /// If FALSE, we want to ignore this type when we're showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.
    /// </summary>
    /// <value>If FALSE, we want to ignore this type when we're showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.</value>
    [DataMember(Name="display", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display")]
    public bool? Display { get; set; }

    /// <summary>
    /// The relative ordering of activity modes.
    /// </summary>
    /// <value>The relative ordering of activity modes.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityModeDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  PgcrImage: ").Append(PgcrImage).Append("\n");
      sb.Append("  ModeType: ").Append(ModeType).Append("\n");
      sb.Append("  ActivityModeCategory: ").Append(ActivityModeCategory).Append("\n");
      sb.Append("  IsTeamBased: ").Append(IsTeamBased).Append("\n");
      sb.Append("  IsAggregateMode: ").Append(IsAggregateMode).Append("\n");
      sb.Append("  ParentHashes: ").Append(ParentHashes).Append("\n");
      sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
      sb.Append("  ActivityModeMappings: ").Append(ActivityModeMappings).Append("\n");
      sb.Append("  Display: ").Append(Display).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
