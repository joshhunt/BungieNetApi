using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Localized text relevant to a given EMail setting in a given localization. Extra settings specifically for subscriptions.
    /// </summary>
    public sealed class UserEMailSettingSubscriptionLocalization:  IEquatable<UserEMailSettingSubscriptionLocalization>
    { 
        /// <summary>
        /// UnknownUserDescription
        /// </summary>
        public string UnknownUserDescription { get; private set; }

        /// <summary>
        /// RegisteredUserDescription
        /// </summary>
        public string RegisteredUserDescription { get; private set; }

        /// <summary>
        /// UnregisteredUserDescription
        /// </summary>
        public string UnregisteredUserDescription { get; private set; }

        /// <summary>
        /// UnknownUserActionText
        /// </summary>
        public string UnknownUserActionText { get; private set; }

        /// <summary>
        /// KnownUserActionText
        /// </summary>
        public string KnownUserActionText { get; private set; }

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
        /// Use UserEMailSettingSubscriptionLocalization.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserEMailSettingSubscriptionLocalization()
        {
        }

        private UserEMailSettingSubscriptionLocalization(string UnknownUserDescription, string RegisteredUserDescription, string UnregisteredUserDescription, string UnknownUserActionText, string KnownUserActionText, string Title, string Description)
        {
            
            this.UnknownUserDescription = UnknownUserDescription;
            
            this.RegisteredUserDescription = RegisteredUserDescription;
            
            this.UnregisteredUserDescription = UnregisteredUserDescription;
            
            this.UnknownUserActionText = UnknownUserActionText;
            
            this.KnownUserActionText = KnownUserActionText;
            
            this.Title = Title;
            
            this.Description = Description;
            
        }

        /// <summary>
        /// Returns builder of UserEMailSettingSubscriptionLocalization.
        /// </summary>
        /// <returns>UserEMailSettingSubscriptionLocalizationBuilder</returns>
        public static UserEMailSettingSubscriptionLocalizationBuilder Builder()
        {
            return new UserEMailSettingSubscriptionLocalizationBuilder();
        }

        /// <summary>
        /// Returns UserEMailSettingSubscriptionLocalizationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserEMailSettingSubscriptionLocalizationBuilder</returns>
        public UserEMailSettingSubscriptionLocalizationBuilder With()
        {
            return Builder()
                .UnknownUserDescription(UnknownUserDescription)
                .RegisteredUserDescription(RegisteredUserDescription)
                .UnregisteredUserDescription(UnregisteredUserDescription)
                .UnknownUserActionText(UnknownUserActionText)
                .KnownUserActionText(KnownUserActionText)
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

        public bool Equals(UserEMailSettingSubscriptionLocalization other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserEMailSettingSubscriptionLocalization.
        /// </summary>
        /// <param name="left">Compared (UserEMailSettingSubscriptionLocalization</param>
        /// <param name="right">Compared (UserEMailSettingSubscriptionLocalization</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserEMailSettingSubscriptionLocalization left, UserEMailSettingSubscriptionLocalization right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserEMailSettingSubscriptionLocalization.
        /// </summary>
        /// <param name="left">Compared (UserEMailSettingSubscriptionLocalization</param>
        /// <param name="right">Compared (UserEMailSettingSubscriptionLocalization</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserEMailSettingSubscriptionLocalization left, UserEMailSettingSubscriptionLocalization right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserEMailSettingSubscriptionLocalization.
        /// </summary>
        public sealed class UserEMailSettingSubscriptionLocalizationBuilder
        {
            private string _UnknownUserDescription;
            private string _RegisteredUserDescription;
            private string _UnregisteredUserDescription;
            private string _UnknownUserActionText;
            private string _KnownUserActionText;
            private string _Title;
            private string _Description;

            internal UserEMailSettingSubscriptionLocalizationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.UnknownUserDescription property.
            /// </summary>
            /// <param name="value">UnknownUserDescription</param>
            public UserEMailSettingSubscriptionLocalizationBuilder UnknownUserDescription(string value)
            {
                _UnknownUserDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.RegisteredUserDescription property.
            /// </summary>
            /// <param name="value">RegisteredUserDescription</param>
            public UserEMailSettingSubscriptionLocalizationBuilder RegisteredUserDescription(string value)
            {
                _RegisteredUserDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.UnregisteredUserDescription property.
            /// </summary>
            /// <param name="value">UnregisteredUserDescription</param>
            public UserEMailSettingSubscriptionLocalizationBuilder UnregisteredUserDescription(string value)
            {
                _UnregisteredUserDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.UnknownUserActionText property.
            /// </summary>
            /// <param name="value">UnknownUserActionText</param>
            public UserEMailSettingSubscriptionLocalizationBuilder UnknownUserActionText(string value)
            {
                _UnknownUserActionText = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.KnownUserActionText property.
            /// </summary>
            /// <param name="value">KnownUserActionText</param>
            public UserEMailSettingSubscriptionLocalizationBuilder KnownUserActionText(string value)
            {
                _KnownUserActionText = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public UserEMailSettingSubscriptionLocalizationBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserEMailSettingSubscriptionLocalization.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public UserEMailSettingSubscriptionLocalizationBuilder Description(string value)
            {
                _Description = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserEMailSettingSubscriptionLocalization.
            /// </summary>
            /// <returns>UserEMailSettingSubscriptionLocalization</returns>
            public UserEMailSettingSubscriptionLocalization Build()
            {
                Validate();
                return new UserEMailSettingSubscriptionLocalization(
                    UnknownUserDescription: _UnknownUserDescription,
                    RegisteredUserDescription: _RegisteredUserDescription,
                    UnregisteredUserDescription: _UnregisteredUserDescription,
                    UnknownUserActionText: _UnknownUserActionText,
                    KnownUserActionText: _KnownUserActionText,
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