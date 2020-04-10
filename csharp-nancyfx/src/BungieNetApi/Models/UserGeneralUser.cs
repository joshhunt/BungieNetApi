using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// UserGeneralUser
    /// </summary>
    public sealed class UserGeneralUser:  IEquatable<UserGeneralUser>
    { 
        /// <summary>
        /// MembershipId
        /// </summary>
        public long? MembershipId { get; private set; }

        /// <summary>
        /// UniqueName
        /// </summary>
        public string UniqueName { get; private set; }

        /// <summary>
        /// NormalizedName
        /// </summary>
        public string NormalizedName { get; private set; }

        /// <summary>
        /// DisplayName
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// ProfilePicture
        /// </summary>
        public int? ProfilePicture { get; private set; }

        /// <summary>
        /// ProfileTheme
        /// </summary>
        public int? ProfileTheme { get; private set; }

        /// <summary>
        /// UserTitle
        /// </summary>
        public int? UserTitle { get; private set; }

        /// <summary>
        /// SuccessMessageFlags
        /// </summary>
        public long? SuccessMessageFlags { get; private set; }

        /// <summary>
        /// IsDeleted
        /// </summary>
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// About
        /// </summary>
        public string About { get; private set; }

        /// <summary>
        /// FirstAccess
        /// </summary>
        public DateTime? FirstAccess { get; private set; }

        /// <summary>
        /// LastUpdate
        /// </summary>
        public DateTime? LastUpdate { get; private set; }

        /// <summary>
        /// LegacyPortalUID
        /// </summary>
        public long? LegacyPortalUID { get; private set; }

        /// <summary>
        /// Context
        /// </summary>
        public UserUserToUserContext Context { get; private set; }

        /// <summary>
        /// PsnDisplayName
        /// </summary>
        public string PsnDisplayName { get; private set; }

        /// <summary>
        /// XboxDisplayName
        /// </summary>
        public string XboxDisplayName { get; private set; }

        /// <summary>
        /// FbDisplayName
        /// </summary>
        public string FbDisplayName { get; private set; }

        /// <summary>
        /// ShowActivity
        /// </summary>
        public bool? ShowActivity { get; private set; }

        /// <summary>
        /// Locale
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// LocaleInheritDefault
        /// </summary>
        public bool? LocaleInheritDefault { get; private set; }

        /// <summary>
        /// LastBanReportId
        /// </summary>
        public long? LastBanReportId { get; private set; }

        /// <summary>
        /// ShowGroupMessaging
        /// </summary>
        public bool? ShowGroupMessaging { get; private set; }

        /// <summary>
        /// ProfilePicturePath
        /// </summary>
        public string ProfilePicturePath { get; private set; }

        /// <summary>
        /// ProfilePictureWidePath
        /// </summary>
        public string ProfilePictureWidePath { get; private set; }

        /// <summary>
        /// ProfileThemeName
        /// </summary>
        public string ProfileThemeName { get; private set; }

        /// <summary>
        /// UserTitleDisplay
        /// </summary>
        public string UserTitleDisplay { get; private set; }

        /// <summary>
        /// StatusText
        /// </summary>
        public string StatusText { get; private set; }

        /// <summary>
        /// StatusDate
        /// </summary>
        public DateTime? StatusDate { get; private set; }

        /// <summary>
        /// ProfileBanExpire
        /// </summary>
        public DateTime? ProfileBanExpire { get; private set; }

        /// <summary>
        /// BlizzardDisplayName
        /// </summary>
        public string BlizzardDisplayName { get; private set; }

        /// <summary>
        /// SteamDisplayName
        /// </summary>
        public string SteamDisplayName { get; private set; }

        /// <summary>
        /// StadiaDisplayName
        /// </summary>
        public string StadiaDisplayName { get; private set; }

        /// <summary>
        /// TwitchDisplayName
        /// </summary>
        public string TwitchDisplayName { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserGeneralUser.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserGeneralUser()
        {
        }

        private UserGeneralUser(long? MembershipId, string UniqueName, string NormalizedName, string DisplayName, int? ProfilePicture, int? ProfileTheme, int? UserTitle, long? SuccessMessageFlags, bool? IsDeleted, string About, DateTime? FirstAccess, DateTime? LastUpdate, long? LegacyPortalUID, UserUserToUserContext Context, string PsnDisplayName, string XboxDisplayName, string FbDisplayName, bool? ShowActivity, string Locale, bool? LocaleInheritDefault, long? LastBanReportId, bool? ShowGroupMessaging, string ProfilePicturePath, string ProfilePictureWidePath, string ProfileThemeName, string UserTitleDisplay, string StatusText, DateTime? StatusDate, DateTime? ProfileBanExpire, string BlizzardDisplayName, string SteamDisplayName, string StadiaDisplayName, string TwitchDisplayName)
        {
            
            this.MembershipId = MembershipId;
            
            this.UniqueName = UniqueName;
            
            this.NormalizedName = NormalizedName;
            
            this.DisplayName = DisplayName;
            
            this.ProfilePicture = ProfilePicture;
            
            this.ProfileTheme = ProfileTheme;
            
            this.UserTitle = UserTitle;
            
            this.SuccessMessageFlags = SuccessMessageFlags;
            
            this.IsDeleted = IsDeleted;
            
            this.About = About;
            
            this.FirstAccess = FirstAccess;
            
            this.LastUpdate = LastUpdate;
            
            this.LegacyPortalUID = LegacyPortalUID;
            
            this.Context = Context;
            
            this.PsnDisplayName = PsnDisplayName;
            
            this.XboxDisplayName = XboxDisplayName;
            
            this.FbDisplayName = FbDisplayName;
            
            this.ShowActivity = ShowActivity;
            
            this.Locale = Locale;
            
            this.LocaleInheritDefault = LocaleInheritDefault;
            
            this.LastBanReportId = LastBanReportId;
            
            this.ShowGroupMessaging = ShowGroupMessaging;
            
            this.ProfilePicturePath = ProfilePicturePath;
            
            this.ProfilePictureWidePath = ProfilePictureWidePath;
            
            this.ProfileThemeName = ProfileThemeName;
            
            this.UserTitleDisplay = UserTitleDisplay;
            
            this.StatusText = StatusText;
            
            this.StatusDate = StatusDate;
            
            this.ProfileBanExpire = ProfileBanExpire;
            
            this.BlizzardDisplayName = BlizzardDisplayName;
            
            this.SteamDisplayName = SteamDisplayName;
            
            this.StadiaDisplayName = StadiaDisplayName;
            
            this.TwitchDisplayName = TwitchDisplayName;
            
        }

        /// <summary>
        /// Returns builder of UserGeneralUser.
        /// </summary>
        /// <returns>UserGeneralUserBuilder</returns>
        public static UserGeneralUserBuilder Builder()
        {
            return new UserGeneralUserBuilder();
        }

        /// <summary>
        /// Returns UserGeneralUserBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserGeneralUserBuilder</returns>
        public UserGeneralUserBuilder With()
        {
            return Builder()
                .MembershipId(MembershipId)
                .UniqueName(UniqueName)
                .NormalizedName(NormalizedName)
                .DisplayName(DisplayName)
                .ProfilePicture(ProfilePicture)
                .ProfileTheme(ProfileTheme)
                .UserTitle(UserTitle)
                .SuccessMessageFlags(SuccessMessageFlags)
                .IsDeleted(IsDeleted)
                .About(About)
                .FirstAccess(FirstAccess)
                .LastUpdate(LastUpdate)
                .LegacyPortalUID(LegacyPortalUID)
                .Context(Context)
                .PsnDisplayName(PsnDisplayName)
                .XboxDisplayName(XboxDisplayName)
                .FbDisplayName(FbDisplayName)
                .ShowActivity(ShowActivity)
                .Locale(Locale)
                .LocaleInheritDefault(LocaleInheritDefault)
                .LastBanReportId(LastBanReportId)
                .ShowGroupMessaging(ShowGroupMessaging)
                .ProfilePicturePath(ProfilePicturePath)
                .ProfilePictureWidePath(ProfilePictureWidePath)
                .ProfileThemeName(ProfileThemeName)
                .UserTitleDisplay(UserTitleDisplay)
                .StatusText(StatusText)
                .StatusDate(StatusDate)
                .ProfileBanExpire(ProfileBanExpire)
                .BlizzardDisplayName(BlizzardDisplayName)
                .SteamDisplayName(SteamDisplayName)
                .StadiaDisplayName(StadiaDisplayName)
                .TwitchDisplayName(TwitchDisplayName);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserGeneralUser other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserGeneralUser.
        /// </summary>
        /// <param name="left">Compared (UserGeneralUser</param>
        /// <param name="right">Compared (UserGeneralUser</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserGeneralUser left, UserGeneralUser right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserGeneralUser.
        /// </summary>
        /// <param name="left">Compared (UserGeneralUser</param>
        /// <param name="right">Compared (UserGeneralUser</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserGeneralUser left, UserGeneralUser right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserGeneralUser.
        /// </summary>
        public sealed class UserGeneralUserBuilder
        {
            private long? _MembershipId;
            private string _UniqueName;
            private string _NormalizedName;
            private string _DisplayName;
            private int? _ProfilePicture;
            private int? _ProfileTheme;
            private int? _UserTitle;
            private long? _SuccessMessageFlags;
            private bool? _IsDeleted;
            private string _About;
            private DateTime? _FirstAccess;
            private DateTime? _LastUpdate;
            private long? _LegacyPortalUID;
            private UserUserToUserContext _Context;
            private string _PsnDisplayName;
            private string _XboxDisplayName;
            private string _FbDisplayName;
            private bool? _ShowActivity;
            private string _Locale;
            private bool? _LocaleInheritDefault;
            private long? _LastBanReportId;
            private bool? _ShowGroupMessaging;
            private string _ProfilePicturePath;
            private string _ProfilePictureWidePath;
            private string _ProfileThemeName;
            private string _UserTitleDisplay;
            private string _StatusText;
            private DateTime? _StatusDate;
            private DateTime? _ProfileBanExpire;
            private string _BlizzardDisplayName;
            private string _SteamDisplayName;
            private string _StadiaDisplayName;
            private string _TwitchDisplayName;

            internal UserGeneralUserBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserGeneralUser.MembershipId property.
            /// </summary>
            /// <param name="value">MembershipId</param>
            public UserGeneralUserBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.UniqueName property.
            /// </summary>
            /// <param name="value">UniqueName</param>
            public UserGeneralUserBuilder UniqueName(string value)
            {
                _UniqueName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.NormalizedName property.
            /// </summary>
            /// <param name="value">NormalizedName</param>
            public UserGeneralUserBuilder NormalizedName(string value)
            {
                _NormalizedName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.DisplayName property.
            /// </summary>
            /// <param name="value">DisplayName</param>
            public UserGeneralUserBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ProfilePicture property.
            /// </summary>
            /// <param name="value">ProfilePicture</param>
            public UserGeneralUserBuilder ProfilePicture(int? value)
            {
                _ProfilePicture = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ProfileTheme property.
            /// </summary>
            /// <param name="value">ProfileTheme</param>
            public UserGeneralUserBuilder ProfileTheme(int? value)
            {
                _ProfileTheme = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.UserTitle property.
            /// </summary>
            /// <param name="value">UserTitle</param>
            public UserGeneralUserBuilder UserTitle(int? value)
            {
                _UserTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.SuccessMessageFlags property.
            /// </summary>
            /// <param name="value">SuccessMessageFlags</param>
            public UserGeneralUserBuilder SuccessMessageFlags(long? value)
            {
                _SuccessMessageFlags = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.IsDeleted property.
            /// </summary>
            /// <param name="value">IsDeleted</param>
            public UserGeneralUserBuilder IsDeleted(bool? value)
            {
                _IsDeleted = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.About property.
            /// </summary>
            /// <param name="value">About</param>
            public UserGeneralUserBuilder About(string value)
            {
                _About = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.FirstAccess property.
            /// </summary>
            /// <param name="value">FirstAccess</param>
            public UserGeneralUserBuilder FirstAccess(DateTime? value)
            {
                _FirstAccess = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.LastUpdate property.
            /// </summary>
            /// <param name="value">LastUpdate</param>
            public UserGeneralUserBuilder LastUpdate(DateTime? value)
            {
                _LastUpdate = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.LegacyPortalUID property.
            /// </summary>
            /// <param name="value">LegacyPortalUID</param>
            public UserGeneralUserBuilder LegacyPortalUID(long? value)
            {
                _LegacyPortalUID = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.Context property.
            /// </summary>
            /// <param name="value">Context</param>
            public UserGeneralUserBuilder Context(UserUserToUserContext value)
            {
                _Context = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.PsnDisplayName property.
            /// </summary>
            /// <param name="value">PsnDisplayName</param>
            public UserGeneralUserBuilder PsnDisplayName(string value)
            {
                _PsnDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.XboxDisplayName property.
            /// </summary>
            /// <param name="value">XboxDisplayName</param>
            public UserGeneralUserBuilder XboxDisplayName(string value)
            {
                _XboxDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.FbDisplayName property.
            /// </summary>
            /// <param name="value">FbDisplayName</param>
            public UserGeneralUserBuilder FbDisplayName(string value)
            {
                _FbDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ShowActivity property.
            /// </summary>
            /// <param name="value">ShowActivity</param>
            public UserGeneralUserBuilder ShowActivity(bool? value)
            {
                _ShowActivity = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.Locale property.
            /// </summary>
            /// <param name="value">Locale</param>
            public UserGeneralUserBuilder Locale(string value)
            {
                _Locale = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.LocaleInheritDefault property.
            /// </summary>
            /// <param name="value">LocaleInheritDefault</param>
            public UserGeneralUserBuilder LocaleInheritDefault(bool? value)
            {
                _LocaleInheritDefault = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.LastBanReportId property.
            /// </summary>
            /// <param name="value">LastBanReportId</param>
            public UserGeneralUserBuilder LastBanReportId(long? value)
            {
                _LastBanReportId = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ShowGroupMessaging property.
            /// </summary>
            /// <param name="value">ShowGroupMessaging</param>
            public UserGeneralUserBuilder ShowGroupMessaging(bool? value)
            {
                _ShowGroupMessaging = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ProfilePicturePath property.
            /// </summary>
            /// <param name="value">ProfilePicturePath</param>
            public UserGeneralUserBuilder ProfilePicturePath(string value)
            {
                _ProfilePicturePath = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ProfilePictureWidePath property.
            /// </summary>
            /// <param name="value">ProfilePictureWidePath</param>
            public UserGeneralUserBuilder ProfilePictureWidePath(string value)
            {
                _ProfilePictureWidePath = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ProfileThemeName property.
            /// </summary>
            /// <param name="value">ProfileThemeName</param>
            public UserGeneralUserBuilder ProfileThemeName(string value)
            {
                _ProfileThemeName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.UserTitleDisplay property.
            /// </summary>
            /// <param name="value">UserTitleDisplay</param>
            public UserGeneralUserBuilder UserTitleDisplay(string value)
            {
                _UserTitleDisplay = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.StatusText property.
            /// </summary>
            /// <param name="value">StatusText</param>
            public UserGeneralUserBuilder StatusText(string value)
            {
                _StatusText = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.StatusDate property.
            /// </summary>
            /// <param name="value">StatusDate</param>
            public UserGeneralUserBuilder StatusDate(DateTime? value)
            {
                _StatusDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.ProfileBanExpire property.
            /// </summary>
            /// <param name="value">ProfileBanExpire</param>
            public UserGeneralUserBuilder ProfileBanExpire(DateTime? value)
            {
                _ProfileBanExpire = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.BlizzardDisplayName property.
            /// </summary>
            /// <param name="value">BlizzardDisplayName</param>
            public UserGeneralUserBuilder BlizzardDisplayName(string value)
            {
                _BlizzardDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.SteamDisplayName property.
            /// </summary>
            /// <param name="value">SteamDisplayName</param>
            public UserGeneralUserBuilder SteamDisplayName(string value)
            {
                _SteamDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.StadiaDisplayName property.
            /// </summary>
            /// <param name="value">StadiaDisplayName</param>
            public UserGeneralUserBuilder StadiaDisplayName(string value)
            {
                _StadiaDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserGeneralUser.TwitchDisplayName property.
            /// </summary>
            /// <param name="value">TwitchDisplayName</param>
            public UserGeneralUserBuilder TwitchDisplayName(string value)
            {
                _TwitchDisplayName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserGeneralUser.
            /// </summary>
            /// <returns>UserGeneralUser</returns>
            public UserGeneralUser Build()
            {
                Validate();
                return new UserGeneralUser(
                    MembershipId: _MembershipId,
                    UniqueName: _UniqueName,
                    NormalizedName: _NormalizedName,
                    DisplayName: _DisplayName,
                    ProfilePicture: _ProfilePicture,
                    ProfileTheme: _ProfileTheme,
                    UserTitle: _UserTitle,
                    SuccessMessageFlags: _SuccessMessageFlags,
                    IsDeleted: _IsDeleted,
                    About: _About,
                    FirstAccess: _FirstAccess,
                    LastUpdate: _LastUpdate,
                    LegacyPortalUID: _LegacyPortalUID,
                    Context: _Context,
                    PsnDisplayName: _PsnDisplayName,
                    XboxDisplayName: _XboxDisplayName,
                    FbDisplayName: _FbDisplayName,
                    ShowActivity: _ShowActivity,
                    Locale: _Locale,
                    LocaleInheritDefault: _LocaleInheritDefault,
                    LastBanReportId: _LastBanReportId,
                    ShowGroupMessaging: _ShowGroupMessaging,
                    ProfilePicturePath: _ProfilePicturePath,
                    ProfilePictureWidePath: _ProfilePictureWidePath,
                    ProfileThemeName: _ProfileThemeName,
                    UserTitleDisplay: _UserTitleDisplay,
                    StatusText: _StatusText,
                    StatusDate: _StatusDate,
                    ProfileBanExpire: _ProfileBanExpire,
                    BlizzardDisplayName: _BlizzardDisplayName,
                    SteamDisplayName: _SteamDisplayName,
                    StadiaDisplayName: _StadiaDisplayName,
                    TwitchDisplayName: _TwitchDisplayName
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}