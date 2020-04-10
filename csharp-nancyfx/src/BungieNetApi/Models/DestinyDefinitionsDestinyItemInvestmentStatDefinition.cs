using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a \&quot;raw\&quot; investment stat, before calculated stats are calculated and before any DestinyStatGroupDefinition is applied to transform the stat into something closer to what you see in-game.  Because these won&#39;t match what you see in-game, consider carefully whether you really want to use these stats. I have left them in case someone can do something useful or interesting with the pre-processed statistics.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemInvestmentStatDefinition:  IEquatable<DestinyDefinitionsDestinyItemInvestmentStatDefinition>
    { 
        /// <summary>
        /// The hash identifier for the DestinyStatDefinition defining this stat.
        /// </summary>
        public int? StatTypeHash { get; private set; }

        /// <summary>
        /// The raw \&quot;Investment\&quot; value for the stat, before transformations are performed to turn this raw stat into stats that are displayed in the game UI.
        /// </summary>
        public int? Value { get; private set; }

        /// <summary>
        /// If this is true, the stat will only be applied on the item in certain game state conditions, and we can&#39;t know statically whether or not this stat will be applied. Check the \&quot;live\&quot; API data instead for whether this value is being applied on a specific instance of the item in question, and you can use this to decide whether you want to show the stat on the generic view of the item, or whether you want to show some kind of caveat or warning about the stat value being conditional on game state.
        /// </summary>
        public bool? IsConditionallyActive { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemInvestmentStatDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemInvestmentStatDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemInvestmentStatDefinition(int? StatTypeHash, int? Value, bool? IsConditionallyActive)
        {
            
            this.StatTypeHash = StatTypeHash;
            
            this.Value = Value;
            
            this.IsConditionallyActive = IsConditionallyActive;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemInvestmentStatDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder With()
        {
            return Builder()
                .StatTypeHash(StatTypeHash)
                .Value(Value)
                .IsConditionallyActive(IsConditionallyActive);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemInvestmentStatDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemInvestmentStatDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemInvestmentStatDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemInvestmentStatDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemInvestmentStatDefinition left, DestinyDefinitionsDestinyItemInvestmentStatDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemInvestmentStatDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemInvestmentStatDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemInvestmentStatDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemInvestmentStatDefinition left, DestinyDefinitionsDestinyItemInvestmentStatDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemInvestmentStatDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder
        {
            private int? _StatTypeHash;
            private int? _Value;
            private bool? _IsConditionallyActive;

            internal DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInvestmentStatDefinition.StatTypeHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the DestinyStatDefinition defining this stat.</param>
            public DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder StatTypeHash(int? value)
            {
                _StatTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInvestmentStatDefinition.Value property.
            /// </summary>
            /// <param name="value">The raw \&quot;Investment\&quot; value for the stat, before transformations are performed to turn this raw stat into stats that are displayed in the game UI.</param>
            public DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder Value(int? value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInvestmentStatDefinition.IsConditionallyActive property.
            /// </summary>
            /// <param name="value">If this is true, the stat will only be applied on the item in certain game state conditions, and we can&#39;t know statically whether or not this stat will be applied. Check the \&quot;live\&quot; API data instead for whether this value is being applied on a specific instance of the item in question, and you can use this to decide whether you want to show the stat on the generic view of the item, or whether you want to show some kind of caveat or warning about the stat value being conditional on game state.</param>
            public DestinyDefinitionsDestinyItemInvestmentStatDefinitionBuilder IsConditionallyActive(bool? value)
            {
                _IsConditionallyActive = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemInvestmentStatDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemInvestmentStatDefinition</returns>
            public DestinyDefinitionsDestinyItemInvestmentStatDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemInvestmentStatDefinition(
                    StatTypeHash: _StatTypeHash,
                    Value: _Value,
                    IsConditionallyActive: _IsConditionallyActive
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}