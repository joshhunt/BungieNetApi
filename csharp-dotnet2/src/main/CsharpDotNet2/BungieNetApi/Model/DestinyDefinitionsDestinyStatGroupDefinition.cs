using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// When an inventory item (DestinyInventoryItemDefinition) has Stats (such as Attack Power), the item will refer to a Stat Group. This definition enumerates the properties used to transform the item&#39;s \&quot;Investment\&quot; stats into \&quot;Display\&quot; stats.  See DestinyStatDefinition&#39;s documentation for information about the transformation of Stats, and the meaning of an Investment vs. a Display stat.  If you don&#39;t want to do these calculations on your own, fear not: pulling live data from the BNet endpoints will return display stat values pre-computed and ready for you to use. I highly recommend this approach, saves a lot of time and also accounts for certain stat modifiers that can&#39;t easily be accounted for without live data (such as stat modifiers on Talent Grids and Socket Plugs)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyStatGroupDefinition {
    /// <summary>
    /// The maximum possible value that any stat in this group can be transformed into.  This is used by stats that *don't* have scaledStats entries below, but that still need to be displayed as a progress bar, in which case this is used as the upper bound for said progress bar. (the lower bound is always 0)
    /// </summary>
    /// <value>The maximum possible value that any stat in this group can be transformed into.  This is used by stats that *don't* have scaledStats entries below, but that still need to be displayed as a progress bar, in which case this is used as the upper bound for said progress bar. (the lower bound is always 0)</value>
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumValue")]
    public int? MaximumValue { get; set; }

    /// <summary>
    /// This apparently indicates the position of the stats in the UI? I've returned it in case anyone can use it, but it's not of any use to us on BNet. Something's being lost in translation with this value.
    /// </summary>
    /// <value>This apparently indicates the position of the stats in the UI? I've returned it in case anyone can use it, but it's not of any use to us on BNet. Something's being lost in translation with this value.</value>
    [DataMember(Name="uiPosition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uiPosition")]
    public int? UiPosition { get; set; }

    /// <summary>
    /// Any stat that requires scaling to be transformed from an \"Investment\" stat to a \"Display\" stat will have an entry in this list. For more information on what those types of stats mean and the transformation process, see DestinyStatDefinition.  In retrospect, I wouldn't mind if this was a dictionary keyed by the stat hash instead. But I'm going to leave it be because [[After Apple Picking]].
    /// </summary>
    /// <value>Any stat that requires scaling to be transformed from an \"Investment\" stat to a \"Display\" stat will have an entry in this list. For more information on what those types of stats mean and the transformation process, see DestinyStatDefinition.  In retrospect, I wouldn't mind if this was a dictionary keyed by the stat hash instead. But I'm going to leave it be because [[After Apple Picking]].</value>
    [DataMember(Name="scaledStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaledStats")]
    public List<DestinyDefinitionsDestinyStatDisplayDefinition> ScaledStats { get; set; }

    /// <summary>
    /// The game has the ability to override, based on the stat group, what the localized text is that is displayed for Stats being shown on the item.  Mercifully, no Stat Groups use this feature currently. If they start using them, we'll all need to start using them (and those of you who are more prudent than I am can go ahead and start pre-checking for this.)
    /// </summary>
    /// <value>The game has the ability to override, based on the stat group, what the localized text is that is displayed for Stats being shown on the item.  Mercifully, no Stat Groups use this feature currently. If they start using them, we'll all need to start using them (and those of you who are more prudent than I am can go ahead and start pre-checking for this.)</value>
    [DataMember(Name="overrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrides")]
    public Dictionary<string, DestinyDefinitionsDestinyStatOverrideDefinition> Overrides { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyStatGroupDefinition {\n");
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      sb.Append("  UiPosition: ").Append(UiPosition).Append("\n");
      sb.Append("  ScaledStats: ").Append(ScaledStats).Append("\n");
      sb.Append("  Overrides: ").Append(Overrides).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
