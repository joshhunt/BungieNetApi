using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyActivityLoadoutRequirementSet
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityLoadoutRequirementSet:  IEquatable<DestinyDefinitionsDestinyActivityLoadoutRequirementSet>
    { 
        /// <summary>
        /// The set of requirements that will be applied on the activity if this requirement set is active.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityLoadoutRequirement> Requirements { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityLoadoutRequirementSet.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityLoadoutRequirementSet()
        {
        }

        private DestinyDefinitionsDestinyActivityLoadoutRequirementSet(List<DestinyDefinitionsDestinyActivityLoadoutRequirement> Requirements)
        {
            
            this.Requirements = Requirements;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityLoadoutRequirementSet.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder</returns>
        public static DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder</returns>
        public DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder With()
        {
            return Builder()
                .Requirements(Requirements);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityLoadoutRequirementSet other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityLoadoutRequirementSet.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirementSet</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirementSet</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityLoadoutRequirementSet left, DestinyDefinitionsDestinyActivityLoadoutRequirementSet right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityLoadoutRequirementSet.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirementSet</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirementSet</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityLoadoutRequirementSet left, DestinyDefinitionsDestinyActivityLoadoutRequirementSet right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityLoadoutRequirementSet.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder
        {
            private List<DestinyDefinitionsDestinyActivityLoadoutRequirement> _Requirements;

            internal DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityLoadoutRequirementSet.Requirements property.
            /// </summary>
            /// <param name="value">The set of requirements that will be applied on the activity if this requirement set is active.</param>
            public DestinyDefinitionsDestinyActivityLoadoutRequirementSetBuilder Requirements(List<DestinyDefinitionsDestinyActivityLoadoutRequirement> value)
            {
                _Requirements = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityLoadoutRequirementSet.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityLoadoutRequirementSet</returns>
            public DestinyDefinitionsDestinyActivityLoadoutRequirementSet Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityLoadoutRequirementSet(
                    Requirements: _Requirements
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}