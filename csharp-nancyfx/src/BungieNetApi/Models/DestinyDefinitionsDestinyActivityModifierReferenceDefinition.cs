using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A reference to an Activity Modifier from another entity, such as an Activity (for now, just Activities).  This defines some
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityModifierReferenceDefinition:  IEquatable<DestinyDefinitionsDestinyActivityModifierReferenceDefinition>
    { 
        /// <summary>
        /// The hash identifier for the DestinyActivityModifierDefinition referenced by this activity.
        /// </summary>
        public int? ActivityModifierHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityModifierReferenceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityModifierReferenceDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityModifierReferenceDefinition(int? ActivityModifierHash)
        {
            
            this.ActivityModifierHash = ActivityModifierHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityModifierReferenceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder With()
        {
            return Builder()
                .ActivityModifierHash(ActivityModifierHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityModifierReferenceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityModifierReferenceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityModifierReferenceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityModifierReferenceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityModifierReferenceDefinition left, DestinyDefinitionsDestinyActivityModifierReferenceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityModifierReferenceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityModifierReferenceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityModifierReferenceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityModifierReferenceDefinition left, DestinyDefinitionsDestinyActivityModifierReferenceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityModifierReferenceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder
        {
            private int? _ActivityModifierHash;

            internal DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModifierReferenceDefinition.ActivityModifierHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the DestinyActivityModifierDefinition referenced by this activity.</param>
            public DestinyDefinitionsDestinyActivityModifierReferenceDefinitionBuilder ActivityModifierHash(int? value)
            {
                _ActivityModifierHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityModifierReferenceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityModifierReferenceDefinition</returns>
            public DestinyDefinitionsDestinyActivityModifierReferenceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityModifierReferenceDefinition(
                    ActivityModifierHash: _ActivityModifierHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}