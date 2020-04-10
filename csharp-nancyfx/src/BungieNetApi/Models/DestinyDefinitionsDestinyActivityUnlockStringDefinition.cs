using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a status string that could be conditionally displayed about an activity. Note that externally, you can only see the strings themselves. Internally we combine this information with server state to determine which strings should be shown.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityUnlockStringDefinition:  IEquatable<DestinyDefinitionsDestinyActivityUnlockStringDefinition>
    { 
        /// <summary>
        /// The string to be displayed if the conditions are met.
        /// </summary>
        public string DisplayString { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityUnlockStringDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityUnlockStringDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityUnlockStringDefinition(string DisplayString)
        {
            
            this.DisplayString = DisplayString;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityUnlockStringDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder With()
        {
            return Builder()
                .DisplayString(DisplayString);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityUnlockStringDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityUnlockStringDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityUnlockStringDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityUnlockStringDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityUnlockStringDefinition left, DestinyDefinitionsDestinyActivityUnlockStringDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityUnlockStringDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityUnlockStringDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityUnlockStringDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityUnlockStringDefinition left, DestinyDefinitionsDestinyActivityUnlockStringDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityUnlockStringDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder
        {
            private string _DisplayString;

            internal DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityUnlockStringDefinition.DisplayString property.
            /// </summary>
            /// <param name="value">The string to be displayed if the conditions are met.</param>
            public DestinyDefinitionsDestinyActivityUnlockStringDefinitionBuilder DisplayString(string value)
            {
                _DisplayString = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityUnlockStringDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityUnlockStringDefinition</returns>
            public DestinyDefinitionsDestinyActivityUnlockStringDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityUnlockStringDefinition(
                    DisplayString: _DisplayString
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}