using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupBan
    /// </summary>
    public sealed class GroupsV2GroupBan:  IEquatable<GroupsV2GroupBan>
    { 
        /// <summary>
        /// GroupId
        /// </summary>
        public long? GroupId { get; private set; }

        /// <summary>
        /// LastModifiedBy
        /// </summary>
        public UserUserInfoCard LastModifiedBy { get; private set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        public UserUserInfoCard CreatedBy { get; private set; }

        /// <summary>
        /// DateBanned
        /// </summary>
        public DateTime? DateBanned { get; private set; }

        /// <summary>
        /// DateExpires
        /// </summary>
        public DateTime? DateExpires { get; private set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; private set; }

        /// <summary>
        /// BungieNetUserInfo
        /// </summary>
        public UserUserInfoCard BungieNetUserInfo { get; private set; }

        /// <summary>
        /// DestinyUserInfo
        /// </summary>
        public GroupsV2GroupUserInfoCard DestinyUserInfo { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupBan.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupBan()
        {
        }

        private GroupsV2GroupBan(long? GroupId, UserUserInfoCard LastModifiedBy, UserUserInfoCard CreatedBy, DateTime? DateBanned, DateTime? DateExpires, string Comment, UserUserInfoCard BungieNetUserInfo, GroupsV2GroupUserInfoCard DestinyUserInfo)
        {
            
            this.GroupId = GroupId;
            
            this.LastModifiedBy = LastModifiedBy;
            
            this.CreatedBy = CreatedBy;
            
            this.DateBanned = DateBanned;
            
            this.DateExpires = DateExpires;
            
            this.Comment = Comment;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
            this.DestinyUserInfo = DestinyUserInfo;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupBan.
        /// </summary>
        /// <returns>GroupsV2GroupBanBuilder</returns>
        public static GroupsV2GroupBanBuilder Builder()
        {
            return new GroupsV2GroupBanBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupBanBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupBanBuilder</returns>
        public GroupsV2GroupBanBuilder With()
        {
            return Builder()
                .GroupId(GroupId)
                .LastModifiedBy(LastModifiedBy)
                .CreatedBy(CreatedBy)
                .DateBanned(DateBanned)
                .DateExpires(DateExpires)
                .Comment(Comment)
                .BungieNetUserInfo(BungieNetUserInfo)
                .DestinyUserInfo(DestinyUserInfo);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupBan other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupBan.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupBan</param>
        /// <param name="right">Compared (GroupsV2GroupBan</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupBan left, GroupsV2GroupBan right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupBan.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupBan</param>
        /// <param name="right">Compared (GroupsV2GroupBan</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupBan left, GroupsV2GroupBan right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupBan.
        /// </summary>
        public sealed class GroupsV2GroupBanBuilder
        {
            private long? _GroupId;
            private UserUserInfoCard _LastModifiedBy;
            private UserUserInfoCard _CreatedBy;
            private DateTime? _DateBanned;
            private DateTime? _DateExpires;
            private string _Comment;
            private UserUserInfoCard _BungieNetUserInfo;
            private GroupsV2GroupUserInfoCard _DestinyUserInfo;

            internal GroupsV2GroupBanBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupBanBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.LastModifiedBy property.
            /// </summary>
            /// <param name="value">LastModifiedBy</param>
            public GroupsV2GroupBanBuilder LastModifiedBy(UserUserInfoCard value)
            {
                _LastModifiedBy = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.CreatedBy property.
            /// </summary>
            /// <param name="value">CreatedBy</param>
            public GroupsV2GroupBanBuilder CreatedBy(UserUserInfoCard value)
            {
                _CreatedBy = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.DateBanned property.
            /// </summary>
            /// <param name="value">DateBanned</param>
            public GroupsV2GroupBanBuilder DateBanned(DateTime? value)
            {
                _DateBanned = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.DateExpires property.
            /// </summary>
            /// <param name="value">DateExpires</param>
            public GroupsV2GroupBanBuilder DateExpires(DateTime? value)
            {
                _DateExpires = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.Comment property.
            /// </summary>
            /// <param name="value">Comment</param>
            public GroupsV2GroupBanBuilder Comment(string value)
            {
                _Comment = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">BungieNetUserInfo</param>
            public GroupsV2GroupBanBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBan.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">DestinyUserInfo</param>
            public GroupsV2GroupBanBuilder DestinyUserInfo(GroupsV2GroupUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupBan.
            /// </summary>
            /// <returns>GroupsV2GroupBan</returns>
            public GroupsV2GroupBan Build()
            {
                Validate();
                return new GroupsV2GroupBan(
                    GroupId: _GroupId,
                    LastModifiedBy: _LastModifiedBy,
                    CreatedBy: _CreatedBy,
                    DateBanned: _DateBanned,
                    DateExpires: _DateExpires,
                    Comment: _Comment,
                    BungieNetUserInfo: _BungieNetUserInfo,
                    DestinyUserInfo: _DestinyUserInfo
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}