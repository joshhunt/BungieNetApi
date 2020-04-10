using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Very basic info about a user as returned by the Account server.
    /// </summary>
    public sealed class UserUserMembership:  IEquatable<UserUserMembership>
    { 
        /// <summary>
        /// Type of the membership. Not necessarily the native type.
        /// </summary>
        public int? MembershipType { get; private set; }

        /// <summary>
        /// Membership ID as they user is known in the Accounts service
        /// </summary>
        public long? MembershipId { get; private set; }

        /// <summary>
        /// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
        /// </summary>
        public string DisplayName { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserUserMembership.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserUserMembership()
        {
        }

        private UserUserMembership(int? MembershipType, long? MembershipId, string DisplayName)
        {
            
            this.MembershipType = MembershipType;
            
            this.MembershipId = MembershipId;
            
            this.DisplayName = DisplayName;
            
        }

        /// <summary>
        /// Returns builder of UserUserMembership.
        /// </summary>
        /// <returns>UserUserMembershipBuilder</returns>
        public static UserUserMembershipBuilder Builder()
        {
            return new UserUserMembershipBuilder();
        }

        /// <summary>
        /// Returns UserUserMembershipBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserUserMembershipBuilder</returns>
        public UserUserMembershipBuilder With()
        {
            return Builder()
                .MembershipType(MembershipType)
                .MembershipId(MembershipId)
                .DisplayName(DisplayName);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserUserMembership other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserUserMembership.
        /// </summary>
        /// <param name="left">Compared (UserUserMembership</param>
        /// <param name="right">Compared (UserUserMembership</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserUserMembership left, UserUserMembership right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserUserMembership.
        /// </summary>
        /// <param name="left">Compared (UserUserMembership</param>
        /// <param name="right">Compared (UserUserMembership</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserUserMembership left, UserUserMembership right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserUserMembership.
        /// </summary>
        public sealed class UserUserMembershipBuilder
        {
            private int? _MembershipType;
            private long? _MembershipId;
            private string _DisplayName;

            internal UserUserMembershipBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserUserMembership.MembershipType property.
            /// </summary>
            /// <param name="value">Type of the membership. Not necessarily the native type.</param>
            public UserUserMembershipBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserMembership.MembershipId property.
            /// </summary>
            /// <param name="value">Membership ID as they user is known in the Accounts service</param>
            public UserUserMembershipBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserMembership.DisplayName property.
            /// </summary>
            /// <param name="value">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</param>
            public UserUserMembershipBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserUserMembership.
            /// </summary>
            /// <returns>UserUserMembership</returns>
            public UserUserMembership Build()
            {
                Validate();
                return new UserUserMembership(
                    MembershipType: _MembershipType,
                    MembershipId: _MembershipId,
                    DisplayName: _DisplayName
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}