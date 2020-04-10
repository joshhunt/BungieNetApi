using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines the conditions under which stat modifications will be applied to a Character while participating in an objective.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyObjectiveStatEntryDefinition:  IEquatable<DestinyDefinitionsDestinyObjectiveStatEntryDefinition>
    { 
        /// <summary>
        /// The stat being modified, and the value used.
        /// </summary>
        public DestinyDefinitionsDestinyItemInvestmentStatDefinition Stat { get; private set; }

        /// <summary>
        /// Whether it will be applied as long as the objective is active, when it&#39;s completed, or until it&#39;s completed.
        /// </summary>
        public int? Style { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyObjectiveStatEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyObjectiveStatEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyObjectiveStatEntryDefinition(DestinyDefinitionsDestinyItemInvestmentStatDefinition Stat, int? Style)
        {
            
            this.Stat = Stat;
            
            this.Style = Style;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyObjectiveStatEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder With()
        {
            return Builder()
                .Stat(Stat)
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

        public bool Equals(DestinyDefinitionsDestinyObjectiveStatEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyObjectiveStatEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectiveStatEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectiveStatEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyObjectiveStatEntryDefinition left, DestinyDefinitionsDestinyObjectiveStatEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyObjectiveStatEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectiveStatEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectiveStatEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyObjectiveStatEntryDefinition left, DestinyDefinitionsDestinyObjectiveStatEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyObjectiveStatEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder
        {
            private DestinyDefinitionsDestinyItemInvestmentStatDefinition _Stat;
            private int? _Style;

            internal DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveStatEntryDefinition.Stat property.
            /// </summary>
            /// <param name="value">The stat being modified, and the value used.</param>
            public DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder Stat(DestinyDefinitionsDestinyItemInvestmentStatDefinition value)
            {
                _Stat = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveStatEntryDefinition.Style property.
            /// </summary>
            /// <param name="value">Whether it will be applied as long as the objective is active, when it&#39;s completed, or until it&#39;s completed.</param>
            public DestinyDefinitionsDestinyObjectiveStatEntryDefinitionBuilder Style(int? value)
            {
                _Style = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyObjectiveStatEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyObjectiveStatEntryDefinition</returns>
            public DestinyDefinitionsDestinyObjectiveStatEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyObjectiveStatEntryDefinition(
                    Stat: _Stat,
                    Style: _Style
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}