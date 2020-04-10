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
  public class ForumPostResponse {
    /// <summary>
    /// Gets or Sets LastReplyTimestamp
    /// </summary>
    [DataMember(Name="lastReplyTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastReplyTimestamp")]
    public DateTime? LastReplyTimestamp { get; set; }

    /// <summary>
    /// Gets or Sets IsPinned
    /// </summary>
    [DataMember(Name="IsPinned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>
    /// Gets or Sets UrlMediaType
    /// </summary>
    [DataMember(Name="urlMediaType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urlMediaType")]
    public int? UrlMediaType { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public string Thumbnail { get; set; }

    /// <summary>
    /// Gets or Sets Popularity
    /// </summary>
    [DataMember(Name="popularity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "popularity")]
    public int? Popularity { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="isActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsAnnouncement
    /// </summary>
    [DataMember(Name="isAnnouncement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAnnouncement")]
    public bool? IsAnnouncement { get; set; }

    /// <summary>
    /// Gets or Sets UserRating
    /// </summary>
    [DataMember(Name="userRating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userRating")]
    public int? UserRating { get; set; }

    /// <summary>
    /// Gets or Sets UserHasRated
    /// </summary>
    [DataMember(Name="userHasRated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userHasRated")]
    public bool? UserHasRated { get; set; }

    /// <summary>
    /// Gets or Sets UserHasMutedPost
    /// </summary>
    [DataMember(Name="userHasMutedPost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userHasMutedPost")]
    public bool? UserHasMutedPost { get; set; }

    /// <summary>
    /// Gets or Sets LatestReplyPostId
    /// </summary>
    [DataMember(Name="latestReplyPostId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestReplyPostId")]
    public long? LatestReplyPostId { get; set; }

    /// <summary>
    /// Gets or Sets LatestReplyAuthorId
    /// </summary>
    [DataMember(Name="latestReplyAuthorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestReplyAuthorId")]
    public long? LatestReplyAuthorId { get; set; }

    /// <summary>
    /// Gets or Sets IgnoreStatus
    /// </summary>
    [DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreStatus")]
    public IgnoresIgnoreResponse IgnoreStatus { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ForumPostResponse {\n");
      sb.Append("  LastReplyTimestamp: ").Append(LastReplyTimestamp).Append("\n");
      sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
      sb.Append("  UrlMediaType: ").Append(UrlMediaType).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Popularity: ").Append(Popularity).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsAnnouncement: ").Append(IsAnnouncement).Append("\n");
      sb.Append("  UserRating: ").Append(UserRating).Append("\n");
      sb.Append("  UserHasRated: ").Append(UserHasRated).Append("\n");
      sb.Append("  UserHasMutedPost: ").Append(UserHasMutedPost).Append("\n");
      sb.Append("  LatestReplyPostId: ").Append(LatestReplyPostId).Append("\n");
      sb.Append("  LatestReplyAuthorId: ").Append(LatestReplyAuthorId).Append("\n");
      sb.Append("  IgnoreStatus: ").Append(IgnoreStatus).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
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
