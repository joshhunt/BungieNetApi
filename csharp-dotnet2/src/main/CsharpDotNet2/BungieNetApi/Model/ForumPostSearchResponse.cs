using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ForumPostSearchResponse {
    /// <summary>
    /// Gets or Sets RelatedPosts
    /// </summary>
    [DataMember(Name="relatedPosts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedPosts")]
    public List<ForumPostResponse> RelatedPosts { get; set; }

    /// <summary>
    /// Gets or Sets Authors
    /// </summary>
    [DataMember(Name="authors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authors")]
    public List<UserGeneralUser> Authors { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<GroupsV2GroupResponse> Groups { get; set; }

    /// <summary>
    /// Gets or Sets SearchedTags
    /// </summary>
    [DataMember(Name="searchedTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchedTags")]
    public List<TagsModelsContractsTagResponse> SearchedTags { get; set; }

    /// <summary>
    /// Gets or Sets Polls
    /// </summary>
    [DataMember(Name="polls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "polls")]
    public List<ForumPollResponse> Polls { get; set; }

    /// <summary>
    /// Gets or Sets RecruitmentDetails
    /// </summary>
    [DataMember(Name="recruitmentDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recruitmentDetails")]
    public List<ForumForumRecruitmentDetail> RecruitmentDetails { get; set; }

    /// <summary>
    /// Gets or Sets AvailablePages
    /// </summary>
    [DataMember(Name="availablePages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availablePages")]
    public int? AvailablePages { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public List<ForumPostResponse> Results { get; set; }

    /// <summary>
    /// Gets or Sets TotalResults
    /// </summary>
    [DataMember(Name="totalResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalResults")]
    public int? TotalResults { get; set; }

    /// <summary>
    /// Gets or Sets HasMore
    /// </summary>
    [DataMember(Name="hasMore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    [DataMember(Name="query", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "query")]
    public QueriesPagedQuery Query { get; set; }

    /// <summary>
    /// Gets or Sets ReplacementContinuationToken
    /// </summary>
    [DataMember(Name="replacementContinuationToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replacementContinuationToken")]
    public string ReplacementContinuationToken { get; set; }

    /// <summary>
    /// If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.
    /// </summary>
    /// <value>If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</value>
    [DataMember(Name="useTotalResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useTotalResults")]
    public bool? UseTotalResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
