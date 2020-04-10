using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Localized text relevant to a given EMail setting in a given localization.
    /// </summary>
    public sealed class UserEMailSettingLocalization:  IEquatable<UserEMailSettingLocalization>
    { 
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserEMailSettingLocalization.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEMailSettingLocalization()
        {
        }

        private UserEMailSettingLocalization(string Title, string Description)
        {
            
            this.Title = Title;
            
            this.Description = Description;
            
        }

        /// <summary>
        /// Returns builder of UserEMailSettingLocalization.
        /// </summary>
        /// <returns>UserEMailSettingLocalizationBuilder</returns>
        public static UserEMailSettingLocalizationBuilder Builder()
        {
            return new UserEMailSettingLocalizationBuilder();
        }

        /// <summary>
        /// Returns UserEMailSettingLocalizationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEMailSettingLocalizationBuilder</returns>
        public UserEMailSettingLocalizationBuilder With()
        {
            return Builder()
                .Title(Title)
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

        public bool Equals(UserEMailSettingLocalization other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEMailSettingLocalization.
        /// </summary>
        /// <param name="left">Compared (UserEMailSettingLocalization</param>
        /// <param name="right">Compared (UserEMailSettingLocalization</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEMailSettingLocalization left, UserEMailSettingLocalization right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEMailSettingLocalization.
        /// </summary>
        /// <param name="left">Compared (UserEMailSettingLocalization</param>
        /// <param name="right">Compared (UserEMailSettingLocalization</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEMailSettingLocalization left, UserEMailSettingLocalization right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEMailSettingLocalization.
        /// </summary>
        public sealed class UserEMailSettingLocalizationBuilder
        {
            private string _Title;
            private string _Description;

            internal UserEMailSettingLocalizationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEMailSettingLocalization.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public UserEMailSettingLocalizationBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingLocalization.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public UserEMailSettingLocalizationBuilder Description(string value)
            {
                _Description = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEMailSettingLocalization.
            /// </summary>
            /// <returns>UserEMailSettingLocalization</returns>
            public UserEMailSettingLocalization Build()
            {
                Validate();
                return new UserEMailSettingLocalization(
                    Title: _Title,
                    Description: _Description
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}