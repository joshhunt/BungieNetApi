using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The list entry view for trending items. Returns just enough to show the item on the trending page.
  /// </summary>
  [DataContract]
  public class TrendingTrendingEntry {
    /// <summary>
    /// The weighted score of this trending item.
    /// </summary>
    /// <value>The weighted score of this trending item.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Gets or Sets IsFeatured
    /// </summary>
    [DataMember(Name="isFeatured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFeatured")]
    public bool? IsFeatured { get; set; }

    /// <summary>
    /// We don't know whether the identifier will be a string, a uint, or a long... so we're going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.
    /// </summary>
    /// <value>We don't know whether the identifier will be a string, a uint, or a long... so we're going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.
    /// </summary>
    /// <value>An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.</value>
    [DataMember(Name="entityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityType")]
    public int? EntityType { get; set; }

    /// <summary>
    /// The localized \"display name/article title/'primary localized identifier'\" of the entity.
    /// </summary>
    /// <value>The localized \"display name/article title/'primary localized identifier'\" of the entity.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// If the entity has a localized tagline/subtitle/motto/whatever, that is found here.
    /// </summary>
    /// <value>If the entity has a localized tagline/subtitle/motto/whatever, that is found here.</value>
    [DataMember(Name="tagline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagline")]
    public string Tagline { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets Link
    /// </summary>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public string Link { get; set; }

    /// <summary>
    /// If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
    /// </summary>
    /// <value>If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo</value>
    [DataMember(Name="webmVideo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webmVideo")]
    public string WebmVideo { get; set; }

    /// <summary>
    /// If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
    /// </summary>
    /// <value>If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo</value>
    [DataMember(Name="mp4Video", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mp4Video")]
    public string Mp4Video { get; set; }

    /// <summary>
    /// If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don't use it all the time.
    /// </summary>
    /// <value>If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don't use it all the time.</value>
    [DataMember(Name="featureImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureImage")]
    public string FeatureImage { get; set; }

    /// <summary>
    /// If the item is of entityType TrendingEntryType.Container, it may have items - also Trending Entries - contained within it. This is the ordered list of those to display under the Container's header.
    /// </summary>
    /// <value>If the item is of entityType TrendingEntryType.Container, it may have items - also Trending Entries - contained within it. This is the ordered list of those to display under the Container's header.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<TrendingTrendingEntry> Items { get; set; }

    /// <summary>
    /// If the entry has a date at which it was created, this is that date.
    /// </summary>
    /// <value>If the entry has a date at which it was created, this is that date.</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrendingTrendingEntry {\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  IsFeatured: ").Append(IsFeatured).Append("\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  EntityType: ").Append(EntityType).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Tagline: ").Append(Tagline).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  WebmVideo: ").Append(WebmVideo).Append("\n");
      sb.Append("  Mp4Video: ").Append(Mp4Video).Append("\n");
      sb.Append("  FeatureImage: ").Append(FeatureImage).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
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
