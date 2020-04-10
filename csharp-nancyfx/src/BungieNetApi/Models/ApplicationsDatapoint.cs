using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ApplicationsDatapoint
    /// </summary>
    public sealed class ApplicationsDatapoint:  IEquatable<ApplicationsDatapoint>
    { 
        /// <summary>
        /// Timestamp for the related count.
        /// </summary>
        public DateTime? Time { get; private set; }

        /// <summary>
        /// Count associated with timestamp
        /// </summary>
        public double? Count { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ApplicationsDatapoint.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ApplicationsDatapoint()
        {
        }

        private ApplicationsDatapoint(DateTime? Time, double? Count)
        {
            
            this.Time = Time;
            
            this.Count = Count;
            
        }

        /// <summary>
        /// Returns builder of ApplicationsDatapoint.
        /// </summary>
        /// <returns>ApplicationsDatapointBuilder</returns>
        public static ApplicationsDatapointBuilder Builder()
        {
            return new ApplicationsDatapointBuilder();
        }

        /// <summary>
        /// Returns ApplicationsDatapointBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ApplicationsDatapointBuilder</returns>
        public ApplicationsDatapointBuilder With()
        {
            return Builder()
                .Time(Time)
                .Count(Count);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ApplicationsDatapoint other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ApplicationsDatapoint.
        /// </summary>
        /// <param name="left">Compared (ApplicationsDatapoint</param>
        /// <param name="right">Compared (ApplicationsDatapoint</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ApplicationsDatapoint left, ApplicationsDatapoint right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ApplicationsDatapoint.
        /// </summary>
        /// <param name="left">Compared (ApplicationsDatapoint</param>
        /// <param name="right">Compared (ApplicationsDatapoint</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ApplicationsDatapoint left, ApplicationsDatapoint right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ApplicationsDatapoint.
        /// </summary>
        public sealed class ApplicationsDatapointBuilder
        {
            private DateTime? _Time;
            private double? _Count;

            internal ApplicationsDatapointBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ApplicationsDatapoint.Time property.
            /// </summary>
            /// <param name="value">Timestamp for the related count.</param>
            public ApplicationsDatapointBuilder Time(DateTime? value)
            {
                _Time = value;
                return this;
            }

            /// <summary>
            /// Sets value for ApplicationsDatapoint.Count property.
            /// </summary>
            /// <param name="value">Count associated with timestamp</param>
            public ApplicationsDatapointBuilder Count(double? value)
            {
                _Count = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ApplicationsDatapoint.
            /// </summary>
            /// <returns>ApplicationsDatapoint</returns>
            public ApplicationsDatapoint Build()
            {
                Validate();
                return new ApplicationsDatapoint(
                    Time: _Time,
                    Count: _Count
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}