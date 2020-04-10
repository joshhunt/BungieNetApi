using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Bare minimum summary information for an item, for the sake of 3D rendering the item.
    /// </summary>
    public sealed class DestinyCharacterDestinyItemPeerView:  IEquatable<DestinyCharacterDestinyItemPeerView>
    { 
        /// <summary>
        /// The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// The list of dyes that have been applied to this item.
        /// </summary>
        public List<DestinyDyeReference> Dyes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyCharacterDestinyItemPeerView.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyCharacterDestinyItemPeerView()
        {
        }

        private DestinyCharacterDestinyItemPeerView(int? ItemHash, List<DestinyDyeReference> Dyes)
        {
            
            this.ItemHash = ItemHash;
            
            this.Dyes = Dyes;
            
        }

        /// <summary>
        /// Returns builder of DestinyCharacterDestinyItemPeerView.
        /// </summary>
        /// <returns>DestinyCharacterDestinyItemPeerViewBuilder</returns>
        public static DestinyCharacterDestinyItemPeerViewBuilder Builder()
        {
            return new DestinyCharacterDestinyItemPeerViewBuilder();
        }

        /// <summary>
        /// Returns DestinyCharacterDestinyItemPeerViewBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyCharacterDestinyItemPeerViewBuilder</returns>
        public DestinyCharacterDestinyItemPeerViewBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash)
                .Dyes(Dyes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyCharacterDestinyItemPeerView other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyCharacterDestinyItemPeerView.
        /// </summary>
        /// <param name="left">Compared (DestinyCharacterDestinyItemPeerView</param>
        /// <param name="right">Compared (DestinyCharacterDestinyItemPeerView</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyCharacterDestinyItemPeerView left, DestinyCharacterDestinyItemPeerView right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyCharacterDestinyItemPeerView.
        /// </summary>
        /// <param name="left">Compared (DestinyCharacterDestinyItemPeerView</param>
        /// <param name="right">Compared (DestinyCharacterDestinyItemPeerView</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyCharacterDestinyItemPeerView left, DestinyCharacterDestinyItemPeerView right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyCharacterDestinyItemPeerView.
        /// </summary>
        public sealed class DestinyCharacterDestinyItemPeerViewBuilder
        {
            private int? _ItemHash;
            private List<DestinyDyeReference> _Dyes;

            internal DestinyCharacterDestinyItemPeerViewBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyItemPeerView.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.</param>
            public DestinyCharacterDestinyItemPeerViewBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyItemPeerView.Dyes property.
            /// </summary>
            /// <param name="value">The list of dyes that have been applied to this item.</param>
            public DestinyCharacterDestinyItemPeerViewBuilder Dyes(List<DestinyDyeReference> value)
            {
                _Dyes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyCharacterDestinyItemPeerView.
            /// </summary>
            /// <returns>DestinyCharacterDestinyItemPeerView</returns>
            public DestinyCharacterDestinyItemPeerView Build()
            {
                Validate();
                return new DestinyCharacterDestinyItemPeerView(
                    ItemHash: _ItemHash,
                    Dyes: _Dyes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}