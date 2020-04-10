using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DatesDateRange
    /// </summary>
    public sealed class DatesDateRange:  IEquatable<DatesDateRange>
    { 
        /// <summary>
        /// Start
        /// </summary>
        public DateTime? Start { get; private set; }

        /// <summary>
        /// End
        /// </summary>
        public DateTime? End { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DatesDateRange.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DatesDateRange()
        {
        }

        private DatesDateRange(DateTime? Start, DateTime? End)
        {
            
            this.Start = Start;
            
            this.End = End;
            
        }

        /// <summary>
        /// Returns builder of DatesDateRange.
        /// </summary>
        /// <returns>DatesDateRangeBuilder</returns>
        public static DatesDateRangeBuilder Builder()
        {
            return new DatesDateRangeBuilder();
        }

        /// <summary>
        /// Returns DatesDateRangeBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DatesDateRangeBuilder</returns>
        public DatesDateRangeBuilder With()
        {
            return Builder()
                .Start(Start)
                .End(End);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DatesDateRange other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DatesDateRange.
        /// </summary>
        /// <param name="left">Compared (DatesDateRange</param>
        /// <param name="right">Compared (DatesDateRange</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DatesDateRange left, DatesDateRange right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DatesDateRange.
        /// </summary>
        /// <param name="left">Compared (DatesDateRange</param>
        /// <param name="right">Compared (DatesDateRange</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DatesDateRange left, DatesDateRange right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DatesDateRange.
        /// </summary>
        public sealed class DatesDateRangeBuilder
        {
            private DateTime? _Start;
            private DateTime? _End;

            internal DatesDateRangeBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DatesDateRange.Start property.
            /// </summary>
            /// <param name="value">Start</param>
            public DatesDateRangeBuilder Start(DateTime? value)
            {
                _Start = value;
                return this;
            }

            /// <summary>
            /// Sets value for DatesDateRange.End property.
            /// </summary>
            /// <param name="value">End</param>
            public DatesDateRangeBuilder End(DateTime? value)
            {
                _End = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DatesDateRange.
            /// </summary>
            /// <returns>DatesDateRange</returns>
            public DatesDateRange Build()
            {
                Validate();
                return new DatesDateRange(
                    Start: _Start,
                    End: _End
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}