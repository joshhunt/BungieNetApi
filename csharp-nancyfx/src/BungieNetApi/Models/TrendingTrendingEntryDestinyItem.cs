using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingEntryDestinyItem
    /// </summary>
    public sealed class TrendingTrendingEntryDestinyItem:  IEquatable<TrendingTrendingEntryDestinyItem>
    { 
        /// <summary>
        /// ItemHash
        /// </summary>
        public int? ItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntryDestinyItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntryDestinyItem()
        {
        }

        private TrendingTrendingEntryDestinyItem(int? ItemHash)
        {
            
            this.ItemHash = ItemHash;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntryDestinyItem.
        /// </summary>
        /// <returns>TrendingTrendingEntryDestinyItemBuilder</returns>
        public static TrendingTrendingEntryDestinyItemBuilder Builder()
        {
            return new TrendingTrendingEntryDestinyItemBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntryDestinyItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntryDestinyItemBuilder</returns>
        public TrendingTrendingEntryDestinyItemBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingEntryDestinyItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntryDestinyItem.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryDestinyItem</param>
        /// <param name="right">Compared (TrendingTrendingEntryDestinyItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntryDestinyItem left, TrendingTrendingEntryDestinyItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntryDestinyItem.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryDestinyItem</param>
        /// <param name="right">Compared (TrendingTrendingEntryDestinyItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntryDestinyItem left, TrendingTrendingEntryDestinyItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntryDestinyItem.
        /// </summary>
        public sealed class TrendingTrendingEntryDestinyItemBuilder
        {
            private int? _ItemHash;

            internal TrendingTrendingEntryDestinyItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyItem.ItemHash property.
            /// </summary>
            /// <param name="value">ItemHash</param>
            public TrendingTrendingEntryDestinyItemBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntryDestinyItem.
            /// </summary>
            /// <returns>TrendingTrendingEntryDestinyItem</returns>
            public TrendingTrendingEntryDestinyItem Build()
            {
                Validate();
                return new TrendingTrendingEntryDestinyItem(
                    ItemHash: _ItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}