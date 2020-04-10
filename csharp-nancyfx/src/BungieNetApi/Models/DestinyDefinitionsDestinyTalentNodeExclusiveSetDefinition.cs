using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The list of indexes into the Talent Grid&#39;s \&quot;nodes\&quot; property for nodes in this exclusive set. (See DestinyTalentNodeDefinition.nodeIndex)
    /// </summary>
    public sealed class DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition:  IEquatable<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition>
    { 
        /// <summary>
        /// The list of node indexes for the exclusive set. Historically, these were indexes. I would have liked to replace this with nodeHashes for consistency, but it&#39;s way too late for that. (9:09 PM, he&#39;s right!)
        /// </summary>
        public List<int?> NodeIndexes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition()
        {
        }

        private DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition(List<int?> NodeIndexes)
        {
            
            this.NodeIndexes = NodeIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder With()
        {
            return Builder()
                .NodeIndexes(NodeIndexes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition left, DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition left, DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder
        {
            private List<int?> _NodeIndexes;

            internal DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.NodeIndexes property.
            /// </summary>
            /// <param name="value">The list of node indexes for the exclusive set. Historically, these were indexes. I would have liked to replace this with nodeHashes for consistency, but it&#39;s way too late for that. (9:09 PM, he&#39;s right!)</param>
            public DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinitionBuilder NodeIndexes(List<int?> value)
            {
                _NodeIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition</returns>
            public DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition(
                    NodeIndexes: _NodeIndexes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}