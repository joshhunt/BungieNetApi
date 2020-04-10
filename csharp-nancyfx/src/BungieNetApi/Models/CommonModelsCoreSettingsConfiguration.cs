using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// CommonModelsCoreSettingsConfiguration
    /// </summary>
    public sealed class CommonModelsCoreSettingsConfiguration:  IEquatable<CommonModelsCoreSettingsConfiguration>
    { 
        /// <summary>
        /// Environment
        /// </summary>
        public string Environment { get; private set; }

        /// <summary>
        /// Systems
        /// </summary>
        public Dictionary<string, CommonModelsCoreSystem> Systems { get; private set; }

        /// <summary>
        /// IgnoreReasons
        /// </summary>
        public List<CommonModelsCoreSetting> IgnoreReasons { get; private set; }

        /// <summary>
        /// ForumCategories
        /// </summary>
        public List<CommonModelsCoreSetting> ForumCategories { get; private set; }

        /// <summary>
        /// GroupAvatars
        /// </summary>
        public List<CommonModelsCoreSetting> GroupAvatars { get; private set; }

        /// <summary>
        /// DestinyMembershipTypes
        /// </summary>
        public List<CommonModelsCoreSetting> DestinyMembershipTypes { get; private set; }

        /// <summary>
        /// RecruitmentPlatformTags
        /// </summary>
        public List<CommonModelsCoreSetting> RecruitmentPlatformTags { get; private set; }

        /// <summary>
        /// RecruitmentMiscTags
        /// </summary>
        public List<CommonModelsCoreSetting> RecruitmentMiscTags { get; private set; }

        /// <summary>
        /// RecruitmentActivities
        /// </summary>
        public List<CommonModelsCoreSetting> RecruitmentActivities { get; private set; }

        /// <summary>
        /// UserContentLocales
        /// </summary>
        public List<CommonModelsCoreSetting> UserContentLocales { get; private set; }

        /// <summary>
        /// SystemContentLocales
        /// </summary>
        public List<CommonModelsCoreSetting> SystemContentLocales { get; private set; }

        /// <summary>
        /// ClanBannerDecals
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerDecals { get; private set; }

        /// <summary>
        /// ClanBannerDecalColors
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerDecalColors { get; private set; }

        /// <summary>
        /// ClanBannerGonfalons
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerGonfalons { get; private set; }

        /// <summary>
        /// ClanBannerGonfalonColors
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerGonfalonColors { get; private set; }

        /// <summary>
        /// ClanBannerGonfalonDetails
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerGonfalonDetails { get; private set; }

        /// <summary>
        /// ClanBannerGonfalonDetailColors
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerGonfalonDetailColors { get; private set; }

        /// <summary>
        /// ClanBannerStandards
        /// </summary>
        public List<CommonModelsCoreSetting> ClanBannerStandards { get; private set; }

        /// <summary>
        /// Destiny2CoreSettings
        /// </summary>
        public CommonModelsDestiny2CoreSettings Destiny2CoreSettings { get; private set; }

        /// <summary>
        /// EmailSettings
        /// </summary>
        public UserEmailSettings EmailSettings { get; private set; }

        /// <summary>
        /// FireteamActivities
        /// </summary>
        public List<CommonModelsCoreSetting> FireteamActivities { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use CommonModelsCoreSettingsConfiguration.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public CommonModelsCoreSettingsConfiguration()
        {
        }

        private CommonModelsCoreSettingsConfiguration(string Environment, Dictionary<string, CommonModelsCoreSystem> Systems, List<CommonModelsCoreSetting> IgnoreReasons, List<CommonModelsCoreSetting> ForumCategories, List<CommonModelsCoreSetting> GroupAvatars, List<CommonModelsCoreSetting> DestinyMembershipTypes, List<CommonModelsCoreSetting> RecruitmentPlatformTags, List<CommonModelsCoreSetting> RecruitmentMiscTags, List<CommonModelsCoreSetting> RecruitmentActivities, List<CommonModelsCoreSetting> UserContentLocales, List<CommonModelsCoreSetting> SystemContentLocales, List<CommonModelsCoreSetting> ClanBannerDecals, List<CommonModelsCoreSetting> ClanBannerDecalColors, List<CommonModelsCoreSetting> ClanBannerGonfalons, List<CommonModelsCoreSetting> ClanBannerGonfalonColors, List<CommonModelsCoreSetting> ClanBannerGonfalonDetails, List<CommonModelsCoreSetting> ClanBannerGonfalonDetailColors, List<CommonModelsCoreSetting> ClanBannerStandards, CommonModelsDestiny2CoreSettings Destiny2CoreSettings, UserEmailSettings EmailSettings, List<CommonModelsCoreSetting> FireteamActivities)
        {
            
            this.Environment = Environment;
            
            this.Systems = Systems;
            
            this.IgnoreReasons = IgnoreReasons;
            
            this.ForumCategories = ForumCategories;
            
            this.GroupAvatars = GroupAvatars;
            
            this.DestinyMembershipTypes = DestinyMembershipTypes;
            
            this.RecruitmentPlatformTags = RecruitmentPlatformTags;
            
            this.RecruitmentMiscTags = RecruitmentMiscTags;
            
            this.RecruitmentActivities = RecruitmentActivities;
            
            this.UserContentLocales = UserContentLocales;
            
            this.SystemContentLocales = SystemContentLocales;
            
            this.ClanBannerDecals = ClanBannerDecals;
            
            this.ClanBannerDecalColors = ClanBannerDecalColors;
            
            this.ClanBannerGonfalons = ClanBannerGonfalons;
            
            this.ClanBannerGonfalonColors = ClanBannerGonfalonColors;
            
            this.ClanBannerGonfalonDetails = ClanBannerGonfalonDetails;
            
            this.ClanBannerGonfalonDetailColors = ClanBannerGonfalonDetailColors;
            
            this.ClanBannerStandards = ClanBannerStandards;
            
            this.Destiny2CoreSettings = Destiny2CoreSettings;
            
            this.EmailSettings = EmailSettings;
            
            this.FireteamActivities = FireteamActivities;
            
        }

        /// <summary>
        /// Returns builder of CommonModelsCoreSettingsConfiguration.
        /// </summary>
        /// <returns>CommonModelsCoreSettingsConfigurationBuilder</returns>
        public static CommonModelsCoreSettingsConfigurationBuilder Builder()
        {
            return new CommonModelsCoreSettingsConfigurationBuilder();
        }

        /// <summary>
        /// Returns CommonModelsCoreSettingsConfigurationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>CommonModelsCoreSettingsConfigurationBuilder</returns>
        public CommonModelsCoreSettingsConfigurationBuilder With()
        {
            return Builder()
                .Environment(Environment)
                .Systems(Systems)
                .IgnoreReasons(IgnoreReasons)
                .ForumCategories(ForumCategories)
                .GroupAvatars(GroupAvatars)
                .DestinyMembershipTypes(DestinyMembershipTypes)
                .RecruitmentPlatformTags(RecruitmentPlatformTags)
                .RecruitmentMiscTags(RecruitmentMiscTags)
                .RecruitmentActivities(RecruitmentActivities)
                .UserContentLocales(UserContentLocales)
                .SystemContentLocales(SystemContentLocales)
                .ClanBannerDecals(ClanBannerDecals)
                .ClanBannerDecalColors(ClanBannerDecalColors)
                .ClanBannerGonfalons(ClanBannerGonfalons)
                .ClanBannerGonfalonColors(ClanBannerGonfalonColors)
                .ClanBannerGonfalonDetails(ClanBannerGonfalonDetails)
                .ClanBannerGonfalonDetailColors(ClanBannerGonfalonDetailColors)
                .ClanBannerStandards(ClanBannerStandards)
                .Destiny2CoreSettings(Destiny2CoreSettings)
                .EmailSettings(EmailSettings)
                .FireteamActivities(FireteamActivities);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(CommonModelsCoreSettingsConfiguration other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (CommonModelsCoreSettingsConfiguration.
        /// </summary>
        /// <param name="left">Compared (CommonModelsCoreSettingsConfiguration</param>
        /// <param name="right">Compared (CommonModelsCoreSettingsConfiguration</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (CommonModelsCoreSettingsConfiguration left, CommonModelsCoreSettingsConfiguration right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (CommonModelsCoreSettingsConfiguration.
        /// </summary>
        /// <param name="left">Compared (CommonModelsCoreSettingsConfiguration</param>
        /// <param name="right">Compared (CommonModelsCoreSettingsConfiguration</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (CommonModelsCoreSettingsConfiguration left, CommonModelsCoreSettingsConfiguration right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of CommonModelsCoreSettingsConfiguration.
        /// </summary>
        public sealed class CommonModelsCoreSettingsConfigurationBuilder
        {
            private string _Environment;
            private Dictionary<string, CommonModelsCoreSystem> _Systems;
            private List<CommonModelsCoreSetting> _IgnoreReasons;
            private List<CommonModelsCoreSetting> _ForumCategories;
            private List<CommonModelsCoreSetting> _GroupAvatars;
            private List<CommonModelsCoreSetting> _DestinyMembershipTypes;
            private List<CommonModelsCoreSetting> _RecruitmentPlatformTags;
            private List<CommonModelsCoreSetting> _RecruitmentMiscTags;
            private List<CommonModelsCoreSetting> _RecruitmentActivities;
            private List<CommonModelsCoreSetting> _UserContentLocales;
            private List<CommonModelsCoreSetting> _SystemContentLocales;
            private List<CommonModelsCoreSetting> _ClanBannerDecals;
            private List<CommonModelsCoreSetting> _ClanBannerDecalColors;
            private List<CommonModelsCoreSetting> _ClanBannerGonfalons;
            private List<CommonModelsCoreSetting> _ClanBannerGonfalonColors;
            private List<CommonModelsCoreSetting> _ClanBannerGonfalonDetails;
            private List<CommonModelsCoreSetting> _ClanBannerGonfalonDetailColors;
            private List<CommonModelsCoreSetting> _ClanBannerStandards;
            private CommonModelsDestiny2CoreSettings _Destiny2CoreSettings;
            private UserEmailSettings _EmailSettings;
            private List<CommonModelsCoreSetting> _FireteamActivities;

            internal CommonModelsCoreSettingsConfigurationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.Environment property.
            /// </summary>
            /// <param name="value">Environment</param>
            public CommonModelsCoreSettingsConfigurationBuilder Environment(string value)
            {
                _Environment = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.Systems property.
            /// </summary>
            /// <param name="value">Systems</param>
            public CommonModelsCoreSettingsConfigurationBuilder Systems(Dictionary<string, CommonModelsCoreSystem> value)
            {
                _Systems = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.IgnoreReasons property.
            /// </summary>
            /// <param name="value">IgnoreReasons</param>
            public CommonModelsCoreSettingsConfigurationBuilder IgnoreReasons(List<CommonModelsCoreSetting> value)
            {
                _IgnoreReasons = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ForumCategories property.
            /// </summary>
            /// <param name="value">ForumCategories</param>
            public CommonModelsCoreSettingsConfigurationBuilder ForumCategories(List<CommonModelsCoreSetting> value)
            {
                _ForumCategories = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.GroupAvatars property.
            /// </summary>
            /// <param name="value">GroupAvatars</param>
            public CommonModelsCoreSettingsConfigurationBuilder GroupAvatars(List<CommonModelsCoreSetting> value)
            {
                _GroupAvatars = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.DestinyMembershipTypes property.
            /// </summary>
            /// <param name="value">DestinyMembershipTypes</param>
            public CommonModelsCoreSettingsConfigurationBuilder DestinyMembershipTypes(List<CommonModelsCoreSetting> value)
            {
                _DestinyMembershipTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.RecruitmentPlatformTags property.
            /// </summary>
            /// <param name="value">RecruitmentPlatformTags</param>
            public CommonModelsCoreSettingsConfigurationBuilder RecruitmentPlatformTags(List<CommonModelsCoreSetting> value)
            {
                _RecruitmentPlatformTags = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.RecruitmentMiscTags property.
            /// </summary>
            /// <param name="value">RecruitmentMiscTags</param>
            public CommonModelsCoreSettingsConfigurationBuilder RecruitmentMiscTags(List<CommonModelsCoreSetting> value)
            {
                _RecruitmentMiscTags = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.RecruitmentActivities property.
            /// </summary>
            /// <param name="value">RecruitmentActivities</param>
            public CommonModelsCoreSettingsConfigurationBuilder RecruitmentActivities(List<CommonModelsCoreSetting> value)
            {
                _RecruitmentActivities = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.UserContentLocales property.
            /// </summary>
            /// <param name="value">UserContentLocales</param>
            public CommonModelsCoreSettingsConfigurationBuilder UserContentLocales(List<CommonModelsCoreSetting> value)
            {
                _UserContentLocales = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.SystemContentLocales property.
            /// </summary>
            /// <param name="value">SystemContentLocales</param>
            public CommonModelsCoreSettingsConfigurationBuilder SystemContentLocales(List<CommonModelsCoreSetting> value)
            {
                _SystemContentLocales = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerDecals property.
            /// </summary>
            /// <param name="value">ClanBannerDecals</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerDecals(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerDecals = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerDecalColors property.
            /// </summary>
            /// <param name="value">ClanBannerDecalColors</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerDecalColors(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerDecalColors = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerGonfalons property.
            /// </summary>
            /// <param name="value">ClanBannerGonfalons</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerGonfalons(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerGonfalons = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerGonfalonColors property.
            /// </summary>
            /// <param name="value">ClanBannerGonfalonColors</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerGonfalonColors(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerGonfalonColors = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerGonfalonDetails property.
            /// </summary>
            /// <param name="value">ClanBannerGonfalonDetails</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerGonfalonDetails(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerGonfalonDetails = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerGonfalonDetailColors property.
            /// </summary>
            /// <param name="value">ClanBannerGonfalonDetailColors</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerGonfalonDetailColors(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerGonfalonDetailColors = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.ClanBannerStandards property.
            /// </summary>
            /// <param name="value">ClanBannerStandards</param>
            public CommonModelsCoreSettingsConfigurationBuilder ClanBannerStandards(List<CommonModelsCoreSetting> value)
            {
                _ClanBannerStandards = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.Destiny2CoreSettings property.
            /// </summary>
            /// <param name="value">Destiny2CoreSettings</param>
            public CommonModelsCoreSettingsConfigurationBuilder Destiny2CoreSettings(CommonModelsDestiny2CoreSettings value)
            {
                _Destiny2CoreSettings = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.EmailSettings property.
            /// </summary>
            /// <param name="value">EmailSettings</param>
            public CommonModelsCoreSettingsConfigurationBuilder EmailSettings(UserEmailSettings value)
            {
                _EmailSettings = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSettingsConfiguration.FireteamActivities property.
            /// </summary>
            /// <param name="value">FireteamActivities</param>
            public CommonModelsCoreSettingsConfigurationBuilder FireteamActivities(List<CommonModelsCoreSetting> value)
            {
                _FireteamActivities = value;
                return this;
            }


            /// <summary>
            /// Builds instance of CommonModelsCoreSettingsConfiguration.
            /// </summary>
            /// <returns>CommonModelsCoreSettingsConfiguration</returns>
            public CommonModelsCoreSettingsConfiguration Build()
            {
                Validate();
                return new CommonModelsCoreSettingsConfiguration(
                    Environment: _Environment,
                    Systems: _Systems,
                    IgnoreReasons: _IgnoreReasons,
                    ForumCategories: _ForumCategories,
                    GroupAvatars: _GroupAvatars,
                    DestinyMembershipTypes: _DestinyMembershipTypes,
                    RecruitmentPlatformTags: _RecruitmentPlatformTags,
                    RecruitmentMiscTags: _RecruitmentMiscTags,
                    RecruitmentActivities: _RecruitmentActivities,
                    UserContentLocales: _UserContentLocales,
                    SystemContentLocales: _SystemContentLocales,
                    ClanBannerDecals: _ClanBannerDecals,
                    ClanBannerDecalColors: _ClanBannerDecalColors,
                    ClanBannerGonfalons: _ClanBannerGonfalons,
                    ClanBannerGonfalonColors: _ClanBannerGonfalonColors,
                    ClanBannerGonfalonDetails: _ClanBannerGonfalonDetails,
                    ClanBannerGonfalonDetailColors: _ClanBannerGonfalonDetailColors,
                    ClanBannerStandards: _ClanBannerStandards,
                    Destiny2CoreSettings: _Destiny2CoreSettings,
                    EmailSettings: _EmailSettings,
                    FireteamActivities: _FireteamActivities
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}