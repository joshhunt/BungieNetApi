using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The metrics available for display and selection on an item.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemMetricBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemMetricBlockDefinition>
    { 
        /// <summary>
        /// Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list available metrics. Any metric listed directly below these nodes, or in any of these nodes&#39; children will be made available for selection.
        /// </summary>
        public List<int?> AvailableMetricCategoryNodeHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemMetricBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemMetricBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemMetricBlockDefinition(List<int?> AvailableMetricCategoryNodeHashes)
        {
            
            this.AvailableMetricCategoryNodeHashes = AvailableMetricCategoryNodeHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemMetricBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder With()
        {
            return Builder()
                .AvailableMetricCategoryNodeHashes(AvailableMetricCategoryNodeHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemMetricBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemMetricBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemMetricBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemMetricBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemMetricBlockDefinition left, DestinyDefinitionsDestinyItemMetricBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemMetricBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemMetricBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemMetricBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemMetricBlockDefinition left, DestinyDefinitionsDestinyItemMetricBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemMetricBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder
        {
            private List<int?> _AvailableMetricCategoryNodeHashes;

            internal DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemMetricBlockDefinition.AvailableMetricCategoryNodeHashes property.
            /// </summary>
            /// <param name="value">Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list available metrics. Any metric listed directly below these nodes, or in any of these nodes&#39; children will be made available for selection.</param>
            public DestinyDefinitionsDestinyItemMetricBlockDefinitionBuilder AvailableMetricCategoryNodeHashes(List<int?> value)
            {
                _AvailableMetricCategoryNodeHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemMetricBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemMetricBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemMetricBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemMetricBlockDefinition(
                    AvailableMetricCategoryNodeHashes: _AvailableMetricCategoryNodeHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}