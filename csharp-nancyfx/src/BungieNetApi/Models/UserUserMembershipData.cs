using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// UserUserMembershipData
    /// </summary>
    public sealed class UserUserMembershipData:  IEquatable<UserUserMembershipData>
    { 
        /// <summary>
        /// this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)
        /// </summary>
        public List<GroupsV2GroupUserInfoCard> DestinyMemberships { get; private set; }

        /// <summary>
        /// If this property is populated, it will have the membership ID of the account considered to be \&quot;primary\&quot; in this user&#39;s cross save relationship.   If null, this user has no cross save relationship, nor primary account.
        /// </summary>
        public long? PrimaryMembershipId { get; private set; }

        /// <summary>
        /// BungieNetUser
        /// </summary>
        public UserGeneralUser BungieNetUser { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserUserMembershipData.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserUserMembershipData()
        {
        }

        private UserUserMembershipData(List<GroupsV2GroupUserInfoCard> DestinyMemberships, long? PrimaryMembershipId, UserGeneralUser BungieNetUser)
        {
            
            this.DestinyMemberships = DestinyMemberships;
            
            this.PrimaryMembershipId = PrimaryMembershipId;
            
            this.BungieNetUser = BungieNetUser;
            
        }

        /// <summary>
        /// Returns builder of UserUserMembershipData.
        /// </summary>
        /// <returns>UserUserMembershipDataBuilder</returns>
        public static UserUserMembershipDataBuilder Builder()
        {
            return new UserUserMembershipDataBuilder();
        }

        /// <summary>
        /// Returns UserUserMembershipDataBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserUserMembershipDataBuilder</returns>
        public UserUserMembershipDataBuilder With()
        {
            return Builder()
                .DestinyMemberships(DestinyMemberships)
                .PrimaryMembershipId(PrimaryMembershipId)
                .BungieNetUser(BungieNetUser);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserUserMembershipData other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserUserMembershipData.
        /// </summary>
        /// <param name="left">Compared (UserUserMembershipData</param>
        /// <param name="right">Compared (UserUserMembershipData</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserUserMembershipData left, UserUserMembershipData right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserUserMembershipData.
        /// </summary>
        /// <param name="left">Compared (UserUserMembershipData</param>
        /// <param name="right">Compared (UserUserMembershipData</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserUserMembershipData left, UserUserMembershipData right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserUserMembershipData.
        /// </summary>
        public sealed class UserUserMembershipDataBuilder
        {
            private List<GroupsV2GroupUserInfoCard> _DestinyMemberships;
            private long? _PrimaryMembershipId;
            private UserGeneralUser _BungieNetUser;

            internal UserUserMembershipDataBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserUserMembershipData.DestinyMemberships property.
            /// </summary>
            /// <param name="value">this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)</param>
            public UserUserMembershipDataBuilder DestinyMemberships(List<GroupsV2GroupUserInfoCard> value)
            {
                _DestinyMemberships = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserMembershipData.PrimaryMembershipId property.
            /// </summary>
            /// <param name="value">If this property is populated, it will have the membership ID of the account considered to be \&quot;primary\&quot; in this user&#39;s cross save relationship.   If null, this user has no cross save relationship, nor primary account.</param>
            public UserUserMembershipDataBuilder PrimaryMembershipId(long? value)
            {
                _PrimaryMembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserMembershipData.BungieNetUser property.
            /// </summary>
            /// <param name="value">BungieNetUser</param>
            public UserUserMembershipDataBuilder BungieNetUser(UserGeneralUser value)
            {
                _BungieNetUser = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserUserMembershipData.
            /// </summary>
            /// <returns>UserUserMembershipData</returns>
            public UserUserMembershipData Build()
            {
                Validate();
                return new UserUserMembershipData(
                    DestinyMemberships: _DestinyMemberships,
                    PrimaryMembershipId: _PrimaryMembershipId,
                    BungieNetUser: _BungieNetUser
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}