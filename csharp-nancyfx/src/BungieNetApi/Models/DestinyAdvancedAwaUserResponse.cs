using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyAdvancedAwaUserResponse
    /// </summary>
    public sealed class DestinyAdvancedAwaUserResponse:  IEquatable<DestinyAdvancedAwaUserResponse>
    { 
        /// <summary>
        /// Indication of the selection the user has made (Approving or rejecting the action)
        /// </summary>
        public int? Selection { get; private set; }

        /// <summary>
        /// Correlation ID of the request
        /// </summary>
        public string CorrelationId { get; private set; }

        /// <summary>
        /// Secret nonce received via the PUSH notification.
        /// </summary>
        public List<byte[]> Nonce { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyAdvancedAwaUserResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyAdvancedAwaUserResponse()
        {
        }

        private DestinyAdvancedAwaUserResponse(int? Selection, string CorrelationId, List<byte[]> Nonce)
        {
            
            this.Selection = Selection;
            
            this.CorrelationId = CorrelationId;
            
            this.Nonce = Nonce;
            
        }

        /// <summary>
        /// Returns builder of DestinyAdvancedAwaUserResponse.
        /// </summary>
        /// <returns>DestinyAdvancedAwaUserResponseBuilder</returns>
        public static DestinyAdvancedAwaUserResponseBuilder Builder()
        {
            return new DestinyAdvancedAwaUserResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyAdvancedAwaUserResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyAdvancedAwaUserResponseBuilder</returns>
        public DestinyAdvancedAwaUserResponseBuilder With()
        {
            return Builder()
                .Selection(Selection)
                .CorrelationId(CorrelationId)
                .Nonce(Nonce);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyAdvancedAwaUserResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyAdvancedAwaUserResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaUserResponse</param>
        /// <param name="right">Compared (DestinyAdvancedAwaUserResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyAdvancedAwaUserResponse left, DestinyAdvancedAwaUserResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyAdvancedAwaUserResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaUserResponse</param>
        /// <param name="right">Compared (DestinyAdvancedAwaUserResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyAdvancedAwaUserResponse left, DestinyAdvancedAwaUserResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyAdvancedAwaUserResponse.
        /// </summary>
        public sealed class DestinyAdvancedAwaUserResponseBuilder
        {
            private int? _Selection;
            private string _CorrelationId;
            private List<byte[]> _Nonce;

            internal DestinyAdvancedAwaUserResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaUserResponse.Selection property.
            /// </summary>
            /// <param name="value">Indication of the selection the user has made (Approving or rejecting the action)</param>
            public DestinyAdvancedAwaUserResponseBuilder Selection(int? value)
            {
                _Selection = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaUserResponse.CorrelationId property.
            /// </summary>
            /// <param name="value">Correlation ID of the request</param>
            public DestinyAdvancedAwaUserResponseBuilder CorrelationId(string value)
            {
                _CorrelationId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaUserResponse.Nonce property.
            /// </summary>
            /// <param name="value">Secret nonce received via the PUSH notification.</param>
            public DestinyAdvancedAwaUserResponseBuilder Nonce(List<byte[]> value)
            {
                _Nonce = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyAdvancedAwaUserResponse.
            /// </summary>
            /// <returns>DestinyAdvancedAwaUserResponse</returns>
            public DestinyAdvancedAwaUserResponse Build()
            {
                Validate();
                return new DestinyAdvancedAwaUserResponse(
                    Selection: _Selection,
                    CorrelationId: _CorrelationId,
                    Nonce: _Nonce
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}