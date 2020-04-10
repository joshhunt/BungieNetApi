using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupResponse
    /// </summary>
    public sealed class GroupsV2GroupResponse:  IEquatable<GroupsV2GroupResponse>
    { 
        /// <summary>
        /// Detail
        /// </summary>
        public GroupsV2GroupV2 Detail { get; private set; }

        /// <summary>
        /// Founder
        /// </summary>
        public GroupsV2GroupMember Founder { get; private set; }

        /// <summary>
        /// AlliedIds
        /// </summary>
        public List<long?> AlliedIds { get; private set; }

        /// <summary>
        /// ParentGroup
        /// </summary>
        public GroupsV2GroupV2 ParentGroup { get; private set; }

        /// <summary>
        /// AllianceStatus
        /// </summary>
        public int? AllianceStatus { get; private set; }

        /// <summary>
        /// GroupJoinInviteCount
        /// </summary>
        public int? GroupJoinInviteCount { get; private set; }

        /// <summary>
        /// A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.
        /// </summary>
        public bool? CurrentUserMembershipsInactiveForDestiny { get; private set; }

        /// <summary>
        /// This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.
        /// </summary>
        public Dictionary<string, GroupsV2GroupMember> CurrentUserMemberMap { get; private set; }

        /// <summary>
        /// This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.
        /// </summary>
        public Dictionary<string, GroupsV2GroupPotentialMember> CurrentUserPotentialMemberMap { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupResponse()
        {
        }

        private GroupsV2GroupResponse(GroupsV2GroupV2 Detail, GroupsV2GroupMember Founder, List<long?> AlliedIds, GroupsV2GroupV2 ParentGroup, int? AllianceStatus, int? GroupJoinInviteCount, bool? CurrentUserMembershipsInactiveForDestiny, Dictionary<string, GroupsV2GroupMember> CurrentUserMemberMap, Dictionary<string, GroupsV2GroupPotentialMember> CurrentUserPotentialMemberMap)
        {
            
            this.Detail = Detail;
            
            this.Founder = Founder;
            
            this.AlliedIds = AlliedIds;
            
            this.ParentGroup = ParentGroup;
            
            this.AllianceStatus = AllianceStatus;
            
            this.GroupJoinInviteCount = GroupJoinInviteCount;
            
            this.CurrentUserMembershipsInactiveForDestiny = CurrentUserMembershipsInactiveForDestiny;
            
            this.CurrentUserMemberMap = CurrentUserMemberMap;
            
            this.CurrentUserPotentialMemberMap = CurrentUserPotentialMemberMap;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupResponse.
        /// </summary>
        /// <returns>GroupsV2GroupResponseBuilder</returns>
        public static GroupsV2GroupResponseBuilder Builder()
        {
            return new GroupsV2GroupResponseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupResponseBuilder</returns>
        public GroupsV2GroupResponseBuilder With()
        {
            return Builder()
                .Detail(Detail)
                .Founder(Founder)
                .AlliedIds(AlliedIds)
                .ParentGroup(ParentGroup)
                .AllianceStatus(AllianceStatus)
                .GroupJoinInviteCount(GroupJoinInviteCount)
                .CurrentUserMembershipsInactiveForDestiny(CurrentUserMembershipsInactiveForDestiny)
                .CurrentUserMemberMap(CurrentUserMemberMap)
                .CurrentUserPotentialMemberMap(CurrentUserPotentialMemberMap);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupResponse</param>
        /// <param name="right">Compared (GroupsV2GroupResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupResponse left, GroupsV2GroupResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupResponse</param>
        /// <param name="right">Compared (GroupsV2GroupResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupResponse left, GroupsV2GroupResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupResponse.
        /// </summary>
        public sealed class GroupsV2GroupResponseBuilder
        {
            private GroupsV2GroupV2 _Detail;
            private GroupsV2GroupMember _Founder;
            private List<long?> _AlliedIds;
            private GroupsV2GroupV2 _ParentGroup;
            private int? _AllianceStatus;
            private int? _GroupJoinInviteCount;
            private bool? _CurrentUserMembershipsInactiveForDestiny;
            private Dictionary<string, GroupsV2GroupMember> _CurrentUserMemberMap;
            private Dictionary<string, GroupsV2GroupPotentialMember> _CurrentUserPotentialMemberMap;

            internal GroupsV2GroupResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.Detail property.
            /// </summary>
            /// <param name="value">Detail</param>
            public GroupsV2GroupResponseBuilder Detail(GroupsV2GroupV2 value)
            {
                _Detail = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.Founder property.
            /// </summary>
            /// <param name="value">Founder</param>
            public GroupsV2GroupResponseBuilder Founder(GroupsV2GroupMember value)
            {
                _Founder = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.AlliedIds property.
            /// </summary>
            /// <param name="value">AlliedIds</param>
            public GroupsV2GroupResponseBuilder AlliedIds(List<long?> value)
            {
                _AlliedIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.ParentGroup property.
            /// </summary>
            /// <param name="value">ParentGroup</param>
            public GroupsV2GroupResponseBuilder ParentGroup(GroupsV2GroupV2 value)
            {
                _ParentGroup = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.AllianceStatus property.
            /// </summary>
            /// <param name="value">AllianceStatus</param>
            public GroupsV2GroupResponseBuilder AllianceStatus(int? value)
            {
                _AllianceStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.GroupJoinInviteCount property.
            /// </summary>
            /// <param name="value">GroupJoinInviteCount</param>
            public GroupsV2GroupResponseBuilder GroupJoinInviteCount(int? value)
            {
                _GroupJoinInviteCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.CurrentUserMembershipsInactiveForDestiny property.
            /// </summary>
            /// <param name="value">A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.</param>
            public GroupsV2GroupResponseBuilder CurrentUserMembershipsInactiveForDestiny(bool? value)
            {
                _CurrentUserMembershipsInactiveForDestiny = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.CurrentUserMemberMap property.
            /// </summary>
            /// <param name="value">This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.</param>
            public GroupsV2GroupResponseBuilder CurrentUserMemberMap(Dictionary<string, GroupsV2GroupMember> value)
            {
                _CurrentUserMemberMap = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupResponse.CurrentUserPotentialMemberMap property.
            /// </summary>
            /// <param name="value">This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.</param>
            public GroupsV2GroupResponseBuilder CurrentUserPotentialMemberMap(Dictionary<string, GroupsV2GroupPotentialMember> value)
            {
                _CurrentUserPotentialMemberMap = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupResponse.
            /// </summary>
            /// <returns>GroupsV2GroupResponse</returns>
            public GroupsV2GroupResponse Build()
            {
                Validate();
                return new GroupsV2GroupResponse(
                    Detail: _Detail,
                    Founder: _Founder,
                    AlliedIds: _AlliedIds,
                    ParentGroup: _ParentGroup,
                    AllianceStatus: _AllianceStatus,
                    GroupJoinInviteCount: _GroupJoinInviteCount,
                    CurrentUserMembershipsInactiveForDestiny: _CurrentUserMembershipsInactiveForDestiny,
                    CurrentUserMemberMap: _CurrentUserMemberMap,
                    CurrentUserPotentialMemberMap: _CurrentUserPotentialMemberMap
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}