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
  public class SearchResultOfGroupV2Card {
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public List<GroupsV2GroupV2Card> Results { get; set; }

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
      sb.Append("class SearchResultOfGroupV2Card {\n");
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
