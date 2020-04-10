using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupV2
    /// </summary>
    public sealed class GroupsV2GroupV2:  IEquatable<GroupsV2GroupV2>
    { 
        /// <summary>
        /// GroupId
        /// </summary>
        public long? GroupId { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// GroupType
        /// </summary>
        public int? GroupType { get; private set; }

        /// <summary>
        /// MembershipIdCreated
        /// </summary>
        public long? MembershipIdCreated { get; private set; }

        /// <summary>
        /// CreationDate
        /// </summary>
        public DateTime? CreationDate { get; private set; }

        /// <summary>
        /// ModificationDate
        /// </summary>
        public DateTime? ModificationDate { get; private set; }

        /// <summary>
        /// About
        /// </summary>
        public string About { get; private set; }

        /// <summary>
        /// Tags
        /// </summary>
        public List<string> Tags { get; private set; }

        /// <summary>
        /// MemberCount
        /// </summary>
        public int? MemberCount { get; private set; }

        /// <summary>
        /// IsPublic
        /// </summary>
        public bool? IsPublic { get; private set; }

        /// <summary>
        /// IsPublicTopicAdminOnly
        /// </summary>
        public bool? IsPublicTopicAdminOnly { get; private set; }

        /// <summary>
        /// Motto
        /// </summary>
        public string Motto { get; private set; }

        /// <summary>
        /// AllowChat
        /// </summary>
        public bool? AllowChat { get; private set; }

        /// <summary>
        /// IsDefaultPostPublic
        /// </summary>
        public bool? IsDefaultPostPublic { get; private set; }

        /// <summary>
        /// ChatSecurity
        /// </summary>
        public int? ChatSecurity { get; private set; }

        /// <summary>
        /// Locale
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// AvatarImageIndex
        /// </summary>
        public int? AvatarImageIndex { get; private set; }

        /// <summary>
        /// Homepage
        /// </summary>
        public int? Homepage { get; private set; }

        /// <summary>
        /// MembershipOption
        /// </summary>
        public int? MembershipOption { get; private set; }

        /// <summary>
        /// DefaultPublicity
        /// </summary>
        public int? DefaultPublicity { get; private set; }

        /// <summary>
        /// Theme
        /// </summary>
        public string Theme { get; private set; }

        /// <summary>
        /// BannerPath
        /// </summary>
        public string BannerPath { get; private set; }

        /// <summary>
        /// AvatarPath
        /// </summary>
        public string AvatarPath { get; private set; }

        /// <summary>
        /// ConversationId
        /// </summary>
        public long? ConversationId { get; private set; }

        /// <summary>
        /// EnableInvitationMessagingForAdmins
        /// </summary>
        public bool? EnableInvitationMessagingForAdmins { get; private set; }

        /// <summary>
        /// BanExpireDate
        /// </summary>
        public DateTime? BanExpireDate { get; private set; }

        /// <summary>
        /// Features
        /// </summary>
        public GroupsV2GroupFeatures Features { get; private set; }

        /// <summary>
        /// ClanInfo
        /// </summary>
        public GroupsV2GroupV2ClanInfoAndInvestment ClanInfo { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupV2.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupV2()
        {
        }

        private GroupsV2GroupV2(long? GroupId, string Name, int? GroupType, long? MembershipIdCreated, DateTime? CreationDate, DateTime? ModificationDate, string About, List<string> Tags, int? MemberCount, bool? IsPublic, bool? IsPublicTopicAdminOnly, string Motto, bool? AllowChat, bool? IsDefaultPostPublic, int? ChatSecurity, string Locale, int? AvatarImageIndex, int? Homepage, int? MembershipOption, int? DefaultPublicity, string Theme, string BannerPath, string AvatarPath, long? ConversationId, bool? EnableInvitationMessagingForAdmins, DateTime? BanExpireDate, GroupsV2GroupFeatures Features, GroupsV2GroupV2ClanInfoAndInvestment ClanInfo)
        {
            
            this.GroupId = GroupId;
            
            this.Name = Name;
            
            this.GroupType = GroupType;
            
            this.MembershipIdCreated = MembershipIdCreated;
            
            this.CreationDate = CreationDate;
            
            this.ModificationDate = ModificationDate;
            
            this.About = About;
            
            this.Tags = Tags;
            
            this.MemberCount = MemberCount;
            
            this.IsPublic = IsPublic;
            
            this.IsPublicTopicAdminOnly = IsPublicTopicAdminOnly;
            
            this.Motto = Motto;
            
            this.AllowChat = AllowChat;
            
            this.IsDefaultPostPublic = IsDefaultPostPublic;
            
            this.ChatSecurity = ChatSecurity;
            
            this.Locale = Locale;
            
            this.AvatarImageIndex = AvatarImageIndex;
            
            this.Homepage = Homepage;
            
            this.MembershipOption = MembershipOption;
            
            this.DefaultPublicity = DefaultPublicity;
            
            this.Theme = Theme;
            
            this.BannerPath = BannerPath;
            
            this.AvatarPath = AvatarPath;
            
            this.ConversationId = ConversationId;
            
            this.EnableInvitationMessagingForAdmins = EnableInvitationMessagingForAdmins;
            
            this.BanExpireDate = BanExpireDate;
            
            this.Features = Features;
            
            this.ClanInfo = ClanInfo;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupV2.
        /// </summary>
        /// <returns>GroupsV2GroupV2Builder</returns>
        public static GroupsV2GroupV2Builder Builder()
        {
            return new GroupsV2GroupV2Builder();
        }

        /// <summary>
        /// Returns GroupsV2GroupV2Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupV2Builder</returns>
        public GroupsV2GroupV2Builder With()
        {
            return Builder()
                .GroupId(GroupId)
                .Name(Name)
                .GroupType(GroupType)
                .MembershipIdCreated(MembershipIdCreated)
                .CreationDate(CreationDate)
                .ModificationDate(ModificationDate)
                .About(About)
                .Tags(Tags)
                .MemberCount(MemberCount)
                .IsPublic(IsPublic)
                .IsPublicTopicAdminOnly(IsPublicTopicAdminOnly)
                .Motto(Motto)
                .AllowChat(AllowChat)
                .IsDefaultPostPublic(IsDefaultPostPublic)
                .ChatSecurity(ChatSecurity)
                .Locale(Locale)
                .AvatarImageIndex(AvatarImageIndex)
                .Homepage(Homepage)
                .MembershipOption(MembershipOption)
                .DefaultPublicity(DefaultPublicity)
                .Theme(Theme)
                .BannerPath(BannerPath)
                .AvatarPath(AvatarPath)
                .ConversationId(ConversationId)
                .EnableInvitationMessagingForAdmins(EnableInvitationMessagingForAdmins)
                .BanExpireDate(BanExpireDate)
                .Features(Features)
                .ClanInfo(ClanInfo);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupV2 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupV2.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2</param>
        /// <param name="right">Compared (GroupsV2GroupV2</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupV2 left, GroupsV2GroupV2 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupV2.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2</param>
        /// <param name="right">Compared (GroupsV2GroupV2</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupV2 left, GroupsV2GroupV2 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupV2.
        /// </summary>
        public sealed class GroupsV2GroupV2Builder
        {
            private long? _GroupId;
            private string _Name;
            private int? _GroupType;
            private long? _MembershipIdCreated;
            private DateTime? _CreationDate;
            private DateTime? _ModificationDate;
            private string _About;
            private List<string> _Tags;
            private int? _MemberCount;
            private bool? _IsPublic;
            private bool? _IsPublicTopicAdminOnly;
            private string _Motto;
            private bool? _AllowChat;
            private bool? _IsDefaultPostPublic;
            private int? _ChatSecurity;
            private string _Locale;
            private int? _AvatarImageIndex;
            private int? _Homepage;
            private int? _MembershipOption;
            private int? _DefaultPublicity;
            private string _Theme;
            private string _BannerPath;
            private string _AvatarPath;
            private long? _ConversationId;
            private bool? _EnableInvitationMessagingForAdmins;
            private DateTime? _BanExpireDate;
            private GroupsV2GroupFeatures _Features;
            private GroupsV2GroupV2ClanInfoAndInvestment _ClanInfo;

            internal GroupsV2GroupV2Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupV2Builder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public GroupsV2GroupV2Builder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.GroupType property.
            /// </summary>
            /// <param name="value">GroupType</param>
            public GroupsV2GroupV2Builder GroupType(int? value)
            {
                _GroupType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.MembershipIdCreated property.
            /// </summary>
            /// <param name="value">MembershipIdCreated</param>
            public GroupsV2GroupV2Builder MembershipIdCreated(long? value)
            {
                _MembershipIdCreated = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.CreationDate property.
            /// </summary>
            /// <param name="value">CreationDate</param>
            public GroupsV2GroupV2Builder CreationDate(DateTime? value)
            {
                _CreationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.ModificationDate property.
            /// </summary>
            /// <param name="value">ModificationDate</param>
            public GroupsV2GroupV2Builder ModificationDate(DateTime? value)
            {
                _ModificationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.About property.
            /// </summary>
            /// <param name="value">About</param>
            public GroupsV2GroupV2Builder About(string value)
            {
                _About = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Tags property.
            /// </summary>
            /// <param name="value">Tags</param>
            public GroupsV2GroupV2Builder Tags(List<string> value)
            {
                _Tags = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.MemberCount property.
            /// </summary>
            /// <param name="value">MemberCount</param>
            public GroupsV2GroupV2Builder MemberCount(int? value)
            {
                _MemberCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.IsPublic property.
            /// </summary>
            /// <param name="value">IsPublic</param>
            public GroupsV2GroupV2Builder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.IsPublicTopicAdminOnly property.
            /// </summary>
            /// <param name="value">IsPublicTopicAdminOnly</param>
            public GroupsV2GroupV2Builder IsPublicTopicAdminOnly(bool? value)
            {
                _IsPublicTopicAdminOnly = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Motto property.
            /// </summary>
            /// <param name="value">Motto</param>
            public GroupsV2GroupV2Builder Motto(string value)
            {
                _Motto = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.AllowChat property.
            /// </summary>
            /// <param name="value">AllowChat</param>
            public GroupsV2GroupV2Builder AllowChat(bool? value)
            {
                _AllowChat = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.IsDefaultPostPublic property.
            /// </summary>
            /// <param name="value">IsDefaultPostPublic</param>
            public GroupsV2GroupV2Builder IsDefaultPostPublic(bool? value)
            {
                _IsDefaultPostPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.ChatSecurity property.
            /// </summary>
            /// <param name="value">ChatSecurity</param>
            public GroupsV2GroupV2Builder ChatSecurity(int? value)
            {
                _ChatSecurity = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Locale property.
            /// </summary>
            /// <param name="value">Locale</param>
            public GroupsV2GroupV2Builder Locale(string value)
            {
                _Locale = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.AvatarImageIndex property.
            /// </summary>
            /// <param name="value">AvatarImageIndex</param>
            public GroupsV2GroupV2Builder AvatarImageIndex(int? value)
            {
                _AvatarImageIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Homepage property.
            /// </summary>
            /// <param name="value">Homepage</param>
            public GroupsV2GroupV2Builder Homepage(int? value)
            {
                _Homepage = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.MembershipOption property.
            /// </summary>
            /// <param name="value">MembershipOption</param>
            public GroupsV2GroupV2Builder MembershipOption(int? value)
            {
                _MembershipOption = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.DefaultPublicity property.
            /// </summary>
            /// <param name="value">DefaultPublicity</param>
            public GroupsV2GroupV2Builder DefaultPublicity(int? value)
            {
                _DefaultPublicity = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Theme property.
            /// </summary>
            /// <param name="value">Theme</param>
            public GroupsV2GroupV2Builder Theme(string value)
            {
                _Theme = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.BannerPath property.
            /// </summary>
            /// <param name="value">BannerPath</param>
            public GroupsV2GroupV2Builder BannerPath(string value)
            {
                _BannerPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.AvatarPath property.
            /// </summary>
            /// <param name="value">AvatarPath</param>
            public GroupsV2GroupV2Builder AvatarPath(string value)
            {
                _AvatarPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.ConversationId property.
            /// </summary>
            /// <param name="value">ConversationId</param>
            public GroupsV2GroupV2Builder ConversationId(long? value)
            {
                _ConversationId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.EnableInvitationMessagingForAdmins property.
            /// </summary>
            /// <param name="value">EnableInvitationMessagingForAdmins</param>
            public GroupsV2GroupV2Builder EnableInvitationMessagingForAdmins(bool? value)
            {
                _EnableInvitationMessagingForAdmins = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.BanExpireDate property.
            /// </summary>
            /// <param name="value">BanExpireDate</param>
            public GroupsV2GroupV2Builder BanExpireDate(DateTime? value)
            {
                _BanExpireDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.Features property.
            /// </summary>
            /// <param name="value">Features</param>
            public GroupsV2GroupV2Builder Features(GroupsV2GroupFeatures value)
            {
                _Features = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2.ClanInfo property.
            /// </summary>
            /// <param name="value">ClanInfo</param>
            public GroupsV2GroupV2Builder ClanInfo(GroupsV2GroupV2ClanInfoAndInvestment value)
            {
                _ClanInfo = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupV2.
            /// </summary>
            /// <returns>GroupsV2GroupV2</returns>
            public GroupsV2GroupV2 Build()
            {
                Validate();
                return new GroupsV2GroupV2(
                    GroupId: _GroupId,
                    Name: _Name,
                    GroupType: _GroupType,
                    MembershipIdCreated: _MembershipIdCreated,
                    CreationDate: _CreationDate,
                    ModificationDate: _ModificationDate,
                    About: _About,
                    Tags: _Tags,
                    MemberCount: _MemberCount,
                    IsPublic: _IsPublic,
                    IsPublicTopicAdminOnly: _IsPublicTopicAdminOnly,
                    Motto: _Motto,
                    AllowChat: _AllowChat,
                    IsDefaultPostPublic: _IsDefaultPostPublic,
                    ChatSecurity: _ChatSecurity,
                    Locale: _Locale,
                    AvatarImageIndex: _AvatarImageIndex,
                    Homepage: _Homepage,
                    MembershipOption: _MembershipOption,
                    DefaultPublicity: _DefaultPublicity,
                    Theme: _Theme,
                    BannerPath: _BannerPath,
                    AvatarPath: _AvatarPath,
                    ConversationId: _ConversationId,
                    EnableInvitationMessagingForAdmins: _EnableInvitationMessagingForAdmins,
                    BanExpireDate: _BanExpireDate,
                    Features: _Features,
                    ClanInfo: _ClanInfo
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}