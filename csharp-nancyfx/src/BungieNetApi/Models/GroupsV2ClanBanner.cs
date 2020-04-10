using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2ClanBanner
    /// </summary>
    public sealed class GroupsV2ClanBanner:  IEquatable<GroupsV2ClanBanner>
    { 
        /// <summary>
        /// DecalId
        /// </summary>
        public int? DecalId { get; private set; }

        /// <summary>
        /// DecalColorId
        /// </summary>
        public int? DecalColorId { get; private set; }

        /// <summary>
        /// DecalBackgroundColorId
        /// </summary>
        public int? DecalBackgroundColorId { get; private set; }

        /// <summary>
        /// GonfalonId
        /// </summary>
        public int? GonfalonId { get; private set; }

        /// <summary>
        /// GonfalonColorId
        /// </summary>
        public int? GonfalonColorId { get; private set; }

        /// <summary>
        /// GonfalonDetailId
        /// </summary>
        public int? GonfalonDetailId { get; private set; }

        /// <summary>
        /// GonfalonDetailColorId
        /// </summary>
        public int? GonfalonDetailColorId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2ClanBanner.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2ClanBanner()
        {
        }

        private GroupsV2ClanBanner(int? DecalId, int? DecalColorId, int? DecalBackgroundColorId, int? GonfalonId, int? GonfalonColorId, int? GonfalonDetailId, int? GonfalonDetailColorId)
        {
            
            this.DecalId = DecalId;
            
            this.DecalColorId = DecalColorId;
            
            this.DecalBackgroundColorId = DecalBackgroundColorId;
            
            this.GonfalonId = GonfalonId;
            
            this.GonfalonColorId = GonfalonColorId;
            
            this.GonfalonDetailId = GonfalonDetailId;
            
            this.GonfalonDetailColorId = GonfalonDetailColorId;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2ClanBanner.
        /// </summary>
        /// <returns>GroupsV2ClanBannerBuilder</returns>
        public static GroupsV2ClanBannerBuilder Builder()
        {
            return new GroupsV2ClanBannerBuilder();
        }

        /// <summary>
        /// Returns GroupsV2ClanBannerBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2ClanBannerBuilder</returns>
        public GroupsV2ClanBannerBuilder With()
        {
            return Builder()
                .DecalId(DecalId)
                .DecalColorId(DecalColorId)
                .DecalBackgroundColorId(DecalBackgroundColorId)
                .GonfalonId(GonfalonId)
                .GonfalonColorId(GonfalonColorId)
                .GonfalonDetailId(GonfalonDetailId)
                .GonfalonDetailColorId(GonfalonDetailColorId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2ClanBanner other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2ClanBanner.
        /// </summary>
        /// <param name="left">Compared (GroupsV2ClanBanner</param>
        /// <param name="right">Compared (GroupsV2ClanBanner</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2ClanBanner left, GroupsV2ClanBanner right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2ClanBanner.
        /// </summary>
        /// <param name="left">Compared (GroupsV2ClanBanner</param>
        /// <param name="right">Compared (GroupsV2ClanBanner</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2ClanBanner left, GroupsV2ClanBanner right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2ClanBanner.
        /// </summary>
        public sealed class GroupsV2ClanBannerBuilder
        {
            private int? _DecalId;
            private int? _DecalColorId;
            private int? _DecalBackgroundColorId;
            private int? _GonfalonId;
            private int? _GonfalonColorId;
            private int? _GonfalonDetailId;
            private int? _GonfalonDetailColorId;

            internal GroupsV2ClanBannerBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.DecalId property.
            /// </summary>
            /// <param name="value">DecalId</param>
            public GroupsV2ClanBannerBuilder DecalId(int? value)
            {
                _DecalId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.DecalColorId property.
            /// </summary>
            /// <param name="value">DecalColorId</param>
            public GroupsV2ClanBannerBuilder DecalColorId(int? value)
            {
                _DecalColorId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.DecalBackgroundColorId property.
            /// </summary>
            /// <param name="value">DecalBackgroundColorId</param>
            public GroupsV2ClanBannerBuilder DecalBackgroundColorId(int? value)
            {
                _DecalBackgroundColorId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.GonfalonId property.
            /// </summary>
            /// <param name="value">GonfalonId</param>
            public GroupsV2ClanBannerBuilder GonfalonId(int? value)
            {
                _GonfalonId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.GonfalonColorId property.
            /// </summary>
            /// <param name="value">GonfalonColorId</param>
            public GroupsV2ClanBannerBuilder GonfalonColorId(int? value)
            {
                _GonfalonColorId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.GonfalonDetailId property.
            /// </summary>
            /// <param name="value">GonfalonDetailId</param>
            public GroupsV2ClanBannerBuilder GonfalonDetailId(int? value)
            {
                _GonfalonDetailId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2ClanBanner.GonfalonDetailColorId property.
            /// </summary>
            /// <param name="value">GonfalonDetailColorId</param>
            public GroupsV2ClanBannerBuilder GonfalonDetailColorId(int? value)
            {
                _GonfalonDetailColorId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2ClanBanner.
            /// </summary>
            /// <returns>GroupsV2ClanBanner</returns>
            public GroupsV2ClanBanner Build()
            {
                Validate();
                return new GroupsV2ClanBanner(
                    DecalId: _DecalId,
                    DecalColorId: _DecalColorId,
                    DecalBackgroundColorId: _DecalBackgroundColorId,
                    GonfalonId: _GonfalonId,
                    GonfalonColorId: _GonfalonColorId,
                    GonfalonDetailId: _GonfalonDetailId,
                    GonfalonDetailColorId: _GonfalonDetailColorId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}