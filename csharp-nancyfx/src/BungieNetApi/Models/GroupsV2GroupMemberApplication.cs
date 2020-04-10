using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupMemberApplication
    /// </summary>
    public sealed class GroupsV2GroupMemberApplication:  IEquatable<GroupsV2GroupMemberApplication>
    { 
        /// <summary>
        /// GroupId
        /// </summary>
        public long? GroupId { get; private set; }

        /// <summary>
        /// CreationDate
        /// </summary>
        public DateTime? CreationDate { get; private set; }

        /// <summary>
        /// ResolveState
        /// </summary>
        public int? ResolveState { get; private set; }

        /// <summary>
        /// ResolveDate
        /// </summary>
        public DateTime? ResolveDate { get; private set; }

        /// <summary>
        /// ResolvedByMembershipId
        /// </summary>
        public long? ResolvedByMembershipId { get; private set; }

        /// <summary>
        /// RequestMessage
        /// </summary>
        public string RequestMessage { get; private set; }

        /// <summary>
        /// ResolveMessage
        /// </summary>
        public string ResolveMessage { get; private set; }

        /// <summary>
        /// DestinyUserInfo
        /// </summary>
        public GroupsV2GroupUserInfoCard DestinyUserInfo { get; private set; }

        /// <summary>
        /// BungieNetUserInfo
        /// </summary>
        public UserUserInfoCard BungieNetUserInfo { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupMemberApplication.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupMemberApplication()
        {
        }

        private GroupsV2GroupMemberApplication(long? GroupId, DateTime? CreationDate, int? ResolveState, DateTime? ResolveDate, long? ResolvedByMembershipId, string RequestMessage, string ResolveMessage, GroupsV2GroupUserInfoCard DestinyUserInfo, UserUserInfoCard BungieNetUserInfo)
        {
            
            this.GroupId = GroupId;
            
            this.CreationDate = CreationDate;
            
            this.ResolveState = ResolveState;
            
            this.ResolveDate = ResolveDate;
            
            this.ResolvedByMembershipId = ResolvedByMembershipId;
            
            this.RequestMessage = RequestMessage;
            
            this.ResolveMessage = ResolveMessage;
            
            this.DestinyUserInfo = DestinyUserInfo;
            
            this.BungieNetUserInfo = BungieNetUserInfo;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupMemberApplication.
        /// </summary>
        /// <returns>GroupsV2GroupMemberApplicationBuilder</returns>
        public static GroupsV2GroupMemberApplicationBuilder Builder()
        {
            return new GroupsV2GroupMemberApplicationBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupMemberApplicationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupMemberApplicationBuilder</returns>
        public GroupsV2GroupMemberApplicationBuilder With()
        {
            return Builder()
                .GroupId(GroupId)
                .CreationDate(CreationDate)
                .ResolveState(ResolveState)
                .ResolveDate(ResolveDate)
                .ResolvedByMembershipId(ResolvedByMembershipId)
                .RequestMessage(RequestMessage)
                .ResolveMessage(ResolveMessage)
                .DestinyUserInfo(DestinyUserInfo)
                .BungieNetUserInfo(BungieNetUserInfo);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupMemberApplication other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupMemberApplication.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMemberApplication</param>
        /// <param name="right">Compared (GroupsV2GroupMemberApplication</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupMemberApplication left, GroupsV2GroupMemberApplication right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupMemberApplication.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMemberApplication</param>
        /// <param name="right">Compared (GroupsV2GroupMemberApplication</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupMemberApplication left, GroupsV2GroupMemberApplication right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupMemberApplication.
        /// </summary>
        public sealed class GroupsV2GroupMemberApplicationBuilder
        {
            private long? _GroupId;
            private DateTime? _CreationDate;
            private int? _ResolveState;
            private DateTime? _ResolveDate;
            private long? _ResolvedByMembershipId;
            private string _RequestMessage;
            private string _ResolveMessage;
            private GroupsV2GroupUserInfoCard _DestinyUserInfo;
            private UserUserInfoCard _BungieNetUserInfo;

            internal GroupsV2GroupMemberApplicationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupMemberApplicationBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.CreationDate property.
            /// </summary>
            /// <param name="value">CreationDate</param>
            public GroupsV2GroupMemberApplicationBuilder CreationDate(DateTime? value)
            {
                _CreationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.ResolveState property.
            /// </summary>
            /// <param name="value">ResolveState</param>
            public GroupsV2GroupMemberApplicationBuilder ResolveState(int? value)
            {
                _ResolveState = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.ResolveDate property.
            /// </summary>
            /// <param name="value">ResolveDate</param>
            public GroupsV2GroupMemberApplicationBuilder ResolveDate(DateTime? value)
            {
                _ResolveDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.ResolvedByMembershipId property.
            /// </summary>
            /// <param name="value">ResolvedByMembershipId</param>
            public GroupsV2GroupMemberApplicationBuilder ResolvedByMembershipId(long? value)
            {
                _ResolvedByMembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.RequestMessage property.
            /// </summary>
            /// <param name="value">RequestMessage</param>
            public GroupsV2GroupMemberApplicationBuilder RequestMessage(string value)
            {
                _RequestMessage = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.ResolveMessage property.
            /// </summary>
            /// <param name="value">ResolveMessage</param>
            public GroupsV2GroupMemberApplicationBuilder ResolveMessage(string value)
            {
                _ResolveMessage = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.DestinyUserInfo property.
            /// </summary>
            /// <param name="value">DestinyUserInfo</param>
            public GroupsV2GroupMemberApplicationBuilder DestinyUserInfo(GroupsV2GroupUserInfoCard value)
            {
                _DestinyUserInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberApplication.BungieNetUserInfo property.
            /// </summary>
            /// <param name="value">BungieNetUserInfo</param>
            public GroupsV2GroupMemberApplicationBuilder BungieNetUserInfo(UserUserInfoCard value)
            {
                _BungieNetUserInfo = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupMemberApplication.
            /// </summary>
            /// <returns>GroupsV2GroupMemberApplication</returns>
            public GroupsV2GroupMemberApplication Build()
            {
                Validate();
                return new GroupsV2GroupMemberApplication(
                    GroupId: _GroupId,
                    CreationDate: _CreationDate,
                    ResolveState: _ResolveState,
                    ResolveDate: _ResolveDate,
                    ResolvedByMembershipId: _ResolvedByMembershipId,
                    RequestMessage: _RequestMessage,
                    ResolveMessage: _ResolveMessage,
                    DestinyUserInfo: _DestinyUserInfo,
                    BungieNetUserInfo: _BungieNetUserInfo
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}