using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupPotentialMember
    /// </summary>
    public sealed class GroupsV2GroupPotentialMember:  IEquatable<GroupsV2GroupPotentialMember>
    { 
        /// <summary>
        /// PotentialStatus
        /// </summary>
        public int? PotentialStatus { get; private set; }

        /// <summary>
        /// GroupId
        /// </summary>
        public long? GroupId { get; private set; }

        /// <summary>
        /// DestinyUserInfo
        /// </summary>
        public GroupsV2GroupUserInfoCard DestinyUserInfo { get; private set; }

        /// <summary>
        /// BungieNetUserInfo
        /// </summary>
        public UserUserInfoCard BungieNetUserInfo { get; private set; }

        /// <summary>
        /// JoinDate
        /// </summary>
        public DateTime? JoinDate { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupPotentialMember.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupPotentialMember()
        {
        }

        private GroupsV2GroupPotentialMember(int? PotentialStatus, long? GroupId, GroupsV2GroupUserInfoCard DestinyUserInfo, UserUserInfoCard BungieNetUserInfo, DateTime? JoinDate)
        {
            
            this.PotentialStatus = PotentialStatus;
            
            this.GroupId = GroupId;
            
            this.DestinyUserInfo = DestinyUserInfo;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
            this.JoinDate = JoinDate;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupPotentialMember.
        /// </summary>
        /// <returns>GroupsV2GroupPotentialMemberBuilder</returns>
        public static GroupsV2GroupPotentialMemberBuilder Builder()
        {
            return new GroupsV2GroupPotentialMemberBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupPotentialMemberBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupPotentialMemberBuilder</returns>
        public GroupsV2GroupPotentialMemberBuilder With()
        {
            return Builder()
                .PotentialStatus(PotentialStatus)
                .GroupId(GroupId)
                .DestinyUserInfo(DestinyUserInfo)
                .BungieNetUserInfo(BungieNetUserInfo)
                .JoinDate(JoinDate);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupPotentialMember other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupPotentialMember.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupPotentialMember</param>
        /// <param name="right">Compared (GroupsV2GroupPotentialMember</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupPotentialMember left, GroupsV2GroupPotentialMember right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupPotentialMember.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupPotentialMember</param>
        /// <param name="right">Compared (GroupsV2GroupPotentialMember</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupPotentialMember left, GroupsV2GroupPotentialMember right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupPotentialMember.
        /// </summary>
        public sealed class GroupsV2GroupPotentialMemberBuilder
        {
            private int? _PotentialStatus;
            private long? _GroupId;
            private GroupsV2GroupUserInfoCard _DestinyUserInfo;
            private UserUserInfoCard _BungieNetUserInfo;
            private DateTime? _JoinDate;

            internal GroupsV2GroupPotentialMemberBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMember.PotentialStatus property.
            /// </summary>
            /// <param name="value">PotentialStatus</param>
            public GroupsV2GroupPotentialMemberBuilder PotentialStatus(int? value)
            {
                _PotentialStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMember.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupPotentialMemberBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMember.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">DestinyUserInfo</param>
            public GroupsV2GroupPotentialMemberBuilder DestinyUserInfo(GroupsV2GroupUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMember.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">BungieNetUserInfo</param>
            public GroupsV2GroupPotentialMemberBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMember.JoinDate property.
            /// </summary>
            /// <param name="value">JoinDate</param>
            public GroupsV2GroupPotentialMemberBuilder JoinDate(DateTime? value)
            {
                _JoinDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupPotentialMember.
            /// </summary>
            /// <returns>GroupsV2GroupPotentialMember</returns>
            public GroupsV2GroupPotentialMember Build()
            {
                Validate();
                return new GroupsV2GroupPotentialMember(
                    PotentialStatus: _PotentialStatus,
                    GroupId: _GroupId,
                    DestinyUserInfo: _DestinyUserInfo,
                    BungieNetUserInfo: _BungieNetUserInfo,
                    JoinDate: _JoinDate
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}