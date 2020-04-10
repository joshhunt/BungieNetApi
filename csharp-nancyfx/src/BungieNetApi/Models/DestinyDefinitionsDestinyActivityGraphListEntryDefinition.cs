using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Destinations and Activities may have default Activity Graphs that should be shown when you bring up the Director and are playing in either.  This contract defines the graph referred to and the gating for when it is relevant.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityGraphListEntryDefinition:  IEquatable<DestinyDefinitionsDestinyActivityGraphListEntryDefinition>
    { 
        /// <summary>
        /// The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening the director.
        /// </summary>
        public int? ActivityGraphHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityGraphListEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityGraphListEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityGraphListEntryDefinition(int? ActivityGraphHash)
        {
            
            this.ActivityGraphHash = ActivityGraphHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityGraphListEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder With()
        {
            return Builder()
                .ActivityGraphHash(ActivityGraphHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityGraphListEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityGraphListEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityGraphListEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityGraphListEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityGraphListEntryDefinition left, DestinyDefinitionsDestinyActivityGraphListEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityGraphListEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityGraphListEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityGraphListEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityGraphListEntryDefinition left, DestinyDefinitionsDestinyActivityGraphListEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityGraphListEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder
        {
            private int? _ActivityGraphHash;

            internal DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityGraphListEntryDefinition.ActivityGraphHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening the director.</param>
            public DestinyDefinitionsDestinyActivityGraphListEntryDefinitionBuilder ActivityGraphHash(int? value)
            {
                _ActivityGraphHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityGraphListEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityGraphListEntryDefinition</returns>
            public DestinyDefinitionsDestinyActivityGraphListEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityGraphListEntryDefinition(
                    ActivityGraphHash: _ActivityGraphHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}