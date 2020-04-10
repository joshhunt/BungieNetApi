using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// StreamInfo
    /// </summary>
    public sealed class StreamInfo:  IEquatable<StreamInfo>
    { 
        /// <summary>
        /// ChannelName
        /// </summary>
        public string ChannelName { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use StreamInfo.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public StreamInfo()
        {
        }

        private StreamInfo(string ChannelName)
        {
            
            this.ChannelName = ChannelName;
            
        }

        /// <summary>
        /// Returns builder of StreamInfo.
        /// </summary>
        /// <returns>StreamInfoBuilder</returns>
        public static StreamInfoBuilder Builder()
        {
            return new StreamInfoBuilder();
        }

        /// <summary>
        /// Returns StreamInfoBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>StreamInfoBuilder</returns>
        public StreamInfoBuilder With()
        {
            return Builder()
                .ChannelName(ChannelName);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(StreamInfo other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (StreamInfo.
        /// </summary>
        /// <param name="left">Compared (StreamInfo</param>
        /// <param name="right">Compared (StreamInfo</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (StreamInfo left, StreamInfo right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (StreamInfo.
        /// </summary>
        /// <param name="left">Compared (StreamInfo</param>
        /// <param name="right">Compared (StreamInfo</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (StreamInfo left, StreamInfo right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of StreamInfo.
        /// </summary>
        public sealed class StreamInfoBuilder
        {
            private string _ChannelName;

            internal StreamInfoBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for StreamInfo.ChannelName property.
            /// </summary>
            /// <param name="value">ChannelName</param>
            public StreamInfoBuilder ChannelName(string value)
            {
                _ChannelName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of StreamInfo.
            /// </summary>
            /// <returns>StreamInfo</returns>
            public StreamInfo Build()
            {
                Validate();
                return new StreamInfo(
                    ChannelName: _ChannelName
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}