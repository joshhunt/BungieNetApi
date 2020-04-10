using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The most essential summary information about a Profile (in Destiny 1, we called these \&quot;Accounts\&quot;).
    /// </summary>
    public sealed class DestinyEntitiesProfilesDestinyProfileComponent:  IEquatable<DestinyEntitiesProfilesDestinyProfileComponent>
    { 
        /// <summary>
        /// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
        /// </summary>
        public UserUserInfoCard UserInfo { get; private set; }

        /// <summary>
        /// The last time the user played with any character on this Profile.
        /// </summary>
        public DateTime? DateLastPlayed { get; private set; }

        /// <summary>
        /// If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you&#39;re interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they&#39;ve purchased on the platform on which they last played, which now could be a different platform.   If you don&#39;t care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \&quot;good enough.\&quot; Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.
        /// </summary>
        public int? VersionsOwned { get; private set; }

        /// <summary>
        /// A list of the character IDs, for further querying on your part.
        /// </summary>
        public List<long?> CharacterIds { get; private set; }

        /// <summary>
        /// A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won&#39;t see these as available: it will be whatever seasons are available for the platform on which they last played.
        /// </summary>
        public List<int?> SeasonHashes { get; private set; }

        /// <summary>
        /// If populated, this is a reference to the season that is currently active.
        /// </summary>
        public int? CurrentSeasonHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesProfilesDestinyProfileComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesProfilesDestinyProfileComponent()
        {
        }

        private DestinyEntitiesProfilesDestinyProfileComponent(UserUserInfoCard UserInfo, DateTime? DateLastPlayed, int? VersionsOwned, List<long?> CharacterIds, List<int?> SeasonHashes, int? CurrentSeasonHash)
        {
            
            this.UserInfo = UserInfo;
            
            this.DateLastPlayed = DateLastPlayed;
            
            this.VersionsOwned = VersionsOwned;
            
            this.CharacterIds = CharacterIds;
            
            this.SeasonHashes = SeasonHashes;
            
            this.CurrentSeasonHash = CurrentSeasonHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesProfilesDestinyProfileComponent.
        /// </summary>
        /// <returns>DestinyEntitiesProfilesDestinyProfileComponentBuilder</returns>
        public static DestinyEntitiesProfilesDestinyProfileComponentBuilder Builder()
        {
            return new DestinyEntitiesProfilesDestinyProfileComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesProfilesDestinyProfileComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesProfilesDestinyProfileComponentBuilder</returns>
        public DestinyEntitiesProfilesDestinyProfileComponentBuilder With()
        {
            return Builder()
                .UserInfo(UserInfo)
                .DateLastPlayed(DateLastPlayed)
                .VersionsOwned(VersionsOwned)
                .CharacterIds(CharacterIds)
                .SeasonHashes(SeasonHashes)
                .CurrentSeasonHash(CurrentSeasonHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesProfilesDestinyProfileComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesProfilesDestinyProfileComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesProfilesDestinyProfileComponent</param>
        /// <param name="right">Compared (DestinyEntitiesProfilesDestinyProfileComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesProfilesDestinyProfileComponent left, DestinyEntitiesProfilesDestinyProfileComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesProfilesDestinyProfileComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesProfilesDestinyProfileComponent</param>
        /// <param name="right">Compared (DestinyEntitiesProfilesDestinyProfileComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesProfilesDestinyProfileComponent left, DestinyEntitiesProfilesDestinyProfileComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesProfilesDestinyProfileComponent.
        /// </summary>
        public sealed class DestinyEntitiesProfilesDestinyProfileComponentBuilder
        {
            private UserUserInfoCard _UserInfo;
            private DateTime? _DateLastPlayed;
            private int? _VersionsOwned;
            private List<long?> _CharacterIds;
            private List<int?> _SeasonHashes;
            private int? _CurrentSeasonHash;

            internal DestinyEntitiesProfilesDestinyProfileComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyProfileComponent.UserInfo property.
            /// </summary>
            /// <param name="value">If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.</param>
            public DestinyEntitiesProfilesDestinyProfileComponentBuilder UserInfo(UserUserInfoCard value)
            {
                _UserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyProfileComponent.DateLastPlayed property.
            /// </summary>
            /// <param name="value">The last time the user played with any character on this Profile.</param>
            public DestinyEntitiesProfilesDestinyProfileComponentBuilder DateLastPlayed(DateTime? value)
            {
                _DateLastPlayed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyProfileComponent.VersionsOwned property.
            /// </summary>
            /// <param name="value">If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you&#39;re interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they&#39;ve purchased on the platform on which they last played, which now could be a different platform.   If you don&#39;t care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \&quot;good enough.\&quot; Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.</param>
            public DestinyEntitiesProfilesDestinyProfileComponentBuilder VersionsOwned(int? value)
            {
                _VersionsOwned = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyProfileComponent.CharacterIds property.
            /// </summary>
            /// <param name="value">A list of the character IDs, for further querying on your part.</param>
            public DestinyEntitiesProfilesDestinyProfileComponentBuilder CharacterIds(List<long?> value)
            {
                _CharacterIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyProfileComponent.SeasonHashes property.
            /// </summary>
            /// <param name="value">A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won&#39;t see these as available: it will be whatever seasons are available for the platform on which they last played.</param>
            public DestinyEntitiesProfilesDestinyProfileComponentBuilder SeasonHashes(List<int?> value)
            {
                _SeasonHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyProfileComponent.CurrentSeasonHash property.
            /// </summary>
            /// <param name="value">If populated, this is a reference to the season that is currently active.</param>
            public DestinyEntitiesProfilesDestinyProfileComponentBuilder CurrentSeasonHash(int? value)
            {
                _CurrentSeasonHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesProfilesDestinyProfileComponent.
            /// </summary>
            /// <returns>DestinyEntitiesProfilesDestinyProfileComponent</returns>
            public DestinyEntitiesProfilesDestinyProfileComponent Build()
            {
                Validate();
                return new DestinyEntitiesProfilesDestinyProfileComponent(
                    UserInfo: _UserInfo,
                    DateLastPlayed: _DateLastPlayed,
                    VersionsOwned: _VersionsOwned,
                    CharacterIds: _CharacterIds,
                    SeasonHashes: _SeasonHashes,
                    CurrentSeasonHash: _CurrentSeasonHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}