using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyConfigImagePyramidEntry
    /// </summary>
    public sealed class DestinyConfigImagePyramidEntry:  IEquatable<DestinyConfigImagePyramidEntry>
    { 
        /// <summary>
        /// The name of the subfolder where these images are located.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The factor by which the original image size has been reduced.
        /// </summary>
        public float? Factor { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyConfigImagePyramidEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyConfigImagePyramidEntry()
        {
        }

        private DestinyConfigImagePyramidEntry(string Name, float? Factor)
        {
            
            this.Name = Name;
            
            this.Factor = Factor;
            
        }

        /// <summary>
        /// Returns builder of DestinyConfigImagePyramidEntry.
        /// </summary>
        /// <returns>DestinyConfigImagePyramidEntryBuilder</returns>
        public static DestinyConfigImagePyramidEntryBuilder Builder()
        {
            return new DestinyConfigImagePyramidEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyConfigImagePyramidEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyConfigImagePyramidEntryBuilder</returns>
        public DestinyConfigImagePyramidEntryBuilder With()
        {
            return Builder()
                .Name(Name)
                .Factor(Factor);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyConfigImagePyramidEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyConfigImagePyramidEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyConfigImagePyramidEntry</param>
        /// <param name="right">Compared (DestinyConfigImagePyramidEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyConfigImagePyramidEntry left, DestinyConfigImagePyramidEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyConfigImagePyramidEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyConfigImagePyramidEntry</param>
        /// <param name="right">Compared (DestinyConfigImagePyramidEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyConfigImagePyramidEntry left, DestinyConfigImagePyramidEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyConfigImagePyramidEntry.
        /// </summary>
        public sealed class DestinyConfigImagePyramidEntryBuilder
        {
            private string _Name;
            private float? _Factor;

            internal DestinyConfigImagePyramidEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyConfigImagePyramidEntry.Name property.
            /// </summary>
            /// <param name="value">The name of the subfolder where these images are located.</param>
            public DestinyConfigImagePyramidEntryBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigImagePyramidEntry.Factor property.
            /// </summary>
            /// <param name="value">The factor by which the original image size has been reduced.</param>
            public DestinyConfigImagePyramidEntryBuilder Factor(float? value)
            {
                _Factor = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyConfigImagePyramidEntry.
            /// </summary>
            /// <returns>DestinyConfigImagePyramidEntry</returns>
            public DestinyConfigImagePyramidEntry Build()
            {
                Validate();
                return new DestinyConfigImagePyramidEntry(
                    Name: _Name,
                    Factor: _Factor
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}