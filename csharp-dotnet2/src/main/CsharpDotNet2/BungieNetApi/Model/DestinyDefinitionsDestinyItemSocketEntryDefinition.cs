using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The definition information for a specific socket on an item. This will determine how the socket behaves in-game.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSocketEntryDefinition {
    /// <summary>
    /// All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.
    /// </summary>
    /// <value>All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.</value>
    [DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketTypeHash")]
    public int? SocketTypeHash { get; set; }

    /// <summary>
    /// If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.
    /// </summary>
    /// <value>If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.</value>
    [DataMember(Name="singleInitialItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singleInitialItemHash")]
    public int? SingleInitialItemHash { get; set; }

    /// <summary>
    /// This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.
    /// </summary>
    /// <value>This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.</value>
    [DataMember(Name="reusablePlugItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusablePlugItems")]
    public List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> ReusablePlugItems { get; set; }

    /// <summary>
    /// If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \"Collection Kiosks\" and other entities. See DestinyVendorDefinition for more information.
    /// </summary>
    /// <value>If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \"Collection Kiosks\" and other entities. See DestinyVendorDefinition for more information.</value>
    [DataMember(Name="preventInitializationOnVendorPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preventInitializationOnVendorPurchase")]
    public bool? PreventInitializationOnVendorPurchase { get; set; }

    /// <summary>
    /// If this is true, the perks provided by this socket shouldn't be shown in the item's tooltip. This might be useful if it's providing a hidden bonus, or if the bonus is less important than other benefits on the item.
    /// </summary>
    /// <value>If this is true, the perks provided by this socket shouldn't be shown in the item's tooltip. This might be useful if it's providing a hidden bonus, or if the bonus is less important than other benefits on the item.</value>
    [DataMember(Name="hidePerksInItemTooltip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidePerksInItemTooltip")]
    public bool? HidePerksInItemTooltip { get; set; }

    /// <summary>
    /// Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It's an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.
    /// </summary>
    /// <value>Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It's an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.</value>
    [DataMember(Name="plugSources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugSources")]
    public int? PlugSources { get; set; }

    /// <summary>
    /// If this socket's plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that's going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.
    /// </summary>
    /// <value>If this socket's plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that's going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.</value>
    [DataMember(Name="reusablePlugSetHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusablePlugSetHash")]
    public int? ReusablePlugSetHash { get; set; }

    /// <summary>
    /// This field replaces \"randomizedPlugItems\" as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs.
    /// </summary>
    /// <value>This field replaces \"randomizedPlugItems\" as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs.</value>
    [DataMember(Name="randomizedPlugSetHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "randomizedPlugSetHash")]
    public int? RandomizedPlugSetHash { get; set; }

    /// <summary>
    /// If true, then this socket is visible in the item's \"default\" state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you're looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
    /// </summary>
    /// <value>If true, then this socket is visible in the item's \"default\" state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you're looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.</value>
    [DataMember(Name="defaultVisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultVisible")]
    public bool? DefaultVisible { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSocketEntryDefinition {\n");
      sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
      sb.Append("  SingleInitialItemHash: ").Append(SingleInitialItemHash).Append("\n");
      sb.Append("  ReusablePlugItems: ").Append(ReusablePlugItems).Append("\n");
      sb.Append("  PreventInitializationOnVendorPurchase: ").Append(PreventInitializationOnVendorPurchase).Append("\n");
      sb.Append("  HidePerksInItemTooltip: ").Append(HidePerksInItemTooltip).Append("\n");
      sb.Append("  PlugSources: ").Append(PlugSources).Append("\n");
      sb.Append("  ReusablePlugSetHash: ").Append(ReusablePlugSetHash).Append("\n");
      sb.Append("  RandomizedPlugSetHash: ").Append(RandomizedPlugSetHash).Append("\n");
      sb.Append("  DefaultVisible: ").Append(DefaultVisible).Append("\n");
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
