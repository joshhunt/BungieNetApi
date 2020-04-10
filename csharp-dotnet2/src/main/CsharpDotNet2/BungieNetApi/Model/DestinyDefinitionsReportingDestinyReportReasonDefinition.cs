using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A specific reason for being banned. Only accessible under the related category (DestinyReportReasonCategoryDefinition) under which it is shown. Note that this means that report reasons&#39; reasonHash are not globally unique: and indeed, entries like \&quot;Other\&quot; are defined under most categories for example.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsReportingDestinyReportReasonDefinition {
    /// <summary>
    /// The identifier for the reason: they are only guaranteed unique under the Category in which they are found.
    /// </summary>
    /// <value>The identifier for the reason: they are only guaranteed unique under the Category in which they are found.</value>
    [DataMember(Name="reasonHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasonHash")]
    public int? ReasonHash { get; set; }

    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsReportingDestinyReportReasonDefinition {\n");
      sb.Append("  ReasonHash: ").Append(ReasonHash).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
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
