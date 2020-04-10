using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This contract contains clan-specific group information. It does not include any investment data.
    /// </summary>
    public sealed class GroupsV2GroupV2ClanInfo:  IEquatable<GroupsV2GroupV2ClanInfo>
    { 
        /// <summary>
        /// ClanCallsign
        /// </summary>
        public string ClanCallsign { get; private set; }

        /// <summary>
        /// ClanBannerData
        /// </summary>
        public GroupsV2ClanBanner ClanBannerData { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupV2ClanInfo.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupV2ClanInfo()
        {
        }

        private GroupsV2GroupV2ClanInfo(string ClanCallsign, GroupsV2ClanBanner ClanBannerData)
        {
            
            this.ClanCallsign = ClanCallsign;
            
            this.ClanBannerData = ClanBannerData;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupV2ClanInfo.
        /// </summary>
        /// <returns>GroupsV2GroupV2ClanInfoBuilder</returns>
        public static GroupsV2GroupV2ClanInfoBuilder Builder()
        {
            return new GroupsV2GroupV2ClanInfoBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupV2ClanInfoBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupV2ClanInfoBuilder</returns>
        public GroupsV2GroupV2ClanInfoBuilder With()
        {
            return Builder()
                .ClanCallsign(ClanCallsign)
                .ClanBannerData(ClanBannerData);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupV2ClanInfo other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupV2ClanInfo.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2ClanInfo</param>
        /// <param name="right">Compared (GroupsV2GroupV2ClanInfo</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupV2ClanInfo left, GroupsV2GroupV2ClanInfo right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupV2ClanInfo.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2ClanInfo</param>
        /// <param name="right">Compared (GroupsV2GroupV2ClanInfo</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupV2ClanInfo left, GroupsV2GroupV2ClanInfo right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupV2ClanInfo.
        /// </summary>
        public sealed class GroupsV2GroupV2ClanInfoBuilder
        {
            private string _ClanCallsign;
            private GroupsV2ClanBanner _ClanBannerData;

            internal GroupsV2GroupV2ClanInfoBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2ClanInfo.ClanCallsign property.
            /// </summary>
            /// <param name="value">ClanCallsign</param>
            public GroupsV2GroupV2ClanInfoBuilder ClanCallsign(string value)
            {
                _ClanCallsign = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2ClanInfo.ClanBannerData property.
            /// </summary>
            /// <param name="value">ClanBannerData</param>
            public GroupsV2GroupV2ClanInfoBuilder ClanBannerData(GroupsV2ClanBanner value)
            {
                _ClanBannerData = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupV2ClanInfo.
            /// </summary>
            /// <returns>GroupsV2GroupV2ClanInfo</returns>
            public GroupsV2GroupV2ClanInfo Build()
            {
                Validate();
                return new GroupsV2GroupV2ClanInfo(
                    ClanCallsign: _ClanCallsign,
                    ClanBannerData: _ClanBannerData
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}