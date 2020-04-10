using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition of a known, reusable plug that can be applied to a socket.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition:  IEquatable<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition>
    { 
        /// <summary>
        /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
        /// </summary>
        public int? PlugItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition(int? PlugItemHash)
        {
            
            this.PlugItemHash = PlugItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder With()
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

        public bool Equals(DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition left, DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition left, DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder
        {
            private int? _PlugItemHash;

            internal DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.PlugItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.</param>
            public DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinitionBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition</returns>
            public DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition(
                    PlugItemHash: _PlugItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}