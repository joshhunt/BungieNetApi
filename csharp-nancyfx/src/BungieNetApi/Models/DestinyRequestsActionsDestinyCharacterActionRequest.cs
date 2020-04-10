using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyCharacterActionRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyCharacterActionRequest:  IEquatable<DestinyRequestsActionsDestinyCharacterActionRequest>
    { 
        /// <summary>
        /// CharacterId
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// MembershipType
        /// </summary>
        public int? MembershipType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyRequestsActionsDestinyCharacterActionRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyCharacterActionRequest()
        {
        }

        private DestinyRequestsActionsDestinyCharacterActionRequest(long? CharacterId, int? MembershipType)
        {
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyCharacterActionRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyCharacterActionRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyCharacterActionRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyCharacterActionRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyCharacterActionRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyCharacterActionRequestBuilder</returns>
        public DestinyRequestsActionsDestinyCharacterActionRequestBuilder With()
        {
            return Builder()
                .CharacterId(CharacterId)
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

        public bool Equals(DestinyRequestsActionsDestinyCharacterActionRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyCharacterActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyCharacterActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyCharacterActionRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyCharacterActionRequest left, DestinyRequestsActionsDestinyCharacterActionRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyCharacterActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyCharacterActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyCharacterActionRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyCharacterActionRequest left, DestinyRequestsActionsDestinyCharacterActionRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyCharacterActionRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyCharacterActionRequestBuilder
        {
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyCharacterActionRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyCharacterActionRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsActionsDestinyCharacterActionRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyCharacterActionRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyCharacterActionRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyCharacterActionRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyCharacterActionRequest</returns>
            public DestinyRequestsActionsDestinyCharacterActionRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyCharacterActionRequest(
                    CharacterId: _CharacterId,
                    MembershipType: _MembershipType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}