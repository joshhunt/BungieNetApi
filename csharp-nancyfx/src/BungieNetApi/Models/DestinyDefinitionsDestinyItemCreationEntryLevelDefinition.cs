using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An overly complicated wrapper for the item level at which the item should spawn.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemCreationEntryLevelDefinition:  IEquatable<DestinyDefinitionsDestinyItemCreationEntryLevelDefinition>
    { 
        /// <summary>
        /// Level
        /// </summary>
        public int? Level { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemCreationEntryLevelDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemCreationEntryLevelDefinition(int? Level)
        {
            
            this.Level = Level;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder With()
        {
            return Builder()
                .Level(Level);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemCreationEntryLevelDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition left, DestinyDefinitionsDestinyItemCreationEntryLevelDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemCreationEntryLevelDefinition left, DestinyDefinitionsDestinyItemCreationEntryLevelDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder
        {
            private int? _Level;

            internal DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.Level property.
            /// </summary>
            /// <param name="value">Level</param>
            public DestinyDefinitionsDestinyItemCreationEntryLevelDefinitionBuilder Level(int? value)
            {
                _Level = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemCreationEntryLevelDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemCreationEntryLevelDefinition</returns>
            public DestinyDefinitionsDestinyItemCreationEntryLevelDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemCreationEntryLevelDefinition(
                    Level: _Level
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}