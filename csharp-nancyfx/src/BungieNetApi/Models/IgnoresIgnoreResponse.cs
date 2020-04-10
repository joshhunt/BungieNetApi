using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// IgnoresIgnoreResponse
    /// </summary>
    public sealed class IgnoresIgnoreResponse:  IEquatable<IgnoresIgnoreResponse>
    { 
        /// <summary>
        /// IsIgnored
        /// </summary>
        public bool? IsIgnored { get; private set; }

        /// <summary>
        /// IgnoreFlags
        /// </summary>
        public int? IgnoreFlags { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use IgnoresIgnoreResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public IgnoresIgnoreResponse()
        {
        }

        private IgnoresIgnoreResponse(bool? IsIgnored, int? IgnoreFlags)
        {
            
            this.IsIgnored = IsIgnored;
            
            this.IgnoreFlags = IgnoreFlags;
            
        }

        /// <summary>
        /// Returns builder of IgnoresIgnoreResponse.
        /// </summary>
        /// <returns>IgnoresIgnoreResponseBuilder</returns>
        public static IgnoresIgnoreResponseBuilder Builder()
        {
            return new IgnoresIgnoreResponseBuilder();
        }

        /// <summary>
        /// Returns IgnoresIgnoreResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>IgnoresIgnoreResponseBuilder</returns>
        public IgnoresIgnoreResponseBuilder With()
        {
            return Builder()
                .IsIgnored(IsIgnored)
                .IgnoreFlags(IgnoreFlags);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(IgnoresIgnoreResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (IgnoresIgnoreResponse.
        /// </summary>
        /// <param name="left">Compared (IgnoresIgnoreResponse</param>
        /// <param name="right">Compared (IgnoresIgnoreResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (IgnoresIgnoreResponse left, IgnoresIgnoreResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (IgnoresIgnoreResponse.
        /// </summary>
        /// <param name="left">Compared (IgnoresIgnoreResponse</param>
        /// <param name="right">Compared (IgnoresIgnoreResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (IgnoresIgnoreResponse left, IgnoresIgnoreResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of IgnoresIgnoreResponse.
        /// </summary>
        public sealed class IgnoresIgnoreResponseBuilder
        {
            private bool? _IsIgnored;
            private int? _IgnoreFlags;

            internal IgnoresIgnoreResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for IgnoresIgnoreResponse.IsIgnored property.
            /// </summary>
            /// <param name="value">IsIgnored</param>
            public IgnoresIgnoreResponseBuilder IsIgnored(bool? value)
            {
                _IsIgnored = value;
                return this;
            }

            /// <summary>
            /// Sets value for IgnoresIgnoreResponse.IgnoreFlags property.
            /// </summary>
            /// <param name="value">IgnoreFlags</param>
            public IgnoresIgnoreResponseBuilder IgnoreFlags(int? value)
            {
                _IgnoreFlags = value;
                return this;
            }


            /// <summary>
            /// Builds instance of IgnoresIgnoreResponse.
            /// </summary>
            /// <returns>IgnoresIgnoreResponse</returns>
            public IgnoresIgnoreResponse Build()
            {
                Validate();
                return new IgnoresIgnoreResponse(
                    IsIgnored: _IsIgnored,
                    IgnoreFlags: _IgnoreFlags
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}