using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SearchResultOfGroupPotentialMembership
    /// </summary>
    public sealed class SearchResultOfGroupPotentialMembership:  IEquatable<SearchResultOfGroupPotentialMembership>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public List<GroupsV2GroupPotentialMembership> Results { get; private set; }

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
        /// Use SearchResultOfGroupPotentialMembership.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SearchResultOfGroupPotentialMembership()
        {
        }

        private SearchResultOfGroupPotentialMembership(List<GroupsV2GroupPotentialMembership> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of SearchResultOfGroupPotentialMembership.
        /// </summary>
        /// <returns>SearchResultOfGroupPotentialMembershipBuilder</returns>
        public static SearchResultOfGroupPotentialMembershipBuilder Builder()
        {
            return new SearchResultOfGroupPotentialMembershipBuilder();
        }

        /// <summary>
        /// Returns SearchResultOfGroupPotentialMembershipBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SearchResultOfGroupPotentialMembershipBuilder</returns>
        public SearchResultOfGroupPotentialMembershipBuilder With()
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

        public bool Equals(SearchResultOfGroupPotentialMembership other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SearchResultOfGroupPotentialMembership.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfGroupPotentialMembership</param>
        /// <param name="right">Compared (SearchResultOfGroupPotentialMembership</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SearchResultOfGroupPotentialMembership left, SearchResultOfGroupPotentialMembership right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SearchResultOfGroupPotentialMembership.
        /// </summary>
        /// <param name="left">Compared (SearchResultOfGroupPotentialMembership</param>
        /// <param name="right">Compared (SearchResultOfGroupPotentialMembership</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SearchResultOfGroupPotentialMembership left, SearchResultOfGroupPotentialMembership right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SearchResultOfGroupPotentialMembership.
        /// </summary>
        public sealed class SearchResultOfGroupPotentialMembershipBuilder
        {
            private List<GroupsV2GroupPotentialMembership> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal SearchResultOfGroupPotentialMembershipBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupPotentialMembership.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public SearchResultOfGroupPotentialMembershipBuilder Results(List<GroupsV2GroupPotentialMembership> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupPotentialMembership.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public SearchResultOfGroupPotentialMembershipBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupPotentialMembership.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public SearchResultOfGroupPotentialMembershipBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupPotentialMembership.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public SearchResultOfGroupPotentialMembershipBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupPotentialMembership.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public SearchResultOfGroupPotentialMembershipBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for SearchResultOfGroupPotentialMembership.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public SearchResultOfGroupPotentialMembershipBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SearchResultOfGroupPotentialMembership.
            /// </summary>
            /// <returns>SearchResultOfGroupPotentialMembership</returns>
            public SearchResultOfGroupPotentialMembership Build()
            {
                Validate();
                return new SearchResultOfGroupPotentialMembership(
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