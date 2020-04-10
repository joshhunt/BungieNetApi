using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A list of minimal information for items in an inventory: be it a character&#39;s inventory, or a Profile&#39;s inventory. (Note that the Vault is a collection of inventory buckets in the Profile&#39;s inventory)  Inventory Items returned here are in a flat list, but importantly they have a bucketHash property that indicates the specific inventory bucket that is holding them. These buckets constitute things like the separate sections of the Vault, the user&#39;s inventory slots, etc. See DestinyInventoryBucketDefinition for more info.
    /// </summary>
    public sealed class DestinyEntitiesInventoryDestinyInventoryComponent:  IEquatable<DestinyEntitiesInventoryDestinyInventoryComponent>
    { 
        /// <summary>
        /// The items in this inventory. If you care to bucket them, use the item&#39;s bucketHash property to group them.
        /// </summary>
        public List<DestinyEntitiesItemsDestinyItemComponent> Items { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesInventoryDestinyInventoryComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesInventoryDestinyInventoryComponent()
        {
        }

        private DestinyEntitiesInventoryDestinyInventoryComponent(List<DestinyEntitiesItemsDestinyItemComponent> Items)
        {
            
            this.Items = Items;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesInventoryDestinyInventoryComponent.
        /// </summary>
        /// <returns>DestinyEntitiesInventoryDestinyInventoryComponentBuilder</returns>
        public static DestinyEntitiesInventoryDestinyInventoryComponentBuilder Builder()
        {
            return new DestinyEntitiesInventoryDestinyInventoryComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesInventoryDestinyInventoryComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesInventoryDestinyInventoryComponentBuilder</returns>
        public DestinyEntitiesInventoryDestinyInventoryComponentBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyEntitiesInventoryDestinyInventoryComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesInventoryDestinyInventoryComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesInventoryDestinyInventoryComponent</param>
        /// <param name="right">Compared (DestinyEntitiesInventoryDestinyInventoryComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesInventoryDestinyInventoryComponent left, DestinyEntitiesInventoryDestinyInventoryComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesInventoryDestinyInventoryComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesInventoryDestinyInventoryComponent</param>
        /// <param name="right">Compared (DestinyEntitiesInventoryDestinyInventoryComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesInventoryDestinyInventoryComponent left, DestinyEntitiesInventoryDestinyInventoryComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesInventoryDestinyInventoryComponent.
        /// </summary>
        public sealed class DestinyEntitiesInventoryDestinyInventoryComponentBuilder
        {
            private List<DestinyEntitiesItemsDestinyItemComponent> _Items;

            internal DestinyEntitiesInventoryDestinyInventoryComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesInventoryDestinyInventoryComponent.Items property.
            /// </summary>
            /// <param name="value">The items in this inventory. If you care to bucket them, use the item&#39;s bucketHash property to group them.</param>
            public DestinyEntitiesInventoryDestinyInventoryComponentBuilder Items(List<DestinyEntitiesItemsDestinyItemComponent> value)
            {
                _Items = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesInventoryDestinyInventoryComponent.
            /// </summary>
            /// <returns>DestinyEntitiesInventoryDestinyInventoryComponent</returns>
            public DestinyEntitiesInventoryDestinyInventoryComponent Build()
            {
                Validate();
                return new DestinyEntitiesInventoryDestinyInventoryComponent(
                    Items: _Items
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}