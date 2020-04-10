using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Properties of a DestinyInventoryItemDefinition that store all of the information we were able to discern about how the item spawns, and where you can find the item.  Items will have many of these sources, one per level at which it spawns, to try and give more granular data about where items spawn for specific level ranges.
    /// </summary>
    public sealed class DestinyDefinitionsSourcesDestinyItemSourceDefinition:  IEquatable<DestinyDefinitionsSourcesDestinyItemSourceDefinition>
    { 
        /// <summary>
        /// The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.
        /// </summary>
        public int? Level { get; private set; }

        /// <summary>
        /// The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don&#39;t ask Phaedrus about it, he&#39;ll never stop talking and you&#39;ll have to write a book about it.
        /// </summary>
        public int? MinQuality { get; private set; }

        /// <summary>
        /// The maximum quality at which the item spawns for this level.
        /// </summary>
        public int? MaxQuality { get; private set; }

        /// <summary>
        /// The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
        /// </summary>
        public int? MinLevelRequired { get; private set; }

        /// <summary>
        /// The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
        /// </summary>
        public int? MaxLevelRequired { get; private set; }

        /// <summary>
        /// The stats computed for this level/quality range.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> ComputedStats { get; private set; }

        /// <summary>
        /// The DestinyRewardSourceDefinitions found that can spawn the item at this level.
        /// </summary>
        public List<int?> SourceHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsSourcesDestinyItemSourceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSourcesDestinyItemSourceDefinition()
        {
        }

        private DestinyDefinitionsSourcesDestinyItemSourceDefinition(int? Level, int? MinQuality, int? MaxQuality, int? MinLevelRequired, int? MaxLevelRequired, Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> ComputedStats, List<int?> SourceHashes)
        {
            
            this.Level = Level;
            
            this.MinQuality = MinQuality;
            
            this.MaxQuality = MaxQuality;
            
            this.MinLevelRequired = MinLevelRequired;
            
            this.MaxLevelRequired = MaxLevelRequired;
            
            this.ComputedStats = ComputedStats;
            
            this.SourceHashes = SourceHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSourcesDestinyItemSourceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder</returns>
        public static DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder</returns>
        public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder With()
        {
            return Builder()
                .Level(Level)
                .MinQuality(MinQuality)
                .MaxQuality(MaxQuality)
                .MinLevelRequired(MinLevelRequired)
                .MaxLevelRequired(MaxLevelRequired)
                .ComputedStats(ComputedStats)
                .SourceHashes(SourceHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsSourcesDestinyItemSourceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSourcesDestinyItemSourceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSourcesDestinyItemSourceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSourcesDestinyItemSourceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSourcesDestinyItemSourceDefinition left, DestinyDefinitionsSourcesDestinyItemSourceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSourcesDestinyItemSourceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSourcesDestinyItemSourceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSourcesDestinyItemSourceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSourcesDestinyItemSourceDefinition left, DestinyDefinitionsSourcesDestinyItemSourceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSourcesDestinyItemSourceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder
        {
            private int? _Level;
            private int? _MinQuality;
            private int? _MaxQuality;
            private int? _MinLevelRequired;
            private int? _MaxLevelRequired;
            private Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> _ComputedStats;
            private List<int?> _SourceHashes;

            internal DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.Level property.
            /// </summary>
            /// <param name="value">The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder Level(int? value)
            {
                _Level = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.MinQuality property.
            /// </summary>
            /// <param name="value">The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don&#39;t ask Phaedrus about it, he&#39;ll never stop talking and you&#39;ll have to write a book about it.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder MinQuality(int? value)
            {
                _MinQuality = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.MaxQuality property.
            /// </summary>
            /// <param name="value">The maximum quality at which the item spawns for this level.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder MaxQuality(int? value)
            {
                _MaxQuality = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.MinLevelRequired property.
            /// </summary>
            /// <param name="value">The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder MinLevelRequired(int? value)
            {
                _MinLevelRequired = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.MaxLevelRequired property.
            /// </summary>
            /// <param name="value">The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder MaxLevelRequired(int? value)
            {
                _MaxLevelRequired = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.ComputedStats property.
            /// </summary>
            /// <param name="value">The stats computed for this level/quality range.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder ComputedStats(Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> value)
            {
                _ComputedStats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSourcesDestinyItemSourceDefinition.SourceHashes property.
            /// </summary>
            /// <param name="value">The DestinyRewardSourceDefinitions found that can spawn the item at this level.</param>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinitionBuilder SourceHashes(List<int?> value)
            {
                _SourceHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSourcesDestinyItemSourceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSourcesDestinyItemSourceDefinition</returns>
            public DestinyDefinitionsSourcesDestinyItemSourceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSourcesDestinyItemSourceDefinition(
                    Level: _Level,
                    MinQuality: _MinQuality,
                    MaxQuality: _MaxQuality,
                    MinLevelRequired: _MinLevelRequired,
                    MaxLevelRequired: _MaxLevelRequired,
                    ComputedStats: _ComputedStats,
                    SourceHashes: _SourceHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}