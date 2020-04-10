using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SearchResultOfTrendingEntry
    /// </summary>
    public sealed class SearchResultOfTrendingEntry:  IEquatable<SearchResultOfTrendingEntry>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public List<TrendingTrendingEntry> Results { get; private set; }

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
        /// Use SearchResultOfTrendingEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SearchResultOfTrendingEntry()
        {
        }

        private SearchResultOfTrendingEntry(List<TrendingTrendingEntry> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of SearchResultOfTrendingEntry.
        /// </summary>
        /// <returns>SearchResultOfTrendingEntryBuilder</returns>
        public static SearchResultOfTrendingEntryBuilder Builder()
        {
            return new SearchResultOfTrendingEntryBuilder();
        }

        /// <summary>
        /// Returns SearchResultOfTrendingEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SearchResultOfTrendingEntryBuilder</returns>
        public SearchResultOfTrendingEntryBuilder With()
        {
            return Builder()
                .Results(Results)
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

        public bool Equals(SearchResultOfTrendingEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SearchResultOfTrendingEntry.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfTrendingEntry</param>
        /// <param name="right">Compared (SearchResultOfTrendingEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SearchResultOfTrendingEntry left, SearchResultOfTrendingEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SearchResultOfTrendingEntry.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfTrendingEntry</param>
        /// <param name="right">Compared (SearchResultOfTrendingEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SearchResultOfTrendingEntry left, SearchResultOfTrendingEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SearchResultOfTrendingEntry.
        /// </summary>
        public sealed class SearchResultOfTrendingEntryBuilder
        {
            private List<TrendingTrendingEntry> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal SearchResultOfTrendingEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SearchResultOfTrendingEntry.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public SearchResultOfTrendingEntryBuilder Results(List<TrendingTrendingEntry> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfTrendingEntry.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public SearchResultOfTrendingEntryBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfTrendingEntry.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public SearchResultOfTrendingEntryBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfTrendingEntry.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public SearchResultOfTrendingEntryBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfTrendingEntry.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public SearchResultOfTrendingEntryBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfTrendingEntry.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public SearchResultOfTrendingEntryBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SearchResultOfTrendingEntry.
            /// </summary>
            /// <returns>SearchResultOfTrendingEntry</returns>
            public SearchResultOfTrendingEntry Build()
            {
                Validate();
                return new SearchResultOfTrendingEntry(
                    Results: _Results,
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