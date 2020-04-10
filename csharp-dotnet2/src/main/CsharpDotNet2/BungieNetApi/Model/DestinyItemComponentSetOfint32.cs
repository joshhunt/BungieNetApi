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
  public class DestinyItemComponentSetOfint32 {
    /// <summary>
    /// Gets or Sets Instances
    /// </summary>
    [DataMember(Name="instances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instances")]
    public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent Instances { get; set; }

    /// <summary>
    /// Gets or Sets Perks
    /// </summary>
    [DataMember(Name="perks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perks")]
    public DictionaryComponentResponseOfint32AndDestinyItemPerksComponent Perks { get; set; }

    /// <summary>
    /// Gets or Sets RenderData
    /// </summary>
    [DataMember(Name="renderData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renderData")]
    public DictionaryComponentResponseOfint32AndDestinyItemRenderComponent RenderData { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public DictionaryComponentResponseOfint32AndDestinyItemStatsComponent Stats { get; set; }

    /// <summary>
    /// Gets or Sets Sockets
    /// </summary>
    [DataMember(Name="sockets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sockets")]
    public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent Sockets { get; set; }

    /// <summary>
    /// Gets or Sets ReusablePlugs
    /// </summary>
    [DataMember(Name="reusablePlugs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusablePlugs")]
    public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

    /// <summary>
    /// Gets or Sets PlugObjectives
    /// </summary>
    [DataMember(Name="plugObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugObjectives")]
    public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }

    /// <summary>
    /// Gets or Sets TalentGrids
    /// </summary>
    [DataMember(Name="talentGrids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "talentGrids")]
    public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent TalentGrids { get; set; }

    /// <summary>
    /// Gets or Sets PlugStates
    /// </summary>
    [DataMember(Name="plugStates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugStates")]
    public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }

    /// <summary>
    /// Gets or Sets Objectives
    /// </summary>
    [DataMember(Name="objectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectives")]
    public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyItemComponentSetOfint32 {\n");
      sb.Append("  Instances: ").Append(Instances).Append("\n");
      sb.Append("  Perks: ").Append(Perks).Append("\n");
      sb.Append("  RenderData: ").Append(RenderData).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  Sockets: ").Append(Sockets).Append("\n");
      sb.Append("  ReusablePlugs: ").Append(ReusablePlugs).Append("\n");
      sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
      sb.Append("  TalentGrids: ").Append(TalentGrids).Append("\n");
      sb.Append("  PlugStates: ").Append(PlugStates).Append("\n");
      sb.Append("  Objectives: ").Append(Objectives).Append("\n");
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
