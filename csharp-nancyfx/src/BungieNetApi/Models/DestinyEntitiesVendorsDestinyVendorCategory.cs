using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Information about the category and items currently sold in that category.
    /// </summary>
    public sealed class DestinyEntitiesVendorsDestinyVendorCategory:  IEquatable<DestinyEntitiesVendorsDestinyVendorCategory>
    { 
        /// <summary>
        /// An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.
        /// </summary>
        public int? DisplayCategoryIndex { get; private set; }

        /// <summary>
        /// An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.
        /// </summary>
        public List<int?> ItemIndexes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesVendorsDestinyVendorCategory.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesVendorsDestinyVendorCategory()
        {
        }

        private DestinyEntitiesVendorsDestinyVendorCategory(int? DisplayCategoryIndex, List<int?> ItemIndexes)
        {
            
            this.DisplayCategoryIndex = DisplayCategoryIndex;
            
            this.ItemIndexes = ItemIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesVendorsDestinyVendorCategory.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorCategoryBuilder</returns>
        public static DestinyEntitiesVendorsDestinyVendorCategoryBuilder Builder()
        {
            return new DestinyEntitiesVendorsDestinyVendorCategoryBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesVendorsDestinyVendorCategoryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorCategoryBuilder</returns>
        public DestinyEntitiesVendorsDestinyVendorCategoryBuilder With()
        {
            return Builder()
                .DisplayCategoryIndex(DisplayCategoryIndex)
                .ItemIndexes(ItemIndexes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesVendorsDestinyVendorCategory other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesVendorsDestinyVendorCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorCategory</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorCategory</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesVendorsDestinyVendorCategory left, DestinyEntitiesVendorsDestinyVendorCategory right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesVendorsDestinyVendorCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorCategory</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorCategory</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesVendorsDestinyVendorCategory left, DestinyEntitiesVendorsDestinyVendorCategory right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesVendorsDestinyVendorCategory.
        /// </summary>
        public sealed class DestinyEntitiesVendorsDestinyVendorCategoryBuilder
        {
            private int? _DisplayCategoryIndex;
            private List<int?> _ItemIndexes;

            internal DestinyEntitiesVendorsDestinyVendorCategoryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorCategory.DisplayCategoryIndex property.
            /// </summary>
            /// <param name="value">An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.</param>
            public DestinyEntitiesVendorsDestinyVendorCategoryBuilder DisplayCategoryIndex(int? value)
            {
                _DisplayCategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorCategory.ItemIndexes property.
            /// </summary>
            /// <param name="value">An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.</param>
            public DestinyEntitiesVendorsDestinyVendorCategoryBuilder ItemIndexes(List<int?> value)
            {
                _ItemIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesVendorsDestinyVendorCategory.
            /// </summary>
            /// <returns>DestinyEntitiesVendorsDestinyVendorCategory</returns>
            public DestinyEntitiesVendorsDestinyVendorCategory Build()
            {
                Validate();
                return new DestinyEntitiesVendorsDestinyVendorCategory(
                    DisplayCategoryIndex: _DisplayCategoryIndex,
                    ItemIndexes: _ItemIndexes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}