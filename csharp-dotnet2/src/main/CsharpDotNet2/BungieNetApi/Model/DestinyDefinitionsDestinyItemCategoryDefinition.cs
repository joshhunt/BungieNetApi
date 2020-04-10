using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// In an attempt to categorize items by type, usage, and other interesting properties, we created DestinyItemCategoryDefinition: information about types that is assembled using a set of heuristics that examine the properties of an item such as what inventory bucket it&#39;s in, its item type name, and whether it has or is missing certain blocks of data.  This heuristic is imperfect, however. If you find an item miscategorized, let us know on the Bungie API forums!  We then populate all of the categories that we think an item belongs to in its DestinyInventoryItemDefinition.itemCategoryHashes property. You can use that to provide your own custom item filtering, sorting, aggregating... go nuts on it! And let us know if you see more categories that you wish would be added!
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemCategoryDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// If True, this category should be visible in UI. Sometimes we make categories that we don't think are interesting externally. It's up to you if you want to skip on showing them.
    /// </summary>
    /// <value>If True, this category should be visible in UI. Sometimes we make categories that we don't think are interesting externally. It's up to you if you want to skip on showing them.</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.
    /// </summary>
    /// <value>If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.</value>
    [DataMember(Name="deprecated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deprecated")]
    public bool? Deprecated { get; set; }

    /// <summary>
    /// A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn't exist for D2... yet.
    /// </summary>
    /// <value>A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn't exist for D2... yet.</value>
    [DataMember(Name="shortTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortTitle")]
    public string ShortTitle { get; set; }

    /// <summary>
    /// The janky regular expression we used against the item type to try and discern whether the item belongs to this category.
    /// </summary>
    /// <value>The janky regular expression we used against the item type to try and discern whether the item belongs to this category.</value>
    [DataMember(Name="itemTypeRegex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemTypeRegex")]
    public string ItemTypeRegex { get; set; }

    /// <summary>
    /// If the item in question has this category, it also should have this breaker type.
    /// </summary>
    /// <value>If the item in question has this category, it also should have this breaker type.</value>
    [DataMember(Name="grantDestinyBreakerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantDestinyBreakerType")]
    public int? GrantDestinyBreakerType { get; set; }

    /// <summary>
    /// If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.
    /// </summary>
    /// <value>If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.</value>
    [DataMember(Name="plugCategoryIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugCategoryIdentifier")]
    public string PlugCategoryIdentifier { get; set; }

    /// <summary>
    /// If the item type matches this janky regex, it does *not* belong to this category.
    /// </summary>
    /// <value>If the item type matches this janky regex, it does *not* belong to this category.</value>
    [DataMember(Name="itemTypeRegexNot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemTypeRegexNot")]
    public string ItemTypeRegexNot { get; set; }

    /// <summary>
    /// If the item belongs to this bucket, it does belong to this category.
    /// </summary>
    /// <value>If the item belongs to this bucket, it does belong to this category.</value>
    [DataMember(Name="originBucketIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originBucketIdentifier")]
    public string OriginBucketIdentifier { get; set; }

    /// <summary>
    /// If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that's a story that requires more alcohol.
    /// </summary>
    /// <value>If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that's a story that requires more alcohol.</value>
    [DataMember(Name="grantDestinyItemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantDestinyItemType")]
    public int? GrantDestinyItemType { get; set; }

    /// <summary>
    /// If an item belongs to this category, it will also receive this subtype enum value.  I know what you're thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \"grant\" enums. Now you can see one reason why we moved away from these enums... but they're so convenient when they work, aren't they?
    /// </summary>
    /// <value>If an item belongs to this category, it will also receive this subtype enum value.  I know what you're thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \"grant\" enums. Now you can see one reason why we moved away from these enums... but they're so convenient when they work, aren't they?</value>
    [DataMember(Name="grantDestinySubType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantDestinySubType")]
    public int? GrantDestinySubType { get; set; }

    /// <summary>
    /// If an item belongs to this category, it will also get this class restriction enum value.  See the other \"grant\"-prefixed properties on this definition for my color commentary.
    /// </summary>
    /// <value>If an item belongs to this category, it will also get this class restriction enum value.  See the other \"grant\"-prefixed properties on this definition for my color commentary.</value>
    [DataMember(Name="grantDestinyClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantDestinyClass")]
    public int? GrantDestinyClass { get; set; }

    /// <summary>
    /// The traitId that can be found on items that belong to this category.
    /// </summary>
    /// <value>The traitId that can be found on items that belong to this category.</value>
    [DataMember(Name="traitId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traitId")]
    public string TraitId { get; set; }

    /// <summary>
    /// If this category is a \"parent\" category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That's what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)
    /// </summary>
    /// <value>If this category is a \"parent\" category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That's what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)</value>
    [DataMember(Name="groupedCategoryHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupedCategoryHashes")]
    public List<int?> GroupedCategoryHashes { get; set; }

    /// <summary>
    /// All item category hashes of \"parent\" categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It's a bit redundant, but having this child-centric list speeds up some calculations.
    /// </summary>
    /// <value>All item category hashes of \"parent\" categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It's a bit redundant, but having this child-centric list speeds up some calculations.</value>
    [DataMember(Name="parentCategoryHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentCategoryHashes")]
    public List<int?> ParentCategoryHashes { get; set; }

    /// <summary>
    /// If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.
    /// </summary>
    /// <value>If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.</value>
    [DataMember(Name="groupCategoryOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupCategoryOnly")]
    public bool? GroupCategoryOnly { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyItemCategoryDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
      sb.Append("  ShortTitle: ").Append(ShortTitle).Append("\n");
      sb.Append("  ItemTypeRegex: ").Append(ItemTypeRegex).Append("\n");
      sb.Append("  GrantDestinyBreakerType: ").Append(GrantDestinyBreakerType).Append("\n");
      sb.Append("  PlugCategoryIdentifier: ").Append(PlugCategoryIdentifier).Append("\n");
      sb.Append("  ItemTypeRegexNot: ").Append(ItemTypeRegexNot).Append("\n");
      sb.Append("  OriginBucketIdentifier: ").Append(OriginBucketIdentifier).Append("\n");
      sb.Append("  GrantDestinyItemType: ").Append(GrantDestinyItemType).Append("\n");
      sb.Append("  GrantDestinySubType: ").Append(GrantDestinySubType).Append("\n");
      sb.Append("  GrantDestinyClass: ").Append(GrantDestinyClass).Append("\n");
      sb.Append("  TraitId: ").Append(TraitId).Append("\n");
      sb.Append("  GroupedCategoryHashes: ").Append(GroupedCategoryHashes).Append("\n");
      sb.Append("  ParentCategoryHashes: ").Append(ParentCategoryHashes).Append("\n");
      sb.Append("  GroupCategoryOnly: ").Append(GroupCategoryOnly).Append("\n");
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
