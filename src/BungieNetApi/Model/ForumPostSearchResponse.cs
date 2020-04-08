/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// ForumPostSearchResponse
    /// </summary>
    [DataContract]
    public partial class ForumPostSearchResponse :  IEquatable<ForumPostSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumPostSearchResponse" /> class.
        /// </summary>
        /// <param name="relatedPosts">relatedPosts.</param>
        /// <param name="authors">authors.</param>
        /// <param name="groups">groups.</param>
        /// <param name="searchedTags">searchedTags.</param>
        /// <param name="polls">polls.</param>
        /// <param name="recruitmentDetails">recruitmentDetails.</param>
        /// <param name="availablePages">availablePages.</param>
        /// <param name="results">results.</param>
        /// <param name="totalResults">totalResults.</param>
        /// <param name="hasMore">hasMore.</param>
        /// <param name="query">query.</param>
        /// <param name="replacementContinuationToken">replacementContinuationToken.</param>
        /// <param name="useTotalResults">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one..</param>
        public ForumPostSearchResponse(List<ForumPostResponse> relatedPosts = default(List<ForumPostResponse>), List<UserGeneralUser> authors = default(List<UserGeneralUser>), List<GroupsV2GroupResponse> groups = default(List<GroupsV2GroupResponse>), List<TagsModelsContractsTagResponse> searchedTags = default(List<TagsModelsContractsTagResponse>), List<ForumPollResponse> polls = default(List<ForumPollResponse>), List<ForumForumRecruitmentDetail> recruitmentDetails = default(List<ForumForumRecruitmentDetail>), int availablePages = default(int), List<ForumPostResponse> results = default(List<ForumPostResponse>), int totalResults = default(int), bool hasMore = default(bool), QueriesPagedQuery query = default(QueriesPagedQuery), string replacementContinuationToken = default(string), bool useTotalResults = default(bool))
        {
            this.RelatedPosts = relatedPosts;
            this.Authors = authors;
            this.Groups = groups;
            this.SearchedTags = searchedTags;
            this.Polls = polls;
            this.RecruitmentDetails = recruitmentDetails;
            this.AvailablePages = availablePages;
            this.Results = results;
            this.TotalResults = totalResults;
            this.HasMore = hasMore;
            this.Query = query;
            this.ReplacementContinuationToken = replacementContinuationToken;
            this.UseTotalResults = useTotalResults;
        }
        
        /// <summary>
        /// Gets or Sets RelatedPosts
        /// </summary>
        [DataMember(Name="relatedPosts", EmitDefaultValue=false)]
        public List<ForumPostResponse> RelatedPosts { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name="authors", EmitDefaultValue=false)]
        public List<UserGeneralUser> Authors { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<GroupsV2GroupResponse> Groups { get; set; }

        /// <summary>
        /// Gets or Sets SearchedTags
        /// </summary>
        [DataMember(Name="searchedTags", EmitDefaultValue=false)]
        public List<TagsModelsContractsTagResponse> SearchedTags { get; set; }

        /// <summary>
        /// Gets or Sets Polls
        /// </summary>
        [DataMember(Name="polls", EmitDefaultValue=false)]
        public List<ForumPollResponse> Polls { get; set; }

        /// <summary>
        /// Gets or Sets RecruitmentDetails
        /// </summary>
        [DataMember(Name="recruitmentDetails", EmitDefaultValue=false)]
        public List<ForumForumRecruitmentDetail> RecruitmentDetails { get; set; }

        /// <summary>
        /// Gets or Sets AvailablePages
        /// </summary>
        [DataMember(Name="availablePages", EmitDefaultValue=false)]
        public int AvailablePages { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<ForumPostResponse> Results { get; set; }

        /// <summary>
        /// Gets or Sets TotalResults
        /// </summary>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="hasMore", EmitDefaultValue=false)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public QueriesPagedQuery Query { get; set; }

        /// <summary>
        /// Gets or Sets ReplacementContinuationToken
        /// </summary>
        [DataMember(Name="replacementContinuationToken", EmitDefaultValue=false)]
        public string ReplacementContinuationToken { get; set; }

        /// <summary>
        /// If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.
        /// </summary>
        /// <value>If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</value>
        [DataMember(Name="useTotalResults", EmitDefaultValue=false)]
        public bool UseTotalResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForumPostSearchResponse {\n");
            sb.Append("  RelatedPosts: ").Append(RelatedPosts).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  SearchedTags: ").Append(SearchedTags).Append("\n");
            sb.Append("  Polls: ").Append(Polls).Append("\n");
            sb.Append("  RecruitmentDetails: ").Append(RecruitmentDetails).Append("\n");
            sb.Append("  AvailablePages: ").Append(AvailablePages).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  ReplacementContinuationToken: ").Append(ReplacementContinuationToken).Append("\n");
            sb.Append("  UseTotalResults: ").Append(UseTotalResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ForumPostSearchResponse);
        }

        /// <summary>
        /// Returns true if ForumPostSearchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumPostSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumPostSearchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RelatedPosts == input.RelatedPosts ||
                    this.RelatedPosts != null &&
                    input.RelatedPosts != null &&
                    this.RelatedPosts.SequenceEqual(input.RelatedPosts)
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.SearchedTags == input.SearchedTags ||
                    this.SearchedTags != null &&
                    input.SearchedTags != null &&
                    this.SearchedTags.SequenceEqual(input.SearchedTags)
                ) && 
                (
                    this.Polls == input.Polls ||
                    this.Polls != null &&
                    input.Polls != null &&
                    this.Polls.SequenceEqual(input.Polls)
                ) && 
                (
                    this.RecruitmentDetails == input.RecruitmentDetails ||
                    this.RecruitmentDetails != null &&
                    input.RecruitmentDetails != null &&
                    this.RecruitmentDetails.SequenceEqual(input.RecruitmentDetails)
                ) && 
                (
                    this.AvailablePages == input.AvailablePages ||
                    (this.AvailablePages != null &&
                    this.AvailablePages.Equals(input.AvailablePages))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    (this.TotalResults != null &&
                    this.TotalResults.Equals(input.TotalResults))
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.ReplacementContinuationToken == input.ReplacementContinuationToken ||
                    (this.ReplacementContinuationToken != null &&
                    this.ReplacementContinuationToken.Equals(input.ReplacementContinuationToken))
                ) && 
                (
                    this.UseTotalResults == input.UseTotalResults ||
                    (this.UseTotalResults != null &&
                    this.UseTotalResults.Equals(input.UseTotalResults))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RelatedPosts != null)
                    hashCode = hashCode * 59 + this.RelatedPosts.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.SearchedTags != null)
                    hashCode = hashCode * 59 + this.SearchedTags.GetHashCode();
                if (this.Polls != null)
                    hashCode = hashCode * 59 + this.Polls.GetHashCode();
                if (this.RecruitmentDetails != null)
                    hashCode = hashCode * 59 + this.RecruitmentDetails.GetHashCode();
                if (this.AvailablePages != null)
                    hashCode = hashCode * 59 + this.AvailablePages.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.TotalResults != null)
                    hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.ReplacementContinuationToken != null)
                    hashCode = hashCode * 59 + this.ReplacementContinuationToken.GetHashCode();
                if (this.UseTotalResults != null)
                    hashCode = hashCode * 59 + this.UseTotalResults.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
