using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupFeatures
    /// </summary>
    public sealed class GroupsV2GroupFeatures:  IEquatable<GroupsV2GroupFeatures>
    { 
        /// <summary>
        /// MaximumMembers
        /// </summary>
        public int? MaximumMembers { get; private set; }

        /// <summary>
        /// Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.
        /// </summary>
        public int? MaximumMembershipsOfGroupType { get; private set; }

        /// <summary>
        /// Capabilities
        /// </summary>
        public int? Capabilities { get; private set; }

        /// <summary>
        /// MembershipTypes
        /// </summary>
        public List<int?> MembershipTypes { get; private set; }

        /// <summary>
        /// Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        public bool? InvitePermissionOverride { get; private set; }

        /// <summary>
        /// Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        public bool? UpdateCulturePermissionOverride { get; private set; }

        /// <summary>
        /// Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.
        /// </summary>
        public int? HostGuidedGamePermissionOverride { get; private set; }

        /// <summary>
        /// Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        public bool? UpdateBannerPermissionOverride { get; private set; }

        /// <summary>
        /// Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.
        /// </summary>
        public int? JoinLevel { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupFeatures.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupFeatures()
        {
        }

        private GroupsV2GroupFeatures(int? MaximumMembers, int? MaximumMembershipsOfGroupType, int? Capabilities, List<int?> MembershipTypes, bool? InvitePermissionOverride, bool? UpdateCulturePermissionOverride, int? HostGuidedGamePermissionOverride, bool? UpdateBannerPermissionOverride, int? JoinLevel)
        {
            
            this.MaximumMembers = MaximumMembers;
            
            this.MaximumMembershipsOfGroupType = MaximumMembershipsOfGroupType;
            
            this.Capabilities = Capabilities;
            
            this.MembershipTypes = MembershipTypes;
            
            this.InvitePermissionOverride = InvitePermissionOverride;
            
            this.UpdateCulturePermissionOverride = UpdateCulturePermissionOverride;
            
            this.HostGuidedGamePermissionOverride = HostGuidedGamePermissionOverride;
            
            this.UpdateBannerPermissionOverride = UpdateBannerPermissionOverride;
            
            this.JoinLevel = JoinLevel;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupFeatures.
        /// </summary>
        /// <returns>GroupsV2GroupFeaturesBuilder</returns>
        public static GroupsV2GroupFeaturesBuilder Builder()
        {
            return new GroupsV2GroupFeaturesBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupFeaturesBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupFeaturesBuilder</returns>
        public GroupsV2GroupFeaturesBuilder With()
        {
            return Builder()
                .MaximumMembers(MaximumMembers)
                .MaximumMembershipsOfGroupType(MaximumMembershipsOfGroupType)
                .Capabilities(Capabilities)
                .MembershipTypes(MembershipTypes)
                .InvitePermissionOverride(InvitePermissionOverride)
                .UpdateCulturePermissionOverride(UpdateCulturePermissionOverride)
                .HostGuidedGamePermissionOverride(HostGuidedGamePermissionOverride)
                .UpdateBannerPermissionOverride(UpdateBannerPermissionOverride)
                .JoinLevel(JoinLevel);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupFeatures other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupFeatures.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupFeatures</param>
        /// <param name="right">Compared (GroupsV2GroupFeatures</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupFeatures left, GroupsV2GroupFeatures right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupFeatures.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupFeatures</param>
        /// <param name="right">Compared (GroupsV2GroupFeatures</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupFeatures left, GroupsV2GroupFeatures right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupFeatures.
        /// </summary>
        public sealed class GroupsV2GroupFeaturesBuilder
        {
            private int? _MaximumMembers;
            private int? _MaximumMembershipsOfGroupType;
            private int? _Capabilities;
            private List<int?> _MembershipTypes;
            private bool? _InvitePermissionOverride;
            private bool? _UpdateCulturePermissionOverride;
            private int? _HostGuidedGamePermissionOverride;
            private bool? _UpdateBannerPermissionOverride;
            private int? _JoinLevel;

            internal GroupsV2GroupFeaturesBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.MaximumMembers property.
            /// </summary>
            /// <param name="value">MaximumMembers</param>
            public GroupsV2GroupFeaturesBuilder MaximumMembers(int? value)
            {
                _MaximumMembers = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.MaximumMembershipsOfGroupType property.
            /// </summary>
            /// <param name="value">Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.</param>
            public GroupsV2GroupFeaturesBuilder MaximumMembershipsOfGroupType(int? value)
            {
                _MaximumMembershipsOfGroupType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.Capabilities property.
            /// </summary>
            /// <param name="value">Capabilities</param>
            public GroupsV2GroupFeaturesBuilder Capabilities(int? value)
            {
                _Capabilities = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.MembershipTypes property.
            /// </summary>
            /// <param name="value">MembershipTypes</param>
            public GroupsV2GroupFeaturesBuilder MembershipTypes(List<int?> value)
            {
                _MembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.InvitePermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</param>
            public GroupsV2GroupFeaturesBuilder InvitePermissionOverride(bool? value)
            {
                _InvitePermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.UpdateCulturePermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</param>
            public GroupsV2GroupFeaturesBuilder UpdateCulturePermissionOverride(bool? value)
            {
                _UpdateCulturePermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.HostGuidedGamePermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.</param>
            public GroupsV2GroupFeaturesBuilder HostGuidedGamePermissionOverride(int? value)
            {
                _HostGuidedGamePermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.UpdateBannerPermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</param>
            public GroupsV2GroupFeaturesBuilder UpdateBannerPermissionOverride(bool? value)
            {
                _UpdateBannerPermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupFeatures.JoinLevel property.
            /// </summary>
            /// <param name="value">Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.</param>
            public GroupsV2GroupFeaturesBuilder JoinLevel(int? value)
            {
                _JoinLevel = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupFeatures.
            /// </summary>
            /// <returns>GroupsV2GroupFeatures</returns>
            public GroupsV2GroupFeatures Build()
            {
                Validate();
                return new GroupsV2GroupFeatures(
                    MaximumMembers: _MaximumMembers,
                    MaximumMembershipsOfGroupType: _MaximumMembershipsOfGroupType,
                    Capabilities: _Capabilities,
                    MembershipTypes: _MembershipTypes,
                    InvitePermissionOverride: _InvitePermissionOverride,
                    UpdateCulturePermissionOverride: _UpdateCulturePermissionOverride,
                    HostGuidedGamePermissionOverride: _HostGuidedGamePermissionOverride,
                    UpdateBannerPermissionOverride: _UpdateBannerPermissionOverride,
                    JoinLevel: _JoinLevel
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}