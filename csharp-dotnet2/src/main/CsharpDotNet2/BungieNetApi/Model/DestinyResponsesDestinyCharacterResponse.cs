using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The response contract for GetDestinyCharacter, with components that can be returned for character and item-level data.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyCharacterResponse {
    /// <summary>
    /// The character-level non-equipped inventory items.  COMPONENT TYPE: CharacterInventories
    /// </summary>
    /// <value>The character-level non-equipped inventory items.  COMPONENT TYPE: CharacterInventories</value>
    [DataMember(Name="inventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory")]
    public SingleComponentResponseOfDestinyInventoryComponent Inventory { get; set; }

    /// <summary>
    /// Base information about the character in question.  COMPONENT TYPE: Characters
    /// </summary>
    /// <value>Base information about the character in question.  COMPONENT TYPE: Characters</value>
    [DataMember(Name="character", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character")]
    public SingleComponentResponseOfDestinyCharacterComponent Character { get; set; }

    /// <summary>
    /// Character progression data, including Milestones.  COMPONENT TYPE: CharacterProgressions
    /// </summary>
    /// <value>Character progression data, including Milestones.  COMPONENT TYPE: CharacterProgressions</value>
    [DataMember(Name="progressions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressions")]
    public SingleComponentResponseOfDestinyCharacterProgressionComponent Progressions { get; set; }

    /// <summary>
    /// Character rendering data - a minimal set of information about equipment and dyes used for rendering.  COMPONENT TYPE: CharacterRenderData
    /// </summary>
    /// <value>Character rendering data - a minimal set of information about equipment and dyes used for rendering.  COMPONENT TYPE: CharacterRenderData</value>
    [DataMember(Name="renderData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renderData")]
    public SingleComponentResponseOfDestinyCharacterRenderComponent RenderData { get; set; }

    /// <summary>
    /// Activity data - info about current activities available to the player.  COMPONENT TYPE: CharacterActivities
    /// </summary>
    /// <value>Activity data - info about current activities available to the player.  COMPONENT TYPE: CharacterActivities</value>
    [DataMember(Name="activities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activities")]
    public SingleComponentResponseOfDestinyCharacterActivitiesComponent Activities { get; set; }

    /// <summary>
    /// Equipped items on the character.  COMPONENT TYPE: CharacterEquipment
    /// </summary>
    /// <value>Equipped items on the character.  COMPONENT TYPE: CharacterEquipment</value>
    [DataMember(Name="equipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipment")]
    public SingleComponentResponseOfDestinyInventoryComponent Equipment { get; set; }

    /// <summary>
    /// Items available from Kiosks that are available to this specific character.   COMPONENT TYPE: Kiosks
    /// </summary>
    /// <value>Items available from Kiosks that are available to this specific character.   COMPONENT TYPE: Kiosks</value>
    [DataMember(Name="kiosks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kiosks")]
    public SingleComponentResponseOfDestinyKiosksComponent Kiosks { get; set; }

    /// <summary>
    /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are scoped to this character.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets
    /// </summary>
    /// <value>When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are scoped to this character.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets</value>
    [DataMember(Name="plugSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugSets")]
    public SingleComponentResponseOfDestinyPlugSetsComponent PlugSets { get; set; }

    /// <summary>
    /// COMPONENT TYPE: PresentationNodes
    /// </summary>
    /// <value>COMPONENT TYPE: PresentationNodes</value>
    [DataMember(Name="presentationNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presentationNodes")]
    public SingleComponentResponseOfDestinyPresentationNodesComponent PresentationNodes { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Records
    /// </summary>
    /// <value>COMPONENT TYPE: Records</value>
    [DataMember(Name="records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "records")]
    public SingleComponentResponseOfDestinyCharacterRecordsComponent Records { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Collectibles
    /// </summary>
    /// <value>COMPONENT TYPE: Collectibles</value>
    [DataMember(Name="collectibles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectibles")]
    public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }

    /// <summary>
    /// The set of components belonging to the player's instanced items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    /// </summary>
    /// <value>The set of components belonging to the player's instanced items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
    [DataMember(Name="itemComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemComponents")]
    public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

    /// <summary>
    /// The set of components belonging to the player's UNinstanced items. Because apparently now those too can have information relevant to the character's state.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    /// </summary>
    /// <value>The set of components belonging to the player's UNinstanced items. Because apparently now those too can have information relevant to the character's state.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
    [DataMember(Name="uninstancedItemComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uninstancedItemComponents")]
    public DestinyBaseItemComponentSetOfuint32 UninstancedItemComponents { get; set; }

    /// <summary>
    /// A \"lookup\" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
    /// </summary>
    /// <value>A \"lookup\" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</value>
    [DataMember(Name="currencyLookups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyLookups")]
    public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyCharacterResponse {\n");
      sb.Append("  Inventory: ").Append(Inventory).Append("\n");
      sb.Append("  Character: ").Append(Character).Append("\n");
      sb.Append("  Progressions: ").Append(Progressions).Append("\n");
      sb.Append("  RenderData: ").Append(RenderData).Append("\n");
      sb.Append("  Activities: ").Append(Activities).Append("\n");
      sb.Append("  Equipment: ").Append(Equipment).Append("\n");
      sb.Append("  Kiosks: ").Append(Kiosks).Append("\n");
      sb.Append("  PlugSets: ").Append(PlugSets).Append("\n");
      sb.Append("  PresentationNodes: ").Append(PresentationNodes).Append("\n");
      sb.Append("  Records: ").Append(Records).Append("\n");
      sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
      sb.Append("  ItemComponents: ").Append(ItemComponents).Append("\n");
      sb.Append("  UninstancedItemComponents: ").Append(UninstancedItemComponents).Append("\n");
      sb.Append("  CurrencyLookups: ").Append(CurrencyLookups).Append("\n");
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
