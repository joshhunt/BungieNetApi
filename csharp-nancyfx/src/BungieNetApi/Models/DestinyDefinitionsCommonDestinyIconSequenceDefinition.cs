using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsCommonDestinyIconSequenceDefinition
    /// </summary>
    public sealed class DestinyDefinitionsCommonDestinyIconSequenceDefinition:  IEquatable<DestinyDefinitionsCommonDestinyIconSequenceDefinition>
    { 
        /// <summary>
        /// Frames
        /// </summary>
        public List<string> Frames { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsCommonDestinyIconSequenceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsCommonDestinyIconSequenceDefinition()
        {
        }

        private DestinyDefinitionsCommonDestinyIconSequenceDefinition(List<string> Frames)
        {
            
            this.Frames = Frames;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsCommonDestinyIconSequenceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder</returns>
        public static DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder</returns>
        public DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder With()
        {
            return Builder()
                .Frames(Frames);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsCommonDestinyIconSequenceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsCommonDestinyIconSequenceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCommonDestinyIconSequenceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCommonDestinyIconSequenceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsCommonDestinyIconSequenceDefinition left, DestinyDefinitionsCommonDestinyIconSequenceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsCommonDestinyIconSequenceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCommonDestinyIconSequenceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCommonDestinyIconSequenceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsCommonDestinyIconSequenceDefinition left, DestinyDefinitionsCommonDestinyIconSequenceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsCommonDestinyIconSequenceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder
        {
            private List<string> _Frames;

            internal DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyIconSequenceDefinition.Frames property.
            /// </summary>
            /// <param name="value">Frames</param>
            public DestinyDefinitionsCommonDestinyIconSequenceDefinitionBuilder Frames(List<string> value)
            {
                _Frames = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsCommonDestinyIconSequenceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsCommonDestinyIconSequenceDefinition</returns>
            public DestinyDefinitionsCommonDestinyIconSequenceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsCommonDestinyIconSequenceDefinition(
                    Frames: _Frames
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}