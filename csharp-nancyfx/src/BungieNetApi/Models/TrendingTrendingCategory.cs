using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingCategory
    /// </summary>
    public sealed class TrendingTrendingCategory:  IEquatable<TrendingTrendingCategory>
    { 
        /// <summary>
        /// CategoryName
        /// </summary>
        public string CategoryName { get; private set; }

        /// <summary>
        /// Entries
        /// </summary>
        public SearchResultOfTrendingEntry Entries { get; private set; }

        /// <summary>
        /// CategoryId
        /// </summary>
        public string CategoryId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingCategory.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingCategory()
        {
        }

        private TrendingTrendingCategory(string CategoryName, SearchResultOfTrendingEntry Entries, string CategoryId)
        {
            
            this.CategoryName = CategoryName;
            
            this.Entries = Entries;
            
            this.CategoryId = CategoryId;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingCategory.
        /// </summary>
        /// <returns>TrendingTrendingCategoryBuilder</returns>
        public static TrendingTrendingCategoryBuilder Builder()
        {
            return new TrendingTrendingCategoryBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingCategoryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingCategoryBuilder</returns>
        public TrendingTrendingCategoryBuilder With()
        {
            return Builder()
                .CategoryName(CategoryName)
                .Entries(Entries)
                .CategoryId(CategoryId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingCategory other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingCategory.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingCategory</param>
        /// <param name="right">Compared (TrendingTrendingCategory</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingCategory left, TrendingTrendingCategory right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingCategory.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingCategory</param>
        /// <param name="right">Compared (TrendingTrendingCategory</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingCategory left, TrendingTrendingCategory right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingCategory.
        /// </summary>
        public sealed class TrendingTrendingCategoryBuilder
        {
            private string _CategoryName;
            private SearchResultOfTrendingEntry _Entries;
            private string _CategoryId;

            internal TrendingTrendingCategoryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingCategory.CategoryName property.
            /// </summary>
            /// <param name="value">CategoryName</param>
            public TrendingTrendingCategoryBuilder CategoryName(string value)
            {
                _CategoryName = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingCategory.Entries property.
            /// </summary>
            /// <param name="value">Entries</param>
            public TrendingTrendingCategoryBuilder Entries(SearchResultOfTrendingEntry value)
            {
                _Entries = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingCategory.CategoryId property.
            /// </summary>
            /// <param name="value">CategoryId</param>
            public TrendingTrendingCategoryBuilder CategoryId(string value)
            {
                _CategoryId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingCategory.
            /// </summary>
            /// <returns>TrendingTrendingCategory</returns>
            public TrendingTrendingCategory Build()
            {
                Validate();
                return new TrendingTrendingCategory(
                    CategoryName: _CategoryName,
                    Entries: _Entries,
                    CategoryId: _CategoryId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}