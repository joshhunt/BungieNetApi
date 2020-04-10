using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupMember
    /// </summary>
    public sealed class GroupsV2GroupMember:  IEquatable<GroupsV2GroupMember>
    { 
        /// <summary>
        /// MemberType
        /// </summary>
        public int? MemberType { get; private set; }

        /// <summary>
        /// IsOnline
        /// </summary>
        public bool? IsOnline { get; private set; }

        /// <summary>
        /// LastOnlineStatusChange
        /// </summary>
        public long? LastOnlineStatusChange { get; private set; }

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
        /// Use GroupsV2GroupMember.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupMember()
        {
        }

        private GroupsV2GroupMember(int? MemberType, bool? IsOnline, long? LastOnlineStatusChange, long? GroupId, GroupsV2GroupUserInfoCard DestinyUserInfo, UserUserInfoCard BungieNetUserInfo, DateTime? JoinDate)
        {
            
            this.MemberType = MemberType;
            
            this.IsOnline = IsOnline;
            
            this.LastOnlineStatusChange = LastOnlineStatusChange;
            
            this.GroupId = GroupId;
            
            this.DestinyUserInfo = DestinyUserInfo;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
            this.JoinDate = JoinDate;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupMember.
        /// </summary>
        /// <returns>GroupsV2GroupMemberBuilder</returns>
        public static GroupsV2GroupMemberBuilder Builder()
        {
            return new GroupsV2GroupMemberBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupMemberBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupMemberBuilder</returns>
        public GroupsV2GroupMemberBuilder With()
        {
            return Builder()
                .MemberType(MemberType)
                .IsOnline(IsOnline)
                .LastOnlineStatusChange(LastOnlineStatusChange)
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

        public bool Equals(GroupsV2GroupMember other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupMember.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMember</param>
        /// <param name="right">Compared (GroupsV2GroupMember</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupMember left, GroupsV2GroupMember right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupMember.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMember</param>
        /// <param name="right">Compared (GroupsV2GroupMember</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupMember left, GroupsV2GroupMember right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupMember.
        /// </summary>
        public sealed class GroupsV2GroupMemberBuilder
        {
            private int? _MemberType;
            private bool? _IsOnline;
            private long? _LastOnlineStatusChange;
            private long? _GroupId;
            private GroupsV2GroupUserInfoCard _DestinyUserInfo;
            private UserUserInfoCard _BungieNetUserInfo;
            private DateTime? _JoinDate;

            internal GroupsV2GroupMemberBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.MemberType property.
            /// </summary>
            /// <param name="value">MemberType</param>
            public GroupsV2GroupMemberBuilder MemberType(int? value)
            {
                _MemberType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.IsOnline property.
            /// </summary>
            /// <param name="value">IsOnline</param>
            public GroupsV2GroupMemberBuilder IsOnline(bool? value)
            {
                _IsOnline = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.LastOnlineStatusChange property.
            /// </summary>
            /// <param name="value">LastOnlineStatusChange</param>
            public GroupsV2GroupMemberBuilder LastOnlineStatusChange(long? value)
            {
                _LastOnlineStatusChange = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupMemberBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">DestinyUserInfo</param>
            public GroupsV2GroupMemberBuilder DestinyUserInfo(GroupsV2GroupUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">BungieNetUserInfo</param>
            public GroupsV2GroupMemberBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMember.JoinDate property.
            /// </summary>
            /// <param name="value">JoinDate</param>
            public GroupsV2GroupMemberBuilder JoinDate(DateTime? value)
            {
                _JoinDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupMember.
            /// </summary>
            /// <returns>GroupsV2GroupMember</returns>
            public GroupsV2GroupMember Build()
            {
                Validate();
                return new GroupsV2GroupMember(
                    MemberType: _MemberType,
                    IsOnline: _IsOnline,
                    LastOnlineStatusChange: _LastOnlineStatusChange,
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