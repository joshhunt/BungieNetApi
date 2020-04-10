using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// When a Graph needs to show active Objectives, this defines those objectives as well as an identifier.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition>
    { 
        /// <summary>
        /// $NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.
        /// </summary>
        public int? Id { get; private set; }

        /// <summary>
        /// The objective being shown on the map.
        /// </summary>
        public int? ObjectiveHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition(int? Id, int? ObjectiveHash)
        {
            
            this.Id = Id;
            
            this.ObjectiveHash = ObjectiveHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder With()
        {
            return Builder()
                .Id(Id)
                .ObjectiveHash(ObjectiveHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder
        {
            private int? _Id;
            private int? _ObjectiveHash;

            internal DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.Id property.
            /// </summary>
            /// <param name="value">$NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder Id(int? value)
            {
                _Id = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.ObjectiveHash property.
            /// </summary>
            /// <param name="value">The objective being shown on the map.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinitionBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition(
                    Id: _Id,
                    ObjectiveHash: _ObjectiveHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}