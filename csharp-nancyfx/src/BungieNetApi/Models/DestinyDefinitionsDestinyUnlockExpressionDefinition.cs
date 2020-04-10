using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Where the sausage gets made. Unlock Expressions are the foundation of the game&#39;s gating mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values for certain states, using a sufficient amount of logical operators such that unlock expressions are effectively Turing complete.  Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from Babel.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyUnlockExpressionDefinition:  IEquatable<DestinyDefinitionsDestinyUnlockExpressionDefinition>
    { 
        /// <summary>
        /// A shortcut for determining the most restrictive gating that this expression performs. See the DestinyGatingScope enum&#39;s documentation for more details.
        /// </summary>
        public int? Scope { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyUnlockExpressionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyUnlockExpressionDefinition()
        {
        }

        private DestinyDefinitionsDestinyUnlockExpressionDefinition(int? Scope)
        {
            
            this.Scope = Scope;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyUnlockExpressionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder With()
        {
            return Builder()
                .Scope(Scope);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyUnlockExpressionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyUnlockExpressionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyUnlockExpressionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyUnlockExpressionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyUnlockExpressionDefinition left, DestinyDefinitionsDestinyUnlockExpressionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyUnlockExpressionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyUnlockExpressionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyUnlockExpressionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyUnlockExpressionDefinition left, DestinyDefinitionsDestinyUnlockExpressionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyUnlockExpressionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder
        {
            private int? _Scope;

            internal DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyUnlockExpressionDefinition.Scope property.
            /// </summary>
            /// <param name="value">A shortcut for determining the most restrictive gating that this expression performs. See the DestinyGatingScope enum&#39;s documentation for more details.</param>
            public DestinyDefinitionsDestinyUnlockExpressionDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyUnlockExpressionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyUnlockExpressionDefinition</returns>
            public DestinyDefinitionsDestinyUnlockExpressionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyUnlockExpressionDefinition(
                    Scope: _Scope
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}