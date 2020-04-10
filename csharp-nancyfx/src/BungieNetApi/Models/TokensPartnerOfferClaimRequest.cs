using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TokensPartnerOfferClaimRequest
    /// </summary>
    public sealed class TokensPartnerOfferClaimRequest:  IEquatable<TokensPartnerOfferClaimRequest>
    { 
        /// <summary>
        /// PartnerOfferId
        /// </summary>
        public string PartnerOfferId { get; private set; }

        /// <summary>
        /// BungieNetMembershipId
        /// </summary>
        public long? BungieNetMembershipId { get; private set; }

        /// <summary>
        /// TransactionId
        /// </summary>
        public string TransactionId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TokensPartnerOfferClaimRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TokensPartnerOfferClaimRequest()
        {
        }

        private TokensPartnerOfferClaimRequest(string PartnerOfferId, long? BungieNetMembershipId, string TransactionId)
        {
            
            this.PartnerOfferId = PartnerOfferId;
            
            this.BungieNetMembershipId = BungieNetMembershipId;
            
            this.TransactionId = TransactionId;
            
        }

        /// <summary>
        /// Returns builder of TokensPartnerOfferClaimRequest.
        /// </summary>
        /// <returns>TokensPartnerOfferClaimRequestBuilder</returns>
        public static TokensPartnerOfferClaimRequestBuilder Builder()
        {
            return new TokensPartnerOfferClaimRequestBuilder();
        }

        /// <summary>
        /// Returns TokensPartnerOfferClaimRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TokensPartnerOfferClaimRequestBuilder</returns>
        public TokensPartnerOfferClaimRequestBuilder With()
        {
            return Builder()
                .PartnerOfferId(PartnerOfferId)
                .BungieNetMembershipId(BungieNetMembershipId)
                .TransactionId(TransactionId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TokensPartnerOfferClaimRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TokensPartnerOfferClaimRequest.
        /// </summary>
        /// <param name="left">Compared (TokensPartnerOfferClaimRequest</param>
        /// <param name="right">Compared (TokensPartnerOfferClaimRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TokensPartnerOfferClaimRequest left, TokensPartnerOfferClaimRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TokensPartnerOfferClaimRequest.
        /// </summary>
        /// <param name="left">Compared (TokensPartnerOfferClaimRequest</param>
        /// <param name="right">Compared (TokensPartnerOfferClaimRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TokensPartnerOfferClaimRequest left, TokensPartnerOfferClaimRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TokensPartnerOfferClaimRequest.
        /// </summary>
        public sealed class TokensPartnerOfferClaimRequestBuilder
        {
            private string _PartnerOfferId;
            private long? _BungieNetMembershipId;
            private string _TransactionId;

            internal TokensPartnerOfferClaimRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferClaimRequest.PartnerOfferId property.
            /// </summary>
            /// <param name="value">PartnerOfferId</param>
            public TokensPartnerOfferClaimRequestBuilder PartnerOfferId(string value)
            {
                _PartnerOfferId = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferClaimRequest.BungieNetMembershipId property.
            /// </summary>
            /// <param name="value">BungieNetMembershipId</param>
            public TokensPartnerOfferClaimRequestBuilder BungieNetMembershipId(long? value)
            {
                _BungieNetMembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferClaimRequest.TransactionId property.
            /// </summary>
            /// <param name="value">TransactionId</param>
            public TokensPartnerOfferClaimRequestBuilder TransactionId(string value)
            {
                _TransactionId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TokensPartnerOfferClaimRequest.
            /// </summary>
            /// <returns>TokensPartnerOfferClaimRequest</returns>
            public TokensPartnerOfferClaimRequest Build()
            {
                Validate();
                return new TokensPartnerOfferClaimRequest(
                    PartnerOfferId: _PartnerOfferId,
                    BungieNetMembershipId: _BungieNetMembershipId,
                    TransactionId: _TransactionId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}