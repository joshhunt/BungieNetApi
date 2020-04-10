using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyRequestsDestinyItemTransferRequest
    /// </summary>
    public sealed class DestinyRequestsDestinyItemTransferRequest:  IEquatable<DestinyRequestsDestinyItemTransferRequest>
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
        /// TransferToVault
        /// </summary>
        public bool? TransferToVault { get; private set; }

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
        /// Use DestinyRequestsDestinyItemTransferRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsDestinyItemTransferRequest()
        {
        }

        private DestinyRequestsDestinyItemTransferRequest(int? ItemReferenceHash, int? StackSize, bool? TransferToVault, long? ItemId, long? CharacterId, int? MembershipType)
        {
            
            this.ItemReferenceHash = ItemReferenceHash;
            
            this.StackSize = StackSize;
            
            this.TransferToVault = TransferToVault;
            
            this.ItemId = ItemId;
            
            this.CharacterId = CharacterId;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsDestinyItemTransferRequest.
        /// </summary>
        /// <returns>DestinyRequestsDestinyItemTransferRequestBuilder</returns>
        public static DestinyRequestsDestinyItemTransferRequestBuilder Builder()
        {
            return new DestinyRequestsDestinyItemTransferRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsDestinyItemTransferRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsDestinyItemTransferRequestBuilder</returns>
        public DestinyRequestsDestinyItemTransferRequestBuilder With()
        {
            return Builder()
                .ItemReferenceHash(ItemReferenceHash)
                .StackSize(StackSize)
                .TransferToVault(TransferToVault)
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

        public bool Equals(DestinyRequestsDestinyItemTransferRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsDestinyItemTransferRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsDestinyItemTransferRequest</param>
        /// <param name="right">Compared (DestinyRequestsDestinyItemTransferRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsDestinyItemTransferRequest left, DestinyRequestsDestinyItemTransferRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsDestinyItemTransferRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsDestinyItemTransferRequest</param>
        /// <param name="right">Compared (DestinyRequestsDestinyItemTransferRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsDestinyItemTransferRequest left, DestinyRequestsDestinyItemTransferRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsDestinyItemTransferRequest.
        /// </summary>
        public sealed class DestinyRequestsDestinyItemTransferRequestBuilder
        {
            private int? _ItemReferenceHash;
            private int? _StackSize;
            private bool? _TransferToVault;
            private long? _ItemId;
            private long? _CharacterId;
            private int? _MembershipType;

            internal DestinyRequestsDestinyItemTransferRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsDestinyItemTransferRequest.ItemReferenceHash property.
            /// </summary>
            /// <param name="value">ItemReferenceHash</param>
            public DestinyRequestsDestinyItemTransferRequestBuilder ItemReferenceHash(int? value)
            {
                _ItemReferenceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsDestinyItemTransferRequest.StackSize property.
            /// </summary>
            /// <param name="value">StackSize</param>
            public DestinyRequestsDestinyItemTransferRequestBuilder StackSize(int? value)
            {
                _StackSize = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsDestinyItemTransferRequest.TransferToVault property.
            /// </summary>
            /// <param name="value">TransferToVault</param>
            public DestinyRequestsDestinyItemTransferRequestBuilder TransferToVault(bool? value)
            {
                _TransferToVault = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsDestinyItemTransferRequest.ItemId property.
            /// </summary>
            /// <param name="value">ItemId</param>
            public DestinyRequestsDestinyItemTransferRequestBuilder ItemId(long? value)
            {
                _ItemId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsDestinyItemTransferRequest.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyRequestsDestinyItemTransferRequestBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsDestinyItemTransferRequest.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public DestinyRequestsDestinyItemTransferRequestBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsDestinyItemTransferRequest.
            /// </summary>
            /// <returns>DestinyRequestsDestinyItemTransferRequest</returns>
            public DestinyRequestsDestinyItemTransferRequest Build()
            {
                Validate();
                return new DestinyRequestsDestinyItemTransferRequest(
                    ItemReferenceHash: _ItemReferenceHash,
                    StackSize: _StackSize,
                    TransferToVault: _TransferToVault,
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