using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Returns the detailed information about a Collectible Presentation Node and any Collectibles that are direct descendants.
    /// </summary>
    public sealed class DestinyResponsesDestinyCollectibleNodeDetailResponse:  IEquatable<DestinyResponsesDestinyCollectibleNodeDetailResponse>
    { 
        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; private set; }

        /// <summary>
        /// Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn&#39;t have to have a special override to do the collectible -&gt; item lookup once you delve into an item&#39;s details, and it also meant that you didn&#39;t have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        public DestinyItemComponentSetOfuint32 CollectibleItemComponents { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyCollectibleNodeDetailResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyCollectibleNodeDetailResponse()
        {
        }

        private DestinyResponsesDestinyCollectibleNodeDetailResponse(SingleComponentResponseOfDestinyCollectiblesComponent Collectibles, DestinyItemComponentSetOfuint32 CollectibleItemComponents)
        {
            
            this.Collectibles = Collectibles;
            
            this.CollectibleItemComponents = CollectibleItemComponents;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyCollectibleNodeDetailResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder</returns>
        public static DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder</returns>
        public DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder With()
        {
            return Builder()
                .Collectibles(Collectibles)
                .CollectibleItemComponents(CollectibleItemComponents);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyCollectibleNodeDetailResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyCollectibleNodeDetailResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyCollectibleNodeDetailResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyCollectibleNodeDetailResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyCollectibleNodeDetailResponse left, DestinyResponsesDestinyCollectibleNodeDetailResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyCollectibleNodeDetailResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyCollectibleNodeDetailResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyCollectibleNodeDetailResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyCollectibleNodeDetailResponse left, DestinyResponsesDestinyCollectibleNodeDetailResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyCollectibleNodeDetailResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder
        {
            private SingleComponentResponseOfDestinyCollectiblesComponent _Collectibles;
            private DestinyItemComponentSetOfuint32 _CollectibleItemComponents;

            internal DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCollectibleNodeDetailResponse.Collectibles property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Collectibles</param>
            public DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder Collectibles(SingleComponentResponseOfDestinyCollectiblesComponent value)
            {
                _Collectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCollectibleNodeDetailResponse.CollectibleItemComponents property.
            /// </summary>
            /// <param name="value">Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn&#39;t have to have a special override to do the collectible -&gt; item lookup once you delve into an item&#39;s details, and it also meant that you didn&#39;t have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</param>
            public DestinyResponsesDestinyCollectibleNodeDetailResponseBuilder CollectibleItemComponents(DestinyItemComponentSetOfuint32 value)
            {
                _CollectibleItemComponents = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyCollectibleNodeDetailResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyCollectibleNodeDetailResponse</returns>
            public DestinyResponsesDestinyCollectibleNodeDetailResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyCollectibleNodeDetailResponse(
                    Collectibles: _Collectibles,
                    CollectibleItemComponents: _CollectibleItemComponents
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}