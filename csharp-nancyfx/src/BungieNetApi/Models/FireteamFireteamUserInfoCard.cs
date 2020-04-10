using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// FireteamFireteamUserInfoCard
    /// </summary>
    public sealed class FireteamFireteamUserInfoCard:  IEquatable<FireteamFireteamUserInfoCard>
    { 
        /// <summary>
        /// FireteamDisplayName
        /// </summary>
        public string FireteamDisplayName { get; private set; }

        /// <summary>
        /// FireteamMembershipType
        /// </summary>
        public int? FireteamMembershipType { get; private set; }

        /// <summary>
        /// FireteamPlatformProfileUrl
        /// </summary>
        public string FireteamPlatformProfileUrl { get; private set; }

        /// <summary>
        /// FireteamPlatformUniqueIdentifier
        /// </summary>
        public string FireteamPlatformUniqueIdentifier { get; private set; }

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
        /// Use FireteamFireteamUserInfoCard.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public FireteamFireteamUserInfoCard()
        {
        }

        private FireteamFireteamUserInfoCard(string FireteamDisplayName, int? FireteamMembershipType, string FireteamPlatformProfileUrl, string FireteamPlatformUniqueIdentifier, string SupplementalDisplayName, string IconPath, int? CrossSaveOverride, List<int?> ApplicableMembershipTypes, bool? IsPublic, int? MembershipType, long? MembershipId, string DisplayName)
        {
            
            this.FireteamDisplayName = FireteamDisplayName;
            
            this.FireteamMembershipType = FireteamMembershipType;
            
            this.FireteamPlatformProfileUrl = FireteamPlatformProfileUrl;
            
            this.FireteamPlatformUniqueIdentifier = FireteamPlatformUniqueIdentifier;
            
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
        /// Returns builder of FireteamFireteamUserInfoCard.
        /// </summary>
        /// <returns>FireteamFireteamUserInfoCardBuilder</returns>
        public static FireteamFireteamUserInfoCardBuilder Builder()
        {
            return new FireteamFireteamUserInfoCardBuilder();
        }

        /// <summary>
        /// Returns FireteamFireteamUserInfoCardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>FireteamFireteamUserInfoCardBuilder</returns>
        public FireteamFireteamUserInfoCardBuilder With()
        {
            return Builder()
                .FireteamDisplayName(FireteamDisplayName)
                .FireteamMembershipType(FireteamMembershipType)
                .FireteamPlatformProfileUrl(FireteamPlatformProfileUrl)
                .FireteamPlatformUniqueIdentifier(FireteamPlatformUniqueIdentifier)
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

        public bool Equals(FireteamFireteamUserInfoCard other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (FireteamFireteamUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamUserInfoCard</param>
        /// <param name="right">Compared (FireteamFireteamUserInfoCard</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (FireteamFireteamUserInfoCard left, FireteamFireteamUserInfoCard right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (FireteamFireteamUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamUserInfoCard</param>
        /// <param name="right">Compared (FireteamFireteamUserInfoCard</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (FireteamFireteamUserInfoCard left, FireteamFireteamUserInfoCard right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of FireteamFireteamUserInfoCard.
        /// </summary>
        public sealed class FireteamFireteamUserInfoCardBuilder
        {
            private string _FireteamDisplayName;
            private int? _FireteamMembershipType;
            private string _FireteamPlatformProfileUrl;
            private string _FireteamPlatformUniqueIdentifier;
            private string _SupplementalDisplayName;
            private string _IconPath;
            private int? _CrossSaveOverride;
            private List<int?> _ApplicableMembershipTypes;
            private bool? _IsPublic;
            private int? _MembershipType;
            private long? _MembershipId;
            private string _DisplayName;

            internal FireteamFireteamUserInfoCardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.FireteamDisplayName property.
            /// </summary>
            /// <param name="value">FireteamDisplayName</param>
            public FireteamFireteamUserInfoCardBuilder FireteamDisplayName(string value)
            {
                _FireteamDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.FireteamMembershipType property.
            /// </summary>
            /// <param name="value">FireteamMembershipType</param>
            public FireteamFireteamUserInfoCardBuilder FireteamMembershipType(int? value)
            {
                _FireteamMembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.FireteamPlatformProfileUrl property.
            /// </summary>
            /// <param name="value">FireteamPlatformProfileUrl</param>
            public FireteamFireteamUserInfoCardBuilder FireteamPlatformProfileUrl(string value)
            {
                _FireteamPlatformProfileUrl = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.FireteamPlatformUniqueIdentifier property.
            /// </summary>
            /// <param name="value">FireteamPlatformUniqueIdentifier</param>
            public FireteamFireteamUserInfoCardBuilder FireteamPlatformUniqueIdentifier(string value)
            {
                _FireteamPlatformUniqueIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.SupplementalDisplayName property.
            /// </summary>
            /// <param name="value">A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.</param>
            public FireteamFireteamUserInfoCardBuilder SupplementalDisplayName(string value)
            {
                _SupplementalDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.IconPath property.
            /// </summary>
            /// <param name="value">URL the Icon if available.</param>
            public FireteamFireteamUserInfoCardBuilder IconPath(string value)
            {
                _IconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.CrossSaveOverride property.
            /// </summary>
            /// <param name="value">If there is a cross save override in effect, this value will tell you the type that is overridding this one.</param>
            public FireteamFireteamUserInfoCardBuilder CrossSaveOverride(int? value)
            {
                _CrossSaveOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.ApplicableMembershipTypes property.
            /// </summary>
            /// <param name="value">The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list</param>
            public FireteamFireteamUserInfoCardBuilder ApplicableMembershipTypes(List<int?> value)
            {
                _ApplicableMembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.IsPublic property.
            /// </summary>
            /// <param name="value">If True, this is a public user membership.</param>
            public FireteamFireteamUserInfoCardBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.MembershipType property.
            /// </summary>
            /// <param name="value">Type of the membership. Not necessarily the native type.</param>
            public FireteamFireteamUserInfoCardBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.MembershipId property.
            /// </summary>
            /// <param name="value">Membership ID as they user is known in the Accounts service</param>
            public FireteamFireteamUserInfoCardBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamUserInfoCard.DisplayName property.
            /// </summary>
            /// <param name="value">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</param>
            public FireteamFireteamUserInfoCardBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of FireteamFireteamUserInfoCard.
            /// </summary>
            /// <returns>FireteamFireteamUserInfoCard</returns>
            public FireteamFireteamUserInfoCard Build()
            {
                Validate();
                return new FireteamFireteamUserInfoCard(
                    FireteamDisplayName: _FireteamDisplayName,
                    FireteamMembershipType: _FireteamMembershipType,
                    FireteamPlatformProfileUrl: _FireteamPlatformProfileUrl,
                    FireteamPlatformUniqueIdentifier: _FireteamPlatformUniqueIdentifier,
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