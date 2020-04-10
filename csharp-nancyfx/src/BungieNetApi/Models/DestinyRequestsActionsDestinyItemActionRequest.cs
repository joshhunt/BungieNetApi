using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyItemActionRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyItemActionRequest:  IEquatable<DestinyRequestsActionsDestinyItemActionRequest>
    { 
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
        /// Use DestinyRequestsActionsDestinyItemActionRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyItemActionRequest()
        {
        }

        private DestinyRequestsActionsDestinyItemActionRequest(long? ItemId, long? CharacterId, int? MembershipType)
        {
            
            this.ItemId = ItemId;
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyItemActionRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyItemActionRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyItemActionRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyItemActionRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyItemActionRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyItemActionRequestBuilder</returns>
        public DestinyRequestsActionsDestinyItemActionRequestBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyRequestsActionsDestinyItemActionRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyItemActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyItemActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyItemActionRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyItemActionRequest left, DestinyRequestsActionsDestinyItemActionRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyItemActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyItemActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyItemActionRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyItemActionRequest left, DestinyRequestsActionsDestinyItemActionRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyItemActionRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyItemActionRequestBuilder
        {
            private long? _ItemId;
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyItemActionRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemActionRequest.ItemId property.
            /// </summary>
            /// <param name="value">ItemId</param>
            public DestinyRequestsActionsDestinyItemActionRequestBuilder ItemId(long? value)
            {
                _ItemId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemActionRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsActionsDestinyItemActionRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemActionRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyItemActionRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyItemActionRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyItemActionRequest</returns>
            public DestinyRequestsActionsDestinyItemActionRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyItemActionRequest(
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