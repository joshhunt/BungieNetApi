using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A response containing all of the components for a vendor.
    /// </summary>
    public sealed class DestinyResponsesDestinyVendorResponse:  IEquatable<DestinyResponsesDestinyVendorResponse>
    { 
        /// <summary>
        /// The base properties of the vendor.  COMPONENT TYPE: Vendors
        /// </summary>
        public SingleComponentResponseOfDestinyVendorComponent Vendor { get; private set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein.  COMPONENT TYPE: VendorCategories
        /// </summary>
        public SingleComponentResponseOfDestinyVendorCategoriesComponent Categories { get; private set; }

        /// <summary>
        /// Sales, keyed by the vendorItemIndex of the item being sold.  COMPONENT TYPE: VendorSales
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Sales { get; private set; }

        /// <summary>
        /// Item components, keyed by the vendorItemIndex of the active sale items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        public DestinyItemComponentSetOfint32 ItemComponents { get; private set; }

        /// <summary>
        /// A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
        /// </summary>
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyVendorResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyVendorResponse()
        {
        }

        private DestinyResponsesDestinyVendorResponse(SingleComponentResponseOfDestinyVendorComponent Vendor, SingleComponentResponseOfDestinyVendorCategoriesComponent Categories, DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Sales, DestinyItemComponentSetOfint32 ItemComponents, SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups)
        {
            
            this.Vendor = Vendor;
            
            this.Categories = Categories;
            
            this.Sales = Sales;
            
            this.ItemComponents = ItemComponents;
            
            this.CurrencyLookups = CurrencyLookups;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyVendorResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyVendorResponseBuilder</returns>
        public static DestinyResponsesDestinyVendorResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyVendorResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyVendorResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyVendorResponseBuilder</returns>
        public DestinyResponsesDestinyVendorResponseBuilder With()
        {
            return Builder()
                .Vendor(Vendor)
                .Categories(Categories)
                .Sales(Sales)
                .ItemComponents(ItemComponents)
                .CurrencyLookups(CurrencyLookups);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyVendorResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyVendorResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyVendorResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyVendorResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyVendorResponse left, DestinyResponsesDestinyVendorResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyVendorResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyVendorResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyVendorResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyVendorResponse left, DestinyResponsesDestinyVendorResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyVendorResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyVendorResponseBuilder
        {
            private SingleComponentResponseOfDestinyVendorComponent _Vendor;
            private SingleComponentResponseOfDestinyVendorCategoriesComponent _Categories;
            private DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent _Sales;
            private DestinyItemComponentSetOfint32 _ItemComponents;
            private SingleComponentResponseOfDestinyCurrenciesComponent _CurrencyLookups;

            internal DestinyResponsesDestinyVendorResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorResponse.Vendor property.
            /// </summary>
            /// <param name="value">The base properties of the vendor.  COMPONENT TYPE: Vendors</param>
            public DestinyResponsesDestinyVendorResponseBuilder Vendor(SingleComponentResponseOfDestinyVendorComponent value)
            {
                _Vendor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorResponse.Categories property.
            /// </summary>
            /// <param name="value">Categories that the vendor has available, and references to the sales therein.  COMPONENT TYPE: VendorCategories</param>
            public DestinyResponsesDestinyVendorResponseBuilder Categories(SingleComponentResponseOfDestinyVendorCategoriesComponent value)
            {
                _Categories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorResponse.Sales property.
            /// </summary>
            /// <param name="value">Sales, keyed by the vendorItemIndex of the item being sold.  COMPONENT TYPE: VendorSales</param>
            public DestinyResponsesDestinyVendorResponseBuilder Sales(DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent value)
            {
                _Sales = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorResponse.ItemComponents property.
            /// </summary>
            /// <param name="value">Item components, keyed by the vendorItemIndex of the active sale items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</param>
            public DestinyResponsesDestinyVendorResponseBuilder ItemComponents(DestinyItemComponentSetOfint32 value)
            {
                _ItemComponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorResponse.CurrencyLookups property.
            /// </summary>
            /// <param name="value">A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</param>
            public DestinyResponsesDestinyVendorResponseBuilder CurrencyLookups(SingleComponentResponseOfDestinyCurrenciesComponent value)
            {
                _CurrencyLookups = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyVendorResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyVendorResponse</returns>
            public DestinyResponsesDestinyVendorResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyVendorResponse(
                    Vendor: _Vendor,
                    Categories: _Categories,
                    Sales: _Sales,
                    ItemComponents: _ItemComponents,
                    CurrencyLookups: _CurrencyLookups
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}