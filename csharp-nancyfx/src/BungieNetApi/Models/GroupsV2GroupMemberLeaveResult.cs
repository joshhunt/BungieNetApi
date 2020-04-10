using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupMemberLeaveResult
    /// </summary>
    public sealed class GroupsV2GroupMemberLeaveResult:  IEquatable<GroupsV2GroupMemberLeaveResult>
    { 
        /// <summary>
        /// Group
        /// </summary>
        public GroupsV2GroupV2 Group { get; private set; }

        /// <summary>
        /// GroupDeleted
        /// </summary>
        public bool? GroupDeleted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupMemberLeaveResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupMemberLeaveResult()
        {
        }

        private GroupsV2GroupMemberLeaveResult(GroupsV2GroupV2 Group, bool? GroupDeleted)
        {
            
            this.Group = Group;
            
            this.GroupDeleted = GroupDeleted;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupMemberLeaveResult.
        /// </summary>
        /// <returns>GroupsV2GroupMemberLeaveResultBuilder</returns>
        public static GroupsV2GroupMemberLeaveResultBuilder Builder()
        {
            return new GroupsV2GroupMemberLeaveResultBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupMemberLeaveResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupMemberLeaveResultBuilder</returns>
        public GroupsV2GroupMemberLeaveResultBuilder With()
        {
            return Builder()
                .Group(Group)
                .GroupDeleted(GroupDeleted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupMemberLeaveResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupMemberLeaveResult.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMemberLeaveResult</param>
        /// <param name="right">Compared (GroupsV2GroupMemberLeaveResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupMemberLeaveResult left, GroupsV2GroupMemberLeaveResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupMemberLeaveResult.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMemberLeaveResult</param>
        /// <param name="right">Compared (GroupsV2GroupMemberLeaveResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupMemberLeaveResult left, GroupsV2GroupMemberLeaveResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupMemberLeaveResult.
        /// </summary>
        public sealed class GroupsV2GroupMemberLeaveResultBuilder
        {
            private GroupsV2GroupV2 _Group;
            private bool? _GroupDeleted;

            internal GroupsV2GroupMemberLeaveResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberLeaveResult.Group property.
            /// </summary>
            /// <param name="value">Group</param>
            public GroupsV2GroupMemberLeaveResultBuilder Group(GroupsV2GroupV2 value)
            {
                _Group = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMemberLeaveResult.GroupDeleted property.
            /// </summary>
            /// <param name="value">GroupDeleted</param>
            public GroupsV2GroupMemberLeaveResultBuilder GroupDeleted(bool? value)
            {
                _GroupDeleted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupMemberLeaveResult.
            /// </summary>
            /// <returns>GroupsV2GroupMemberLeaveResult</returns>
            public GroupsV2GroupMemberLeaveResult Build()
            {
                Validate();
                return new GroupsV2GroupMemberLeaveResult(
                    Group: _Group,
                    GroupDeleted: _GroupDeleted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}