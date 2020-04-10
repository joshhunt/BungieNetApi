using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent
    /// </summary>
    public sealed class DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent:  IEquatable<DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent>
    { 
        /// <summary>
        /// SaleItems
        /// </summary>
        public Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> SaleItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent()
        {
        }

        private DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent(Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> SaleItems)
        {
            
            this.SaleItems = SaleItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.
        /// </summary>
        /// <returns>DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder</returns>
        public static DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder Builder()
        {
            return new DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder</returns>
        public DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder With()
        {
            return Builder()
                .SaleItems(SaleItems);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent</param>
        /// <param name="right">Compared (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent left, DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent</param>
        /// <param name="right">Compared (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent left, DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.
        /// </summary>
        public sealed class DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder
        {
            private Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> _SaleItems;

            internal DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.SaleItems property.
            /// </summary>
            /// <param name="value">SaleItems</param>
            public DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponentBuilder SaleItems(Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> value)
            {
                _SaleItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent.
            /// </summary>
            /// <returns>DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent</returns>
            public DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent Build()
            {
                Validate();
                return new DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent(
                    SaleItems: _SaleItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}