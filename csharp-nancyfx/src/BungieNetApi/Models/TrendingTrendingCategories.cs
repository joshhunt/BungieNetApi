using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingCategories
    /// </summary>
    public sealed class TrendingTrendingCategories:  IEquatable<TrendingTrendingCategories>
    { 
        /// <summary>
        /// Categories
        /// </summary>
        public List<TrendingTrendingCategory> Categories { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingCategories.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingCategories()
        {
        }

        private TrendingTrendingCategories(List<TrendingTrendingCategory> Categories)
        {
            
            this.Categories = Categories;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingCategories.
        /// </summary>
        /// <returns>TrendingTrendingCategoriesBuilder</returns>
        public static TrendingTrendingCategoriesBuilder Builder()
        {
            return new TrendingTrendingCategoriesBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingCategoriesBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingCategoriesBuilder</returns>
        public TrendingTrendingCategoriesBuilder With()
        {
            return Builder()
                .Categories(Categories);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingCategories other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingCategories.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingCategories</param>
        /// <param name="right">Compared (TrendingTrendingCategories</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingCategories left, TrendingTrendingCategories right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingCategories.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingCategories</param>
        /// <param name="right">Compared (TrendingTrendingCategories</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingCategories left, TrendingTrendingCategories right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingCategories.
        /// </summary>
        public sealed class TrendingTrendingCategoriesBuilder
        {
            private List<TrendingTrendingCategory> _Categories;

            internal TrendingTrendingCategoriesBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingCategories.Categories property.
            /// </summary>
            /// <param name="value">Categories</param>
            public TrendingTrendingCategoriesBuilder Categories(List<TrendingTrendingCategory> value)
            {
                _Categories = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingCategories.
            /// </summary>
            /// <returns>TrendingTrendingCategories</returns>
            public TrendingTrendingCategories Build()
            {
                Validate();
                return new TrendingTrendingCategories(
                    Categories: _Categories
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}