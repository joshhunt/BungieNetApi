using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Talent nodes have requirements that must be met before they can be activated.  This describes the material costs, the Level of the Talent Grid&#39;s progression required, and other conditional information that limits whether a talent node can be activated.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyNodeActivationRequirement:  IEquatable<DestinyDefinitionsDestinyNodeActivationRequirement>
    { 
        /// <summary>
        /// The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition&#39;s documentation to learn more about Progressions.
        /// </summary>
        public int? GridLevel { get; private set; }

        /// <summary>
        /// The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won&#39;t know which one will be chosen until an instance of the item is created.
        /// </summary>
        public List<int?> MaterialRequirementHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyNodeActivationRequirement.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyNodeActivationRequirement()
        {
        }

        private DestinyDefinitionsDestinyNodeActivationRequirement(int? GridLevel, List<int?> MaterialRequirementHashes)
        {
            
            this.GridLevel = GridLevel;
            
            this.MaterialRequirementHashes = MaterialRequirementHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyNodeActivationRequirement.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyNodeActivationRequirementBuilder</returns>
        public static DestinyDefinitionsDestinyNodeActivationRequirementBuilder Builder()
        {
            return new DestinyDefinitionsDestinyNodeActivationRequirementBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyNodeActivationRequirementBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyNodeActivationRequirementBuilder</returns>
        public DestinyDefinitionsDestinyNodeActivationRequirementBuilder With()
        {
            return Builder()
                .GridLevel(GridLevel)
                .MaterialRequirementHashes(MaterialRequirementHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyNodeActivationRequirement other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyNodeActivationRequirement.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyNodeActivationRequirement</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyNodeActivationRequirement</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyNodeActivationRequirement left, DestinyDefinitionsDestinyNodeActivationRequirement right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyNodeActivationRequirement.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyNodeActivationRequirement</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyNodeActivationRequirement</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyNodeActivationRequirement left, DestinyDefinitionsDestinyNodeActivationRequirement right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyNodeActivationRequirement.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyNodeActivationRequirementBuilder
        {
            private int? _GridLevel;
            private List<int?> _MaterialRequirementHashes;

            internal DestinyDefinitionsDestinyNodeActivationRequirementBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeActivationRequirement.GridLevel property.
            /// </summary>
            /// <param name="value">The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition&#39;s documentation to learn more about Progressions.</param>
            public DestinyDefinitionsDestinyNodeActivationRequirementBuilder GridLevel(int? value)
            {
                _GridLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeActivationRequirement.MaterialRequirementHashes property.
            /// </summary>
            /// <param name="value">The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won&#39;t know which one will be chosen until an instance of the item is created.</param>
            public DestinyDefinitionsDestinyNodeActivationRequirementBuilder MaterialRequirementHashes(List<int?> value)
            {
                _MaterialRequirementHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyNodeActivationRequirement.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyNodeActivationRequirement</returns>
            public DestinyDefinitionsDestinyNodeActivationRequirement Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyNodeActivationRequirement(
                    GridLevel: _GridLevel,
                    MaterialRequirementHashes: _MaterialRequirementHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}