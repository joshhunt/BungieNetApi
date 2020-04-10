using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// InterpolationInterpolationPointFloat
    /// </summary>
    public sealed class InterpolationInterpolationPointFloat:  IEquatable<InterpolationInterpolationPointFloat>
    { 
        /// <summary>
        /// Value
        /// </summary>
        public float? Value { get; private set; }

        /// <summary>
        /// Weight
        /// </summary>
        public float? Weight { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use InterpolationInterpolationPointFloat.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public InterpolationInterpolationPointFloat()
        {
        }

        private InterpolationInterpolationPointFloat(float? Value, float? Weight)
        {
            
            this.Value = Value;
            
            this.Weight = Weight;
            
        }

        /// <summary>
        /// Returns builder of InterpolationInterpolationPointFloat.
        /// </summary>
        /// <returns>InterpolationInterpolationPointFloatBuilder</returns>
        public static InterpolationInterpolationPointFloatBuilder Builder()
        {
            return new InterpolationInterpolationPointFloatBuilder();
        }

        /// <summary>
        /// Returns InterpolationInterpolationPointFloatBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>InterpolationInterpolationPointFloatBuilder</returns>
        public InterpolationInterpolationPointFloatBuilder With()
        {
            return Builder()
                .Value(Value)
                .Weight(Weight);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(InterpolationInterpolationPointFloat other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (InterpolationInterpolationPointFloat.
        /// </summary>
        /// <param name="left">Compared (InterpolationInterpolationPointFloat</param>
        /// <param name="right">Compared (InterpolationInterpolationPointFloat</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (InterpolationInterpolationPointFloat left, InterpolationInterpolationPointFloat right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (InterpolationInterpolationPointFloat.
        /// </summary>
        /// <param name="left">Compared (InterpolationInterpolationPointFloat</param>
        /// <param name="right">Compared (InterpolationInterpolationPointFloat</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (InterpolationInterpolationPointFloat left, InterpolationInterpolationPointFloat right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of InterpolationInterpolationPointFloat.
        /// </summary>
        public sealed class InterpolationInterpolationPointFloatBuilder
        {
            private float? _Value;
            private float? _Weight;

            internal InterpolationInterpolationPointFloatBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for InterpolationInterpolationPointFloat.Value property.
            /// </summary>
            /// <param name="value">Value</param>
            public InterpolationInterpolationPointFloatBuilder Value(float? value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for InterpolationInterpolationPointFloat.Weight property.
            /// </summary>
            /// <param name="value">Weight</param>
            public InterpolationInterpolationPointFloatBuilder Weight(float? value)
            {
                _Weight = value;
                return this;
            }


            /// <summary>
            /// Builds instance of InterpolationInterpolationPointFloat.
            /// </summary>
            /// <returns>InterpolationInterpolationPointFloat</returns>
            public InterpolationInterpolationPointFloat Build()
            {
                Validate();
                return new InterpolationInterpolationPointFloat(
                    Value: _Value,
                    Weight: _Weight
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}