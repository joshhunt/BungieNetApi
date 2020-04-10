using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// UserHardLinkedUserMembership
    /// </summary>
    public sealed class UserHardLinkedUserMembership:  IEquatable<UserHardLinkedUserMembership>
    { 
        /// <summary>
        /// MembershipType
        /// </summary>
        public int? MembershipType { get; private set; }

        /// <summary>
        /// MembershipId
        /// </summary>
        public long? MembershipId { get; private set; }

        /// <summary>
        /// CrossSaveOverriddenType
        /// </summary>
        public int? CrossSaveOverriddenType { get; private set; }

        /// <summary>
        /// CrossSaveOverriddenMembershipId
        /// </summary>
        public long? CrossSaveOverriddenMembershipId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserHardLinkedUserMembership.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserHardLinkedUserMembership()
        {
        }

        private UserHardLinkedUserMembership(int? MembershipType, long? MembershipId, int? CrossSaveOverriddenType, long? CrossSaveOverriddenMembershipId)
        {
            
            this.MembershipType = MembershipType;
            
            this.MembershipId = MembershipId;
            
            this.CrossSaveOverriddenType = CrossSaveOverriddenType;
            
            this.CrossSaveOverriddenMembershipId = CrossSaveOverriddenMembershipId;
            
        }

        /// <summary>
        /// Returns builder of UserHardLinkedUserMembership.
        /// </summary>
        /// <returns>UserHardLinkedUserMembershipBuilder</returns>
        public static UserHardLinkedUserMembershipBuilder Builder()
        {
            return new UserHardLinkedUserMembershipBuilder();
        }

        /// <summary>
        /// Returns UserHardLinkedUserMembershipBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserHardLinkedUserMembershipBuilder</returns>
        public UserHardLinkedUserMembershipBuilder With()
        {
            return Builder()
                .MembershipType(MembershipType)
                .MembershipId(MembershipId)
                .CrossSaveOverriddenType(CrossSaveOverriddenType)
                .CrossSaveOverriddenMembershipId(CrossSaveOverriddenMembershipId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserHardLinkedUserMembership other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserHardLinkedUserMembership.
        /// </summary>
        /// <param name="left">Compared (UserHardLinkedUserMembership</param>
        /// <param name="right">Compared (UserHardLinkedUserMembership</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserHardLinkedUserMembership left, UserHardLinkedUserMembership right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserHardLinkedUserMembership.
        /// </summary>
        /// <param name="left">Compared (UserHardLinkedUserMembership</param>
        /// <param name="right">Compared (UserHardLinkedUserMembership</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserHardLinkedUserMembership left, UserHardLinkedUserMembership right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserHardLinkedUserMembership.
        /// </summary>
        public sealed class UserHardLinkedUserMembershipBuilder
        {
            private int? _MembershipType;
            private long? _MembershipId;
            private int? _CrossSaveOverriddenType;
            private long? _CrossSaveOverriddenMembershipId;

            internal UserHardLinkedUserMembershipBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserHardLinkedUserMembership.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public UserHardLinkedUserMembershipBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserHardLinkedUserMembership.MembershipId property.
            /// </summary>
            /// <param name="value">MembershipId</param>
            public UserHardLinkedUserMembershipBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserHardLinkedUserMembership.CrossSaveOverriddenType property.
            /// </summary>
            /// <param name="value">CrossSaveOverriddenType</param>
            public UserHardLinkedUserMembershipBuilder CrossSaveOverriddenType(int? value)
            {
                _CrossSaveOverriddenType = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserHardLinkedUserMembership.CrossSaveOverriddenMembershipId property.
            /// </summary>
            /// <param name="value">CrossSaveOverriddenMembershipId</param>
            public UserHardLinkedUserMembershipBuilder CrossSaveOverriddenMembershipId(long? value)
            {
                _CrossSaveOverriddenMembershipId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserHardLinkedUserMembership.
            /// </summary>
            /// <returns>UserHardLinkedUserMembership</returns>
            public UserHardLinkedUserMembership Build()
            {
                Validate();
                return new UserHardLinkedUserMembership(
                    MembershipType: _MembershipType,
                    MembershipId: _MembershipId,
                    CrossSaveOverriddenType: _CrossSaveOverriddenType,
                    CrossSaveOverriddenMembershipId: _CrossSaveOverriddenMembershipId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}