using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingEntrySupportArticle
    /// </summary>
    public sealed class TrendingTrendingEntrySupportArticle:  IEquatable<TrendingTrendingEntrySupportArticle>
    { 
        /// <summary>
        /// Article
        /// </summary>
        public ContentContentItemPublicContract Article { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntrySupportArticle.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntrySupportArticle()
        {
        }

        private TrendingTrendingEntrySupportArticle(ContentContentItemPublicContract Article)
        {
            
            this.Article = Article;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntrySupportArticle.
        /// </summary>
        /// <returns>TrendingTrendingEntrySupportArticleBuilder</returns>
        public static TrendingTrendingEntrySupportArticleBuilder Builder()
        {
            return new TrendingTrendingEntrySupportArticleBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntrySupportArticleBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntrySupportArticleBuilder</returns>
        public TrendingTrendingEntrySupportArticleBuilder With()
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

        public bool Equals(TrendingTrendingEntrySupportArticle other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntrySupportArticle.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntrySupportArticle</param>
        /// <param name="right">Compared (TrendingTrendingEntrySupportArticle</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntrySupportArticle left, TrendingTrendingEntrySupportArticle right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntrySupportArticle.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntrySupportArticle</param>
        /// <param name="right">Compared (TrendingTrendingEntrySupportArticle</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntrySupportArticle left, TrendingTrendingEntrySupportArticle right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntrySupportArticle.
        /// </summary>
        public sealed class TrendingTrendingEntrySupportArticleBuilder
        {
            private ContentContentItemPublicContract _Article;

            internal TrendingTrendingEntrySupportArticleBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntrySupportArticle.Article property.
            /// </summary>
            /// <param name="value">Article</param>
            public TrendingTrendingEntrySupportArticleBuilder Article(ContentContentItemPublicContract value)
            {
                _Article = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntrySupportArticle.
            /// </summary>
            /// <returns>TrendingTrendingEntrySupportArticle</returns>
            public TrendingTrendingEntrySupportArticle Build()
            {
                Validate();
                return new TrendingTrendingEntrySupportArticle(
                    Article: _Article
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}