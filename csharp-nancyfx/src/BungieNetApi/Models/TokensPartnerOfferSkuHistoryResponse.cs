using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TokensPartnerOfferSkuHistoryResponse
    /// </summary>
    public sealed class TokensPartnerOfferSkuHistoryResponse:  IEquatable<TokensPartnerOfferSkuHistoryResponse>
    { 
        /// <summary>
        /// SkuIdentifier
        /// </summary>
        public string SkuIdentifier { get; private set; }

        /// <summary>
        /// LocalizedName
        /// </summary>
        public string LocalizedName { get; private set; }

        /// <summary>
        /// LocalizedDescription
        /// </summary>
        public string LocalizedDescription { get; private set; }

        /// <summary>
        /// ClaimDate
        /// </summary>
        public DateTime? ClaimDate { get; private set; }

        /// <summary>
        /// AllOffersApplied
        /// </summary>
        public bool? AllOffersApplied { get; private set; }

        /// <summary>
        /// TransactionId
        /// </summary>
        public string TransactionId { get; private set; }

        /// <summary>
        /// SkuOffers
        /// </summary>
        public List<TokensPartnerOfferHistoryResponse> SkuOffers { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TokensPartnerOfferSkuHistoryResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TokensPartnerOfferSkuHistoryResponse()
        {
        }

        private TokensPartnerOfferSkuHistoryResponse(string SkuIdentifier, string LocalizedName, string LocalizedDescription, DateTime? ClaimDate, bool? AllOffersApplied, string TransactionId, List<TokensPartnerOfferHistoryResponse> SkuOffers)
        {
            
            this.SkuIdentifier = SkuIdentifier;
            
            this.LocalizedName = LocalizedName;
            
            this.LocalizedDescription = LocalizedDescription;
            
            this.ClaimDate = ClaimDate;
            
            this.AllOffersApplied = AllOffersApplied;
            
            this.TransactionId = TransactionId;
            
            this.SkuOffers = SkuOffers;
            
        }

        /// <summary>
        /// Returns builder of TokensPartnerOfferSkuHistoryResponse.
        /// </summary>
        /// <returns>TokensPartnerOfferSkuHistoryResponseBuilder</returns>
        public static TokensPartnerOfferSkuHistoryResponseBuilder Builder()
        {
            return new TokensPartnerOfferSkuHistoryResponseBuilder();
        }

        /// <summary>
        /// Returns TokensPartnerOfferSkuHistoryResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TokensPartnerOfferSkuHistoryResponseBuilder</returns>
        public TokensPartnerOfferSkuHistoryResponseBuilder With()
        {
            return Builder()
                .SkuIdentifier(SkuIdentifier)
                .LocalizedName(LocalizedName)
                .LocalizedDescription(LocalizedDescription)
                .ClaimDate(ClaimDate)
                .AllOffersApplied(AllOffersApplied)
                .TransactionId(TransactionId)
                .SkuOffers(SkuOffers);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TokensPartnerOfferSkuHistoryResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TokensPartnerOfferSkuHistoryResponse.
        /// </summary>
        /// <param name="left">Compared (TokensPartnerOfferSkuHistoryResponse</param>
        /// <param name="right">Compared (TokensPartnerOfferSkuHistoryResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TokensPartnerOfferSkuHistoryResponse left, TokensPartnerOfferSkuHistoryResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TokensPartnerOfferSkuHistoryResponse.
        /// </summary>
        /// <param name="left">Compared (TokensPartnerOfferSkuHistoryResponse</param>
        /// <param name="right">Compared (TokensPartnerOfferSkuHistoryResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TokensPartnerOfferSkuHistoryResponse left, TokensPartnerOfferSkuHistoryResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TokensPartnerOfferSkuHistoryResponse.
        /// </summary>
        public sealed class TokensPartnerOfferSkuHistoryResponseBuilder
        {
            private string _SkuIdentifier;
            private string _LocalizedName;
            private string _LocalizedDescription;
            private DateTime? _ClaimDate;
            private bool? _AllOffersApplied;
            private string _TransactionId;
            private List<TokensPartnerOfferHistoryResponse> _SkuOffers;

            internal TokensPartnerOfferSkuHistoryResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.SkuIdentifier property.
            /// </summary>
            /// <param name="value">SkuIdentifier</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder SkuIdentifier(string value)
            {
                _SkuIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.LocalizedName property.
            /// </summary>
            /// <param name="value">LocalizedName</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder LocalizedName(string value)
            {
                _LocalizedName = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.LocalizedDescription property.
            /// </summary>
            /// <param name="value">LocalizedDescription</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder LocalizedDescription(string value)
            {
                _LocalizedDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.ClaimDate property.
            /// </summary>
            /// <param name="value">ClaimDate</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder ClaimDate(DateTime? value)
            {
                _ClaimDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.AllOffersApplied property.
            /// </summary>
            /// <param name="value">AllOffersApplied</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder AllOffersApplied(bool? value)
            {
                _AllOffersApplied = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.TransactionId property.
            /// </summary>
            /// <param name="value">TransactionId</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder TransactionId(string value)
            {
                _TransactionId = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferSkuHistoryResponse.SkuOffers property.
            /// </summary>
            /// <param name="value">SkuOffers</param>
            public TokensPartnerOfferSkuHistoryResponseBuilder SkuOffers(List<TokensPartnerOfferHistoryResponse> value)
            {
                _SkuOffers = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TokensPartnerOfferSkuHistoryResponse.
            /// </summary>
            /// <returns>TokensPartnerOfferSkuHistoryResponse</returns>
            public TokensPartnerOfferSkuHistoryResponse Build()
            {
                Validate();
                return new TokensPartnerOfferSkuHistoryResponse(
                    SkuIdentifier: _SkuIdentifier,
                    LocalizedName: _LocalizedName,
                    LocalizedDescription: _LocalizedDescription,
                    ClaimDate: _ClaimDate,
                    AllOffersApplied: _AllOffersApplied,
                    TransactionId: _TransactionId,
                    SkuOffers: _SkuOffers
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}