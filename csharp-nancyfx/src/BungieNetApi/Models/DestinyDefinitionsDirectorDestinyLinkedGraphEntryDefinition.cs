using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition>
    { 
        /// <summary>
        /// ActivityGraphHash
        /// </summary>
        public int? ActivityGraphHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition(int? ActivityGraphHash)
        {
            
            this.ActivityGraphHash = ActivityGraphHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder With()
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

        public bool Equals(DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition left, DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition left, DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder
        {
            private int? _ActivityGraphHash;

            internal DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.ActivityGraphHash property.
            /// </summary>
            /// <param name="value">ActivityGraphHash</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinitionBuilder ActivityGraphHash(int? value)
            {
                _ActivityGraphHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition</returns>
            public DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition(
                    ActivityGraphHash: _ActivityGraphHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}