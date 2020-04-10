using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The response for GetDestinyProfile, with components for character and item-level data.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyProfileResponse {
    /// <summary>
    /// Recent, refundable purchases you have made from vendors. When will you use it? Couldn't say...  COMPONENT TYPE: VendorReceipts
    /// </summary>
    /// <value>Recent, refundable purchases you have made from vendors. When will you use it? Couldn't say...  COMPONENT TYPE: VendorReceipts</value>
    [DataMember(Name="vendorReceipts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorReceipts")]
    public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; }

    /// <summary>
    /// The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories
    /// </summary>
    /// <value>The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories</value>
    [DataMember(Name="profileInventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileInventory")]
    public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; set; }

    /// <summary>
    /// The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies
    /// </summary>
    /// <value>The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies</value>
    [DataMember(Name="profileCurrencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileCurrencies")]
    public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; set; }

    /// <summary>
    /// The basic information about the Destiny Profile (formerly \"Account\").  COMPONENT TYPE: Profiles
    /// </summary>
    /// <value>The basic information about the Destiny Profile (formerly \"Account\").  COMPONENT TYPE: Profiles</value>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile")]
    public SingleComponentResponseOfDestinyProfileComponent Profile { get; set; }

    /// <summary>
    /// Silver quantities for any platform on which this Profile plays destiny.   COMPONENT TYPE: PlatformSilver
    /// </summary>
    /// <value>Silver quantities for any platform on which this Profile plays destiny.   COMPONENT TYPE: PlatformSilver</value>
    [DataMember(Name="platformSilver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformSilver")]
    public SingleComponentResponseOfDestinyPlatformSilverComponent PlatformSilver { get; set; }

    /// <summary>
    /// Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks
    /// </summary>
    /// <value>Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks</value>
    [DataMember(Name="profileKiosks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileKiosks")]
    public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; set; }

    /// <summary>
    /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are profile-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets
    /// </summary>
    /// <value>When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are profile-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets</value>
    [DataMember(Name="profilePlugSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profilePlugSets")]
    public SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets { get; set; }

    /// <summary>
    /// When we have progression information - such as Checklists - that may apply profile-wide, it will be returned here rather than in the per-character progression data.  COMPONENT TYPE: ProfileProgression
    /// </summary>
    /// <value>When we have progression information - such as Checklists - that may apply profile-wide, it will be returned here rather than in the per-character progression data.  COMPONENT TYPE: ProfileProgression</value>
    [DataMember(Name="profileProgression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileProgression")]
    public SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression { get; set; }

    /// <summary>
    /// COMPONENT TYPE: PresentationNodes
    /// </summary>
    /// <value>COMPONENT TYPE: PresentationNodes</value>
    [DataMember(Name="profilePresentationNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profilePresentationNodes")]
    public SingleComponentResponseOfDestinyPresentationNodesComponent ProfilePresentationNodes { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Records
    /// </summary>
    /// <value>COMPONENT TYPE: Records</value>
    [DataMember(Name="profileRecords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileRecords")]
    public SingleComponentResponseOfDestinyProfileRecordsComponent ProfileRecords { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Collectibles
    /// </summary>
    /// <value>COMPONENT TYPE: Collectibles</value>
    [DataMember(Name="profileCollectibles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileCollectibles")]
    public SingleComponentResponseOfDestinyProfileCollectiblesComponent ProfileCollectibles { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Transitory
    /// </summary>
    /// <value>COMPONENT TYPE: Transitory</value>
    [DataMember(Name="profileTransitoryData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileTransitoryData")]
    public SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Metrics
    /// </summary>
    /// <value>COMPONENT TYPE: Metrics</value>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public SingleComponentResponseOfDestinyMetricsComponent Metrics { get; set; }

    /// <summary>
    /// Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters
    /// </summary>
    /// <value>Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters</value>
    [DataMember(Name="characters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characters")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; set; }

    /// <summary>
    /// The character-level non-equipped inventory items, keyed by the Character's Id.  COMPONENT TYPE: CharacterInventories
    /// </summary>
    /// <value>The character-level non-equipped inventory items, keyed by the Character's Id.  COMPONENT TYPE: CharacterInventories</value>
    [DataMember(Name="characterInventories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterInventories")]
    public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories { get; set; }

    /// <summary>
    /// Character-level progression data, keyed by the Character's Id.  COMPONENT TYPE: CharacterProgressions
    /// </summary>
    /// <value>Character-level progression data, keyed by the Character's Id.  COMPONENT TYPE: CharacterProgressions</value>
    [DataMember(Name="characterProgressions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterProgressions")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions { get; set; }

    /// <summary>
    /// Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character's Id.  COMPONENT TYPE: CharacterRenderData
    /// </summary>
    /// <value>Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character's Id.  COMPONENT TYPE: CharacterRenderData</value>
    [DataMember(Name="characterRenderData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterRenderData")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData { get; set; }

    /// <summary>
    /// Character activity data - the activities available to this character and its status, keyed by the Character's Id.  COMPONENT TYPE: CharacterActivities
    /// </summary>
    /// <value>Character activity data - the activities available to this character and its status, keyed by the Character's Id.  COMPONENT TYPE: CharacterActivities</value>
    [DataMember(Name="characterActivities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterActivities")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities { get; set; }

    /// <summary>
    /// The character's equipped items, keyed by the Character's Id.  COMPONENT TYPE: CharacterEquipment
    /// </summary>
    /// <value>The character's equipped items, keyed by the Character's Id.  COMPONENT TYPE: CharacterEquipment</value>
    [DataMember(Name="characterEquipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterEquipment")]
    public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; set; }

    /// <summary>
    /// Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character's available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks
    /// </summary>
    /// <value>Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character's available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks</value>
    [DataMember(Name="characterKiosks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterKiosks")]
    public DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks { get; set; }

    /// <summary>
    /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states, per character, that are character-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets
    /// </summary>
    /// <value>When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states, per character, that are character-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets</value>
    [DataMember(Name="characterPlugSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterPlugSets")]
    public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent CharacterPlugSets { get; set; }

    /// <summary>
    /// Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so many different ways that you end up being unable to provide an easy to use abstraction for the mess that's happening under the surface?  Let's talk about character-specific data that might be related to items without instances. These two statements are totally unrelated, I promise.  At some point during D2, it was decided that items - such as Bounties - could be given to characters and *not* have instance data, but that *could* display and even use relevant state information on your account and character.  Up to now, any item that had meaningful dependencies on character or account state had to be instanced, and thus \"itemComponents\" was all that you needed: it was keyed by item's instance IDs and provided the stateful information you needed inside.  Unfortunately, we don't live in such a magical world anymore. This is information held on a per-character basis about non-instanced items that the characters have in their inventory - or that reference character-specific state information even if it's in Account-level inventory - and the values related to that item's state in relation to the given character.  To give a concrete example, look at a Moments of Triumph bounty. They exist in a character's inventory, and show/care about a character's progression toward completing the bounty. But the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for the characters who have the bounty in their inventory.  I'm not crying, you're crying Okay we're both crying but it's going to be okay I promise Actually I shouldn't promise that, I don't know if it's going to be okay
    /// </summary>
    /// <value>Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so many different ways that you end up being unable to provide an easy to use abstraction for the mess that's happening under the surface?  Let's talk about character-specific data that might be related to items without instances. These two statements are totally unrelated, I promise.  At some point during D2, it was decided that items - such as Bounties - could be given to characters and *not* have instance data, but that *could* display and even use relevant state information on your account and character.  Up to now, any item that had meaningful dependencies on character or account state had to be instanced, and thus \"itemComponents\" was all that you needed: it was keyed by item's instance IDs and provided the stateful information you needed inside.  Unfortunately, we don't live in such a magical world anymore. This is information held on a per-character basis about non-instanced items that the characters have in their inventory - or that reference character-specific state information even if it's in Account-level inventory - and the values related to that item's state in relation to the given character.  To give a concrete example, look at a Moments of Triumph bounty. They exist in a character's inventory, and show/care about a character's progression toward completing the bounty. But the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for the characters who have the bounty in their inventory.  I'm not crying, you're crying Okay we're both crying but it's going to be okay I promise Actually I shouldn't promise that, I don't know if it's going to be okay</value>
    [DataMember(Name="characterUninstancedItemComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterUninstancedItemComponents")]
    public Dictionary<string, DestinyBaseItemComponentSetOfuint32> CharacterUninstancedItemComponents { get; set; }

    /// <summary>
    /// COMPONENT TYPE: PresentationNodes
    /// </summary>
    /// <value>COMPONENT TYPE: PresentationNodes</value>
    [DataMember(Name="characterPresentationNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterPresentationNodes")]
    public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent CharacterPresentationNodes { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Records
    /// </summary>
    /// <value>COMPONENT TYPE: Records</value>
    [DataMember(Name="characterRecords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterRecords")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent CharacterRecords { get; set; }

    /// <summary>
    /// COMPONENT TYPE: Collectibles
    /// </summary>
    /// <value>COMPONENT TYPE: Collectibles</value>
    [DataMember(Name="characterCollectibles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterCollectibles")]
    public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent CharacterCollectibles { get; set; }

    /// <summary>
    /// Information about instanced items across all returned characters, keyed by the item's instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    /// </summary>
    /// <value>Information about instanced items across all returned characters, keyed by the item's instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
    [DataMember(Name="itemComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemComponents")]
    public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

    /// <summary>
    /// A \"lookup\" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
    /// </summary>
    /// <value>A \"lookup\" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</value>
    [DataMember(Name="characterCurrencyLookups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterCurrencyLookups")]
    public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent CharacterCurrencyLookups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyProfileResponse {\n");
      sb.Append("  VendorReceipts: ").Append(VendorReceipts).Append("\n");
      sb.Append("  ProfileInventory: ").Append(ProfileInventory).Append("\n");
      sb.Append("  ProfileCurrencies: ").Append(ProfileCurrencies).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  PlatformSilver: ").Append(PlatformSilver).Append("\n");
      sb.Append("  ProfileKiosks: ").Append(ProfileKiosks).Append("\n");
      sb.Append("  ProfilePlugSets: ").Append(ProfilePlugSets).Append("\n");
      sb.Append("  ProfileProgression: ").Append(ProfileProgression).Append("\n");
      sb.Append("  ProfilePresentationNodes: ").Append(ProfilePresentationNodes).Append("\n");
      sb.Append("  ProfileRecords: ").Append(ProfileRecords).Append("\n");
      sb.Append("  ProfileCollectibles: ").Append(ProfileCollectibles).Append("\n");
      sb.Append("  ProfileTransitoryData: ").Append(ProfileTransitoryData).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  Characters: ").Append(Characters).Append("\n");
      sb.Append("  CharacterInventories: ").Append(CharacterInventories).Append("\n");
      sb.Append("  CharacterProgressions: ").Append(CharacterProgressions).Append("\n");
      sb.Append("  CharacterRenderData: ").Append(CharacterRenderData).Append("\n");
      sb.Append("  CharacterActivities: ").Append(CharacterActivities).Append("\n");
      sb.Append("  CharacterEquipment: ").Append(CharacterEquipment).Append("\n");
      sb.Append("  CharacterKiosks: ").Append(CharacterKiosks).Append("\n");
      sb.Append("  CharacterPlugSets: ").Append(CharacterPlugSets).Append("\n");
      sb.Append("  CharacterUninstancedItemComponents: ").Append(CharacterUninstancedItemComponents).Append("\n");
      sb.Append("  CharacterPresentationNodes: ").Append(CharacterPresentationNodes).Append("\n");
      sb.Append("  CharacterRecords: ").Append(CharacterRecords).Append("\n");
      sb.Append("  CharacterCollectibles: ").Append(CharacterCollectibles).Append("\n");
      sb.Append("  ItemComponents: ").Append(ItemComponents).Append("\n");
      sb.Append("  CharacterCurrencyLookups: ").Append(CharacterCurrencyLookups).Append("\n");
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
