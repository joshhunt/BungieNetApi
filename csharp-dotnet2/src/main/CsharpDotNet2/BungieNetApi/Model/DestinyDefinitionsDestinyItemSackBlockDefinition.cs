using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Some items are \&quot;sacks\&quot; - they can be \&quot;opened\&quot; to produce other items. This is information related to its sack status, mostly UI strings. Engrams are an example of items that are considered to be \&quot;Sacks\&quot;.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSackBlockDefinition {
    /// <summary>
    /// A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.
    /// </summary>
    /// <value>A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.</value>
    [DataMember(Name="detailAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailAction")]
    public string DetailAction { get; set; }

    /// <summary>
    /// The localized name of the action being performed when you open the sack.
    /// </summary>
    /// <value>The localized name of the action being performed when you open the sack.</value>
    [DataMember(Name="openAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openAction")]
    public string OpenAction { get; set; }

    /// <summary>
    /// Gets or Sets SelectItemCount
    /// </summary>
    [DataMember(Name="selectItemCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selectItemCount")]
    public int? SelectItemCount { get; set; }

    /// <summary>
    /// Gets or Sets VendorSackType
    /// </summary>
    [DataMember(Name="vendorSackType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorSackType")]
    public string VendorSackType { get; set; }

    /// <summary>
    /// Gets or Sets OpenOnAcquire
    /// </summary>
    [DataMember(Name="openOnAcquire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openOnAcquire")]
    public bool? OpenOnAcquire { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSackBlockDefinition {\n");
      sb.Append("  DetailAction: ").Append(DetailAction).Append("\n");
      sb.Append("  OpenAction: ").Append(OpenAction).Append("\n");
      sb.Append("  SelectItemCount: ").Append(SelectItemCount).Append("\n");
      sb.Append("  VendorSackType: ").Append(VendorSackType).Append("\n");
      sb.Append("  OpenOnAcquire: ").Append(OpenOnAcquire).Append("\n");
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
