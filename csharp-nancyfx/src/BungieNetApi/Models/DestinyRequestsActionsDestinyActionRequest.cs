using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyActionRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyActionRequest:  IEquatable<DestinyRequestsActionsDestinyActionRequest>
    { 
        /// <summary>
        /// MembershipType
        /// </summary>
        public int? MembershipType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyRequestsActionsDestinyActionRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyActionRequest()
        {
        }

        private DestinyRequestsActionsDestinyActionRequest(int? MembershipType)
        {
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyActionRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyActionRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyActionRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyActionRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyActionRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyActionRequestBuilder</returns>
        public DestinyRequestsActionsDestinyActionRequestBuilder With()
        {
            return Builder()
                .MembershipType(MembershipType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyRequestsActionsDestinyActionRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyActionRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyActionRequest left, DestinyRequestsActionsDestinyActionRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyActionRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyActionRequest left, DestinyRequestsActionsDestinyActionRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyActionRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyActionRequestBuilder
        {
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyActionRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyActionRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyActionRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyActionRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyActionRequest</returns>
            public DestinyRequestsActionsDestinyActionRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyActionRequest(
                    MembershipType: _MembershipType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}