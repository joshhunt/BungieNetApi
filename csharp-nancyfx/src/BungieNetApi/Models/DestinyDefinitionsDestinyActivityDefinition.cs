using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The static data about Activities in Destiny 2.  Note that an Activity must be combined with an ActivityMode to know - from a Gameplay perspective - what the user is \&quot;Playing\&quot;.  In most PvE activities, this is fairly straightforward. A Story Activity can only be played in the Story Activity Mode.  However, in PvP activities, the Activity alone only tells you the map being played, or the Playlist that the user chose to enter. You&#39;ll need to know the Activity Mode they&#39;re playing to know that they&#39;re playing Mode X on Map Y.  Activity Definitions tell a great deal of information about what *could* be relevant to a user: what rewards they can earn, what challenges could be performed, what modifiers could be applied. To figure out which of these properties is actually live, you&#39;ll need to combine the definition with \&quot;Live\&quot; data from one of the Destiny endpoints.  Activities also have Activity Types, but unfortunately in Destiny 2 these are even less reliable of a source of information than they were in Destiny 1. I will be looking into ways to provide more reliable sources for type information as time goes on, but for now we&#39;re going to have to deal with the limitations. See DestinyActivityTypeDefinition for more information.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityDefinition:  IEquatable<DestinyDefinitionsDestinyActivityDefinition>
    { 
        /// <summary>
        /// The title, subtitle, and icon for the activity. We do a little post-processing on this to try and account for Activities where the designers have left this data too minimal to determine what activity is actually being played.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The unadulterated form of the display properties, as they ought to be shown in the Director (if the activity appears in the director).
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; private set; }

        /// <summary>
        /// The title, subtitle, and icon for the activity as determined by Selection Screen data, if there is any for this activity. There won&#39;t be data in this field if the activity is never shown in a selection/options screen.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; private set; }

        /// <summary>
        /// If the activity has an icon associated with a specific release (such as a DLC), this is the path to that release&#39;s icon.
        /// </summary>
        public string ReleaseIcon { get; private set; }

        /// <summary>
        /// If the activity will not be visible until a specific and known time, this will be the seconds since the Epoch when it will become visible.
        /// </summary>
        public int? ReleaseTime { get; private set; }

        /// <summary>
        /// The difficulty level of the activity.
        /// </summary>
        public int? ActivityLevel { get; private set; }

        /// <summary>
        /// The recommended light level for this activity.
        /// </summary>
        public int? ActivityLightLevel { get; private set; }

        /// <summary>
        /// The hash identifier for the Destination on which this Activity is played. Use it to look up the DestinyDestinationDefinition for human readable info about the destination. A Destination can be thought of as a more specific location than a \&quot;Place\&quot;. For instance, if the \&quot;Place\&quot; is Earth, the \&quot;Destination\&quot; would be a specific city or region on Earth.
        /// </summary>
        public int? DestinationHash { get; private set; }

        /// <summary>
        /// The hash identifier for the \&quot;Place\&quot; on which this Activity is played. Use it to look up the DestinyPlaceDefinition for human readable info about the Place. A Place is the largest-scoped concept for location information. For instance, if the \&quot;Place\&quot; is Earth, the \&quot;Destination\&quot; would be a specific city or region on Earth.
        /// </summary>
        public int? PlaceHash { get; private set; }

        /// <summary>
        /// The hash identifier for the Activity Type of this Activity. You may use it to look up the DestinyActivityTypeDefinition for human readable info, but be forewarned: Playlists and many PVP Map Activities will map to generic Activity Types. You&#39;ll have to use your knowledge of the Activity Mode being played to get more specific information about what the user is playing.
        /// </summary>
        public int? ActivityTypeHash { get; private set; }

        /// <summary>
        /// The difficulty tier of the activity.
        /// </summary>
        public int? Tier { get; private set; }

        /// <summary>
        /// When Activities are completed, we generate a \&quot;Post-Game Carnage Report\&quot;, or PGCR, with details about what happened in that activity (how many kills someone got, which team won, etc...) We use this image as the background when displaying PGCR information, and often use it when we refer to the Activity in general.
        /// </summary>
        public string PgcrImage { get; private set; }

        /// <summary>
        /// The expected possible rewards for the activity. These rewards may or may not be accessible for an individual player based on their character state, the account state, and even the game&#39;s state overall. But it is a useful reference for possible rewards you can earn in the activity. These match up to rewards displayed when you hover over the Activity in the in-game Director, and often refer to Placeholder or \&quot;Dummy\&quot; items: items that tell you what you can earn in vague terms rather than what you&#39;ll specifically be earning (partly because the game doesn&#39;t even know what you&#39;ll earn specifically until you roll for it at the end)
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityRewardDefinition> Rewards { get; private set; }

        /// <summary>
        /// Activities can have Modifiers, as defined in DestinyActivityModifierDefinition. These are references to the modifiers that *can* be applied to that activity, along with data that we use to determine if that modifier is actually active at any given point in time.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityModifierReferenceDefinition> Modifiers { get; private set; }

        /// <summary>
        /// If True, this Activity is actually a Playlist that refers to multiple possible specific Activities and Activity Modes. For instance, a Crucible Playlist may have references to multiple Activities (Maps) with multiple Activity Modes (specific PvP gameplay modes). If this is true, refer to the playlistItems property for the specific entries in the playlist.
        /// </summary>
        public bool? IsPlaylist { get; private set; }

        /// <summary>
        /// An activity can have many Challenges, of which any subset of them may be active for play at any given period of time. This gives the information about the challenges and data that we use to understand when they&#39;re active and what rewards they provide. Sadly, at the moment there&#39;s no central definition for challenges: much like \&quot;Skulls\&quot; were in Destiny 1, these are defined on individual activities and there can be many duplicates/near duplicates across the Destiny 2 ecosystem. I have it in mind to centralize these in a future revision of the API, but we are out of time.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityChallengeDefinition> Challenges { get; private set; }

        /// <summary>
        /// If there are status strings related to the activity and based on internal state of the game, account, or character, then this will be the definition of those strings and the states needed in order for the strings to be shown.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityUnlockStringDefinition> OptionalUnlockStrings { get; private set; }

        /// <summary>
        /// Represents all of the possible activities that could be played in the Playlist, along with information that we can use to determine if they are active at the present time.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityPlaylistItemDefinition> PlaylistItems { get; private set; }

        /// <summary>
        /// Unfortunately, in practice this is almost never populated. In theory, this is supposed to tell which Activity Graph to show if you bring up the director while in this activity.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> ActivityGraphList { get; private set; }

        /// <summary>
        /// This block of data provides information about the Activity&#39;s matchmaking attributes: how many people can join and such.
        /// </summary>
        public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition Matchmaking { get; private set; }

        /// <summary>
        /// This block of data, if it exists, provides information about the guided game experience and restrictions for this activity. If it doesn&#39;t exist, the game is not able to be played as a guided game.
        /// </summary>
        public DestinyDefinitionsDestinyActivityGuidedBlockDefinition GuidedGame { get; private set; }

        /// <summary>
        /// If this activity had an activity mode directly defined on it, this will be the hash of that mode.
        /// </summary>
        public int? DirectActivityModeHash { get; private set; }

        /// <summary>
        /// If the activity had an activity mode directly defined on it, this will be the enum value of that mode.
        /// </summary>
        public DirectActivityModeTypeEnum? DirectActivityModeType { get; private set; }

        /// <summary>
        /// The set of all possible loadout requirements that could be active for this activity. Only one will be active at any given time, and you can discover which one through activity-associated data such as Milestones that have activity info on them.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityLoadoutRequirementSet> Loadouts { get; private set; }

        /// <summary>
        /// The hash identifiers for Activity Modes relevant to this activity.  Note that if this is a playlist, the specific playlist entry chosen will determine the actual activity modes that end up being relevant.
        /// </summary>
        public List<int?> ActivityModeHashes { get; private set; }

        /// <summary>
        /// The activity modes - if any - in enum form. Because we can&#39;t seem to escape the enums.
        /// </summary>
        public List<int?> ActivityModeTypes { get; private set; }

        /// <summary>
        /// If true, this activity is a PVP activity or playlist.
        /// </summary>
        public bool? IsPvP { get; private set; }

        /// <summary>
        /// The list of phases or points of entry into an activity, along with information we can use to determine their gating and availability.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityInsertionPointDefinition> InsertionPoints { get; private set; }

        /// <summary>
        /// A list of location mappings that are affected by this activity. Pulled out of DestinyLocationDefinitions for our/your lookup convenience.
        /// </summary>
        public List<DestinyConstantsDestinyEnvironmentLocationMapping> ActivityLocationMappings { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition OriginalDisplayProperties, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties, string ReleaseIcon, int? ReleaseTime, int? ActivityLevel, int? ActivityLightLevel, int? DestinationHash, int? PlaceHash, int? ActivityTypeHash, int? Tier, string PgcrImage, List<DestinyDefinitionsDestinyActivityRewardDefinition> Rewards, List<DestinyDefinitionsDestinyActivityModifierReferenceDefinition> Modifiers, bool? IsPlaylist, List<DestinyDefinitionsDestinyActivityChallengeDefinition> Challenges, List<DestinyDefinitionsDestinyActivityUnlockStringDefinition> OptionalUnlockStrings, List<DestinyDefinitionsDestinyActivityPlaylistItemDefinition> PlaylistItems, List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> ActivityGraphList, DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition Matchmaking, DestinyDefinitionsDestinyActivityGuidedBlockDefinition GuidedGame, int? DirectActivityModeHash, DirectActivityModeTypeEnum? DirectActivityModeType, List<DestinyDefinitionsDestinyActivityLoadoutRequirementSet> Loadouts, List<int?> ActivityModeHashes, List<int?> ActivityModeTypes, bool? IsPvP, List<DestinyDefinitionsDestinyActivityInsertionPointDefinition> InsertionPoints, List<DestinyConstantsDestinyEnvironmentLocationMapping> ActivityLocationMappings, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.OriginalDisplayProperties = OriginalDisplayProperties;
            
            this.SelectionScreenDisplayProperties = SelectionScreenDisplayProperties;
            
            this.ReleaseIcon = ReleaseIcon;
            
            this.ReleaseTime = ReleaseTime;
            
            this.ActivityLevel = ActivityLevel;
            
            this.ActivityLightLevel = ActivityLightLevel;
            
            this.DestinationHash = DestinationHash;
            
            this.PlaceHash = PlaceHash;
            
            this.ActivityTypeHash = ActivityTypeHash;
            
            this.Tier = Tier;
            
            this.PgcrImage = PgcrImage;
            
            this.Rewards = Rewards;
            
            this.Modifiers = Modifiers;
            
            this.IsPlaylist = IsPlaylist;
            
            this.Challenges = Challenges;
            
            this.OptionalUnlockStrings = OptionalUnlockStrings;
            
            this.PlaylistItems = PlaylistItems;
            
            this.ActivityGraphList = ActivityGraphList;
            
            this.Matchmaking = Matchmaking;
            
            this.GuidedGame = GuidedGame;
            
            this.DirectActivityModeHash = DirectActivityModeHash;
            
            this.DirectActivityModeType = DirectActivityModeType;
            
            this.Loadouts = Loadouts;
            
            this.ActivityModeHashes = ActivityModeHashes;
            
            this.ActivityModeTypes = ActivityModeTypes;
            
            this.IsPvP = IsPvP;
            
            this.InsertionPoints = InsertionPoints;
            
            this.ActivityLocationMappings = ActivityLocationMappings;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .OriginalDisplayProperties(OriginalDisplayProperties)
                .SelectionScreenDisplayProperties(SelectionScreenDisplayProperties)
                .ReleaseIcon(ReleaseIcon)
                .ReleaseTime(ReleaseTime)
                .ActivityLevel(ActivityLevel)
                .ActivityLightLevel(ActivityLightLevel)
                .DestinationHash(DestinationHash)
                .PlaceHash(PlaceHash)
                .ActivityTypeHash(ActivityTypeHash)
                .Tier(Tier)
                .PgcrImage(PgcrImage)
                .Rewards(Rewards)
                .Modifiers(Modifiers)
                .IsPlaylist(IsPlaylist)
                .Challenges(Challenges)
                .OptionalUnlockStrings(OptionalUnlockStrings)
                .PlaylistItems(PlaylistItems)
                .ActivityGraphList(ActivityGraphList)
                .Matchmaking(Matchmaking)
                .GuidedGame(GuidedGame)
                .DirectActivityModeHash(DirectActivityModeHash)
                .DirectActivityModeType(DirectActivityModeType)
                .Loadouts(Loadouts)
                .ActivityModeHashes(ActivityModeHashes)
                .ActivityModeTypes(ActivityModeTypes)
                .IsPvP(IsPvP)
                .InsertionPoints(InsertionPoints)
                .ActivityLocationMappings(ActivityLocationMappings)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityDefinition left, DestinyDefinitionsDestinyActivityDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityDefinition left, DestinyDefinitionsDestinyActivityDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _OriginalDisplayProperties;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _SelectionScreenDisplayProperties;
            private string _ReleaseIcon;
            private int? _ReleaseTime;
            private int? _ActivityLevel;
            private int? _ActivityLightLevel;
            private int? _DestinationHash;
            private int? _PlaceHash;
            private int? _ActivityTypeHash;
            private int? _Tier;
            private string _PgcrImage;
            private List<DestinyDefinitionsDestinyActivityRewardDefinition> _Rewards;
            private List<DestinyDefinitionsDestinyActivityModifierReferenceDefinition> _Modifiers;
            private bool? _IsPlaylist;
            private List<DestinyDefinitionsDestinyActivityChallengeDefinition> _Challenges;
            private List<DestinyDefinitionsDestinyActivityUnlockStringDefinition> _OptionalUnlockStrings;
            private List<DestinyDefinitionsDestinyActivityPlaylistItemDefinition> _PlaylistItems;
            private List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> _ActivityGraphList;
            private DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition _Matchmaking;
            private DestinyDefinitionsDestinyActivityGuidedBlockDefinition _GuidedGame;
            private int? _DirectActivityModeHash;
            private DirectActivityModeTypeEnum? _DirectActivityModeType;
            private List<DestinyDefinitionsDestinyActivityLoadoutRequirementSet> _Loadouts;
            private List<int?> _ActivityModeHashes;
            private List<int?> _ActivityModeTypes;
            private bool? _IsPvP;
            private List<DestinyDefinitionsDestinyActivityInsertionPointDefinition> _InsertionPoints;
            private List<DestinyConstantsDestinyEnvironmentLocationMapping> _ActivityLocationMappings;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyActivityDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The title, subtitle, and icon for the activity. We do a little post-processing on this to try and account for Activities where the designers have left this data too minimal to determine what activity is actually being played.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.OriginalDisplayProperties property.
            /// </summary>
            /// <param name="value">The unadulterated form of the display properties, as they ought to be shown in the Director (if the activity appears in the director).</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder OriginalDisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _OriginalDisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.SelectionScreenDisplayProperties property.
            /// </summary>
            /// <param name="value">The title, subtitle, and icon for the activity as determined by Selection Screen data, if there is any for this activity. There won&#39;t be data in this field if the activity is never shown in a selection/options screen.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder SelectionScreenDisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _SelectionScreenDisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ReleaseIcon property.
            /// </summary>
            /// <param name="value">If the activity has an icon associated with a specific release (such as a DLC), this is the path to that release&#39;s icon.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ReleaseIcon(string value)
            {
                _ReleaseIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ReleaseTime property.
            /// </summary>
            /// <param name="value">If the activity will not be visible until a specific and known time, this will be the seconds since the Epoch when it will become visible.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ReleaseTime(int? value)
            {
                _ReleaseTime = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityLevel property.
            /// </summary>
            /// <param name="value">The difficulty level of the activity.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityLevel(int? value)
            {
                _ActivityLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityLightLevel property.
            /// </summary>
            /// <param name="value">The recommended light level for this activity.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityLightLevel(int? value)
            {
                _ActivityLightLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.DestinationHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the Destination on which this Activity is played. Use it to look up the DestinyDestinationDefinition for human readable info about the destination. A Destination can be thought of as a more specific location than a \&quot;Place\&quot;. For instance, if the \&quot;Place\&quot; is Earth, the \&quot;Destination\&quot; would be a specific city or region on Earth.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.PlaceHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the \&quot;Place\&quot; on which this Activity is played. Use it to look up the DestinyPlaceDefinition for human readable info about the Place. A Place is the largest-scoped concept for location information. For instance, if the \&quot;Place\&quot; is Earth, the \&quot;Destination\&quot; would be a specific city or region on Earth.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder PlaceHash(int? value)
            {
                _PlaceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityTypeHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the Activity Type of this Activity. You may use it to look up the DestinyActivityTypeDefinition for human readable info, but be forewarned: Playlists and many PVP Map Activities will map to generic Activity Types. You&#39;ll have to use your knowledge of the Activity Mode being played to get more specific information about what the user is playing.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityTypeHash(int? value)
            {
                _ActivityTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Tier property.
            /// </summary>
            /// <param name="value">The difficulty tier of the activity.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Tier(int? value)
            {
                _Tier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.PgcrImage property.
            /// </summary>
            /// <param name="value">When Activities are completed, we generate a \&quot;Post-Game Carnage Report\&quot;, or PGCR, with details about what happened in that activity (how many kills someone got, which team won, etc...) We use this image as the background when displaying PGCR information, and often use it when we refer to the Activity in general.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder PgcrImage(string value)
            {
                _PgcrImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Rewards property.
            /// </summary>
            /// <param name="value">The expected possible rewards for the activity. These rewards may or may not be accessible for an individual player based on their character state, the account state, and even the game&#39;s state overall. But it is a useful reference for possible rewards you can earn in the activity. These match up to rewards displayed when you hover over the Activity in the in-game Director, and often refer to Placeholder or \&quot;Dummy\&quot; items: items that tell you what you can earn in vague terms rather than what you&#39;ll specifically be earning (partly because the game doesn&#39;t even know what you&#39;ll earn specifically until you roll for it at the end)</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Rewards(List<DestinyDefinitionsDestinyActivityRewardDefinition> value)
            {
                _Rewards = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Modifiers property.
            /// </summary>
            /// <param name="value">Activities can have Modifiers, as defined in DestinyActivityModifierDefinition. These are references to the modifiers that *can* be applied to that activity, along with data that we use to determine if that modifier is actually active at any given point in time.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Modifiers(List<DestinyDefinitionsDestinyActivityModifierReferenceDefinition> value)
            {
                _Modifiers = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.IsPlaylist property.
            /// </summary>
            /// <param name="value">If True, this Activity is actually a Playlist that refers to multiple possible specific Activities and Activity Modes. For instance, a Crucible Playlist may have references to multiple Activities (Maps) with multiple Activity Modes (specific PvP gameplay modes). If this is true, refer to the playlistItems property for the specific entries in the playlist.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder IsPlaylist(bool? value)
            {
                _IsPlaylist = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Challenges property.
            /// </summary>
            /// <param name="value">An activity can have many Challenges, of which any subset of them may be active for play at any given period of time. This gives the information about the challenges and data that we use to understand when they&#39;re active and what rewards they provide. Sadly, at the moment there&#39;s no central definition for challenges: much like \&quot;Skulls\&quot; were in Destiny 1, these are defined on individual activities and there can be many duplicates/near duplicates across the Destiny 2 ecosystem. I have it in mind to centralize these in a future revision of the API, but we are out of time.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Challenges(List<DestinyDefinitionsDestinyActivityChallengeDefinition> value)
            {
                _Challenges = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.OptionalUnlockStrings property.
            /// </summary>
            /// <param name="value">If there are status strings related to the activity and based on internal state of the game, account, or character, then this will be the definition of those strings and the states needed in order for the strings to be shown.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder OptionalUnlockStrings(List<DestinyDefinitionsDestinyActivityUnlockStringDefinition> value)
            {
                _OptionalUnlockStrings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.PlaylistItems property.
            /// </summary>
            /// <param name="value">Represents all of the possible activities that could be played in the Playlist, along with information that we can use to determine if they are active at the present time.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder PlaylistItems(List<DestinyDefinitionsDestinyActivityPlaylistItemDefinition> value)
            {
                _PlaylistItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityGraphList property.
            /// </summary>
            /// <param name="value">Unfortunately, in practice this is almost never populated. In theory, this is supposed to tell which Activity Graph to show if you bring up the director while in this activity.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityGraphList(List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> value)
            {
                _ActivityGraphList = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Matchmaking property.
            /// </summary>
            /// <param name="value">This block of data provides information about the Activity&#39;s matchmaking attributes: how many people can join and such.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Matchmaking(DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition value)
            {
                _Matchmaking = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.GuidedGame property.
            /// </summary>
            /// <param name="value">This block of data, if it exists, provides information about the guided game experience and restrictions for this activity. If it doesn&#39;t exist, the game is not able to be played as a guided game.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder GuidedGame(DestinyDefinitionsDestinyActivityGuidedBlockDefinition value)
            {
                _GuidedGame = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.DirectActivityModeHash property.
            /// </summary>
            /// <param name="value">If this activity had an activity mode directly defined on it, this will be the hash of that mode.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder DirectActivityModeHash(int? value)
            {
                _DirectActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.DirectActivityModeType property.
            /// </summary>
            /// <param name="value">If the activity had an activity mode directly defined on it, this will be the enum value of that mode.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder DirectActivityModeType(DirectActivityModeTypeEnum? value)
            {
                _DirectActivityModeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Loadouts property.
            /// </summary>
            /// <param name="value">The set of all possible loadout requirements that could be active for this activity. Only one will be active at any given time, and you can discover which one through activity-associated data such as Milestones that have activity info on them.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Loadouts(List<DestinyDefinitionsDestinyActivityLoadoutRequirementSet> value)
            {
                _Loadouts = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityModeHashes property.
            /// </summary>
            /// <param name="value">The hash identifiers for Activity Modes relevant to this activity.  Note that if this is a playlist, the specific playlist entry chosen will determine the actual activity modes that end up being relevant.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityModeHashes(List<int?> value)
            {
                _ActivityModeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityModeTypes property.
            /// </summary>
            /// <param name="value">The activity modes - if any - in enum form. Because we can&#39;t seem to escape the enums.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityModeTypes(List<int?> value)
            {
                _ActivityModeTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.IsPvP property.
            /// </summary>
            /// <param name="value">If true, this activity is a PVP activity or playlist.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder IsPvP(bool? value)
            {
                _IsPvP = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.InsertionPoints property.
            /// </summary>
            /// <param name="value">The list of phases or points of entry into an activity, along with information we can use to determine their gating and availability.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder InsertionPoints(List<DestinyDefinitionsDestinyActivityInsertionPointDefinition> value)
            {
                _InsertionPoints = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.ActivityLocationMappings property.
            /// </summary>
            /// <param name="value">A list of location mappings that are affected by this activity. Pulled out of DestinyLocationDefinitions for our/your lookup convenience.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder ActivityLocationMappings(List<DestinyConstantsDestinyEnvironmentLocationMapping> value)
            {
                _ActivityLocationMappings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyActivityDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityDefinition</returns>
            public DestinyDefinitionsDestinyActivityDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityDefinition(
                    DisplayProperties: _DisplayProperties,
                    OriginalDisplayProperties: _OriginalDisplayProperties,
                    SelectionScreenDisplayProperties: _SelectionScreenDisplayProperties,
                    ReleaseIcon: _ReleaseIcon,
                    ReleaseTime: _ReleaseTime,
                    ActivityLevel: _ActivityLevel,
                    ActivityLightLevel: _ActivityLightLevel,
                    DestinationHash: _DestinationHash,
                    PlaceHash: _PlaceHash,
                    ActivityTypeHash: _ActivityTypeHash,
                    Tier: _Tier,
                    PgcrImage: _PgcrImage,
                    Rewards: _Rewards,
                    Modifiers: _Modifiers,
                    IsPlaylist: _IsPlaylist,
                    Challenges: _Challenges,
                    OptionalUnlockStrings: _OptionalUnlockStrings,
                    PlaylistItems: _PlaylistItems,
                    ActivityGraphList: _ActivityGraphList,
                    Matchmaking: _Matchmaking,
                    GuidedGame: _GuidedGame,
                    DirectActivityModeHash: _DirectActivityModeHash,
                    DirectActivityModeType: _DirectActivityModeType,
                    Loadouts: _Loadouts,
                    ActivityModeHashes: _ActivityModeHashes,
                    ActivityModeTypes: _ActivityModeTypes,
                    IsPvP: _IsPvP,
                    InsertionPoints: _InsertionPoints,
                    ActivityLocationMappings: _ActivityLocationMappings,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum DirectActivityModeTypeEnum { _0, _2, _3, _4, _5, _6, _7, _9, _10, _11, _12, _13, _15, _16, _17, _18, _19, _20, _21, _22, _24, _25, _26, _27, _28, _29, _30, _31, _32, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84 };
    }
}