using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyItemStateRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyItemStateRequest:  IEquatable<DestinyRequestsActionsDestinyItemStateRequest>
    { 
        /// <summary>
        /// State
        /// </summary>
        public bool? State { get; private set; }

        /// <summary>
        /// ItemId
        /// </summary>
        public long? ItemId { get; private set; }

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
        /// Use DestinyRequestsActionsDestinyItemStateRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyItemStateRequest()
        {
        }

        private DestinyRequestsActionsDestinyItemStateRequest(bool? State, long? ItemId, long? CharacterId, int? MembershipType)
        {
            
            this.State = State;
            
            this.ItemId = ItemId;
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyItemStateRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyItemStateRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyItemStateRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyItemStateRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyItemStateRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyItemStateRequestBuilder</returns>
        public DestinyRequestsActionsDestinyItemStateRequestBuilder With()
        {
            return Builder()
                .State(State)
                .ItemId(ItemId)
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

        public bool Equals(DestinyRequestsActionsDestinyItemStateRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyItemStateRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyItemStateRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyItemStateRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyItemStateRequest left, DestinyRequestsActionsDestinyItemStateRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyItemStateRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyItemStateRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyItemStateRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyItemStateRequest left, DestinyRequestsActionsDestinyItemStateRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyItemStateRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyItemStateRequestBuilder
        {
            private bool? _State;
            private long? _ItemId;
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyItemStateRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemStateRequest.State property.
            /// </summary>
            /// <param name="value">State</param>
            public DestinyRequestsActionsDestinyItemStateRequestBuilder State(bool? value)
            {
                _State = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemStateRequest.ItemId property.
            /// </summary>
            /// <param name="value">ItemId</param>
            public DestinyRequestsActionsDestinyItemStateRequestBuilder ItemId(long? value)
            {
                _ItemId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemStateRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsActionsDestinyItemStateRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemStateRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyItemStateRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyItemStateRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyItemStateRequest</returns>
            public DestinyRequestsActionsDestinyItemStateRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyItemStateRequest(
                    State: _State,
                    ItemId: _ItemId,
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