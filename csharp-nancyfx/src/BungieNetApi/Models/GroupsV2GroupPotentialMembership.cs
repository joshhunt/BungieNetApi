using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupPotentialMembership
    /// </summary>
    public sealed class GroupsV2GroupPotentialMembership:  IEquatable<GroupsV2GroupPotentialMembership>
    { 
        /// <summary>
        /// Member
        /// </summary>
        public GroupsV2GroupPotentialMember Member { get; private set; }

        /// <summary>
        /// Group
        /// </summary>
        public GroupsV2GroupV2 Group { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupPotentialMembership.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupPotentialMembership()
        {
        }

        private GroupsV2GroupPotentialMembership(GroupsV2GroupPotentialMember Member, GroupsV2GroupV2 Group)
        {
            
            this.Member = Member;
            
            this.Group = Group;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupPotentialMembership.
        /// </summary>
        /// <returns>GroupsV2GroupPotentialMembershipBuilder</returns>
        public static GroupsV2GroupPotentialMembershipBuilder Builder()
        {
            return new GroupsV2GroupPotentialMembershipBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupPotentialMembershipBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupPotentialMembershipBuilder</returns>
        public GroupsV2GroupPotentialMembershipBuilder With()
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

        public bool Equals(GroupsV2GroupPotentialMembership other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupPotentialMembership.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupPotentialMembership</param>
        /// <param name="right">Compared (GroupsV2GroupPotentialMembership</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupPotentialMembership left, GroupsV2GroupPotentialMembership right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupPotentialMembership.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupPotentialMembership</param>
        /// <param name="right">Compared (GroupsV2GroupPotentialMembership</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupPotentialMembership left, GroupsV2GroupPotentialMembership right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupPotentialMembership.
        /// </summary>
        public sealed class GroupsV2GroupPotentialMembershipBuilder
        {
            private GroupsV2GroupPotentialMember _Member;
            private GroupsV2GroupV2 _Group;

            internal GroupsV2GroupPotentialMembershipBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembership.Member property.
            /// </summary>
            /// <param name="value">Member</param>
            public GroupsV2GroupPotentialMembershipBuilder Member(GroupsV2GroupPotentialMember value)
            {
                _Member = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembership.Group property.
            /// </summary>
            /// <param name="value">Group</param>
            public GroupsV2GroupPotentialMembershipBuilder Group(GroupsV2GroupV2 value)
            {
                _Group = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupPotentialMembership.
            /// </summary>
            /// <returns>GroupsV2GroupPotentialMembership</returns>
            public GroupsV2GroupPotentialMembership Build()
            {
                Validate();
                return new GroupsV2GroupPotentialMembership(
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