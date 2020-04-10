using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// QueriesSearchResult
    /// </summary>
    public sealed class QueriesSearchResult:  IEquatable<QueriesSearchResult>
    { 
        /// <summary>
        /// TotalResults
        /// </summary>
        public int? TotalResults { get; private set; }

        /// <summary>
        /// HasMore
        /// </summary>
        public bool? HasMore { get; private set; }

        /// <summary>
        /// Query
        /// </summary>
        public QueriesPagedQuery Query { get; private set; }

        /// <summary>
        /// ReplacementContinuationToken
        /// </summary>
        public string ReplacementContinuationToken { get; private set; }

        /// <summary>
        /// If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.
        /// </summary>
        public bool? UseTotalResults { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use QueriesSearchResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public QueriesSearchResult()
        {
        }

        private QueriesSearchResult(int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of QueriesSearchResult.
        /// </summary>
        /// <returns>QueriesSearchResultBuilder</returns>
        public static QueriesSearchResultBuilder Builder()
        {
            return new QueriesSearchResultBuilder();
        }

        /// <summary>
        /// Returns QueriesSearchResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>QueriesSearchResultBuilder</returns>
        public QueriesSearchResultBuilder With()
        {
            return Builder()
                .TotalResults(TotalResults)
                .HasMore(HasMore)
                .Query(Query)
                .ReplacementContinuationToken(ReplacementContinuationToken)
                .UseTotalResults(UseTotalResults);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(QueriesSearchResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (QueriesSearchResult.
        /// </summary>
        /// <param name="left">Compared (QueriesSearchResult</param>
        /// <param name="right">Compared (QueriesSearchResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (QueriesSearchResult left, QueriesSearchResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (QueriesSearchResult.
        /// </summary>
        /// <param name="left">Compared (QueriesSearchResult</param>
        /// <param name="right">Compared (QueriesSearchResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (QueriesSearchResult left, QueriesSearchResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of QueriesSearchResult.
        /// </summary>
        public sealed class QueriesSearchResultBuilder
        {
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal QueriesSearchResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for QueriesSearchResult.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public QueriesSearchResultBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for QueriesSearchResult.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public QueriesSearchResultBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for QueriesSearchResult.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public QueriesSearchResultBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for QueriesSearchResult.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public QueriesSearchResultBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for QueriesSearchResult.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public QueriesSearchResultBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of QueriesSearchResult.
            /// </summary>
            /// <returns>QueriesSearchResult</returns>
            public QueriesSearchResult Build()
            {
                Validate();
                return new QueriesSearchResult(
                    TotalResults: _TotalResults,
                    HasMore: _HasMore,
                    Query: _Query,
                    ReplacementContinuationToken: _ReplacementContinuationToken,
                    UseTotalResults: _UseTotalResults
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}