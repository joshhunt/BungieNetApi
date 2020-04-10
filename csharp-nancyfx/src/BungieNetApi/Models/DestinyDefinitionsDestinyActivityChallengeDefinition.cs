using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a reference to a Challenge, which for now is just an Objective.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityChallengeDefinition:  IEquatable<DestinyDefinitionsDestinyActivityChallengeDefinition>
    { 
        /// <summary>
        /// The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.
        /// </summary>
        public int? ObjectiveHash { get; private set; }

        /// <summary>
        /// The rewards as they&#39;re represented in the UI. Note that they generally link to \&quot;dummy\&quot; items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don&#39;t show the quantity.
        /// </summary>
        public List<DestinyDestinyItemQuantity> DummyRewards { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityChallengeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityChallengeDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityChallengeDefinition(int? ObjectiveHash, List<DestinyDestinyItemQuantity> DummyRewards)
        {
            
            this.ObjectiveHash = ObjectiveHash;
            
            this.DummyRewards = DummyRewards;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityChallengeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder With()
        {
            return Builder()
                .ObjectiveHash(ObjectiveHash)
                .DummyRewards(DummyRewards);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityChallengeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityChallengeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityChallengeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityChallengeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityChallengeDefinition left, DestinyDefinitionsDestinyActivityChallengeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityChallengeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityChallengeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityChallengeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityChallengeDefinition left, DestinyDefinitionsDestinyActivityChallengeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityChallengeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder
        {
            private int? _ObjectiveHash;
            private List<DestinyDestinyItemQuantity> _DummyRewards;

            internal DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityChallengeDefinition.ObjectiveHash property.
            /// </summary>
            /// <param name="value">The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.</param>
            public DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityChallengeDefinition.DummyRewards property.
            /// </summary>
            /// <param name="value">The rewards as they&#39;re represented in the UI. Note that they generally link to \&quot;dummy\&quot; items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don&#39;t show the quantity.</param>
            public DestinyDefinitionsDestinyActivityChallengeDefinitionBuilder DummyRewards(List<DestinyDestinyItemQuantity> value)
            {
                _DummyRewards = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityChallengeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityChallengeDefinition</returns>
            public DestinyDefinitionsDestinyActivityChallengeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityChallengeDefinition(
                    ObjectiveHash: _ObjectiveHash,
                    DummyRewards: _DummyRewards
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}