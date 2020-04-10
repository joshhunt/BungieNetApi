using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you&#39;ll have to call in the context of a character. I know, sad but true.
    /// </summary>
    public sealed class DestinyResponsesDestinyPublicVendorsResponse:  IEquatable<DestinyResponsesDestinyPublicVendorsResponse>
    { 
        /// <summary>
        /// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors
        /// </summary>
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; private set; }

        /// <summary>
        /// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Vendors { get; private set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; private set; }

        /// <summary>
        /// Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales
        /// </summary>
        public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Sales { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyPublicVendorsResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyPublicVendorsResponse()
        {
        }

        private DestinyResponsesDestinyPublicVendorsResponse(SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups, DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Vendors, DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories, DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Sales)
        {
            
            this.VendorGroups = VendorGroups;
            
            this.Vendors = Vendors;
            
            this.Categories = Categories;
            
            this.Sales = Sales;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyPublicVendorsResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyPublicVendorsResponseBuilder</returns>
        public static DestinyResponsesDestinyPublicVendorsResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyPublicVendorsResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyPublicVendorsResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyPublicVendorsResponseBuilder</returns>
        public DestinyResponsesDestinyPublicVendorsResponseBuilder With()
        {
            return Builder()
                .VendorGroups(VendorGroups)
                .Vendors(Vendors)
                .Categories(Categories)
                .Sales(Sales);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyPublicVendorsResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyPublicVendorsResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyPublicVendorsResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyPublicVendorsResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyPublicVendorsResponse left, DestinyResponsesDestinyPublicVendorsResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyPublicVendorsResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyPublicVendorsResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyPublicVendorsResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyPublicVendorsResponse left, DestinyResponsesDestinyPublicVendorsResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyPublicVendorsResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyPublicVendorsResponseBuilder
        {
            private SingleComponentResponseOfDestinyVendorGroupComponent _VendorGroups;
            private DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent _Vendors;
            private DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent _Categories;
            private DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent _Sales;

            internal DestinyResponsesDestinyPublicVendorsResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyPublicVendorsResponse.VendorGroups property.
            /// </summary>
            /// <param name="value">For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors</param>
            public DestinyResponsesDestinyPublicVendorsResponseBuilder VendorGroups(SingleComponentResponseOfDestinyVendorGroupComponent value)
            {
                _VendorGroups = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyPublicVendorsResponse.Vendors property.
            /// </summary>
            /// <param name="value">The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors</param>
            public DestinyResponsesDestinyPublicVendorsResponseBuilder Vendors(DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent value)
            {
                _Vendors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyPublicVendorsResponse.Categories property.
            /// </summary>
            /// <param name="value">Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories</param>
            public DestinyResponsesDestinyPublicVendorsResponseBuilder Categories(DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent value)
            {
                _Categories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyPublicVendorsResponse.Sales property.
            /// </summary>
            /// <param name="value">Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales</param>
            public DestinyResponsesDestinyPublicVendorsResponseBuilder Sales(DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent value)
            {
                _Sales = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyPublicVendorsResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyPublicVendorsResponse</returns>
            public DestinyResponsesDestinyPublicVendorsResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyPublicVendorsResponse(
                    VendorGroups: _VendorGroups,
                    Vendors: _Vendors,
                    Categories: _Categories,
                    Sales: _Sales
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}