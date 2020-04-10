using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If you want the stats on an item&#39;s instanced data, get this component.  These are stats like Attack, Defense etc... and *not* historical stats.  Note that some stats have additional computation in-game at runtime - for instance, Magazine Size - and thus these stats might not be 100% accurate compared to what you see in-game for some stats. I know, it sucks. I hate it too.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemStatsComponent:  IEquatable<DestinyEntitiesItemsDestinyItemStatsComponent>
    { 
        /// <summary>
        /// If the item has stats that it provides (damage, defense, etc...), it will be given here.
        /// </summary>
        public Dictionary<string, DestinyDestinyStat> Stats { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemStatsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemStatsComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemStatsComponent(Dictionary<string, DestinyDestinyStat> Stats)
        {
            
            this.Stats = Stats;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemStatsComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemStatsComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemStatsComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemStatsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemStatsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemStatsComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemStatsComponentBuilder With()
        {
            return Builder()
                .Stats(Stats);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemStatsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemStatsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemStatsComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemStatsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemStatsComponent left, DestinyEntitiesItemsDestinyItemStatsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemStatsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemStatsComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemStatsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemStatsComponent left, DestinyEntitiesItemsDestinyItemStatsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemStatsComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemStatsComponentBuilder
        {
            private Dictionary<string, DestinyDestinyStat> _Stats;

            internal DestinyEntitiesItemsDestinyItemStatsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemStatsComponent.Stats property.
            /// </summary>
            /// <param name="value">If the item has stats that it provides (damage, defense, etc...), it will be given here.</param>
            public DestinyEntitiesItemsDestinyItemStatsComponentBuilder Stats(Dictionary<string, DestinyDestinyStat> value)
            {
                _Stats = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemStatsComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemStatsComponent</returns>
            public DestinyEntitiesItemsDestinyItemStatsComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemStatsComponent(
                    Stats: _Stats
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}