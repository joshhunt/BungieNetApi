using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupMembershipBase
    /// </summary>
    public sealed class GroupsV2GroupMembershipBase:  IEquatable<GroupsV2GroupMembershipBase>
    { 
        /// <summary>
        /// Group
        /// </summary>
        public GroupsV2GroupV2 Group { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupMembershipBase.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupMembershipBase()
        {
        }

        private GroupsV2GroupMembershipBase(GroupsV2GroupV2 Group)
        {
            
            this.Group = Group;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupMembershipBase.
        /// </summary>
        /// <returns>GroupsV2GroupMembershipBaseBuilder</returns>
        public static GroupsV2GroupMembershipBaseBuilder Builder()
        {
            return new GroupsV2GroupMembershipBaseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupMembershipBaseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupMembershipBaseBuilder</returns>
        public GroupsV2GroupMembershipBaseBuilder With()
        {
            return Builder()
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

        public bool Equals(GroupsV2GroupMembershipBase other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupMembershipBase.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMembershipBase</param>
        /// <param name="right">Compared (GroupsV2GroupMembershipBase</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupMembershipBase left, GroupsV2GroupMembershipBase right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupMembershipBase.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMembershipBase</param>
        /// <param name="right">Compared (GroupsV2GroupMembershipBase</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupMembershipBase left, GroupsV2GroupMembershipBase right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupMembershipBase.
        /// </summary>
        public sealed class GroupsV2GroupMembershipBaseBuilder
        {
            private GroupsV2GroupV2 _Group;

            internal GroupsV2GroupMembershipBaseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipBase.Group property.
            /// </summary>
            /// <param name="value">Group</param>
            public GroupsV2GroupMembershipBaseBuilder Group(GroupsV2GroupV2 value)
            {
                _Group = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupMembershipBase.
            /// </summary>
            /// <returns>GroupsV2GroupMembershipBase</returns>
            public GroupsV2GroupMembershipBase Build()
            {
                Validate();
                return new GroupsV2GroupMembershipBase(
                    Group: _Group
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}