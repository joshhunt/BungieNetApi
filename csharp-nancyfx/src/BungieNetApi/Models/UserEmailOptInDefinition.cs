using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a single opt-in category: a wide-scoped permission to send emails for the subject related to the opt-in.
    /// </summary>
    public sealed class UserEmailOptInDefinition:  IEquatable<UserEmailOptInDefinition>
    { 
        /// <summary>
        /// The unique identifier for this opt-in category.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.
        /// </summary>
        public long? Value { get; private set; }

        /// <summary>
        /// If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they&#39;re opting into.
        /// </summary>
        public bool? SetByDefault { get; private set; }

        /// <summary>
        /// Information about the dependent subscriptions for this opt-in.
        /// </summary>
        public List<UserEmailSubscriptionDefinition> DependentSubscriptions { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserEmailOptInDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEmailOptInDefinition()
        {
        }

        private UserEmailOptInDefinition(string Name, long? Value, bool? SetByDefault, List<UserEmailSubscriptionDefinition> DependentSubscriptions)
        {
            
            this.Name = Name;
            
            this.Value = Value;
            
            this.SetByDefault = SetByDefault;
            
            this.DependentSubscriptions = DependentSubscriptions;
            
        }

        /// <summary>
        /// Returns builder of UserEmailOptInDefinition.
        /// </summary>
        /// <returns>UserEmailOptInDefinitionBuilder</returns>
        public static UserEmailOptInDefinitionBuilder Builder()
        {
            return new UserEmailOptInDefinitionBuilder();
        }

        /// <summary>
        /// Returns UserEmailOptInDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEmailOptInDefinitionBuilder</returns>
        public UserEmailOptInDefinitionBuilder With()
        {
            return Builder()
                .Name(Name)
                .Value(Value)
                .SetByDefault(SetByDefault)
                .DependentSubscriptions(DependentSubscriptions);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserEmailOptInDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEmailOptInDefinition.
        /// </summary>
        /// <param name="left">Compared (UserEmailOptInDefinition</param>
        /// <param name="right">Compared (UserEmailOptInDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEmailOptInDefinition left, UserEmailOptInDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEmailOptInDefinition.
        /// </summary>
        /// <param name="left">Compared (UserEmailOptInDefinition</param>
        /// <param name="right">Compared (UserEmailOptInDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEmailOptInDefinition left, UserEmailOptInDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEmailOptInDefinition.
        /// </summary>
        public sealed class UserEmailOptInDefinitionBuilder
        {
            private string _Name;
            private long? _Value;
            private bool? _SetByDefault;
            private List<UserEmailSubscriptionDefinition> _DependentSubscriptions;

            internal UserEmailOptInDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEmailOptInDefinition.Name property.
            /// </summary>
            /// <param name="value">The unique identifier for this opt-in category.</param>
            public UserEmailOptInDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailOptInDefinition.Value property.
            /// </summary>
            /// <param name="value">The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.</param>
            public UserEmailOptInDefinitionBuilder Value(long? value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailOptInDefinition.SetByDefault property.
            /// </summary>
            /// <param name="value">If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they&#39;re opting into.</param>
            public UserEmailOptInDefinitionBuilder SetByDefault(bool? value)
            {
                _SetByDefault = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailOptInDefinition.DependentSubscriptions property.
            /// </summary>
            /// <param name="value">Information about the dependent subscriptions for this opt-in.</param>
            public UserEmailOptInDefinitionBuilder DependentSubscriptions(List<UserEmailSubscriptionDefinition> value)
            {
                _DependentSubscriptions = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEmailOptInDefinition.
            /// </summary>
            /// <returns>UserEmailOptInDefinition</returns>
            public UserEmailOptInDefinition Build()
            {
                Validate();
                return new UserEmailOptInDefinition(
                    Name: _Name,
                    Value: _Value,
                    SetByDefault: _SetByDefault,
                    DependentSubscriptions: _DependentSubscriptions
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}