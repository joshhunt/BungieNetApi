using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If a Destiny Profile can&#39;t be returned, but we&#39;re pretty certain it&#39;s a valid Destiny account, this will contain as much info as we can get about the profile for your use.  Assume that the most you&#39;ll get is the Error Code, the Membership Type and the Membership ID.
    /// </summary>
    public sealed class DestinyResponsesDestinyErrorProfile:  IEquatable<DestinyResponsesDestinyErrorProfile>
    { 
        /// <summary>
        /// The error that we encountered. You should be able to look up localized text to show to the user for these failures.
        /// </summary>
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// Basic info about the account that failed. Don&#39;t expect anything other than membership ID, Membership Type, and displayName to be populated.
        /// </summary>
        public UserUserInfoCard InfoCard { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyErrorProfile.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyErrorProfile()
        {
        }

        private DestinyResponsesDestinyErrorProfile(int? ErrorCode, UserUserInfoCard InfoCard)
        {
            
            this.ErrorCode = ErrorCode;
            
            this.InfoCard = InfoCard;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyErrorProfile.
        /// </summary>
        /// <returns>DestinyResponsesDestinyErrorProfileBuilder</returns>
        public static DestinyResponsesDestinyErrorProfileBuilder Builder()
        {
            return new DestinyResponsesDestinyErrorProfileBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyErrorProfileBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyErrorProfileBuilder</returns>
        public DestinyResponsesDestinyErrorProfileBuilder With()
        {
            return Builder()
                .ErrorCode(ErrorCode)
                .InfoCard(InfoCard);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyErrorProfile other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyErrorProfile.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyErrorProfile</param>
        /// <param name="right">Compared (DestinyResponsesDestinyErrorProfile</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyErrorProfile left, DestinyResponsesDestinyErrorProfile right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyErrorProfile.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyErrorProfile</param>
        /// <param name="right">Compared (DestinyResponsesDestinyErrorProfile</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyErrorProfile left, DestinyResponsesDestinyErrorProfile right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyErrorProfile.
        /// </summary>
        public sealed class DestinyResponsesDestinyErrorProfileBuilder
        {
            private int? _ErrorCode;
            private UserUserInfoCard _InfoCard;

            internal DestinyResponsesDestinyErrorProfileBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyErrorProfile.ErrorCode property.
            /// </summary>
            /// <param name="value">The error that we encountered. You should be able to look up localized text to show to the user for these failures.</param>
            public DestinyResponsesDestinyErrorProfileBuilder ErrorCode(int? value)
            {
                _ErrorCode = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyErrorProfile.InfoCard property.
            /// </summary>
            /// <param name="value">Basic info about the account that failed. Don&#39;t expect anything other than membership ID, Membership Type, and displayName to be populated.</param>
            public DestinyResponsesDestinyErrorProfileBuilder InfoCard(UserUserInfoCard value)
            {
                _InfoCard = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyErrorProfile.
            /// </summary>
            /// <returns>DestinyResponsesDestinyErrorProfile</returns>
            public DestinyResponsesDestinyErrorProfile Build()
            {
                Validate();
                return new DestinyResponsesDestinyErrorProfile(
                    ErrorCode: _ErrorCode,
                    InfoCard: _InfoCard
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}