using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsActionsDestinyPostmasterTransferRequest
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyPostmasterTransferRequest:  IEquatable<DestinyRequestsActionsDestinyPostmasterTransferRequest>
    { 
        /// <summary>
        /// ItemReferenceHash
        /// </summary>
        public int? ItemReferenceHash { get; private set; }

        /// <summary>
        /// StackSize
        /// </summary>
        public int? StackSize { get; private set; }

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
        /// Use DestinyRequestsActionsDestinyPostmasterTransferRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyPostmasterTransferRequest()
        {
        }

        private DestinyRequestsActionsDestinyPostmasterTransferRequest(int? ItemReferenceHash, int? StackSize, long? ItemId, long? CharacterId, int? MembershipType)
        {
            
            this.ItemReferenceHash = ItemReferenceHash;
            
            this.StackSize = StackSize;
            
            this.ItemId = ItemId;
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyPostmasterTransferRequest.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder</returns>
        public static DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder</returns>
        public DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder With()
        {
            return Builder()
                .ItemReferenceHash(ItemReferenceHash)
                .StackSize(StackSize)
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

        public bool Equals(DestinyRequestsActionsDestinyPostmasterTransferRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyPostmasterTransferRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyPostmasterTransferRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyPostmasterTransferRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyPostmasterTransferRequest left, DestinyRequestsActionsDestinyPostmasterTransferRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyPostmasterTransferRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyPostmasterTransferRequest</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyPostmasterTransferRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyPostmasterTransferRequest left, DestinyRequestsActionsDestinyPostmasterTransferRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyPostmasterTransferRequest.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder
        {
            private int? _ItemReferenceHash;
            private int? _StackSize;
            private long? _ItemId;
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyPostmasterTransferRequest.ItemReferenceHash property.
            /// </summary>
            /// <param name="value">ItemReferenceHash</param>
            public DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder ItemReferenceHash(int? value)
            {
                _ItemReferenceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyPostmasterTransferRequest.StackSize property.
            /// </summary>
            /// <param name="value">StackSize</param>
            public DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder StackSize(int? value)
            {
                _StackSize = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyPostmasterTransferRequest.ItemId property.
            /// </summary>
            /// <param name="value">ItemId</param>
            public DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder ItemId(long? value)
            {
                _ItemId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyPostmasterTransferRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyPostmasterTransferRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsActionsDestinyPostmasterTransferRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyPostmasterTransferRequest.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyPostmasterTransferRequest</returns>
            public DestinyRequestsActionsDestinyPostmasterTransferRequest Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyPostmasterTransferRequest(
                    ItemReferenceHash: _ItemReferenceHash,
                    StackSize: _StackSize,
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