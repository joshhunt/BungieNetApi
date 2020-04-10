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
  public class ContentContentItemPublicContract {
    /// <summary>
    /// Gets or Sets ContentId
    /// </summary>
    [DataMember(Name="contentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contentId")]
    public long? ContentId { get; set; }

    /// <summary>
    /// Gets or Sets CType
    /// </summary>
    [DataMember(Name="cType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cType")]
    public string CType { get; set; }

    /// <summary>
    /// Gets or Sets CmsPath
    /// </summary>
    [DataMember(Name="cmsPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cmsPath")]
    public string CmsPath { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    [DataMember(Name="modifyDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifyDate")]
    public DateTime? ModifyDate { get; set; }

    /// <summary>
    /// Gets or Sets AllowComments
    /// </summary>
    [DataMember(Name="allowComments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowComments")]
    public bool? AllowComments { get; set; }

    /// <summary>
    /// Gets or Sets HasAgeGate
    /// </summary>
    [DataMember(Name="hasAgeGate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasAgeGate")]
    public bool? HasAgeGate { get; set; }

    /// <summary>
    /// Gets or Sets MinimumAge
    /// </summary>
    [DataMember(Name="minimumAge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumAge")]
    public int? MinimumAge { get; set; }

    /// <summary>
    /// Gets or Sets RatingImagePath
    /// </summary>
    [DataMember(Name="ratingImagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratingImagePath")]
    public string RatingImagePath { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public UserGeneralUser Author { get; set; }

    /// <summary>
    /// Gets or Sets AutoEnglishPropertyFallback
    /// </summary>
    [DataMember(Name="autoEnglishPropertyFallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoEnglishPropertyFallback")]
    public bool? AutoEnglishPropertyFallback { get; set; }

    /// <summary>
    /// Firehose content is really a collection of metadata and \"properties\", which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown.  As Cole Porter would have crooned, \"Anything Goes\" with Firehose properties. They are most often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized.
    /// </summary>
    /// <value>Firehose content is really a collection of metadata and \"properties\", which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown.  As Cole Porter would have crooned, \"Anything Goes\" with Firehose properties. They are most often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized.</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public Dictionary<string, Object> Properties { get; set; }

    /// <summary>
    /// Gets or Sets Representations
    /// </summary>
    [DataMember(Name="representations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "representations")]
    public List<ContentContentRepresentation> Representations { get; set; }

    /// <summary>
    /// NOTE: Tags will always be lower case.
    /// </summary>
    /// <value>NOTE: Tags will always be lower case.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets CommentSummary
    /// </summary>
    [DataMember(Name="commentSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commentSummary")]
    public ContentCommentSummary CommentSummary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentContentItemPublicContract {\n");
      sb.Append("  ContentId: ").Append(ContentId).Append("\n");
      sb.Append("  CType: ").Append(CType).Append("\n");
      sb.Append("  CmsPath: ").Append(CmsPath).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
      sb.Append("  AllowComments: ").Append(AllowComments).Append("\n");
      sb.Append("  HasAgeGate: ").Append(HasAgeGate).Append("\n");
      sb.Append("  MinimumAge: ").Append(MinimumAge).Append("\n");
      sb.Append("  RatingImagePath: ").Append(RatingImagePath).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  AutoEnglishPropertyFallback: ").Append(AutoEnglishPropertyFallback).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  Representations: ").Append(Representations).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  CommentSummary: ").Append(CommentSummary).Append("\n");
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
