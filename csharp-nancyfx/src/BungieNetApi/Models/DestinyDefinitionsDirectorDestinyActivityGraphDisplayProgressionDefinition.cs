using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// When a Graph needs to show active Progressions, this defines those objectives as well as an identifier.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition>
    { 
        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; private set; }

        /// <summary>
        /// ProgressionHash
        /// </summary>
        public int? ProgressionHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition(int? Id, int? ProgressionHash)
        {
            
            this.Id = Id;
            
            this.ProgressionHash = ProgressionHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder With()
        {
            return Builder()
                .Id(Id)
                .ProgressionHash(ProgressionHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder
        {
            private int? _Id;
            private int? _ProgressionHash;

            internal DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.Id property.
            /// </summary>
            /// <param name="value">Id</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder Id(int? value)
            {
                _Id = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.ProgressionHash property.
            /// </summary>
            /// <param name="value">ProgressionHash</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinitionBuilder ProgressionHash(int? value)
            {
                _ProgressionHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition(
                    Id: _Id,
                    ProgressionHash: _ProgressionHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}