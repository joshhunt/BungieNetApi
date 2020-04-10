using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Nodes on a graph can be visually connected: this appears to be the information about which nodes to link. It appears to lack more detailed information, such as the path for that linking.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition>
    { 
        /// <summary>
        /// SourceNodeHash
        /// </summary>
        public int? SourceNodeHash { get; private set; }

        /// <summary>
        /// DestNodeHash
        /// </summary>
        public int? DestNodeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition(int? SourceNodeHash, int? DestNodeHash)
        {
            
            this.SourceNodeHash = SourceNodeHash;
            
            this.DestNodeHash = DestNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder With()
        {
            return Builder()
                .SourceNodeHash(SourceNodeHash)
                .DestNodeHash(DestNodeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder
        {
            private int? _SourceNodeHash;
            private int? _DestNodeHash;

            internal DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.SourceNodeHash property.
            /// </summary>
            /// <param name="value">SourceNodeHash</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder SourceNodeHash(int? value)
            {
                _SourceNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.DestNodeHash property.
            /// </summary>
            /// <param name="value">DestNodeHash</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinitionBuilder DestNodeHash(int? value)
            {
                _DestNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition(
                    SourceNodeHash: _SourceNodeHash,
                    DestNodeHash: _DestNodeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}