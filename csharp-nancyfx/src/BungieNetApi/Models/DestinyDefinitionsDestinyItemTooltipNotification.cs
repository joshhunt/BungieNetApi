using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyItemTooltipNotification
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemTooltipNotification:  IEquatable<DestinyDefinitionsDestinyItemTooltipNotification>
    { 
        /// <summary>
        /// DisplayString
        /// </summary>
        public string DisplayString { get; private set; }

        /// <summary>
        /// DisplayStyle
        /// </summary>
        public string DisplayStyle { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemTooltipNotification.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemTooltipNotification()
        {
        }

        private DestinyDefinitionsDestinyItemTooltipNotification(string DisplayString, string DisplayStyle)
        {
            
            this.DisplayString = DisplayString;
            
            this.DisplayStyle = DisplayStyle;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemTooltipNotification.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemTooltipNotificationBuilder</returns>
        public static DestinyDefinitionsDestinyItemTooltipNotificationBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemTooltipNotificationBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemTooltipNotificationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemTooltipNotificationBuilder</returns>
        public DestinyDefinitionsDestinyItemTooltipNotificationBuilder With()
        {
            return Builder()
                .DisplayString(DisplayString)
                .DisplayStyle(DisplayStyle);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemTooltipNotification other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemTooltipNotification.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemTooltipNotification</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemTooltipNotification</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemTooltipNotification left, DestinyDefinitionsDestinyItemTooltipNotification right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemTooltipNotification.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemTooltipNotification</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemTooltipNotification</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemTooltipNotification left, DestinyDefinitionsDestinyItemTooltipNotification right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemTooltipNotification.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemTooltipNotificationBuilder
        {
            private string _DisplayString;
            private string _DisplayStyle;

            internal DestinyDefinitionsDestinyItemTooltipNotificationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTooltipNotification.DisplayString property.
            /// </summary>
            /// <param name="value">DisplayString</param>
            public DestinyDefinitionsDestinyItemTooltipNotificationBuilder DisplayString(string value)
            {
                _DisplayString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTooltipNotification.DisplayStyle property.
            /// </summary>
            /// <param name="value">DisplayStyle</param>
            public DestinyDefinitionsDestinyItemTooltipNotificationBuilder DisplayStyle(string value)
            {
                _DisplayStyle = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemTooltipNotification.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemTooltipNotification</returns>
            public DestinyDefinitionsDestinyItemTooltipNotification Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemTooltipNotification(
                    DisplayString: _DisplayString,
                    DisplayStyle: _DisplayStyle
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}