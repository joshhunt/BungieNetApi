using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupUserBase
    /// </summary>
    public sealed class GroupsV2GroupUserBase:  IEquatable<GroupsV2GroupUserBase>
    { 
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
        /// Use GroupsV2GroupUserBase.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupUserBase()
        {
        }

        private GroupsV2GroupUserBase(long? GroupId, GroupsV2GroupUserInfoCard DestinyUserInfo, UserUserInfoCard BungieNetUserInfo, DateTime? JoinDate)
        {
            
            this.GroupId = GroupId;
            
            this.DestinyUserInfo = DestinyUserInfo;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
            this.JoinDate = JoinDate;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupUserBase.
        /// </summary>
        /// <returns>GroupsV2GroupUserBaseBuilder</returns>
        public static GroupsV2GroupUserBaseBuilder Builder()
        {
            return new GroupsV2GroupUserBaseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupUserBaseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupUserBaseBuilder</returns>
        public GroupsV2GroupUserBaseBuilder With()
        {
            return Builder()
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

        public bool Equals(GroupsV2GroupUserBase other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupUserBase.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupUserBase</param>
        /// <param name="right">Compared (GroupsV2GroupUserBase</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupUserBase left, GroupsV2GroupUserBase right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupUserBase.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupUserBase</param>
        /// <param name="right">Compared (GroupsV2GroupUserBase</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupUserBase left, GroupsV2GroupUserBase right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupUserBase.
        /// </summary>
        public sealed class GroupsV2GroupUserBaseBuilder
        {
            private long? _GroupId;
            private GroupsV2GroupUserInfoCard _DestinyUserInfo;
            private UserUserInfoCard _BungieNetUserInfo;
            private DateTime? _JoinDate;

            internal GroupsV2GroupUserBaseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserBase.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupUserBaseBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserBase.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">DestinyUserInfo</param>
            public GroupsV2GroupUserBaseBuilder DestinyUserInfo(GroupsV2GroupUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserBase.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">BungieNetUserInfo</param>
            public GroupsV2GroupUserBaseBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserBase.JoinDate property.
            /// </summary>
            /// <param name="value">JoinDate</param>
            public GroupsV2GroupUserBaseBuilder JoinDate(DateTime? value)
            {
                _JoinDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupUserBase.
            /// </summary>
            /// <returns>GroupsV2GroupUserBase</returns>
            public GroupsV2GroupUserBase Build()
            {
                Validate();
                return new GroupsV2GroupUserBase(
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