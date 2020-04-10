using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A small infocard of group information, usually used for when a list of groups are returned
    /// </summary>
    public sealed class GroupsV2GroupV2Card:  IEquatable<GroupsV2GroupV2Card>
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
        /// CreationDate
        /// </summary>
        public DateTime? CreationDate { get; private set; }

        /// <summary>
        /// About
        /// </summary>
        public string About { get; private set; }

        /// <summary>
        /// Motto
        /// </summary>
        public string Motto { get; private set; }

        /// <summary>
        /// MemberCount
        /// </summary>
        public int? MemberCount { get; private set; }

        /// <summary>
        /// Locale
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// MembershipOption
        /// </summary>
        public int? MembershipOption { get; private set; }

        /// <summary>
        /// Capabilities
        /// </summary>
        public int? Capabilities { get; private set; }

        /// <summary>
        /// ClanInfo
        /// </summary>
        public GroupsV2GroupV2ClanInfo ClanInfo { get; private set; }

        /// <summary>
        /// AvatarPath
        /// </summary>
        public string AvatarPath { get; private set; }

        /// <summary>
        /// Theme
        /// </summary>
        public string Theme { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupV2Card.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupV2Card()
        {
        }

        private GroupsV2GroupV2Card(long? GroupId, string Name, int? GroupType, DateTime? CreationDate, string About, string Motto, int? MemberCount, string Locale, int? MembershipOption, int? Capabilities, GroupsV2GroupV2ClanInfo ClanInfo, string AvatarPath, string Theme)
        {
            
            this.GroupId = GroupId;
            
            this.Name = Name;
            
            this.GroupType = GroupType;
            
            this.CreationDate = CreationDate;
            
            this.About = About;
            
            this.Motto = Motto;
            
            this.MemberCount = MemberCount;
            
            this.Locale = Locale;
            
            this.MembershipOption = MembershipOption;
            
            this.Capabilities = Capabilities;
            
            this.ClanInfo = ClanInfo;
            
            this.AvatarPath = AvatarPath;
            
            this.Theme = Theme;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupV2Card.
        /// </summary>
        /// <returns>GroupsV2GroupV2CardBuilder</returns>
        public static GroupsV2GroupV2CardBuilder Builder()
        {
            return new GroupsV2GroupV2CardBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupV2CardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupV2CardBuilder</returns>
        public GroupsV2GroupV2CardBuilder With()
        {
            return Builder()
                .GroupId(GroupId)
                .Name(Name)
                .GroupType(GroupType)
                .CreationDate(CreationDate)
                .About(About)
                .Motto(Motto)
                .MemberCount(MemberCount)
                .Locale(Locale)
                .MembershipOption(MembershipOption)
                .Capabilities(Capabilities)
                .ClanInfo(ClanInfo)
                .AvatarPath(AvatarPath)
                .Theme(Theme);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupV2Card other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupV2Card.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2Card</param>
        /// <param name="right">Compared (GroupsV2GroupV2Card</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupV2Card left, GroupsV2GroupV2Card right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupV2Card.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2Card</param>
        /// <param name="right">Compared (GroupsV2GroupV2Card</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupV2Card left, GroupsV2GroupV2Card right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupV2Card.
        /// </summary>
        public sealed class GroupsV2GroupV2CardBuilder
        {
            private long? _GroupId;
            private string _Name;
            private int? _GroupType;
            private DateTime? _CreationDate;
            private string _About;
            private string _Motto;
            private int? _MemberCount;
            private string _Locale;
            private int? _MembershipOption;
            private int? _Capabilities;
            private GroupsV2GroupV2ClanInfo _ClanInfo;
            private string _AvatarPath;
            private string _Theme;

            internal GroupsV2GroupV2CardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupV2CardBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public GroupsV2GroupV2CardBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.GroupType property.
            /// </summary>
            /// <param name="value">GroupType</param>
            public GroupsV2GroupV2CardBuilder GroupType(int? value)
            {
                _GroupType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.CreationDate property.
            /// </summary>
            /// <param name="value">CreationDate</param>
            public GroupsV2GroupV2CardBuilder CreationDate(DateTime? value)
            {
                _CreationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.About property.
            /// </summary>
            /// <param name="value">About</param>
            public GroupsV2GroupV2CardBuilder About(string value)
            {
                _About = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.Motto property.
            /// </summary>
            /// <param name="value">Motto</param>
            public GroupsV2GroupV2CardBuilder Motto(string value)
            {
                _Motto = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.MemberCount property.
            /// </summary>
            /// <param name="value">MemberCount</param>
            public GroupsV2GroupV2CardBuilder MemberCount(int? value)
            {
                _MemberCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.Locale property.
            /// </summary>
            /// <param name="value">Locale</param>
            public GroupsV2GroupV2CardBuilder Locale(string value)
            {
                _Locale = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.MembershipOption property.
            /// </summary>
            /// <param name="value">MembershipOption</param>
            public GroupsV2GroupV2CardBuilder MembershipOption(int? value)
            {
                _MembershipOption = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.Capabilities property.
            /// </summary>
            /// <param name="value">Capabilities</param>
            public GroupsV2GroupV2CardBuilder Capabilities(int? value)
            {
                _Capabilities = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.ClanInfo property.
            /// </summary>
            /// <param name="value">ClanInfo</param>
            public GroupsV2GroupV2CardBuilder ClanInfo(GroupsV2GroupV2ClanInfo value)
            {
                _ClanInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.AvatarPath property.
            /// </summary>
            /// <param name="value">AvatarPath</param>
            public GroupsV2GroupV2CardBuilder AvatarPath(string value)
            {
                _AvatarPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2Card.Theme property.
            /// </summary>
            /// <param name="value">Theme</param>
            public GroupsV2GroupV2CardBuilder Theme(string value)
            {
                _Theme = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupV2Card.
            /// </summary>
            /// <returns>GroupsV2GroupV2Card</returns>
            public GroupsV2GroupV2Card Build()
            {
                Validate();
                return new GroupsV2GroupV2Card(
                    GroupId: _GroupId,
                    Name: _Name,
                    GroupType: _GroupType,
                    CreationDate: _CreationDate,
                    About: _About,
                    Motto: _Motto,
                    MemberCount: _MemberCount,
                    Locale: _Locale,
                    MembershipOption: _MembershipOption,
                    Capabilities: _Capabilities,
                    ClanInfo: _ClanInfo,
                    AvatarPath: _AvatarPath,
                    Theme: _Theme
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}