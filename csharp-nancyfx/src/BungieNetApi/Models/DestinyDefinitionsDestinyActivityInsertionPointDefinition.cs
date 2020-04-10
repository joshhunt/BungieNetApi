using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A point of entry into an activity, gated by an unlock flag and with some more-or-less useless (for our purposes) phase information. I&#39;m including it in case we end up being able to bolt more useful information onto it in the future.  UPDATE: Turns out this information isn&#39;t actually useless, and is in fact actually useful for people. Who would have thought? We still don&#39;t have localized info for it, but at least this will help people when they&#39;re looking at phase indexes in stats data, or when they want to know what phases have been completed on a weekly achievement.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityInsertionPointDefinition:  IEquatable<DestinyDefinitionsDestinyActivityInsertionPointDefinition>
    { 
        /// <summary>
        /// A unique hash value representing the phase. This can be useful for, for example, comparing how different instances of Raids have phases in different orders!
        /// </summary>
        public int? PhaseHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityInsertionPointDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityInsertionPointDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityInsertionPointDefinition(int? PhaseHash)
        {
            
            this.PhaseHash = PhaseHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityInsertionPointDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder With()
        {
            return Builder()
                .PhaseHash(PhaseHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityInsertionPointDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityInsertionPointDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityInsertionPointDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityInsertionPointDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityInsertionPointDefinition left, DestinyDefinitionsDestinyActivityInsertionPointDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityInsertionPointDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityInsertionPointDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityInsertionPointDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityInsertionPointDefinition left, DestinyDefinitionsDestinyActivityInsertionPointDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityInsertionPointDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder
        {
            private int? _PhaseHash;

            internal DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityInsertionPointDefinition.PhaseHash property.
            /// </summary>
            /// <param name="value">A unique hash value representing the phase. This can be useful for, for example, comparing how different instances of Raids have phases in different orders!</param>
            public DestinyDefinitionsDestinyActivityInsertionPointDefinitionBuilder PhaseHash(int? value)
            {
                _PhaseHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityInsertionPointDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityInsertionPointDefinition</returns>
            public DestinyDefinitionsDestinyActivityInsertionPointDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityInsertionPointDefinition(
                    PhaseHash: _PhaseHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}