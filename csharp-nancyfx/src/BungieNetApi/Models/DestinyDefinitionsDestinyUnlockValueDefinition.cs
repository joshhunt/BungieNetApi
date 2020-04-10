using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An Unlock Value is an internal integer value, stored on the server and used in a variety of ways, most frequently for the gating/requirement checks that the game performs across all of its main features. They can also be used as the storage data for mapped Progressions, Objectives, and other features that require storage of variable numeric values.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyUnlockValueDefinition:  IEquatable<DestinyDefinitionsDestinyUnlockValueDefinition>
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
        /// Use DestinyDefinitionsDestinyUnlockValueDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyUnlockValueDefinition()
        {
        }

        private DestinyDefinitionsDestinyUnlockValueDefinition(int? Hash, int? Index, bool? Redacted)
        {
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyUnlockValueDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyUnlockValueDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyUnlockValueDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyUnlockValueDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyUnlockValueDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyUnlockValueDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyUnlockValueDefinitionBuilder With()
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

        public bool Equals(DestinyDefinitionsDestinyUnlockValueDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyUnlockValueDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyUnlockValueDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyUnlockValueDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyUnlockValueDefinition left, DestinyDefinitionsDestinyUnlockValueDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyUnlockValueDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyUnlockValueDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyUnlockValueDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyUnlockValueDefinition left, DestinyDefinitionsDestinyUnlockValueDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyUnlockValueDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyUnlockValueDefinitionBuilder
        {
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyUnlockValueDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyUnlockValueDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyUnlockValueDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyUnlockValueDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyUnlockValueDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyUnlockValueDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyUnlockValueDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyUnlockValueDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyUnlockValueDefinition</returns>
            public DestinyDefinitionsDestinyUnlockValueDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyUnlockValueDefinition(
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