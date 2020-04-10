using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An intrinsic perk on an item, and the requirements for it to be activated.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemPerkEntryDefinition:  IEquatable<DestinyDefinitionsDestinyItemPerkEntryDefinition>
    { 
        /// <summary>
        /// If this perk is not active, this is the string to show for why it&#39;s not providing its benefits.
        /// </summary>
        public string RequirementDisplayString { get; private set; }

        /// <summary>
        /// A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
        /// </summary>
        public int? PerkHash { get; private set; }

        /// <summary>
        /// Indicates whether this perk should be shown, or if it should be shown disabled.
        /// </summary>
        public int? PerkVisibility { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemPerkEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemPerkEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemPerkEntryDefinition(string RequirementDisplayString, int? PerkHash, int? PerkVisibility)
        {
            
            this.RequirementDisplayString = RequirementDisplayString;
            
            this.PerkHash = PerkHash;
            
            this.PerkVisibility = PerkVisibility;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemPerkEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder With()
        {
            return Builder()
                .RequirementDisplayString(RequirementDisplayString)
                .PerkHash(PerkHash)
                .PerkVisibility(PerkVisibility);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemPerkEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemPerkEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemPerkEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemPerkEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemPerkEntryDefinition left, DestinyDefinitionsDestinyItemPerkEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemPerkEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemPerkEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemPerkEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemPerkEntryDefinition left, DestinyDefinitionsDestinyItemPerkEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemPerkEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder
        {
            private string _RequirementDisplayString;
            private int? _PerkHash;
            private int? _PerkVisibility;

            internal DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPerkEntryDefinition.RequirementDisplayString property.
            /// </summary>
            /// <param name="value">If this perk is not active, this is the string to show for why it&#39;s not providing its benefits.</param>
            public DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder RequirementDisplayString(string value)
            {
                _RequirementDisplayString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPerkEntryDefinition.PerkHash property.
            /// </summary>
            /// <param name="value">A hash identifier for the DestinySandboxPerkDefinition being provided on the item.</param>
            public DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder PerkHash(int? value)
            {
                _PerkHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPerkEntryDefinition.PerkVisibility property.
            /// </summary>
            /// <param name="value">Indicates whether this perk should be shown, or if it should be shown disabled.</param>
            public DestinyDefinitionsDestinyItemPerkEntryDefinitionBuilder PerkVisibility(int? value)
            {
                _PerkVisibility = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemPerkEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemPerkEntryDefinition</returns>
            public DestinyDefinitionsDestinyItemPerkEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemPerkEntryDefinition(
                    RequirementDisplayString: _RequirementDisplayString,
                    PerkHash: _PerkHash,
                    PerkVisibility: _PerkVisibility
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}