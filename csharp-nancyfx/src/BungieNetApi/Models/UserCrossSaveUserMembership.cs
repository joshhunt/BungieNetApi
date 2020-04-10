using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Very basic info about a user as returned by the Account server, but including CrossSave information. Do NOT use as a request contract.
    /// </summary>
    public sealed class UserCrossSaveUserMembership:  IEquatable<UserCrossSaveUserMembership>
    { 
        /// <summary>
        /// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
        /// </summary>
        public int? CrossSaveOverride { get; private set; }

        /// <summary>
        /// The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list
        /// </summary>
        public List<int?> ApplicableMembershipTypes { get; private set; }

        /// <summary>
        /// If True, this is a public user membership.
        /// </summary>
        public bool? IsPublic { get; private set; }

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
        /// Use UserCrossSaveUserMembership.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserCrossSaveUserMembership()
        {
        }

        private UserCrossSaveUserMembership(int? CrossSaveOverride, List<int?> ApplicableMembershipTypes, bool? IsPublic, int? MembershipType, long? MembershipId, string DisplayName)
        {
            
            this.CrossSaveOverride = CrossSaveOverride;
            
            this.ApplicableMembershipTypes = ApplicableMembershipTypes;
            
            this.IsPublic = IsPublic;
            
            this.MembershipType = MembershipType;
            
            this.MembershipId = MembershipId;
            
            this.DisplayName = DisplayName;
            
        }

        /// <summary>
        /// Returns builder of UserCrossSaveUserMembership.
        /// </summary>
        /// <returns>UserCrossSaveUserMembershipBuilder</returns>
        public static UserCrossSaveUserMembershipBuilder Builder()
        {
            return new UserCrossSaveUserMembershipBuilder();
        }

        /// <summary>
        /// Returns UserCrossSaveUserMembershipBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserCrossSaveUserMembershipBuilder</returns>
        public UserCrossSaveUserMembershipBuilder With()
        {
            return Builder()
                .CrossSaveOverride(CrossSaveOverride)
                .ApplicableMembershipTypes(ApplicableMembershipTypes)
                .IsPublic(IsPublic)
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

        public bool Equals(UserCrossSaveUserMembership other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserCrossSaveUserMembership.
        /// </summary>
        /// <param name="left">Compared (UserCrossSaveUserMembership</param>
        /// <param name="right">Compared (UserCrossSaveUserMembership</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserCrossSaveUserMembership left, UserCrossSaveUserMembership right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserCrossSaveUserMembership.
        /// </summary>
        /// <param name="left">Compared (UserCrossSaveUserMembership</param>
        /// <param name="right">Compared (UserCrossSaveUserMembership</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserCrossSaveUserMembership left, UserCrossSaveUserMembership right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserCrossSaveUserMembership.
        /// </summary>
        public sealed class UserCrossSaveUserMembershipBuilder
        {
            private int? _CrossSaveOverride;
            private List<int?> _ApplicableMembershipTypes;
            private bool? _IsPublic;
            private int? _MembershipType;
            private long? _MembershipId;
            private string _DisplayName;

            internal UserCrossSaveUserMembershipBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserCrossSaveUserMembership.CrossSaveOverride property.
            /// </summary>
            /// <param name="value">If there is a cross save override in effect, this value will tell you the type that is overridding this one.</param>
            public UserCrossSaveUserMembershipBuilder CrossSaveOverride(int? value)
            {
                _CrossSaveOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserCrossSaveUserMembership.ApplicableMembershipTypes property.
            /// </summary>
            /// <param name="value">The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list</param>
            public UserCrossSaveUserMembershipBuilder ApplicableMembershipTypes(List<int?> value)
            {
                _ApplicableMembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserCrossSaveUserMembership.IsPublic property.
            /// </summary>
            /// <param name="value">If True, this is a public user membership.</param>
            public UserCrossSaveUserMembershipBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserCrossSaveUserMembership.MembershipType property.
            /// </summary>
            /// <param name="value">Type of the membership. Not necessarily the native type.</param>
            public UserCrossSaveUserMembershipBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserCrossSaveUserMembership.MembershipId property.
            /// </summary>
            /// <param name="value">Membership ID as they user is known in the Accounts service</param>
            public UserCrossSaveUserMembershipBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserCrossSaveUserMembership.DisplayName property.
            /// </summary>
            /// <param name="value">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</param>
            public UserCrossSaveUserMembershipBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserCrossSaveUserMembership.
            /// </summary>
            /// <returns>UserCrossSaveUserMembership</returns>
            public UserCrossSaveUserMembership Build()
            {
                Validate();
                return new UserCrossSaveUserMembership(
                    CrossSaveOverride: _CrossSaveOverride,
                    ApplicableMembershipTypes: _ApplicableMembershipTypes,
                    IsPublic: _IsPublic,
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