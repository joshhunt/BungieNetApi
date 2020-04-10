using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// All Sockets have a \&quot;Type\&quot;: a set of common properties that determine when the socket allows Plugs to be inserted, what Categories of Plugs can be inserted, and whether the socket is even visible at all given the current game/character/account state.  See DestinyInventoryItemDefinition for more information about Socketed items and Plugs.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsSocketsDestinySocketTypeDefinition {
    /// <summary>
    /// There are fields for this display data, but they appear to be unpopulated as of now. I am not sure where in the UI these would show if they even were populated, but I will continue to return this data in case it becomes useful.
    /// </summary>
    /// <value>There are fields for this display data, but they appear to be unpopulated as of now. I am not sure where in the UI these would show if they even were populated, but I will continue to return this data in case it becomes useful.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Defines what happens when a plug is inserted into sockets of this type.
    /// </summary>
    /// <value>Defines what happens when a plug is inserted into sockets of this type.</value>
    [DataMember(Name="insertAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insertAction")]
    public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition InsertAction { get; set; }

    /// <summary>
    /// A list of Plug \"Categories\" that are allowed to be plugged into sockets of this type.  These should be compared against a given plug item's DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item's category.  If the plug's category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted.
    /// </summary>
    /// <value>A list of Plug \"Categories\" that are allowed to be plugged into sockets of this type.  These should be compared against a given plug item's DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item's category.  If the plug's category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted.</value>
    [DataMember(Name="plugWhitelist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugWhitelist")]
    public List<DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition> PlugWhitelist { get; set; }

    /// <summary>
    /// Gets or Sets SocketCategoryHash
    /// </summary>
    [DataMember(Name="socketCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketCategoryHash")]
    public int? SocketCategoryHash { get; set; }

    /// <summary>
    /// Sometimes a socket isn't visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled.
    /// </summary>
    /// <value>Sometimes a socket isn't visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled.</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public int? Visibility { get; set; }

    /// <summary>
    /// Gets or Sets AlwaysRandomizeSockets
    /// </summary>
    [DataMember(Name="alwaysRandomizeSockets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alwaysRandomizeSockets")]
    public bool? AlwaysRandomizeSockets { get; set; }

    /// <summary>
    /// Gets or Sets IsPreviewEnabled
    /// </summary>
    [DataMember(Name="isPreviewEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPreviewEnabled")]
    public bool? IsPreviewEnabled { get; set; }

    /// <summary>
    /// Gets or Sets HideDuplicateReusablePlugs
    /// </summary>
    [DataMember(Name="hideDuplicateReusablePlugs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hideDuplicateReusablePlugs")]
    public bool? HideDuplicateReusablePlugs { get; set; }

    /// <summary>
    /// This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item's icon and nameplate.
    /// </summary>
    /// <value>This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item's icon and nameplate.</value>
    [DataMember(Name="overridesUiAppearance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overridesUiAppearance")]
    public bool? OverridesUiAppearance { get; set; }

    /// <summary>
    /// Gets or Sets AvoidDuplicatesOnInitialization
    /// </summary>
    [DataMember(Name="avoidDuplicatesOnInitialization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avoidDuplicatesOnInitialization")]
    public bool? AvoidDuplicatesOnInitialization { get; set; }

    /// <summary>
    /// Gets or Sets CurrencyScalars
    /// </summary>
    [DataMember(Name="currencyScalars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyScalars")]
    public List<DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry> CurrencyScalars { get; set; }

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
      sb.Append("class DestinyDefinitionsSocketsDestinySocketTypeDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  InsertAction: ").Append(InsertAction).Append("\n");
      sb.Append("  PlugWhitelist: ").Append(PlugWhitelist).Append("\n");
      sb.Append("  SocketCategoryHash: ").Append(SocketCategoryHash).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  AlwaysRandomizeSockets: ").Append(AlwaysRandomizeSockets).Append("\n");
      sb.Append("  IsPreviewEnabled: ").Append(IsPreviewEnabled).Append("\n");
      sb.Append("  HideDuplicateReusablePlugs: ").Append(HideDuplicateReusablePlugs).Append("\n");
      sb.Append("  OverridesUiAppearance: ").Append(OverridesUiAppearance).Append("\n");
      sb.Append("  AvoidDuplicatesOnInitialization: ").Append(AvoidDuplicatesOnInitialization).Append("\n");
      sb.Append("  CurrencyScalars: ").Append(CurrencyScalars).Append("\n");
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
