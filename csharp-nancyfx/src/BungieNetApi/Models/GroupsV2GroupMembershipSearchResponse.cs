using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupMembershipSearchResponse
    /// </summary>
    public sealed class GroupsV2GroupMembershipSearchResponse:  IEquatable<GroupsV2GroupMembershipSearchResponse>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public List<GroupsV2GroupMembership> Results { get; private set; }

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
        /// Use GroupsV2GroupMembershipSearchResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupMembershipSearchResponse()
        {
        }

        private GroupsV2GroupMembershipSearchResponse(List<GroupsV2GroupMembership> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupMembershipSearchResponse.
        /// </summary>
        /// <returns>GroupsV2GroupMembershipSearchResponseBuilder</returns>
        public static GroupsV2GroupMembershipSearchResponseBuilder Builder()
        {
            return new GroupsV2GroupMembershipSearchResponseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupMembershipSearchResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupMembershipSearchResponseBuilder</returns>
        public GroupsV2GroupMembershipSearchResponseBuilder With()
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

        public bool Equals(GroupsV2GroupMembershipSearchResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupMembershipSearchResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMembershipSearchResponse</param>
        /// <param name="right">Compared (GroupsV2GroupMembershipSearchResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupMembershipSearchResponse left, GroupsV2GroupMembershipSearchResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupMembershipSearchResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupMembershipSearchResponse</param>
        /// <param name="right">Compared (GroupsV2GroupMembershipSearchResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupMembershipSearchResponse left, GroupsV2GroupMembershipSearchResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupMembershipSearchResponse.
        /// </summary>
        public sealed class GroupsV2GroupMembershipSearchResponseBuilder
        {
            private List<GroupsV2GroupMembership> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal GroupsV2GroupMembershipSearchResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipSearchResponse.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public GroupsV2GroupMembershipSearchResponseBuilder Results(List<GroupsV2GroupMembership> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipSearchResponse.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public GroupsV2GroupMembershipSearchResponseBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipSearchResponse.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public GroupsV2GroupMembershipSearchResponseBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipSearchResponse.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public GroupsV2GroupMembershipSearchResponseBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipSearchResponse.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public GroupsV2GroupMembershipSearchResponseBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupMembershipSearchResponse.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public GroupsV2GroupMembershipSearchResponseBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupMembershipSearchResponse.
            /// </summary>
            /// <returns>GroupsV2GroupMembershipSearchResponse</returns>
            public GroupsV2GroupMembershipSearchResponse Build()
            {
                Validate();
                return new GroupsV2GroupMembershipSearchResponse(
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