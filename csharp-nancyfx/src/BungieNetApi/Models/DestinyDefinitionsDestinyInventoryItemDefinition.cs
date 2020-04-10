using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// So much of what you see in Destiny is actually an Item used in a new and creative way. This is the definition for Items in Destiny, which started off as just entities that could exist in your Inventory but ended up being the backing data for so much more: quests, reward previews, slots, and subclasses.  In practice, you will want to associate this data with \&quot;live\&quot; item data from a Bungie.Net Platform call: these definitions describe the item in generic, non-instanced terms: but an actual instance of an item can vary widely from these generic definitions.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyInventoryItemDefinition:  IEquatable<DestinyDefinitionsDestinyInventoryItemDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Tooltips that only come up conditionally for the item. Check the live data DestinyItemComponent.tooltipNotificationIndexes property for which of these should be shown at runtime.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemTooltipNotification> TooltipNotifications { get; private set; }

        /// <summary>
        /// If this item has a collectible related to it, this is the hash identifier of that collectible entry.
        /// </summary>
        public int? CollectibleHash { get; private set; }

        /// <summary>
        /// A secondary icon associated with the item. Currently this is used in very context specific applications, such as Emblem Nameplates.
        /// </summary>
        public string SecondaryIcon { get; private set; }

        /// <summary>
        /// Pulled from the secondary icon, this is the \&quot;secondary background\&quot; of the secondary icon. Confusing? Sure, that&#39;s why I call it \&quot;overlay\&quot; here: because as far as it&#39;s been used thus far, it has been for an optional overlay image. We&#39;ll see if that holds up, but at least for now it explains what this image is a bit better.
        /// </summary>
        public string SecondaryOverlay { get; private set; }

        /// <summary>
        /// Pulled from the Secondary Icon, this is the \&quot;special\&quot; background for the item. For Emblems, this is the background image used on the Details view: but it need not be limited to that for other types of items.
        /// </summary>
        public string SecondarySpecial { get; private set; }

        /// <summary>
        /// Sometimes, an item will have a background color. Most notably this occurs with Emblems, who use the Background Color for small character nameplates such as the \&quot;friends\&quot; view you see in-game. There are almost certainly other items that have background color as well, though I have not bothered to investigate what items have it nor what purposes they serve: use it as you will.
        /// </summary>
        public DestinyMiscDestinyColor BackgroundColor { get; private set; }

        /// <summary>
        /// If we were able to acquire an in-game screenshot for the item, the path to that screenshot will be returned here. Note that not all items have screenshots: particularly not any non-equippable items.
        /// </summary>
        public string Screenshot { get; private set; }

        /// <summary>
        /// The localized title/name of the item&#39;s type. This can be whatever the designers want, and has no guarantee of consistency between items.
        /// </summary>
        public string ItemTypeDisplayName { get; private set; }

        /// <summary>
        /// A string identifier that the game&#39;s UI uses to determine how the item should be rendered in inventory screens and the like. This could really be anything - at the moment, we don&#39;t have the time to really breakdown and maintain all the possible strings this could be, partly because new ones could be added ad hoc. But if you want to use it to dictate your own UI, or look for items with a certain display style, go for it!
        /// </summary>
        public string UiItemDisplayStyle { get; private set; }

        /// <summary>
        /// It became a common enough pattern in our UI to show Item Type and Tier combined into a single localized string that I&#39;m just going to go ahead and start pre-creating these for items.
        /// </summary>
        public string ItemTypeAndTierDisplayName { get; private set; }

        /// <summary>
        /// In theory, it is a localized string telling you about how you can find the item. I really wish this was more consistent. Many times, it has nothing. Sometimes, it&#39;s instead a more narrative-forward description of the item. Which is cool, and I wish all properties had that data, but it should really be its own property.
        /// </summary>
        public string DisplaySource { get; private set; }

        /// <summary>
        /// An identifier that the game UI uses to determine what type of tooltip to show for the item. These have no corresponding definitions that BNet can link to: so it&#39;ll be up to you to interpret and display your UI differently according to these styles (or ignore it).
        /// </summary>
        public string TooltipStyle { get; private set; }

        /// <summary>
        /// If the item can be \&quot;used\&quot;, this block will be non-null, and will have data related to the action performed when using the item. (Guess what? 99% of the time, this action is \&quot;dismantle\&quot;. Shocker)
        /// </summary>
        public DestinyDefinitionsDestinyItemActionBlockDefinition Action { get; private set; }

        /// <summary>
        /// If this item can exist in an inventory, this block will be non-null. In practice, every item that currently exists has one of these blocks. But note that it is not necessarily guaranteed.
        /// </summary>
        public DestinyDefinitionsDestinyItemInventoryBlockDefinition Inventory { get; private set; }

        /// <summary>
        /// If this item is a quest, this block will be non-null. In practice, I wish I had called this the Quest block, but at the time it wasn&#39;t clear to me whether it would end up being used for purposes other than quests. It will contain data about the steps in the quest, and mechanics we can use for displaying and tracking the quest.
        /// </summary>
        public DestinyDefinitionsDestinyItemSetBlockDefinition SetData { get; private set; }

        /// <summary>
        /// If this item can have stats (such as a weapon, armor, or vehicle), this block will be non-null and populated with the stats found on the item.
        /// </summary>
        public DestinyDefinitionsDestinyItemStatBlockDefinition Stats { get; private set; }

        /// <summary>
        /// If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the \&quot;art channel\&quot;. When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they&#39;re being used for and how they are wired up, but for now here&#39;s the raw data.
        /// </summary>
        public int? EmblemObjectiveHash { get; private set; }

        /// <summary>
        /// If this item can be equipped, this block will be non-null and will be populated with the conditions under which it can be equipped.
        /// </summary>
        public DestinyDefinitionsDestinyEquippingBlockDefinition EquippingBlock { get; private set; }

        /// <summary>
        /// If this item can be rendered, this block will be non-null and will be populated with rendering information.
        /// </summary>
        public DestinyDefinitionsDestinyItemTranslationBlockDefinition TranslationBlock { get; private set; }

        /// <summary>
        /// If this item can be Used or Acquired to gain other items (for instance, how Eververse Boxes can be consumed to get items from the box), this block will be non-null and will give summary information for the items that can be acquired.
        /// </summary>
        public DestinyDefinitionsDestinyItemPreviewBlockDefinition Preview { get; private set; }

        /// <summary>
        /// If this item can have a level or stats, this block will be non-null and will be populated with default quality (item level, \&quot;quality\&quot;, and infusion) data. See the block for more details, there&#39;s often less upfront information in D2 so you&#39;ll want to be aware of how you use quality and item level on the definition level now.
        /// </summary>
        public DestinyDefinitionsDestinyItemQualityBlockDefinition Quality { get; private set; }

        /// <summary>
        /// The conceptual \&quot;Value\&quot; of an item, if any was defined. See the DestinyItemValueBlockDefinition for more details.
        /// </summary>
        public DestinyDefinitionsDestinyItemValueBlockDefinition Value { get; private set; }

        /// <summary>
        /// If this item has a known source, this block will be non-null and populated with source information. Unfortunately, at this time we are not generating sources: that is some aggressively manual work which we didn&#39;t have time for, and I&#39;m hoping to get back to at some point in the future.
        /// </summary>
        public DestinyDefinitionsDestinyItemSourceBlockDefinition SourceData { get; private set; }

        /// <summary>
        /// If this item has Objectives (extra tasks that can be accomplished related to the item... most frequently when the item is a Quest Step and the Objectives need to be completed to move on to the next Quest Step), this block will be non-null and the objectives defined herein.
        /// </summary>
        public DestinyDefinitionsDestinyItemObjectiveBlockDefinition Objectives { get; private set; }

        /// <summary>
        /// If this item has available metrics to be shown, this block will be non-null have the appropriate hashes defined.
        /// </summary>
        public DestinyDefinitionsDestinyItemMetricBlockDefinition Metrics { get; private set; }

        /// <summary>
        /// If this item *is* a Plug, this will be non-null and the info defined herein. See DestinyItemPlugDefinition for more information.
        /// </summary>
        public DestinyDefinitionsItemsDestinyItemPlugDefinition Plug { get; private set; }

        /// <summary>
        /// If this item has related items in a \&quot;Gear Set\&quot;, this will be non-null and the relationships defined herein.
        /// </summary>
        public DestinyDefinitionsDestinyItemGearsetBlockDefinition Gearset { get; private set; }

        /// <summary>
        /// If this item is a \&quot;reward sack\&quot; that can be opened to provide other items, this will be non-null and the properties of the sack contained herein.
        /// </summary>
        public DestinyDefinitionsDestinyItemSackBlockDefinition Sack { get; private set; }

        /// <summary>
        /// If this item has any Sockets, this will be non-null and the individual sockets on the item will be defined herein.
        /// </summary>
        public DestinyDefinitionsDestinyItemSocketBlockDefinition Sockets { get; private set; }

        /// <summary>
        /// Summary data about the item.
        /// </summary>
        public DestinyDefinitionsDestinyItemSummaryBlockDefinition Summary { get; private set; }

        /// <summary>
        /// If the item has a Talent Grid, this will be non-null and the properties of the grid defined herein. Note that, while many items still have talent grids, the only ones with meaningful Nodes still on them will be Subclass/\&quot;Build\&quot; items.
        /// </summary>
        public DestinyDefinitionsDestinyItemTalentGridBlockDefinition TalentGrid { get; private set; }

        /// <summary>
        /// If the item has stats, this block will be defined. It has the \&quot;raw\&quot; investment stats for the item. These investment stats don&#39;t take into account the ways that the items can spawn, nor do they take into account any Stat Group transformations. I have retained them for debugging purposes, but I do not know how useful people will find them.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemInvestmentStatDefinition> InvestmentStats { get; private set; }

        /// <summary>
        /// If the item has any *intrinsic* Perks (Perks that it will provide regardless of Sockets, Talent Grid, and other transitory state), they will be defined here.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemPerkEntryDefinition> Perks { get; private set; }

        /// <summary>
        /// If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.
        /// </summary>
        public int? LoreHash { get; private set; }

        /// <summary>
        /// There are times when the game will show you a \&quot;summary/vague\&quot; version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.  This happens sometimes when summarizing possible rewards in a tooltip. This is the item displayed instead, if it exists.
        /// </summary>
        public int? SummaryItemHash { get; private set; }

        /// <summary>
        /// If any animations were extracted from game content for this item, these will be the definitions of those animations.
        /// </summary>
        public List<DestinyDefinitionsAnimationsDestinyAnimationReference> Animations { get; private set; }

        /// <summary>
        /// BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.
        /// </summary>
        public bool? AllowActions { get; private set; }

        /// <summary>
        /// If we added any help or informational URLs about this item, these will be those links.
        /// </summary>
        public List<LinksHyperlinkReference> Links { get; private set; }

        /// <summary>
        /// The boolean will indicate to us (and you!) whether something *could* happen when you transfer this item from the Postmaster that might be considered a \&quot;destructive\&quot; action.  It is not feasible currently to tell you (or ourelves!) in a consistent way whether this *will* actually cause a destructive action, so we are playing it safe: if it has the potential to do so, we will not allow it to be transferred from the Postmaster by default. You will need to check for this flag before transferring an item from the Postmaster, or else you&#39;ll end up receiving an error.
        /// </summary>
        public bool? DoesPostmasterPullHaveSideEffects { get; private set; }

        /// <summary>
        /// The intrinsic transferability of an item.  I hate that this boolean is negative - but there&#39;s a reason.  Just because an item is intrinsically transferrable doesn&#39;t mean that it can be transferred, and we don&#39;t want to imply that this is the only source of that transferability.
        /// </summary>
        public bool? NonTransferrable { get; private set; }

        /// <summary>
        /// BNet attempts to make a more formal definition of item \&quot;Categories\&quot;, as defined by DestinyItemCategoryDefinition. This is a list of all Categories that we were able to algorithmically determine that this item is a member of. (for instance, that it&#39;s a \&quot;Weapon\&quot;, that it&#39;s an \&quot;Auto Rifle\&quot;, etc...)  The algorithm for these is, unfortunately, volatile. If you believe you see a miscategorized item, please let us know on the Bungie API forums.
        /// </summary>
        public List<int?> ItemCategoryHashes { get; private set; }

        /// <summary>
        /// In Destiny 1, we identified some items as having particular categories that we&#39;d like to know about for various internal logic purposes. These are defined in SpecialItemType, and while these days the itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
        /// </summary>
        public int? SpecialItemType { get; private set; }

        /// <summary>
        /// A value indicating the \&quot;base\&quot; the of the item. This enum is a useful but dramatic oversimplification of what it means for an item to have a \&quot;Type\&quot;. Still, it&#39;s handy in many situations.  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
        /// </summary>
        public int? ItemType { get; private set; }

        /// <summary>
        /// A value indicating the \&quot;sub-type\&quot; of the item. For instance, where an item might have an itemType value \&quot;Weapon\&quot;, this will be something more specific like \&quot;Auto Rifle\&quot;.  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
        /// </summary>
        public int? ItemSubType { get; private set; }

        /// <summary>
        /// We run a similarly weak-sauce algorithm to try and determine whether an item is restricted to a specific class. If we find it to be restricted in such a way, we set this classType property to match the class&#39; enumeration value so that users can easily identify class restricted items.  If you see a mis-classed item, please inform the developers in the Bungie API forum.
        /// </summary>
        public int? ClassType { get; private set; }

        /// <summary>
        /// Some weapons and plugs can have a \&quot;Breaker Type\&quot;: a special ability that works sort of like damage type vulnerabilities. This is (almost?) always set on items by plugs.
        /// </summary>
        public int? BreakerType { get; private set; }

        /// <summary>
        /// Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what&#39;s cleanest for your code.
        /// </summary>
        public int? BreakerTypeHash { get; private set; }

        /// <summary>
        /// If true, then you will be allowed to equip the item if you pass its other requirements.  This being false means that you cannot equip the item under any circumstances.
        /// </summary>
        public bool? Equippable { get; private set; }

        /// <summary>
        /// Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.
        /// </summary>
        public List<int?> DamageTypeHashes { get; private set; }

        /// <summary>
        /// This is the list of all damage types that we know ahead of time the item can take on. Unfortunately, this does not preclude the possibility of something funky happening to give the item a damage type that cannot be predicted beforehand: for example, if some designer decides to create arbitrary non-reusable plugs that cause damage type to change.  This damage type prediction will only use the following to determine potential damage types:  - Intrinsic perks  - Talent Node perks  - Known, reusable plugs for sockets
        /// </summary>
        public List<int?> DamageTypes { get; private set; }

        /// <summary>
        /// If the item has a damage type that could be considered to be default, it will be populated here.  For various upsetting reasons, it&#39;s surprisingly cumbersome to figure this out. I hope you&#39;re happy.
        /// </summary>
        public int? DefaultDamageType { get; private set; }

        /// <summary>
        /// Similar to defaultDamageType, but represented as the hash identifier for a DestinyDamageTypeDefinition.  I will likely regret leaving in the enumeration versions of these properties, but for now they&#39;re very convenient.
        /// </summary>
        public int? DefaultDamageTypeHash { get; private set; }

        /// <summary>
        /// If this item is related directly to a Season of Destiny, this is the hash identifier for that season.
        /// </summary>
        public int? SeasonHash { get; private set; }

        /// <summary>
        /// If true, this is a dummy vendor-wrapped item template. Items purchased from Eververse will be \&quot;wrapped\&quot; by one of these items so that we can safely provide refund capabilities before the item is \&quot;unwrapped\&quot;.
        /// </summary>
        public bool? IsWrapper { get; private set; }

        /// <summary>
        /// Traits are metadata tags applied to this item. For example: armor slot, weapon type, foundry, faction, etc. These IDs come from the game and don&#39;t map to any content, but should still be useful.
        /// </summary>
        public List<string> TraitIds { get; private set; }

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
        /// Use DestinyDefinitionsDestinyInventoryItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyInventoryItemDefinition()
        {
        }

        private DestinyDefinitionsDestinyInventoryItemDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, List<DestinyDefinitionsDestinyItemTooltipNotification> TooltipNotifications, int? CollectibleHash, string SecondaryIcon, string SecondaryOverlay, string SecondarySpecial, DestinyMiscDestinyColor BackgroundColor, string Screenshot, string ItemTypeDisplayName, string UiItemDisplayStyle, string ItemTypeAndTierDisplayName, string DisplaySource, string TooltipStyle, DestinyDefinitionsDestinyItemActionBlockDefinition Action, DestinyDefinitionsDestinyItemInventoryBlockDefinition Inventory, DestinyDefinitionsDestinyItemSetBlockDefinition SetData, DestinyDefinitionsDestinyItemStatBlockDefinition Stats, int? EmblemObjectiveHash, DestinyDefinitionsDestinyEquippingBlockDefinition EquippingBlock, DestinyDefinitionsDestinyItemTranslationBlockDefinition TranslationBlock, DestinyDefinitionsDestinyItemPreviewBlockDefinition Preview, DestinyDefinitionsDestinyItemQualityBlockDefinition Quality, DestinyDefinitionsDestinyItemValueBlockDefinition Value, DestinyDefinitionsDestinyItemSourceBlockDefinition SourceData, DestinyDefinitionsDestinyItemObjectiveBlockDefinition Objectives, DestinyDefinitionsDestinyItemMetricBlockDefinition Metrics, DestinyDefinitionsItemsDestinyItemPlugDefinition Plug, DestinyDefinitionsDestinyItemGearsetBlockDefinition Gearset, DestinyDefinitionsDestinyItemSackBlockDefinition Sack, DestinyDefinitionsDestinyItemSocketBlockDefinition Sockets, DestinyDefinitionsDestinyItemSummaryBlockDefinition Summary, DestinyDefinitionsDestinyItemTalentGridBlockDefinition TalentGrid, List<DestinyDefinitionsDestinyItemInvestmentStatDefinition> InvestmentStats, List<DestinyDefinitionsDestinyItemPerkEntryDefinition> Perks, int? LoreHash, int? SummaryItemHash, List<DestinyDefinitionsAnimationsDestinyAnimationReference> Animations, bool? AllowActions, List<LinksHyperlinkReference> Links, bool? DoesPostmasterPullHaveSideEffects, bool? NonTransferrable, List<int?> ItemCategoryHashes, int? SpecialItemType, int? ItemType, int? ItemSubType, int? ClassType, int? BreakerType, int? BreakerTypeHash, bool? Equippable, List<int?> DamageTypeHashes, List<int?> DamageTypes, int? DefaultDamageType, int? DefaultDamageTypeHash, int? SeasonHash, bool? IsWrapper, List<string> TraitIds, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.TooltipNotifications = TooltipNotifications;
            
            this.CollectibleHash = CollectibleHash;
            
            this.SecondaryIcon = SecondaryIcon;
            
            this.SecondaryOverlay = SecondaryOverlay;
            
            this.SecondarySpecial = SecondarySpecial;
            
            this.BackgroundColor = BackgroundColor;
            
            this.Screenshot = Screenshot;
            
            this.ItemTypeDisplayName = ItemTypeDisplayName;
            
            this.UiItemDisplayStyle = UiItemDisplayStyle;
            
            this.ItemTypeAndTierDisplayName = ItemTypeAndTierDisplayName;
            
            this.DisplaySource = DisplaySource;
            
            this.TooltipStyle = TooltipStyle;
            
            this.Action = Action;
            
            this.Inventory = Inventory;
            
            this.SetData = SetData;
            
            this.Stats = Stats;
            
            this.EmblemObjectiveHash = EmblemObjectiveHash;
            
            this.EquippingBlock = EquippingBlock;
            
            this.TranslationBlock = TranslationBlock;
            
            this.Preview = Preview;
            
            this.Quality = Quality;
            
            this.Value = Value;
            
            this.SourceData = SourceData;
            
            this.Objectives = Objectives;
            
            this.Metrics = Metrics;
            
            this.Plug = Plug;
            
            this.Gearset = Gearset;
            
            this.Sack = Sack;
            
            this.Sockets = Sockets;
            
            this.Summary = Summary;
            
            this.TalentGrid = TalentGrid;
            
            this.InvestmentStats = InvestmentStats;
            
            this.Perks = Perks;
            
            this.LoreHash = LoreHash;
            
            this.SummaryItemHash = SummaryItemHash;
            
            this.Animations = Animations;
            
            this.AllowActions = AllowActions;
            
            this.Links = Links;
            
            this.DoesPostmasterPullHaveSideEffects = DoesPostmasterPullHaveSideEffects;
            
            this.NonTransferrable = NonTransferrable;
            
            this.ItemCategoryHashes = ItemCategoryHashes;
            
            this.SpecialItemType = SpecialItemType;
            
            this.ItemType = ItemType;
            
            this.ItemSubType = ItemSubType;
            
            this.ClassType = ClassType;
            
            this.BreakerType = BreakerType;
            
            this.BreakerTypeHash = BreakerTypeHash;
            
            this.Equippable = Equippable;
            
            this.DamageTypeHashes = DamageTypeHashes;
            
            this.DamageTypes = DamageTypes;
            
            this.DefaultDamageType = DefaultDamageType;
            
            this.DefaultDamageTypeHash = DefaultDamageTypeHash;
            
            this.SeasonHash = SeasonHash;
            
            this.IsWrapper = IsWrapper;
            
            this.TraitIds = TraitIds;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyInventoryItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyInventoryItemDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyInventoryItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyInventoryItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyInventoryItemDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .TooltipNotifications(TooltipNotifications)
                .CollectibleHash(CollectibleHash)
                .SecondaryIcon(SecondaryIcon)
                .SecondaryOverlay(SecondaryOverlay)
                .SecondarySpecial(SecondarySpecial)
                .BackgroundColor(BackgroundColor)
                .Screenshot(Screenshot)
                .ItemTypeDisplayName(ItemTypeDisplayName)
                .UiItemDisplayStyle(UiItemDisplayStyle)
                .ItemTypeAndTierDisplayName(ItemTypeAndTierDisplayName)
                .DisplaySource(DisplaySource)
                .TooltipStyle(TooltipStyle)
                .Action(Action)
                .Inventory(Inventory)
                .SetData(SetData)
                .Stats(Stats)
                .EmblemObjectiveHash(EmblemObjectiveHash)
                .EquippingBlock(EquippingBlock)
                .TranslationBlock(TranslationBlock)
                .Preview(Preview)
                .Quality(Quality)
                .Value(Value)
                .SourceData(SourceData)
                .Objectives(Objectives)
                .Metrics(Metrics)
                .Plug(Plug)
                .Gearset(Gearset)
                .Sack(Sack)
                .Sockets(Sockets)
                .Summary(Summary)
                .TalentGrid(TalentGrid)
                .InvestmentStats(InvestmentStats)
                .Perks(Perks)
                .LoreHash(LoreHash)
                .SummaryItemHash(SummaryItemHash)
                .Animations(Animations)
                .AllowActions(AllowActions)
                .Links(Links)
                .DoesPostmasterPullHaveSideEffects(DoesPostmasterPullHaveSideEffects)
                .NonTransferrable(NonTransferrable)
                .ItemCategoryHashes(ItemCategoryHashes)
                .SpecialItemType(SpecialItemType)
                .ItemType(ItemType)
                .ItemSubType(ItemSubType)
                .ClassType(ClassType)
                .BreakerType(BreakerType)
                .BreakerTypeHash(BreakerTypeHash)
                .Equippable(Equippable)
                .DamageTypeHashes(DamageTypeHashes)
                .DamageTypes(DamageTypes)
                .DefaultDamageType(DefaultDamageType)
                .DefaultDamageTypeHash(DefaultDamageTypeHash)
                .SeasonHash(SeasonHash)
                .IsWrapper(IsWrapper)
                .TraitIds(TraitIds)
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

        public bool Equals(DestinyDefinitionsDestinyInventoryItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyInventoryItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyInventoryItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyInventoryItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyInventoryItemDefinition left, DestinyDefinitionsDestinyInventoryItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyInventoryItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyInventoryItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyInventoryItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyInventoryItemDefinition left, DestinyDefinitionsDestinyInventoryItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyInventoryItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyInventoryItemDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private List<DestinyDefinitionsDestinyItemTooltipNotification> _TooltipNotifications;
            private int? _CollectibleHash;
            private string _SecondaryIcon;
            private string _SecondaryOverlay;
            private string _SecondarySpecial;
            private DestinyMiscDestinyColor _BackgroundColor;
            private string _Screenshot;
            private string _ItemTypeDisplayName;
            private string _UiItemDisplayStyle;
            private string _ItemTypeAndTierDisplayName;
            private string _DisplaySource;
            private string _TooltipStyle;
            private DestinyDefinitionsDestinyItemActionBlockDefinition _Action;
            private DestinyDefinitionsDestinyItemInventoryBlockDefinition _Inventory;
            private DestinyDefinitionsDestinyItemSetBlockDefinition _SetData;
            private DestinyDefinitionsDestinyItemStatBlockDefinition _Stats;
            private int? _EmblemObjectiveHash;
            private DestinyDefinitionsDestinyEquippingBlockDefinition _EquippingBlock;
            private DestinyDefinitionsDestinyItemTranslationBlockDefinition _TranslationBlock;
            private DestinyDefinitionsDestinyItemPreviewBlockDefinition _Preview;
            private DestinyDefinitionsDestinyItemQualityBlockDefinition _Quality;
            private DestinyDefinitionsDestinyItemValueBlockDefinition _Value;
            private DestinyDefinitionsDestinyItemSourceBlockDefinition _SourceData;
            private DestinyDefinitionsDestinyItemObjectiveBlockDefinition _Objectives;
            private DestinyDefinitionsDestinyItemMetricBlockDefinition _Metrics;
            private DestinyDefinitionsItemsDestinyItemPlugDefinition _Plug;
            private DestinyDefinitionsDestinyItemGearsetBlockDefinition _Gearset;
            private DestinyDefinitionsDestinyItemSackBlockDefinition _Sack;
            private DestinyDefinitionsDestinyItemSocketBlockDefinition _Sockets;
            private DestinyDefinitionsDestinyItemSummaryBlockDefinition _Summary;
            private DestinyDefinitionsDestinyItemTalentGridBlockDefinition _TalentGrid;
            private List<DestinyDefinitionsDestinyItemInvestmentStatDefinition> _InvestmentStats;
            private List<DestinyDefinitionsDestinyItemPerkEntryDefinition> _Perks;
            private int? _LoreHash;
            private int? _SummaryItemHash;
            private List<DestinyDefinitionsAnimationsDestinyAnimationReference> _Animations;
            private bool? _AllowActions;
            private List<LinksHyperlinkReference> _Links;
            private bool? _DoesPostmasterPullHaveSideEffects;
            private bool? _NonTransferrable;
            private List<int?> _ItemCategoryHashes;
            private int? _SpecialItemType;
            private int? _ItemType;
            private int? _ItemSubType;
            private int? _ClassType;
            private int? _BreakerType;
            private int? _BreakerTypeHash;
            private bool? _Equippable;
            private List<int?> _DamageTypeHashes;
            private List<int?> _DamageTypes;
            private int? _DefaultDamageType;
            private int? _DefaultDamageTypeHash;
            private int? _SeasonHash;
            private bool? _IsWrapper;
            private List<string> _TraitIds;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyInventoryItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.TooltipNotifications property.
            /// </summary>
            /// <param name="value">Tooltips that only come up conditionally for the item. Check the live data DestinyItemComponent.tooltipNotificationIndexes property for which of these should be shown at runtime.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder TooltipNotifications(List<DestinyDefinitionsDestinyItemTooltipNotification> value)
            {
                _TooltipNotifications = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.CollectibleHash property.
            /// </summary>
            /// <param name="value">If this item has a collectible related to it, this is the hash identifier of that collectible entry.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder CollectibleHash(int? value)
            {
                _CollectibleHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SecondaryIcon property.
            /// </summary>
            /// <param name="value">A secondary icon associated with the item. Currently this is used in very context specific applications, such as Emblem Nameplates.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SecondaryIcon(string value)
            {
                _SecondaryIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SecondaryOverlay property.
            /// </summary>
            /// <param name="value">Pulled from the secondary icon, this is the \&quot;secondary background\&quot; of the secondary icon. Confusing? Sure, that&#39;s why I call it \&quot;overlay\&quot; here: because as far as it&#39;s been used thus far, it has been for an optional overlay image. We&#39;ll see if that holds up, but at least for now it explains what this image is a bit better.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SecondaryOverlay(string value)
            {
                _SecondaryOverlay = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SecondarySpecial property.
            /// </summary>
            /// <param name="value">Pulled from the Secondary Icon, this is the \&quot;special\&quot; background for the item. For Emblems, this is the background image used on the Details view: but it need not be limited to that for other types of items.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SecondarySpecial(string value)
            {
                _SecondarySpecial = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.BackgroundColor property.
            /// </summary>
            /// <param name="value">Sometimes, an item will have a background color. Most notably this occurs with Emblems, who use the Background Color for small character nameplates such as the \&quot;friends\&quot; view you see in-game. There are almost certainly other items that have background color as well, though I have not bothered to investigate what items have it nor what purposes they serve: use it as you will.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder BackgroundColor(DestinyMiscDestinyColor value)
            {
                _BackgroundColor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Screenshot property.
            /// </summary>
            /// <param name="value">If we were able to acquire an in-game screenshot for the item, the path to that screenshot will be returned here. Note that not all items have screenshots: particularly not any non-equippable items.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Screenshot(string value)
            {
                _Screenshot = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.ItemTypeDisplayName property.
            /// </summary>
            /// <param name="value">The localized title/name of the item&#39;s type. This can be whatever the designers want, and has no guarantee of consistency between items.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder ItemTypeDisplayName(string value)
            {
                _ItemTypeDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.UiItemDisplayStyle property.
            /// </summary>
            /// <param name="value">A string identifier that the game&#39;s UI uses to determine how the item should be rendered in inventory screens and the like. This could really be anything - at the moment, we don&#39;t have the time to really breakdown and maintain all the possible strings this could be, partly because new ones could be added ad hoc. But if you want to use it to dictate your own UI, or look for items with a certain display style, go for it!</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder UiItemDisplayStyle(string value)
            {
                _UiItemDisplayStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.ItemTypeAndTierDisplayName property.
            /// </summary>
            /// <param name="value">It became a common enough pattern in our UI to show Item Type and Tier combined into a single localized string that I&#39;m just going to go ahead and start pre-creating these for items.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder ItemTypeAndTierDisplayName(string value)
            {
                _ItemTypeAndTierDisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DisplaySource property.
            /// </summary>
            /// <param name="value">In theory, it is a localized string telling you about how you can find the item. I really wish this was more consistent. Many times, it has nothing. Sometimes, it&#39;s instead a more narrative-forward description of the item. Which is cool, and I wish all properties had that data, but it should really be its own property.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DisplaySource(string value)
            {
                _DisplaySource = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.TooltipStyle property.
            /// </summary>
            /// <param name="value">An identifier that the game UI uses to determine what type of tooltip to show for the item. These have no corresponding definitions that BNet can link to: so it&#39;ll be up to you to interpret and display your UI differently according to these styles (or ignore it).</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder TooltipStyle(string value)
            {
                _TooltipStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Action property.
            /// </summary>
            /// <param name="value">If the item can be \&quot;used\&quot;, this block will be non-null, and will have data related to the action performed when using the item. (Guess what? 99% of the time, this action is \&quot;dismantle\&quot;. Shocker)</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Action(DestinyDefinitionsDestinyItemActionBlockDefinition value)
            {
                _Action = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Inventory property.
            /// </summary>
            /// <param name="value">If this item can exist in an inventory, this block will be non-null. In practice, every item that currently exists has one of these blocks. But note that it is not necessarily guaranteed.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Inventory(DestinyDefinitionsDestinyItemInventoryBlockDefinition value)
            {
                _Inventory = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SetData property.
            /// </summary>
            /// <param name="value">If this item is a quest, this block will be non-null. In practice, I wish I had called this the Quest block, but at the time it wasn&#39;t clear to me whether it would end up being used for purposes other than quests. It will contain data about the steps in the quest, and mechanics we can use for displaying and tracking the quest.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SetData(DestinyDefinitionsDestinyItemSetBlockDefinition value)
            {
                _SetData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Stats property.
            /// </summary>
            /// <param name="value">If this item can have stats (such as a weapon, armor, or vehicle), this block will be non-null and populated with the stats found on the item.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Stats(DestinyDefinitionsDestinyItemStatBlockDefinition value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.EmblemObjectiveHash property.
            /// </summary>
            /// <param name="value">If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the \&quot;art channel\&quot;. When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they&#39;re being used for and how they are wired up, but for now here&#39;s the raw data.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder EmblemObjectiveHash(int? value)
            {
                _EmblemObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.EquippingBlock property.
            /// </summary>
            /// <param name="value">If this item can be equipped, this block will be non-null and will be populated with the conditions under which it can be equipped.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder EquippingBlock(DestinyDefinitionsDestinyEquippingBlockDefinition value)
            {
                _EquippingBlock = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.TranslationBlock property.
            /// </summary>
            /// <param name="value">If this item can be rendered, this block will be non-null and will be populated with rendering information.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder TranslationBlock(DestinyDefinitionsDestinyItemTranslationBlockDefinition value)
            {
                _TranslationBlock = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Preview property.
            /// </summary>
            /// <param name="value">If this item can be Used or Acquired to gain other items (for instance, how Eververse Boxes can be consumed to get items from the box), this block will be non-null and will give summary information for the items that can be acquired.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Preview(DestinyDefinitionsDestinyItemPreviewBlockDefinition value)
            {
                _Preview = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Quality property.
            /// </summary>
            /// <param name="value">If this item can have a level or stats, this block will be non-null and will be populated with default quality (item level, \&quot;quality\&quot;, and infusion) data. See the block for more details, there&#39;s often less upfront information in D2 so you&#39;ll want to be aware of how you use quality and item level on the definition level now.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Quality(DestinyDefinitionsDestinyItemQualityBlockDefinition value)
            {
                _Quality = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Value property.
            /// </summary>
            /// <param name="value">The conceptual \&quot;Value\&quot; of an item, if any was defined. See the DestinyItemValueBlockDefinition for more details.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Value(DestinyDefinitionsDestinyItemValueBlockDefinition value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SourceData property.
            /// </summary>
            /// <param name="value">If this item has a known source, this block will be non-null and populated with source information. Unfortunately, at this time we are not generating sources: that is some aggressively manual work which we didn&#39;t have time for, and I&#39;m hoping to get back to at some point in the future.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SourceData(DestinyDefinitionsDestinyItemSourceBlockDefinition value)
            {
                _SourceData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Objectives property.
            /// </summary>
            /// <param name="value">If this item has Objectives (extra tasks that can be accomplished related to the item... most frequently when the item is a Quest Step and the Objectives need to be completed to move on to the next Quest Step), this block will be non-null and the objectives defined herein.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Objectives(DestinyDefinitionsDestinyItemObjectiveBlockDefinition value)
            {
                _Objectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Metrics property.
            /// </summary>
            /// <param name="value">If this item has available metrics to be shown, this block will be non-null have the appropriate hashes defined.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Metrics(DestinyDefinitionsDestinyItemMetricBlockDefinition value)
            {
                _Metrics = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Plug property.
            /// </summary>
            /// <param name="value">If this item *is* a Plug, this will be non-null and the info defined herein. See DestinyItemPlugDefinition for more information.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Plug(DestinyDefinitionsItemsDestinyItemPlugDefinition value)
            {
                _Plug = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Gearset property.
            /// </summary>
            /// <param name="value">If this item has related items in a \&quot;Gear Set\&quot;, this will be non-null and the relationships defined herein.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Gearset(DestinyDefinitionsDestinyItemGearsetBlockDefinition value)
            {
                _Gearset = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Sack property.
            /// </summary>
            /// <param name="value">If this item is a \&quot;reward sack\&quot; that can be opened to provide other items, this will be non-null and the properties of the sack contained herein.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Sack(DestinyDefinitionsDestinyItemSackBlockDefinition value)
            {
                _Sack = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Sockets property.
            /// </summary>
            /// <param name="value">If this item has any Sockets, this will be non-null and the individual sockets on the item will be defined herein.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Sockets(DestinyDefinitionsDestinyItemSocketBlockDefinition value)
            {
                _Sockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Summary property.
            /// </summary>
            /// <param name="value">Summary data about the item.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Summary(DestinyDefinitionsDestinyItemSummaryBlockDefinition value)
            {
                _Summary = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.TalentGrid property.
            /// </summary>
            /// <param name="value">If the item has a Talent Grid, this will be non-null and the properties of the grid defined herein. Note that, while many items still have talent grids, the only ones with meaningful Nodes still on them will be Subclass/\&quot;Build\&quot; items.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder TalentGrid(DestinyDefinitionsDestinyItemTalentGridBlockDefinition value)
            {
                _TalentGrid = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.InvestmentStats property.
            /// </summary>
            /// <param name="value">If the item has stats, this block will be defined. It has the \&quot;raw\&quot; investment stats for the item. These investment stats don&#39;t take into account the ways that the items can spawn, nor do they take into account any Stat Group transformations. I have retained them for debugging purposes, but I do not know how useful people will find them.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder InvestmentStats(List<DestinyDefinitionsDestinyItemInvestmentStatDefinition> value)
            {
                _InvestmentStats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Perks property.
            /// </summary>
            /// <param name="value">If the item has any *intrinsic* Perks (Perks that it will provide regardless of Sockets, Talent Grid, and other transitory state), they will be defined here.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Perks(List<DestinyDefinitionsDestinyItemPerkEntryDefinition> value)
            {
                _Perks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.LoreHash property.
            /// </summary>
            /// <param name="value">If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder LoreHash(int? value)
            {
                _LoreHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SummaryItemHash property.
            /// </summary>
            /// <param name="value">There are times when the game will show you a \&quot;summary/vague\&quot; version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.  This happens sometimes when summarizing possible rewards in a tooltip. This is the item displayed instead, if it exists.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SummaryItemHash(int? value)
            {
                _SummaryItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Animations property.
            /// </summary>
            /// <param name="value">If any animations were extracted from game content for this item, these will be the definitions of those animations.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Animations(List<DestinyDefinitionsAnimationsDestinyAnimationReference> value)
            {
                _Animations = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.AllowActions property.
            /// </summary>
            /// <param name="value">BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder AllowActions(bool? value)
            {
                _AllowActions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Links property.
            /// </summary>
            /// <param name="value">If we added any help or informational URLs about this item, these will be those links.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Links(List<LinksHyperlinkReference> value)
            {
                _Links = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DoesPostmasterPullHaveSideEffects property.
            /// </summary>
            /// <param name="value">The boolean will indicate to us (and you!) whether something *could* happen when you transfer this item from the Postmaster that might be considered a \&quot;destructive\&quot; action.  It is not feasible currently to tell you (or ourelves!) in a consistent way whether this *will* actually cause a destructive action, so we are playing it safe: if it has the potential to do so, we will not allow it to be transferred from the Postmaster by default. You will need to check for this flag before transferring an item from the Postmaster, or else you&#39;ll end up receiving an error.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DoesPostmasterPullHaveSideEffects(bool? value)
            {
                _DoesPostmasterPullHaveSideEffects = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.NonTransferrable property.
            /// </summary>
            /// <param name="value">The intrinsic transferability of an item.  I hate that this boolean is negative - but there&#39;s a reason.  Just because an item is intrinsically transferrable doesn&#39;t mean that it can be transferred, and we don&#39;t want to imply that this is the only source of that transferability.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder NonTransferrable(bool? value)
            {
                _NonTransferrable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.ItemCategoryHashes property.
            /// </summary>
            /// <param name="value">BNet attempts to make a more formal definition of item \&quot;Categories\&quot;, as defined by DestinyItemCategoryDefinition. This is a list of all Categories that we were able to algorithmically determine that this item is a member of. (for instance, that it&#39;s a \&quot;Weapon\&quot;, that it&#39;s an \&quot;Auto Rifle\&quot;, etc...)  The algorithm for these is, unfortunately, volatile. If you believe you see a miscategorized item, please let us know on the Bungie API forums.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder ItemCategoryHashes(List<int?> value)
            {
                _ItemCategoryHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SpecialItemType property.
            /// </summary>
            /// <param name="value">In Destiny 1, we identified some items as having particular categories that we&#39;d like to know about for various internal logic purposes. These are defined in SpecialItemType, and while these days the itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SpecialItemType(int? value)
            {
                _SpecialItemType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.ItemType property.
            /// </summary>
            /// <param name="value">A value indicating the \&quot;base\&quot; the of the item. This enum is a useful but dramatic oversimplification of what it means for an item to have a \&quot;Type\&quot;. Still, it&#39;s handy in many situations.  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder ItemType(int? value)
            {
                _ItemType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.ItemSubType property.
            /// </summary>
            /// <param name="value">A value indicating the \&quot;sub-type\&quot; of the item. For instance, where an item might have an itemType value \&quot;Weapon\&quot;, this will be something more specific like \&quot;Auto Rifle\&quot;.  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder ItemSubType(int? value)
            {
                _ItemSubType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.ClassType property.
            /// </summary>
            /// <param name="value">We run a similarly weak-sauce algorithm to try and determine whether an item is restricted to a specific class. If we find it to be restricted in such a way, we set this classType property to match the class&#39; enumeration value so that users can easily identify class restricted items.  If you see a mis-classed item, please inform the developers in the Bungie API forum.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder ClassType(int? value)
            {
                _ClassType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.BreakerType property.
            /// </summary>
            /// <param name="value">Some weapons and plugs can have a \&quot;Breaker Type\&quot;: a special ability that works sort of like damage type vulnerabilities. This is (almost?) always set on items by plugs.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder BreakerType(int? value)
            {
                _BreakerType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.BreakerTypeHash property.
            /// </summary>
            /// <param name="value">Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what&#39;s cleanest for your code.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder BreakerTypeHash(int? value)
            {
                _BreakerTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Equippable property.
            /// </summary>
            /// <param name="value">If true, then you will be allowed to equip the item if you pass its other requirements.  This being false means that you cannot equip the item under any circumstances.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Equippable(bool? value)
            {
                _Equippable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DamageTypeHashes property.
            /// </summary>
            /// <param name="value">Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DamageTypeHashes(List<int?> value)
            {
                _DamageTypeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DamageTypes property.
            /// </summary>
            /// <param name="value">This is the list of all damage types that we know ahead of time the item can take on. Unfortunately, this does not preclude the possibility of something funky happening to give the item a damage type that cannot be predicted beforehand: for example, if some designer decides to create arbitrary non-reusable plugs that cause damage type to change.  This damage type prediction will only use the following to determine potential damage types:  - Intrinsic perks  - Talent Node perks  - Known, reusable plugs for sockets</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DamageTypes(List<int?> value)
            {
                _DamageTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DefaultDamageType property.
            /// </summary>
            /// <param name="value">If the item has a damage type that could be considered to be default, it will be populated here.  For various upsetting reasons, it&#39;s surprisingly cumbersome to figure this out. I hope you&#39;re happy.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DefaultDamageType(int? value)
            {
                _DefaultDamageType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.DefaultDamageTypeHash property.
            /// </summary>
            /// <param name="value">Similar to defaultDamageType, but represented as the hash identifier for a DestinyDamageTypeDefinition.  I will likely regret leaving in the enumeration versions of these properties, but for now they&#39;re very convenient.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder DefaultDamageTypeHash(int? value)
            {
                _DefaultDamageTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.SeasonHash property.
            /// </summary>
            /// <param name="value">If this item is related directly to a Season of Destiny, this is the hash identifier for that season.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder SeasonHash(int? value)
            {
                _SeasonHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.IsWrapper property.
            /// </summary>
            /// <param name="value">If true, this is a dummy vendor-wrapped item template. Items purchased from Eververse will be \&quot;wrapped\&quot; by one of these items so that we can safely provide refund capabilities before the item is \&quot;unwrapped\&quot;.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder IsWrapper(bool? value)
            {
                _IsWrapper = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">Traits are metadata tags applied to this item. For example: armor slot, weapon type, foundry, faction, etc. These IDs come from the game and don&#39;t map to any content, but should still be useful.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyInventoryItemDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyInventoryItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyInventoryItemDefinition</returns>
            public DestinyDefinitionsDestinyInventoryItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyInventoryItemDefinition(
                    DisplayProperties: _DisplayProperties,
                    TooltipNotifications: _TooltipNotifications,
                    CollectibleHash: _CollectibleHash,
                    SecondaryIcon: _SecondaryIcon,
                    SecondaryOverlay: _SecondaryOverlay,
                    SecondarySpecial: _SecondarySpecial,
                    BackgroundColor: _BackgroundColor,
                    Screenshot: _Screenshot,
                    ItemTypeDisplayName: _ItemTypeDisplayName,
                    UiItemDisplayStyle: _UiItemDisplayStyle,
                    ItemTypeAndTierDisplayName: _ItemTypeAndTierDisplayName,
                    DisplaySource: _DisplaySource,
                    TooltipStyle: _TooltipStyle,
                    Action: _Action,
                    Inventory: _Inventory,
                    SetData: _SetData,
                    Stats: _Stats,
                    EmblemObjectiveHash: _EmblemObjectiveHash,
                    EquippingBlock: _EquippingBlock,
                    TranslationBlock: _TranslationBlock,
                    Preview: _Preview,
                    Quality: _Quality,
                    Value: _Value,
                    SourceData: _SourceData,
                    Objectives: _Objectives,
                    Metrics: _Metrics,
                    Plug: _Plug,
                    Gearset: _Gearset,
                    Sack: _Sack,
                    Sockets: _Sockets,
                    Summary: _Summary,
                    TalentGrid: _TalentGrid,
                    InvestmentStats: _InvestmentStats,
                    Perks: _Perks,
                    LoreHash: _LoreHash,
                    SummaryItemHash: _SummaryItemHash,
                    Animations: _Animations,
                    AllowActions: _AllowActions,
                    Links: _Links,
                    DoesPostmasterPullHaveSideEffects: _DoesPostmasterPullHaveSideEffects,
                    NonTransferrable: _NonTransferrable,
                    ItemCategoryHashes: _ItemCategoryHashes,
                    SpecialItemType: _SpecialItemType,
                    ItemType: _ItemType,
                    ItemSubType: _ItemSubType,
                    ClassType: _ClassType,
                    BreakerType: _BreakerType,
                    BreakerTypeHash: _BreakerTypeHash,
                    Equippable: _Equippable,
                    DamageTypeHashes: _DamageTypeHashes,
                    DamageTypes: _DamageTypes,
                    DefaultDamageType: _DefaultDamageType,
                    DefaultDamageTypeHash: _DefaultDamageTypeHash,
                    SeasonHash: _SeasonHash,
                    IsWrapper: _IsWrapper,
                    TraitIds: _TraitIds,
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