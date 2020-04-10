using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
    /// </summary>
    public sealed class UserUserInfoCard:  IEquatable<UserUserInfoCard>
    { 
        /// <summary>
        /// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
        /// </summary>
        public string SupplementalDisplayName { get; private set; }

        /// <summary>
        /// URL the Icon if available.
        /// </summary>
        public string IconPath { get; private set; }

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
        /// Use UserUserInfoCard.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserUserInfoCard()
        {
        }

        private UserUserInfoCard(string SupplementalDisplayName, string IconPath, int? CrossSaveOverride, List<int?> ApplicableMembershipTypes, bool? IsPublic, int? MembershipType, long? MembershipId, string DisplayName)
        {
            
            this.SupplementalDisplayName = SupplementalDisplayName;
            
            this.IconPath = IconPath;
            
            this.CrossSaveOverride = CrossSaveOverride;
            
            this.ApplicableMembershipTypes = ApplicableMembershipTypes;
            
            this.IsPublic = IsPublic;
            
            this.MembershipType = MembershipType;
            
            this.MembershipId = MembershipId;
            
            this.DisplayName = DisplayName;
            
        }

        /// <summary>
        /// Returns builder of UserUserInfoCard.
        /// </summary>
        /// <returns>UserUserInfoCardBuilder</returns>
        public static UserUserInfoCardBuilder Builder()
        {
            return new UserUserInfoCardBuilder();
        }

        /// <summary>
        /// Returns UserUserInfoCardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserUserInfoCardBuilder</returns>
        public UserUserInfoCardBuilder With()
        {
            return Builder()
                .SupplementalDisplayName(SupplementalDisplayName)
                .IconPath(IconPath)
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

        public bool Equals(UserUserInfoCard other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (UserUserInfoCard</param>
        /// <param name="right">Compared (UserUserInfoCard</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserUserInfoCard left, UserUserInfoCard right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (UserUserInfoCard</param>
        /// <param name="right">Compared (UserUserInfoCard</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserUserInfoCard left, UserUserInfoCard right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserUserInfoCard.
        /// </summary>
        public sealed class UserUserInfoCardBuilder
        {
            private string _SupplementalDisplayName;
            private string _IconPath;
            private int? _CrossSaveOverride;
            private List<int?> _ApplicableMembershipTypes;
            private bool? _IsPublic;
            private int? _MembershipType;
            private long? _MembershipId;
            private string _DisplayName;

            internal UserUserInfoCardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.SupplementalDisplayName property.
            /// </summary>
            /// <param name="value">A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.</param>
            public UserUserInfoCardBuilder SupplementalDisplayName(string value)
            {
                _SupplementalDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.IconPath property.
            /// </summary>
            /// <param name="value">URL the Icon if available.</param>
            public UserUserInfoCardBuilder IconPath(string value)
            {
                _IconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.CrossSaveOverride property.
            /// </summary>
            /// <param name="value">If there is a cross save override in effect, this value will tell you the type that is overridding this one.</param>
            public UserUserInfoCardBuilder CrossSaveOverride(int? value)
            {
                _CrossSaveOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.ApplicableMembershipTypes property.
            /// </summary>
            /// <param name="value">The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list</param>
            public UserUserInfoCardBuilder ApplicableMembershipTypes(List<int?> value)
            {
                _ApplicableMembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.IsPublic property.
            /// </summary>
            /// <param name="value">If True, this is a public user membership.</param>
            public UserUserInfoCardBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.MembershipType property.
            /// </summary>
            /// <param name="value">Type of the membership. Not necessarily the native type.</param>
            public UserUserInfoCardBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.MembershipId property.
            /// </summary>
            /// <param name="value">Membership ID as they user is known in the Accounts service</param>
            public UserUserInfoCardBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserInfoCard.DisplayName property.
            /// </summary>
            /// <param name="value">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</param>
            public UserUserInfoCardBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserUserInfoCard.
            /// </summary>
            /// <returns>UserUserInfoCard</returns>
            public UserUserInfoCard Build()
            {
                Validate();
                return new UserUserInfoCard(
                    SupplementalDisplayName: _SupplementalDisplayName,
                    IconPath: _IconPath,
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