using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines the conditions under which an intrinsic perk is applied while participating in an Objective.  These perks will generally not be benefit-granting perks, but rather a perk that modifies gameplay in some interesting way.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyObjectivePerkEntryDefinition:  IEquatable<DestinyDefinitionsDestinyObjectivePerkEntryDefinition>
    { 
        /// <summary>
        /// The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.
        /// </summary>
        public int? PerkHash { get; private set; }

        /// <summary>
        /// An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed.
        /// </summary>
        public int? Style { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyObjectivePerkEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyObjectivePerkEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyObjectivePerkEntryDefinition(int? PerkHash, int? Style)
        {
            
            this.PerkHash = PerkHash;
            
            this.Style = Style;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyObjectivePerkEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder With()
        {
            return Builder()
                .PerkHash(PerkHash)
                .Style(Style);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyObjectivePerkEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyObjectivePerkEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectivePerkEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectivePerkEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyObjectivePerkEntryDefinition left, DestinyDefinitionsDestinyObjectivePerkEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyObjectivePerkEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectivePerkEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectivePerkEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyObjectivePerkEntryDefinition left, DestinyDefinitionsDestinyObjectivePerkEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyObjectivePerkEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder
        {
            private int? _PerkHash;
            private int? _Style;

            internal DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectivePerkEntryDefinition.PerkHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.</param>
            public DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder PerkHash(int? value)
            {
                _PerkHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectivePerkEntryDefinition.Style property.
            /// </summary>
            /// <param name="value">An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed.</param>
            public DestinyDefinitionsDestinyObjectivePerkEntryDefinitionBuilder Style(int? value)
            {
                _Style = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyObjectivePerkEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyObjectivePerkEntryDefinition</returns>
            public DestinyDefinitionsDestinyObjectivePerkEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyObjectivePerkEntryDefinition(
                    PerkHash: _PerkHash,
                    Style: _Style
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}