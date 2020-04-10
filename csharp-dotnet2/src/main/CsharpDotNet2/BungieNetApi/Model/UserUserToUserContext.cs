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
  public class UserUserToUserContext {
    /// <summary>
    /// Gets or Sets IsFollowing
    /// </summary>
    [DataMember(Name="isFollowing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFollowing")]
    public bool? IsFollowing { get; set; }

    /// <summary>
    /// Gets or Sets IgnoreStatus
    /// </summary>
    [DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreStatus")]
    public IgnoresIgnoreResponse IgnoreStatus { get; set; }

    /// <summary>
    /// Gets or Sets GlobalIgnoreEndDate
    /// </summary>
    [DataMember(Name="globalIgnoreEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "globalIgnoreEndDate")]
    public DateTime? GlobalIgnoreEndDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserUserToUserContext {\n");
      sb.Append("  IsFollowing: ").Append(IsFollowing).Append("\n");
      sb.Append("  IgnoreStatus: ").Append(IgnoreStatus).Append("\n");
      sb.Append("  GlobalIgnoreEndDate: ").Append(GlobalIgnoreEndDate).Append("\n");
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
