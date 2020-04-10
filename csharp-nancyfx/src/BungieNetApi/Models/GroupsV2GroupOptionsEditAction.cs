using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupOptionsEditAction
    /// </summary>
    public sealed class GroupsV2GroupOptionsEditAction:  IEquatable<GroupsV2GroupOptionsEditAction>
    { 
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
        public HostGuidedGamePermissionOverrideEnum? HostGuidedGamePermissionOverride { get; private set; }

        /// <summary>
        /// Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        public bool? UpdateBannerPermissionOverride { get; private set; }

        /// <summary>
        /// Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.
        /// </summary>
        public JoinLevelEnum? JoinLevel { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupOptionsEditAction.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupOptionsEditAction()
        {
        }

        private GroupsV2GroupOptionsEditAction(bool? InvitePermissionOverride, bool? UpdateCulturePermissionOverride, HostGuidedGamePermissionOverrideEnum? HostGuidedGamePermissionOverride, bool? UpdateBannerPermissionOverride, JoinLevelEnum? JoinLevel)
        {
            
            this.InvitePermissionOverride = InvitePermissionOverride;
            
            this.UpdateCulturePermissionOverride = UpdateCulturePermissionOverride;
            
            this.HostGuidedGamePermissionOverride = HostGuidedGamePermissionOverride;
            
            this.UpdateBannerPermissionOverride = UpdateBannerPermissionOverride;
            
            this.JoinLevel = JoinLevel;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupOptionsEditAction.
        /// </summary>
        /// <returns>GroupsV2GroupOptionsEditActionBuilder</returns>
        public static GroupsV2GroupOptionsEditActionBuilder Builder()
        {
            return new GroupsV2GroupOptionsEditActionBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupOptionsEditActionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupOptionsEditActionBuilder</returns>
        public GroupsV2GroupOptionsEditActionBuilder With()
        {
            return Builder()
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

        public bool Equals(GroupsV2GroupOptionsEditAction other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupOptionsEditAction.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionsEditAction</param>
        /// <param name="right">Compared (GroupsV2GroupOptionsEditAction</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupOptionsEditAction left, GroupsV2GroupOptionsEditAction right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupOptionsEditAction.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionsEditAction</param>
        /// <param name="right">Compared (GroupsV2GroupOptionsEditAction</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupOptionsEditAction left, GroupsV2GroupOptionsEditAction right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupOptionsEditAction.
        /// </summary>
        public sealed class GroupsV2GroupOptionsEditActionBuilder
        {
            private bool? _InvitePermissionOverride;
            private bool? _UpdateCulturePermissionOverride;
            private HostGuidedGamePermissionOverrideEnum? _HostGuidedGamePermissionOverride;
            private bool? _UpdateBannerPermissionOverride;
            private JoinLevelEnum? _JoinLevel;

            internal GroupsV2GroupOptionsEditActionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionsEditAction.InvitePermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</param>
            public GroupsV2GroupOptionsEditActionBuilder InvitePermissionOverride(bool? value)
            {
                _InvitePermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionsEditAction.UpdateCulturePermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</param>
            public GroupsV2GroupOptionsEditActionBuilder UpdateCulturePermissionOverride(bool? value)
            {
                _UpdateCulturePermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionsEditAction.HostGuidedGamePermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.</param>
            public GroupsV2GroupOptionsEditActionBuilder HostGuidedGamePermissionOverride(HostGuidedGamePermissionOverrideEnum? value)
            {
                _HostGuidedGamePermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionsEditAction.UpdateBannerPermissionOverride property.
            /// </summary>
            /// <param name="value">Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</param>
            public GroupsV2GroupOptionsEditActionBuilder UpdateBannerPermissionOverride(bool? value)
            {
                _UpdateBannerPermissionOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionsEditAction.JoinLevel property.
            /// </summary>
            /// <param name="value">Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.</param>
            public GroupsV2GroupOptionsEditActionBuilder JoinLevel(JoinLevelEnum? value)
            {
                _JoinLevel = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupOptionsEditAction.
            /// </summary>
            /// <returns>GroupsV2GroupOptionsEditAction</returns>
            public GroupsV2GroupOptionsEditAction Build()
            {
                Validate();
                return new GroupsV2GroupOptionsEditAction(
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

        
        public enum HostGuidedGamePermissionOverrideEnum { _0, _1, _2 };
        public enum JoinLevelEnum { _0, _1, _2, _3, _4, _5 };
    }
}