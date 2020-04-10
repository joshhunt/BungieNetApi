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
  public class DestinyComponentsRecordsDestinyProfileRecordsComponent {
    /// <summary>
    /// Your \"Triumphs\" score.
    /// </summary>
    /// <value>Your \"Triumphs\" score.</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public int? Score { get; set; }

    /// <summary>
    /// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
    /// </summary>
    /// <value>If this profile is tracking a record, this is the hash identifier of the record it is tracking.</value>
    [DataMember(Name="trackedRecordHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackedRecordHash")]
    public int? TrackedRecordHash { get; set; }

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
      sb.Append("class DestinyComponentsRecordsDestinyProfileRecordsComponent {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  TrackedRecordHash: ").Append(TrackedRecordHash).Append("\n");
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
