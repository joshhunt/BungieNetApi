using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyAdvancedAwaInitializeResponse
    /// </summary>
    public sealed class DestinyAdvancedAwaInitializeResponse:  IEquatable<DestinyAdvancedAwaInitializeResponse>
    { 
        /// <summary>
        /// ID used to get the token. Present this ID to the user as it will identify this specific request on their device.
        /// </summary>
        public string CorrelationId { get; private set; }

        /// <summary>
        /// True if the PUSH message will only be sent to the device that made this request.
        /// </summary>
        public bool? SentToSelf { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyAdvancedAwaInitializeResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyAdvancedAwaInitializeResponse()
        {
        }

        private DestinyAdvancedAwaInitializeResponse(string CorrelationId, bool? SentToSelf)
        {
            
            this.CorrelationId = CorrelationId;
            
            this.SentToSelf = SentToSelf;
            
        }

        /// <summary>
        /// Returns builder of DestinyAdvancedAwaInitializeResponse.
        /// </summary>
        /// <returns>DestinyAdvancedAwaInitializeResponseBuilder</returns>
        public static DestinyAdvancedAwaInitializeResponseBuilder Builder()
        {
            return new DestinyAdvancedAwaInitializeResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyAdvancedAwaInitializeResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyAdvancedAwaInitializeResponseBuilder</returns>
        public DestinyAdvancedAwaInitializeResponseBuilder With()
        {
            return Builder()
                .CorrelationId(CorrelationId)
                .SentToSelf(SentToSelf);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyAdvancedAwaInitializeResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyAdvancedAwaInitializeResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaInitializeResponse</param>
        /// <param name="right">Compared (DestinyAdvancedAwaInitializeResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyAdvancedAwaInitializeResponse left, DestinyAdvancedAwaInitializeResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyAdvancedAwaInitializeResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaInitializeResponse</param>
        /// <param name="right">Compared (DestinyAdvancedAwaInitializeResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyAdvancedAwaInitializeResponse left, DestinyAdvancedAwaInitializeResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyAdvancedAwaInitializeResponse.
        /// </summary>
        public sealed class DestinyAdvancedAwaInitializeResponseBuilder
        {
            private string _CorrelationId;
            private bool? _SentToSelf;

            internal DestinyAdvancedAwaInitializeResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaInitializeResponse.CorrelationId property.
            /// </summary>
            /// <param name="value">ID used to get the token. Present this ID to the user as it will identify this specific request on their device.</param>
            public DestinyAdvancedAwaInitializeResponseBuilder CorrelationId(string value)
            {
                _CorrelationId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaInitializeResponse.SentToSelf property.
            /// </summary>
            /// <param name="value">True if the PUSH message will only be sent to the device that made this request.</param>
            public DestinyAdvancedAwaInitializeResponseBuilder SentToSelf(bool? value)
            {
                _SentToSelf = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyAdvancedAwaInitializeResponse.
            /// </summary>
            /// <returns>DestinyAdvancedAwaInitializeResponse</returns>
            public DestinyAdvancedAwaInitializeResponse Build()
            {
                Validate();
                return new DestinyAdvancedAwaInitializeResponse(
                    CorrelationId: _CorrelationId,
                    SentToSelf: _SentToSelf
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}