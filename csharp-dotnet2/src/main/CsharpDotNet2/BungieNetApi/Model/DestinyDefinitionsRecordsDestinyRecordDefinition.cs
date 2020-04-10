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
  public class DestinyDefinitionsRecordsDestinyRecordDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Indicates whether this Record's state is determined on a per-character or on an account-wide basis.
    /// </summary>
    /// <value>Indicates whether this Record's state is determined on a per-character or on an account-wide basis.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// Gets or Sets PresentationInfo
    /// </summary>
    [DataMember(Name="presentationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationInfo")]
    public DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo { get; set; }

    /// <summary>
    /// Gets or Sets LoreHash
    /// </summary>
    [DataMember(Name="loreHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loreHash")]
    public int? LoreHash { get; set; }

    /// <summary>
    /// Gets or Sets ObjectiveHashes
    /// </summary>
    [DataMember(Name="objectiveHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHashes")]
    public List<int?> ObjectiveHashes { get; set; }

    /// <summary>
    /// Gets or Sets RecordValueStyle
    /// </summary>
    [DataMember(Name="recordValueStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recordValueStyle")]
    public int? RecordValueStyle { get; set; }

    /// <summary>
    /// Gets or Sets TitleInfo
    /// </summary>
    [DataMember(Name="titleInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titleInfo")]
    public DestinyDefinitionsRecordsDestinyRecordTitleBlock TitleInfo { get; set; }

    /// <summary>
    /// Gets or Sets CompletionInfo
    /// </summary>
    [DataMember(Name="completionInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionInfo")]
    public DestinyDefinitionsRecordsDestinyRecordCompletionBlock CompletionInfo { get; set; }

    /// <summary>
    /// Gets or Sets StateInfo
    /// </summary>
    [DataMember(Name="stateInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateInfo")]
    public DestinyDefinitionsRecordsSchemaRecordStateBlock StateInfo { get; set; }

    /// <summary>
    /// Gets or Sets Requirements
    /// </summary>
    [DataMember(Name="requirements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirements")]
    public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; set; }

    /// <summary>
    /// Gets or Sets ExpirationInfo
    /// </summary>
    [DataMember(Name="expirationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationInfo")]
    public DestinyDefinitionsRecordsDestinyRecordExpirationBlock ExpirationInfo { get; set; }

    /// <summary>
    /// Some records have multiple 'interval' objectives, and the record may be claimed at each completed interval
    /// </summary>
    /// <value>Some records have multiple 'interval' objectives, and the record may be claimed at each completed interval</value>
    [DataMember(Name="intervalInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalInfo")]
    public DestinyDefinitionsRecordsDestinyRecordIntervalBlock IntervalInfo { get; set; }

    /// <summary>
    /// If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \"hidden\" rewards. These will not be returned in this list.
    /// </summary>
    /// <value>If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \"hidden\" rewards. These will not be returned in this list.</value>
    [DataMember(Name="rewardItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardItems")]
    public List<DestinyDestinyItemQuantity> RewardItems { get; set; }

    /// <summary>
    /// Gets or Sets PresentationNodeType
    /// </summary>
    [DataMember(Name="presentationNodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationNodeType")]
    public int? PresentationNodeType { get; set; }

    /// <summary>
    /// Gets or Sets TraitIds
    /// </summary>
    [DataMember(Name="traitIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traitIds")]
    public List<string> TraitIds { get; set; }

    /// <summary>
    /// Gets or Sets TraitHashes
    /// </summary>
    [DataMember(Name="traitHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traitHashes")]
    public List<int?> TraitHashes { get; set; }

    /// <summary>
    /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
    /// </summary>
    /// <value>A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</value>
    [DataMember(Name="parentNodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentNodeHashes")]
    public List<int?> ParentNodeHashes { get; set; }

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
      sb.Append("class DestinyDefinitionsRecordsDestinyRecordDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  PresentationInfo: ").Append(PresentationInfo).Append("\n");
      sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
      sb.Append("  ObjectiveHashes: ").Append(ObjectiveHashes).Append("\n");
      sb.Append("  RecordValueStyle: ").Append(RecordValueStyle).Append("\n");
      sb.Append("  TitleInfo: ").Append(TitleInfo).Append("\n");
      sb.Append("  CompletionInfo: ").Append(CompletionInfo).Append("\n");
      sb.Append("  StateInfo: ").Append(StateInfo).Append("\n");
      sb.Append("  Requirements: ").Append(Requirements).Append("\n");
      sb.Append("  ExpirationInfo: ").Append(ExpirationInfo).Append("\n");
      sb.Append("  IntervalInfo: ").Append(IntervalInfo).Append("\n");
      sb.Append("  RewardItems: ").Append(RewardItems).Append("\n");
      sb.Append("  PresentationNodeType: ").Append(PresentationNodeType).Append("\n");
      sb.Append("  TraitIds: ").Append(TraitIds).Append("\n");
      sb.Append("  TraitHashes: ").Append(TraitHashes).Append("\n");
      sb.Append("  ParentNodeHashes: ").Append(ParentNodeHashes).Append("\n");
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
