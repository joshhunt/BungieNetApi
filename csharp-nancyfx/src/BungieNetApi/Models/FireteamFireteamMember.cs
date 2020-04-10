using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// FireteamFireteamMember
    /// </summary>
    public sealed class FireteamFireteamMember:  IEquatable<FireteamFireteamMember>
    { 
        /// <summary>
        /// DestinyUserInfo
        /// </summary>
        public FireteamFireteamUserInfoCard DestinyUserInfo { get; private set; }

        /// <summary>
        /// BungieNetUserInfo
        /// </summary>
        public UserUserInfoCard BungieNetUserInfo { get; private set; }

        /// <summary>
        /// CharacterId
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// DateJoined
        /// </summary>
        public DateTime? DateJoined { get; private set; }

        /// <summary>
        /// HasMicrophone
        /// </summary>
        public bool? HasMicrophone { get; private set; }

        /// <summary>
        /// LastPlatformInviteAttemptDate
        /// </summary>
        public DateTime? LastPlatformInviteAttemptDate { get; private set; }

        /// <summary>
        /// LastPlatformInviteAttemptResult
        /// </summary>
        public int? LastPlatformInviteAttemptResult { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use FireteamFireteamMember.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public FireteamFireteamMember()
        {
        }

        private FireteamFireteamMember(FireteamFireteamUserInfoCard DestinyUserInfo, UserUserInfoCard BungieNetUserInfo, long? CharacterId, DateTime? DateJoined, bool? HasMicrophone, DateTime? LastPlatformInviteAttemptDate, int? LastPlatformInviteAttemptResult)
        {
            
            this.DestinyUserInfo = DestinyUserInfo;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
            this.CharacterId = CharacterId;
            
            this.DateJoined = DateJoined;
            
            this.HasMicrophone = HasMicrophone;
            
            this.LastPlatformInviteAttemptDate = LastPlatformInviteAttemptDate;
            
            this.LastPlatformInviteAttemptResult = LastPlatformInviteAttemptResult;
            
        }

        /// <summary>
        /// Returns builder of FireteamFireteamMember.
        /// </summary>
        /// <returns>FireteamFireteamMemberBuilder</returns>
        public static FireteamFireteamMemberBuilder Builder()
        {
            return new FireteamFireteamMemberBuilder();
        }

        /// <summary>
        /// Returns FireteamFireteamMemberBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>FireteamFireteamMemberBuilder</returns>
        public FireteamFireteamMemberBuilder With()
        {
            return Builder()
                .DestinyUserInfo(DestinyUserInfo)
                .BungieNetUserInfo(BungieNetUserInfo)
                .CharacterId(CharacterId)
                .DateJoined(DateJoined)
                .HasMicrophone(HasMicrophone)
                .LastPlatformInviteAttemptDate(LastPlatformInviteAttemptDate)
                .LastPlatformInviteAttemptResult(LastPlatformInviteAttemptResult);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(FireteamFireteamMember other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (FireteamFireteamMember.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamMember</param>
        /// <param name="right">Compared (FireteamFireteamMember</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (FireteamFireteamMember left, FireteamFireteamMember right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (FireteamFireteamMember.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamMember</param>
        /// <param name="right">Compared (FireteamFireteamMember</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (FireteamFireteamMember left, FireteamFireteamMember right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of FireteamFireteamMember.
        /// </summary>
        public sealed class FireteamFireteamMemberBuilder
        {
            private FireteamFireteamUserInfoCard _DestinyUserInfo;
            private UserUserInfoCard _BungieNetUserInfo;
            private long? _CharacterId;
            private DateTime? _DateJoined;
            private bool? _HasMicrophone;
            private DateTime? _LastPlatformInviteAttemptDate;
            private int? _LastPlatformInviteAttemptResult;

            internal FireteamFireteamMemberBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">DestinyUserInfo</param>
            public FireteamFireteamMemberBuilder DestinyUserInfo(FireteamFireteamUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">BungieNetUserInfo</param>
            public FireteamFireteamMemberBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public FireteamFireteamMemberBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.DateJoined property.
            /// </summary>
            /// <param name="value">DateJoined</param>
            public FireteamFireteamMemberBuilder DateJoined(DateTime? value)
            {
                _DateJoined = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.HasMicrophone property.
            /// </summary>
            /// <param name="value">HasMicrophone</param>
            public FireteamFireteamMemberBuilder HasMicrophone(bool? value)
            {
                _HasMicrophone = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.LastPlatformInviteAttemptDate property.
            /// </summary>
            /// <param name="value">LastPlatformInviteAttemptDate</param>
            public FireteamFireteamMemberBuilder LastPlatformInviteAttemptDate(DateTime? value)
            {
                _LastPlatformInviteAttemptDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamMember.LastPlatformInviteAttemptResult property.
            /// </summary>
            /// <param name="value">LastPlatformInviteAttemptResult</param>
            public FireteamFireteamMemberBuilder LastPlatformInviteAttemptResult(int? value)
            {
                _LastPlatformInviteAttemptResult = value;
                return this;
            }


            /// <summary>
            /// Builds instance of FireteamFireteamMember.
            /// </summary>
            /// <returns>FireteamFireteamMember</returns>
            public FireteamFireteamMember Build()
            {
                Validate();
                return new FireteamFireteamMember(
                    DestinyUserInfo: _DestinyUserInfo,
                    BungieNetUserInfo: _BungieNetUserInfo,
                    CharacterId: _CharacterId,
                    DateJoined: _DateJoined,
                    HasMicrophone: _HasMicrophone,
                    LastPlatformInviteAttemptDate: _LastPlatformInviteAttemptDate,
                    LastPlatformInviteAttemptResult: _LastPlatformInviteAttemptResult
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}