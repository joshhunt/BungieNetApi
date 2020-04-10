using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Used in a number of Destiny contracts to return data about an item stack and its quantity. Can optionally return an itemInstanceId if the item is instanced - in which case, the quantity returned will be 1. If it&#39;s not... uh, let me know okay? Thanks.
    /// </summary>
    public sealed class DestinyDestinyItemQuantity:  IEquatable<DestinyDestinyItemQuantity>
    { 
        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        public int? Quantity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyItemQuantity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyItemQuantity()
        {
        }

        private DestinyDestinyItemQuantity(int? ItemHash, long? ItemInstanceId, int? Quantity)
        {
            
            this.ItemHash = ItemHash;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Quantity = Quantity;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyItemQuantity.
        /// </summary>
        /// <returns>DestinyDestinyItemQuantityBuilder</returns>
        public static DestinyDestinyItemQuantityBuilder Builder()
        {
            return new DestinyDestinyItemQuantityBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyItemQuantityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyItemQuantityBuilder</returns>
        public DestinyDestinyItemQuantityBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash)
                .ItemInstanceId(ItemInstanceId)
                .Quantity(Quantity);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyItemQuantity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyItemQuantity.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyItemQuantity</param>
        /// <param name="right">Compared (DestinyDestinyItemQuantity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyItemQuantity left, DestinyDestinyItemQuantity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyItemQuantity.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyItemQuantity</param>
        /// <param name="right">Compared (DestinyDestinyItemQuantity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyItemQuantity left, DestinyDestinyItemQuantity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyItemQuantity.
        /// </summary>
        public sealed class DestinyDestinyItemQuantityBuilder
        {
            private int? _ItemHash;
            private long? _ItemInstanceId;
            private int? _Quantity;

            internal DestinyDestinyItemQuantityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyItemQuantity.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</param>
            public DestinyDestinyItemQuantityBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyItemQuantity.ItemInstanceId property.
            /// </summary>
            /// <param name="value">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</param>
            public DestinyDestinyItemQuantityBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyItemQuantity.Quantity property.
            /// </summary>
            /// <param name="value">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</param>
            public DestinyDestinyItemQuantityBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyItemQuantity.
            /// </summary>
            /// <returns>DestinyDestinyItemQuantity</returns>
            public DestinyDestinyItemQuantity Build()
            {
                Validate();
                return new DestinyDestinyItemQuantity(
                    ItemHash: _ItemHash,
                    ItemInstanceId: _ItemInstanceId,
                    Quantity: _Quantity
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}