using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This describes links between the current graph and others, as well as when that link is relevant.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDirectorDestinyLinkedGraphDefinition {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets UnlockExpression
    /// </summary>
    [DataMember(Name="unlockExpression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unlockExpression")]
    public DestinyDefinitionsDestinyUnlockExpressionDefinition UnlockExpression { get; set; }

    /// <summary>
    /// Gets or Sets LinkedGraphId
    /// </summary>
    [DataMember(Name="linkedGraphId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedGraphId")]
    public int? LinkedGraphId { get; set; }

    /// <summary>
    /// Gets or Sets LinkedGraphs
    /// </summary>
    [DataMember(Name="linkedGraphs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedGraphs")]
    public List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> LinkedGraphs { get; set; }

    /// <summary>
    /// Gets or Sets Overview
    /// </summary>
    [DataMember(Name="overview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overview")]
    public string Overview { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDirectorDestinyLinkedGraphDefinition {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  UnlockExpression: ").Append(UnlockExpression).Append("\n");
      sb.Append("  LinkedGraphId: ").Append(LinkedGraphId).Append("\n");
      sb.Append("  LinkedGraphs: ").Append(LinkedGraphs).Append("\n");
      sb.Append("  Overview: ").Append(Overview).Append("\n");
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
