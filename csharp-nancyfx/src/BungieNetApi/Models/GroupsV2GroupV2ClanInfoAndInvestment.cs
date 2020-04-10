using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The same as GroupV2ClanInfo, but includes any investment data.
    /// </summary>
    public sealed class GroupsV2GroupV2ClanInfoAndInvestment:  IEquatable<GroupsV2GroupV2ClanInfoAndInvestment>
    { 
        /// <summary>
        /// D2ClanProgressions
        /// </summary>
        public Dictionary<string, DestinyDestinyProgression> D2ClanProgressions { get; private set; }

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
        /// Use GroupsV2GroupV2ClanInfoAndInvestment.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupV2ClanInfoAndInvestment()
        {
        }

        private GroupsV2GroupV2ClanInfoAndInvestment(Dictionary<string, DestinyDestinyProgression> D2ClanProgressions, string ClanCallsign, GroupsV2ClanBanner ClanBannerData)
        {
            
            this.D2ClanProgressions = D2ClanProgressions;
            
            this.ClanCallsign = ClanCallsign;
            
            this.ClanBannerData = ClanBannerData;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupV2ClanInfoAndInvestment.
        /// </summary>
        /// <returns>GroupsV2GroupV2ClanInfoAndInvestmentBuilder</returns>
        public static GroupsV2GroupV2ClanInfoAndInvestmentBuilder Builder()
        {
            return new GroupsV2GroupV2ClanInfoAndInvestmentBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupV2ClanInfoAndInvestmentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupV2ClanInfoAndInvestmentBuilder</returns>
        public GroupsV2GroupV2ClanInfoAndInvestmentBuilder With()
        {
            return Builder()
                .D2ClanProgressions(D2ClanProgressions)
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

        public bool Equals(GroupsV2GroupV2ClanInfoAndInvestment other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupV2ClanInfoAndInvestment.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2ClanInfoAndInvestment</param>
        /// <param name="right">Compared (GroupsV2GroupV2ClanInfoAndInvestment</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupV2ClanInfoAndInvestment left, GroupsV2GroupV2ClanInfoAndInvestment right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupV2ClanInfoAndInvestment.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupV2ClanInfoAndInvestment</param>
        /// <param name="right">Compared (GroupsV2GroupV2ClanInfoAndInvestment</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupV2ClanInfoAndInvestment left, GroupsV2GroupV2ClanInfoAndInvestment right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupV2ClanInfoAndInvestment.
        /// </summary>
        public sealed class GroupsV2GroupV2ClanInfoAndInvestmentBuilder
        {
            private Dictionary<string, DestinyDestinyProgression> _D2ClanProgressions;
            private string _ClanCallsign;
            private GroupsV2ClanBanner _ClanBannerData;

            internal GroupsV2GroupV2ClanInfoAndInvestmentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2ClanInfoAndInvestment.D2ClanProgressions property.
            /// </summary>
            /// <param name="value">D2ClanProgressions</param>
            public GroupsV2GroupV2ClanInfoAndInvestmentBuilder D2ClanProgressions(Dictionary<string, DestinyDestinyProgression> value)
            {
                _D2ClanProgressions = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2ClanInfoAndInvestment.ClanCallsign property.
            /// </summary>
            /// <param name="value">ClanCallsign</param>
            public GroupsV2GroupV2ClanInfoAndInvestmentBuilder ClanCallsign(string value)
            {
                _ClanCallsign = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupV2ClanInfoAndInvestment.ClanBannerData property.
            /// </summary>
            /// <param name="value">ClanBannerData</param>
            public GroupsV2GroupV2ClanInfoAndInvestmentBuilder ClanBannerData(GroupsV2ClanBanner value)
            {
                _ClanBannerData = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupV2ClanInfoAndInvestment.
            /// </summary>
            /// <returns>GroupsV2GroupV2ClanInfoAndInvestment</returns>
            public GroupsV2GroupV2ClanInfoAndInvestment Build()
            {
                Validate();
                return new GroupsV2GroupV2ClanInfoAndInvestment(
                    D2ClanProgressions: _D2ClanProgressions,
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