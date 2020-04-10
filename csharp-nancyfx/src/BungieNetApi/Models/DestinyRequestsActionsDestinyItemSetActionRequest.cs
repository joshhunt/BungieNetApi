using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyItemSetActionRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyItemSetActionRequest:  IEquatable<DestinyRequestsActionsDestinyItemSetActionRequest>
    { 
        /// <summary>
        /// ItemIds
        /// </summary>
        public List<long?> ItemIds { get; private set; }

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
        /// Use DestinyRequestsActionsDestinyItemSetActionRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyItemSetActionRequest()
        {
        }

        private DestinyRequestsActionsDestinyItemSetActionRequest(List<long?> ItemIds, long? CharacterId, int? MembershipType)
        {
            
            this.ItemIds = ItemIds;
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyItemSetActionRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyItemSetActionRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyItemSetActionRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyItemSetActionRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyItemSetActionRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyItemSetActionRequestBuilder</returns>
        public DestinyRequestsActionsDestinyItemSetActionRequestBuilder With()
        {
            return Builder()
                .ItemIds(ItemIds)
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

        public bool Equals(DestinyRequestsActionsDestinyItemSetActionRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyItemSetActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyItemSetActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyItemSetActionRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyItemSetActionRequest left, DestinyRequestsActionsDestinyItemSetActionRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyItemSetActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyItemSetActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyItemSetActionRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyItemSetActionRequest left, DestinyRequestsActionsDestinyItemSetActionRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyItemSetActionRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyItemSetActionRequestBuilder
        {
            private List<long?> _ItemIds;
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyItemSetActionRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemSetActionRequest.ItemIds property.
            /// </summary>
            /// <param name="value">ItemIds</param>
            public DestinyRequestsActionsDestinyItemSetActionRequestBuilder ItemIds(List<long?> value)
            {
                _ItemIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemSetActionRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsActionsDestinyItemSetActionRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyItemSetActionRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyItemSetActionRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyItemSetActionRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyItemSetActionRequest</returns>
            public DestinyRequestsActionsDestinyItemSetActionRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyItemSetActionRequest(
                    ItemIds: _ItemIds,
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