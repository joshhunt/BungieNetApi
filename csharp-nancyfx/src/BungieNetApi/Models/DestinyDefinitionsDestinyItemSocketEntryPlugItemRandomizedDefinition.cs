using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition:  IEquatable<DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition>
    { 
        /// <summary>
        /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
        /// </summary>
        public int? PlugItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition(int? PlugItemHash)
        {
            
            this.PlugItemHash = PlugItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder With()
        {
            return Builder()
                .PlugItemHash(PlugItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition left, DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition left, DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder
        {
            private int? _PlugItemHash;

            internal DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.PlugItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.</param>
            public DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinitionBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition</returns>
            public DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSocketEntryPlugItemRandomizedDefinition(
                    PlugItemHash: _PlugItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}