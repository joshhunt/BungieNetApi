using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupMembership
    /// </summary>
    public sealed class GroupsV2GroupMembership:  IEquatable<GroupsV2GroupMembership>
    { 
        /// <summary>
        /// Member
        /// </summary>
        public GroupsV2GroupMember Member { get; private set; }

        /// <summary>
        /// Group
        /// </summary>
        public GroupsV2GroupV2 Group { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupMembership.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupMembership()
        {
        }

        private GroupsV2GroupMembership(GroupsV2GroupMember Member, GroupsV2GroupV2 Group)
        {
            
            this.Member = Member;
            
            this.Group = Group;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupMembership.
        /// </summary>
        /// <returns>GroupsV2GroupMembershipBuilder</returns>
        public static GroupsV2GroupMembershipBuilder Builder()
        {
            return new GroupsV2GroupMembershipBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupMembershipBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupMembershipBuilder</returns>
        public GroupsV2GroupMembershipBuilder With()
        {
            return Builder()
                .Member(Member)
                .Group(Group);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupMembership other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupMembership.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMembership</param>
        /// <param name="right">Compared (GroupsV2GroupMembership</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupMembership left, GroupsV2GroupMembership right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupMembership.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMembership</param>
        /// <param name="right">Compared (GroupsV2GroupMembership</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupMembership left, GroupsV2GroupMembership right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupMembership.
        /// </summary>
        public sealed class GroupsV2GroupMembershipBuilder
        {
            private GroupsV2GroupMember _Member;
            private GroupsV2GroupV2 _Group;

            internal GroupsV2GroupMembershipBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembership.Member property.
            /// </summary>
            /// <param name="value">Member</param>
            public GroupsV2GroupMembershipBuilder Member(GroupsV2GroupMember value)
            {
                _Member = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembership.Group property.
            /// </summary>
            /// <param name="value">Group</param>
            public GroupsV2GroupMembershipBuilder Group(GroupsV2GroupV2 value)
            {
                _Group = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupMembership.
            /// </summary>
            /// <returns>GroupsV2GroupMembership</returns>
            public GroupsV2GroupMembership Build()
            {
                Validate();
                return new GroupsV2GroupMembership(
                    Member: _Member,
                    Group: _Group
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}