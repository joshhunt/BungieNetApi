using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a single subscription: permission to send emails for a specific, focused subject (generally timeboxed, such as for a specific release of a product or feature).
    /// </summary>
    public sealed class UserEmailSubscriptionDefinition:  IEquatable<UserEmailSubscriptionDefinition>
    { 
        /// <summary>
        /// The unique identifier for this subscription.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.
        /// </summary>
        public Dictionary<string, UserEMailSettingSubscriptionLocalization> Localization { get; private set; }

        /// <summary>
        /// The bitflag value for this subscription. Should be a unique power of two value.
        /// </summary>
        public long? Value { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserEmailSubscriptionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEmailSubscriptionDefinition()
        {
        }

        private UserEmailSubscriptionDefinition(string Name, Dictionary<string, UserEMailSettingSubscriptionLocalization> Localization, long? Value)
        {
            
            this.Name = Name;
            
            this.Localization = Localization;
            
            this.Value = Value;
            
        }

        /// <summary>
        /// Returns builder of UserEmailSubscriptionDefinition.
        /// </summary>
        /// <returns>UserEmailSubscriptionDefinitionBuilder</returns>
        public static UserEmailSubscriptionDefinitionBuilder Builder()
        {
            return new UserEmailSubscriptionDefinitionBuilder();
        }

        /// <summary>
        /// Returns UserEmailSubscriptionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEmailSubscriptionDefinitionBuilder</returns>
        public UserEmailSubscriptionDefinitionBuilder With()
        {
            return Builder()
                .Name(Name)
                .Localization(Localization)
                .Value(Value);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserEmailSubscriptionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEmailSubscriptionDefinition.
        /// </summary>
        /// <param name="left">Compared (UserEmailSubscriptionDefinition</param>
        /// <param name="right">Compared (UserEmailSubscriptionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEmailSubscriptionDefinition left, UserEmailSubscriptionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEmailSubscriptionDefinition.
        /// </summary>
        /// <param name="left">Compared (UserEmailSubscriptionDefinition</param>
        /// <param name="right">Compared (UserEmailSubscriptionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEmailSubscriptionDefinition left, UserEmailSubscriptionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEmailSubscriptionDefinition.
        /// </summary>
        public sealed class UserEmailSubscriptionDefinitionBuilder
        {
            private string _Name;
            private Dictionary<string, UserEMailSettingSubscriptionLocalization> _Localization;
            private long? _Value;

            internal UserEmailSubscriptionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEmailSubscriptionDefinition.Name property.
            /// </summary>
            /// <param name="value">The unique identifier for this subscription.</param>
            public UserEmailSubscriptionDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailSubscriptionDefinition.Localization property.
            /// </summary>
            /// <param name="value">A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.</param>
            public UserEmailSubscriptionDefinitionBuilder Localization(Dictionary<string, UserEMailSettingSubscriptionLocalization> value)
            {
                _Localization = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailSubscriptionDefinition.Value property.
            /// </summary>
            /// <param name="value">The bitflag value for this subscription. Should be a unique power of two value.</param>
            public UserEmailSubscriptionDefinitionBuilder Value(long? value)
            {
                _Value = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEmailSubscriptionDefinition.
            /// </summary>
            /// <returns>UserEmailSubscriptionDefinition</returns>
            public UserEmailSubscriptionDefinition Build()
            {
                Validate();
                return new UserEmailSubscriptionDefinition(
                    Name: _Name,
                    Localization: _Localization,
                    Value: _Value
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}