using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The base class for Vendor Sale Item data. Has a bunch of character-agnostic state about the item being sold.  Note that if you want instance, stats, etc... data for the item, you&#39;ll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse&#39;s \&quot;items\&quot; property.
    /// </summary>
    public sealed class DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent:  IEquatable<DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent>
    { 
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
        /// Use DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent()
        {
        }

        private DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent(int? VendorItemIndex, int? ItemHash, int? OverrideStyleItemHash, int? Quantity, List<DestinyDestinyItemQuantity> Costs, DateTime? OverrideNextRefreshDate)
        {
            
            this.VendorItemIndex = VendorItemIndex;
            
            this.ItemHash = ItemHash;
            
            this.OverrideStyleItemHash = OverrideStyleItemHash;
            
            this.Quantity = Quantity;
            
            this.Costs = Costs;
            
            this.OverrideNextRefreshDate = OverrideNextRefreshDate;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder</returns>
        public static DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder Builder()
        {
            return new DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder</returns>
        public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent left, DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent left, DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.
        /// </summary>
        public sealed class DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder
        {
            private int? _VendorItemIndex;
            private int? _ItemHash;
            private int? _OverrideStyleItemHash;
            private int? _Quantity;
            private List<DestinyDestinyItemQuantity> _Costs;
            private DateTime? _OverrideNextRefreshDate;

            internal DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.VendorItemIndex property.
            /// </summary>
            /// <param name="value">The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.</param>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder VendorItemIndex(int? value)
            {
                _VendorItemIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.ItemHash property.
            /// </summary>
            /// <param name="value">The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.</param>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.OverrideStyleItemHash property.
            /// </summary>
            /// <param name="value">If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.</param>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder OverrideStyleItemHash(int? value)
            {
                _OverrideStyleItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.Quantity property.
            /// </summary>
            /// <param name="value">How much of the item you&#39;ll be getting.</param>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.Costs property.
            /// </summary>
            /// <param name="value">A summary of the current costs of the item.</param>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder Costs(List<DestinyDestinyItemQuantity> value)
            {
                _Costs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.OverrideNextRefreshDate property.
            /// </summary>
            /// <param name="value">If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.</param>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponentBuilder OverrideNextRefreshDate(DateTime? value)
            {
                _OverrideNextRefreshDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent.
            /// </summary>
            /// <returns>DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent</returns>
            public DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent Build()
            {
                Validate();
                return new DestinyComponentsVendorsDestinyVendorSaleItemBaseComponent(
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