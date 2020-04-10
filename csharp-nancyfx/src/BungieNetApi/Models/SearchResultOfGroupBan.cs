using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SearchResultOfGroupBan
    /// </summary>
    public sealed class SearchResultOfGroupBan:  IEquatable<SearchResultOfGroupBan>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public List<GroupsV2GroupBan> Results { get; private set; }

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
        /// Use SearchResultOfGroupBan.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SearchResultOfGroupBan()
        {
        }

        private SearchResultOfGroupBan(List<GroupsV2GroupBan> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of SearchResultOfGroupBan.
        /// </summary>
        /// <returns>SearchResultOfGroupBanBuilder</returns>
        public static SearchResultOfGroupBanBuilder Builder()
        {
            return new SearchResultOfGroupBanBuilder();
        }

        /// <summary>
        /// Returns SearchResultOfGroupBanBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SearchResultOfGroupBanBuilder</returns>
        public SearchResultOfGroupBanBuilder With()
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

        public bool Equals(SearchResultOfGroupBan other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SearchResultOfGroupBan.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfGroupBan</param>
        /// <param name="right">Compared (SearchResultOfGroupBan</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SearchResultOfGroupBan left, SearchResultOfGroupBan right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SearchResultOfGroupBan.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfGroupBan</param>
        /// <param name="right">Compared (SearchResultOfGroupBan</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SearchResultOfGroupBan left, SearchResultOfGroupBan right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SearchResultOfGroupBan.
        /// </summary>
        public sealed class SearchResultOfGroupBanBuilder
        {
            private List<GroupsV2GroupBan> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal SearchResultOfGroupBanBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupBan.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public SearchResultOfGroupBanBuilder Results(List<GroupsV2GroupBan> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupBan.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public SearchResultOfGroupBanBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupBan.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public SearchResultOfGroupBanBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupBan.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public SearchResultOfGroupBanBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupBan.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public SearchResultOfGroupBanBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupBan.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public SearchResultOfGroupBanBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SearchResultOfGroupBan.
            /// </summary>
            /// <returns>SearchResultOfGroupBan</returns>
            public SearchResultOfGroupBan Build()
            {
                Validate();
                return new SearchResultOfGroupBan(
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