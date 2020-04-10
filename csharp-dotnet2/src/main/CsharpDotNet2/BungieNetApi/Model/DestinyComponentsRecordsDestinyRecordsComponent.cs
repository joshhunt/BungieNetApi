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
  public class DestinyComponentsRecordsDestinyRecordsComponent {
    /// <summary>
    /// Gets or Sets Records
    /// </summary>
    [DataMember(Name="records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "records")]
    public Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records { get; set; }

    /// <summary>
    /// The hash for the root presentation node definition of Triumph categories.
    /// </summary>
    /// <value>The hash for the root presentation node definition of Triumph categories.</value>
    [DataMember(Name="recordCategoriesRootNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recordCategoriesRootNodeHash")]
    public int? RecordCategoriesRootNodeHash { get; set; }

    /// <summary>
    /// The hash for the root presentation node definition of Triumph Seals.
    /// </summary>
    /// <value>The hash for the root presentation node definition of Triumph Seals.</value>
    [DataMember(Name="recordSealsRootNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recordSealsRootNodeHash")]
    public int? RecordSealsRootNodeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsRecordsDestinyRecordsComponent {\n");
      sb.Append("  Records: ").Append(Records).Append("\n");
      sb.Append("  RecordCategoriesRootNodeHash: ").Append(RecordCategoriesRootNodeHash).Append("\n");
      sb.Append("  RecordSealsRootNodeHash: ").Append(RecordSealsRootNodeHash).Append("\n");
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
