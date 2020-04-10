using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingEntryNews
    /// </summary>
    public sealed class TrendingTrendingEntryNews:  IEquatable<TrendingTrendingEntryNews>
    { 
        /// <summary>
        /// Article
        /// </summary>
        public ContentContentItemPublicContract Article { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntryNews.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntryNews()
        {
        }

        private TrendingTrendingEntryNews(ContentContentItemPublicContract Article)
        {
            
            this.Article = Article;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntryNews.
        /// </summary>
        /// <returns>TrendingTrendingEntryNewsBuilder</returns>
        public static TrendingTrendingEntryNewsBuilder Builder()
        {
            return new TrendingTrendingEntryNewsBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntryNewsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntryNewsBuilder</returns>
        public TrendingTrendingEntryNewsBuilder With()
        {
            return Builder()
                .Article(Article);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingEntryNews other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntryNews.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryNews</param>
        /// <param name="right">Compared (TrendingTrendingEntryNews</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntryNews left, TrendingTrendingEntryNews right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntryNews.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryNews</param>
        /// <param name="right">Compared (TrendingTrendingEntryNews</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntryNews left, TrendingTrendingEntryNews right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntryNews.
        /// </summary>
        public sealed class TrendingTrendingEntryNewsBuilder
        {
            private ContentContentItemPublicContract _Article;

            internal TrendingTrendingEntryNewsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryNews.Article property.
            /// </summary>
            /// <param name="value">Article</param>
            public TrendingTrendingEntryNewsBuilder Article(ContentContentItemPublicContract value)
            {
                _Article = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntryNews.
            /// </summary>
            /// <returns>TrendingTrendingEntryNews</returns>
            public TrendingTrendingEntryNews Build()
            {
                Validate();
                return new TrendingTrendingEntryNews(
                    Article: _Article
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}