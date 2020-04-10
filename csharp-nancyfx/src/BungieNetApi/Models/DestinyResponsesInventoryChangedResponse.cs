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
    public sealed class DestinyResponsesInventoryChangedResponse:  IEquatable<DestinyResponsesInventoryChangedResponse>
    { 
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
        /// Use DestinyResponsesInventoryChangedResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesInventoryChangedResponse()
        {
        }

        private DestinyResponsesInventoryChangedResponse(List<DestinyEntitiesItemsDestinyItemComponent> AddedInventoryItems, List<DestinyEntitiesItemsDestinyItemComponent> RemovedInventoryItems)
        {
            
            this.AddedInventoryItems = AddedInventoryItems;
            
            this.RemovedInventoryItems = RemovedInventoryItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesInventoryChangedResponse.
        /// </summary>
        /// <returns>DestinyResponsesInventoryChangedResponseBuilder</returns>
        public static DestinyResponsesInventoryChangedResponseBuilder Builder()
        {
            return new DestinyResponsesInventoryChangedResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesInventoryChangedResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesInventoryChangedResponseBuilder</returns>
        public DestinyResponsesInventoryChangedResponseBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyResponsesInventoryChangedResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesInventoryChangedResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesInventoryChangedResponse</param>
        /// <param name="right">Compared (DestinyResponsesInventoryChangedResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesInventoryChangedResponse left, DestinyResponsesInventoryChangedResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesInventoryChangedResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesInventoryChangedResponse</param>
        /// <param name="right">Compared (DestinyResponsesInventoryChangedResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesInventoryChangedResponse left, DestinyResponsesInventoryChangedResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesInventoryChangedResponse.
        /// </summary>
        public sealed class DestinyResponsesInventoryChangedResponseBuilder
        {
            private List<DestinyEntitiesItemsDestinyItemComponent> _AddedInventoryItems;
            private List<DestinyEntitiesItemsDestinyItemComponent> _RemovedInventoryItems;

            internal DestinyResponsesInventoryChangedResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesInventoryChangedResponse.AddedInventoryItems property.
            /// </summary>
            /// <param name="value">Items that appeared in the inventory possibly as a result of an action.</param>
            public DestinyResponsesInventoryChangedResponseBuilder AddedInventoryItems(List<DestinyEntitiesItemsDestinyItemComponent> value)
            {
                _AddedInventoryItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesInventoryChangedResponse.RemovedInventoryItems property.
            /// </summary>
            /// <param name="value">Items that disappeared from the inventory possibly as a result of an action.</param>
            public DestinyResponsesInventoryChangedResponseBuilder RemovedInventoryItems(List<DestinyEntitiesItemsDestinyItemComponent> value)
            {
                _RemovedInventoryItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesInventoryChangedResponse.
            /// </summary>
            /// <returns>DestinyResponsesInventoryChangedResponse</returns>
            public DestinyResponsesInventoryChangedResponse Build()
            {
                Validate();
                return new DestinyResponsesInventoryChangedResponse(
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