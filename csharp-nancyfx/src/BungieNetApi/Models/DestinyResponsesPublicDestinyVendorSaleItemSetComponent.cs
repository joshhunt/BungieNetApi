using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyResponsesPublicDestinyVendorSaleItemSetComponent
    /// </summary>
    public sealed class DestinyResponsesPublicDestinyVendorSaleItemSetComponent:  IEquatable<DestinyResponsesPublicDestinyVendorSaleItemSetComponent>
    { 
        /// <summary>
        /// SaleItems
        /// </summary>
        public Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> SaleItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesPublicDestinyVendorSaleItemSetComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesPublicDestinyVendorSaleItemSetComponent()
        {
        }

        private DestinyResponsesPublicDestinyVendorSaleItemSetComponent(Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> SaleItems)
        {
            
            this.SaleItems = SaleItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <returns>DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder</returns>
        public static DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder Builder()
        {
            return new DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder</returns>
        public DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder With()
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

        public bool Equals(DestinyResponsesPublicDestinyVendorSaleItemSetComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesPublicDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DestinyResponsesPublicDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesPublicDestinyVendorSaleItemSetComponent left, DestinyResponsesPublicDestinyVendorSaleItemSetComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesPublicDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DestinyResponsesPublicDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesPublicDestinyVendorSaleItemSetComponent left, DestinyResponsesPublicDestinyVendorSaleItemSetComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        public sealed class DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder
        {
            private Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> _SaleItems;

            internal DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesPublicDestinyVendorSaleItemSetComponent.SaleItems property.
            /// </summary>
            /// <param name="value">SaleItems</param>
            public DestinyResponsesPublicDestinyVendorSaleItemSetComponentBuilder SaleItems(Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> value)
            {
                _SaleItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesPublicDestinyVendorSaleItemSetComponent.
            /// </summary>
            /// <returns>DestinyResponsesPublicDestinyVendorSaleItemSetComponent</returns>
            public DestinyResponsesPublicDestinyVendorSaleItemSetComponent Build()
            {
                Validate();
                return new DestinyResponsesPublicDestinyVendorSaleItemSetComponent(
                    SaleItems: _SaleItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}