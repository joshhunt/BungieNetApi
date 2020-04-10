using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent
    /// </summary>
    public sealed class DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent:  IEquatable<DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent>
    { 
        /// <summary>
        /// The list of collectibles determined by the game as having been \&quot;recently\&quot; acquired.
        /// </summary>
        public List<int?> RecentCollectibleHashes { get; private set; }

        /// <summary>
        /// The list of collectibles determined by the game as having been \&quot;recently\&quot; acquired.  The game client itself actually controls this data, so I personally question whether anyone will get much use out of this: because we can&#39;t edit this value through the API. But in case anyone finds it useful, here it is.
        /// </summary>
        public List<int?> NewnessFlaggedCollectibleHashes { get; private set; }

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
        /// Use DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent()
        {
        }

        private DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent(List<int?> RecentCollectibleHashes, List<int?> NewnessFlaggedCollectibleHashes, Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> Collectibles, int? CollectionCategoriesRootNodeHash, int? CollectionBadgesRootNodeHash)
        {
            
            this.RecentCollectibleHashes = RecentCollectibleHashes;
            
            this.NewnessFlaggedCollectibleHashes = NewnessFlaggedCollectibleHashes;
            
            this.Collectibles = Collectibles;
            
            this.CollectionCategoriesRootNodeHash = CollectionCategoriesRootNodeHash;
            
            this.CollectionBadgesRootNodeHash = CollectionBadgesRootNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.
        /// </summary>
        /// <returns>DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder</returns>
        public static DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder Builder()
        {
            return new DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder</returns>
        public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder With()
        {
            return Builder()
                .RecentCollectibleHashes(RecentCollectibleHashes)
                .NewnessFlaggedCollectibleHashes(NewnessFlaggedCollectibleHashes)
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

        public bool Equals(DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent</param>
        /// <param name="right">Compared (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent left, DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent</param>
        /// <param name="right">Compared (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent left, DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.
        /// </summary>
        public sealed class DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder
        {
            private List<int?> _RecentCollectibleHashes;
            private List<int?> _NewnessFlaggedCollectibleHashes;
            private Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> _Collectibles;
            private int? _CollectionCategoriesRootNodeHash;
            private int? _CollectionBadgesRootNodeHash;

            internal DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.RecentCollectibleHashes property.
            /// </summary>
            /// <param name="value">The list of collectibles determined by the game as having been \&quot;recently\&quot; acquired.</param>
            public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder RecentCollectibleHashes(List<int?> value)
            {
                _RecentCollectibleHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.NewnessFlaggedCollectibleHashes property.
            /// </summary>
            /// <param name="value">The list of collectibles determined by the game as having been \&quot;recently\&quot; acquired.  The game client itself actually controls this data, so I personally question whether anyone will get much use out of this: because we can&#39;t edit this value through the API. But in case anyone finds it useful, here it is.</param>
            public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder NewnessFlaggedCollectibleHashes(List<int?> value)
            {
                _NewnessFlaggedCollectibleHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.Collectibles property.
            /// </summary>
            /// <param name="value">Collectibles</param>
            public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder Collectibles(Dictionary<string, DestinyComponentsCollectiblesDestinyCollectibleComponent> value)
            {
                _Collectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.CollectionCategoriesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Collection categories.</param>
            public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder CollectionCategoriesRootNodeHash(int? value)
            {
                _CollectionCategoriesRootNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.CollectionBadgesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Collection Badges.</param>
            public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponentBuilder CollectionBadgesRootNodeHash(int? value)
            {
                _CollectionBadgesRootNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent.
            /// </summary>
            /// <returns>DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent</returns>
            public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent Build()
            {
                Validate();
                return new DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent(
                    RecentCollectibleHashes: _RecentCollectibleHashes,
                    NewnessFlaggedCollectibleHashes: _NewnessFlaggedCollectibleHashes,
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