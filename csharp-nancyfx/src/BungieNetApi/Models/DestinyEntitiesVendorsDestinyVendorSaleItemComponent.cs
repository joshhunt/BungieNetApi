using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Request this component if you want the details about an item being sold in relation to the character making the request: whether the character can buy it, whether they can afford it, and other data related to purchasing the item.  Note that if you want instance, stats, etc... data for the item, you&#39;ll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse&#39;s \&quot;items\&quot; property.
    /// </summary>
    public sealed class DestinyEntitiesVendorsDestinyVendorSaleItemComponent:  IEquatable<DestinyEntitiesVendorsDestinyVendorSaleItemComponent>
    { 
        /// <summary>
        /// A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can&#39;t buy it.
        /// </summary>
        public int? SaleStatus { get; private set; }

        /// <summary>
        /// If you can&#39;t buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
        /// </summary>
        public List<int?> RequiredUnlocks { get; private set; }

        /// <summary>
        /// If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
        /// </summary>
        public List<DestinyDestinyUnlockStatus> UnlockStatuses { get; private set; }

        /// <summary>
        /// Indexes in to the \&quot;failureStrings\&quot; lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can&#39;t purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn&#39;t anticipate.
        /// </summary>
        public List<int?> FailureIndexes { get; private set; }

        /// <summary>
        /// A flags enumeration value representing the current state of any \&quot;state modifiers\&quot; on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.
        /// </summary>
        public int? Augments { get; private set; }

        /// <summary>
        /// The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.
        /// </summary>
        public int? VendorItemIndex { get; private set; }

        /// <summary>
        /// The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.
        /// </summary>
        public int? OverrideStyleItemHash { get; private set; }

        /// <summary>
        /// How much of the item you&#39;ll be getting.
        /// </summary>
        public int? Quantity { get; private set; }

        /// <summary>
        /// A summary of the current costs of the item.
        /// </summary>
        public List<DestinyDestinyItemQuantity> Costs { get; private set; }

        /// <summary>
        /// If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.
        /// </summary>
        public DateTime? OverrideNextRefreshDate { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesVendorsDestinyVendorSaleItemComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesVendorsDestinyVendorSaleItemComponent()
        {
        }

        private DestinyEntitiesVendorsDestinyVendorSaleItemComponent(int? SaleStatus, List<int?> RequiredUnlocks, List<DestinyDestinyUnlockStatus> UnlockStatuses, List<int?> FailureIndexes, int? Augments, int? VendorItemIndex, int? ItemHash, int? OverrideStyleItemHash, int? Quantity, List<DestinyDestinyItemQuantity> Costs, DateTime? OverrideNextRefreshDate)
        {
            
            this.SaleStatus = SaleStatus;
            
            this.RequiredUnlocks = RequiredUnlocks;
            
            this.UnlockStatuses = UnlockStatuses;
            
            this.FailureIndexes = FailureIndexes;
            
            this.Augments = Augments;
            
            this.VendorItemIndex = VendorItemIndex;
            
            this.ItemHash = ItemHash;
            
            this.OverrideStyleItemHash = OverrideStyleItemHash;
            
            this.Quantity = Quantity;
            
            this.Costs = Costs;
            
            this.OverrideNextRefreshDate = OverrideNextRefreshDate;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesVendorsDestinyVendorSaleItemComponent.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder</returns>
        public static DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder Builder()
        {
            return new DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder</returns>
        public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder With()
        {
            return Builder()
                .SaleStatus(SaleStatus)
                .RequiredUnlocks(RequiredUnlocks)
                .UnlockStatuses(UnlockStatuses)
                .FailureIndexes(FailureIndexes)
                .Augments(Augments)
                .VendorItemIndex(VendorItemIndex)
                .ItemHash(ItemHash)
                .OverrideStyleItemHash(OverrideStyleItemHash)
                .Quantity(Quantity)
                .Costs(Costs)
                .OverrideNextRefreshDate(OverrideNextRefreshDate);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesVendorsDestinyVendorSaleItemComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesVendorsDestinyVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorSaleItemComponent</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorSaleItemComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesVendorsDestinyVendorSaleItemComponent left, DestinyEntitiesVendorsDestinyVendorSaleItemComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesVendorsDestinyVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorSaleItemComponent</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorSaleItemComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesVendorsDestinyVendorSaleItemComponent left, DestinyEntitiesVendorsDestinyVendorSaleItemComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesVendorsDestinyVendorSaleItemComponent.
        /// </summary>
        public sealed class DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder
        {
            private int? _SaleStatus;
            private List<int?> _RequiredUnlocks;
            private List<DestinyDestinyUnlockStatus> _UnlockStatuses;
            private List<int?> _FailureIndexes;
            private int? _Augments;
            private int? _VendorItemIndex;
            private int? _ItemHash;
            private int? _OverrideStyleItemHash;
            private int? _Quantity;
            private List<DestinyDestinyItemQuantity> _Costs;
            private DateTime? _OverrideNextRefreshDate;

            internal DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.SaleStatus property.
            /// </summary>
            /// <param name="value">A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can&#39;t buy it.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder SaleStatus(int? value)
            {
                _SaleStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.RequiredUnlocks property.
            /// </summary>
            /// <param name="value">If you can&#39;t buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder RequiredUnlocks(List<int?> value)
            {
                _RequiredUnlocks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.UnlockStatuses property.
            /// </summary>
            /// <param name="value">If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder UnlockStatuses(List<DestinyDestinyUnlockStatus> value)
            {
                _UnlockStatuses = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.FailureIndexes property.
            /// </summary>
            /// <param name="value">Indexes in to the \&quot;failureStrings\&quot; lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can&#39;t purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn&#39;t anticipate.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder FailureIndexes(List<int?> value)
            {
                _FailureIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.Augments property.
            /// </summary>
            /// <param name="value">A flags enumeration value representing the current state of any \&quot;state modifiers\&quot; on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder Augments(int? value)
            {
                _Augments = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.VendorItemIndex property.
            /// </summary>
            /// <param name="value">The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder VendorItemIndex(int? value)
            {
                _VendorItemIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.ItemHash property.
            /// </summary>
            /// <param name="value">The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.OverrideStyleItemHash property.
            /// </summary>
            /// <param name="value">If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder OverrideStyleItemHash(int? value)
            {
                _OverrideStyleItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.Quantity property.
            /// </summary>
            /// <param name="value">How much of the item you&#39;ll be getting.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.Costs property.
            /// </summary>
            /// <param name="value">A summary of the current costs of the item.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder Costs(List<DestinyDestinyItemQuantity> value)
            {
                _Costs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorSaleItemComponent.OverrideNextRefreshDate property.
            /// </summary>
            /// <param name="value">If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.</param>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponentBuilder OverrideNextRefreshDate(DateTime? value)
            {
                _OverrideNextRefreshDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesVendorsDestinyVendorSaleItemComponent.
            /// </summary>
            /// <returns>DestinyEntitiesVendorsDestinyVendorSaleItemComponent</returns>
            public DestinyEntitiesVendorsDestinyVendorSaleItemComponent Build()
            {
                Validate();
                return new DestinyEntitiesVendorsDestinyVendorSaleItemComponent(
                    SaleStatus: _SaleStatus,
                    RequiredUnlocks: _RequiredUnlocks,
                    UnlockStatuses: _UnlockStatuses,
                    FailureIndexes: _FailureIndexes,
                    Augments: _Augments,
                    VendorItemIndex: _VendorItemIndex,
                    ItemHash: _ItemHash,
                    OverrideStyleItemHash: _OverrideStyleItemHash,
                    Quantity: _Quantity,
                    Costs: _Costs,
                    OverrideNextRefreshDate: _OverrideNextRefreshDate
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}