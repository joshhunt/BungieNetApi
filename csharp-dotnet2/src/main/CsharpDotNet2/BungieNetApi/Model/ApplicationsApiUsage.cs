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
  public class ApplicationsApiUsage {
    /// <summary>
    /// The date range for the data being reported.
    /// </summary>
    /// <value>The date range for the data being reported.</value>
    [DataMember(Name="range", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range")]
    public DatesDateRange Range { get; set; }

    /// <summary>
    /// Counts for on API calls made for the time range.
    /// </summary>
    /// <value>Counts for on API calls made for the time range.</value>
    [DataMember(Name="apiCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiCalls")]
    public List<ApplicationsSeries> ApiCalls { get; set; }

    /// <summary>
    /// Instances of blocked requests or requests that crossed the warn threshold during the time range.
    /// </summary>
    /// <value>Instances of blocked requests or requests that crossed the warn threshold during the time range.</value>
    [DataMember(Name="throttledRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "throttledRequests")]
    public List<ApplicationsSeries> ThrottledRequests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationsApiUsage {\n");
      sb.Append("  Range: ").Append(Range).Append("\n");
      sb.Append("  ApiCalls: ").Append(ApiCalls).Append("\n");
      sb.Append("  ThrottledRequests: ").Append(ThrottledRequests).Append("\n");
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
