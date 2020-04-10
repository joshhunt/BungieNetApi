using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This represents an item being sold by the vendor.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorItemDefinition:  IEquatable<DestinyDefinitionsDestinyVendorItemDefinition>
    { 
        /// <summary>
        /// The index into the DestinyVendorDefinition.saleList. This is what we use to refer to items being sold throughout live and definition data.
        /// </summary>
        public int? VendorItemIndex { get; private set; }

        /// <summary>
        /// The hash identifier of the item being sold (DestinyInventoryItemDefinition).  Note that a vendor can sell the same item in multiple ways, so don&#39;t assume that itemHash is a unique identifier for this entity.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// The amount you will recieve of the item described in itemHash if you make the purchase.
        /// </summary>
        public int? Quantity { get; private set; }

        /// <summary>
        /// An list of indexes into the DestinyVendorDefinition.failureStrings array, indicating the possible failure strings that can be relevant for this item.
        /// </summary>
        public List<int?> FailureIndexes { get; private set; }

        /// <summary>
        /// This is a pre-compiled aggregation of item value and priceOverrideList, so that we have one place to check for what the purchaser must pay for the item. Use this instead of trying to piece together the price separately.  The somewhat crappy part about this is that, now that item quantity overrides have dynamic modifiers, this will not necessarily be statically true. If you were using this instead of live data, switch to using live data.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorItemQuantity> Currencies { get; private set; }

        /// <summary>
        /// If this item can be refunded, this is the policy for what will be refundd, how, and in what time period.
        /// </summary>
        public int? RefundPolicy { get; private set; }

        /// <summary>
        /// The amount of time before refundability of the newly purchased item will expire.
        /// </summary>
        public int? RefundTimeLimit { get; private set; }

        /// <summary>
        /// The Default level at which the item will spawn. Almost always driven by an adjusto these days. Ideally should be singular. It&#39;s a long story how this ended up as a list, but there is always either going to be 0:1 of these entities.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemCreationEntryLevelDefinition> CreationLevels { get; private set; }

        /// <summary>
        /// This is an index specifically into the display category, as opposed to the server-side Categories (which do not need to match or pair with each other in any way: server side categories are really just structures for common validation. Display Category will let us more easily categorize items visually)
        /// </summary>
        public int? DisplayCategoryIndex { get; private set; }

        /// <summary>
        /// The index into the DestinyVendorDefinition.categories array, so you can find the category associated with this item.
        /// </summary>
        public int? CategoryIndex { get; private set; }

        /// <summary>
        /// Same as above, but for the original category indexes.
        /// </summary>
        public int? OriginalCategoryIndex { get; private set; }

        /// <summary>
        /// The minimum character level at which this item is available for sale.
        /// </summary>
        public int? MinimumLevel { get; private set; }

        /// <summary>
        /// The maximum character level at which this item is available for sale.
        /// </summary>
        public int? MaximumLevel { get; private set; }

        /// <summary>
        /// The action to be performed when purchasing the item, if it&#39;s not just \&quot;buy\&quot;.
        /// </summary>
        public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition Action { get; private set; }

        /// <summary>
        /// The string identifier for the category selling this item.
        /// </summary>
        public string DisplayCategory { get; private set; }

        /// <summary>
        /// The inventory bucket into which this item will be placed upon purchase.
        /// </summary>
        public int? InventoryBucketHash { get; private set; }

        /// <summary>
        /// The most restrictive scope that determines whether the item is available in the Vendor&#39;s inventory. See DestinyGatingScope&#39;s documentation for more information.  This can be determined by Unlock gating, or by whether or not the item has purchase level requirements (minimumLevel and maximumLevel properties).
        /// </summary>
        public int? VisibilityScope { get; private set; }

        /// <summary>
        /// Similar to visibilityScope, it represents the most restrictive scope that determines whether the item can be purchased. It will at least be as restrictive as visibilityScope, but could be more restrictive if the item has additional purchase requirements beyond whether it is merely visible or not.  See DestinyGatingScope&#39;s documentation for more information.
        /// </summary>
        public int? PurchasableScope { get; private set; }

        /// <summary>
        /// If this item can only be purchased by a given platform, this indicates the platform to which it is restricted.
        /// </summary>
        public int? Exclusivity { get; private set; }

        /// <summary>
        /// If this sale can only be performed as the result of an offer check, this is true.
        /// </summary>
        public bool? IsOffer { get; private set; }

        /// <summary>
        /// If this sale can only be performed as the result of receiving a CRM offer, this is true.
        /// </summary>
        public bool? IsCrm { get; private set; }

        /// <summary>
        /// *if* the category this item is in supports non-default sorting, this value should represent the sorting value to use, pre-processed and ready to go.
        /// </summary>
        public int? SortValue { get; private set; }

        /// <summary>
        /// If this item can expire, this is the tooltip message to show with its expiration info.
        /// </summary>
        public string ExpirationTooltip { get; private set; }

        /// <summary>
        /// If this is populated, the purchase of this item should redirect to purchasing these other items instead.
        /// </summary>
        public List<int?> RedirectToSaleIndexes { get; private set; }

        /// <summary>
        /// SocketOverrides
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorItemSocketOverride> SocketOverrides { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorItemDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorItemDefinition(int? VendorItemIndex, int? ItemHash, int? Quantity, List<int?> FailureIndexes, List<DestinyDefinitionsDestinyVendorItemQuantity> Currencies, int? RefundPolicy, int? RefundTimeLimit, List<DestinyDefinitionsDestinyItemCreationEntryLevelDefinition> CreationLevels, int? DisplayCategoryIndex, int? CategoryIndex, int? OriginalCategoryIndex, int? MinimumLevel, int? MaximumLevel, DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition Action, string DisplayCategory, int? InventoryBucketHash, int? VisibilityScope, int? PurchasableScope, int? Exclusivity, bool? IsOffer, bool? IsCrm, int? SortValue, string ExpirationTooltip, List<int?> RedirectToSaleIndexes, List<DestinyDefinitionsDestinyVendorItemSocketOverride> SocketOverrides)
        {
            
            this.VendorItemIndex = VendorItemIndex;
            
            this.ItemHash = ItemHash;
            
            this.Quantity = Quantity;
            
            this.FailureIndexes = FailureIndexes;
            
            this.Currencies = Currencies;
            
            this.RefundPolicy = RefundPolicy;
            
            this.RefundTimeLimit = RefundTimeLimit;
            
            this.CreationLevels = CreationLevels;
            
            this.DisplayCategoryIndex = DisplayCategoryIndex;
            
            this.CategoryIndex = CategoryIndex;
            
            this.OriginalCategoryIndex = OriginalCategoryIndex;
            
            this.MinimumLevel = MinimumLevel;
            
            this.MaximumLevel = MaximumLevel;
            
            this.Action = Action;
            
            this.DisplayCategory = DisplayCategory;
            
            this.InventoryBucketHash = InventoryBucketHash;
            
            this.VisibilityScope = VisibilityScope;
            
            this.PurchasableScope = PurchasableScope;
            
            this.Exclusivity = Exclusivity;
            
            this.IsOffer = IsOffer;
            
            this.IsCrm = IsCrm;
            
            this.SortValue = SortValue;
            
            this.ExpirationTooltip = ExpirationTooltip;
            
            this.RedirectToSaleIndexes = RedirectToSaleIndexes;
            
            this.SocketOverrides = SocketOverrides;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorItemDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorItemDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorItemDefinitionBuilder With()
        {
            return Builder()
                .VendorItemIndex(VendorItemIndex)
                .ItemHash(ItemHash)
                .Quantity(Quantity)
                .FailureIndexes(FailureIndexes)
                .Currencies(Currencies)
                .RefundPolicy(RefundPolicy)
                .RefundTimeLimit(RefundTimeLimit)
                .CreationLevels(CreationLevels)
                .DisplayCategoryIndex(DisplayCategoryIndex)
                .CategoryIndex(CategoryIndex)
                .OriginalCategoryIndex(OriginalCategoryIndex)
                .MinimumLevel(MinimumLevel)
                .MaximumLevel(MaximumLevel)
                .Action(Action)
                .DisplayCategory(DisplayCategory)
                .InventoryBucketHash(InventoryBucketHash)
                .VisibilityScope(VisibilityScope)
                .PurchasableScope(PurchasableScope)
                .Exclusivity(Exclusivity)
                .IsOffer(IsOffer)
                .IsCrm(IsCrm)
                .SortValue(SortValue)
                .ExpirationTooltip(ExpirationTooltip)
                .RedirectToSaleIndexes(RedirectToSaleIndexes)
                .SocketOverrides(SocketOverrides);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorItemDefinition left, DestinyDefinitionsDestinyVendorItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorItemDefinition left, DestinyDefinitionsDestinyVendorItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorItemDefinitionBuilder
        {
            private int? _VendorItemIndex;
            private int? _ItemHash;
            private int? _Quantity;
            private List<int?> _FailureIndexes;
            private List<DestinyDefinitionsDestinyVendorItemQuantity> _Currencies;
            private int? _RefundPolicy;
            private int? _RefundTimeLimit;
            private List<DestinyDefinitionsDestinyItemCreationEntryLevelDefinition> _CreationLevels;
            private int? _DisplayCategoryIndex;
            private int? _CategoryIndex;
            private int? _OriginalCategoryIndex;
            private int? _MinimumLevel;
            private int? _MaximumLevel;
            private DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition _Action;
            private string _DisplayCategory;
            private int? _InventoryBucketHash;
            private int? _VisibilityScope;
            private int? _PurchasableScope;
            private int? _Exclusivity;
            private bool? _IsOffer;
            private bool? _IsCrm;
            private int? _SortValue;
            private string _ExpirationTooltip;
            private List<int?> _RedirectToSaleIndexes;
            private List<DestinyDefinitionsDestinyVendorItemSocketOverride> _SocketOverrides;

            internal DestinyDefinitionsDestinyVendorItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.VendorItemIndex property.
            /// </summary>
            /// <param name="value">The index into the DestinyVendorDefinition.saleList. This is what we use to refer to items being sold throughout live and definition data.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder VendorItemIndex(int? value)
            {
                _VendorItemIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the item being sold (DestinyInventoryItemDefinition).  Note that a vendor can sell the same item in multiple ways, so don&#39;t assume that itemHash is a unique identifier for this entity.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.Quantity property.
            /// </summary>
            /// <param name="value">The amount you will recieve of the item described in itemHash if you make the purchase.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.FailureIndexes property.
            /// </summary>
            /// <param name="value">An list of indexes into the DestinyVendorDefinition.failureStrings array, indicating the possible failure strings that can be relevant for this item.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder FailureIndexes(List<int?> value)
            {
                _FailureIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.Currencies property.
            /// </summary>
            /// <param name="value">This is a pre-compiled aggregation of item value and priceOverrideList, so that we have one place to check for what the purchaser must pay for the item. Use this instead of trying to piece together the price separately.  The somewhat crappy part about this is that, now that item quantity overrides have dynamic modifiers, this will not necessarily be statically true. If you were using this instead of live data, switch to using live data.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder Currencies(List<DestinyDefinitionsDestinyVendorItemQuantity> value)
            {
                _Currencies = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.RefundPolicy property.
            /// </summary>
            /// <param name="value">If this item can be refunded, this is the policy for what will be refundd, how, and in what time period.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder RefundPolicy(int? value)
            {
                _RefundPolicy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.RefundTimeLimit property.
            /// </summary>
            /// <param name="value">The amount of time before refundability of the newly purchased item will expire.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder RefundTimeLimit(int? value)
            {
                _RefundTimeLimit = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.CreationLevels property.
            /// </summary>
            /// <param name="value">The Default level at which the item will spawn. Almost always driven by an adjusto these days. Ideally should be singular. It&#39;s a long story how this ended up as a list, but there is always either going to be 0:1 of these entities.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder CreationLevels(List<DestinyDefinitionsDestinyItemCreationEntryLevelDefinition> value)
            {
                _CreationLevels = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.DisplayCategoryIndex property.
            /// </summary>
            /// <param name="value">This is an index specifically into the display category, as opposed to the server-side Categories (which do not need to match or pair with each other in any way: server side categories are really just structures for common validation. Display Category will let us more easily categorize items visually)</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder DisplayCategoryIndex(int? value)
            {
                _DisplayCategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.CategoryIndex property.
            /// </summary>
            /// <param name="value">The index into the DestinyVendorDefinition.categories array, so you can find the category associated with this item.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder CategoryIndex(int? value)
            {
                _CategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.OriginalCategoryIndex property.
            /// </summary>
            /// <param name="value">Same as above, but for the original category indexes.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder OriginalCategoryIndex(int? value)
            {
                _OriginalCategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.MinimumLevel property.
            /// </summary>
            /// <param name="value">The minimum character level at which this item is available for sale.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder MinimumLevel(int? value)
            {
                _MinimumLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.MaximumLevel property.
            /// </summary>
            /// <param name="value">The maximum character level at which this item is available for sale.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder MaximumLevel(int? value)
            {
                _MaximumLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.Action property.
            /// </summary>
            /// <param name="value">The action to be performed when purchasing the item, if it&#39;s not just \&quot;buy\&quot;.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder Action(DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition value)
            {
                _Action = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.DisplayCategory property.
            /// </summary>
            /// <param name="value">The string identifier for the category selling this item.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder DisplayCategory(string value)
            {
                _DisplayCategory = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.InventoryBucketHash property.
            /// </summary>
            /// <param name="value">The inventory bucket into which this item will be placed upon purchase.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder InventoryBucketHash(int? value)
            {
                _InventoryBucketHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.VisibilityScope property.
            /// </summary>
            /// <param name="value">The most restrictive scope that determines whether the item is available in the Vendor&#39;s inventory. See DestinyGatingScope&#39;s documentation for more information.  This can be determined by Unlock gating, or by whether or not the item has purchase level requirements (minimumLevel and maximumLevel properties).</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder VisibilityScope(int? value)
            {
                _VisibilityScope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.PurchasableScope property.
            /// </summary>
            /// <param name="value">Similar to visibilityScope, it represents the most restrictive scope that determines whether the item can be purchased. It will at least be as restrictive as visibilityScope, but could be more restrictive if the item has additional purchase requirements beyond whether it is merely visible or not.  See DestinyGatingScope&#39;s documentation for more information.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder PurchasableScope(int? value)
            {
                _PurchasableScope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.Exclusivity property.
            /// </summary>
            /// <param name="value">If this item can only be purchased by a given platform, this indicates the platform to which it is restricted.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder Exclusivity(int? value)
            {
                _Exclusivity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.IsOffer property.
            /// </summary>
            /// <param name="value">If this sale can only be performed as the result of an offer check, this is true.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder IsOffer(bool? value)
            {
                _IsOffer = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.IsCrm property.
            /// </summary>
            /// <param name="value">If this sale can only be performed as the result of receiving a CRM offer, this is true.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder IsCrm(bool? value)
            {
                _IsCrm = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.SortValue property.
            /// </summary>
            /// <param name="value">*if* the category this item is in supports non-default sorting, this value should represent the sorting value to use, pre-processed and ready to go.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder SortValue(int? value)
            {
                _SortValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.ExpirationTooltip property.
            /// </summary>
            /// <param name="value">If this item can expire, this is the tooltip message to show with its expiration info.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder ExpirationTooltip(string value)
            {
                _ExpirationTooltip = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.RedirectToSaleIndexes property.
            /// </summary>
            /// <param name="value">If this is populated, the purchase of this item should redirect to purchasing these other items instead.</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder RedirectToSaleIndexes(List<int?> value)
            {
                _RedirectToSaleIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemDefinition.SocketOverrides property.
            /// </summary>
            /// <param name="value">SocketOverrides</param>
            public DestinyDefinitionsDestinyVendorItemDefinitionBuilder SocketOverrides(List<DestinyDefinitionsDestinyVendorItemSocketOverride> value)
            {
                _SocketOverrides = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorItemDefinition</returns>
            public DestinyDefinitionsDestinyVendorItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorItemDefinition(
                    VendorItemIndex: _VendorItemIndex,
                    ItemHash: _ItemHash,
                    Quantity: _Quantity,
                    FailureIndexes: _FailureIndexes,
                    Currencies: _Currencies,
                    RefundPolicy: _RefundPolicy,
                    RefundTimeLimit: _RefundTimeLimit,
                    CreationLevels: _CreationLevels,
                    DisplayCategoryIndex: _DisplayCategoryIndex,
                    CategoryIndex: _CategoryIndex,
                    OriginalCategoryIndex: _OriginalCategoryIndex,
                    MinimumLevel: _MinimumLevel,
                    MaximumLevel: _MaximumLevel,
                    Action: _Action,
                    DisplayCategory: _DisplayCategory,
                    InventoryBucketHash: _InventoryBucketHash,
                    VisibilityScope: _VisibilityScope,
                    PurchasableScope: _PurchasableScope,
                    Exclusivity: _Exclusivity,
                    IsOffer: _IsOffer,
                    IsCrm: _IsCrm,
                    SortValue: _SortValue,
                    ExpirationTooltip: _ExpirationTooltip,
                    RedirectToSaleIndexes: _RedirectToSaleIndexes,
                    SocketOverrides: _SocketOverrides
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}