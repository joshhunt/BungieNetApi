using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A response containing all of the components for all requested vendors.
    /// </summary>
    public sealed class DestinyResponsesDestinyVendorsResponse:  IEquatable<DestinyResponsesDestinyVendorsResponse>
    { 
        /// <summary>
        /// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors
        /// </summary>
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; private set; }

        /// <summary>
        /// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyVendorComponent Vendors { get; private set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; private set; }

        /// <summary>
        /// Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales
        /// </summary>
        public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Sales { get; private set; }

        /// <summary>
        /// The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.  The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor.
        /// </summary>
        public Dictionary<string, DestinyItemComponentSetOfint32> ItemComponents { get; private set; }

        /// <summary>
        /// A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
        /// </summary>
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyVendorsResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyVendorsResponse()
        {
        }

        private DestinyResponsesDestinyVendorsResponse(SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups, DictionaryComponentResponseOfuint32AndDestinyVendorComponent Vendors, DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories, DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Sales, Dictionary<string, DestinyItemComponentSetOfint32> ItemComponents, SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups)
        {
            
            this.VendorGroups = VendorGroups;
            
            this.Vendors = Vendors;
            
            this.Categories = Categories;
            
            this.Sales = Sales;
            
            this.ItemComponents = ItemComponents;
            
            this.CurrencyLookups = CurrencyLookups;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyVendorsResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyVendorsResponseBuilder</returns>
        public static DestinyResponsesDestinyVendorsResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyVendorsResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyVendorsResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyVendorsResponseBuilder</returns>
        public DestinyResponsesDestinyVendorsResponseBuilder With()
        {
            return Builder()
                .VendorGroups(VendorGroups)
                .Vendors(Vendors)
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

        public bool Equals(DestinyResponsesDestinyVendorsResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyVendorsResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyVendorsResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyVendorsResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyVendorsResponse left, DestinyResponsesDestinyVendorsResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyVendorsResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyVendorsResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyVendorsResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyVendorsResponse left, DestinyResponsesDestinyVendorsResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyVendorsResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyVendorsResponseBuilder
        {
            private SingleComponentResponseOfDestinyVendorGroupComponent _VendorGroups;
            private DictionaryComponentResponseOfuint32AndDestinyVendorComponent _Vendors;
            private DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent _Categories;
            private DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent _Sales;
            private Dictionary<string, DestinyItemComponentSetOfint32> _ItemComponents;
            private SingleComponentResponseOfDestinyCurrenciesComponent _CurrencyLookups;

            internal DestinyResponsesDestinyVendorsResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorsResponse.VendorGroups property.
            /// </summary>
            /// <param name="value">For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors</param>
            public DestinyResponsesDestinyVendorsResponseBuilder VendorGroups(SingleComponentResponseOfDestinyVendorGroupComponent value)
            {
                _VendorGroups = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorsResponse.Vendors property.
            /// </summary>
            /// <param name="value">The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors</param>
            public DestinyResponsesDestinyVendorsResponseBuilder Vendors(DictionaryComponentResponseOfuint32AndDestinyVendorComponent value)
            {
                _Vendors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorsResponse.Categories property.
            /// </summary>
            /// <param name="value">Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories</param>
            public DestinyResponsesDestinyVendorsResponseBuilder Categories(DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent value)
            {
                _Categories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorsResponse.Sales property.
            /// </summary>
            /// <param name="value">Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales</param>
            public DestinyResponsesDestinyVendorsResponseBuilder Sales(DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent value)
            {
                _Sales = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorsResponse.ItemComponents property.
            /// </summary>
            /// <param name="value">The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.  The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor.</param>
            public DestinyResponsesDestinyVendorsResponseBuilder ItemComponents(Dictionary<string, DestinyItemComponentSetOfint32> value)
            {
                _ItemComponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyVendorsResponse.CurrencyLookups property.
            /// </summary>
            /// <param name="value">A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</param>
            public DestinyResponsesDestinyVendorsResponseBuilder CurrencyLookups(SingleComponentResponseOfDestinyCurrenciesComponent value)
            {
                _CurrencyLookups = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyVendorsResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyVendorsResponse</returns>
            public DestinyResponsesDestinyVendorsResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyVendorsResponse(
                    VendorGroups: _VendorGroups,
                    Vendors: _Vendors,
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