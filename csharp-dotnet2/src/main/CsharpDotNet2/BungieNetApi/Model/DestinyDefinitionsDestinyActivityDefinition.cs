using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The static data about Activities in Destiny 2.  Note that an Activity must be combined with an ActivityMode to know - from a Gameplay perspective - what the user is \&quot;Playing\&quot;.  In most PvE activities, this is fairly straightforward. A Story Activity can only be played in the Story Activity Mode.  However, in PvP activities, the Activity alone only tells you the map being played, or the Playlist that the user chose to enter. You&#39;ll need to know the Activity Mode they&#39;re playing to know that they&#39;re playing Mode X on Map Y.  Activity Definitions tell a great deal of information about what *could* be relevant to a user: what rewards they can earn, what challenges could be performed, what modifiers could be applied. To figure out which of these properties is actually live, you&#39;ll need to combine the definition with \&quot;Live\&quot; data from one of the Destiny endpoints.  Activities also have Activity Types, but unfortunately in Destiny 2 these are even less reliable of a source of information than they were in Destiny 1. I will be looking into ways to provide more reliable sources for type information as time goes on, but for now we&#39;re going to have to deal with the limitations. See DestinyActivityTypeDefinition for more information.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityDefinition {
    /// <summary>
    /// The title, subtitle, and icon for the activity. We do a little post-processing on this to try and account for Activities where the designers have left this data too minimal to determine what activity is actually being played.
    /// </summary>
    /// <value>The title, subtitle, and icon for the activity. We do a little post-processing on this to try and account for Activities where the designers have left this data too minimal to determine what activity is actually being played.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The unadulterated form of the display properties, as they ought to be shown in the Director (if the activity appears in the director).
    /// </summary>
    /// <value>The unadulterated form of the display properties, as they ought to be shown in the Director (if the activity appears in the director).</value>
    [DataMember(Name="originalDisplayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalDisplayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }

    /// <summary>
    /// The title, subtitle, and icon for the activity as determined by Selection Screen data, if there is any for this activity. There won't be data in this field if the activity is never shown in a selection/options screen.
    /// </summary>
    /// <value>The title, subtitle, and icon for the activity as determined by Selection Screen data, if there is any for this activity. There won't be data in this field if the activity is never shown in a selection/options screen.</value>
    [DataMember(Name="selectionScreenDisplayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selectionScreenDisplayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; set; }

    /// <summary>
    /// If the activity has an icon associated with a specific release (such as a DLC), this is the path to that release's icon.
    /// </summary>
    /// <value>If the activity has an icon associated with a specific release (such as a DLC), this is the path to that release's icon.</value>
    [DataMember(Name="releaseIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releaseIcon")]
    public string ReleaseIcon { get; set; }

    /// <summary>
    /// If the activity will not be visible until a specific and known time, this will be the seconds since the Epoch when it will become visible.
    /// </summary>
    /// <value>If the activity will not be visible until a specific and known time, this will be the seconds since the Epoch when it will become visible.</value>
    [DataMember(Name="releaseTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releaseTime")]
    public int? ReleaseTime { get; set; }

    /// <summary>
    /// The difficulty level of the activity.
    /// </summary>
    /// <value>The difficulty level of the activity.</value>
    [DataMember(Name="activityLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityLevel")]
    public int? ActivityLevel { get; set; }

    /// <summary>
    /// The recommended light level for this activity.
    /// </summary>
    /// <value>The recommended light level for this activity.</value>
    [DataMember(Name="activityLightLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityLightLevel")]
    public int? ActivityLightLevel { get; set; }

    /// <summary>
    /// The hash identifier for the Destination on which this Activity is played. Use it to look up the DestinyDestinationDefinition for human readable info about the destination. A Destination can be thought of as a more specific location than a \"Place\". For instance, if the \"Place\" is Earth, the \"Destination\" would be a specific city or region on Earth.
    /// </summary>
    /// <value>The hash identifier for the Destination on which this Activity is played. Use it to look up the DestinyDestinationDefinition for human readable info about the destination. A Destination can be thought of as a more specific location than a \"Place\". For instance, if the \"Place\" is Earth, the \"Destination\" would be a specific city or region on Earth.</value>
    [DataMember(Name="destinationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationHash")]
    public int? DestinationHash { get; set; }

    /// <summary>
    /// The hash identifier for the \"Place\" on which this Activity is played. Use it to look up the DestinyPlaceDefinition for human readable info about the Place. A Place is the largest-scoped concept for location information. For instance, if the \"Place\" is Earth, the \"Destination\" would be a specific city or region on Earth.
    /// </summary>
    /// <value>The hash identifier for the \"Place\" on which this Activity is played. Use it to look up the DestinyPlaceDefinition for human readable info about the Place. A Place is the largest-scoped concept for location information. For instance, if the \"Place\" is Earth, the \"Destination\" would be a specific city or region on Earth.</value>
    [DataMember(Name="placeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "placeHash")]
    public int? PlaceHash { get; set; }

    /// <summary>
    /// The hash identifier for the Activity Type of this Activity. You may use it to look up the DestinyActivityTypeDefinition for human readable info, but be forewarned: Playlists and many PVP Map Activities will map to generic Activity Types. You'll have to use your knowledge of the Activity Mode being played to get more specific information about what the user is playing.
    /// </summary>
    /// <value>The hash identifier for the Activity Type of this Activity. You may use it to look up the DestinyActivityTypeDefinition for human readable info, but be forewarned: Playlists and many PVP Map Activities will map to generic Activity Types. You'll have to use your knowledge of the Activity Mode being played to get more specific information about what the user is playing.</value>
    [DataMember(Name="activityTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityTypeHash")]
    public int? ActivityTypeHash { get; set; }

    /// <summary>
    /// The difficulty tier of the activity.
    /// </summary>
    /// <value>The difficulty tier of the activity.</value>
    [DataMember(Name="tier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tier")]
    public int? Tier { get; set; }

    /// <summary>
    /// When Activities are completed, we generate a \"Post-Game Carnage Report\", or PGCR, with details about what happened in that activity (how many kills someone got, which team won, etc...) We use this image as the background when displaying PGCR information, and often use it when we refer to the Activity in general.
    /// </summary>
    /// <value>When Activities are completed, we generate a \"Post-Game Carnage Report\", or PGCR, with details about what happened in that activity (how many kills someone got, which team won, etc...) We use this image as the background when displaying PGCR information, and often use it when we refer to the Activity in general.</value>
    [DataMember(Name="pgcrImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pgcrImage")]
    public string PgcrImage { get; set; }

    /// <summary>
    /// The expected possible rewards for the activity. These rewards may or may not be accessible for an individual player based on their character state, the account state, and even the game's state overall. But it is a useful reference for possible rewards you can earn in the activity. These match up to rewards displayed when you hover over the Activity in the in-game Director, and often refer to Placeholder or \"Dummy\" items: items that tell you what you can earn in vague terms rather than what you'll specifically be earning (partly because the game doesn't even know what you'll earn specifically until you roll for it at the end)
    /// </summary>
    /// <value>The expected possible rewards for the activity. These rewards may or may not be accessible for an individual player based on their character state, the account state, and even the game's state overall. But it is a useful reference for possible rewards you can earn in the activity. These match up to rewards displayed when you hover over the Activity in the in-game Director, and often refer to Placeholder or \"Dummy\" items: items that tell you what you can earn in vague terms rather than what you'll specifically be earning (partly because the game doesn't even know what you'll earn specifically until you roll for it at the end)</value>
    [DataMember(Name="rewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewards")]
    public List<DestinyDefinitionsDestinyActivityRewardDefinition> Rewards { get; set; }

    /// <summary>
    /// Activities can have Modifiers, as defined in DestinyActivityModifierDefinition. These are references to the modifiers that *can* be applied to that activity, along with data that we use to determine if that modifier is actually active at any given point in time.
    /// </summary>
    /// <value>Activities can have Modifiers, as defined in DestinyActivityModifierDefinition. These are references to the modifiers that *can* be applied to that activity, along with data that we use to determine if that modifier is actually active at any given point in time.</value>
    [DataMember(Name="modifiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiers")]
    public List<DestinyDefinitionsDestinyActivityModifierReferenceDefinition> Modifiers { get; set; }

    /// <summary>
    /// If True, this Activity is actually a Playlist that refers to multiple possible specific Activities and Activity Modes. For instance, a Crucible Playlist may have references to multiple Activities (Maps) with multiple Activity Modes (specific PvP gameplay modes). If this is true, refer to the playlistItems property for the specific entries in the playlist.
    /// </summary>
    /// <value>If True, this Activity is actually a Playlist that refers to multiple possible specific Activities and Activity Modes. For instance, a Crucible Playlist may have references to multiple Activities (Maps) with multiple Activity Modes (specific PvP gameplay modes). If this is true, refer to the playlistItems property for the specific entries in the playlist.</value>
    [DataMember(Name="isPlaylist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPlaylist")]
    public bool? IsPlaylist { get; set; }

    /// <summary>
    /// An activity can have many Challenges, of which any subset of them may be active for play at any given period of time. This gives the information about the challenges and data that we use to understand when they're active and what rewards they provide. Sadly, at the moment there's no central definition for challenges: much like \"Skulls\" were in Destiny 1, these are defined on individual activities and there can be many duplicates/near duplicates across the Destiny 2 ecosystem. I have it in mind to centralize these in a future revision of the API, but we are out of time.
    /// </summary>
    /// <value>An activity can have many Challenges, of which any subset of them may be active for play at any given period of time. This gives the information about the challenges and data that we use to understand when they're active and what rewards they provide. Sadly, at the moment there's no central definition for challenges: much like \"Skulls\" were in Destiny 1, these are defined on individual activities and there can be many duplicates/near duplicates across the Destiny 2 ecosystem. I have it in mind to centralize these in a future revision of the API, but we are out of time.</value>
    [DataMember(Name="challenges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenges")]
    public List<DestinyDefinitionsDestinyActivityChallengeDefinition> Challenges { get; set; }

    /// <summary>
    /// If there are status strings related to the activity and based on internal state of the game, account, or character, then this will be the definition of those strings and the states needed in order for the strings to be shown.
    /// </summary>
    /// <value>If there are status strings related to the activity and based on internal state of the game, account, or character, then this will be the definition of those strings and the states needed in order for the strings to be shown.</value>
    [DataMember(Name="optionalUnlockStrings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optionalUnlockStrings")]
    public List<DestinyDefinitionsDestinyActivityUnlockStringDefinition> OptionalUnlockStrings { get; set; }

    /// <summary>
    /// Represents all of the possible activities that could be played in the Playlist, along with information that we can use to determine if they are active at the present time.
    /// </summary>
    /// <value>Represents all of the possible activities that could be played in the Playlist, along with information that we can use to determine if they are active at the present time.</value>
    [DataMember(Name="playlistItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playlistItems")]
    public List<DestinyDefinitionsDestinyActivityPlaylistItemDefinition> PlaylistItems { get; set; }

    /// <summary>
    /// Unfortunately, in practice this is almost never populated. In theory, this is supposed to tell which Activity Graph to show if you bring up the director while in this activity.
    /// </summary>
    /// <value>Unfortunately, in practice this is almost never populated. In theory, this is supposed to tell which Activity Graph to show if you bring up the director while in this activity.</value>
    [DataMember(Name="activityGraphList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphList")]
    public List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> ActivityGraphList { get; set; }

    /// <summary>
    /// This block of data provides information about the Activity's matchmaking attributes: how many people can join and such.
    /// </summary>
    /// <value>This block of data provides information about the Activity's matchmaking attributes: how many people can join and such.</value>
    [DataMember(Name="matchmaking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matchmaking")]
    public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition Matchmaking { get; set; }

    /// <summary>
    /// This block of data, if it exists, provides information about the guided game experience and restrictions for this activity. If it doesn't exist, the game is not able to be played as a guided game.
    /// </summary>
    /// <value>This block of data, if it exists, provides information about the guided game experience and restrictions for this activity. If it doesn't exist, the game is not able to be played as a guided game.</value>
    [DataMember(Name="guidedGame", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guidedGame")]
    public DestinyDefinitionsDestinyActivityGuidedBlockDefinition GuidedGame { get; set; }

    /// <summary>
    /// If this activity had an activity mode directly defined on it, this will be the hash of that mode.
    /// </summary>
    /// <value>If this activity had an activity mode directly defined on it, this will be the hash of that mode.</value>
    [DataMember(Name="directActivityModeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directActivityModeHash")]
    public int? DirectActivityModeHash { get; set; }

    /// <summary>
    /// If the activity had an activity mode directly defined on it, this will be the enum value of that mode.
    /// </summary>
    /// <value>If the activity had an activity mode directly defined on it, this will be the enum value of that mode.</value>
    [DataMember(Name="directActivityModeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directActivityModeType")]
    public int? DirectActivityModeType { get; set; }

    /// <summary>
    /// The set of all possible loadout requirements that could be active for this activity. Only one will be active at any given time, and you can discover which one through activity-associated data such as Milestones that have activity info on them.
    /// </summary>
    /// <value>The set of all possible loadout requirements that could be active for this activity. Only one will be active at any given time, and you can discover which one through activity-associated data such as Milestones that have activity info on them.</value>
    [DataMember(Name="loadouts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadouts")]
    public List<DestinyDefinitionsDestinyActivityLoadoutRequirementSet> Loadouts { get; set; }

    /// <summary>
    /// The hash identifiers for Activity Modes relevant to this activity.  Note that if this is a playlist, the specific playlist entry chosen will determine the actual activity modes that end up being relevant.
    /// </summary>
    /// <value>The hash identifiers for Activity Modes relevant to this activity.  Note that if this is a playlist, the specific playlist entry chosen will determine the actual activity modes that end up being relevant.</value>
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
    /// If true, this activity is a PVP activity or playlist.
    /// </summary>
    /// <value>If true, this activity is a PVP activity or playlist.</value>
    [DataMember(Name="isPvP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPvP")]
    public bool? IsPvP { get; set; }

    /// <summary>
    /// The list of phases or points of entry into an activity, along with information we can use to determine their gating and availability.
    /// </summary>
    /// <value>The list of phases or points of entry into an activity, along with information we can use to determine their gating and availability.</value>
    [DataMember(Name="insertionPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insertionPoints")]
    public List<DestinyDefinitionsDestinyActivityInsertionPointDefinition> InsertionPoints { get; set; }

    /// <summary>
    /// A list of location mappings that are affected by this activity. Pulled out of DestinyLocationDefinitions for our/your lookup convenience.
    /// </summary>
    /// <value>A list of location mappings that are affected by this activity. Pulled out of DestinyLocationDefinitions for our/your lookup convenience.</value>
    [DataMember(Name="activityLocationMappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityLocationMappings")]
    public List<DestinyConstantsDestinyEnvironmentLocationMapping> ActivityLocationMappings { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyActivityDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  OriginalDisplayProperties: ").Append(OriginalDisplayProperties).Append("\n");
      sb.Append("  SelectionScreenDisplayProperties: ").Append(SelectionScreenDisplayProperties).Append("\n");
      sb.Append("  ReleaseIcon: ").Append(ReleaseIcon).Append("\n");
      sb.Append("  ReleaseTime: ").Append(ReleaseTime).Append("\n");
      sb.Append("  ActivityLevel: ").Append(ActivityLevel).Append("\n");
      sb.Append("  ActivityLightLevel: ").Append(ActivityLightLevel).Append("\n");
      sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
      sb.Append("  PlaceHash: ").Append(PlaceHash).Append("\n");
      sb.Append("  ActivityTypeHash: ").Append(ActivityTypeHash).Append("\n");
      sb.Append("  Tier: ").Append(Tier).Append("\n");
      sb.Append("  PgcrImage: ").Append(PgcrImage).Append("\n");
      sb.Append("  Rewards: ").Append(Rewards).Append("\n");
      sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
      sb.Append("  IsPlaylist: ").Append(IsPlaylist).Append("\n");
      sb.Append("  Challenges: ").Append(Challenges).Append("\n");
      sb.Append("  OptionalUnlockStrings: ").Append(OptionalUnlockStrings).Append("\n");
      sb.Append("  PlaylistItems: ").Append(PlaylistItems).Append("\n");
      sb.Append("  ActivityGraphList: ").Append(ActivityGraphList).Append("\n");
      sb.Append("  Matchmaking: ").Append(Matchmaking).Append("\n");
      sb.Append("  GuidedGame: ").Append(GuidedGame).Append("\n");
      sb.Append("  DirectActivityModeHash: ").Append(DirectActivityModeHash).Append("\n");
      sb.Append("  DirectActivityModeType: ").Append(DirectActivityModeType).Append("\n");
      sb.Append("  Loadouts: ").Append(Loadouts).Append("\n");
      sb.Append("  ActivityModeHashes: ").Append(ActivityModeHashes).Append("\n");
      sb.Append("  ActivityModeTypes: ").Append(ActivityModeTypes).Append("\n");
      sb.Append("  IsPvP: ").Append(IsPvP).Append("\n");
      sb.Append("  InsertionPoints: ").Append(InsertionPoints).Append("\n");
      sb.Append("  ActivityLocationMappings: ").Append(ActivityLocationMappings).Append("\n");
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
