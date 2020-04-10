using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is the definition for a single Vendor Category, into which Sale Items are grouped.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorCategoryEntryDefinition:  IEquatable<DestinyDefinitionsDestinyVendorCategoryEntryDefinition>
    { 
        /// <summary>
        /// The index of the category in the original category definitions for the vendor.
        /// </summary>
        public int? CategoryIndex { get; private set; }

        /// <summary>
        /// Used in sorting items in vendors... but there&#39;s a lot more to it. Just go with the order provided in the itemIndexes property on the DestinyVendorCategoryComponent instead, it should be more reliable than trying to recalculate it yourself.
        /// </summary>
        public int? SortValue { get; private set; }

        /// <summary>
        /// The hashed identifier for the category.
        /// </summary>
        public int? CategoryHash { get; private set; }

        /// <summary>
        /// The amount of items that will be available when this category is shown.
        /// </summary>
        public int? QuantityAvailable { get; private set; }

        /// <summary>
        /// If items aren&#39;t up for sale in this category, should we still show them (greyed out)?
        /// </summary>
        public bool? ShowUnavailableItems { get; private set; }

        /// <summary>
        /// If you don&#39;t have the currency required to buy items from this category, should the items be hidden?
        /// </summary>
        public bool? HideIfNoCurrency { get; private set; }

        /// <summary>
        /// True if this category doesn&#39;t allow purchases.
        /// </summary>
        public bool? HideFromRegularPurchase { get; private set; }

        /// <summary>
        /// The localized string for making purchases from this category, if it is different from the vendor&#39;s string for purchasing.
        /// </summary>
        public string BuyStringOverride { get; private set; }

        /// <summary>
        /// If the category is disabled, this is the localized description to show.
        /// </summary>
        public string DisabledDescription { get; private set; }

        /// <summary>
        /// The localized title of the category.
        /// </summary>
        public string DisplayTitle { get; private set; }

        /// <summary>
        /// If this category has an overlay prompt that should appear, this contains the details of that prompt.
        /// </summary>
        public DestinyDefinitionsDestinyVendorCategoryOverlayDefinition Overlay { get; private set; }

        /// <summary>
        /// A shortcut for the vendor item indexes sold under this category. Saves us from some expensive reorganization at runtime.
        /// </summary>
        public List<int?> VendorItemIndexes { get; private set; }

        /// <summary>
        /// Sometimes a category isn&#39;t actually used to sell items, but rather to preview them. This implies different UI (and manual placement of the category in the UI) in the game, and special treatment.
        /// </summary>
        public bool? IsPreview { get; private set; }

        /// <summary>
        /// If true, this category only displays items: you can&#39;t purchase anything in them.
        /// </summary>
        public bool? IsDisplayOnly { get; private set; }

        /// <summary>
        /// ResetIntervalMinutesOverride
        /// </summary>
        public int? ResetIntervalMinutesOverride { get; private set; }

        /// <summary>
        /// ResetOffsetMinutesOverride
        /// </summary>
        public int? ResetOffsetMinutesOverride { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorCategoryEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorCategoryEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorCategoryEntryDefinition(int? CategoryIndex, int? SortValue, int? CategoryHash, int? QuantityAvailable, bool? ShowUnavailableItems, bool? HideIfNoCurrency, bool? HideFromRegularPurchase, string BuyStringOverride, string DisabledDescription, string DisplayTitle, DestinyDefinitionsDestinyVendorCategoryOverlayDefinition Overlay, List<int?> VendorItemIndexes, bool? IsPreview, bool? IsDisplayOnly, int? ResetIntervalMinutesOverride, int? ResetOffsetMinutesOverride)
        {
            
            this.CategoryIndex = CategoryIndex;
            
            this.SortValue = SortValue;
            
            this.CategoryHash = CategoryHash;
            
            this.QuantityAvailable = QuantityAvailable;
            
            this.ShowUnavailableItems = ShowUnavailableItems;
            
            this.HideIfNoCurrency = HideIfNoCurrency;
            
            this.HideFromRegularPurchase = HideFromRegularPurchase;
            
            this.BuyStringOverride = BuyStringOverride;
            
            this.DisabledDescription = DisabledDescription;
            
            this.DisplayTitle = DisplayTitle;
            
            this.Overlay = Overlay;
            
            this.VendorItemIndexes = VendorItemIndexes;
            
            this.IsPreview = IsPreview;
            
            this.IsDisplayOnly = IsDisplayOnly;
            
            this.ResetIntervalMinutesOverride = ResetIntervalMinutesOverride;
            
            this.ResetOffsetMinutesOverride = ResetOffsetMinutesOverride;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorCategoryEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder With()
        {
            return Builder()
                .CategoryIndex(CategoryIndex)
                .SortValue(SortValue)
                .CategoryHash(CategoryHash)
                .QuantityAvailable(QuantityAvailable)
                .ShowUnavailableItems(ShowUnavailableItems)
                .HideIfNoCurrency(HideIfNoCurrency)
                .HideFromRegularPurchase(HideFromRegularPurchase)
                .BuyStringOverride(BuyStringOverride)
                .DisabledDescription(DisabledDescription)
                .DisplayTitle(DisplayTitle)
                .Overlay(Overlay)
                .VendorItemIndexes(VendorItemIndexes)
                .IsPreview(IsPreview)
                .IsDisplayOnly(IsDisplayOnly)
                .ResetIntervalMinutesOverride(ResetIntervalMinutesOverride)
                .ResetOffsetMinutesOverride(ResetOffsetMinutesOverride);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorCategoryEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorCategoryEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorCategoryEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorCategoryEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorCategoryEntryDefinition left, DestinyDefinitionsDestinyVendorCategoryEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorCategoryEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorCategoryEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorCategoryEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorCategoryEntryDefinition left, DestinyDefinitionsDestinyVendorCategoryEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorCategoryEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder
        {
            private int? _CategoryIndex;
            private int? _SortValue;
            private int? _CategoryHash;
            private int? _QuantityAvailable;
            private bool? _ShowUnavailableItems;
            private bool? _HideIfNoCurrency;
            private bool? _HideFromRegularPurchase;
            private string _BuyStringOverride;
            private string _DisabledDescription;
            private string _DisplayTitle;
            private DestinyDefinitionsDestinyVendorCategoryOverlayDefinition _Overlay;
            private List<int?> _VendorItemIndexes;
            private bool? _IsPreview;
            private bool? _IsDisplayOnly;
            private int? _ResetIntervalMinutesOverride;
            private int? _ResetOffsetMinutesOverride;

            internal DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.CategoryIndex property.
            /// </summary>
            /// <param name="value">The index of the category in the original category definitions for the vendor.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder CategoryIndex(int? value)
            {
                _CategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.SortValue property.
            /// </summary>
            /// <param name="value">Used in sorting items in vendors... but there&#39;s a lot more to it. Just go with the order provided in the itemIndexes property on the DestinyVendorCategoryComponent instead, it should be more reliable than trying to recalculate it yourself.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder SortValue(int? value)
            {
                _SortValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.CategoryHash property.
            /// </summary>
            /// <param name="value">The hashed identifier for the category.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder CategoryHash(int? value)
            {
                _CategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.QuantityAvailable property.
            /// </summary>
            /// <param name="value">The amount of items that will be available when this category is shown.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder QuantityAvailable(int? value)
            {
                _QuantityAvailable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.ShowUnavailableItems property.
            /// </summary>
            /// <param name="value">If items aren&#39;t up for sale in this category, should we still show them (greyed out)?</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder ShowUnavailableItems(bool? value)
            {
                _ShowUnavailableItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.HideIfNoCurrency property.
            /// </summary>
            /// <param name="value">If you don&#39;t have the currency required to buy items from this category, should the items be hidden?</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder HideIfNoCurrency(bool? value)
            {
                _HideIfNoCurrency = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.HideFromRegularPurchase property.
            /// </summary>
            /// <param name="value">True if this category doesn&#39;t allow purchases.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder HideFromRegularPurchase(bool? value)
            {
                _HideFromRegularPurchase = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.BuyStringOverride property.
            /// </summary>
            /// <param name="value">The localized string for making purchases from this category, if it is different from the vendor&#39;s string for purchasing.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder BuyStringOverride(string value)
            {
                _BuyStringOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.DisabledDescription property.
            /// </summary>
            /// <param name="value">If the category is disabled, this is the localized description to show.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder DisabledDescription(string value)
            {
                _DisabledDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.DisplayTitle property.
            /// </summary>
            /// <param name="value">The localized title of the category.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder DisplayTitle(string value)
            {
                _DisplayTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.Overlay property.
            /// </summary>
            /// <param name="value">If this category has an overlay prompt that should appear, this contains the details of that prompt.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder Overlay(DestinyDefinitionsDestinyVendorCategoryOverlayDefinition value)
            {
                _Overlay = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.VendorItemIndexes property.
            /// </summary>
            /// <param name="value">A shortcut for the vendor item indexes sold under this category. Saves us from some expensive reorganization at runtime.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder VendorItemIndexes(List<int?> value)
            {
                _VendorItemIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.IsPreview property.
            /// </summary>
            /// <param name="value">Sometimes a category isn&#39;t actually used to sell items, but rather to preview them. This implies different UI (and manual placement of the category in the UI) in the game, and special treatment.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder IsPreview(bool? value)
            {
                _IsPreview = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.IsDisplayOnly property.
            /// </summary>
            /// <param name="value">If true, this category only displays items: you can&#39;t purchase anything in them.</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder IsDisplayOnly(bool? value)
            {
                _IsDisplayOnly = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.ResetIntervalMinutesOverride property.
            /// </summary>
            /// <param name="value">ResetIntervalMinutesOverride</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder ResetIntervalMinutesOverride(int? value)
            {
                _ResetIntervalMinutesOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryEntryDefinition.ResetOffsetMinutesOverride property.
            /// </summary>
            /// <param name="value">ResetOffsetMinutesOverride</param>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinitionBuilder ResetOffsetMinutesOverride(int? value)
            {
                _ResetOffsetMinutesOverride = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorCategoryEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorCategoryEntryDefinition</returns>
            public DestinyDefinitionsDestinyVendorCategoryEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorCategoryEntryDefinition(
                    CategoryIndex: _CategoryIndex,
                    SortValue: _SortValue,
                    CategoryHash: _CategoryHash,
                    QuantityAvailable: _QuantityAvailable,
                    ShowUnavailableItems: _ShowUnavailableItems,
                    HideIfNoCurrency: _HideIfNoCurrency,
                    HideFromRegularPurchase: _HideFromRegularPurchase,
                    BuyStringOverride: _BuyStringOverride,
                    DisabledDescription: _DisabledDescription,
                    DisplayTitle: _DisplayTitle,
                    Overlay: _Overlay,
                    VendorItemIndexes: _VendorItemIndexes,
                    IsPreview: _IsPreview,
                    IsDisplayOnly: _IsDisplayOnly,
                    ResetIntervalMinutesOverride: _ResetIntervalMinutesOverride,
                    ResetOffsetMinutesOverride: _ResetOffsetMinutesOverride
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}