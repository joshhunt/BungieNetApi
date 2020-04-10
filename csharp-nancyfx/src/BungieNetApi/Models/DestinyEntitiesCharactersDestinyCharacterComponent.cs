using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component contains base properties of the character. You&#39;ll probably want to always request this component, but hey you do you.
    /// </summary>
    public sealed class DestinyEntitiesCharactersDestinyCharacterComponent:  IEquatable<DestinyEntitiesCharactersDestinyCharacterComponent>
    { 
        /// <summary>
        /// Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.
        /// </summary>
        public long? MembershipId { get; private set; }

        /// <summary>
        /// membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.
        /// </summary>
        public int? MembershipType { get; private set; }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// The last date that the user played Destiny.
        /// </summary>
        public DateTime? DateLastPlayed { get; private set; }

        /// <summary>
        /// If the user is currently playing, this is how long they&#39;ve been playing.
        /// </summary>
        public long? MinutesPlayedThisSession { get; private set; }

        /// <summary>
        /// If this value is 525,600, then they played Destiny for a year. Or they&#39;re a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.
        /// </summary>
        public long? MinutesPlayedTotal { get; private set; }

        /// <summary>
        /// The user&#39;s calculated \&quot;Light Level\&quot;. Light level is an indicator of your power that mostly matters in the end game, once you&#39;ve reached the maximum character level: it&#39;s a level that&#39;s dependent on the average Attack/Defense power of your items.
        /// </summary>
        public int? Light { get; private set; }

        /// <summary>
        /// Your character&#39;s stats, such as Agility, Resilience, etc... *not* historical stats.  You&#39;ll have to call a different endpoint for those.
        /// </summary>
        public Dictionary<string, int?> Stats { get; private set; }

        /// <summary>
        /// Use this hash to look up the character&#39;s DestinyRaceDefinition.
        /// </summary>
        public int? RaceHash { get; private set; }

        /// <summary>
        /// Use this hash to look up the character&#39;s DestinyGenderDefinition.
        /// </summary>
        public int? GenderHash { get; private set; }

        /// <summary>
        /// Use this hash to look up the character&#39;s DestinyClassDefinition.
        /// </summary>
        public int? ClassHash { get; private set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character&#39;s race.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
        /// </summary>
        public int? RaceType { get; private set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character&#39;s class.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
        /// </summary>
        public int? ClassType { get; private set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character&#39;s Gender.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it&#39;s an enumeration and not a boolean. Fight me.
        /// </summary>
        public int? GenderType { get; private set; }

        /// <summary>
        /// A shortcut path to the user&#39;s currently equipped emblem image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        public string EmblemPath { get; private set; }

        /// <summary>
        /// A shortcut path to the user&#39;s currently equipped emblem background image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        public string EmblemBackgroundPath { get; private set; }

        /// <summary>
        /// The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
        /// </summary>
        public int? EmblemHash { get; private set; }

        /// <summary>
        /// A shortcut for getting the background color of the user&#39;s currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.
        /// </summary>
        public DestinyMiscDestinyColor EmblemColor { get; private set; }

        /// <summary>
        /// The progression that indicates your character&#39;s level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.
        /// </summary>
        public DestinyDestinyProgression LevelProgression { get; private set; }

        /// <summary>
        /// The \&quot;base\&quot; level of your character, not accounting for any light level.
        /// </summary>
        public int? BaseCharacterLevel { get; private set; }

        /// <summary>
        /// A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.
        /// </summary>
        public float? PercentToNextLevel { get; private set; }

        /// <summary>
        /// If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
        /// </summary>
        public int? TitleRecordHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesCharactersDestinyCharacterComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesCharactersDestinyCharacterComponent()
        {
        }

        private DestinyEntitiesCharactersDestinyCharacterComponent(long? MembershipId, int? MembershipType, long? CharacterId, DateTime? DateLastPlayed, long? MinutesPlayedThisSession, long? MinutesPlayedTotal, int? Light, Dictionary<string, int?> Stats, int? RaceHash, int? GenderHash, int? ClassHash, int? RaceType, int? ClassType, int? GenderType, string EmblemPath, string EmblemBackgroundPath, int? EmblemHash, DestinyMiscDestinyColor EmblemColor, DestinyDestinyProgression LevelProgression, int? BaseCharacterLevel, float? PercentToNextLevel, int? TitleRecordHash)
        {
            
            this.MembershipId = MembershipId;
            
            this.MembershipType = MembershipType;
            
            this.CharacterId = CharacterId;
            
            this.DateLastPlayed = DateLastPlayed;
            
            this.MinutesPlayedThisSession = MinutesPlayedThisSession;
            
            this.MinutesPlayedTotal = MinutesPlayedTotal;
            
            this.Light = Light;
            
            this.Stats = Stats;
            
            this.RaceHash = RaceHash;
            
            this.GenderHash = GenderHash;
            
            this.ClassHash = ClassHash;
            
            this.RaceType = RaceType;
            
            this.ClassType = ClassType;
            
            this.GenderType = GenderType;
            
            this.EmblemPath = EmblemPath;
            
            this.EmblemBackgroundPath = EmblemBackgroundPath;
            
            this.EmblemHash = EmblemHash;
            
            this.EmblemColor = EmblemColor;
            
            this.LevelProgression = LevelProgression;
            
            this.BaseCharacterLevel = BaseCharacterLevel;
            
            this.PercentToNextLevel = PercentToNextLevel;
            
            this.TitleRecordHash = TitleRecordHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesCharactersDestinyCharacterComponent.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterComponentBuilder</returns>
        public static DestinyEntitiesCharactersDestinyCharacterComponentBuilder Builder()
        {
            return new DestinyEntitiesCharactersDestinyCharacterComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesCharactersDestinyCharacterComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterComponentBuilder</returns>
        public DestinyEntitiesCharactersDestinyCharacterComponentBuilder With()
        {
            return Builder()
                .MembershipId(MembershipId)
                .MembershipType(MembershipType)
                .CharacterId(CharacterId)
                .DateLastPlayed(DateLastPlayed)
                .MinutesPlayedThisSession(MinutesPlayedThisSession)
                .MinutesPlayedTotal(MinutesPlayedTotal)
                .Light(Light)
                .Stats(Stats)
                .RaceHash(RaceHash)
                .GenderHash(GenderHash)
                .ClassHash(ClassHash)
                .RaceType(RaceType)
                .ClassType(ClassType)
                .GenderType(GenderType)
                .EmblemPath(EmblemPath)
                .EmblemBackgroundPath(EmblemBackgroundPath)
                .EmblemHash(EmblemHash)
                .EmblemColor(EmblemColor)
                .LevelProgression(LevelProgression)
                .BaseCharacterLevel(BaseCharacterLevel)
                .PercentToNextLevel(PercentToNextLevel)
                .TitleRecordHash(TitleRecordHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesCharactersDestinyCharacterComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesCharactersDestinyCharacterComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesCharactersDestinyCharacterComponent left, DestinyEntitiesCharactersDestinyCharacterComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesCharactersDestinyCharacterComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesCharactersDestinyCharacterComponent left, DestinyEntitiesCharactersDestinyCharacterComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesCharactersDestinyCharacterComponent.
        /// </summary>
        public sealed class DestinyEntitiesCharactersDestinyCharacterComponentBuilder
        {
            private long? _MembershipId;
            private int? _MembershipType;
            private long? _CharacterId;
            private DateTime? _DateLastPlayed;
            private long? _MinutesPlayedThisSession;
            private long? _MinutesPlayedTotal;
            private int? _Light;
            private Dictionary<string, int?> _Stats;
            private int? _RaceHash;
            private int? _GenderHash;
            private int? _ClassHash;
            private int? _RaceType;
            private int? _ClassType;
            private int? _GenderType;
            private string _EmblemPath;
            private string _EmblemBackgroundPath;
            private int? _EmblemHash;
            private DestinyMiscDestinyColor _EmblemColor;
            private DestinyDestinyProgression _LevelProgression;
            private int? _BaseCharacterLevel;
            private float? _PercentToNextLevel;
            private int? _TitleRecordHash;

            internal DestinyEntitiesCharactersDestinyCharacterComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.MembershipId property.
            /// </summary>
            /// <param name="value">Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.MembershipType property.
            /// </summary>
            /// <param name="value">membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.CharacterId property.
            /// </summary>
            /// <param name="value">The unique identifier for the character.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.DateLastPlayed property.
            /// </summary>
            /// <param name="value">The last date that the user played Destiny.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder DateLastPlayed(DateTime? value)
            {
                _DateLastPlayed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.MinutesPlayedThisSession property.
            /// </summary>
            /// <param name="value">If the user is currently playing, this is how long they&#39;ve been playing.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder MinutesPlayedThisSession(long? value)
            {
                _MinutesPlayedThisSession = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.MinutesPlayedTotal property.
            /// </summary>
            /// <param name="value">If this value is 525,600, then they played Destiny for a year. Or they&#39;re a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder MinutesPlayedTotal(long? value)
            {
                _MinutesPlayedTotal = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.Light property.
            /// </summary>
            /// <param name="value">The user&#39;s calculated \&quot;Light Level\&quot;. Light level is an indicator of your power that mostly matters in the end game, once you&#39;ve reached the maximum character level: it&#39;s a level that&#39;s dependent on the average Attack/Defense power of your items.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder Light(int? value)
            {
                _Light = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.Stats property.
            /// </summary>
            /// <param name="value">Your character&#39;s stats, such as Agility, Resilience, etc... *not* historical stats.  You&#39;ll have to call a different endpoint for those.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder Stats(Dictionary<string, int?> value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.RaceHash property.
            /// </summary>
            /// <param name="value">Use this hash to look up the character&#39;s DestinyRaceDefinition.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder RaceHash(int? value)
            {
                _RaceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.GenderHash property.
            /// </summary>
            /// <param name="value">Use this hash to look up the character&#39;s DestinyGenderDefinition.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder GenderHash(int? value)
            {
                _GenderHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.ClassHash property.
            /// </summary>
            /// <param name="value">Use this hash to look up the character&#39;s DestinyClassDefinition.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder ClassHash(int? value)
            {
                _ClassHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.RaceType property.
            /// </summary>
            /// <param name="value">Mostly for historical purposes at this point, this is an enumeration for the character&#39;s race.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder RaceType(int? value)
            {
                _RaceType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.ClassType property.
            /// </summary>
            /// <param name="value">Mostly for historical purposes at this point, this is an enumeration for the character&#39;s class.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder ClassType(int? value)
            {
                _ClassType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.GenderType property.
            /// </summary>
            /// <param name="value">Mostly for historical purposes at this point, this is an enumeration for the character&#39;s Gender.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it&#39;s an enumeration and not a boolean. Fight me.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder GenderType(int? value)
            {
                _GenderType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.EmblemPath property.
            /// </summary>
            /// <param name="value">A shortcut path to the user&#39;s currently equipped emblem image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder EmblemPath(string value)
            {
                _EmblemPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.EmblemBackgroundPath property.
            /// </summary>
            /// <param name="value">A shortcut path to the user&#39;s currently equipped emblem background image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder EmblemBackgroundPath(string value)
            {
                _EmblemBackgroundPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.EmblemHash property.
            /// </summary>
            /// <param name="value">The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder EmblemHash(int? value)
            {
                _EmblemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.EmblemColor property.
            /// </summary>
            /// <param name="value">A shortcut for getting the background color of the user&#39;s currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder EmblemColor(DestinyMiscDestinyColor value)
            {
                _EmblemColor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.LevelProgression property.
            /// </summary>
            /// <param name="value">The progression that indicates your character&#39;s level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder LevelProgression(DestinyDestinyProgression value)
            {
                _LevelProgression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.BaseCharacterLevel property.
            /// </summary>
            /// <param name="value">The \&quot;base\&quot; level of your character, not accounting for any light level.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder BaseCharacterLevel(int? value)
            {
                _BaseCharacterLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.PercentToNextLevel property.
            /// </summary>
            /// <param name="value">A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder PercentToNextLevel(float? value)
            {
                _PercentToNextLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterComponent.TitleRecordHash property.
            /// </summary>
            /// <param name="value">If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.</param>
            public DestinyEntitiesCharactersDestinyCharacterComponentBuilder TitleRecordHash(int? value)
            {
                _TitleRecordHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesCharactersDestinyCharacterComponent.
            /// </summary>
            /// <returns>DestinyEntitiesCharactersDestinyCharacterComponent</returns>
            public DestinyEntitiesCharactersDestinyCharacterComponent Build()
            {
                Validate();
                return new DestinyEntitiesCharactersDestinyCharacterComponent(
                    MembershipId: _MembershipId,
                    MembershipType: _MembershipType,
                    CharacterId: _CharacterId,
                    DateLastPlayed: _DateLastPlayed,
                    MinutesPlayedThisSession: _MinutesPlayedThisSession,
                    MinutesPlayedTotal: _MinutesPlayedTotal,
                    Light: _Light,
                    Stats: _Stats,
                    RaceHash: _RaceHash,
                    GenderHash: _GenderHash,
                    ClassHash: _ClassHash,
                    RaceType: _RaceType,
                    ClassType: _ClassType,
                    GenderType: _GenderType,
                    EmblemPath: _EmblemPath,
                    EmblemBackgroundPath: _EmblemBackgroundPath,
                    EmblemHash: _EmblemHash,
                    EmblemColor: _EmblemColor,
                    LevelProgression: _LevelProgression,
                    BaseCharacterLevel: _BaseCharacterLevel,
                    PercentToNextLevel: _PercentToNextLevel,
                    TitleRecordHash: _TitleRecordHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}