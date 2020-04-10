using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// UserEmailViewDefinitionSetting
    /// </summary>
    public sealed class UserEmailViewDefinitionSetting:  IEquatable<UserEmailViewDefinitionSetting>
    { 
        /// <summary>
        /// The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// A dictionary of localized text for the EMail setting, keyed by the locale.
        /// </summary>
        public Dictionary<string, UserEMailSettingLocalization> Localization { get; private set; }

        /// <summary>
        /// If true, this setting should be set by default if the user hasn&#39;t chosen whether it&#39;s set or cleared yet.
        /// </summary>
        public bool? SetByDefault { get; private set; }

        /// <summary>
        /// The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.
        /// </summary>
        public long? OptInAggregateValue { get; private set; }

        /// <summary>
        /// The subscriptions to show as children of this setting, if any.
        /// </summary>
        public List<UserEmailSubscriptionDefinition> Subscriptions { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserEmailViewDefinitionSetting.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEmailViewDefinitionSetting()
        {
        }

        private UserEmailViewDefinitionSetting(string Name, Dictionary<string, UserEMailSettingLocalization> Localization, bool? SetByDefault, long? OptInAggregateValue, List<UserEmailSubscriptionDefinition> Subscriptions)
        {
            
            this.Name = Name;
            
            this.Localization = Localization;
            
            this.SetByDefault = SetByDefault;
            
            this.OptInAggregateValue = OptInAggregateValue;
            
            this.Subscriptions = Subscriptions;
            
        }

        /// <summary>
        /// Returns builder of UserEmailViewDefinitionSetting.
        /// </summary>
        /// <returns>UserEmailViewDefinitionSettingBuilder</returns>
        public static UserEmailViewDefinitionSettingBuilder Builder()
        {
            return new UserEmailViewDefinitionSettingBuilder();
        }

        /// <summary>
        /// Returns UserEmailViewDefinitionSettingBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEmailViewDefinitionSettingBuilder</returns>
        public UserEmailViewDefinitionSettingBuilder With()
        {
            return Builder()
                .Name(Name)
                .Localization(Localization)
                .SetByDefault(SetByDefault)
                .OptInAggregateValue(OptInAggregateValue)
                .Subscriptions(Subscriptions);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserEmailViewDefinitionSetting other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEmailViewDefinitionSetting.
        /// </summary>
        /// <param name="left">Compared (UserEmailViewDefinitionSetting</param>
        /// <param name="right">Compared (UserEmailViewDefinitionSetting</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEmailViewDefinitionSetting left, UserEmailViewDefinitionSetting right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEmailViewDefinitionSetting.
        /// </summary>
        /// <param name="left">Compared (UserEmailViewDefinitionSetting</param>
        /// <param name="right">Compared (UserEmailViewDefinitionSetting</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEmailViewDefinitionSetting left, UserEmailViewDefinitionSetting right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEmailViewDefinitionSetting.
        /// </summary>
        public sealed class UserEmailViewDefinitionSettingBuilder
        {
            private string _Name;
            private Dictionary<string, UserEMailSettingLocalization> _Localization;
            private bool? _SetByDefault;
            private long? _OptInAggregateValue;
            private List<UserEmailSubscriptionDefinition> _Subscriptions;

            internal UserEmailViewDefinitionSettingBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinitionSetting.Name property.
            /// </summary>
            /// <param name="value">The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.</param>
            public UserEmailViewDefinitionSettingBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinitionSetting.Localization property.
            /// </summary>
            /// <param name="value">A dictionary of localized text for the EMail setting, keyed by the locale.</param>
            public UserEmailViewDefinitionSettingBuilder Localization(Dictionary<string, UserEMailSettingLocalization> value)
            {
                _Localization = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinitionSetting.SetByDefault property.
            /// </summary>
            /// <param name="value">If true, this setting should be set by default if the user hasn&#39;t chosen whether it&#39;s set or cleared yet.</param>
            public UserEmailViewDefinitionSettingBuilder SetByDefault(bool? value)
            {
                _SetByDefault = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinitionSetting.OptInAggregateValue property.
            /// </summary>
            /// <param name="value">The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.</param>
            public UserEmailViewDefinitionSettingBuilder OptInAggregateValue(long? value)
            {
                _OptInAggregateValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinitionSetting.Subscriptions property.
            /// </summary>
            /// <param name="value">The subscriptions to show as children of this setting, if any.</param>
            public UserEmailViewDefinitionSettingBuilder Subscriptions(List<UserEmailSubscriptionDefinition> value)
            {
                _Subscriptions = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEmailViewDefinitionSetting.
            /// </summary>
            /// <returns>UserEmailViewDefinitionSetting</returns>
            public UserEmailViewDefinitionSetting Build()
            {
                Validate();
                return new UserEmailViewDefinitionSetting(
                    Name: _Name,
                    Localization: _Localization,
                    SetByDefault: _SetByDefault,
                    OptInAggregateValue: _OptInAggregateValue,
                    Subscriptions: _Subscriptions
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}