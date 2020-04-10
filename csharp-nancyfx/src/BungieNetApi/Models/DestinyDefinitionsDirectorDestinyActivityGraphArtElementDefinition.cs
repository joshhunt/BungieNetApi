using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These Art Elements are meant to represent one-off visual effects overlaid on the map. Currently, we do not have a pipeline to import the assets for these overlays, so this info exists as a placeholder for when such a pipeline exists (if it ever will)
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition>
    { 
        /// <summary>
        /// The position on the map of the art element.
        /// </summary>
        public DestinyDefinitionsCommonDestinyPositionDefinition Position { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition(DestinyDefinitionsCommonDestinyPositionDefinition Position)
        {
            
            this.Position = Position;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder With()
        {
            return Builder()
                .Position(Position);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyPositionDefinition _Position;

            internal DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.Position property.
            /// </summary>
            /// <param name="value">The position on the map of the art element.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinitionBuilder Position(DestinyDefinitionsCommonDestinyPositionDefinition value)
            {
                _Position = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition(
                    Position: _Position
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}