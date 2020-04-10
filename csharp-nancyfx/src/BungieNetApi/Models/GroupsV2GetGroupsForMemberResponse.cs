using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GetGroupsForMemberResponse
    /// </summary>
    public sealed class GroupsV2GetGroupsForMemberResponse:  IEquatable<GroupsV2GetGroupsForMemberResponse>
    { 
        /// <summary>
        /// A convenience property that indicates if every membership this user has that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.   The key is the Group ID for the group being checked, and the value is true if the users&#39; memberships for that group are all inactive.
        /// </summary>
        public Dictionary<string, bool?> AreAllMembershipsInactive { get; private set; }

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
        /// Use GroupsV2GetGroupsForMemberResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GetGroupsForMemberResponse()
        {
        }

        private GroupsV2GetGroupsForMemberResponse(Dictionary<string, bool?> AreAllMembershipsInactive, List<GroupsV2GroupMembership> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.AreAllMembershipsInactive = AreAllMembershipsInactive;
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GetGroupsForMemberResponse.
        /// </summary>
        /// <returns>GroupsV2GetGroupsForMemberResponseBuilder</returns>
        public static GroupsV2GetGroupsForMemberResponseBuilder Builder()
        {
            return new GroupsV2GetGroupsForMemberResponseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GetGroupsForMemberResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GetGroupsForMemberResponseBuilder</returns>
        public GroupsV2GetGroupsForMemberResponseBuilder With()
        {
            return Builder()
                .AreAllMembershipsInactive(AreAllMembershipsInactive)
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

        public bool Equals(GroupsV2GetGroupsForMemberResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GetGroupsForMemberResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GetGroupsForMemberResponse</param>
        /// <param name="right">Compared (GroupsV2GetGroupsForMemberResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GetGroupsForMemberResponse left, GroupsV2GetGroupsForMemberResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GetGroupsForMemberResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GetGroupsForMemberResponse</param>
        /// <param name="right">Compared (GroupsV2GetGroupsForMemberResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GetGroupsForMemberResponse left, GroupsV2GetGroupsForMemberResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GetGroupsForMemberResponse.
        /// </summary>
        public sealed class GroupsV2GetGroupsForMemberResponseBuilder
        {
            private Dictionary<string, bool?> _AreAllMembershipsInactive;
            private List<GroupsV2GroupMembership> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal GroupsV2GetGroupsForMemberResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.AreAllMembershipsInactive property.
            /// </summary>
            /// <param name="value">A convenience property that indicates if every membership this user has that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.   The key is the Group ID for the group being checked, and the value is true if the users&#39; memberships for that group are all inactive.</param>
            public GroupsV2GetGroupsForMemberResponseBuilder AreAllMembershipsInactive(Dictionary<string, bool?> value)
            {
                _AreAllMembershipsInactive = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public GroupsV2GetGroupsForMemberResponseBuilder Results(List<GroupsV2GroupMembership> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public GroupsV2GetGroupsForMemberResponseBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public GroupsV2GetGroupsForMemberResponseBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public GroupsV2GetGroupsForMemberResponseBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public GroupsV2GetGroupsForMemberResponseBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GetGroupsForMemberResponse.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public GroupsV2GetGroupsForMemberResponseBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GetGroupsForMemberResponse.
            /// </summary>
            /// <returns>GroupsV2GetGroupsForMemberResponse</returns>
            public GroupsV2GetGroupsForMemberResponse Build()
            {
                Validate();
                return new GroupsV2GetGroupsForMemberResponse(
                    AreAllMembershipsInactive: _AreAllMembershipsInactive,
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