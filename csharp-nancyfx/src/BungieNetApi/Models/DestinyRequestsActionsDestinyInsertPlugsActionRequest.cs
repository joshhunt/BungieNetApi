using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyInsertPlugsActionRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyInsertPlugsActionRequest:  IEquatable<DestinyRequestsActionsDestinyInsertPlugsActionRequest>
    { 
        /// <summary>
        /// Action token provided by the AwaGetActionToken API call.
        /// </summary>
        public string ActionToken { get; private set; }

        /// <summary>
        /// The instance ID of the item having a plug inserted. Only instanced items can have sockets.
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// The plugs being inserted.
        /// </summary>
        public DestinyRequestsActionsDestinyInsertPlugsRequestEntry Plug { get; private set; }

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
        /// Use DestinyRequestsActionsDestinyInsertPlugsActionRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyInsertPlugsActionRequest()
        {
        }

        private DestinyRequestsActionsDestinyInsertPlugsActionRequest(string ActionToken, long? ItemInstanceId, DestinyRequestsActionsDestinyInsertPlugsRequestEntry Plug, long? CharacterId, int? MembershipType)
        {
            
            this.ActionToken = ActionToken;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Plug = Plug;
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyInsertPlugsActionRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder</returns>
        public DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder With()
        {
            return Builder()
                .ActionToken(ActionToken)
                .ItemInstanceId(ItemInstanceId)
                .Plug(Plug)
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

        public bool Equals(DestinyRequestsActionsDestinyInsertPlugsActionRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyInsertPlugsActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyInsertPlugsActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyInsertPlugsActionRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyInsertPlugsActionRequest left, DestinyRequestsActionsDestinyInsertPlugsActionRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyInsertPlugsActionRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyInsertPlugsActionRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyInsertPlugsActionRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyInsertPlugsActionRequest left, DestinyRequestsActionsDestinyInsertPlugsActionRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyInsertPlugsActionRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder
        {
            private string _ActionToken;
            private long? _ItemInstanceId;
            private DestinyRequestsActionsDestinyInsertPlugsRequestEntry _Plug;
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsActionRequest.ActionToken property.
            /// </summary>
            /// <param name="value">Action token provided by the AwaGetActionToken API call.</param>
            public DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder ActionToken(string value)
            {
                _ActionToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsActionRequest.ItemInstanceId property.
            /// </summary>
            /// <param name="value">The instance ID of the item having a plug inserted. Only instanced items can have sockets.</param>
            public DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsActionRequest.Plug property.
            /// </summary>
            /// <param name="value">The plugs being inserted.</param>
            public DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder Plug(DestinyRequestsActionsDestinyInsertPlugsRequestEntry value)
            {
                _Plug = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsActionRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsActionRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyInsertPlugsActionRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyInsertPlugsActionRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyInsertPlugsActionRequest</returns>
            public DestinyRequestsActionsDestinyInsertPlugsActionRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyInsertPlugsActionRequest(
                    ActionToken: _ActionToken,
                    ItemInstanceId: _ItemInstanceId,
                    Plug: _Plug,
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