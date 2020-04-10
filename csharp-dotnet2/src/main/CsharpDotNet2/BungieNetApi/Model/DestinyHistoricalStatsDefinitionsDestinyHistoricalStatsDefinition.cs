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
  public class DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition {
    /// <summary>
    /// Unique programmer friendly ID for this stat
    /// </summary>
    /// <value>Unique programmer friendly ID for this stat</value>
    [DataMember(Name="statId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statId")]
    public string StatId { get; set; }

    /// <summary>
    /// Statistic group
    /// </summary>
    /// <value>Statistic group</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public int? Group { get; set; }

    /// <summary>
    /// Time periods the statistic covers
    /// </summary>
    /// <value>Time periods the statistic covers</value>
    [DataMember(Name="periodTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periodTypes")]
    public List<int?> PeriodTypes { get; set; }

    /// <summary>
    /// Game modes where this statistic can be reported.
    /// </summary>
    /// <value>Game modes where this statistic can be reported.</value>
    [DataMember(Name="modes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modes")]
    public List<int?> Modes { get; set; }

    /// <summary>
    /// Category for the stat.
    /// </summary>
    /// <value>Category for the stat.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public int? Category { get; set; }

    /// <summary>
    /// Display name
    /// </summary>
    /// <value>Display name</value>
    [DataMember(Name="statName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statName")]
    public string StatName { get; set; }

    /// <summary>
    /// Display name abbreviated
    /// </summary>
    /// <value>Display name abbreviated</value>
    [DataMember(Name="statNameAbbr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statNameAbbr")]
    public string StatNameAbbr { get; set; }

    /// <summary>
    /// Description of a stat if applicable.
    /// </summary>
    /// <value>Description of a stat if applicable.</value>
    [DataMember(Name="statDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statDescription")]
    public string StatDescription { get; set; }

    /// <summary>
    /// Unit, if any, for the statistic
    /// </summary>
    /// <value>Unit, if any, for the statistic</value>
    [DataMember(Name="unitType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitType")]
    public int? UnitType { get; set; }

    /// <summary>
    /// Optional URI to an icon for the statistic
    /// </summary>
    /// <value>Optional URI to an icon for the statistic</value>
    [DataMember(Name="iconImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconImage")]
    public string IconImage { get; set; }

    /// <summary>
    /// Optional icon for the statistic
    /// </summary>
    /// <value>Optional icon for the statistic</value>
    [DataMember(Name="mergeMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mergeMethod")]
    public int? MergeMethod { get; set; }

    /// <summary>
    /// Localized Unit Name for the stat.
    /// </summary>
    /// <value>Localized Unit Name for the stat.</value>
    [DataMember(Name="unitLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitLabel")]
    public string UnitLabel { get; set; }

    /// <summary>
    /// Weight assigned to this stat indicating its relative impressiveness.
    /// </summary>
    /// <value>Weight assigned to this stat indicating its relative impressiveness.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public int? Weight { get; set; }

    /// <summary>
    /// The tier associated with this medal - be it implicitly or explicitly.
    /// </summary>
    /// <value>The tier associated with this medal - be it implicitly or explicitly.</value>
    [DataMember(Name="medalTierHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medalTierHash")]
    public int? MedalTierHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition {\n");
      sb.Append("  StatId: ").Append(StatId).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  PeriodTypes: ").Append(PeriodTypes).Append("\n");
      sb.Append("  Modes: ").Append(Modes).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  StatName: ").Append(StatName).Append("\n");
      sb.Append("  StatNameAbbr: ").Append(StatNameAbbr).Append("\n");
      sb.Append("  StatDescription: ").Append(StatDescription).Append("\n");
      sb.Append("  UnitType: ").Append(UnitType).Append("\n");
      sb.Append("  IconImage: ").Append(IconImage).Append("\n");
      sb.Append("  MergeMethod: ").Append(MergeMethod).Append("\n");
      sb.Append("  UnitLabel: ").Append(UnitLabel).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  MedalTierHash: ").Append(MedalTierHash).Append("\n");
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
