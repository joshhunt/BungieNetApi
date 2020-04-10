using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyResponsesDestinyItemChangeResponse
    /// </summary>
    public sealed class DestinyResponsesDestinyItemChangeResponse:  IEquatable<DestinyResponsesDestinyItemChangeResponse>
    { 
        /// <summary>
        /// Item
        /// </summary>
        public DestinyResponsesDestinyItemResponse Item { get; private set; }

        /// <summary>
        /// Items that appeared in the inventory possibly as a result of an action.
        /// </summary>
        public List<DestinyEntitiesItemsDestinyItemComponent> AddedInventoryItems { get; private set; }

        /// <summary>
        /// Items that disappeared from the inventory possibly as a result of an action.
        /// </summary>
        public List<DestinyEntitiesItemsDestinyItemComponent> RemovedInventoryItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyItemChangeResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyItemChangeResponse()
        {
        }

        private DestinyResponsesDestinyItemChangeResponse(DestinyResponsesDestinyItemResponse Item, List<DestinyEntitiesItemsDestinyItemComponent> AddedInventoryItems, List<DestinyEntitiesItemsDestinyItemComponent> RemovedInventoryItems)
        {
            
            this.Item = Item;
            
            this.AddedInventoryItems = AddedInventoryItems;
            
            this.RemovedInventoryItems = RemovedInventoryItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyItemChangeResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyItemChangeResponseBuilder</returns>
        public static DestinyResponsesDestinyItemChangeResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyItemChangeResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyItemChangeResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyItemChangeResponseBuilder</returns>
        public DestinyResponsesDestinyItemChangeResponseBuilder With()
        {
            return Builder()
                .Item(Item)
                .AddedInventoryItems(AddedInventoryItems)
                .RemovedInventoryItems(RemovedInventoryItems);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyItemChangeResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyItemChangeResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyItemChangeResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyItemChangeResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyItemChangeResponse left, DestinyResponsesDestinyItemChangeResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyItemChangeResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyItemChangeResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyItemChangeResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyItemChangeResponse left, DestinyResponsesDestinyItemChangeResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyItemChangeResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyItemChangeResponseBuilder
        {
            private DestinyResponsesDestinyItemResponse _Item;
            private List<DestinyEntitiesItemsDestinyItemComponent> _AddedInventoryItems;
            private List<DestinyEntitiesItemsDestinyItemComponent> _RemovedInventoryItems;

            internal DestinyResponsesDestinyItemChangeResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemChangeResponse.Item property.
            /// </summary>
            /// <param name="value">Item</param>
            public DestinyResponsesDestinyItemChangeResponseBuilder Item(DestinyResponsesDestinyItemResponse value)
            {
                _Item = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemChangeResponse.AddedInventoryItems property.
            /// </summary>
            /// <param name="value">Items that appeared in the inventory possibly as a result of an action.</param>
            public DestinyResponsesDestinyItemChangeResponseBuilder AddedInventoryItems(List<DestinyEntitiesItemsDestinyItemComponent> value)
            {
                _AddedInventoryItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemChangeResponse.RemovedInventoryItems property.
            /// </summary>
            /// <param name="value">Items that disappeared from the inventory possibly as a result of an action.</param>
            public DestinyResponsesDestinyItemChangeResponseBuilder RemovedInventoryItems(List<DestinyEntitiesItemsDestinyItemComponent> value)
            {
                _RemovedInventoryItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyItemChangeResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyItemChangeResponse</returns>
            public DestinyResponsesDestinyItemChangeResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyItemChangeResponse(
                    Item: _Item,
                    AddedInventoryItems: _AddedInventoryItems,
                    RemovedInventoryItems: _RemovedInventoryItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}