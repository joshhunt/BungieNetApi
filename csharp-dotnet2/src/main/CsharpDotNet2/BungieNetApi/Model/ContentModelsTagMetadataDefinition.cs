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
  public class ContentModelsTagMetadataDefinition {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }

    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<ContentModelsTagMetadataItem> Items { get; set; }

    /// <summary>
    /// Gets or Sets Datatype
    /// </summary>
    [DataMember(Name="datatype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datatype")]
    public string Datatype { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets IsRequired
    /// </summary>
    [DataMember(Name="isRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isRequired")]
    public bool? IsRequired { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsTagMetadataDefinition {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Datatype: ").Append(Datatype).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
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
