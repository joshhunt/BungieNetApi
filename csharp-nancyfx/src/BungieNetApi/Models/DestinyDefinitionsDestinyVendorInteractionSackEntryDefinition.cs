using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Compare this sackType to the sack identifier in the DestinyInventoryItemDefinition.vendorSackType property of items. If they match, show this sack with this interaction.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition:  IEquatable<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition>
    { 
        /// <summary>
        /// SackType
        /// </summary>
        public int? SackType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition(int? SackType)
        {
            
            this.SackType = SackType;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder With()
        {
            return Builder()
                .SackType(SackType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition left, DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition left, DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder
        {
            private int? _SackType;

            internal DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.SackType property.
            /// </summary>
            /// <param name="value">SackType</param>
            public DestinyDefinitionsDestinyVendorInteractionSackEntryDefinitionBuilder SackType(int? value)
            {
                _SackType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition</returns>
            public DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition(
                    SackType: _SackType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}