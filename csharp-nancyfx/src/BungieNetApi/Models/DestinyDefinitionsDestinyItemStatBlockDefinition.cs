using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Information about the item&#39;s calculated stats, with as much data as we can find for the stats without having an actual instance of the item.  Note that this means the entire concept of providing these stats is fundamentally insufficient: we cannot predict with 100% accuracy the conditions under which an item can spawn, so we use various heuristics to attempt to simulate the conditions as accurately as possible. Actual stats for items in-game can and will vary, but these should at least be useful base points for comparison and display.  It is also worth noting that some stats, like Magazine size, have further calculations performed on them by scripts in-game and on the game servers that BNet does not have access to. We cannot know how those stats are further transformed, and thus some stats will be inaccurate even on instances of items in BNet vs. how they appear in-game. This is a known limitation of our item statistics, without any planned fix.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemStatBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemStatBlockDefinition>
    { 
        /// <summary>
        /// If true, the game won&#39;t show the \&quot;primary\&quot; stat on this item when you inspect it.  NOTE: This is being manually mapped, because I happen to want it in a block that isn&#39;t going to directly create this derivative block.
        /// </summary>
        public bool? DisablePrimaryStatDisplay { get; private set; }

        /// <summary>
        /// If the item&#39;s stats are meant to be modified by a DestinyStatGroupDefinition, this will be the identifier for that definition.  If you are using live data or precomputed stats data on the DestinyInventoryItemDefinition.stats.stats property, you don&#39;t have to worry about statGroupHash and how it alters stats: the already altered stats are provided to you. But if you want to see how the sausage gets made, or perform computations yourself, this is valuable information.
        /// </summary>
        public int? StatGroupHash { get; private set; }

        /// <summary>
        /// If you are looking for precomputed values for the stats on a weapon, this is where they are stored. Technically these are the \&quot;Display\&quot; stat values. Please see DestinyStatsDefinition for what Display Stat Values means, it&#39;s a very long story... but essentially these are the closest values BNet can get to the item stats that you see in-game.  These stats are keyed by the DestinyStatDefinition&#39;s hash identifier for the stat that&#39;s found on the item.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> Stats { get; private set; }

        /// <summary>
        /// A quick and lazy way to determine whether any stat other than the \&quot;primary\&quot; stat is actually visible on the item. Items often have stats that we return in case people find them useful, but they&#39;re not part of the \&quot;Stat Group\&quot; and thus we wouldn&#39;t display them in our UI. If this is False, then we&#39;re not going to display any of these stats other than the primary one.
        /// </summary>
        public bool? HasDisplayableStats { get; private set; }

        /// <summary>
        /// This stat is determined to be the \&quot;primary\&quot; stat, and can be looked up in the stats or any other stat collection related to the item.  Use this hash to look up the stat&#39;s value using DestinyInventoryItemDefinition.stats.stats, and the renderable data for the primary stat in the related DestinyStatDefinition.
        /// </summary>
        public int? PrimaryBaseStatHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemStatBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemStatBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemStatBlockDefinition(bool? DisablePrimaryStatDisplay, int? StatGroupHash, Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> Stats, bool? HasDisplayableStats, int? PrimaryBaseStatHash)
        {
            
            this.DisablePrimaryStatDisplay = DisablePrimaryStatDisplay;
            
            this.StatGroupHash = StatGroupHash;
            
            this.Stats = Stats;
            
            this.HasDisplayableStats = HasDisplayableStats;
            
            this.PrimaryBaseStatHash = PrimaryBaseStatHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemStatBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder With()
        {
            return Builder()
                .DisablePrimaryStatDisplay(DisablePrimaryStatDisplay)
                .StatGroupHash(StatGroupHash)
                .Stats(Stats)
                .HasDisplayableStats(HasDisplayableStats)
                .PrimaryBaseStatHash(PrimaryBaseStatHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemStatBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemStatBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemStatBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemStatBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemStatBlockDefinition left, DestinyDefinitionsDestinyItemStatBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemStatBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemStatBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemStatBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemStatBlockDefinition left, DestinyDefinitionsDestinyItemStatBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemStatBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder
        {
            private bool? _DisablePrimaryStatDisplay;
            private int? _StatGroupHash;
            private Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> _Stats;
            private bool? _HasDisplayableStats;
            private int? _PrimaryBaseStatHash;

            internal DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemStatBlockDefinition.DisablePrimaryStatDisplay property.
            /// </summary>
            /// <param name="value">If true, the game won&#39;t show the \&quot;primary\&quot; stat on this item when you inspect it.  NOTE: This is being manually mapped, because I happen to want it in a block that isn&#39;t going to directly create this derivative block.</param>
            public DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder DisablePrimaryStatDisplay(bool? value)
            {
                _DisablePrimaryStatDisplay = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemStatBlockDefinition.StatGroupHash property.
            /// </summary>
            /// <param name="value">If the item&#39;s stats are meant to be modified by a DestinyStatGroupDefinition, this will be the identifier for that definition.  If you are using live data or precomputed stats data on the DestinyInventoryItemDefinition.stats.stats property, you don&#39;t have to worry about statGroupHash and how it alters stats: the already altered stats are provided to you. But if you want to see how the sausage gets made, or perform computations yourself, this is valuable information.</param>
            public DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder StatGroupHash(int? value)
            {
                _StatGroupHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemStatBlockDefinition.Stats property.
            /// </summary>
            /// <param name="value">If you are looking for precomputed values for the stats on a weapon, this is where they are stored. Technically these are the \&quot;Display\&quot; stat values. Please see DestinyStatsDefinition for what Display Stat Values means, it&#39;s a very long story... but essentially these are the closest values BNet can get to the item stats that you see in-game.  These stats are keyed by the DestinyStatDefinition&#39;s hash identifier for the stat that&#39;s found on the item.</param>
            public DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder Stats(Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemStatBlockDefinition.HasDisplayableStats property.
            /// </summary>
            /// <param name="value">A quick and lazy way to determine whether any stat other than the \&quot;primary\&quot; stat is actually visible on the item. Items often have stats that we return in case people find them useful, but they&#39;re not part of the \&quot;Stat Group\&quot; and thus we wouldn&#39;t display them in our UI. If this is False, then we&#39;re not going to display any of these stats other than the primary one.</param>
            public DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder HasDisplayableStats(bool? value)
            {
                _HasDisplayableStats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemStatBlockDefinition.PrimaryBaseStatHash property.
            /// </summary>
            /// <param name="value">This stat is determined to be the \&quot;primary\&quot; stat, and can be looked up in the stats or any other stat collection related to the item.  Use this hash to look up the stat&#39;s value using DestinyInventoryItemDefinition.stats.stats, and the renderable data for the primary stat in the related DestinyStatDefinition.</param>
            public DestinyDefinitionsDestinyItemStatBlockDefinitionBuilder PrimaryBaseStatHash(int? value)
            {
                _PrimaryBaseStatHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemStatBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemStatBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemStatBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemStatBlockDefinition(
                    DisablePrimaryStatDisplay: _DisablePrimaryStatDisplay,
                    StatGroupHash: _StatGroupHash,
                    Stats: _Stats,
                    HasDisplayableStats: _HasDisplayableStats,
                    PrimaryBaseStatHash: _PrimaryBaseStatHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}