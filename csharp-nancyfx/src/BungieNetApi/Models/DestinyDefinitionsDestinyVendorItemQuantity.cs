using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// In addition to item quantity information for vendor prices, this also has any optional information that may exist about how the item&#39;s quantity can be modified. (unfortunately not information that is able to be read outside of the BNet servers, but it&#39;s there)
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorItemQuantity:  IEquatable<DestinyDefinitionsDestinyVendorItemQuantity>
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
        /// Use DestinyDefinitionsDestinyVendorItemQuantity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorItemQuantity()
        {
        }

        private DestinyDefinitionsDestinyVendorItemQuantity(int? ItemHash, long? ItemInstanceId, int? Quantity)
        {
            
            this.ItemHash = ItemHash;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Quantity = Quantity;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorItemQuantity.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorItemQuantityBuilder</returns>
        public static DestinyDefinitionsDestinyVendorItemQuantityBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorItemQuantityBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorItemQuantityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorItemQuantityBuilder</returns>
        public DestinyDefinitionsDestinyVendorItemQuantityBuilder With()
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

        public bool Equals(DestinyDefinitionsDestinyVendorItemQuantity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorItemQuantity.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorItemQuantity</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorItemQuantity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorItemQuantity left, DestinyDefinitionsDestinyVendorItemQuantity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorItemQuantity.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorItemQuantity</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorItemQuantity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorItemQuantity left, DestinyDefinitionsDestinyVendorItemQuantity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorItemQuantity.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorItemQuantityBuilder
        {
            private int? _ItemHash;
            private long? _ItemInstanceId;
            private int? _Quantity;

            internal DestinyDefinitionsDestinyVendorItemQuantityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemQuantity.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</param>
            public DestinyDefinitionsDestinyVendorItemQuantityBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemQuantity.ItemInstanceId property.
            /// </summary>
            /// <param name="value">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</param>
            public DestinyDefinitionsDestinyVendorItemQuantityBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemQuantity.Quantity property.
            /// </summary>
            /// <param name="value">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</param>
            public DestinyDefinitionsDestinyVendorItemQuantityBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorItemQuantity.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorItemQuantity</returns>
            public DestinyDefinitionsDestinyVendorItemQuantity Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorItemQuantity(
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