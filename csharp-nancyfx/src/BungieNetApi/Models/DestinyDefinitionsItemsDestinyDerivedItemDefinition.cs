using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is a reference to, and summary data for, a specific item that you can get as a result of Using or Acquiring some other Item (For example, this could be summary information for an Emote that you can get by opening an an Eververse Box) See DestinyDerivedItemCategoryDefinition for more information.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyDerivedItemDefinition:  IEquatable<DestinyDefinitionsItemsDestinyDerivedItemDefinition>
    { 
        /// <summary>
        /// The hash for the DestinyInventoryItemDefinition of this derived item, if there is one. Sometimes we are given this information as a manual override, in which case there won&#39;t be an actual DestinyInventoryItemDefinition for what we display, but you can still show the strings from this object itself.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// The name of the derived item.
        /// </summary>
        public string ItemName { get; private set; }

        /// <summary>
        /// Additional details about the derived item, in addition to the description.
        /// </summary>
        public string ItemDetail { get; private set; }

        /// <summary>
        /// A brief description of the item.
        /// </summary>
        public string ItemDescription { get; private set; }

        /// <summary>
        /// An icon for the item.
        /// </summary>
        public string IconPath { get; private set; }

        /// <summary>
        /// If the item was derived from a \&quot;Preview Vendor\&quot;, this will be an index into the DestinyVendorDefinition&#39;s itemList property. Otherwise, -1.
        /// </summary>
        public int? VendorItemIndex { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyDerivedItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyDerivedItemDefinition()
        {
        }

        private DestinyDefinitionsItemsDestinyDerivedItemDefinition(int? ItemHash, string ItemName, string ItemDetail, string ItemDescription, string IconPath, int? VendorItemIndex)
        {
            
            this.ItemHash = ItemHash;
            
            this.ItemName = ItemName;
            
            this.ItemDetail = ItemDetail;
            
            this.ItemDescription = ItemDescription;
            
            this.IconPath = IconPath;
            
            this.VendorItemIndex = VendorItemIndex;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyDerivedItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder</returns>
        public static DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder</returns>
        public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash)
                .ItemName(ItemName)
                .ItemDetail(ItemDetail)
                .ItemDescription(ItemDescription)
                .IconPath(IconPath)
                .VendorItemIndex(VendorItemIndex);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyDerivedItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyDerivedItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyDerivedItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyDerivedItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyDerivedItemDefinition left, DestinyDefinitionsItemsDestinyDerivedItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyDerivedItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyDerivedItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyDerivedItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyDerivedItemDefinition left, DestinyDefinitionsItemsDestinyDerivedItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyDerivedItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder
        {
            private int? _ItemHash;
            private string _ItemName;
            private string _ItemDetail;
            private string _ItemDescription;
            private string _IconPath;
            private int? _VendorItemIndex;

            internal DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">The hash for the DestinyInventoryItemDefinition of this derived item, if there is one. Sometimes we are given this information as a manual override, in which case there won&#39;t be an actual DestinyInventoryItemDefinition for what we display, but you can still show the strings from this object itself.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemDefinition.ItemName property.
            /// </summary>
            /// <param name="value">The name of the derived item.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder ItemName(string value)
            {
                _ItemName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemDefinition.ItemDetail property.
            /// </summary>
            /// <param name="value">Additional details about the derived item, in addition to the description.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder ItemDetail(string value)
            {
                _ItemDetail = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemDefinition.ItemDescription property.
            /// </summary>
            /// <param name="value">A brief description of the item.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder ItemDescription(string value)
            {
                _ItemDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemDefinition.IconPath property.
            /// </summary>
            /// <param name="value">An icon for the item.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder IconPath(string value)
            {
                _IconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyDerivedItemDefinition.VendorItemIndex property.
            /// </summary>
            /// <param name="value">If the item was derived from a \&quot;Preview Vendor\&quot;, this will be an index into the DestinyVendorDefinition&#39;s itemList property. Otherwise, -1.</param>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinitionBuilder VendorItemIndex(int? value)
            {
                _VendorItemIndex = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyDerivedItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyDerivedItemDefinition</returns>
            public DestinyDefinitionsItemsDestinyDerivedItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyDerivedItemDefinition(
                    ItemHash: _ItemHash,
                    ItemName: _ItemName,
                    ItemDetail: _ItemDetail,
                    ItemDescription: _ItemDescription,
                    IconPath: _IconPath,
                    VendorItemIndex: _VendorItemIndex
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}