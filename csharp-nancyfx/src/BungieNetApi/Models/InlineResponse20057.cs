using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// InlineResponse20057
    /// </summary>
    public sealed class InlineResponse20057:  IEquatable<InlineResponse20057>
    { 
        /// <summary>
        /// Response
        /// </summary>
        public DestinyMilestonesDestinyMilestoneContent Response { get; private set; }

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
        /// Use InlineResponse20057.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public InlineResponse20057()
        {
        }

        private InlineResponse20057(DestinyMilestonesDestinyMilestoneContent Response, int? ErrorCode, int? ThrottleSeconds, string ErrorStatus, string Message, Dictionary<string, string> MessageData, string DetailedErrorTrace)
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
        /// Returns builder of InlineResponse20057.
        /// </summary>
        /// <returns>InlineResponse20057Builder</returns>
        public static InlineResponse20057Builder Builder()
        {
            return new InlineResponse20057Builder();
        }

        /// <summary>
        /// Returns InlineResponse20057Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>InlineResponse20057Builder</returns>
        public InlineResponse20057Builder With()
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

        public bool Equals(InlineResponse20057 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (InlineResponse20057.
        /// </summary>
        /// <param name="left">Compared (InlineResponse20057</param>
        /// <param name="right">Compared (InlineResponse20057</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (InlineResponse20057 left, InlineResponse20057 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (InlineResponse20057.
        /// </summary>
        /// <param name="left">Compared (InlineResponse20057</param>
        /// <param name="right">Compared (InlineResponse20057</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (InlineResponse20057 left, InlineResponse20057 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of InlineResponse20057.
        /// </summary>
        public sealed class InlineResponse20057Builder
        {
            private DestinyMilestonesDestinyMilestoneContent _Response;
            private int? _ErrorCode;
            private int? _ThrottleSeconds;
            private string _ErrorStatus;
            private string _Message;
            private Dictionary<string, string> _MessageData;
            private string _DetailedErrorTrace;

            internal InlineResponse20057Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for InlineResponse20057.Response property.
            /// </summary>
            /// <param name="value">Response</param>
            public InlineResponse20057Builder Response(DestinyMilestonesDestinyMilestoneContent value)
            {
                _Response = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20057.ErrorCode property.
            /// </summary>
            /// <param name="value">ErrorCode</param>
            public InlineResponse20057Builder ErrorCode(int? value)
            {
                _ErrorCode = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20057.ThrottleSeconds property.
            /// </summary>
            /// <param name="value">ThrottleSeconds</param>
            public InlineResponse20057Builder ThrottleSeconds(int? value)
            {
                _ThrottleSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20057.ErrorStatus property.
            /// </summary>
            /// <param name="value">ErrorStatus</param>
            public InlineResponse20057Builder ErrorStatus(string value)
            {
                _ErrorStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20057.Message property.
            /// </summary>
            /// <param name="value">Message</param>
            public InlineResponse20057Builder Message(string value)
            {
                _Message = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20057.MessageData property.
            /// </summary>
            /// <param name="value">MessageData</param>
            public InlineResponse20057Builder MessageData(Dictionary<string, string> value)
            {
                _MessageData = value;
                return this;
            }

            /// <summary>
            /// Sets value for InlineResponse20057.DetailedErrorTrace property.
            /// </summary>
            /// <param name="value">DetailedErrorTrace</param>
            public InlineResponse20057Builder DetailedErrorTrace(string value)
            {
                _DetailedErrorTrace = value;
                return this;
            }


            /// <summary>
            /// Builds instance of InlineResponse20057.
            /// </summary>
            /// <returns>InlineResponse20057</returns>
            public InlineResponse20057 Build()
            {
                Validate();
                return new InlineResponse20057(
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