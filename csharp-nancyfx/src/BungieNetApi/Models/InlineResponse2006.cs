using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// InlineResponse2006
    /// </summary>
    public sealed class InlineResponse2006:  IEquatable<InlineResponse2006>
    { 
        /// <summary>
        /// Response
        /// </summary>
        public UserHardLinkedUserMembership Response { get; private set; }

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
        /// Use InlineResponse2006.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public InlineResponse2006()
        {
        }

        private InlineResponse2006(UserHardLinkedUserMembership Response, int? ErrorCode, int? ThrottleSeconds, string ErrorStatus, string Message, Dictionary<string, string> MessageData, string DetailedErrorTrace)
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
        /// Returns builder of InlineResponse2006.
        /// </summary>
        /// <returns>InlineResponse2006Builder</returns>
        public static InlineResponse2006Builder Builder()
        {
            return new InlineResponse2006Builder();
        }

        /// <summary>
        /// Returns InlineResponse2006Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>InlineResponse2006Builder</returns>
        public InlineResponse2006Builder With()
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

        public bool Equals(InlineResponse2006 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (InlineResponse2006.
        /// </summary>
        /// <param name="left">Compared (InlineResponse2006</param>
        /// <param name="right">Compared (InlineResponse2006</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (InlineResponse2006 left, InlineResponse2006 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (InlineResponse2006.
        /// </summary>
        /// <param name="left">Compared (InlineResponse2006</param>
        /// <param name="right">Compared (InlineResponse2006</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (InlineResponse2006 left, InlineResponse2006 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of InlineResponse2006.
        /// </summary>
        public sealed class InlineResponse2006Builder
        {
            private UserHardLinkedUserMembership _Response;
            private int? _ErrorCode;
            private int? _ThrottleSeconds;
            private string _ErrorStatus;
            private string _Message;
            private Dictionary<string, string> _MessageData;
            private string _DetailedErrorTrace;

            internal InlineResponse2006Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for InlineResponse2006.Response property.
            /// </summary>
            /// <param name="value">Response</param>
            public InlineResponse2006Builder Response(UserHardLinkedUserMembership value)
            {
                _Response = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse2006.ErrorCode property.
            /// </summary>
            /// <param name="value">ErrorCode</param>
            public InlineResponse2006Builder ErrorCode(int? value)
            {
                _ErrorCode = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse2006.ThrottleSeconds property.
            /// </summary>
            /// <param name="value">ThrottleSeconds</param>
            public InlineResponse2006Builder ThrottleSeconds(int? value)
            {
                _ThrottleSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse2006.ErrorStatus property.
            /// </summary>
            /// <param name="value">ErrorStatus</param>
            public InlineResponse2006Builder ErrorStatus(string value)
            {
                _ErrorStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse2006.Message property.
            /// </summary>
            /// <param name="value">Message</param>
            public InlineResponse2006Builder Message(string value)
            {
                _Message = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse2006.MessageData property.
            /// </summary>
            /// <param name="value">MessageData</param>
            public InlineResponse2006Builder MessageData(Dictionary<string, string> value)
            {
                _MessageData = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse2006.DetailedErrorTrace property.
            /// </summary>
            /// <param name="value">DetailedErrorTrace</param>
            public InlineResponse2006Builder DetailedErrorTrace(string value)
            {
                _DetailedErrorTrace = value;
                return this;
            }


            /// <summary>
            /// Builds instance of InlineResponse2006.
            /// </summary>
            /// <returns>InlineResponse2006</returns>
            public InlineResponse2006 Build()
            {
                Validate();
                return new InlineResponse2006(
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