using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represent a set of material requirements: Items that either need to be owned or need to be consumed in order to perform an action.  A variety of other entities refer to these as gatekeepers and payments for actions that can be performed in game.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyMaterialRequirementSetDefinition:  IEquatable<DestinyDefinitionsDestinyMaterialRequirementSetDefinition>
    { 
        /// <summary>
        /// The list of all materials that are required.
        /// </summary>
        public List<DestinyDefinitionsDestinyMaterialRequirement> Materials { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyMaterialRequirementSetDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyMaterialRequirementSetDefinition()
        {
        }

        private DestinyDefinitionsDestinyMaterialRequirementSetDefinition(List<DestinyDefinitionsDestinyMaterialRequirement> Materials, int? Hash, int? Index, bool? Redacted)
        {
            
            this.Materials = Materials;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyMaterialRequirementSetDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder With()
        {
            return Builder()
                .Materials(Materials)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyMaterialRequirementSetDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyMaterialRequirementSetDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyMaterialRequirementSetDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyMaterialRequirementSetDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyMaterialRequirementSetDefinition left, DestinyDefinitionsDestinyMaterialRequirementSetDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyMaterialRequirementSetDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyMaterialRequirementSetDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyMaterialRequirementSetDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyMaterialRequirementSetDefinition left, DestinyDefinitionsDestinyMaterialRequirementSetDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyMaterialRequirementSetDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder
        {
            private List<DestinyDefinitionsDestinyMaterialRequirement> _Materials;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirementSetDefinition.Materials property.
            /// </summary>
            /// <param name="value">The list of all materials that are required.</param>
            public DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder Materials(List<DestinyDefinitionsDestinyMaterialRequirement> value)
            {
                _Materials = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirementSetDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirementSetDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirementSetDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyMaterialRequirementSetDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyMaterialRequirementSetDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyMaterialRequirementSetDefinition</returns>
            public DestinyDefinitionsDestinyMaterialRequirementSetDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyMaterialRequirementSetDefinition(
                    Materials: _Materials,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}