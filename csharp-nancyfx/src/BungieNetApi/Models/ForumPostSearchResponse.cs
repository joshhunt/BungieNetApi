using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ForumPostSearchResponse
    /// </summary>
    public sealed class ForumPostSearchResponse:  IEquatable<ForumPostSearchResponse>
    { 
        /// <summary>
        /// RelatedPosts
        /// </summary>
        public List<ForumPostResponse> RelatedPosts { get; private set; }

        /// <summary>
        /// Authors
        /// </summary>
        public List<UserGeneralUser> Authors { get; private set; }

        /// <summary>
        /// Groups
        /// </summary>
        public List<GroupsV2GroupResponse> Groups { get; private set; }

        /// <summary>
        /// SearchedTags
        /// </summary>
        public List<TagsModelsContractsTagResponse> SearchedTags { get; private set; }

        /// <summary>
        /// Polls
        /// </summary>
        public List<ForumPollResponse> Polls { get; private set; }

        /// <summary>
        /// RecruitmentDetails
        /// </summary>
        public List<ForumForumRecruitmentDetail> RecruitmentDetails { get; private set; }

        /// <summary>
        /// AvailablePages
        /// </summary>
        public int? AvailablePages { get; private set; }

        /// <summary>
        /// Results
        /// </summary>
        public List<ForumPostResponse> Results { get; private set; }

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
        /// Use ForumPostSearchResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ForumPostSearchResponse()
        {
        }

        private ForumPostSearchResponse(List<ForumPostResponse> RelatedPosts, List<UserGeneralUser> Authors, List<GroupsV2GroupResponse> Groups, List<TagsModelsContractsTagResponse> SearchedTags, List<ForumPollResponse> Polls, List<ForumForumRecruitmentDetail> RecruitmentDetails, int? AvailablePages, List<ForumPostResponse> Results, int? TotalResults, bool? HasMore, QueriesPagedQuery Query, string ReplacementContinuationToken, bool? UseTotalResults)
        {
            
            this.RelatedPosts = RelatedPosts;
            
            this.Authors = Authors;
            
            this.Groups = Groups;
            
            this.SearchedTags = SearchedTags;
            
            this.Polls = Polls;
            
            this.RecruitmentDetails = RecruitmentDetails;
            
            this.AvailablePages = AvailablePages;
            
            this.Results = Results;
            
            this.TotalResults = TotalResults;
            
            this.HasMore = HasMore;
            
            this.Query = Query;
            
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            
            this.UseTotalResults = UseTotalResults;
            
        }

        /// <summary>
        /// Returns builder of ForumPostSearchResponse.
        /// </summary>
        /// <returns>ForumPostSearchResponseBuilder</returns>
        public static ForumPostSearchResponseBuilder Builder()
        {
            return new ForumPostSearchResponseBuilder();
        }

        /// <summary>
        /// Returns ForumPostSearchResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ForumPostSearchResponseBuilder</returns>
        public ForumPostSearchResponseBuilder With()
        {
            return Builder()
                .RelatedPosts(RelatedPosts)
                .Authors(Authors)
                .Groups(Groups)
                .SearchedTags(SearchedTags)
                .Polls(Polls)
                .RecruitmentDetails(RecruitmentDetails)
                .AvailablePages(AvailablePages)
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

        public bool Equals(ForumPostSearchResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ForumPostSearchResponse.
        /// </summary>
        /// <param name="left">Compared (ForumPostSearchResponse</param>
        /// <param name="right">Compared (ForumPostSearchResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ForumPostSearchResponse left, ForumPostSearchResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ForumPostSearchResponse.
        /// </summary>
        /// <param name="left">Compared (ForumPostSearchResponse</param>
        /// <param name="right">Compared (ForumPostSearchResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ForumPostSearchResponse left, ForumPostSearchResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ForumPostSearchResponse.
        /// </summary>
        public sealed class ForumPostSearchResponseBuilder
        {
            private List<ForumPostResponse> _RelatedPosts;
            private List<UserGeneralUser> _Authors;
            private List<GroupsV2GroupResponse> _Groups;
            private List<TagsModelsContractsTagResponse> _SearchedTags;
            private List<ForumPollResponse> _Polls;
            private List<ForumForumRecruitmentDetail> _RecruitmentDetails;
            private int? _AvailablePages;
            private List<ForumPostResponse> _Results;
            private int? _TotalResults;
            private bool? _HasMore;
            private QueriesPagedQuery _Query;
            private string _ReplacementContinuationToken;
            private bool? _UseTotalResults;

            internal ForumPostSearchResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.RelatedPosts property.
            /// </summary>
            /// <param name="value">RelatedPosts</param>
            public ForumPostSearchResponseBuilder RelatedPosts(List<ForumPostResponse> value)
            {
                _RelatedPosts = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.Authors property.
            /// </summary>
            /// <param name="value">Authors</param>
            public ForumPostSearchResponseBuilder Authors(List<UserGeneralUser> value)
            {
                _Authors = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.Groups property.
            /// </summary>
            /// <param name="value">Groups</param>
            public ForumPostSearchResponseBuilder Groups(List<GroupsV2GroupResponse> value)
            {
                _Groups = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.SearchedTags property.
            /// </summary>
            /// <param name="value">SearchedTags</param>
            public ForumPostSearchResponseBuilder SearchedTags(List<TagsModelsContractsTagResponse> value)
            {
                _SearchedTags = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.Polls property.
            /// </summary>
            /// <param name="value">Polls</param>
            public ForumPostSearchResponseBuilder Polls(List<ForumPollResponse> value)
            {
                _Polls = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.RecruitmentDetails property.
            /// </summary>
            /// <param name="value">RecruitmentDetails</param>
            public ForumPostSearchResponseBuilder RecruitmentDetails(List<ForumForumRecruitmentDetail> value)
            {
                _RecruitmentDetails = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.AvailablePages property.
            /// </summary>
            /// <param name="value">AvailablePages</param>
            public ForumPostSearchResponseBuilder AvailablePages(int? value)
            {
                _AvailablePages = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public ForumPostSearchResponseBuilder Results(List<ForumPostResponse> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.TotalResults property.
            /// </summary>
            /// <param name="value">TotalResults</param>
            public ForumPostSearchResponseBuilder TotalResults(int? value)
            {
                _TotalResults = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.HasMore property.
            /// </summary>
            /// <param name="value">HasMore</param>
            public ForumPostSearchResponseBuilder HasMore(bool? value)
            {
                _HasMore = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.Query property.
            /// </summary>
            /// <param name="value">Query</param>
            public ForumPostSearchResponseBuilder Query(QueriesPagedQuery value)
            {
                _Query = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.ReplacementContinuationToken property.
            /// </summary>
            /// <param name="value">ReplacementContinuationToken</param>
            public ForumPostSearchResponseBuilder ReplacementContinuationToken(string value)
            {
                _ReplacementContinuationToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostSearchResponse.UseTotalResults property.
            /// </summary>
            /// <param name="value">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</param>
            public ForumPostSearchResponseBuilder UseTotalResults(bool? value)
            {
                _UseTotalResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ForumPostSearchResponse.
            /// </summary>
            /// <returns>ForumPostSearchResponse</returns>
            public ForumPostSearchResponse Build()
            {
                Validate();
                return new ForumPostSearchResponse(
                    RelatedPosts: _RelatedPosts,
                    Authors: _Authors,
                    Groups: _Groups,
                    SearchedTags: _SearchedTags,
                    Polls: _Polls,
                    RecruitmentDetails: _RecruitmentDetails,
                    AvailablePages: _AvailablePages,
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