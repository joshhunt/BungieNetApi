using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent
    /// </summary>
    public sealed class DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent:  IEquatable<DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent>
    { 
        /// <summary>
        /// SaleItems
        /// </summary>
        public Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> SaleItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent()
        {
        }

        private DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> SaleItems)
        {
            
            this.SaleItems = SaleItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.
        /// </summary>
        /// <returns>DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder</returns>
        public static DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder Builder()
        {
            return new DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder</returns>
        public DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder With()
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

        public bool Equals(DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent</param>
        /// <param name="right">Compared (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent left, DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent</param>
        /// <param name="right">Compared (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent left, DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.
        /// </summary>
        public sealed class DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> _SaleItems;

            internal DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.SaleItems property.
            /// </summary>
            /// <param name="value">SaleItems</param>
            public DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponentBuilder SaleItems(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> value)
            {
                _SaleItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent.
            /// </summary>
            /// <returns>DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent</returns>
            public DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent Build()
            {
                Validate();
                return new DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent(
                    SaleItems: _SaleItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}