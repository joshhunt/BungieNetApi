using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GlobalAlert
    /// </summary>
    public sealed class GlobalAlert:  IEquatable<GlobalAlert>
    { 
        /// <summary>
        /// AlertKey
        /// </summary>
        public string AlertKey { get; private set; }

        /// <summary>
        /// AlertHtml
        /// </summary>
        public string AlertHtml { get; private set; }

        /// <summary>
        /// AlertTimestamp
        /// </summary>
        public DateTime? AlertTimestamp { get; private set; }

        /// <summary>
        /// AlertLink
        /// </summary>
        public string AlertLink { get; private set; }

        /// <summary>
        /// AlertLevel
        /// </summary>
        public int? AlertLevel { get; private set; }

        /// <summary>
        /// AlertType
        /// </summary>
        public int? AlertType { get; private set; }

        /// <summary>
        /// StreamInfo
        /// </summary>
        public StreamInfo StreamInfo { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GlobalAlert.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GlobalAlert()
        {
        }

        private GlobalAlert(string AlertKey, string AlertHtml, DateTime? AlertTimestamp, string AlertLink, int? AlertLevel, int? AlertType, StreamInfo StreamInfo)
        {
            
            this.AlertKey = AlertKey;
            
            this.AlertHtml = AlertHtml;
            
            this.AlertTimestamp = AlertTimestamp;
            
            this.AlertLink = AlertLink;
            
            this.AlertLevel = AlertLevel;
            
            this.AlertType = AlertType;
            
            this.StreamInfo = StreamInfo;
            
        }

        /// <summary>
        /// Returns builder of GlobalAlert.
        /// </summary>
        /// <returns>GlobalAlertBuilder</returns>
        public static GlobalAlertBuilder Builder()
        {
            return new GlobalAlertBuilder();
        }

        /// <summary>
        /// Returns GlobalAlertBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GlobalAlertBuilder</returns>
        public GlobalAlertBuilder With()
        {
            return Builder()
                .AlertKey(AlertKey)
                .AlertHtml(AlertHtml)
                .AlertTimestamp(AlertTimestamp)
                .AlertLink(AlertLink)
                .AlertLevel(AlertLevel)
                .AlertType(AlertType)
                .StreamInfo(StreamInfo);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GlobalAlert other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GlobalAlert.
        /// </summary>
        /// <param name="left">Compared (GlobalAlert</param>
        /// <param name="right">Compared (GlobalAlert</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GlobalAlert left, GlobalAlert right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GlobalAlert.
        /// </summary>
        /// <param name="left">Compared (GlobalAlert</param>
        /// <param name="right">Compared (GlobalAlert</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GlobalAlert left, GlobalAlert right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GlobalAlert.
        /// </summary>
        public sealed class GlobalAlertBuilder
        {
            private string _AlertKey;
            private string _AlertHtml;
            private DateTime? _AlertTimestamp;
            private string _AlertLink;
            private int? _AlertLevel;
            private int? _AlertType;
            private StreamInfo _StreamInfo;

            internal GlobalAlertBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GlobalAlert.AlertKey property.
            /// </summary>
            /// <param name="value">AlertKey</param>
            public GlobalAlertBuilder AlertKey(string value)
            {
                _AlertKey = value;
                return this;
            }

            /// <summary>
            /// Sets value for GlobalAlert.AlertHtml property.
            /// </summary>
            /// <param name="value">AlertHtml</param>
            public GlobalAlertBuilder AlertHtml(string value)
            {
                _AlertHtml = value;
                return this;
            }

            /// <summary>
            /// Sets value for GlobalAlert.AlertTimestamp property.
            /// </summary>
            /// <param name="value">AlertTimestamp</param>
            public GlobalAlertBuilder AlertTimestamp(DateTime? value)
            {
                _AlertTimestamp = value;
                return this;
            }

            /// <summary>
            /// Sets value for GlobalAlert.AlertLink property.
            /// </summary>
            /// <param name="value">AlertLink</param>
            public GlobalAlertBuilder AlertLink(string value)
            {
                _AlertLink = value;
                return this;
            }

            /// <summary>
            /// Sets value for GlobalAlert.AlertLevel property.
            /// </summary>
            /// <param name="value">AlertLevel</param>
            public GlobalAlertBuilder AlertLevel(int? value)
            {
                _AlertLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for GlobalAlert.AlertType property.
            /// </summary>
            /// <param name="value">AlertType</param>
            public GlobalAlertBuilder AlertType(int? value)
            {
                _AlertType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GlobalAlert.StreamInfo property.
            /// </summary>
            /// <param name="value">StreamInfo</param>
            public GlobalAlertBuilder StreamInfo(StreamInfo value)
            {
                _StreamInfo = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GlobalAlert.
            /// </summary>
            /// <returns>GlobalAlert</returns>
            public GlobalAlert Build()
            {
                Validate();
                return new GlobalAlert(
                    AlertKey: _AlertKey,
                    AlertHtml: _AlertHtml,
                    AlertTimestamp: _AlertTimestamp,
                    AlertLink: _AlertLink,
                    AlertLevel: _AlertLevel,
                    AlertType: _AlertType,
                    StreamInfo: _StreamInfo
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}