using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyResponsesPersonalDestinyVendorSaleItemSetComponent
    /// </summary>
    public sealed class DestinyResponsesPersonalDestinyVendorSaleItemSetComponent:  IEquatable<DestinyResponsesPersonalDestinyVendorSaleItemSetComponent>
    { 
        /// <summary>
        /// SaleItems
        /// </summary>
        public Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> SaleItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesPersonalDestinyVendorSaleItemSetComponent()
        {
        }

        private DestinyResponsesPersonalDestinyVendorSaleItemSetComponent(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> SaleItems)
        {
            
            this.SaleItems = SaleItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <returns>DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder</returns>
        public static DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder Builder()
        {
            return new DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder</returns>
        public DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder With()
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

        public bool Equals(DestinyResponsesPersonalDestinyVendorSaleItemSetComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent left, DestinyResponsesPersonalDestinyVendorSaleItemSetComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesPersonalDestinyVendorSaleItemSetComponent left, DestinyResponsesPersonalDestinyVendorSaleItemSetComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        public sealed class DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> _SaleItems;

            internal DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.SaleItems property.
            /// </summary>
            /// <param name="value">SaleItems</param>
            public DestinyResponsesPersonalDestinyVendorSaleItemSetComponentBuilder SaleItems(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> value)
            {
                _SaleItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesPersonalDestinyVendorSaleItemSetComponent.
            /// </summary>
            /// <returns>DestinyResponsesPersonalDestinyVendorSaleItemSetComponent</returns>
            public DestinyResponsesPersonalDestinyVendorSaleItemSetComponent Build()
            {
                Validate();
                return new DestinyResponsesPersonalDestinyVendorSaleItemSetComponent(
                    SaleItems: _SaleItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}