using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SearchResultOfDestinyEntitySearchResultItem
    /// </summary>
    public sealed class SearchResultOfDestinyEntitySearchResultItem:  IEquatable<SearchResultOfDestinyEntitySearchResultItem>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public List<DestinyDefinitionsDestinyEntitySearchResultItem> Results { get; private set; }

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
        /// Use SearchResultOfDestinyEntitySearchResultItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SearchResultOfDestinyEntitySearchResultItem()
        {
        }

        private SearchResultOfDestinyEntitySearchResultItem(List<DestinyDefinitionsDestinyEntitySearchResultItem> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of SearchResultOfDestinyEntitySearchResultItem.
        /// </summary>
        /// <returns>SearchResultOfDestinyEntitySearchResultItemBuilder</returns>
        public static SearchResultOfDestinyEntitySearchResultItemBuilder Builder()
        {
            return new SearchResultOfDestinyEntitySearchResultItemBuilder();
        }

        /// <summary>
        /// Returns SearchResultOfDestinyEntitySearchResultItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SearchResultOfDestinyEntitySearchResultItemBuilder</returns>
        public SearchResultOfDestinyEntitySearchResultItemBuilder With()
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

        public bool Equals(SearchResultOfDestinyEntitySearchResultItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SearchResultOfDestinyEntitySearchResultItem.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfDestinyEntitySearchResultItem</param>
        /// <param name="right">Compared (SearchResultOfDestinyEntitySearchResultItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SearchResultOfDestinyEntitySearchResultItem left, SearchResultOfDestinyEntitySearchResultItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SearchResultOfDestinyEntitySearchResultItem.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfDestinyEntitySearchResultItem</param>
        /// <param name="right">Compared (SearchResultOfDestinyEntitySearchResultItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SearchResultOfDestinyEntitySearchResultItem left, SearchResultOfDestinyEntitySearchResultItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SearchResultOfDestinyEntitySearchResultItem.
        /// </summary>
        public sealed class SearchResultOfDestinyEntitySearchResultItemBuilder
        {
            private List<DestinyDefinitionsDestinyEntitySearchResultItem> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal SearchResultOfDestinyEntitySearchResultItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SearchResultOfDestinyEntitySearchResultItem.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public SearchResultOfDestinyEntitySearchResultItemBuilder Results(List<DestinyDefinitionsDestinyEntitySearchResultItem> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfDestinyEntitySearchResultItem.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public SearchResultOfDestinyEntitySearchResultItemBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfDestinyEntitySearchResultItem.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public SearchResultOfDestinyEntitySearchResultItemBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfDestinyEntitySearchResultItem.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public SearchResultOfDestinyEntitySearchResultItemBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfDestinyEntitySearchResultItem.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public SearchResultOfDestinyEntitySearchResultItemBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfDestinyEntitySearchResultItem.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public SearchResultOfDestinyEntitySearchResultItemBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SearchResultOfDestinyEntitySearchResultItem.
            /// </summary>
            /// <returns>SearchResultOfDestinyEntitySearchResultItem</returns>
            public SearchResultOfDestinyEntitySearchResultItem Build()
            {
                Validate();
                return new SearchResultOfDestinyEntitySearchResultItem(
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