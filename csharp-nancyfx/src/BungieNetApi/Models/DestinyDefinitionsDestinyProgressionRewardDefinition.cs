using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Inventory Items can reward progression when actions are performed on them. A common example of this in Destiny 1 was Bounties, which would reward Experience on your Character and the like when you completed the bounty.  Note that this maps to a DestinyProgressionMappingDefinition, and *not* a DestinyProgressionDefinition directly. This is apparently so that multiple progressions can be granted progression points/experience at the same time.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyProgressionRewardDefinition:  IEquatable<DestinyDefinitionsDestinyProgressionRewardDefinition>
    { 
        /// <summary>
        /// The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.
        /// </summary>
        public int? ProgressionMappingHash { get; private set; }

        /// <summary>
        /// The amount of experience to give to each of the mapped progressions.
        /// </summary>
        public int? Amount { get; private set; }

        /// <summary>
        /// If true, the game&#39;s internal mechanisms to throttle progression should be applied.
        /// </summary>
        public bool? ApplyThrottles { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyProgressionRewardDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyProgressionRewardDefinition()
        {
        }

        private DestinyDefinitionsDestinyProgressionRewardDefinition(int? ProgressionMappingHash, int? Amount, bool? ApplyThrottles)
        {
            
            this.ProgressionMappingHash = ProgressionMappingHash;
            
            this.Amount = Amount;
            
            this.ApplyThrottles = ApplyThrottles;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyProgressionRewardDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder With()
        {
            return Builder()
                .ProgressionMappingHash(ProgressionMappingHash)
                .Amount(Amount)
                .ApplyThrottles(ApplyThrottles);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyProgressionRewardDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyProgressionRewardDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionRewardDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionRewardDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyProgressionRewardDefinition left, DestinyDefinitionsDestinyProgressionRewardDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyProgressionRewardDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionRewardDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionRewardDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyProgressionRewardDefinition left, DestinyDefinitionsDestinyProgressionRewardDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyProgressionRewardDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder
        {
            private int? _ProgressionMappingHash;
            private int? _Amount;
            private bool? _ApplyThrottles;

            internal DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardDefinition.ProgressionMappingHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.</param>
            public DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder ProgressionMappingHash(int? value)
            {
                _ProgressionMappingHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardDefinition.Amount property.
            /// </summary>
            /// <param name="value">The amount of experience to give to each of the mapped progressions.</param>
            public DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder Amount(int? value)
            {
                _Amount = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardDefinition.ApplyThrottles property.
            /// </summary>
            /// <param name="value">If true, the game&#39;s internal mechanisms to throttle progression should be applied.</param>
            public DestinyDefinitionsDestinyProgressionRewardDefinitionBuilder ApplyThrottles(bool? value)
            {
                _ApplyThrottles = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyProgressionRewardDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyProgressionRewardDefinition</returns>
            public DestinyDefinitionsDestinyProgressionRewardDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyProgressionRewardDefinition(
                    ProgressionMappingHash: _ProgressionMappingHash,
                    Amount: _Amount,
                    ApplyThrottles: _ApplyThrottles
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}