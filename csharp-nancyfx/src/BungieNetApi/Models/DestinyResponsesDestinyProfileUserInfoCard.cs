using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyResponsesDestinyProfileUserInfoCard
    /// </summary>
    public sealed class DestinyResponsesDestinyProfileUserInfoCard:  IEquatable<DestinyResponsesDestinyProfileUserInfoCard>
    { 
        /// <summary>
        /// DateLastPlayed
        /// </summary>
        public DateTime? DateLastPlayed { get; private set; }

        /// <summary>
        /// If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.
        /// </summary>
        public bool? IsOverridden { get; private set; }

        /// <summary>
        /// If true, this account is hooked up as the \&quot;Primary\&quot; cross save account for one or more platforms.
        /// </summary>
        public bool? IsCrossSavePrimary { get; private set; }

        /// <summary>
        /// This is the silver available on this Profile across any platforms on which they have purchased silver.   This is only available if you are requesting yourself.
        /// </summary>
        public DestinyComponentsInventoryDestinyPlatformSilverComponent PlatformSilver { get; private set; }

        /// <summary>
        /// If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.   For the time being, we will not return this information for any membership that is in a cross save pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to get that information for the profile&#39;s original Platform, and thus gameVersions would be too inconsistent (based on the last platform they happened to play on) for the info to be useful.   If we ever can get this data, this field will be deprecated and replaced with data on the DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we can&#39;t get that, we have this as a stop-gap measure for getting the data in the only situation that we currently need it.
        /// </summary>
        public UnpairedGameVersionsEnum? UnpairedGameVersions { get; private set; }

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
        /// Use DestinyResponsesDestinyProfileUserInfoCard.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyProfileUserInfoCard()
        {
        }

        private DestinyResponsesDestinyProfileUserInfoCard(DateTime? DateLastPlayed, bool? IsOverridden, bool? IsCrossSavePrimary, DestinyComponentsInventoryDestinyPlatformSilverComponent PlatformSilver, UnpairedGameVersionsEnum? UnpairedGameVersions, string SupplementalDisplayName, string IconPath, int? CrossSaveOverride, List<int?> ApplicableMembershipTypes, bool? IsPublic, int? MembershipType, long? MembershipId, string DisplayName)
        {
            
            this.DateLastPlayed = DateLastPlayed;
            
            this.IsOverridden = IsOverridden;
            
            this.IsCrossSavePrimary = IsCrossSavePrimary;
            
            this.PlatformSilver = PlatformSilver;
            
            this.UnpairedGameVersions = UnpairedGameVersions;
            
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
        /// Returns builder of DestinyResponsesDestinyProfileUserInfoCard.
        /// </summary>
        /// <returns>DestinyResponsesDestinyProfileUserInfoCardBuilder</returns>
        public static DestinyResponsesDestinyProfileUserInfoCardBuilder Builder()
        {
            return new DestinyResponsesDestinyProfileUserInfoCardBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyProfileUserInfoCardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyProfileUserInfoCardBuilder</returns>
        public DestinyResponsesDestinyProfileUserInfoCardBuilder With()
        {
            return Builder()
                .DateLastPlayed(DateLastPlayed)
                .IsOverridden(IsOverridden)
                .IsCrossSavePrimary(IsCrossSavePrimary)
                .PlatformSilver(PlatformSilver)
                .UnpairedGameVersions(UnpairedGameVersions)
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

        public bool Equals(DestinyResponsesDestinyProfileUserInfoCard other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyProfileUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyProfileUserInfoCard</param>
        /// <param name="right">Compared (DestinyResponsesDestinyProfileUserInfoCard</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyProfileUserInfoCard left, DestinyResponsesDestinyProfileUserInfoCard right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyProfileUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyProfileUserInfoCard</param>
        /// <param name="right">Compared (DestinyResponsesDestinyProfileUserInfoCard</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyProfileUserInfoCard left, DestinyResponsesDestinyProfileUserInfoCard right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyProfileUserInfoCard.
        /// </summary>
        public sealed class DestinyResponsesDestinyProfileUserInfoCardBuilder
        {
            private DateTime? _DateLastPlayed;
            private bool? _IsOverridden;
            private bool? _IsCrossSavePrimary;
            private DestinyComponentsInventoryDestinyPlatformSilverComponent _PlatformSilver;
            private UnpairedGameVersionsEnum? _UnpairedGameVersions;
            private string _SupplementalDisplayName;
            private string _IconPath;
            private int? _CrossSaveOverride;
            private List<int?> _ApplicableMembershipTypes;
            private bool? _IsPublic;
            private int? _MembershipType;
            private long? _MembershipId;
            private string _DisplayName;

            internal DestinyResponsesDestinyProfileUserInfoCardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.DateLastPlayed property.
            /// </summary>
            /// <param name="value">DateLastPlayed</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder DateLastPlayed(DateTime? value)
            {
                _DateLastPlayed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.IsOverridden property.
            /// </summary>
            /// <param name="value">If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder IsOverridden(bool? value)
            {
                _IsOverridden = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.IsCrossSavePrimary property.
            /// </summary>
            /// <param name="value">If true, this account is hooked up as the \&quot;Primary\&quot; cross save account for one or more platforms.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder IsCrossSavePrimary(bool? value)
            {
                _IsCrossSavePrimary = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.PlatformSilver property.
            /// </summary>
            /// <param name="value">This is the silver available on this Profile across any platforms on which they have purchased silver.   This is only available if you are requesting yourself.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder PlatformSilver(DestinyComponentsInventoryDestinyPlatformSilverComponent value)
            {
                _PlatformSilver = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.UnpairedGameVersions property.
            /// </summary>
            /// <param name="value">If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.   For the time being, we will not return this information for any membership that is in a cross save pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to get that information for the profile&#39;s original Platform, and thus gameVersions would be too inconsistent (based on the last platform they happened to play on) for the info to be useful.   If we ever can get this data, this field will be deprecated and replaced with data on the DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we can&#39;t get that, we have this as a stop-gap measure for getting the data in the only situation that we currently need it.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder UnpairedGameVersions(UnpairedGameVersionsEnum? value)
            {
                _UnpairedGameVersions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.SupplementalDisplayName property.
            /// </summary>
            /// <param name="value">A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder SupplementalDisplayName(string value)
            {
                _SupplementalDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.IconPath property.
            /// </summary>
            /// <param name="value">URL the Icon if available.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder IconPath(string value)
            {
                _IconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.CrossSaveOverride property.
            /// </summary>
            /// <param name="value">If there is a cross save override in effect, this value will tell you the type that is overridding this one.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder CrossSaveOverride(int? value)
            {
                _CrossSaveOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.ApplicableMembershipTypes property.
            /// </summary>
            /// <param name="value">The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder ApplicableMembershipTypes(List<int?> value)
            {
                _ApplicableMembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.IsPublic property.
            /// </summary>
            /// <param name="value">If True, this is a public user membership.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.MembershipType property.
            /// </summary>
            /// <param name="value">Type of the membership. Not necessarily the native type.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.MembershipId property.
            /// </summary>
            /// <param name="value">Membership ID as they user is known in the Accounts service</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileUserInfoCard.DisplayName property.
            /// </summary>
            /// <param name="value">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</param>
            public DestinyResponsesDestinyProfileUserInfoCardBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyProfileUserInfoCard.
            /// </summary>
            /// <returns>DestinyResponsesDestinyProfileUserInfoCard</returns>
            public DestinyResponsesDestinyProfileUserInfoCard Build()
            {
                Validate();
                return new DestinyResponsesDestinyProfileUserInfoCard(
                    DateLastPlayed: _DateLastPlayed,
                    IsOverridden: _IsOverridden,
                    IsCrossSavePrimary: _IsCrossSavePrimary,
                    PlatformSilver: _PlatformSilver,
                    UnpairedGameVersions: _UnpairedGameVersions,
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

        
        public enum UnpairedGameVersionsEnum { _0, _1, _2, _4, _8, _16, _32 };
    }
}