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
  public class QueriesPagedQuery {
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
      sb.Append("class QueriesPagedQuery {\n");
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
