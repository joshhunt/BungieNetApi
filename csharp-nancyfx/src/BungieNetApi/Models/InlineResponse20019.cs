using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// InlineResponse20019
    /// </summary>
    public sealed class InlineResponse20019:  IEquatable<InlineResponse20019>
    { 
        /// <summary>
        /// Response
        /// </summary>
        public GroupsV2GroupSearchResponse Response { get; private set; }

        /// <summary>
        /// ErrorCode
        /// </summary>
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// ThrottleSeconds
        /// </summary>
        public int? ThrottleSeconds { get; private set; }

        /// <summary>
        /// ErrorStatus
        /// </summary>
        public string ErrorStatus { get; private set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// MessageData
        /// </summary>
        public Dictionary<string, string> MessageData { get; private set; }

        /// <summary>
        /// DetailedErrorTrace
        /// </summary>
        public string DetailedErrorTrace { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use InlineResponse20019.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public InlineResponse20019()
        {
        }

        private InlineResponse20019(GroupsV2GroupSearchResponse Response, int? ErrorCode, int? ThrottleSeconds, string ErrorStatus, string Message, Dictionary<string, string> MessageData, string DetailedErrorTrace)
        {
            
            this.Response = Response;
            
            this.ErrorCode = ErrorCode;
            
            this.ThrottleSeconds = ThrottleSeconds;
            
            this.ErrorStatus = ErrorStatus;
            
            this.Message = Message;
            
            this.MessageData = MessageData;
            
            this.DetailedErrorTrace = DetailedErrorTrace;
            
        }

        /// <summary>
        /// Returns builder of InlineResponse20019.
        /// </summary>
        /// <returns>InlineResponse20019Builder</returns>
        public static InlineResponse20019Builder Builder()
        {
            return new InlineResponse20019Builder();
        }

        /// <summary>
        /// Returns InlineResponse20019Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>InlineResponse20019Builder</returns>
        public InlineResponse20019Builder With()
        {
            return Builder()
                .Response(Response)
                .ErrorCode(ErrorCode)
                .ThrottleSeconds(ThrottleSeconds)
                .ErrorStatus(ErrorStatus)
                .Message(Message)
                .MessageData(MessageData)
                .DetailedErrorTrace(DetailedErrorTrace);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(InlineResponse20019 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (InlineResponse20019.
        /// </summary>
        /// <param name="left">Compared (InlineResponse20019</param>
        /// <param name="right">Compared (InlineResponse20019</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (InlineResponse20019 left, InlineResponse20019 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (InlineResponse20019.
        /// </summary>
        /// <param name="left">Compared (InlineResponse20019</param>
        /// <param name="right">Compared (InlineResponse20019</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (InlineResponse20019 left, InlineResponse20019 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of InlineResponse20019.
        /// </summary>
        public sealed class InlineResponse20019Builder
        {
            private GroupsV2GroupSearchResponse _Response;
            private int? _ErrorCode;
            private int? _ThrottleSeconds;
            private string _ErrorStatus;
            private string _Message;
            private Dictionary<string, string> _MessageData;
            private string _DetailedErrorTrace;

            internal InlineResponse20019Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for InlineResponse20019.Response property.
            /// </summary>
            /// <param name="value">Response</param>
            public InlineResponse20019Builder Response(GroupsV2GroupSearchResponse value)
            {
                _Response = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20019.ErrorCode property.
            /// </summary>
            /// <param name="value">ErrorCode</param>
            public InlineResponse20019Builder ErrorCode(int? value)
            {
                _ErrorCode = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20019.ThrottleSeconds property.
            /// </summary>
            /// <param name="value">ThrottleSeconds</param>
            public InlineResponse20019Builder ThrottleSeconds(int? value)
            {
                _ThrottleSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20019.ErrorStatus property.
            /// </summary>
            /// <param name="value">ErrorStatus</param>
            public InlineResponse20019Builder ErrorStatus(string value)
            {
                _ErrorStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20019.Message property.
            /// </summary>
            /// <param name="value">Message</param>
            public InlineResponse20019Builder Message(string value)
            {
                _Message = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20019.MessageData property.
            /// </summary>
            /// <param name="value">MessageData</param>
            public InlineResponse20019Builder MessageData(Dictionary<string, string> value)
            {
                _MessageData = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20019.DetailedErrorTrace property.
            /// </summary>
            /// <param name="value">DetailedErrorTrace</param>
            public InlineResponse20019Builder DetailedErrorTrace(string value)
            {
                _DetailedErrorTrace = value;
                return this;
            }


            /// <summary>
            /// Builds instance of InlineResponse20019.
            /// </summary>
            /// <returns>InlineResponse20019</returns>
            public InlineResponse20019 Build()
            {
                Validate();
                return new InlineResponse20019(
                    Response: _Response,
                    ErrorCode: _ErrorCode,
                    ThrottleSeconds: _ThrottleSeconds,
                    ErrorStatus: _ErrorStatus,
                    Message: _Message,
                    MessageData: _MessageData,
                    DetailedErrorTrace: _DetailedErrorTrace
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}