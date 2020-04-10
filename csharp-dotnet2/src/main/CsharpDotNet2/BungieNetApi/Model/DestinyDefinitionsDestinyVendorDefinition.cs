using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// These are the definitions for Vendors.  In Destiny, a Vendor can be a lot of things - some things that you wouldn&#39;t expect, and some things that you don&#39;t even see directly in the game. Vendors are the Dolly Levi of the Destiny universe.  - Traditional Vendors as you see in game: people who you come up to and who give you quests, rewards, or who you can buy things from.  - Kiosks/Collections, which are really just Vendors that don&#39;t charge currency (or charge some pittance of a currency) and whose gating for purchases revolves more around your character&#39;s state.  - Previews for rewards or the contents of sacks. These are implemented as Vendors, where you can&#39;t actually purchase from them but the items that they have for sale and the categories of sale items reflect the rewards or contents of the sack. This is so that the game could reuse the existing Vendor display UI for rewards and save a bunch of wheel reinvention.  - Item Transfer capabilities, like the Vault and Postmaster. Vendors can have \&quot;acceptedItem\&quot; buckets that determine the source and destination buckets for transfers. When you interact with such a vendor, these buckets are what gets shown in the UI instead of any items that the Vendor would have for sale. Yep, the Vault is a vendor.  It is pretty much guaranteed that they&#39;ll be used for even more features in the future. They have come to be seen more as generic categorized containers for items than \&quot;vendors\&quot; in a traditional sense, for better or worse.  Where possible and time allows, we&#39;ll attempt to split those out into their own more digestible derived \&quot;Definitions\&quot;: but often time does not allow that, as you can see from the above ways that vendors are used which we never split off from Vendor Definitions externally.  Since Vendors are so many things to so many parts of the game, the definition is understandably complex. You will want to combine this data with live Vendor information from the API when it is available.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// If the vendor has a custom localized string describing the \"buy\" action, that is returned here.
    /// </summary>
    /// <value>If the vendor has a custom localized string describing the \"buy\" action, that is returned here.</value>
    [DataMember(Name="buyString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyString")]
    public string BuyString { get; set; }

    /// <summary>
    /// Ditto for selling. Not that you can sell items to a vendor anymore. Will it come back? Who knows. The string's still there.
    /// </summary>
    /// <value>Ditto for selling. Not that you can sell items to a vendor anymore. Will it come back? Who knows. The string's still there.</value>
    [DataMember(Name="sellString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sellString")]
    public string SellString { get; set; }

    /// <summary>
    /// If the vendor has an item that should be displayed as the \"featured\" item, this is the hash identifier for that DestinyVendorItemDefinition.  Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.
    /// </summary>
    /// <value>If the vendor has an item that should be displayed as the \"featured\" item, this is the hash identifier for that DestinyVendorItemDefinition.  Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.</value>
    [DataMember(Name="displayItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayItemHash")]
    public int? DisplayItemHash { get; set; }

    /// <summary>
    /// If this is true, you aren't allowed to buy whatever the vendor is selling.
    /// </summary>
    /// <value>If this is true, you aren't allowed to buy whatever the vendor is selling.</value>
    [DataMember(Name="inhibitBuying", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inhibitBuying")]
    public bool? InhibitBuying { get; set; }

    /// <summary>
    /// If this is true, you're not allowed to sell whatever the vendor is buying.
    /// </summary>
    /// <value>If this is true, you're not allowed to sell whatever the vendor is buying.</value>
    [DataMember(Name="inhibitSelling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inhibitSelling")]
    public bool? InhibitSelling { get; set; }

    /// <summary>
    /// If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.  The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction's Progression status (aka \"Reputation\").
    /// </summary>
    /// <value>If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.  The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction's Progression status (aka \"Reputation\").</value>
    [DataMember(Name="factionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factionHash")]
    public int? FactionHash { get; set; }

    /// <summary>
    /// A number used for calculating the frequency of a vendor's inventory resetting/refreshing.  Don't worry about calculating this - we do it on the server side and send you the next refresh date with the live data.
    /// </summary>
    /// <value>A number used for calculating the frequency of a vendor's inventory resetting/refreshing.  Don't worry about calculating this - we do it on the server side and send you the next refresh date with the live data.</value>
    [DataMember(Name="resetIntervalMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetIntervalMinutes")]
    public int? ResetIntervalMinutes { get; set; }

    /// <summary>
    /// Again, used for reset/refreshing of inventory. Don't worry too much about it. Unless you want to.
    /// </summary>
    /// <value>Again, used for reset/refreshing of inventory. Don't worry too much about it. Unless you want to.</value>
    [DataMember(Name="resetOffsetMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetOffsetMinutes")]
    public int? ResetOffsetMinutes { get; set; }

    /// <summary>
    /// If an item can't be purchased from the vendor, there may be many \"custom\"/game state specific reasons why not.  This is a list of localized strings with messages for those custom failures. The live BNet data will return a failureIndexes property for items that can't be purchased: using those values to index into this array, you can show the user the appropriate failure message for the item that can't be bought.
    /// </summary>
    /// <value>If an item can't be purchased from the vendor, there may be many \"custom\"/game state specific reasons why not.  This is a list of localized strings with messages for those custom failures. The live BNet data will return a failureIndexes property for items that can't be purchased: using those values to index into this array, you can show the user the appropriate failure message for the item that can't be bought.</value>
    [DataMember(Name="failureStrings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureStrings")]
    public List<string> FailureStrings { get; set; }

    /// <summary>
    /// If we were able to predict the dates when this Vendor will be visible/available, this will be the list of those date ranges. Sadly, we're not able to predict this very frequently, so this will often be useless data.
    /// </summary>
    /// <value>If we were able to predict the dates when this Vendor will be visible/available, this will be the list of those date ranges. Sadly, we're not able to predict this very frequently, so this will often be useless data.</value>
    [DataMember(Name="unlockRanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unlockRanges")]
    public List<DatesDateRange> UnlockRanges { get; set; }

    /// <summary>
    /// The internal identifier for the Vendor. A holdover from the old days of Vendors, but we don't have time to refactor it away.
    /// </summary>
    /// <value>The internal identifier for the Vendor. A holdover from the old days of Vendors, but we don't have time to refactor it away.</value>
    [DataMember(Name="vendorIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorIdentifier")]
    public string VendorIdentifier { get; set; }

    /// <summary>
    /// A portrait of the Vendor's smiling mug. Or frothing tentacles.
    /// </summary>
    /// <value>A portrait of the Vendor's smiling mug. Or frothing tentacles.</value>
    [DataMember(Name="vendorPortrait", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorPortrait")]
    public string VendorPortrait { get; set; }

    /// <summary>
    /// If the vendor has a custom banner image, that can be found here.
    /// </summary>
    /// <value>If the vendor has a custom banner image, that can be found here.</value>
    [DataMember(Name="vendorBanner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorBanner")]
    public string VendorBanner { get; set; }

    /// <summary>
    /// If a vendor is not enabled, we won't even save the vendor's definition, and we won't return any items or info about them. It's as if they don't exist.
    /// </summary>
    /// <value>If a vendor is not enabled, we won't even save the vendor's definition, and we won't return any items or info about them. It's as if they don't exist.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// If a vendor is not visible, we still have and will give vendor definition info, but we won't use them for things like Advisors or UI.
    /// </summary>
    /// <value>If a vendor is not visible, we still have and will give vendor definition info, but we won't use them for things like Advisors or UI.</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// The identifier of the VendorCategoryDefinition for this vendor's subcategory.
    /// </summary>
    /// <value>The identifier of the VendorCategoryDefinition for this vendor's subcategory.</value>
    [DataMember(Name="vendorSubcategoryIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorSubcategoryIdentifier")]
    public string VendorSubcategoryIdentifier { get; set; }

    /// <summary>
    /// If TRUE, consolidate categories that only differ by trivial properties (such as having minor differences in name)
    /// </summary>
    /// <value>If TRUE, consolidate categories that only differ by trivial properties (such as having minor differences in name)</value>
    [DataMember(Name="consolidateCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consolidateCategories")]
    public bool? ConsolidateCategories { get; set; }

    /// <summary>
    /// Describes \"actions\" that can be performed on a vendor. Currently, none of these exist. But theoretically a Vendor could let you interact with it by performing actions. We'll see what these end up looking like if they ever get used.
    /// </summary>
    /// <value>Describes \"actions\" that can be performed on a vendor. Currently, none of these exist. But theoretically a Vendor could let you interact with it by performing actions. We'll see what these end up looking like if they ever get used.</value>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<DestinyDefinitionsDestinyVendorActionDefinition> Actions { get; set; }

    /// <summary>
    /// These are the headers for sections of items that the vendor is selling. When you see items organized by category in the header, it is these categories that it is showing.  Well, technically not *exactly* these. On BNet, it doesn't make sense to have categories be \"paged\" as we do in Destiny, so we run some heuristics to attempt to aggregate pages of categories together.   These are the categories post-concatenation, if the vendor had concatenation applied. If you want the pre-aggregated category data, use originalCategories.
    /// </summary>
    /// <value>These are the headers for sections of items that the vendor is selling. When you see items organized by category in the header, it is these categories that it is showing.  Well, technically not *exactly* these. On BNet, it doesn't make sense to have categories be \"paged\" as we do in Destiny, so we run some heuristics to attempt to aggregate pages of categories together.   These are the categories post-concatenation, if the vendor had concatenation applied. If you want the pre-aggregated category data, use originalCategories.</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> Categories { get; set; }

    /// <summary>
    /// See the categories property for a description of categories and why originalCategories exists.
    /// </summary>
    /// <value>See the categories property for a description of categories and why originalCategories exists.</value>
    [DataMember(Name="originalCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalCategories")]
    public List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> OriginalCategories { get; set; }

    /// <summary>
    /// Display Categories are different from \"categories\" in that these are specifically for visual grouping and display of categories in Vendor UI.   The \"categories\" structure is for validation of the contained items, and can be categorized entirely separately from \"Display Categories\", there need be and often will be no meaningful relationship between the two.
    /// </summary>
    /// <value>Display Categories are different from \"categories\" in that these are specifically for visual grouping and display of categories in Vendor UI.   The \"categories\" structure is for validation of the contained items, and can be categorized entirely separately from \"Display Categories\", there need be and often will be no meaningful relationship between the two.</value>
    [DataMember(Name="displayCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayCategories")]
    public List<DestinyDefinitionsDestinyDisplayCategoryDefinition> DisplayCategories { get; set; }

    /// <summary>
    /// In addition to selling items, vendors can have \"interactions\": UI where you \"talk\" with the vendor and they offer you a reward, some item, or merely acknowledge via dialog that you did something cool.
    /// </summary>
    /// <value>In addition to selling items, vendors can have \"interactions\": UI where you \"talk\" with the vendor and they offer you a reward, some item, or merely acknowledge via dialog that you did something cool.</value>
    [DataMember(Name="interactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interactions")]
    public List<DestinyDefinitionsDestinyVendorInteractionDefinition> Interactions { get; set; }

    /// <summary>
    /// If the vendor shows you items from your own inventory - such as the Vault vendor does - this data describes the UI around showing those inventory buckets and which ones get shown.
    /// </summary>
    /// <value>If the vendor shows you items from your own inventory - such as the Vault vendor does - this data describes the UI around showing those inventory buckets and which ones get shown.</value>
    [DataMember(Name="inventoryFlyouts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventoryFlyouts")]
    public List<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition> InventoryFlyouts { get; set; }

    /// <summary>
    /// If the vendor sells items (or merely has a list of items to show like the \"Sack\" vendors do), this is the list of those items that the vendor can sell. From this list, only a subset will be available from the vendor at any given time, selected randomly and reset on the vendor's refresh interval.  Note that a vendor can sell the same item multiple ways: for instance, nothing stops a vendor from selling you some specific weapon but using two different currencies, or the same weapon at multiple \"item levels\".
    /// </summary>
    /// <value>If the vendor sells items (or merely has a list of items to show like the \"Sack\" vendors do), this is the list of those items that the vendor can sell. From this list, only a subset will be available from the vendor at any given time, selected randomly and reset on the vendor's refresh interval.  Note that a vendor can sell the same item multiple ways: for instance, nothing stops a vendor from selling you some specific weapon but using two different currencies, or the same weapon at multiple \"item levels\".</value>
    [DataMember(Name="itemList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemList")]
    public List<DestinyDefinitionsDestinyVendorItemDefinition> ItemList { get; set; }

    /// <summary>
    /// BNet doesn't use this data yet, but it appears to be an optional list of flavor text about services that the Vendor can provide.
    /// </summary>
    /// <value>BNet doesn't use this data yet, but it appears to be an optional list of flavor text about services that the Vendor can provide.</value>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public List<DestinyDefinitionsDestinyVendorServiceDefinition> Services { get; set; }

    /// <summary>
    /// If the Vendor is actually a vehicle for the transferring of items (like the Vault and Postmaster vendors), this defines the list of source->destination buckets for transferring.
    /// </summary>
    /// <value>If the Vendor is actually a vehicle for the transferring of items (like the Vault and Postmaster vendors), this defines the list of source->destination buckets for transferring.</value>
    [DataMember(Name="acceptedItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acceptedItems")]
    public List<DestinyDefinitionsDestinyVendorAcceptedItemDefinition> AcceptedItems { get; set; }

    /// <summary>
    /// As many of you know, Vendor data has historically been pretty brutal on the BNet servers. In an effort to reduce this workload, only Vendors with this flag set will be returned on Vendor requests. This allows us to filter out Vendors that don't dynamic data that's particularly useful: things like \"Preview/Sack\" vendors, for example, that you can usually suss out the details for using just the definitions themselves.
    /// </summary>
    /// <value>As many of you know, Vendor data has historically been pretty brutal on the BNet servers. In an effort to reduce this workload, only Vendors with this flag set will be returned on Vendor requests. This allows us to filter out Vendors that don't dynamic data that's particularly useful: things like \"Preview/Sack\" vendors, for example, that you can usually suss out the details for using just the definitions themselves.</value>
    [DataMember(Name="returnWithVendorRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnWithVendorRequest")]
    public bool? ReturnWithVendorRequest { get; set; }

    /// <summary>
    /// A vendor can be at different places in the world depending on the game/character/account state. This is the list of possible locations for the vendor, along with conditions we use to determine which one is currently active.
    /// </summary>
    /// <value>A vendor can be at different places in the world depending on the game/character/account state. This is the list of possible locations for the vendor, along with conditions we use to determine which one is currently active.</value>
    [DataMember(Name="locations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locations")]
    public List<DestinyDefinitionsVendorsDestinyVendorLocationDefinition> Locations { get; set; }

    /// <summary>
    /// A vendor can be a part of 0 or 1 \"groups\" at a time: a group being a collection of Vendors related by either location or function/purpose. It's used for our our Companion Vendor UI. Only one of these can be active for a Vendor at a time.
    /// </summary>
    /// <value>A vendor can be a part of 0 or 1 \"groups\" at a time: a group being a collection of Vendors related by either location or function/purpose. It's used for our our Companion Vendor UI. Only one of these can be active for a Vendor at a time.</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<DestinyDefinitionsDestinyVendorGroupReference> Groups { get; set; }

    /// <summary>
    /// Some items don't make sense to return in the API, for example because they represent an action to be performed rather than an item being sold. I'd rather we not do this, but at least in the short term this is a workable workaround.
    /// </summary>
    /// <value>Some items don't make sense to return in the API, for example because they represent an action to be performed rather than an item being sold. I'd rather we not do this, but at least in the short term this is a workable workaround.</value>
    [DataMember(Name="ignoreSaleItemHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreSaleItemHashes")]
    public List<int?> IgnoreSaleItemHashes { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyVendorDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  BuyString: ").Append(BuyString).Append("\n");
      sb.Append("  SellString: ").Append(SellString).Append("\n");
      sb.Append("  DisplayItemHash: ").Append(DisplayItemHash).Append("\n");
      sb.Append("  InhibitBuying: ").Append(InhibitBuying).Append("\n");
      sb.Append("  InhibitSelling: ").Append(InhibitSelling).Append("\n");
      sb.Append("  FactionHash: ").Append(FactionHash).Append("\n");
      sb.Append("  ResetIntervalMinutes: ").Append(ResetIntervalMinutes).Append("\n");
      sb.Append("  ResetOffsetMinutes: ").Append(ResetOffsetMinutes).Append("\n");
      sb.Append("  FailureStrings: ").Append(FailureStrings).Append("\n");
      sb.Append("  UnlockRanges: ").Append(UnlockRanges).Append("\n");
      sb.Append("  VendorIdentifier: ").Append(VendorIdentifier).Append("\n");
      sb.Append("  VendorPortrait: ").Append(VendorPortrait).Append("\n");
      sb.Append("  VendorBanner: ").Append(VendorBanner).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  VendorSubcategoryIdentifier: ").Append(VendorSubcategoryIdentifier).Append("\n");
      sb.Append("  ConsolidateCategories: ").Append(ConsolidateCategories).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  OriginalCategories: ").Append(OriginalCategories).Append("\n");
      sb.Append("  DisplayCategories: ").Append(DisplayCategories).Append("\n");
      sb.Append("  Interactions: ").Append(Interactions).Append("\n");
      sb.Append("  InventoryFlyouts: ").Append(InventoryFlyouts).Append("\n");
      sb.Append("  ItemList: ").Append(ItemList).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
      sb.Append("  AcceptedItems: ").Append(AcceptedItems).Append("\n");
      sb.Append("  ReturnWithVendorRequest: ").Append(ReturnWithVendorRequest).Append("\n");
      sb.Append("  Locations: ").Append(Locations).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  IgnoreSaleItemHashes: ").Append(IgnoreSaleItemHashes).Append("\n");
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
