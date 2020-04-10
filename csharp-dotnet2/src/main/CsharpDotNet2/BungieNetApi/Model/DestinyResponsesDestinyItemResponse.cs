using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn&#39;t have an \&quot;itemInstanceId\&quot;: for those, get your information from the DestinyInventoryDefinition.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyItemResponse {
    /// <summary>
    /// If the item is on a character, this will return the ID of the character that is holding the item.
    /// </summary>
    /// <value>If the item is on a character, this will return the ID of the character that is holding the item.</value>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }

    /// <summary>
    /// Common data for the item relevant to its non-instanced properties.  COMPONENT TYPE: ItemCommonData
    /// </summary>
    /// <value>Common data for the item relevant to its non-instanced properties.  COMPONENT TYPE: ItemCommonData</value>
    [DataMember(Name="item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item")]
    public SingleComponentResponseOfDestinyItemComponent Item { get; set; }

    /// <summary>
    /// Basic instance data for the item.  COMPONENT TYPE: ItemInstances
    /// </summary>
    /// <value>Basic instance data for the item.  COMPONENT TYPE: ItemInstances</value>
    [DataMember(Name="instance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instance")]
    public SingleComponentResponseOfDestinyItemInstanceComponent Instance { get; set; }

    /// <summary>
    /// Information specifically about the item's objectives.  COMPONENT TYPE: ItemObjectives
    /// </summary>
    /// <value>Information specifically about the item's objectives.  COMPONENT TYPE: ItemObjectives</value>
    [DataMember(Name="objectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectives")]
    public SingleComponentResponseOfDestinyItemObjectivesComponent Objectives { get; set; }

    /// <summary>
    /// Information specifically about the perks currently active on the item.  COMPONENT TYPE: ItemPerks
    /// </summary>
    /// <value>Information specifically about the perks currently active on the item.  COMPONENT TYPE: ItemPerks</value>
    [DataMember(Name="perks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perks")]
    public SingleComponentResponseOfDestinyItemPerksComponent Perks { get; set; }

    /// <summary>
    /// Information about how to render the item in 3D.  COMPONENT TYPE: ItemRenderData
    /// </summary>
    /// <value>Information about how to render the item in 3D.  COMPONENT TYPE: ItemRenderData</value>
    [DataMember(Name="renderData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renderData")]
    public SingleComponentResponseOfDestinyItemRenderComponent RenderData { get; set; }

    /// <summary>
    /// Information about the computed stats of the item: power, defense, etc...  COMPONENT TYPE: ItemStats
    /// </summary>
    /// <value>Information about the computed stats of the item: power, defense, etc...  COMPONENT TYPE: ItemStats</value>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public SingleComponentResponseOfDestinyItemStatsComponent Stats { get; set; }

    /// <summary>
    /// Information about the talent grid attached to the item. Talent nodes can provide a variety of benefits and abilities, and in Destiny 2 are used almost exclusively for the character's \"Builds\".  COMPONENT TYPE: ItemTalentGrids
    /// </summary>
    /// <value>Information about the talent grid attached to the item. Talent nodes can provide a variety of benefits and abilities, and in Destiny 2 are used almost exclusively for the character's \"Builds\".  COMPONENT TYPE: ItemTalentGrids</value>
    [DataMember(Name="talentGrid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "talentGrid")]
    public SingleComponentResponseOfDestinyItemTalentGridComponent TalentGrid { get; set; }

    /// <summary>
    /// Information about the sockets of the item: which are currently active, what potential sockets you could have and the stats/abilities/perks you can gain from them.  COMPONENT TYPE: ItemSockets
    /// </summary>
    /// <value>Information about the sockets of the item: which are currently active, what potential sockets you could have and the stats/abilities/perks you can gain from them.  COMPONENT TYPE: ItemSockets</value>
    [DataMember(Name="sockets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sockets")]
    public SingleComponentResponseOfDestinyItemSocketsComponent Sockets { get; set; }

    /// <summary>
    /// Information about the Reusable Plugs for sockets on an item. These are plugs that you can insert into the given socket regardless of if you actually own an instance of that plug: they are logic-driven plugs rather than inventory-driven.   These may need to be combined with Plug Set component data to get a full picture of available plugs on a given socket.   COMPONENT TYPE: ItemReusablePlugs
    /// </summary>
    /// <value>Information about the Reusable Plugs for sockets on an item. These are plugs that you can insert into the given socket regardless of if you actually own an instance of that plug: they are logic-driven plugs rather than inventory-driven.   These may need to be combined with Plug Set component data to get a full picture of available plugs on a given socket.   COMPONENT TYPE: ItemReusablePlugs</value>
    [DataMember(Name="reusablePlugs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusablePlugs")]
    public SingleComponentResponseOfDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

    /// <summary>
    /// Information about objectives on Plugs for a given item. See the component's documentation for more info.  COMPONENT TYPE: ItemPlugObjectives
    /// </summary>
    /// <value>Information about objectives on Plugs for a given item. See the component's documentation for more info.  COMPONENT TYPE: ItemPlugObjectives</value>
    [DataMember(Name="plugObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugObjectives")]
    public SingleComponentResponseOfDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyItemResponse {\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  Item: ").Append(Item).Append("\n");
      sb.Append("  Instance: ").Append(Instance).Append("\n");
      sb.Append("  Objectives: ").Append(Objectives).Append("\n");
      sb.Append("  Perks: ").Append(Perks).Append("\n");
      sb.Append("  RenderData: ").Append(RenderData).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  TalentGrid: ").Append(TalentGrid).Append("\n");
      sb.Append("  Sockets: ").Append(Sockets).Append("\n");
      sb.Append("  ReusablePlugs: ").Append(ReusablePlugs).Append("\n");
      sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
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
