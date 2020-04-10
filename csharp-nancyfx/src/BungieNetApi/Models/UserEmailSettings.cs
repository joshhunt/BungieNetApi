using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The set of all email subscription/opt-in settings and definitions.
    /// </summary>
    public sealed class UserEmailSettings:  IEquatable<UserEmailSettings>
    { 
        /// <summary>
        /// Keyed by the name identifier of the opt-in definition.
        /// </summary>
        public Dictionary<string, UserEmailOptInDefinition> OptInDefinitions { get; private set; }

        /// <summary>
        /// Keyed by the name identifier of the Subscription definition.
        /// </summary>
        public Dictionary<string, UserEmailSubscriptionDefinition> SubscriptionDefinitions { get; private set; }

        /// <summary>
        /// Keyed by the name identifier of the View definition.
        /// </summary>
        public Dictionary<string, UserEmailViewDefinition> Views { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserEmailSettings.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEmailSettings()
        {
        }

        private UserEmailSettings(Dictionary<string, UserEmailOptInDefinition> OptInDefinitions, Dictionary<string, UserEmailSubscriptionDefinition> SubscriptionDefinitions, Dictionary<string, UserEmailViewDefinition> Views)
        {
            
            this.OptInDefinitions = OptInDefinitions;
            
            this.SubscriptionDefinitions = SubscriptionDefinitions;
            
            this.Views = Views;
            
        }

        /// <summary>
        /// Returns builder of UserEmailSettings.
        /// </summary>
        /// <returns>UserEmailSettingsBuilder</returns>
        public static UserEmailSettingsBuilder Builder()
        {
            return new UserEmailSettingsBuilder();
        }

        /// <summary>
        /// Returns UserEmailSettingsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEmailSettingsBuilder</returns>
        public UserEmailSettingsBuilder With()
        {
            return Builder()
                .OptInDefinitions(OptInDefinitions)
                .SubscriptionDefinitions(SubscriptionDefinitions)
                .Views(Views);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserEmailSettings other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEmailSettings.
        /// </summary>
        /// <param name="left">Compared (UserEmailSettings</param>
        /// <param name="right">Compared (UserEmailSettings</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEmailSettings left, UserEmailSettings right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEmailSettings.
        /// </summary>
        /// <param name="left">Compared (UserEmailSettings</param>
        /// <param name="right">Compared (UserEmailSettings</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEmailSettings left, UserEmailSettings right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEmailSettings.
        /// </summary>
        public sealed class UserEmailSettingsBuilder
        {
            private Dictionary<string, UserEmailOptInDefinition> _OptInDefinitions;
            private Dictionary<string, UserEmailSubscriptionDefinition> _SubscriptionDefinitions;
            private Dictionary<string, UserEmailViewDefinition> _Views;

            internal UserEmailSettingsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEmailSettings.OptInDefinitions property.
            /// </summary>
            /// <param name="value">Keyed by the name identifier of the opt-in definition.</param>
            public UserEmailSettingsBuilder OptInDefinitions(Dictionary<string, UserEmailOptInDefinition> value)
            {
                _OptInDefinitions = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailSettings.SubscriptionDefinitions property.
            /// </summary>
            /// <param name="value">Keyed by the name identifier of the Subscription definition.</param>
            public UserEmailSettingsBuilder SubscriptionDefinitions(Dictionary<string, UserEmailSubscriptionDefinition> value)
            {
                _SubscriptionDefinitions = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailSettings.Views property.
            /// </summary>
            /// <param name="value">Keyed by the name identifier of the View definition.</param>
            public UserEmailSettingsBuilder Views(Dictionary<string, UserEmailViewDefinition> value)
            {
                _Views = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEmailSettings.
            /// </summary>
            /// <returns>UserEmailSettings</returns>
            public UserEmailSettings Build()
            {
                Validate();
                return new UserEmailSettings(
                    OptInDefinitions: _OptInDefinitions,
                    SubscriptionDefinitions: _SubscriptionDefinitions,
                    Views: _Views
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}