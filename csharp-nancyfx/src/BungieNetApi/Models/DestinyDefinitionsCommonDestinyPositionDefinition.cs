using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsCommonDestinyPositionDefinition
    /// </summary>
    public sealed class DestinyDefinitionsCommonDestinyPositionDefinition:  IEquatable<DestinyDefinitionsCommonDestinyPositionDefinition>
    { 
        /// <summary>
        /// X
        /// </summary>
        public int? X { get; private set; }

        /// <summary>
        /// Y
        /// </summary>
        public int? Y { get; private set; }

        /// <summary>
        /// Z
        /// </summary>
        public int? Z { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsCommonDestinyPositionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsCommonDestinyPositionDefinition()
        {
        }

        private DestinyDefinitionsCommonDestinyPositionDefinition(int? X, int? Y, int? Z)
        {
            
            this.X = X;
            
            this.Y = Y;
            
            this.Z = Z;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsCommonDestinyPositionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsCommonDestinyPositionDefinitionBuilder</returns>
        public static DestinyDefinitionsCommonDestinyPositionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsCommonDestinyPositionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsCommonDestinyPositionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsCommonDestinyPositionDefinitionBuilder</returns>
        public DestinyDefinitionsCommonDestinyPositionDefinitionBuilder With()
        {
            return Builder()
                .X(X)
                .Y(Y)
                .Z(Z);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsCommonDestinyPositionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsCommonDestinyPositionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCommonDestinyPositionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCommonDestinyPositionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsCommonDestinyPositionDefinition left, DestinyDefinitionsCommonDestinyPositionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsCommonDestinyPositionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCommonDestinyPositionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCommonDestinyPositionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsCommonDestinyPositionDefinition left, DestinyDefinitionsCommonDestinyPositionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsCommonDestinyPositionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsCommonDestinyPositionDefinitionBuilder
        {
            private int? _X;
            private int? _Y;
            private int? _Z;

            internal DestinyDefinitionsCommonDestinyPositionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyPositionDefinition.X property.
            /// </summary>
            /// <param name="value">X</param>
            public DestinyDefinitionsCommonDestinyPositionDefinitionBuilder X(int? value)
            {
                _X = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyPositionDefinition.Y property.
            /// </summary>
            /// <param name="value">Y</param>
            public DestinyDefinitionsCommonDestinyPositionDefinitionBuilder Y(int? value)
            {
                _Y = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyPositionDefinition.Z property.
            /// </summary>
            /// <param name="value">Z</param>
            public DestinyDefinitionsCommonDestinyPositionDefinitionBuilder Z(int? value)
            {
                _Z = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsCommonDestinyPositionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsCommonDestinyPositionDefinition</returns>
            public DestinyDefinitionsCommonDestinyPositionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsCommonDestinyPositionDefinition(
                    X: _X,
                    Y: _Y,
                    Z: _Z
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}