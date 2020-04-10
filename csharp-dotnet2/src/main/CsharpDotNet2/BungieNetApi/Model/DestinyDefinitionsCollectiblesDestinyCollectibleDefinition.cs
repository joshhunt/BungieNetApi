using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsCollectiblesDestinyCollectibleDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Indicates whether the state of this Collectible is determined on a per-character or on an account-wide basis.
    /// </summary>
    /// <value>Indicates whether the state of this Collectible is determined on a per-character or on an account-wide basis.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// A human readable string for a hint about how to acquire the item.
    /// </summary>
    /// <value>A human readable string for a hint about how to acquire the item.</value>
    [DataMember(Name="sourceString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceString")]
    public string SourceString { get; set; }

    /// <summary>
    /// This is a hash identifier we are building on the BNet side in an attempt to let people group collectibles by similar sources.  I can't promise that it's going to be 100% accurate, but if the designers were consistent in assigning the same source strings to items with the same sources, it *ought to* be. No promises though.  This hash also doesn't relate to an actual definition, just to note: we've got nothing useful other than the source string for this data.
    /// </summary>
    /// <value>This is a hash identifier we are building on the BNet side in an attempt to let people group collectibles by similar sources.  I can't promise that it's going to be 100% accurate, but if the designers were consistent in assigning the same source strings to items with the same sources, it *ought to* be. No promises though.  This hash also doesn't relate to an actual definition, just to note: we've got nothing useful other than the source string for this data.</value>
    [DataMember(Name="sourceHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceHash")]
    public int? SourceHash { get; set; }

    /// <summary>
    /// Gets or Sets ItemHash
    /// </summary>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// Gets or Sets AcquisitionInfo
    /// </summary>
    [DataMember(Name="acquisitionInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquisitionInfo")]
    public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock AcquisitionInfo { get; set; }

    /// <summary>
    /// Gets or Sets StateInfo
    /// </summary>
    [DataMember(Name="stateInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateInfo")]
    public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock StateInfo { get; set; }

    /// <summary>
    /// Gets or Sets PresentationInfo
    /// </summary>
    [DataMember(Name="presentationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationInfo")]
    public DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo { get; set; }

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
      sb.Append("class DestinyDefinitionsCollectiblesDestinyCollectibleDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  SourceString: ").Append(SourceString).Append("\n");
      sb.Append("  SourceHash: ").Append(SourceHash).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  AcquisitionInfo: ").Append(AcquisitionInfo).Append("\n");
      sb.Append("  StateInfo: ").Append(StateInfo).Append("\n");
      sb.Append("  PresentationInfo: ").Append(PresentationInfo).Append("\n");
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
