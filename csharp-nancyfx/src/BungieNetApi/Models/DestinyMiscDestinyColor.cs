using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a color whose RGBA values are all represented as values between 0 and 255.
    /// </summary>
    public sealed class DestinyMiscDestinyColor:  IEquatable<DestinyMiscDestinyColor>
    { 
        /// <summary>
        /// Red
        /// </summary>
        public byte[] Red { get; private set; }

        /// <summary>
        /// Green
        /// </summary>
        public byte[] Green { get; private set; }

        /// <summary>
        /// Blue
        /// </summary>
        public byte[] Blue { get; private set; }

        /// <summary>
        /// Alpha
        /// </summary>
        public byte[] Alpha { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMiscDestinyColor.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMiscDestinyColor()
        {
        }

        private DestinyMiscDestinyColor(byte[] Red, byte[] Green, byte[] Blue, byte[] Alpha)
        {
            
            this.Red = Red;
            
            this.Green = Green;
            
            this.Blue = Blue;
            
            this.Alpha = Alpha;
            
        }

        /// <summary>
        /// Returns builder of DestinyMiscDestinyColor.
        /// </summary>
        /// <returns>DestinyMiscDestinyColorBuilder</returns>
        public static DestinyMiscDestinyColorBuilder Builder()
        {
            return new DestinyMiscDestinyColorBuilder();
        }

        /// <summary>
        /// Returns DestinyMiscDestinyColorBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMiscDestinyColorBuilder</returns>
        public DestinyMiscDestinyColorBuilder With()
        {
            return Builder()
                .Red(Red)
                .Green(Green)
                .Blue(Blue)
                .Alpha(Alpha);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMiscDestinyColor other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMiscDestinyColor.
        /// </summary>
        /// <param name="left">Compared (DestinyMiscDestinyColor</param>
        /// <param name="right">Compared (DestinyMiscDestinyColor</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMiscDestinyColor left, DestinyMiscDestinyColor right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMiscDestinyColor.
        /// </summary>
        /// <param name="left">Compared (DestinyMiscDestinyColor</param>
        /// <param name="right">Compared (DestinyMiscDestinyColor</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMiscDestinyColor left, DestinyMiscDestinyColor right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMiscDestinyColor.
        /// </summary>
        public sealed class DestinyMiscDestinyColorBuilder
        {
            private byte[] _Red;
            private byte[] _Green;
            private byte[] _Blue;
            private byte[] _Alpha;

            internal DestinyMiscDestinyColorBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMiscDestinyColor.Red property.
            /// </summary>
            /// <param name="value">Red</param>
            public DestinyMiscDestinyColorBuilder Red(byte[] value)
            {
                _Red = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMiscDestinyColor.Green property.
            /// </summary>
            /// <param name="value">Green</param>
            public DestinyMiscDestinyColorBuilder Green(byte[] value)
            {
                _Green = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMiscDestinyColor.Blue property.
            /// </summary>
            /// <param name="value">Blue</param>
            public DestinyMiscDestinyColorBuilder Blue(byte[] value)
            {
                _Blue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMiscDestinyColor.Alpha property.
            /// </summary>
            /// <param name="value">Alpha</param>
            public DestinyMiscDestinyColorBuilder Alpha(byte[] value)
            {
                _Alpha = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMiscDestinyColor.
            /// </summary>
            /// <returns>DestinyMiscDestinyColor</returns>
            public DestinyMiscDestinyColor Build()
            {
                Validate();
                return new DestinyMiscDestinyColor(
                    Red: _Red,
                    Green: _Green,
                    Blue: _Blue,
                    Alpha: _Alpha
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}