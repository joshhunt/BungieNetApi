using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SearchResultOfGroupV2Card
    /// </summary>
    public sealed class SearchResultOfGroupV2Card:  IEquatable<SearchResultOfGroupV2Card>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public List<GroupsV2GroupV2Card> Results { get; private set; }

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
        /// Use SearchResultOfGroupV2Card.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SearchResultOfGroupV2Card()
        {
        }

        private SearchResultOfGroupV2Card(List<GroupsV2GroupV2Card> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of SearchResultOfGroupV2Card.
        /// </summary>
        /// <returns>SearchResultOfGroupV2CardBuilder</returns>
        public static SearchResultOfGroupV2CardBuilder Builder()
        {
            return new SearchResultOfGroupV2CardBuilder();
        }

        /// <summary>
        /// Returns SearchResultOfGroupV2CardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SearchResultOfGroupV2CardBuilder</returns>
        public SearchResultOfGroupV2CardBuilder With()
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

        public bool Equals(SearchResultOfGroupV2Card other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SearchResultOfGroupV2Card.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfGroupV2Card</param>
        /// <param name="right">Compared (SearchResultOfGroupV2Card</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SearchResultOfGroupV2Card left, SearchResultOfGroupV2Card right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SearchResultOfGroupV2Card.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfGroupV2Card</param>
        /// <param name="right">Compared (SearchResultOfGroupV2Card</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SearchResultOfGroupV2Card left, SearchResultOfGroupV2Card right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SearchResultOfGroupV2Card.
        /// </summary>
        public sealed class SearchResultOfGroupV2CardBuilder
        {
            private List<GroupsV2GroupV2Card> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal SearchResultOfGroupV2CardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupV2Card.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public SearchResultOfGroupV2CardBuilder Results(List<GroupsV2GroupV2Card> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupV2Card.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public SearchResultOfGroupV2CardBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupV2Card.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public SearchResultOfGroupV2CardBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupV2Card.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public SearchResultOfGroupV2CardBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupV2Card.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public SearchResultOfGroupV2CardBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupV2Card.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public SearchResultOfGroupV2CardBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SearchResultOfGroupV2Card.
            /// </summary>
            /// <returns>SearchResultOfGroupV2Card</returns>
            public SearchResultOfGroupV2Card Build()
            {
                Validate();
                return new SearchResultOfGroupV2Card(
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