using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsCollectiblesDestinyCollectiblesComponent
    /// </summary>
    public sealed class DestinyComponentsCollectiblesDestinyCollectiblesComponent:  IEquatable<DestinyComponentsCollectiblesDestinyCollectiblesComponent>
    { 
        /// <summary>
        /// Collectibles
        /// </summary>
        public Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> Collectibles { get; private set; }

        /// <summary>
        /// The hash for the root presentation node definition of Collection categories.
        /// </summary>
        public int? CollectionCategoriesRootNodeHash { get; private set; }

        /// <summary>
        /// The hash for the root presentation node definition of Collection Badges.
        /// </summary>
        public int? CollectionBadgesRootNodeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsCollectiblesDestinyCollectiblesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsCollectiblesDestinyCollectiblesComponent()
        {
        }

        private DestinyComponentsCollectiblesDestinyCollectiblesComponent(Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> Collectibles, int? CollectionCategoriesRootNodeHash, int? CollectionBadgesRootNodeHash)
        {
            
            this.Collectibles = Collectibles;
            
            this.CollectionCategoriesRootNodeHash = CollectionCategoriesRootNodeHash;
            
            this.CollectionBadgesRootNodeHash = CollectionBadgesRootNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsCollectiblesDestinyCollectiblesComponent.
        /// </summary>
        /// <returns>DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder</returns>
        public static DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder Builder()
        {
            return new DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder</returns>
        public DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder With()
        {
            return Builder()
                .Collectibles(Collectibles)
                .CollectionCategoriesRootNodeHash(CollectionCategoriesRootNodeHash)
                .CollectionBadgesRootNodeHash(CollectionBadgesRootNodeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsCollectiblesDestinyCollectiblesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsCollectiblesDestinyCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsCollectiblesDestinyCollectiblesComponent</param>
        /// <param name="right">Compared (DestinyComponentsCollectiblesDestinyCollectiblesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsCollectiblesDestinyCollectiblesComponent left, DestinyComponentsCollectiblesDestinyCollectiblesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsCollectiblesDestinyCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsCollectiblesDestinyCollectiblesComponent</param>
        /// <param name="right">Compared (DestinyComponentsCollectiblesDestinyCollectiblesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsCollectiblesDestinyCollectiblesComponent left, DestinyComponentsCollectiblesDestinyCollectiblesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsCollectiblesDestinyCollectiblesComponent.
        /// </summary>
        public sealed class DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> _Collectibles;
            private int? _CollectionCategoriesRootNodeHash;
            private int? _CollectionBadgesRootNodeHash;

            internal DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyCollectiblesComponent.Collectibles property.
            /// </summary>
            /// <param name="value">Collectibles</param>
            public DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder Collectibles(Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> value)
            {
                _Collectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyCollectiblesComponent.CollectionCategoriesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Collection categories.</param>
            public DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder CollectionCategoriesRootNodeHash(int? value)
            {
                _CollectionCategoriesRootNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyCollectiblesComponent.CollectionBadgesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Collection Badges.</param>
            public DestinyComponentsCollectiblesDestinyCollectiblesComponentBuilder CollectionBadgesRootNodeHash(int? value)
            {
                _CollectionBadgesRootNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsCollectiblesDestinyCollectiblesComponent.
            /// </summary>
            /// <returns>DestinyComponentsCollectiblesDestinyCollectiblesComponent</returns>
            public DestinyComponentsCollectiblesDestinyCollectiblesComponent Build()
            {
                Validate();
                return new DestinyComponentsCollectiblesDestinyCollectiblesComponent(
                    Collectibles: _Collectibles,
                    CollectionCategoriesRootNodeHash: _CollectionCategoriesRootNodeHash,
                    CollectionBadgesRootNodeHash: _CollectionBadgesRootNodeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}