using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A shortcut for the fact that some items have a \&quot;Preview Vendor\&quot; - See DestinyInventoryItemDefinition.preview.previewVendorHash - that is intended to be used to show what items you can get as a result of acquiring or using this item.  A common example of this in Destiny 1 was Eververse \&quot;Boxes,\&quot; which could have many possible items. This \&quot;Preview Vendor\&quot; is not a vendor you can actually see in the game, but it defines categories and sale items for all of the possible items you could get from the Box so that the game can show them to you. We summarize that info here so that you don&#39;t have to do that Vendor lookup and aggregation manually.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition:  IEquatable<DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition>
    { 
        /// <summary>
        /// The localized string for the category title. This will be something describing the items you can get as a group, or your likelihood/the quantity you&#39;ll get.
        /// </summary>
        public string CategoryDescription { get; private set; }

        /// <summary>
        /// This is the list of all of the items for this category and the basic properties we&#39;ll know about them.
        /// </summary>
        public List<DestinyDefinitionsItemsDestinyDerivedItemDefinition> Items { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition()
        {
        }

        private DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition(string CategoryDescription, List<DestinyDefinitionsItemsDestinyDerivedItemDefinition> Items)
        {
            
            this.CategoryDescription = CategoryDescription;
            
            this.Items = Items;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder With()
        {
            return Builder()
                .CategoryDescription(CategoryDescription)
                .Items(Items);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition left, DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition left, DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder
        {
            private string _CategoryDescription;
            private List<DestinyDefinitionsItemsDestinyDerivedItemDefinition> _Items;

            internal DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.CategoryDescription property.
            /// </summary>
            /// <param name="value">The localized string for the category title. This will be something describing the items you can get as a group, or your likelihood/the quantity you&#39;ll get.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder CategoryDescription(string value)
            {
                _CategoryDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.Items property.
            /// </summary>
            /// <param name="value">This is the list of all of the items for this category and the basic properties we&#39;ll know about them.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinitionBuilder Items(List<DestinyDefinitionsItemsDestinyDerivedItemDefinition> value)
            {
                _Items = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition</returns>
            public DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition(
                    CategoryDescription: _CategoryDescription,
                    Items: _Items
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}