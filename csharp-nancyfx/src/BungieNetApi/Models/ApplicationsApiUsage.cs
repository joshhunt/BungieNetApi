using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ApplicationsApiUsage
    /// </summary>
    public sealed class ApplicationsApiUsage:  IEquatable<ApplicationsApiUsage>
    { 
        /// <summary>
        /// The date range for the data being reported.
        /// </summary>
        public DatesDateRange Range { get; private set; }

        /// <summary>
        /// Counts for on API calls made for the time range.
        /// </summary>
        public List<ApplicationsSeries> ApiCalls { get; private set; }

        /// <summary>
        /// Instances of blocked requests or requests that crossed the warn threshold during the time range.
        /// </summary>
        public List<ApplicationsSeries> ThrottledRequests { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ApplicationsApiUsage.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ApplicationsApiUsage()
        {
        }

        private ApplicationsApiUsage(DatesDateRange Range, List<ApplicationsSeries> ApiCalls, List<ApplicationsSeries> ThrottledRequests)
        {
            
            this.Range = Range;
            
            this.ApiCalls = ApiCalls;
            
            this.ThrottledRequests = ThrottledRequests;
            
        }

        /// <summary>
        /// Returns builder of ApplicationsApiUsage.
        /// </summary>
        /// <returns>ApplicationsApiUsageBuilder</returns>
        public static ApplicationsApiUsageBuilder Builder()
        {
            return new ApplicationsApiUsageBuilder();
        }

        /// <summary>
        /// Returns ApplicationsApiUsageBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ApplicationsApiUsageBuilder</returns>
        public ApplicationsApiUsageBuilder With()
        {
            return Builder()
                .Range(Range)
                .ApiCalls(ApiCalls)
                .ThrottledRequests(ThrottledRequests);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ApplicationsApiUsage other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ApplicationsApiUsage.
        /// </summary>
        /// <param name="left">Compared (ApplicationsApiUsage</param>
        /// <param name="right">Compared (ApplicationsApiUsage</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ApplicationsApiUsage left, ApplicationsApiUsage right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ApplicationsApiUsage.
        /// </summary>
        /// <param name="left">Compared (ApplicationsApiUsage</param>
        /// <param name="right">Compared (ApplicationsApiUsage</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ApplicationsApiUsage left, ApplicationsApiUsage right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ApplicationsApiUsage.
        /// </summary>
        public sealed class ApplicationsApiUsageBuilder
        {
            private DatesDateRange _Range;
            private List<ApplicationsSeries> _ApiCalls;
            private List<ApplicationsSeries> _ThrottledRequests;

            internal ApplicationsApiUsageBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ApplicationsApiUsage.Range property.
            /// </summary>
            /// <param name="value">The date range for the data being reported.</param>
            public ApplicationsApiUsageBuilder Range(DatesDateRange value)
            {
                _Range = value;
                return this;
            }

            /// <summary>
            /// Sets value for ApplicationsApiUsage.ApiCalls property.
            /// </summary>
            /// <param name="value">Counts for on API calls made for the time range.</param>
            public ApplicationsApiUsageBuilder ApiCalls(List<ApplicationsSeries> value)
            {
                _ApiCalls = value;
                return this;
            }

            /// <summary>
            /// Sets value for ApplicationsApiUsage.ThrottledRequests property.
            /// </summary>
            /// <param name="value">Instances of blocked requests or requests that crossed the warn threshold during the time range.</param>
            public ApplicationsApiUsageBuilder ThrottledRequests(List<ApplicationsSeries> value)
            {
                _ThrottledRequests = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ApplicationsApiUsage.
            /// </summary>
            /// <returns>ApplicationsApiUsage</returns>
            public ApplicationsApiUsage Build()
            {
                Validate();
                return new ApplicationsApiUsage(
                    Range: _Range,
                    ApiCalls: _ApiCalls,
                    ThrottledRequests: _ThrottledRequests
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}