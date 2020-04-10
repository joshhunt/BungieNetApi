using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupPotentialMembershipSearchResponse
    /// </summary>
    public sealed class GroupsV2GroupPotentialMembershipSearchResponse:  IEquatable<GroupsV2GroupPotentialMembershipSearchResponse>
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
        /// Use GroupsV2GroupPotentialMembershipSearchResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupPotentialMembershipSearchResponse()
        {
        }

        private GroupsV2GroupPotentialMembershipSearchResponse(List<GroupsV2GroupPotentialMembership> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupPotentialMembershipSearchResponse.
        /// </summary>
        /// <returns>GroupsV2GroupPotentialMembershipSearchResponseBuilder</returns>
        public static GroupsV2GroupPotentialMembershipSearchResponseBuilder Builder()
        {
            return new GroupsV2GroupPotentialMembershipSearchResponseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupPotentialMembershipSearchResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupPotentialMembershipSearchResponseBuilder</returns>
        public GroupsV2GroupPotentialMembershipSearchResponseBuilder With()
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

        public bool Equals(GroupsV2GroupPotentialMembershipSearchResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupPotentialMembershipSearchResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupPotentialMembershipSearchResponse</param>
        /// <param name="right">Compared (GroupsV2GroupPotentialMembershipSearchResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupPotentialMembershipSearchResponse left, GroupsV2GroupPotentialMembershipSearchResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupPotentialMembershipSearchResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupPotentialMembershipSearchResponse</param>
        /// <param name="right">Compared (GroupsV2GroupPotentialMembershipSearchResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupPotentialMembershipSearchResponse left, GroupsV2GroupPotentialMembershipSearchResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupPotentialMembershipSearchResponse.
        /// </summary>
        public sealed class GroupsV2GroupPotentialMembershipSearchResponseBuilder
        {
            private List<GroupsV2GroupPotentialMembership> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal GroupsV2GroupPotentialMembershipSearchResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembershipSearchResponse.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public GroupsV2GroupPotentialMembershipSearchResponseBuilder Results(List<GroupsV2GroupPotentialMembership> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembershipSearchResponse.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public GroupsV2GroupPotentialMembershipSearchResponseBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembershipSearchResponse.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public GroupsV2GroupPotentialMembershipSearchResponseBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembershipSearchResponse.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public GroupsV2GroupPotentialMembershipSearchResponseBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembershipSearchResponse.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public GroupsV2GroupPotentialMembershipSearchResponseBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupPotentialMembershipSearchResponse.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public GroupsV2GroupPotentialMembershipSearchResponseBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupPotentialMembershipSearchResponse.
            /// </summary>
            /// <returns>GroupsV2GroupPotentialMembershipSearchResponse</returns>
            public GroupsV2GroupPotentialMembershipSearchResponse Build()
            {
                Validate();
                return new GroupsV2GroupPotentialMembershipSearchResponse(
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