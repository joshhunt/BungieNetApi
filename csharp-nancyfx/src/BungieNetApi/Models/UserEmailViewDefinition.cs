using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a data-driven view for Email settings. Web/Mobile UI can use this data to show new EMail settings consistently without further manual work.
    /// </summary>
    public sealed class UserEmailViewDefinition:  IEquatable<UserEmailViewDefinition>
    { 
        /// <summary>
        /// The identifier for this view.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The ordered list of settings to show in this view.
        /// </summary>
        public List<UserEmailViewDefinitionSetting> ViewSettings { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserEmailViewDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEmailViewDefinition()
        {
        }

        private UserEmailViewDefinition(string Name, List<UserEmailViewDefinitionSetting> ViewSettings)
        {
            
            this.Name = Name;
            
            this.ViewSettings = ViewSettings;
            
        }

        /// <summary>
        /// Returns builder of UserEmailViewDefinition.
        /// </summary>
        /// <returns>UserEmailViewDefinitionBuilder</returns>
        public static UserEmailViewDefinitionBuilder Builder()
        {
            return new UserEmailViewDefinitionBuilder();
        }

        /// <summary>
        /// Returns UserEmailViewDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEmailViewDefinitionBuilder</returns>
        public UserEmailViewDefinitionBuilder With()
        {
            return Builder()
                .Name(Name)
                .ViewSettings(ViewSettings);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserEmailViewDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEmailViewDefinition.
        /// </summary>
        /// <param name="left">Compared (UserEmailViewDefinition</param>
        /// <param name="right">Compared (UserEmailViewDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEmailViewDefinition left, UserEmailViewDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEmailViewDefinition.
        /// </summary>
        /// <param name="left">Compared (UserEmailViewDefinition</param>
        /// <param name="right">Compared (UserEmailViewDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEmailViewDefinition left, UserEmailViewDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEmailViewDefinition.
        /// </summary>
        public sealed class UserEmailViewDefinitionBuilder
        {
            private string _Name;
            private List<UserEmailViewDefinitionSetting> _ViewSettings;

            internal UserEmailViewDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinition.Name property.
            /// </summary>
            /// <param name="value">The identifier for this view.</param>
            public UserEmailViewDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEmailViewDefinition.ViewSettings property.
            /// </summary>
            /// <param name="value">The ordered list of settings to show in this view.</param>
            public UserEmailViewDefinitionBuilder ViewSettings(List<UserEmailViewDefinitionSetting> value)
            {
                _ViewSettings = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEmailViewDefinition.
            /// </summary>
            /// <returns>UserEmailViewDefinition</returns>
            public UserEmailViewDefinition Build()
            {
                Validate();
                return new UserEmailViewDefinition(
                    Name: _Name,
                    ViewSettings: _ViewSettings
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}