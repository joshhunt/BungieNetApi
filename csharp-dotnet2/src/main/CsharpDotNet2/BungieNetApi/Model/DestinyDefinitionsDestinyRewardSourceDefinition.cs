using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a heuristically-determined \&quot;item source\&quot; according to Bungie.net. These item sources are non-canonical: we apply a combination of special configuration and often-fragile heuristics to attempt to discern whether an item should be part of a given \&quot;source,\&quot; but we have known cases of false positives and negatives due to our imperfect heuristics.  Still, they provide a decent approximation for people trying to figure out how an item can be obtained. DestinyInventoryItemDefinition refers to sources in the sourceDatas.sourceHashes property for all sources we determined the item could spawn from.  An example in Destiny 1 of a Source would be \&quot;Nightfall\&quot;. If an item has the \&quot;Nightfall\&quot; source associated with it, it&#39;s extremely likely that you can earn that item while playing Nightfall, either during play or as an after-completion reward.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyRewardSourceDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Sources are grouped into categories: common ways that items are provided. I hope to see this expand in Destiny 2 once we have time to generate accurate reward source data.
    /// </summary>
    /// <value>Sources are grouped into categories: common ways that items are provided. I hope to see this expand in Destiny 2 once we have time to generate accurate reward source data.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public int? Category { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyRewardSourceDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
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
