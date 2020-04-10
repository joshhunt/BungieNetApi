using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ApplicationsSeries
    /// </summary>
    public sealed class ApplicationsSeries:  IEquatable<ApplicationsSeries>
    { 
        /// <summary>
        /// Collection of samples with time and value.
        /// </summary>
        public List<ApplicationsDatapoint> Datapoints { get; private set; }

        /// <summary>
        /// Target to which to datapoints apply.
        /// </summary>
        public string Target { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ApplicationsSeries.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ApplicationsSeries()
        {
        }

        private ApplicationsSeries(List<ApplicationsDatapoint> Datapoints, string Target)
        {
            
            this.Datapoints = Datapoints;
            
            this.Target = Target;
            
        }

        /// <summary>
        /// Returns builder of ApplicationsSeries.
        /// </summary>
        /// <returns>ApplicationsSeriesBuilder</returns>
        public static ApplicationsSeriesBuilder Builder()
        {
            return new ApplicationsSeriesBuilder();
        }

        /// <summary>
        /// Returns ApplicationsSeriesBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ApplicationsSeriesBuilder</returns>
        public ApplicationsSeriesBuilder With()
        {
            return Builder()
                .Datapoints(Datapoints)
                .Target(Target);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ApplicationsSeries other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ApplicationsSeries.
        /// </summary>
        /// <param name="left">Compared (ApplicationsSeries</param>
        /// <param name="right">Compared (ApplicationsSeries</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ApplicationsSeries left, ApplicationsSeries right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ApplicationsSeries.
        /// </summary>
        /// <param name="left">Compared (ApplicationsSeries</param>
        /// <param name="right">Compared (ApplicationsSeries</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ApplicationsSeries left, ApplicationsSeries right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ApplicationsSeries.
        /// </summary>
        public sealed class ApplicationsSeriesBuilder
        {
            private List<ApplicationsDatapoint> _Datapoints;
            private string _Target;

            internal ApplicationsSeriesBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ApplicationsSeries.Datapoints property.
            /// </summary>
            /// <param name="value">Collection of samples with time and value.</param>
            public ApplicationsSeriesBuilder Datapoints(List<ApplicationsDatapoint> value)
            {
                _Datapoints = value;
                return this;
            }

            /// <summary>
            /// Sets value for ApplicationsSeries.Target property.
            /// </summary>
            /// <param name="value">Target to which to datapoints apply.</param>
            public ApplicationsSeriesBuilder Target(string value)
            {
                _Target = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ApplicationsSeries.
            /// </summary>
            /// <returns>ApplicationsSeries</returns>
            public ApplicationsSeries Build()
            {
                Validate();
                return new ApplicationsSeries(
                    Datapoints: _Datapoints,
                    Target: _Target
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}