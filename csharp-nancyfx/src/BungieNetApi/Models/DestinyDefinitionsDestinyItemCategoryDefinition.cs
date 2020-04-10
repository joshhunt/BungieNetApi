using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// In an attempt to categorize items by type, usage, and other interesting properties, we created DestinyItemCategoryDefinition: information about types that is assembled using a set of heuristics that examine the properties of an item such as what inventory bucket it&#39;s in, its item type name, and whether it has or is missing certain blocks of data.  This heuristic is imperfect, however. If you find an item miscategorized, let us know on the Bungie API forums!  We then populate all of the categories that we think an item belongs to in its DestinyInventoryItemDefinition.itemCategoryHashes property. You can use that to provide your own custom item filtering, sorting, aggregating... go nuts on it! And let us know if you see more categories that you wish would be added!
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemCategoryDefinition:  IEquatable<DestinyDefinitionsDestinyItemCategoryDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them.
        /// </summary>
        public bool? Visible { get; private set; }

        /// <summary>
        /// If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.
        /// </summary>
        public bool? Deprecated { get; private set; }

        /// <summary>
        /// A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet.
        /// </summary>
        public string ShortTitle { get; private set; }

        /// <summary>
        /// The janky regular expression we used against the item type to try and discern whether the item belongs to this category.
        /// </summary>
        public string ItemTypeRegex { get; private set; }

        /// <summary>
        /// If the item in question has this category, it also should have this breaker type.
        /// </summary>
        public int? GrantDestinyBreakerType { get; private set; }

        /// <summary>
        /// If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.
        /// </summary>
        public string PlugCategoryIdentifier { get; private set; }

        /// <summary>
        /// If the item type matches this janky regex, it does *not* belong to this category.
        /// </summary>
        public string ItemTypeRegexNot { get; private set; }

        /// <summary>
        /// If the item belongs to this bucket, it does belong to this category.
        /// </summary>
        public string OriginBucketIdentifier { get; private set; }

        /// <summary>
        /// If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol.
        /// </summary>
        public int? GrantDestinyItemType { get; private set; }

        /// <summary>
        /// If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?
        /// </summary>
        public int? GrantDestinySubType { get; private set; }

        /// <summary>
        /// If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary.
        /// </summary>
        public int? GrantDestinyClass { get; private set; }

        /// <summary>
        /// The traitId that can be found on items that belong to this category.
        /// </summary>
        public string TraitId { get; private set; }

        /// <summary>
        /// If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)
        /// </summary>
        public List<int?> GroupedCategoryHashes { get; private set; }

        /// <summary>
        /// All item category hashes of \&quot;parent\&quot; categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It&#39;s a bit redundant, but having this child-centric list speeds up some calculations.
        /// </summary>
        public List<int?> ParentCategoryHashes { get; private set; }

        /// <summary>
        /// If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.
        /// </summary>
        public bool? GroupCategoryOnly { get; private set; }

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
        /// Use DestinyDefinitionsDestinyItemCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemCategoryDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemCategoryDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, bool? Visible, bool? Deprecated, string ShortTitle, string ItemTypeRegex, int? GrantDestinyBreakerType, string PlugCategoryIdentifier, string ItemTypeRegexNot, string OriginBucketIdentifier, int? GrantDestinyItemType, int? GrantDestinySubType, int? GrantDestinyClass, string TraitId, List<int?> GroupedCategoryHashes, List<int?> ParentCategoryHashes, bool? GroupCategoryOnly, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Visible = Visible;
            
            this.Deprecated = Deprecated;
            
            this.ShortTitle = ShortTitle;
            
            this.ItemTypeRegex = ItemTypeRegex;
            
            this.GrantDestinyBreakerType = GrantDestinyBreakerType;
            
            this.PlugCategoryIdentifier = PlugCategoryIdentifier;
            
            this.ItemTypeRegexNot = ItemTypeRegexNot;
            
            this.OriginBucketIdentifier = OriginBucketIdentifier;
            
            this.GrantDestinyItemType = GrantDestinyItemType;
            
            this.GrantDestinySubType = GrantDestinySubType;
            
            this.GrantDestinyClass = GrantDestinyClass;
            
            this.TraitId = TraitId;
            
            this.GroupedCategoryHashes = GroupedCategoryHashes;
            
            this.ParentCategoryHashes = ParentCategoryHashes;
            
            this.GroupCategoryOnly = GroupCategoryOnly;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Visible(Visible)
                .Deprecated(Deprecated)
                .ShortTitle(ShortTitle)
                .ItemTypeRegex(ItemTypeRegex)
                .GrantDestinyBreakerType(GrantDestinyBreakerType)
                .PlugCategoryIdentifier(PlugCategoryIdentifier)
                .ItemTypeRegexNot(ItemTypeRegexNot)
                .OriginBucketIdentifier(OriginBucketIdentifier)
                .GrantDestinyItemType(GrantDestinyItemType)
                .GrantDestinySubType(GrantDestinySubType)
                .GrantDestinyClass(GrantDestinyClass)
                .TraitId(TraitId)
                .GroupedCategoryHashes(GroupedCategoryHashes)
                .ParentCategoryHashes(ParentCategoryHashes)
                .GroupCategoryOnly(GroupCategoryOnly)
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

        public bool Equals(DestinyDefinitionsDestinyItemCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemCategoryDefinition left, DestinyDefinitionsDestinyItemCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemCategoryDefinition left, DestinyDefinitionsDestinyItemCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemCategoryDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private bool? _Visible;
            private bool? _Deprecated;
            private string _ShortTitle;
            private string _ItemTypeRegex;
            private int? _GrantDestinyBreakerType;
            private string _PlugCategoryIdentifier;
            private string _ItemTypeRegexNot;
            private string _OriginBucketIdentifier;
            private int? _GrantDestinyItemType;
            private int? _GrantDestinySubType;
            private int? _GrantDestinyClass;
            private string _TraitId;
            private List<int?> _GroupedCategoryHashes;
            private List<int?> _ParentCategoryHashes;
            private bool? _GroupCategoryOnly;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyItemCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.Visible property.
            /// </summary>
            /// <param name="value">If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder Visible(bool? value)
            {
                _Visible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.Deprecated property.
            /// </summary>
            /// <param name="value">If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder Deprecated(bool? value)
            {
                _Deprecated = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.ShortTitle property.
            /// </summary>
            /// <param name="value">A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder ShortTitle(string value)
            {
                _ShortTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.ItemTypeRegex property.
            /// </summary>
            /// <param name="value">The janky regular expression we used against the item type to try and discern whether the item belongs to this category.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder ItemTypeRegex(string value)
            {
                _ItemTypeRegex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.GrantDestinyBreakerType property.
            /// </summary>
            /// <param name="value">If the item in question has this category, it also should have this breaker type.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder GrantDestinyBreakerType(int? value)
            {
                _GrantDestinyBreakerType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.PlugCategoryIdentifier property.
            /// </summary>
            /// <param name="value">If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder PlugCategoryIdentifier(string value)
            {
                _PlugCategoryIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.ItemTypeRegexNot property.
            /// </summary>
            /// <param name="value">If the item type matches this janky regex, it does *not* belong to this category.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder ItemTypeRegexNot(string value)
            {
                _ItemTypeRegexNot = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.OriginBucketIdentifier property.
            /// </summary>
            /// <param name="value">If the item belongs to this bucket, it does belong to this category.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder OriginBucketIdentifier(string value)
            {
                _OriginBucketIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.GrantDestinyItemType property.
            /// </summary>
            /// <param name="value">If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder GrantDestinyItemType(int? value)
            {
                _GrantDestinyItemType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.GrantDestinySubType property.
            /// </summary>
            /// <param name="value">If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder GrantDestinySubType(int? value)
            {
                _GrantDestinySubType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.GrantDestinyClass property.
            /// </summary>
            /// <param name="value">If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder GrantDestinyClass(int? value)
            {
                _GrantDestinyClass = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.TraitId property.
            /// </summary>
            /// <param name="value">The traitId that can be found on items that belong to this category.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder TraitId(string value)
            {
                _TraitId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.GroupedCategoryHashes property.
            /// </summary>
            /// <param name="value">If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder GroupedCategoryHashes(List<int?> value)
            {
                _GroupedCategoryHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.ParentCategoryHashes property.
            /// </summary>
            /// <param name="value">All item category hashes of \&quot;parent\&quot; categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It&#39;s a bit redundant, but having this child-centric list speeds up some calculations.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder ParentCategoryHashes(List<int?> value)
            {
                _ParentCategoryHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.GroupCategoryOnly property.
            /// </summary>
            /// <param name="value">If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder GroupCategoryOnly(bool? value)
            {
                _GroupCategoryOnly = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCategoryDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyItemCategoryDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemCategoryDefinition</returns>
            public DestinyDefinitionsDestinyItemCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemCategoryDefinition(
                    DisplayProperties: _DisplayProperties,
                    Visible: _Visible,
                    Deprecated: _Deprecated,
                    ShortTitle: _ShortTitle,
                    ItemTypeRegex: _ItemTypeRegex,
                    GrantDestinyBreakerType: _GrantDestinyBreakerType,
                    PlugCategoryIdentifier: _PlugCategoryIdentifier,
                    ItemTypeRegexNot: _ItemTypeRegexNot,
                    OriginBucketIdentifier: _OriginBucketIdentifier,
                    GrantDestinyItemType: _GrantDestinyItemType,
                    GrantDestinySubType: _GrantDestinySubType,
                    GrantDestinyClass: _GrantDestinyClass,
                    TraitId: _TraitId,
                    GroupedCategoryHashes: _GroupedCategoryHashes,
                    ParentCategoryHashes: _ParentCategoryHashes,
                    GroupCategoryOnly: _GroupCategoryOnly,
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