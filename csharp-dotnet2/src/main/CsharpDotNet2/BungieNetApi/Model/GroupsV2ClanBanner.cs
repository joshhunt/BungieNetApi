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
  public class GroupsV2ClanBanner {
    /// <summary>
    /// Gets or Sets DecalId
    /// </summary>
    [DataMember(Name="decalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decalId")]
    public int? DecalId { get; set; }

    /// <summary>
    /// Gets or Sets DecalColorId
    /// </summary>
    [DataMember(Name="decalColorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decalColorId")]
    public int? DecalColorId { get; set; }

    /// <summary>
    /// Gets or Sets DecalBackgroundColorId
    /// </summary>
    [DataMember(Name="decalBackgroundColorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decalBackgroundColorId")]
    public int? DecalBackgroundColorId { get; set; }

    /// <summary>
    /// Gets or Sets GonfalonId
    /// </summary>
    [DataMember(Name="gonfalonId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gonfalonId")]
    public int? GonfalonId { get; set; }

    /// <summary>
    /// Gets or Sets GonfalonColorId
    /// </summary>
    [DataMember(Name="gonfalonColorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gonfalonColorId")]
    public int? GonfalonColorId { get; set; }

    /// <summary>
    /// Gets or Sets GonfalonDetailId
    /// </summary>
    [DataMember(Name="gonfalonDetailId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gonfalonDetailId")]
    public int? GonfalonDetailId { get; set; }

    /// <summary>
    /// Gets or Sets GonfalonDetailColorId
    /// </summary>
    [DataMember(Name="gonfalonDetailColorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gonfalonDetailColorId")]
    public int? GonfalonDetailColorId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2ClanBanner {\n");
      sb.Append("  DecalId: ").Append(DecalId).Append("\n");
      sb.Append("  DecalColorId: ").Append(DecalColorId).Append("\n");
      sb.Append("  DecalBackgroundColorId: ").Append(DecalBackgroundColorId).Append("\n");
      sb.Append("  GonfalonId: ").Append(GonfalonId).Append("\n");
      sb.Append("  GonfalonColorId: ").Append(GonfalonColorId).Append("\n");
      sb.Append("  GonfalonDetailId: ").Append(GonfalonDetailId).Append("\n");
      sb.Append("  GonfalonDetailColorId: ").Append(GonfalonDetailColorId).Append("\n");
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
