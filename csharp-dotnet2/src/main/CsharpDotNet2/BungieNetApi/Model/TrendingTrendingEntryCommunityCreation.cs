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
  public class TrendingTrendingEntryCommunityCreation {
    /// <summary>
    /// Gets or Sets Media
    /// </summary>
    [DataMember(Name="media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media")]
    public string Media { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public string Author { get; set; }

    /// <summary>
    /// Gets or Sets AuthorMembershipId
    /// </summary>
    [DataMember(Name="authorMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorMembershipId")]
    public long? AuthorMembershipId { get; set; }

    /// <summary>
    /// Gets or Sets PostId
    /// </summary>
    [DataMember(Name="postId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postId")]
    public long? PostId { get; set; }

    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets Upvotes
    /// </summary>
    [DataMember(Name="upvotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upvotes")]
    public int? Upvotes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrendingTrendingEntryCommunityCreation {\n");
      sb.Append("  Media: ").Append(Media).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  AuthorMembershipId: ").Append(AuthorMembershipId).Append("\n");
      sb.Append("  PostId: ").Append(PostId).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Upvotes: ").Append(Upvotes).Append("\n");
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
