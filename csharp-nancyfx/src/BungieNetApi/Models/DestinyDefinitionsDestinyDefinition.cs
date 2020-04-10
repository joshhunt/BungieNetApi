using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Provides common properties for destiny definitions.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyDefinition:  IEquatable<DestinyDefinitionsDestinyDefinition>
    { 
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
        /// Use DestinyDefinitionsDestinyDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyDefinition()
        {
        }

        private DestinyDefinitionsDestinyDefinition(int? Hash, int? Index, bool? Redacted)
        {
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyDefinitionBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyDefinitionsDestinyDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyDefinition left, DestinyDefinitionsDestinyDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyDefinition left, DestinyDefinitionsDestinyDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyDefinitionBuilder
        {
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyDefinition</returns>
            public DestinyDefinitionsDestinyDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyDefinition(
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