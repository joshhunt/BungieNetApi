using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// So much of what you see in Destiny is actually an Item used in a new and creative way. This is the definition for Items in Destiny, which started off as just entities that could exist in your Inventory but ended up being the backing data for so much more: quests, reward previews, slots, and subclasses.  In practice, you will want to associate this data with \&quot;live\&quot; item data from a Bungie.Net Platform call: these definitions describe the item in generic, non-instanced terms: but an actual instance of an item can vary widely from these generic definitions.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyInventoryItemDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Tooltips that only come up conditionally for the item. Check the live data DestinyItemComponent.tooltipNotificationIndexes property for which of these should be shown at runtime.
    /// </summary>
    /// <value>Tooltips that only come up conditionally for the item. Check the live data DestinyItemComponent.tooltipNotificationIndexes property for which of these should be shown at runtime.</value>
    [DataMember(Name="tooltipNotifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tooltipNotifications")]
    public List<DestinyDefinitionsDestinyItemTooltipNotification> TooltipNotifications { get; set; }

    /// <summary>
    /// If this item has a collectible related to it, this is the hash identifier of that collectible entry.
    /// </summary>
    /// <value>If this item has a collectible related to it, this is the hash identifier of that collectible entry.</value>
    [DataMember(Name="collectibleHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectibleHash")]
    public int? CollectibleHash { get; set; }

    /// <summary>
    /// A secondary icon associated with the item. Currently this is used in very context specific applications, such as Emblem Nameplates.
    /// </summary>
    /// <value>A secondary icon associated with the item. Currently this is used in very context specific applications, such as Emblem Nameplates.</value>
    [DataMember(Name="secondaryIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondaryIcon")]
    public string SecondaryIcon { get; set; }

    /// <summary>
    /// Pulled from the secondary icon, this is the \"secondary background\" of the secondary icon. Confusing? Sure, that's why I call it \"overlay\" here: because as far as it's been used thus far, it has been for an optional overlay image. We'll see if that holds up, but at least for now it explains what this image is a bit better.
    /// </summary>
    /// <value>Pulled from the secondary icon, this is the \"secondary background\" of the secondary icon. Confusing? Sure, that's why I call it \"overlay\" here: because as far as it's been used thus far, it has been for an optional overlay image. We'll see if that holds up, but at least for now it explains what this image is a bit better.</value>
    [DataMember(Name="secondaryOverlay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondaryOverlay")]
    public string SecondaryOverlay { get; set; }

    /// <summary>
    /// Pulled from the Secondary Icon, this is the \"special\" background for the item. For Emblems, this is the background image used on the Details view: but it need not be limited to that for other types of items.
    /// </summary>
    /// <value>Pulled from the Secondary Icon, this is the \"special\" background for the item. For Emblems, this is the background image used on the Details view: but it need not be limited to that for other types of items.</value>
    [DataMember(Name="secondarySpecial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondarySpecial")]
    public string SecondarySpecial { get; set; }

    /// <summary>
    /// Sometimes, an item will have a background color. Most notably this occurs with Emblems, who use the Background Color for small character nameplates such as the \"friends\" view you see in-game. There are almost certainly other items that have background color as well, though I have not bothered to investigate what items have it nor what purposes they serve: use it as you will.
    /// </summary>
    /// <value>Sometimes, an item will have a background color. Most notably this occurs with Emblems, who use the Background Color for small character nameplates such as the \"friends\" view you see in-game. There are almost certainly other items that have background color as well, though I have not bothered to investigate what items have it nor what purposes they serve: use it as you will.</value>
    [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundColor")]
    public DestinyMiscDestinyColor BackgroundColor { get; set; }

    /// <summary>
    /// If we were able to acquire an in-game screenshot for the item, the path to that screenshot will be returned here. Note that not all items have screenshots: particularly not any non-equippable items.
    /// </summary>
    /// <value>If we were able to acquire an in-game screenshot for the item, the path to that screenshot will be returned here. Note that not all items have screenshots: particularly not any non-equippable items.</value>
    [DataMember(Name="screenshot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screenshot")]
    public string Screenshot { get; set; }

    /// <summary>
    /// The localized title/name of the item's type. This can be whatever the designers want, and has no guarantee of consistency between items.
    /// </summary>
    /// <value>The localized title/name of the item's type. This can be whatever the designers want, and has no guarantee of consistency between items.</value>
    [DataMember(Name="itemTypeDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemTypeDisplayName")]
    public string ItemTypeDisplayName { get; set; }

    /// <summary>
    /// A string identifier that the game's UI uses to determine how the item should be rendered in inventory screens and the like. This could really be anything - at the moment, we don't have the time to really breakdown and maintain all the possible strings this could be, partly because new ones could be added ad hoc. But if you want to use it to dictate your own UI, or look for items with a certain display style, go for it!
    /// </summary>
    /// <value>A string identifier that the game's UI uses to determine how the item should be rendered in inventory screens and the like. This could really be anything - at the moment, we don't have the time to really breakdown and maintain all the possible strings this could be, partly because new ones could be added ad hoc. But if you want to use it to dictate your own UI, or look for items with a certain display style, go for it!</value>
    [DataMember(Name="uiItemDisplayStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uiItemDisplayStyle")]
    public string UiItemDisplayStyle { get; set; }

    /// <summary>
    /// It became a common enough pattern in our UI to show Item Type and Tier combined into a single localized string that I'm just going to go ahead and start pre-creating these for items.
    /// </summary>
    /// <value>It became a common enough pattern in our UI to show Item Type and Tier combined into a single localized string that I'm just going to go ahead and start pre-creating these for items.</value>
    [DataMember(Name="itemTypeAndTierDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemTypeAndTierDisplayName")]
    public string ItemTypeAndTierDisplayName { get; set; }

    /// <summary>
    /// In theory, it is a localized string telling you about how you can find the item. I really wish this was more consistent. Many times, it has nothing. Sometimes, it's instead a more narrative-forward description of the item. Which is cool, and I wish all properties had that data, but it should really be its own property.
    /// </summary>
    /// <value>In theory, it is a localized string telling you about how you can find the item. I really wish this was more consistent. Many times, it has nothing. Sometimes, it's instead a more narrative-forward description of the item. Which is cool, and I wish all properties had that data, but it should really be its own property.</value>
    [DataMember(Name="displaySource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displaySource")]
    public string DisplaySource { get; set; }

    /// <summary>
    /// An identifier that the game UI uses to determine what type of tooltip to show for the item. These have no corresponding definitions that BNet can link to: so it'll be up to you to interpret and display your UI differently according to these styles (or ignore it).
    /// </summary>
    /// <value>An identifier that the game UI uses to determine what type of tooltip to show for the item. These have no corresponding definitions that BNet can link to: so it'll be up to you to interpret and display your UI differently according to these styles (or ignore it).</value>
    [DataMember(Name="tooltipStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tooltipStyle")]
    public string TooltipStyle { get; set; }

    /// <summary>
    /// If the item can be \"used\", this block will be non-null, and will have data related to the action performed when using the item. (Guess what? 99% of the time, this action is \"dismantle\". Shocker)
    /// </summary>
    /// <value>If the item can be \"used\", this block will be non-null, and will have data related to the action performed when using the item. (Guess what? 99% of the time, this action is \"dismantle\". Shocker)</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public DestinyDefinitionsDestinyItemActionBlockDefinition Action { get; set; }

    /// <summary>
    /// If this item can exist in an inventory, this block will be non-null. In practice, every item that currently exists has one of these blocks. But note that it is not necessarily guaranteed.
    /// </summary>
    /// <value>If this item can exist in an inventory, this block will be non-null. In practice, every item that currently exists has one of these blocks. But note that it is not necessarily guaranteed.</value>
    [DataMember(Name="inventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory")]
    public DestinyDefinitionsDestinyItemInventoryBlockDefinition Inventory { get; set; }

    /// <summary>
    /// If this item is a quest, this block will be non-null. In practice, I wish I had called this the Quest block, but at the time it wasn't clear to me whether it would end up being used for purposes other than quests. It will contain data about the steps in the quest, and mechanics we can use for displaying and tracking the quest.
    /// </summary>
    /// <value>If this item is a quest, this block will be non-null. In practice, I wish I had called this the Quest block, but at the time it wasn't clear to me whether it would end up being used for purposes other than quests. It will contain data about the steps in the quest, and mechanics we can use for displaying and tracking the quest.</value>
    [DataMember(Name="setData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setData")]
    public DestinyDefinitionsDestinyItemSetBlockDefinition SetData { get; set; }

    /// <summary>
    /// If this item can have stats (such as a weapon, armor, or vehicle), this block will be non-null and populated with the stats found on the item.
    /// </summary>
    /// <value>If this item can have stats (such as a weapon, armor, or vehicle), this block will be non-null and populated with the stats found on the item.</value>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public DestinyDefinitionsDestinyItemStatBlockDefinition Stats { get; set; }

    /// <summary>
    /// If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the \"art channel\". When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they're being used for and how they are wired up, but for now here's the raw data.
    /// </summary>
    /// <value>If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the \"art channel\". When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they're being used for and how they are wired up, but for now here's the raw data.</value>
    [DataMember(Name="emblemObjectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emblemObjectiveHash")]
    public int? EmblemObjectiveHash { get; set; }

    /// <summary>
    /// If this item can be equipped, this block will be non-null and will be populated with the conditions under which it can be equipped.
    /// </summary>
    /// <value>If this item can be equipped, this block will be non-null and will be populated with the conditions under which it can be equipped.</value>
    [DataMember(Name="equippingBlock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equippingBlock")]
    public DestinyDefinitionsDestinyEquippingBlockDefinition EquippingBlock { get; set; }

    /// <summary>
    /// If this item can be rendered, this block will be non-null and will be populated with rendering information.
    /// </summary>
    /// <value>If this item can be rendered, this block will be non-null and will be populated with rendering information.</value>
    [DataMember(Name="translationBlock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translationBlock")]
    public DestinyDefinitionsDestinyItemTranslationBlockDefinition TranslationBlock { get; set; }

    /// <summary>
    /// If this item can be Used or Acquired to gain other items (for instance, how Eververse Boxes can be consumed to get items from the box), this block will be non-null and will give summary information for the items that can be acquired.
    /// </summary>
    /// <value>If this item can be Used or Acquired to gain other items (for instance, how Eververse Boxes can be consumed to get items from the box), this block will be non-null and will give summary information for the items that can be acquired.</value>
    [DataMember(Name="preview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preview")]
    public DestinyDefinitionsDestinyItemPreviewBlockDefinition Preview { get; set; }

    /// <summary>
    /// If this item can have a level or stats, this block will be non-null and will be populated with default quality (item level, \"quality\", and infusion) data. See the block for more details, there's often less upfront information in D2 so you'll want to be aware of how you use quality and item level on the definition level now.
    /// </summary>
    /// <value>If this item can have a level or stats, this block will be non-null and will be populated with default quality (item level, \"quality\", and infusion) data. See the block for more details, there's often less upfront information in D2 so you'll want to be aware of how you use quality and item level on the definition level now.</value>
    [DataMember(Name="quality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quality")]
    public DestinyDefinitionsDestinyItemQualityBlockDefinition Quality { get; set; }

    /// <summary>
    /// The conceptual \"Value\" of an item, if any was defined. See the DestinyItemValueBlockDefinition for more details.
    /// </summary>
    /// <value>The conceptual \"Value\" of an item, if any was defined. See the DestinyItemValueBlockDefinition for more details.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public DestinyDefinitionsDestinyItemValueBlockDefinition Value { get; set; }

    /// <summary>
    /// If this item has a known source, this block will be non-null and populated with source information. Unfortunately, at this time we are not generating sources: that is some aggressively manual work which we didn't have time for, and I'm hoping to get back to at some point in the future.
    /// </summary>
    /// <value>If this item has a known source, this block will be non-null and populated with source information. Unfortunately, at this time we are not generating sources: that is some aggressively manual work which we didn't have time for, and I'm hoping to get back to at some point in the future.</value>
    [DataMember(Name="sourceData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceData")]
    public DestinyDefinitionsDestinyItemSourceBlockDefinition SourceData { get; set; }

    /// <summary>
    /// If this item has Objectives (extra tasks that can be accomplished related to the item... most frequently when the item is a Quest Step and the Objectives need to be completed to move on to the next Quest Step), this block will be non-null and the objectives defined herein.
    /// </summary>
    /// <value>If this item has Objectives (extra tasks that can be accomplished related to the item... most frequently when the item is a Quest Step and the Objectives need to be completed to move on to the next Quest Step), this block will be non-null and the objectives defined herein.</value>
    [DataMember(Name="objectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectives")]
    public DestinyDefinitionsDestinyItemObjectiveBlockDefinition Objectives { get; set; }

    /// <summary>
    /// If this item has available metrics to be shown, this block will be non-null have the appropriate hashes defined.
    /// </summary>
    /// <value>If this item has available metrics to be shown, this block will be non-null have the appropriate hashes defined.</value>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public DestinyDefinitionsDestinyItemMetricBlockDefinition Metrics { get; set; }

    /// <summary>
    /// If this item *is* a Plug, this will be non-null and the info defined herein. See DestinyItemPlugDefinition for more information.
    /// </summary>
    /// <value>If this item *is* a Plug, this will be non-null and the info defined herein. See DestinyItemPlugDefinition for more information.</value>
    [DataMember(Name="plug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plug")]
    public DestinyDefinitionsItemsDestinyItemPlugDefinition Plug { get; set; }

    /// <summary>
    /// If this item has related items in a \"Gear Set\", this will be non-null and the relationships defined herein.
    /// </summary>
    /// <value>If this item has related items in a \"Gear Set\", this will be non-null and the relationships defined herein.</value>
    [DataMember(Name="gearset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gearset")]
    public DestinyDefinitionsDestinyItemGearsetBlockDefinition Gearset { get; set; }

    /// <summary>
    /// If this item is a \"reward sack\" that can be opened to provide other items, this will be non-null and the properties of the sack contained herein.
    /// </summary>
    /// <value>If this item is a \"reward sack\" that can be opened to provide other items, this will be non-null and the properties of the sack contained herein.</value>
    [DataMember(Name="sack", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sack")]
    public DestinyDefinitionsDestinyItemSackBlockDefinition Sack { get; set; }

    /// <summary>
    /// If this item has any Sockets, this will be non-null and the individual sockets on the item will be defined herein.
    /// </summary>
    /// <value>If this item has any Sockets, this will be non-null and the individual sockets on the item will be defined herein.</value>
    [DataMember(Name="sockets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sockets")]
    public DestinyDefinitionsDestinyItemSocketBlockDefinition Sockets { get; set; }

    /// <summary>
    /// Summary data about the item.
    /// </summary>
    /// <value>Summary data about the item.</value>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public DestinyDefinitionsDestinyItemSummaryBlockDefinition Summary { get; set; }

    /// <summary>
    /// If the item has a Talent Grid, this will be non-null and the properties of the grid defined herein. Note that, while many items still have talent grids, the only ones with meaningful Nodes still on them will be Subclass/\"Build\" items.
    /// </summary>
    /// <value>If the item has a Talent Grid, this will be non-null and the properties of the grid defined herein. Note that, while many items still have talent grids, the only ones with meaningful Nodes still on them will be Subclass/\"Build\" items.</value>
    [DataMember(Name="talentGrid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "talentGrid")]
    public DestinyDefinitionsDestinyItemTalentGridBlockDefinition TalentGrid { get; set; }

    /// <summary>
    /// If the item has stats, this block will be defined. It has the \"raw\" investment stats for the item. These investment stats don't take into account the ways that the items can spawn, nor do they take into account any Stat Group transformations. I have retained them for debugging purposes, but I do not know how useful people will find them.
    /// </summary>
    /// <value>If the item has stats, this block will be defined. It has the \"raw\" investment stats for the item. These investment stats don't take into account the ways that the items can spawn, nor do they take into account any Stat Group transformations. I have retained them for debugging purposes, but I do not know how useful people will find them.</value>
    [DataMember(Name="investmentStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "investmentStats")]
    public List<DestinyDefinitionsDestinyItemInvestmentStatDefinition> InvestmentStats { get; set; }

    /// <summary>
    /// If the item has any *intrinsic* Perks (Perks that it will provide regardless of Sockets, Talent Grid, and other transitory state), they will be defined here.
    /// </summary>
    /// <value>If the item has any *intrinsic* Perks (Perks that it will provide regardless of Sockets, Talent Grid, and other transitory state), they will be defined here.</value>
    [DataMember(Name="perks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perks")]
    public List<DestinyDefinitionsDestinyItemPerkEntryDefinition> Perks { get; set; }

    /// <summary>
    /// If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.
    /// </summary>
    /// <value>If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.</value>
    [DataMember(Name="loreHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loreHash")]
    public int? LoreHash { get; set; }

    /// <summary>
    /// There are times when the game will show you a \"summary/vague\" version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.  This happens sometimes when summarizing possible rewards in a tooltip. This is the item displayed instead, if it exists.
    /// </summary>
    /// <value>There are times when the game will show you a \"summary/vague\" version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.  This happens sometimes when summarizing possible rewards in a tooltip. This is the item displayed instead, if it exists.</value>
    [DataMember(Name="summaryItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summaryItemHash")]
    public int? SummaryItemHash { get; set; }

    /// <summary>
    /// If any animations were extracted from game content for this item, these will be the definitions of those animations.
    /// </summary>
    /// <value>If any animations were extracted from game content for this item, these will be the definitions of those animations.</value>
    [DataMember(Name="animations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animations")]
    public List<DestinyDefinitionsAnimationsDestinyAnimationReference> Animations { get; set; }

    /// <summary>
    /// BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.
    /// </summary>
    /// <value>BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.</value>
    [DataMember(Name="allowActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowActions")]
    public bool? AllowActions { get; set; }

    /// <summary>
    /// If we added any help or informational URLs about this item, these will be those links.
    /// </summary>
    /// <value>If we added any help or informational URLs about this item, these will be those links.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public List<LinksHyperlinkReference> Links { get; set; }

    /// <summary>
    /// The boolean will indicate to us (and you!) whether something *could* happen when you transfer this item from the Postmaster that might be considered a \"destructive\" action.  It is not feasible currently to tell you (or ourelves!) in a consistent way whether this *will* actually cause a destructive action, so we are playing it safe: if it has the potential to do so, we will not allow it to be transferred from the Postmaster by default. You will need to check for this flag before transferring an item from the Postmaster, or else you'll end up receiving an error.
    /// </summary>
    /// <value>The boolean will indicate to us (and you!) whether something *could* happen when you transfer this item from the Postmaster that might be considered a \"destructive\" action.  It is not feasible currently to tell you (or ourelves!) in a consistent way whether this *will* actually cause a destructive action, so we are playing it safe: if it has the potential to do so, we will not allow it to be transferred from the Postmaster by default. You will need to check for this flag before transferring an item from the Postmaster, or else you'll end up receiving an error.</value>
    [DataMember(Name="doesPostmasterPullHaveSideEffects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "doesPostmasterPullHaveSideEffects")]
    public bool? DoesPostmasterPullHaveSideEffects { get; set; }

    /// <summary>
    /// The intrinsic transferability of an item.  I hate that this boolean is negative - but there's a reason.  Just because an item is intrinsically transferrable doesn't mean that it can be transferred, and we don't want to imply that this is the only source of that transferability.
    /// </summary>
    /// <value>The intrinsic transferability of an item.  I hate that this boolean is negative - but there's a reason.  Just because an item is intrinsically transferrable doesn't mean that it can be transferred, and we don't want to imply that this is the only source of that transferability.</value>
    [DataMember(Name="nonTransferrable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonTransferrable")]
    public bool? NonTransferrable { get; set; }

    /// <summary>
    /// BNet attempts to make a more formal definition of item \"Categories\", as defined by DestinyItemCategoryDefinition. This is a list of all Categories that we were able to algorithmically determine that this item is a member of. (for instance, that it's a \"Weapon\", that it's an \"Auto Rifle\", etc...)  The algorithm for these is, unfortunately, volatile. If you believe you see a miscategorized item, please let us know on the Bungie API forums.
    /// </summary>
    /// <value>BNet attempts to make a more formal definition of item \"Categories\", as defined by DestinyItemCategoryDefinition. This is a list of all Categories that we were able to algorithmically determine that this item is a member of. (for instance, that it's a \"Weapon\", that it's an \"Auto Rifle\", etc...)  The algorithm for these is, unfortunately, volatile. If you believe you see a miscategorized item, please let us know on the Bungie API forums.</value>
    [DataMember(Name="itemCategoryHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemCategoryHashes")]
    public List<int?> ItemCategoryHashes { get; set; }

    /// <summary>
    /// In Destiny 1, we identified some items as having particular categories that we'd like to know about for various internal logic purposes. These are defined in SpecialItemType, and while these days the itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
    /// </summary>
    /// <value>In Destiny 1, we identified some items as having particular categories that we'd like to know about for various internal logic purposes. These are defined in SpecialItemType, and while these days the itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.</value>
    [DataMember(Name="specialItemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specialItemType")]
    public int? SpecialItemType { get; set; }

    /// <summary>
    /// A value indicating the \"base\" the of the item. This enum is a useful but dramatic oversimplification of what it means for an item to have a \"Type\". Still, it's handy in many situations.  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
    /// </summary>
    /// <value>A value indicating the \"base\" the of the item. This enum is a useful but dramatic oversimplification of what it means for an item to have a \"Type\". Still, it's handy in many situations.  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.</value>
    [DataMember(Name="itemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemType")]
    public int? ItemType { get; set; }

    /// <summary>
    /// A value indicating the \"sub-type\" of the item. For instance, where an item might have an itemType value \"Weapon\", this will be something more specific like \"Auto Rifle\".  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
    /// </summary>
    /// <value>A value indicating the \"sub-type\" of the item. For instance, where an item might have an itemType value \"Weapon\", this will be something more specific like \"Auto Rifle\".  itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.</value>
    [DataMember(Name="itemSubType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemSubType")]
    public int? ItemSubType { get; set; }

    /// <summary>
    /// We run a similarly weak-sauce algorithm to try and determine whether an item is restricted to a specific class. If we find it to be restricted in such a way, we set this classType property to match the class' enumeration value so that users can easily identify class restricted items.  If you see a mis-classed item, please inform the developers in the Bungie API forum.
    /// </summary>
    /// <value>We run a similarly weak-sauce algorithm to try and determine whether an item is restricted to a specific class. If we find it to be restricted in such a way, we set this classType property to match the class' enumeration value so that users can easily identify class restricted items.  If you see a mis-classed item, please inform the developers in the Bungie API forum.</value>
    [DataMember(Name="classType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classType")]
    public int? ClassType { get; set; }

    /// <summary>
    /// Some weapons and plugs can have a \"Breaker Type\": a special ability that works sort of like damage type vulnerabilities. This is (almost?) always set on items by plugs.
    /// </summary>
    /// <value>Some weapons and plugs can have a \"Breaker Type\": a special ability that works sort of like damage type vulnerabilities. This is (almost?) always set on items by plugs.</value>
    [DataMember(Name="breakerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "breakerType")]
    public int? BreakerType { get; set; }

    /// <summary>
    /// Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what's cleanest for your code.
    /// </summary>
    /// <value>Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what's cleanest for your code.</value>
    [DataMember(Name="breakerTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "breakerTypeHash")]
    public int? BreakerTypeHash { get; set; }

    /// <summary>
    /// If true, then you will be allowed to equip the item if you pass its other requirements.  This being false means that you cannot equip the item under any circumstances.
    /// </summary>
    /// <value>If true, then you will be allowed to equip the item if you pass its other requirements.  This being false means that you cannot equip the item under any circumstances.</value>
    [DataMember(Name="equippable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equippable")]
    public bool? Equippable { get; set; }

    /// <summary>
    /// Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.
    /// </summary>
    /// <value>Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.</value>
    [DataMember(Name="damageTypeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageTypeHashes")]
    public List<int?> DamageTypeHashes { get; set; }

    /// <summary>
    /// This is the list of all damage types that we know ahead of time the item can take on. Unfortunately, this does not preclude the possibility of something funky happening to give the item a damage type that cannot be predicted beforehand: for example, if some designer decides to create arbitrary non-reusable plugs that cause damage type to change.  This damage type prediction will only use the following to determine potential damage types:  - Intrinsic perks  - Talent Node perks  - Known, reusable plugs for sockets
    /// </summary>
    /// <value>This is the list of all damage types that we know ahead of time the item can take on. Unfortunately, this does not preclude the possibility of something funky happening to give the item a damage type that cannot be predicted beforehand: for example, if some designer decides to create arbitrary non-reusable plugs that cause damage type to change.  This damage type prediction will only use the following to determine potential damage types:  - Intrinsic perks  - Talent Node perks  - Known, reusable plugs for sockets</value>
    [DataMember(Name="damageTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageTypes")]
    public List<int?> DamageTypes { get; set; }

    /// <summary>
    /// If the item has a damage type that could be considered to be default, it will be populated here.  For various upsetting reasons, it's surprisingly cumbersome to figure this out. I hope you're happy.
    /// </summary>
    /// <value>If the item has a damage type that could be considered to be default, it will be populated here.  For various upsetting reasons, it's surprisingly cumbersome to figure this out. I hope you're happy.</value>
    [DataMember(Name="defaultDamageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultDamageType")]
    public int? DefaultDamageType { get; set; }

    /// <summary>
    /// Similar to defaultDamageType, but represented as the hash identifier for a DestinyDamageTypeDefinition.  I will likely regret leaving in the enumeration versions of these properties, but for now they're very convenient.
    /// </summary>
    /// <value>Similar to defaultDamageType, but represented as the hash identifier for a DestinyDamageTypeDefinition.  I will likely regret leaving in the enumeration versions of these properties, but for now they're very convenient.</value>
    [DataMember(Name="defaultDamageTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultDamageTypeHash")]
    public int? DefaultDamageTypeHash { get; set; }

    /// <summary>
    /// If this item is related directly to a Season of Destiny, this is the hash identifier for that season.
    /// </summary>
    /// <value>If this item is related directly to a Season of Destiny, this is the hash identifier for that season.</value>
    [DataMember(Name="seasonHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonHash")]
    public int? SeasonHash { get; set; }

    /// <summary>
    /// If true, this is a dummy vendor-wrapped item template. Items purchased from Eververse will be \"wrapped\" by one of these items so that we can safely provide refund capabilities before the item is \"unwrapped\".
    /// </summary>
    /// <value>If true, this is a dummy vendor-wrapped item template. Items purchased from Eververse will be \"wrapped\" by one of these items so that we can safely provide refund capabilities before the item is \"unwrapped\".</value>
    [DataMember(Name="isWrapper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isWrapper")]
    public bool? IsWrapper { get; set; }

    /// <summary>
    /// Traits are metadata tags applied to this item. For example: armor slot, weapon type, foundry, faction, etc. These IDs come from the game and don't map to any content, but should still be useful.
    /// </summary>
    /// <value>Traits are metadata tags applied to this item. For example: armor slot, weapon type, foundry, faction, etc. These IDs come from the game and don't map to any content, but should still be useful.</value>
    [DataMember(Name="traitIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traitIds")]
    public List<string> TraitIds { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyInventoryItemDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  TooltipNotifications: ").Append(TooltipNotifications).Append("\n");
      sb.Append("  CollectibleHash: ").Append(CollectibleHash).Append("\n");
      sb.Append("  SecondaryIcon: ").Append(SecondaryIcon).Append("\n");
      sb.Append("  SecondaryOverlay: ").Append(SecondaryOverlay).Append("\n");
      sb.Append("  SecondarySpecial: ").Append(SecondarySpecial).Append("\n");
      sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
      sb.Append("  Screenshot: ").Append(Screenshot).Append("\n");
      sb.Append("  ItemTypeDisplayName: ").Append(ItemTypeDisplayName).Append("\n");
      sb.Append("  UiItemDisplayStyle: ").Append(UiItemDisplayStyle).Append("\n");
      sb.Append("  ItemTypeAndTierDisplayName: ").Append(ItemTypeAndTierDisplayName).Append("\n");
      sb.Append("  DisplaySource: ").Append(DisplaySource).Append("\n");
      sb.Append("  TooltipStyle: ").Append(TooltipStyle).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Inventory: ").Append(Inventory).Append("\n");
      sb.Append("  SetData: ").Append(SetData).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  EmblemObjectiveHash: ").Append(EmblemObjectiveHash).Append("\n");
      sb.Append("  EquippingBlock: ").Append(EquippingBlock).Append("\n");
      sb.Append("  TranslationBlock: ").Append(TranslationBlock).Append("\n");
      sb.Append("  Preview: ").Append(Preview).Append("\n");
      sb.Append("  Quality: ").Append(Quality).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  SourceData: ").Append(SourceData).Append("\n");
      sb.Append("  Objectives: ").Append(Objectives).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  Plug: ").Append(Plug).Append("\n");
      sb.Append("  Gearset: ").Append(Gearset).Append("\n");
      sb.Append("  Sack: ").Append(Sack).Append("\n");
      sb.Append("  Sockets: ").Append(Sockets).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  TalentGrid: ").Append(TalentGrid).Append("\n");
      sb.Append("  InvestmentStats: ").Append(InvestmentStats).Append("\n");
      sb.Append("  Perks: ").Append(Perks).Append("\n");
      sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
      sb.Append("  SummaryItemHash: ").Append(SummaryItemHash).Append("\n");
      sb.Append("  Animations: ").Append(Animations).Append("\n");
      sb.Append("  AllowActions: ").Append(AllowActions).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  DoesPostmasterPullHaveSideEffects: ").Append(DoesPostmasterPullHaveSideEffects).Append("\n");
      sb.Append("  NonTransferrable: ").Append(NonTransferrable).Append("\n");
      sb.Append("  ItemCategoryHashes: ").Append(ItemCategoryHashes).Append("\n");
      sb.Append("  SpecialItemType: ").Append(SpecialItemType).Append("\n");
      sb.Append("  ItemType: ").Append(ItemType).Append("\n");
      sb.Append("  ItemSubType: ").Append(ItemSubType).Append("\n");
      sb.Append("  ClassType: ").Append(ClassType).Append("\n");
      sb.Append("  BreakerType: ").Append(BreakerType).Append("\n");
      sb.Append("  BreakerTypeHash: ").Append(BreakerTypeHash).Append("\n");
      sb.Append("  Equippable: ").Append(Equippable).Append("\n");
      sb.Append("  DamageTypeHashes: ").Append(DamageTypeHashes).Append("\n");
      sb.Append("  DamageTypes: ").Append(DamageTypes).Append("\n");
      sb.Append("  DefaultDamageType: ").Append(DefaultDamageType).Append("\n");
      sb.Append("  DefaultDamageTypeHash: ").Append(DefaultDamageTypeHash).Append("\n");
      sb.Append("  SeasonHash: ").Append(SeasonHash).Append("\n");
      sb.Append("  IsWrapper: ").Append(IsWrapper).Append("\n");
      sb.Append("  TraitIds: ").Append(TraitIds).Append("\n");
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
