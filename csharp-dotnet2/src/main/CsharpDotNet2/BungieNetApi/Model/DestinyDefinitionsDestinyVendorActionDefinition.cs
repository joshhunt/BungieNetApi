using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If a vendor can ever end up performing actions, these are the properties that will be related to those actions. I&#39;m not going to bother documenting this yet, as it is unused and unclear if it will ever be used... but in case it is ever populated and someone finds it useful, it is defined here.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorActionDefinition {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets ExecuteSeconds
    /// </summary>
    [DataMember(Name="executeSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executeSeconds")]
    public int? ExecuteSeconds { get; set; }

    /// <summary>
    /// Gets or Sets Icon
    /// </summary>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Verb
    /// </summary>
    [DataMember(Name="verb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verb")]
    public string Verb { get; set; }

    /// <summary>
    /// Gets or Sets IsPositive
    /// </summary>
    [DataMember(Name="isPositive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPositive")]
    public bool? IsPositive { get; set; }

    /// <summary>
    /// Gets or Sets ActionId
    /// </summary>
    [DataMember(Name="actionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionId")]
    public string ActionId { get; set; }

    /// <summary>
    /// Gets or Sets ActionHash
    /// </summary>
    [DataMember(Name="actionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionHash")]
    public int? ActionHash { get; set; }

    /// <summary>
    /// Gets or Sets AutoPerformAction
    /// </summary>
    [DataMember(Name="autoPerformAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoPerformAction")]
    public bool? AutoPerformAction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorActionDefinition {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ExecuteSeconds: ").Append(ExecuteSeconds).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Verb: ").Append(Verb).Append("\n");
      sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
      sb.Append("  ActionId: ").Append(ActionId).Append("\n");
      sb.Append("  ActionHash: ").Append(ActionHash).Append("\n");
      sb.Append("  AutoPerformAction: ").Append(AutoPerformAction).Append("\n");
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
