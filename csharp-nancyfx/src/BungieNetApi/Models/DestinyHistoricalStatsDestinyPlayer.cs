using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyPlayer
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyPlayer:  IEquatable<DestinyHistoricalStatsDestinyPlayer>
    { 
        /// <summary>
        /// Details about the player as they are known in game (platform display name, Destiny emblem)
        /// </summary>
        public UserUserInfoCard DestinyUserInfo { get; private set; }

        /// <summary>
        /// Class of the character if applicable and available.
        /// </summary>
        public string CharacterClass { get; private set; }

        /// <summary>
        /// ClassHash
        /// </summary>
        public int? ClassHash { get; private set; }

        /// <summary>
        /// RaceHash
        /// </summary>
        public int? RaceHash { get; private set; }

        /// <summary>
        /// GenderHash
        /// </summary>
        public int? GenderHash { get; private set; }

        /// <summary>
        /// Level of the character if available. Zero if it is not available.
        /// </summary>
        public int? CharacterLevel { get; private set; }

        /// <summary>
        /// Light Level of the character if available. Zero if it is not available.
        /// </summary>
        public int? LightLevel { get; private set; }

        /// <summary>
        /// Details about the player as they are known on BungieNet. This will be undefined if the player has marked their credential private, or does not have a BungieNet account.
        /// </summary>
        public UserUserInfoCard BungieNetUserInfo { get; private set; }

        /// <summary>
        /// Current clan name for the player. This value may be null or an empty string if the user does not have a clan.
        /// </summary>
        public string ClanName { get; private set; }

        /// <summary>
        /// Current clan tag for the player. This value may be null or an empty string if the user does not have a clan.
        /// </summary>
        public string ClanTag { get; private set; }

        /// <summary>
        /// If we know the emblem&#39;s hash, this can be used to look up the player&#39;s emblem at the time of a match when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to obtain it).
        /// </summary>
        public int? EmblemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyPlayer.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyPlayer()
        {
        }

        private DestinyHistoricalStatsDestinyPlayer(UserUserInfoCard DestinyUserInfo, string CharacterClass, int? ClassHash, int? RaceHash, int? GenderHash, int? CharacterLevel, int? LightLevel, UserUserInfoCard BungieNetUserInfo, string ClanName, string ClanTag, int? EmblemHash)
        {
            
            this.DestinyUserInfo = DestinyUserInfo;
            
            this.CharacterClass = CharacterClass;
            
            this.ClassHash = ClassHash;
            
            this.RaceHash = RaceHash;
            
            this.GenderHash = GenderHash;
            
            this.CharacterLevel = CharacterLevel;
            
            this.LightLevel = LightLevel;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
            this.ClanName = ClanName;
            
            this.ClanTag = ClanTag;
            
            this.EmblemHash = EmblemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyPlayer.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPlayerBuilder</returns>
        public static DestinyHistoricalStatsDestinyPlayerBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyPlayerBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyPlayerBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPlayerBuilder</returns>
        public DestinyHistoricalStatsDestinyPlayerBuilder With()
        {
            return Builder()
                .DestinyUserInfo(DestinyUserInfo)
                .CharacterClass(CharacterClass)
                .ClassHash(ClassHash)
                .RaceHash(RaceHash)
                .GenderHash(GenderHash)
                .CharacterLevel(CharacterLevel)
                .LightLevel(LightLevel)
                .BungieNetUserInfo(BungieNetUserInfo)
                .ClanName(ClanName)
                .ClanTag(ClanTag)
                .EmblemHash(EmblemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyPlayer other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyPlayer.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPlayer</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPlayer</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyPlayer left, DestinyHistoricalStatsDestinyPlayer right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyPlayer.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPlayer</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPlayer</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyPlayer left, DestinyHistoricalStatsDestinyPlayer right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyPlayer.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyPlayerBuilder
        {
            private UserUserInfoCard _DestinyUserInfo;
            private string _CharacterClass;
            private int? _ClassHash;
            private int? _RaceHash;
            private int? _GenderHash;
            private int? _CharacterLevel;
            private int? _LightLevel;
            private UserUserInfoCard _BungieNetUserInfo;
            private string _ClanName;
            private string _ClanTag;
            private int? _EmblemHash;

            internal DestinyHistoricalStatsDestinyPlayerBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">Details about the player as they are known in game (platform display name, Destiny emblem)</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder DestinyUserInfo(UserUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.CharacterClass property.
            /// </summary>
            /// <param name="value">Class of the character if applicable and available.</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder CharacterClass(string value)
            {
                _CharacterClass = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.ClassHash property.
            /// </summary>
            /// <param name="value">ClassHash</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder ClassHash(int? value)
            {
                _ClassHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.RaceHash property.
            /// </summary>
            /// <param name="value">RaceHash</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder RaceHash(int? value)
            {
                _RaceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.GenderHash property.
            /// </summary>
            /// <param name="value">GenderHash</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder GenderHash(int? value)
            {
                _GenderHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.CharacterLevel property.
            /// </summary>
            /// <param name="value">Level of the character if available. Zero if it is not available.</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder CharacterLevel(int? value)
            {
                _CharacterLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.LightLevel property.
            /// </summary>
            /// <param name="value">Light Level of the character if available. Zero if it is not available.</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder LightLevel(int? value)
            {
                _LightLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">Details about the player as they are known on BungieNet. This will be undefined if the player has marked their credential private, or does not have a BungieNet account.</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.ClanName property.
            /// </summary>
            /// <param name="value">Current clan name for the player. This value may be null or an empty string if the user does not have a clan.</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder ClanName(string value)
            {
                _ClanName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.ClanTag property.
            /// </summary>
            /// <param name="value">Current clan tag for the player. This value may be null or an empty string if the user does not have a clan.</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder ClanTag(string value)
            {
                _ClanTag = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPlayer.EmblemHash property.
            /// </summary>
            /// <param name="value">If we know the emblem&#39;s hash, this can be used to look up the player&#39;s emblem at the time of a match when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to obtain it).</param>
            public DestinyHistoricalStatsDestinyPlayerBuilder EmblemHash(int? value)
            {
                _EmblemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyPlayer.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyPlayer</returns>
            public DestinyHistoricalStatsDestinyPlayer Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyPlayer(
                    DestinyUserInfo: _DestinyUserInfo,
                    CharacterClass: _CharacterClass,
                    ClassHash: _ClassHash,
                    RaceHash: _RaceHash,
                    GenderHash: _GenderHash,
                    CharacterLevel: _CharacterLevel,
                    LightLevel: _LightLevel,
                    BungieNetUserInfo: _BungieNetUserInfo,
                    ClanName: _ClanName,
                    ClanTag: _ClanTag,
                    EmblemHash: _EmblemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}