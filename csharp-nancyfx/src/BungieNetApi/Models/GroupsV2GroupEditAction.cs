using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupEditAction
    /// </summary>
    public sealed class GroupsV2GroupEditAction:  IEquatable<GroupsV2GroupEditAction>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// About
        /// </summary>
        public string About { get; private set; }

        /// <summary>
        /// Motto
        /// </summary>
        public string Motto { get; private set; }

        /// <summary>
        /// Theme
        /// </summary>
        public string Theme { get; private set; }

        /// <summary>
        /// AvatarImageIndex
        /// </summary>
        public int? AvatarImageIndex { get; private set; }

        /// <summary>
        /// Tags
        /// </summary>
        public string Tags { get; private set; }

        /// <summary>
        /// IsPublic
        /// </summary>
        public bool? IsPublic { get; private set; }

        /// <summary>
        /// MembershipOption
        /// </summary>
        public MembershipOptionEnum? MembershipOption { get; private set; }

        /// <summary>
        /// IsPublicTopicAdminOnly
        /// </summary>
        public bool? IsPublicTopicAdminOnly { get; private set; }

        /// <summary>
        /// AllowChat
        /// </summary>
        public bool? AllowChat { get; private set; }

        /// <summary>
        /// ChatSecurity
        /// </summary>
        public ChatSecurityEnum? ChatSecurity { get; private set; }

        /// <summary>
        /// Callsign
        /// </summary>
        public string Callsign { get; private set; }

        /// <summary>
        /// Locale
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// Homepage
        /// </summary>
        public HomepageEnum? Homepage { get; private set; }

        /// <summary>
        /// EnableInvitationMessagingForAdmins
        /// </summary>
        public bool? EnableInvitationMessagingForAdmins { get; private set; }

        /// <summary>
        /// DefaultPublicity
        /// </summary>
        public DefaultPublicityEnum? DefaultPublicity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupEditAction.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupEditAction()
        {
        }

        private GroupsV2GroupEditAction(string Name, string About, string Motto, string Theme, int? AvatarImageIndex, string Tags, bool? IsPublic, MembershipOptionEnum? MembershipOption, bool? IsPublicTopicAdminOnly, bool? AllowChat, ChatSecurityEnum? ChatSecurity, string Callsign, string Locale, HomepageEnum? Homepage, bool? EnableInvitationMessagingForAdmins, DefaultPublicityEnum? DefaultPublicity)
        {
            
            this.Name = Name;
            
            this.About = About;
            
            this.Motto = Motto;
            
            this.Theme = Theme;
            
            this.AvatarImageIndex = AvatarImageIndex;
            
            this.Tags = Tags;
            
            this.IsPublic = IsPublic;
            
            this.MembershipOption = MembershipOption;
            
            this.IsPublicTopicAdminOnly = IsPublicTopicAdminOnly;
            
            this.AllowChat = AllowChat;
            
            this.ChatSecurity = ChatSecurity;
            
            this.Callsign = Callsign;
            
            this.Locale = Locale;
            
            this.Homepage = Homepage;
            
            this.EnableInvitationMessagingForAdmins = EnableInvitationMessagingForAdmins;
            
            this.DefaultPublicity = DefaultPublicity;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupEditAction.
        /// </summary>
        /// <returns>GroupsV2GroupEditActionBuilder</returns>
        public static GroupsV2GroupEditActionBuilder Builder()
        {
            return new GroupsV2GroupEditActionBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupEditActionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupEditActionBuilder</returns>
        public GroupsV2GroupEditActionBuilder With()
        {
            return Builder()
                .Name(Name)
                .About(About)
                .Motto(Motto)
                .Theme(Theme)
                .AvatarImageIndex(AvatarImageIndex)
                .Tags(Tags)
                .IsPublic(IsPublic)
                .MembershipOption(MembershipOption)
                .IsPublicTopicAdminOnly(IsPublicTopicAdminOnly)
                .AllowChat(AllowChat)
                .ChatSecurity(ChatSecurity)
                .Callsign(Callsign)
                .Locale(Locale)
                .Homepage(Homepage)
                .EnableInvitationMessagingForAdmins(EnableInvitationMessagingForAdmins)
                .DefaultPublicity(DefaultPublicity);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupEditAction other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupEditAction.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupEditAction</param>
        /// <param name="right">Compared (GroupsV2GroupEditAction</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupEditAction left, GroupsV2GroupEditAction right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupEditAction.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupEditAction</param>
        /// <param name="right">Compared (GroupsV2GroupEditAction</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupEditAction left, GroupsV2GroupEditAction right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupEditAction.
        /// </summary>
        public sealed class GroupsV2GroupEditActionBuilder
        {
            private string _Name;
            private string _About;
            private string _Motto;
            private string _Theme;
            private int? _AvatarImageIndex;
            private string _Tags;
            private bool? _IsPublic;
            private MembershipOptionEnum? _MembershipOption;
            private bool? _IsPublicTopicAdminOnly;
            private bool? _AllowChat;
            private ChatSecurityEnum? _ChatSecurity;
            private string _Callsign;
            private string _Locale;
            private HomepageEnum? _Homepage;
            private bool? _EnableInvitationMessagingForAdmins;
            private DefaultPublicityEnum? _DefaultPublicity;

            internal GroupsV2GroupEditActionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public GroupsV2GroupEditActionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.About property.
            /// </summary>
            /// <param name="value">About</param>
            public GroupsV2GroupEditActionBuilder About(string value)
            {
                _About = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Motto property.
            /// </summary>
            /// <param name="value">Motto</param>
            public GroupsV2GroupEditActionBuilder Motto(string value)
            {
                _Motto = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Theme property.
            /// </summary>
            /// <param name="value">Theme</param>
            public GroupsV2GroupEditActionBuilder Theme(string value)
            {
                _Theme = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.AvatarImageIndex property.
            /// </summary>
            /// <param name="value">AvatarImageIndex</param>
            public GroupsV2GroupEditActionBuilder AvatarImageIndex(int? value)
            {
                _AvatarImageIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Tags property.
            /// </summary>
            /// <param name="value">Tags</param>
            public GroupsV2GroupEditActionBuilder Tags(string value)
            {
                _Tags = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.IsPublic property.
            /// </summary>
            /// <param name="value">IsPublic</param>
            public GroupsV2GroupEditActionBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.MembershipOption property.
            /// </summary>
            /// <param name="value">MembershipOption</param>
            public GroupsV2GroupEditActionBuilder MembershipOption(MembershipOptionEnum? value)
            {
                _MembershipOption = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.IsPublicTopicAdminOnly property.
            /// </summary>
            /// <param name="value">IsPublicTopicAdminOnly</param>
            public GroupsV2GroupEditActionBuilder IsPublicTopicAdminOnly(bool? value)
            {
                _IsPublicTopicAdminOnly = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.AllowChat property.
            /// </summary>
            /// <param name="value">AllowChat</param>
            public GroupsV2GroupEditActionBuilder AllowChat(bool? value)
            {
                _AllowChat = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.ChatSecurity property.
            /// </summary>
            /// <param name="value">ChatSecurity</param>
            public GroupsV2GroupEditActionBuilder ChatSecurity(ChatSecurityEnum? value)
            {
                _ChatSecurity = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Callsign property.
            /// </summary>
            /// <param name="value">Callsign</param>
            public GroupsV2GroupEditActionBuilder Callsign(string value)
            {
                _Callsign = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Locale property.
            /// </summary>
            /// <param name="value">Locale</param>
            public GroupsV2GroupEditActionBuilder Locale(string value)
            {
                _Locale = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.Homepage property.
            /// </summary>
            /// <param name="value">Homepage</param>
            public GroupsV2GroupEditActionBuilder Homepage(HomepageEnum? value)
            {
                _Homepage = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.EnableInvitationMessagingForAdmins property.
            /// </summary>
            /// <param name="value">EnableInvitationMessagingForAdmins</param>
            public GroupsV2GroupEditActionBuilder EnableInvitationMessagingForAdmins(bool? value)
            {
                _EnableInvitationMessagingForAdmins = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupEditAction.DefaultPublicity property.
            /// </summary>
            /// <param name="value">DefaultPublicity</param>
            public GroupsV2GroupEditActionBuilder DefaultPublicity(DefaultPublicityEnum? value)
            {
                _DefaultPublicity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupEditAction.
            /// </summary>
            /// <returns>GroupsV2GroupEditAction</returns>
            public GroupsV2GroupEditAction Build()
            {
                Validate();
                return new GroupsV2GroupEditAction(
                    Name: _Name,
                    About: _About,
                    Motto: _Motto,
                    Theme: _Theme,
                    AvatarImageIndex: _AvatarImageIndex,
                    Tags: _Tags,
                    IsPublic: _IsPublic,
                    MembershipOption: _MembershipOption,
                    IsPublicTopicAdminOnly: _IsPublicTopicAdminOnly,
                    AllowChat: _AllowChat,
                    ChatSecurity: _ChatSecurity,
                    Callsign: _Callsign,
                    Locale: _Locale,
                    Homepage: _Homepage,
                    EnableInvitationMessagingForAdmins: _EnableInvitationMessagingForAdmins,
                    DefaultPublicity: _DefaultPublicity
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum MembershipOptionEnum { _0, _1, _2 };
        public enum ChatSecurityEnum { _0, _1 };
        public enum HomepageEnum { _0, _1, _2 };
        public enum DefaultPublicityEnum { _0, _1, _2 };
    }
}