using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition
    /// </summary>
    public sealed class DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition:  IEquatable<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition>
    { 
        /// <summary>
        /// The identifier of the Plug Item unlocked by activating this item in the Artifact.
        /// </summary>
        public int? ItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition()
        {
        }

        private DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition(int? ItemHash)
        {
            
            this.ItemHash = ItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder</returns>
        public static DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder</returns>
        public DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition left, DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition left, DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder
        {
            private int? _ItemHash;

            internal DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">The identifier of the Plug Item unlocked by activating this item in the Artifact.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition</returns>
            public DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition(
                    ItemHash: _ItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}