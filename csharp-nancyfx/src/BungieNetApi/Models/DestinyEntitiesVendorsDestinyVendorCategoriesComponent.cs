using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A vendor can have many categories of items that they sell. This component will return the category information for available items, as well as the index into those items in the user&#39;s sale item list.  Note that, since both the category and items are indexes, this data is Content Version dependent. Be sure to check that your content is up to date before using this data. This is an unfortunate, but permanent, limitation of Vendor data.
    /// </summary>
    public sealed class DestinyEntitiesVendorsDestinyVendorCategoriesComponent:  IEquatable<DestinyEntitiesVendorsDestinyVendorCategoriesComponent>
    { 
        /// <summary>
        /// The list of categories for items that the vendor sells, in rendering order.  These categories each point to a \&quot;display category\&quot; in the displayCategories property of the DestinyVendorDefinition, as opposed to the other categories.
        /// </summary>
        public List<DestinyEntitiesVendorsDestinyVendorCategory> Categories { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesVendorsDestinyVendorCategoriesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesVendorsDestinyVendorCategoriesComponent()
        {
        }

        private DestinyEntitiesVendorsDestinyVendorCategoriesComponent(List<DestinyEntitiesVendorsDestinyVendorCategory> Categories)
        {
            
            this.Categories = Categories;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesVendorsDestinyVendorCategoriesComponent.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder</returns>
        public static DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder Builder()
        {
            return new DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder</returns>
        public DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder With()
        {
            return Builder()
                .Categories(Categories);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesVendorsDestinyVendorCategoriesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesVendorsDestinyVendorCategoriesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorCategoriesComponent</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorCategoriesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesVendorsDestinyVendorCategoriesComponent left, DestinyEntitiesVendorsDestinyVendorCategoriesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesVendorsDestinyVendorCategoriesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorCategoriesComponent</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorCategoriesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesVendorsDestinyVendorCategoriesComponent left, DestinyEntitiesVendorsDestinyVendorCategoriesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesVendorsDestinyVendorCategoriesComponent.
        /// </summary>
        public sealed class DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder
        {
            private List<DestinyEntitiesVendorsDestinyVendorCategory> _Categories;

            internal DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorCategoriesComponent.Categories property.
            /// </summary>
            /// <param name="value">The list of categories for items that the vendor sells, in rendering order.  These categories each point to a \&quot;display category\&quot; in the displayCategories property of the DestinyVendorDefinition, as opposed to the other categories.</param>
            public DestinyEntitiesVendorsDestinyVendorCategoriesComponentBuilder Categories(List<DestinyEntitiesVendorsDestinyVendorCategory> value)
            {
                _Categories = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesVendorsDestinyVendorCategoriesComponent.
            /// </summary>
            /// <returns>DestinyEntitiesVendorsDestinyVendorCategoriesComponent</returns>
            public DestinyEntitiesVendorsDestinyVendorCategoriesComponent Build()
            {
                Validate();
                return new DestinyEntitiesVendorsDestinyVendorCategoriesComponent(
                    Categories: _Categories
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}