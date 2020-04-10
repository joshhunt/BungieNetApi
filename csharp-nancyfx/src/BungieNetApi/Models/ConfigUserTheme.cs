using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ConfigUserTheme
    /// </summary>
    public sealed class ConfigUserTheme:  IEquatable<ConfigUserTheme>
    { 
        /// <summary>
        /// UserThemeId
        /// </summary>
        public int? UserThemeId { get; private set; }

        /// <summary>
        /// UserThemeName
        /// </summary>
        public string UserThemeName { get; private set; }

        /// <summary>
        /// UserThemeDescription
        /// </summary>
        public string UserThemeDescription { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ConfigUserTheme.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ConfigUserTheme()
        {
        }

        private ConfigUserTheme(int? UserThemeId, string UserThemeName, string UserThemeDescription)
        {
            
            this.UserThemeId = UserThemeId;
            
            this.UserThemeName = UserThemeName;
            
            this.UserThemeDescription = UserThemeDescription;
            
        }

        /// <summary>
        /// Returns builder of ConfigUserTheme.
        /// </summary>
        /// <returns>ConfigUserThemeBuilder</returns>
        public static ConfigUserThemeBuilder Builder()
        {
            return new ConfigUserThemeBuilder();
        }

        /// <summary>
        /// Returns ConfigUserThemeBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ConfigUserThemeBuilder</returns>
        public ConfigUserThemeBuilder With()
        {
            return Builder()
                .UserThemeId(UserThemeId)
                .UserThemeName(UserThemeName)
                .UserThemeDescription(UserThemeDescription);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ConfigUserTheme other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ConfigUserTheme.
        /// </summary>
        /// <param name="left">Compared (ConfigUserTheme</param>
        /// <param name="right">Compared (ConfigUserTheme</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ConfigUserTheme left, ConfigUserTheme right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ConfigUserTheme.
        /// </summary>
        /// <param name="left">Compared (ConfigUserTheme</param>
        /// <param name="right">Compared (ConfigUserTheme</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ConfigUserTheme left, ConfigUserTheme right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ConfigUserTheme.
        /// </summary>
        public sealed class ConfigUserThemeBuilder
        {
            private int? _UserThemeId;
            private string _UserThemeName;
            private string _UserThemeDescription;

            internal ConfigUserThemeBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ConfigUserTheme.UserThemeId property.
            /// </summary>
            /// <param name="value">UserThemeId</param>
            public ConfigUserThemeBuilder UserThemeId(int? value)
            {
                _UserThemeId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ConfigUserTheme.UserThemeName property.
            /// </summary>
            /// <param name="value">UserThemeName</param>
            public ConfigUserThemeBuilder UserThemeName(string value)
            {
                _UserThemeName = value;
                return this;
            }

            /// <summary>
            /// Sets value for ConfigUserTheme.UserThemeDescription property.
            /// </summary>
            /// <param name="value">UserThemeDescription</param>
            public ConfigUserThemeBuilder UserThemeDescription(string value)
            {
                _UserThemeDescription = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ConfigUserTheme.
            /// </summary>
            /// <returns>ConfigUserTheme</returns>
            public ConfigUserTheme Build()
            {
                Validate();
                return new ConfigUserTheme(
                    UserThemeId: _UserThemeId,
                    UserThemeName: _UserThemeName,
                    UserThemeDescription: _UserThemeDescription
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}