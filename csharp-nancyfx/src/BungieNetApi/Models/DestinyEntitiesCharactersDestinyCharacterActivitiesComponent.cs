using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component holds activity data for a character. It will tell you about the character&#39;s current activity status, as well as activities that are available to the user.
    /// </summary>
    public sealed class DestinyEntitiesCharactersDestinyCharacterActivitiesComponent:  IEquatable<DestinyEntitiesCharactersDestinyCharacterActivitiesComponent>
    { 
        /// <summary>
        /// The last date that the user started playing an activity.
        /// </summary>
        public DateTime? DateActivityStarted { get; private set; }

        /// <summary>
        /// The list of activities that the user can play.
        /// </summary>
        public List<DestinyDestinyActivity> AvailableActivities { get; private set; }

        /// <summary>
        /// If the user is in an activity, this will be the hash of the Activity being played. Note that you must combine this info with currentActivityModeHash to get a real picture of what the user is doing right now. For instance, PVP \&quot;Activities\&quot; are just maps: it&#39;s the ActivityMode that determines what type of PVP game they&#39;re playing.
        /// </summary>
        public int? CurrentActivityHash { get; private set; }

        /// <summary>
        /// If the user is in an activity, this will be the hash of the activity mode being played. Combine with currentActivityHash to give a person a full picture of what they&#39;re doing right now.
        /// </summary>
        public int? CurrentActivityModeHash { get; private set; }

        /// <summary>
        /// And the current activity&#39;s most specific mode type, if it can be found.
        /// </summary>
        public CurrentActivityModeTypeEnum? CurrentActivityModeType { get; private set; }

        /// <summary>
        /// If the user is in an activity, this will be the hashes of the DestinyActivityModeDefinition being played. Combine with currentActivityHash to give a person a full picture of what they&#39;re doing right now.
        /// </summary>
        public List<int?> CurrentActivityModeHashes { get; private set; }

        /// <summary>
        /// All Activity Modes that apply to the current activity being played, in enum form.
        /// </summary>
        public List<int?> CurrentActivityModeTypes { get; private set; }

        /// <summary>
        /// If the user is in a playlist, this is the hash identifier for the playlist that they chose.
        /// </summary>
        public int? CurrentPlaylistActivityHash { get; private set; }

        /// <summary>
        /// This will have the activity hash of the last completed story/campaign mission, in case you care about that.
        /// </summary>
        public int? LastCompletedStoryHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesCharactersDestinyCharacterActivitiesComponent()
        {
        }

        private DestinyEntitiesCharactersDestinyCharacterActivitiesComponent(DateTime? DateActivityStarted, List<DestinyDestinyActivity> AvailableActivities, int? CurrentActivityHash, int? CurrentActivityModeHash, CurrentActivityModeTypeEnum? CurrentActivityModeType, List<int?> CurrentActivityModeHashes, List<int?> CurrentActivityModeTypes, int? CurrentPlaylistActivityHash, int? LastCompletedStoryHash)
        {
            
            this.DateActivityStarted = DateActivityStarted;
            
            this.AvailableActivities = AvailableActivities;
            
            this.CurrentActivityHash = CurrentActivityHash;
            
            this.CurrentActivityModeHash = CurrentActivityModeHash;
            
            this.CurrentActivityModeType = CurrentActivityModeType;
            
            this.CurrentActivityModeHashes = CurrentActivityModeHashes;
            
            this.CurrentActivityModeTypes = CurrentActivityModeTypes;
            
            this.CurrentPlaylistActivityHash = CurrentPlaylistActivityHash;
            
            this.LastCompletedStoryHash = LastCompletedStoryHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder</returns>
        public static DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder Builder()
        {
            return new DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder</returns>
        public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder With()
        {
            return Builder()
                .DateActivityStarted(DateActivityStarted)
                .AvailableActivities(AvailableActivities)
                .CurrentActivityHash(CurrentActivityHash)
                .CurrentActivityModeHash(CurrentActivityModeHash)
                .CurrentActivityModeType(CurrentActivityModeType)
                .CurrentActivityModeHashes(CurrentActivityModeHashes)
                .CurrentActivityModeTypes(CurrentActivityModeTypes)
                .CurrentPlaylistActivityHash(CurrentPlaylistActivityHash)
                .LastCompletedStoryHash(LastCompletedStoryHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesCharactersDestinyCharacterActivitiesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent left, DestinyEntitiesCharactersDestinyCharacterActivitiesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesCharactersDestinyCharacterActivitiesComponent left, DestinyEntitiesCharactersDestinyCharacterActivitiesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.
        /// </summary>
        public sealed class DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder
        {
            private DateTime? _DateActivityStarted;
            private List<DestinyDestinyActivity> _AvailableActivities;
            private int? _CurrentActivityHash;
            private int? _CurrentActivityModeHash;
            private CurrentActivityModeTypeEnum? _CurrentActivityModeType;
            private List<int?> _CurrentActivityModeHashes;
            private List<int?> _CurrentActivityModeTypes;
            private int? _CurrentPlaylistActivityHash;
            private int? _LastCompletedStoryHash;

            internal DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.DateActivityStarted property.
            /// </summary>
            /// <param name="value">The last date that the user started playing an activity.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder DateActivityStarted(DateTime? value)
            {
                _DateActivityStarted = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.AvailableActivities property.
            /// </summary>
            /// <param name="value">The list of activities that the user can play.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder AvailableActivities(List<DestinyDestinyActivity> value)
            {
                _AvailableActivities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.CurrentActivityHash property.
            /// </summary>
            /// <param name="value">If the user is in an activity, this will be the hash of the Activity being played. Note that you must combine this info with currentActivityModeHash to get a real picture of what the user is doing right now. For instance, PVP \&quot;Activities\&quot; are just maps: it&#39;s the ActivityMode that determines what type of PVP game they&#39;re playing.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder CurrentActivityHash(int? value)
            {
                _CurrentActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.CurrentActivityModeHash property.
            /// </summary>
            /// <param name="value">If the user is in an activity, this will be the hash of the activity mode being played. Combine with currentActivityHash to give a person a full picture of what they&#39;re doing right now.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder CurrentActivityModeHash(int? value)
            {
                _CurrentActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.CurrentActivityModeType property.
            /// </summary>
            /// <param name="value">And the current activity&#39;s most specific mode type, if it can be found.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder CurrentActivityModeType(CurrentActivityModeTypeEnum? value)
            {
                _CurrentActivityModeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.CurrentActivityModeHashes property.
            /// </summary>
            /// <param name="value">If the user is in an activity, this will be the hashes of the DestinyActivityModeDefinition being played. Combine with currentActivityHash to give a person a full picture of what they&#39;re doing right now.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder CurrentActivityModeHashes(List<int?> value)
            {
                _CurrentActivityModeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.CurrentActivityModeTypes property.
            /// </summary>
            /// <param name="value">All Activity Modes that apply to the current activity being played, in enum form.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder CurrentActivityModeTypes(List<int?> value)
            {
                _CurrentActivityModeTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.CurrentPlaylistActivityHash property.
            /// </summary>
            /// <param name="value">If the user is in a playlist, this is the hash identifier for the playlist that they chose.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder CurrentPlaylistActivityHash(int? value)
            {
                _CurrentPlaylistActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.LastCompletedStoryHash property.
            /// </summary>
            /// <param name="value">This will have the activity hash of the last completed story/campaign mission, in case you care about that.</param>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponentBuilder LastCompletedStoryHash(int? value)
            {
                _LastCompletedStoryHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesCharactersDestinyCharacterActivitiesComponent.
            /// </summary>
            /// <returns>DestinyEntitiesCharactersDestinyCharacterActivitiesComponent</returns>
            public DestinyEntitiesCharactersDestinyCharacterActivitiesComponent Build()
            {
                Validate();
                return new DestinyEntitiesCharactersDestinyCharacterActivitiesComponent(
                    DateActivityStarted: _DateActivityStarted,
                    AvailableActivities: _AvailableActivities,
                    CurrentActivityHash: _CurrentActivityHash,
                    CurrentActivityModeHash: _CurrentActivityModeHash,
                    CurrentActivityModeType: _CurrentActivityModeType,
                    CurrentActivityModeHashes: _CurrentActivityModeHashes,
                    CurrentActivityModeTypes: _CurrentActivityModeTypes,
                    CurrentPlaylistActivityHash: _CurrentPlaylistActivityHash,
                    LastCompletedStoryHash: _LastCompletedStoryHash
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum CurrentActivityModeTypeEnum { _0, _2, _3, _4, _5, _6, _7, _9, _10, _11, _12, _13, _15, _16, _17, _18, _19, _20, _21, _22, _24, _25, _26, _27, _28, _29, _30, _31, _32, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84 };
    }
}