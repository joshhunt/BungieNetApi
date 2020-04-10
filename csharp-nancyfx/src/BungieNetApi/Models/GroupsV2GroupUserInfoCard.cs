using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupUserInfoCard
    /// </summary>
    public sealed class GroupsV2GroupUserInfoCard:  IEquatable<GroupsV2GroupUserInfoCard>
    { 
        /// <summary>
        /// This will be the display name the clan server last saw the user as. If the account is an active cross save override, this will be the display name to use. Otherwise, this will match the displayName property.
        /// </summary>
        public string LastSeenDisplayName { get; private set; }

        /// <summary>
        /// The platform of the LastSeenDisplayName
        /// </summary>
        public int? LastSeenDisplayNameType { get; private set; }

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
        /// Use GroupsV2GroupUserInfoCard.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupUserInfoCard()
        {
        }

        private GroupsV2GroupUserInfoCard(string LastSeenDisplayName, int? LastSeenDisplayNameType, string SupplementalDisplayName, string IconPath, int? CrossSaveOverride, List<int?> ApplicableMembershipTypes, bool? IsPublic, int? MembershipType, long? MembershipId, string DisplayName)
        {
            
            this.LastSeenDisplayName = LastSeenDisplayName;
            
            this.LastSeenDisplayNameType = LastSeenDisplayNameType;
            
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
        /// Returns builder of GroupsV2GroupUserInfoCard.
        /// </summary>
        /// <returns>GroupsV2GroupUserInfoCardBuilder</returns>
        public static GroupsV2GroupUserInfoCardBuilder Builder()
        {
            return new GroupsV2GroupUserInfoCardBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupUserInfoCardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupUserInfoCardBuilder</returns>
        public GroupsV2GroupUserInfoCardBuilder With()
        {
            return Builder()
                .LastSeenDisplayName(LastSeenDisplayName)
                .LastSeenDisplayNameType(LastSeenDisplayNameType)
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

        public bool Equals(GroupsV2GroupUserInfoCard other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupUserInfoCard</param>
        /// <param name="right">Compared (GroupsV2GroupUserInfoCard</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupUserInfoCard left, GroupsV2GroupUserInfoCard right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupUserInfoCard.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupUserInfoCard</param>
        /// <param name="right">Compared (GroupsV2GroupUserInfoCard</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupUserInfoCard left, GroupsV2GroupUserInfoCard right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupUserInfoCard.
        /// </summary>
        public sealed class GroupsV2GroupUserInfoCardBuilder
        {
            private string _LastSeenDisplayName;
            private int? _LastSeenDisplayNameType;
            private string _SupplementalDisplayName;
            private string _IconPath;
            private int? _CrossSaveOverride;
            private List<int?> _ApplicableMembershipTypes;
            private bool? _IsPublic;
            private int? _MembershipType;
            private long? _MembershipId;
            private string _DisplayName;

            internal GroupsV2GroupUserInfoCardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.LastSeenDisplayName property.
            /// </summary>
            /// <param name="value">This will be the display name the clan server last saw the user as. If the account is an active cross save override, this will be the display name to use. Otherwise, this will match the displayName property.</param>
            public GroupsV2GroupUserInfoCardBuilder LastSeenDisplayName(string value)
            {
                _LastSeenDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.LastSeenDisplayNameType property.
            /// </summary>
            /// <param name="value">The platform of the LastSeenDisplayName</param>
            public GroupsV2GroupUserInfoCardBuilder LastSeenDisplayNameType(int? value)
            {
                _LastSeenDisplayNameType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.SupplementalDisplayName property.
            /// </summary>
            /// <param name="value">A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.</param>
            public GroupsV2GroupUserInfoCardBuilder SupplementalDisplayName(string value)
            {
                _SupplementalDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.IconPath property.
            /// </summary>
            /// <param name="value">URL the Icon if available.</param>
            public GroupsV2GroupUserInfoCardBuilder IconPath(string value)
            {
                _IconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.CrossSaveOverride property.
            /// </summary>
            /// <param name="value">If there is a cross save override in effect, this value will tell you the type that is overridding this one.</param>
            public GroupsV2GroupUserInfoCardBuilder CrossSaveOverride(int? value)
            {
                _CrossSaveOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.ApplicableMembershipTypes property.
            /// </summary>
            /// <param name="value">The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list</param>
            public GroupsV2GroupUserInfoCardBuilder ApplicableMembershipTypes(List<int?> value)
            {
                _ApplicableMembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.IsPublic property.
            /// </summary>
            /// <param name="value">If True, this is a public user membership.</param>
            public GroupsV2GroupUserInfoCardBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.MembershipType property.
            /// </summary>
            /// <param name="value">Type of the membership. Not necessarily the native type.</param>
            public GroupsV2GroupUserInfoCardBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.MembershipId property.
            /// </summary>
            /// <param name="value">Membership ID as they user is known in the Accounts service</param>
            public GroupsV2GroupUserInfoCardBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupUserInfoCard.DisplayName property.
            /// </summary>
            /// <param name="value">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</param>
            public GroupsV2GroupUserInfoCardBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupUserInfoCard.
            /// </summary>
            /// <returns>GroupsV2GroupUserInfoCard</returns>
            public GroupsV2GroupUserInfoCard Build()
            {
                Validate();
                return new GroupsV2GroupUserInfoCard(
                    LastSeenDisplayName: _LastSeenDisplayName,
                    LastSeenDisplayNameType: _LastSeenDisplayNameType,
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