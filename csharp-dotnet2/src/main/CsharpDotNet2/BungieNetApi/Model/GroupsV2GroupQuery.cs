using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible \&quot;modes\&quot;.  If you are querying for a group, you can pass any of the properties below.  If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be null or undefined in your request, not just empty string/default values):  - groupMemberCountFilter - localeFilter - tagText  If you pass these, you will get a useless InvalidParameters error.
  /// </summary>
  [DataContract]
  public class GroupsV2GroupQuery {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets GroupType
    /// </summary>
    [DataMember(Name="groupType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupType")]
    public int? GroupType { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public int? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets SortBy
    /// </summary>
    [DataMember(Name="sortBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortBy")]
    public int? SortBy { get; set; }

    /// <summary>
    /// Gets or Sets GroupMemberCountFilter
    /// </summary>
    [DataMember(Name="groupMemberCountFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupMemberCountFilter")]
    public int? GroupMemberCountFilter { get; set; }

    /// <summary>
    /// Gets or Sets LocaleFilter
    /// </summary>
    [DataMember(Name="localeFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localeFilter")]
    public string LocaleFilter { get; set; }

    /// <summary>
    /// Gets or Sets TagText
    /// </summary>
    [DataMember(Name="tagText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagText")]
    public string TagText { get; set; }

    /// <summary>
    /// Gets or Sets ItemsPerPage
    /// </summary>
    [DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemsPerPage")]
    public int? ItemsPerPage { get; set; }

    /// <summary>
    /// Gets or Sets CurrentPage
    /// </summary>
    [DataMember(Name="currentPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPage")]
    public int? CurrentPage { get; set; }

    /// <summary>
    /// Gets or Sets RequestContinuationToken
    /// </summary>
    [DataMember(Name="requestContinuationToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestContinuationToken")]
    public string RequestContinuationToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupQuery {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  GroupType: ").Append(GroupType).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  SortBy: ").Append(SortBy).Append("\n");
      sb.Append("  GroupMemberCountFilter: ").Append(GroupMemberCountFilter).Append("\n");
      sb.Append("  LocaleFilter: ").Append(LocaleFilter).Append("\n");
      sb.Append("  TagText: ").Append(TagText).Append("\n");
      sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
      sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
      sb.Append("  RequestContinuationToken: ").Append(RequestContinuationToken).Append("\n");
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
