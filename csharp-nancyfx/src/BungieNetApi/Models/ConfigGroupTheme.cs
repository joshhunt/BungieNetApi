using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ConfigGroupTheme
    /// </summary>
    public sealed class ConfigGroupTheme:  IEquatable<ConfigGroupTheme>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Folder
        /// </summary>
        public string Folder { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ConfigGroupTheme.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ConfigGroupTheme()
        {
        }

        private ConfigGroupTheme(string Name, string Folder, string Description)
        {
            
            this.Name = Name;
            
            this.Folder = Folder;
            
            this.Description = Description;
            
        }

        /// <summary>
        /// Returns builder of ConfigGroupTheme.
        /// </summary>
        /// <returns>ConfigGroupThemeBuilder</returns>
        public static ConfigGroupThemeBuilder Builder()
        {
            return new ConfigGroupThemeBuilder();
        }

        /// <summary>
        /// Returns ConfigGroupThemeBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ConfigGroupThemeBuilder</returns>
        public ConfigGroupThemeBuilder With()
        {
            return Builder()
                .Name(Name)
                .Folder(Folder)
                .Description(Description);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ConfigGroupTheme other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ConfigGroupTheme.
        /// </summary>
        /// <param name="left">Compared (ConfigGroupTheme</param>
        /// <param name="right">Compared (ConfigGroupTheme</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ConfigGroupTheme left, ConfigGroupTheme right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ConfigGroupTheme.
        /// </summary>
        /// <param name="left">Compared (ConfigGroupTheme</param>
        /// <param name="right">Compared (ConfigGroupTheme</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ConfigGroupTheme left, ConfigGroupTheme right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ConfigGroupTheme.
        /// </summary>
        public sealed class ConfigGroupThemeBuilder
        {
            private string _Name;
            private string _Folder;
            private string _Description;

            internal ConfigGroupThemeBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ConfigGroupTheme.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ConfigGroupThemeBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ConfigGroupTheme.Folder property.
            /// </summary>
            /// <param name="value">Folder</param>
            public ConfigGroupThemeBuilder Folder(string value)
            {
                _Folder = value;
                return this;
            }

            /// <summary>
            /// Sets value for ConfigGroupTheme.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public ConfigGroupThemeBuilder Description(string value)
            {
                _Description = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ConfigGroupTheme.
            /// </summary>
            /// <returns>ConfigGroupTheme</returns>
            public ConfigGroupTheme Build()
            {
                Validate();
                return new ConfigGroupTheme(
                    Name: _Name,
                    Folder: _Folder,
                    Description: _Description
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}