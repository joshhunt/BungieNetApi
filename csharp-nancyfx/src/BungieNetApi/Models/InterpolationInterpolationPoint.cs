using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// InterpolationInterpolationPoint
    /// </summary>
    public sealed class InterpolationInterpolationPoint:  IEquatable<InterpolationInterpolationPoint>
    { 
        /// <summary>
        /// Value
        /// </summary>
        public int? Value { get; private set; }

        /// <summary>
        /// Weight
        /// </summary>
        public int? Weight { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use InterpolationInterpolationPoint.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public InterpolationInterpolationPoint()
        {
        }

        private InterpolationInterpolationPoint(int? Value, int? Weight)
        {
            
            this.Value = Value;
            
            this.Weight = Weight;
            
        }

        /// <summary>
        /// Returns builder of InterpolationInterpolationPoint.
        /// </summary>
        /// <returns>InterpolationInterpolationPointBuilder</returns>
        public static InterpolationInterpolationPointBuilder Builder()
        {
            return new InterpolationInterpolationPointBuilder();
        }

        /// <summary>
        /// Returns InterpolationInterpolationPointBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>InterpolationInterpolationPointBuilder</returns>
        public InterpolationInterpolationPointBuilder With()
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

        public bool Equals(InterpolationInterpolationPoint other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (InterpolationInterpolationPoint.
        /// </summary>
        /// <param name="left">Compared (InterpolationInterpolationPoint</param>
        /// <param name="right">Compared (InterpolationInterpolationPoint</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (InterpolationInterpolationPoint left, InterpolationInterpolationPoint right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (InterpolationInterpolationPoint.
        /// </summary>
        /// <param name="left">Compared (InterpolationInterpolationPoint</param>
        /// <param name="right">Compared (InterpolationInterpolationPoint</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (InterpolationInterpolationPoint left, InterpolationInterpolationPoint right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of InterpolationInterpolationPoint.
        /// </summary>
        public sealed class InterpolationInterpolationPointBuilder
        {
            private int? _Value;
            private int? _Weight;

            internal InterpolationInterpolationPointBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for InterpolationInterpolationPoint.Value property.
            /// </summary>
            /// <param name="value">Value</param>
            public InterpolationInterpolationPointBuilder Value(int? value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for InterpolationInterpolationPoint.Weight property.
            /// </summary>
            /// <param name="value">Weight</param>
            public InterpolationInterpolationPointBuilder Weight(int? value)
            {
                _Weight = value;
                return this;
            }


            /// <summary>
            /// Builds instance of InterpolationInterpolationPoint.
            /// </summary>
            /// <returns>InterpolationInterpolationPoint</returns>
            public InterpolationInterpolationPoint Build()
            {
                Validate();
                return new InterpolationInterpolationPoint(
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