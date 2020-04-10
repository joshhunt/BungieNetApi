using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These are the definitions for Vendors.  In Destiny, a Vendor can be a lot of things - some things that you wouldn&#39;t expect, and some things that you don&#39;t even see directly in the game. Vendors are the Dolly Levi of the Destiny universe.  - Traditional Vendors as you see in game: people who you come up to and who give you quests, rewards, or who you can buy things from.  - Kiosks/Collections, which are really just Vendors that don&#39;t charge currency (or charge some pittance of a currency) and whose gating for purchases revolves more around your character&#39;s state.  - Previews for rewards or the contents of sacks. These are implemented as Vendors, where you can&#39;t actually purchase from them but the items that they have for sale and the categories of sale items reflect the rewards or contents of the sack. This is so that the game could reuse the existing Vendor display UI for rewards and save a bunch of wheel reinvention.  - Item Transfer capabilities, like the Vault and Postmaster. Vendors can have \&quot;acceptedItem\&quot; buckets that determine the source and destination buckets for transfers. When you interact with such a vendor, these buckets are what gets shown in the UI instead of any items that the Vendor would have for sale. Yep, the Vault is a vendor.  It is pretty much guaranteed that they&#39;ll be used for even more features in the future. They have come to be seen more as generic categorized containers for items than \&quot;vendors\&quot; in a traditional sense, for better or worse.  Where possible and time allows, we&#39;ll attempt to split those out into their own more digestible derived \&quot;Definitions\&quot;: but often time does not allow that, as you can see from the above ways that vendors are used which we never split off from Vendor Definitions externally.  Since Vendors are so many things to so many parts of the game, the definition is understandably complex. You will want to combine this data with live Vendor information from the API when it is available.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorDefinition:  IEquatable<DestinyDefinitionsDestinyVendorDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If the vendor has a custom localized string describing the \&quot;buy\&quot; action, that is returned here.
        /// </summary>
        public string BuyString { get; private set; }

        /// <summary>
        /// Ditto for selling. Not that you can sell items to a vendor anymore. Will it come back? Who knows. The string&#39;s still there.
        /// </summary>
        public string SellString { get; private set; }

        /// <summary>
        /// If the vendor has an item that should be displayed as the \&quot;featured\&quot; item, this is the hash identifier for that DestinyVendorItemDefinition.  Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.
        /// </summary>
        public int? DisplayItemHash { get; private set; }

        /// <summary>
        /// If this is true, you aren&#39;t allowed to buy whatever the vendor is selling.
        /// </summary>
        public bool? InhibitBuying { get; private set; }

        /// <summary>
        /// If this is true, you&#39;re not allowed to sell whatever the vendor is buying.
        /// </summary>
        public bool? InhibitSelling { get; private set; }

        /// <summary>
        /// If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.  The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction&#39;s Progression status (aka \&quot;Reputation\&quot;).
        /// </summary>
        public int? FactionHash { get; private set; }

        /// <summary>
        /// A number used for calculating the frequency of a vendor&#39;s inventory resetting/refreshing.  Don&#39;t worry about calculating this - we do it on the server side and send you the next refresh date with the live data.
        /// </summary>
        public int? ResetIntervalMinutes { get; private set; }

        /// <summary>
        /// Again, used for reset/refreshing of inventory. Don&#39;t worry too much about it. Unless you want to.
        /// </summary>
        public int? ResetOffsetMinutes { get; private set; }

        /// <summary>
        /// If an item can&#39;t be purchased from the vendor, there may be many \&quot;custom\&quot;/game state specific reasons why not.  This is a list of localized strings with messages for those custom failures. The live BNet data will return a failureIndexes property for items that can&#39;t be purchased: using those values to index into this array, you can show the user the appropriate failure message for the item that can&#39;t be bought.
        /// </summary>
        public List<string> FailureStrings { get; private set; }

        /// <summary>
        /// If we were able to predict the dates when this Vendor will be visible/available, this will be the list of those date ranges. Sadly, we&#39;re not able to predict this very frequently, so this will often be useless data.
        /// </summary>
        public List<DatesDateRange> UnlockRanges { get; private set; }

        /// <summary>
        /// The internal identifier for the Vendor. A holdover from the old days of Vendors, but we don&#39;t have time to refactor it away.
        /// </summary>
        public string VendorIdentifier { get; private set; }

        /// <summary>
        /// A portrait of the Vendor&#39;s smiling mug. Or frothing tentacles.
        /// </summary>
        public string VendorPortrait { get; private set; }

        /// <summary>
        /// If the vendor has a custom banner image, that can be found here.
        /// </summary>
        public string VendorBanner { get; private set; }

        /// <summary>
        /// If a vendor is not enabled, we won&#39;t even save the vendor&#39;s definition, and we won&#39;t return any items or info about them. It&#39;s as if they don&#39;t exist.
        /// </summary>
        public bool? Enabled { get; private set; }

        /// <summary>
        /// If a vendor is not visible, we still have and will give vendor definition info, but we won&#39;t use them for things like Advisors or UI.
        /// </summary>
        public bool? Visible { get; private set; }

        /// <summary>
        /// The identifier of the VendorCategoryDefinition for this vendor&#39;s subcategory.
        /// </summary>
        public string VendorSubcategoryIdentifier { get; private set; }

        /// <summary>
        /// If TRUE, consolidate categories that only differ by trivial properties (such as having minor differences in name)
        /// </summary>
        public bool? ConsolidateCategories { get; private set; }

        /// <summary>
        /// Describes \&quot;actions\&quot; that can be performed on a vendor. Currently, none of these exist. But theoretically a Vendor could let you interact with it by performing actions. We&#39;ll see what these end up looking like if they ever get used.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorActionDefinition> Actions { get; private set; }

        /// <summary>
        /// These are the headers for sections of items that the vendor is selling. When you see items organized by category in the header, it is these categories that it is showing.  Well, technically not *exactly* these. On BNet, it doesn&#39;t make sense to have categories be \&quot;paged\&quot; as we do in Destiny, so we run some heuristics to attempt to aggregate pages of categories together.   These are the categories post-concatenation, if the vendor had concatenation applied. If you want the pre-aggregated category data, use originalCategories.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> Categories { get; private set; }

        /// <summary>
        /// See the categories property for a description of categories and why originalCategories exists.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> OriginalCategories { get; private set; }

        /// <summary>
        /// Display Categories are different from \&quot;categories\&quot; in that these are specifically for visual grouping and display of categories in Vendor UI.   The \&quot;categories\&quot; structure is for validation of the contained items, and can be categorized entirely separately from \&quot;Display Categories\&quot;, there need be and often will be no meaningful relationship between the two.
        /// </summary>
        public List<DestinyDefinitionsDestinyDisplayCategoryDefinition> DisplayCategories { get; private set; }

        /// <summary>
        /// In addition to selling items, vendors can have \&quot;interactions\&quot;: UI where you \&quot;talk\&quot; with the vendor and they offer you a reward, some item, or merely acknowledge via dialog that you did something cool.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorInteractionDefinition> Interactions { get; private set; }

        /// <summary>
        /// If the vendor shows you items from your own inventory - such as the Vault vendor does - this data describes the UI around showing those inventory buckets and which ones get shown.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition> InventoryFlyouts { get; private set; }

        /// <summary>
        /// If the vendor sells items (or merely has a list of items to show like the \&quot;Sack\&quot; vendors do), this is the list of those items that the vendor can sell. From this list, only a subset will be available from the vendor at any given time, selected randomly and reset on the vendor&#39;s refresh interval.  Note that a vendor can sell the same item multiple ways: for instance, nothing stops a vendor from selling you some specific weapon but using two different currencies, or the same weapon at multiple \&quot;item levels\&quot;.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorItemDefinition> ItemList { get; private set; }

        /// <summary>
        /// BNet doesn&#39;t use this data yet, but it appears to be an optional list of flavor text about services that the Vendor can provide.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorServiceDefinition> Services { get; private set; }

        /// <summary>
        /// If the Vendor is actually a vehicle for the transferring of items (like the Vault and Postmaster vendors), this defines the list of source-&gt;destination buckets for transferring.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorAcceptedItemDefinition> AcceptedItems { get; private set; }

        /// <summary>
        /// As many of you know, Vendor data has historically been pretty brutal on the BNet servers. In an effort to reduce this workload, only Vendors with this flag set will be returned on Vendor requests. This allows us to filter out Vendors that don&#39;t dynamic data that&#39;s particularly useful: things like \&quot;Preview/Sack\&quot; vendors, for example, that you can usually suss out the details for using just the definitions themselves.
        /// </summary>
        public bool? ReturnWithVendorRequest { get; private set; }

        /// <summary>
        /// A vendor can be at different places in the world depending on the game/character/account state. This is the list of possible locations for the vendor, along with conditions we use to determine which one is currently active.
        /// </summary>
        public List<DestinyDefinitionsVendorsDestinyVendorLocationDefinition> Locations { get; private set; }

        /// <summary>
        /// A vendor can be a part of 0 or 1 \&quot;groups\&quot; at a time: a group being a collection of Vendors related by either location or function/purpose. It&#39;s used for our our Companion Vendor UI. Only one of these can be active for a Vendor at a time.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorGroupReference> Groups { get; private set; }

        /// <summary>
        /// Some items don&#39;t make sense to return in the API, for example because they represent an action to be performed rather than an item being sold. I&#39;d rather we not do this, but at least in the short term this is a workable workaround.
        /// </summary>
        public List<int?> IgnoreSaleItemHashes { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorDefinition(DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition DisplayProperties, string BuyString, string SellString, int? DisplayItemHash, bool? InhibitBuying, bool? InhibitSelling, int? FactionHash, int? ResetIntervalMinutes, int? ResetOffsetMinutes, List<string> FailureStrings, List<DatesDateRange> UnlockRanges, string VendorIdentifier, string VendorPortrait, string VendorBanner, bool? Enabled, bool? Visible, string VendorSubcategoryIdentifier, bool? ConsolidateCategories, List<DestinyDefinitionsDestinyVendorActionDefinition> Actions, List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> Categories, List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> OriginalCategories, List<DestinyDefinitionsDestinyDisplayCategoryDefinition> DisplayCategories, List<DestinyDefinitionsDestinyVendorInteractionDefinition> Interactions, List<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition> InventoryFlyouts, List<DestinyDefinitionsDestinyVendorItemDefinition> ItemList, List<DestinyDefinitionsDestinyVendorServiceDefinition> Services, List<DestinyDefinitionsDestinyVendorAcceptedItemDefinition> AcceptedItems, bool? ReturnWithVendorRequest, List<DestinyDefinitionsVendorsDestinyVendorLocationDefinition> Locations, List<DestinyDefinitionsDestinyVendorGroupReference> Groups, List<int?> IgnoreSaleItemHashes, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.BuyString = BuyString;
            
            this.SellString = SellString;
            
            this.DisplayItemHash = DisplayItemHash;
            
            this.InhibitBuying = InhibitBuying;
            
            this.InhibitSelling = InhibitSelling;
            
            this.FactionHash = FactionHash;
            
            this.ResetIntervalMinutes = ResetIntervalMinutes;
            
            this.ResetOffsetMinutes = ResetOffsetMinutes;
            
            this.FailureStrings = FailureStrings;
            
            this.UnlockRanges = UnlockRanges;
            
            this.VendorIdentifier = VendorIdentifier;
            
            this.VendorPortrait = VendorPortrait;
            
            this.VendorBanner = VendorBanner;
            
            this.Enabled = Enabled;
            
            this.Visible = Visible;
            
            this.VendorSubcategoryIdentifier = VendorSubcategoryIdentifier;
            
            this.ConsolidateCategories = ConsolidateCategories;
            
            this.Actions = Actions;
            
            this.Categories = Categories;
            
            this.OriginalCategories = OriginalCategories;
            
            this.DisplayCategories = DisplayCategories;
            
            this.Interactions = Interactions;
            
            this.InventoryFlyouts = InventoryFlyouts;
            
            this.ItemList = ItemList;
            
            this.Services = Services;
            
            this.AcceptedItems = AcceptedItems;
            
            this.ReturnWithVendorRequest = ReturnWithVendorRequest;
            
            this.Locations = Locations;
            
            this.Groups = Groups;
            
            this.IgnoreSaleItemHashes = IgnoreSaleItemHashes;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .BuyString(BuyString)
                .SellString(SellString)
                .DisplayItemHash(DisplayItemHash)
                .InhibitBuying(InhibitBuying)
                .InhibitSelling(InhibitSelling)
                .FactionHash(FactionHash)
                .ResetIntervalMinutes(ResetIntervalMinutes)
                .ResetOffsetMinutes(ResetOffsetMinutes)
                .FailureStrings(FailureStrings)
                .UnlockRanges(UnlockRanges)
                .VendorIdentifier(VendorIdentifier)
                .VendorPortrait(VendorPortrait)
                .VendorBanner(VendorBanner)
                .Enabled(Enabled)
                .Visible(Visible)
                .VendorSubcategoryIdentifier(VendorSubcategoryIdentifier)
                .ConsolidateCategories(ConsolidateCategories)
                .Actions(Actions)
                .Categories(Categories)
                .OriginalCategories(OriginalCategories)
                .DisplayCategories(DisplayCategories)
                .Interactions(Interactions)
                .InventoryFlyouts(InventoryFlyouts)
                .ItemList(ItemList)
                .Services(Services)
                .AcceptedItems(AcceptedItems)
                .ReturnWithVendorRequest(ReturnWithVendorRequest)
                .Locations(Locations)
                .Groups(Groups)
                .IgnoreSaleItemHashes(IgnoreSaleItemHashes)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorDefinition left, DestinyDefinitionsDestinyVendorDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorDefinition left, DestinyDefinitionsDestinyVendorDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorDefinitionBuilder
        {
            private DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition _DisplayProperties;
            private string _BuyString;
            private string _SellString;
            private int? _DisplayItemHash;
            private bool? _InhibitBuying;
            private bool? _InhibitSelling;
            private int? _FactionHash;
            private int? _ResetIntervalMinutes;
            private int? _ResetOffsetMinutes;
            private List<string> _FailureStrings;
            private List<DatesDateRange> _UnlockRanges;
            private string _VendorIdentifier;
            private string _VendorPortrait;
            private string _VendorBanner;
            private bool? _Enabled;
            private bool? _Visible;
            private string _VendorSubcategoryIdentifier;
            private bool? _ConsolidateCategories;
            private List<DestinyDefinitionsDestinyVendorActionDefinition> _Actions;
            private List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> _Categories;
            private List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> _OriginalCategories;
            private List<DestinyDefinitionsDestinyDisplayCategoryDefinition> _DisplayCategories;
            private List<DestinyDefinitionsDestinyVendorInteractionDefinition> _Interactions;
            private List<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition> _InventoryFlyouts;
            private List<DestinyDefinitionsDestinyVendorItemDefinition> _ItemList;
            private List<DestinyDefinitionsDestinyVendorServiceDefinition> _Services;
            private List<DestinyDefinitionsDestinyVendorAcceptedItemDefinition> _AcceptedItems;
            private bool? _ReturnWithVendorRequest;
            private List<DestinyDefinitionsVendorsDestinyVendorLocationDefinition> _Locations;
            private List<DestinyDefinitionsDestinyVendorGroupReference> _Groups;
            private List<int?> _IgnoreSaleItemHashes;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyVendorDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder DisplayProperties(DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.BuyString property.
            /// </summary>
            /// <param name="value">If the vendor has a custom localized string describing the \&quot;buy\&quot; action, that is returned here.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder BuyString(string value)
            {
                _BuyString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.SellString property.
            /// </summary>
            /// <param name="value">Ditto for selling. Not that you can sell items to a vendor anymore. Will it come back? Who knows. The string&#39;s still there.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder SellString(string value)
            {
                _SellString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.DisplayItemHash property.
            /// </summary>
            /// <param name="value">If the vendor has an item that should be displayed as the \&quot;featured\&quot; item, this is the hash identifier for that DestinyVendorItemDefinition.  Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder DisplayItemHash(int? value)
            {
                _DisplayItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.InhibitBuying property.
            /// </summary>
            /// <param name="value">If this is true, you aren&#39;t allowed to buy whatever the vendor is selling.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder InhibitBuying(bool? value)
            {
                _InhibitBuying = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.InhibitSelling property.
            /// </summary>
            /// <param name="value">If this is true, you&#39;re not allowed to sell whatever the vendor is buying.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder InhibitSelling(bool? value)
            {
                _InhibitSelling = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.FactionHash property.
            /// </summary>
            /// <param name="value">If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.  The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction&#39;s Progression status (aka \&quot;Reputation\&quot;).</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder FactionHash(int? value)
            {
                _FactionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.ResetIntervalMinutes property.
            /// </summary>
            /// <param name="value">A number used for calculating the frequency of a vendor&#39;s inventory resetting/refreshing.  Don&#39;t worry about calculating this - we do it on the server side and send you the next refresh date with the live data.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder ResetIntervalMinutes(int? value)
            {
                _ResetIntervalMinutes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.ResetOffsetMinutes property.
            /// </summary>
            /// <param name="value">Again, used for reset/refreshing of inventory. Don&#39;t worry too much about it. Unless you want to.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder ResetOffsetMinutes(int? value)
            {
                _ResetOffsetMinutes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.FailureStrings property.
            /// </summary>
            /// <param name="value">If an item can&#39;t be purchased from the vendor, there may be many \&quot;custom\&quot;/game state specific reasons why not.  This is a list of localized strings with messages for those custom failures. The live BNet data will return a failureIndexes property for items that can&#39;t be purchased: using those values to index into this array, you can show the user the appropriate failure message for the item that can&#39;t be bought.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder FailureStrings(List<string> value)
            {
                _FailureStrings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.UnlockRanges property.
            /// </summary>
            /// <param name="value">If we were able to predict the dates when this Vendor will be visible/available, this will be the list of those date ranges. Sadly, we&#39;re not able to predict this very frequently, so this will often be useless data.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder UnlockRanges(List<DatesDateRange> value)
            {
                _UnlockRanges = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.VendorIdentifier property.
            /// </summary>
            /// <param name="value">The internal identifier for the Vendor. A holdover from the old days of Vendors, but we don&#39;t have time to refactor it away.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder VendorIdentifier(string value)
            {
                _VendorIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.VendorPortrait property.
            /// </summary>
            /// <param name="value">A portrait of the Vendor&#39;s smiling mug. Or frothing tentacles.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder VendorPortrait(string value)
            {
                _VendorPortrait = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.VendorBanner property.
            /// </summary>
            /// <param name="value">If the vendor has a custom banner image, that can be found here.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder VendorBanner(string value)
            {
                _VendorBanner = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Enabled property.
            /// </summary>
            /// <param name="value">If a vendor is not enabled, we won&#39;t even save the vendor&#39;s definition, and we won&#39;t return any items or info about them. It&#39;s as if they don&#39;t exist.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Visible property.
            /// </summary>
            /// <param name="value">If a vendor is not visible, we still have and will give vendor definition info, but we won&#39;t use them for things like Advisors or UI.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Visible(bool? value)
            {
                _Visible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.VendorSubcategoryIdentifier property.
            /// </summary>
            /// <param name="value">The identifier of the VendorCategoryDefinition for this vendor&#39;s subcategory.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder VendorSubcategoryIdentifier(string value)
            {
                _VendorSubcategoryIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.ConsolidateCategories property.
            /// </summary>
            /// <param name="value">If TRUE, consolidate categories that only differ by trivial properties (such as having minor differences in name)</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder ConsolidateCategories(bool? value)
            {
                _ConsolidateCategories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Actions property.
            /// </summary>
            /// <param name="value">Describes \&quot;actions\&quot; that can be performed on a vendor. Currently, none of these exist. But theoretically a Vendor could let you interact with it by performing actions. We&#39;ll see what these end up looking like if they ever get used.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Actions(List<DestinyDefinitionsDestinyVendorActionDefinition> value)
            {
                _Actions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Categories property.
            /// </summary>
            /// <param name="value">These are the headers for sections of items that the vendor is selling. When you see items organized by category in the header, it is these categories that it is showing.  Well, technically not *exactly* these. On BNet, it doesn&#39;t make sense to have categories be \&quot;paged\&quot; as we do in Destiny, so we run some heuristics to attempt to aggregate pages of categories together.   These are the categories post-concatenation, if the vendor had concatenation applied. If you want the pre-aggregated category data, use originalCategories.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Categories(List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> value)
            {
                _Categories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.OriginalCategories property.
            /// </summary>
            /// <param name="value">See the categories property for a description of categories and why originalCategories exists.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder OriginalCategories(List<DestinyDefinitionsDestinyVendorCategoryEntryDefinition> value)
            {
                _OriginalCategories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.DisplayCategories property.
            /// </summary>
            /// <param name="value">Display Categories are different from \&quot;categories\&quot; in that these are specifically for visual grouping and display of categories in Vendor UI.   The \&quot;categories\&quot; structure is for validation of the contained items, and can be categorized entirely separately from \&quot;Display Categories\&quot;, there need be and often will be no meaningful relationship between the two.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder DisplayCategories(List<DestinyDefinitionsDestinyDisplayCategoryDefinition> value)
            {
                _DisplayCategories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Interactions property.
            /// </summary>
            /// <param name="value">In addition to selling items, vendors can have \&quot;interactions\&quot;: UI where you \&quot;talk\&quot; with the vendor and they offer you a reward, some item, or merely acknowledge via dialog that you did something cool.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Interactions(List<DestinyDefinitionsDestinyVendorInteractionDefinition> value)
            {
                _Interactions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.InventoryFlyouts property.
            /// </summary>
            /// <param name="value">If the vendor shows you items from your own inventory - such as the Vault vendor does - this data describes the UI around showing those inventory buckets and which ones get shown.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder InventoryFlyouts(List<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition> value)
            {
                _InventoryFlyouts = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.ItemList property.
            /// </summary>
            /// <param name="value">If the vendor sells items (or merely has a list of items to show like the \&quot;Sack\&quot; vendors do), this is the list of those items that the vendor can sell. From this list, only a subset will be available from the vendor at any given time, selected randomly and reset on the vendor&#39;s refresh interval.  Note that a vendor can sell the same item multiple ways: for instance, nothing stops a vendor from selling you some specific weapon but using two different currencies, or the same weapon at multiple \&quot;item levels\&quot;.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder ItemList(List<DestinyDefinitionsDestinyVendorItemDefinition> value)
            {
                _ItemList = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Services property.
            /// </summary>
            /// <param name="value">BNet doesn&#39;t use this data yet, but it appears to be an optional list of flavor text about services that the Vendor can provide.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Services(List<DestinyDefinitionsDestinyVendorServiceDefinition> value)
            {
                _Services = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.AcceptedItems property.
            /// </summary>
            /// <param name="value">If the Vendor is actually a vehicle for the transferring of items (like the Vault and Postmaster vendors), this defines the list of source-&gt;destination buckets for transferring.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder AcceptedItems(List<DestinyDefinitionsDestinyVendorAcceptedItemDefinition> value)
            {
                _AcceptedItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.ReturnWithVendorRequest property.
            /// </summary>
            /// <param name="value">As many of you know, Vendor data has historically been pretty brutal on the BNet servers. In an effort to reduce this workload, only Vendors with this flag set will be returned on Vendor requests. This allows us to filter out Vendors that don&#39;t dynamic data that&#39;s particularly useful: things like \&quot;Preview/Sack\&quot; vendors, for example, that you can usually suss out the details for using just the definitions themselves.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder ReturnWithVendorRequest(bool? value)
            {
                _ReturnWithVendorRequest = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Locations property.
            /// </summary>
            /// <param name="value">A vendor can be at different places in the world depending on the game/character/account state. This is the list of possible locations for the vendor, along with conditions we use to determine which one is currently active.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Locations(List<DestinyDefinitionsVendorsDestinyVendorLocationDefinition> value)
            {
                _Locations = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Groups property.
            /// </summary>
            /// <param name="value">A vendor can be a part of 0 or 1 \&quot;groups\&quot; at a time: a group being a collection of Vendors related by either location or function/purpose. It&#39;s used for our our Companion Vendor UI. Only one of these can be active for a Vendor at a time.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Groups(List<DestinyDefinitionsDestinyVendorGroupReference> value)
            {
                _Groups = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.IgnoreSaleItemHashes property.
            /// </summary>
            /// <param name="value">Some items don&#39;t make sense to return in the API, for example because they represent an action to be performed rather than an item being sold. I&#39;d rather we not do this, but at least in the short term this is a workable workaround.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder IgnoreSaleItemHashes(List<int?> value)
            {
                _IgnoreSaleItemHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyVendorDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorDefinition</returns>
            public DestinyDefinitionsDestinyVendorDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorDefinition(
                    DisplayProperties: _DisplayProperties,
                    BuyString: _BuyString,
                    SellString: _SellString,
                    DisplayItemHash: _DisplayItemHash,
                    InhibitBuying: _InhibitBuying,
                    InhibitSelling: _InhibitSelling,
                    FactionHash: _FactionHash,
                    ResetIntervalMinutes: _ResetIntervalMinutes,
                    ResetOffsetMinutes: _ResetOffsetMinutes,
                    FailureStrings: _FailureStrings,
                    UnlockRanges: _UnlockRanges,
                    VendorIdentifier: _VendorIdentifier,
                    VendorPortrait: _VendorPortrait,
                    VendorBanner: _VendorBanner,
                    Enabled: _Enabled,
                    Visible: _Visible,
                    VendorSubcategoryIdentifier: _VendorSubcategoryIdentifier,
                    ConsolidateCategories: _ConsolidateCategories,
                    Actions: _Actions,
                    Categories: _Categories,
                    OriginalCategories: _OriginalCategories,
                    DisplayCategories: _DisplayCategories,
                    Interactions: _Interactions,
                    InventoryFlyouts: _InventoryFlyouts,
                    ItemList: _ItemList,
                    Services: _Services,
                    AcceptedItems: _AcceptedItems,
                    ReturnWithVendorRequest: _ReturnWithVendorRequest,
                    Locations: _Locations,
                    Groups: _Groups,
                    IgnoreSaleItemHashes: _IgnoreSaleItemHashes,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}