using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TokensPartnerOfferHistoryResponse
    /// </summary>
    public sealed class TokensPartnerOfferHistoryResponse:  IEquatable<TokensPartnerOfferHistoryResponse>
    { 
        /// <summary>
        /// PartnerOfferKey
        /// </summary>
        public string PartnerOfferKey { get; private set; }

        /// <summary>
        /// MembershipId
        /// </summary>
        public long? MembershipId { get; private set; }

        /// <summary>
        /// MembershipType
        /// </summary>
        public MembershipTypeEnum? MembershipType { get; private set; }

        /// <summary>
        /// LocalizedName
        /// </summary>
        public string LocalizedName { get; private set; }

        /// <summary>
        /// LocalizedDescription
        /// </summary>
        public string LocalizedDescription { get; private set; }

        /// <summary>
        /// IsConsumable
        /// </summary>
        public bool? IsConsumable { get; private set; }

        /// <summary>
        /// QuantityApplied
        /// </summary>
        public int? QuantityApplied { get; private set; }

        /// <summary>
        /// ApplyDate
        /// </summary>
        public DateTime? ApplyDate { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TokensPartnerOfferHistoryResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TokensPartnerOfferHistoryResponse()
        {
        }

        private TokensPartnerOfferHistoryResponse(string PartnerOfferKey, long? MembershipId, MembershipTypeEnum? MembershipType, string LocalizedName, string LocalizedDescription, bool? IsConsumable, int? QuantityApplied, DateTime? ApplyDate)
        {
            
            this.PartnerOfferKey = PartnerOfferKey;
            
            this.MembershipId = MembershipId;
            
            this.MembershipType = MembershipType;
            
            this.LocalizedName = LocalizedName;
            
            this.LocalizedDescription = LocalizedDescription;
            
            this.IsConsumable = IsConsumable;
            
            this.QuantityApplied = QuantityApplied;
            
            this.ApplyDate = ApplyDate;
            
        }

        /// <summary>
        /// Returns builder of TokensPartnerOfferHistoryResponse.
        /// </summary>
        /// <returns>TokensPartnerOfferHistoryResponseBuilder</returns>
        public static TokensPartnerOfferHistoryResponseBuilder Builder()
        {
            return new TokensPartnerOfferHistoryResponseBuilder();
        }

        /// <summary>
        /// Returns TokensPartnerOfferHistoryResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TokensPartnerOfferHistoryResponseBuilder</returns>
        public TokensPartnerOfferHistoryResponseBuilder With()
        {
            return Builder()
                .PartnerOfferKey(PartnerOfferKey)
                .MembershipId(MembershipId)
                .MembershipType(MembershipType)
                .LocalizedName(LocalizedName)
                .LocalizedDescription(LocalizedDescription)
                .IsConsumable(IsConsumable)
                .QuantityApplied(QuantityApplied)
                .ApplyDate(ApplyDate);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TokensPartnerOfferHistoryResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TokensPartnerOfferHistoryResponse.
        /// </summary>
        /// <param name="left">Compared (TokensPartnerOfferHistoryResponse</param>
        /// <param name="right">Compared (TokensPartnerOfferHistoryResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TokensPartnerOfferHistoryResponse left, TokensPartnerOfferHistoryResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TokensPartnerOfferHistoryResponse.
        /// </summary>
        /// <param name="left">Compared (TokensPartnerOfferHistoryResponse</param>
        /// <param name="right">Compared (TokensPartnerOfferHistoryResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TokensPartnerOfferHistoryResponse left, TokensPartnerOfferHistoryResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TokensPartnerOfferHistoryResponse.
        /// </summary>
        public sealed class TokensPartnerOfferHistoryResponseBuilder
        {
            private string _PartnerOfferKey;
            private long? _MembershipId;
            private MembershipTypeEnum? _MembershipType;
            private string _LocalizedName;
            private string _LocalizedDescription;
            private bool? _IsConsumable;
            private int? _QuantityApplied;
            private DateTime? _ApplyDate;

            internal TokensPartnerOfferHistoryResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.PartnerOfferKey property.
            /// </summary>
            /// <param name="value">PartnerOfferKey</param>
            public TokensPartnerOfferHistoryResponseBuilder PartnerOfferKey(string value)
            {
                _PartnerOfferKey = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.MembershipId property.
            /// </summary>
            /// <param name="value">MembershipId</param>
            public TokensPartnerOfferHistoryResponseBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType</param>
            public TokensPartnerOfferHistoryResponseBuilder MembershipType(MembershipTypeEnum? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.LocalizedName property.
            /// </summary>
            /// <param name="value">LocalizedName</param>
            public TokensPartnerOfferHistoryResponseBuilder LocalizedName(string value)
            {
                _LocalizedName = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.LocalizedDescription property.
            /// </summary>
            /// <param name="value">LocalizedDescription</param>
            public TokensPartnerOfferHistoryResponseBuilder LocalizedDescription(string value)
            {
                _LocalizedDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.IsConsumable property.
            /// </summary>
            /// <param name="value">IsConsumable</param>
            public TokensPartnerOfferHistoryResponseBuilder IsConsumable(bool? value)
            {
                _IsConsumable = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.QuantityApplied property.
            /// </summary>
            /// <param name="value">QuantityApplied</param>
            public TokensPartnerOfferHistoryResponseBuilder QuantityApplied(int? value)
            {
                _QuantityApplied = value;
                return this;
            }

            /// <summary>
            /// Sets value for TokensPartnerOfferHistoryResponse.ApplyDate property.
            /// </summary>
            /// <param name="value">ApplyDate</param>
            public TokensPartnerOfferHistoryResponseBuilder ApplyDate(DateTime? value)
            {
                _ApplyDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TokensPartnerOfferHistoryResponse.
            /// </summary>
            /// <returns>TokensPartnerOfferHistoryResponse</returns>
            public TokensPartnerOfferHistoryResponse Build()
            {
                Validate();
                return new TokensPartnerOfferHistoryResponse(
                    PartnerOfferKey: _PartnerOfferKey,
                    MembershipId: _MembershipId,
                    MembershipType: _MembershipType,
                    LocalizedName: _LocalizedName,
                    LocalizedDescription: _LocalizedDescription,
                    IsConsumable: _IsConsumable,
                    QuantityApplied: _QuantityApplied,
                    ApplyDate: _ApplyDate
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum MembershipTypeEnum { _0, _1, _2, _3, _4, _5, _10, _254, _1 };
    }
}