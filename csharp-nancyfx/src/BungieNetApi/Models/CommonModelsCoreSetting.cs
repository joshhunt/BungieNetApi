using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// CommonModelsCoreSetting
    /// </summary>
    public sealed class CommonModelsCoreSetting:  IEquatable<CommonModelsCoreSetting>
    { 
        /// <summary>
        /// Identifier
        /// </summary>
        public string Identifier { get; private set; }

        /// <summary>
        /// IsDefault
        /// </summary>
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// DisplayName
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; private set; }

        /// <summary>
        /// ImagePath
        /// </summary>
        public string ImagePath { get; private set; }

        /// <summary>
        /// ChildSettings
        /// </summary>
        public List<CommonModelsCoreSetting> ChildSettings { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use CommonModelsCoreSetting.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public CommonModelsCoreSetting()
        {
        }

        private CommonModelsCoreSetting(string Identifier, bool? IsDefault, string DisplayName, string Summary, string ImagePath, List<CommonModelsCoreSetting> ChildSettings)
        {
            
            this.Identifier = Identifier;
            
            this.IsDefault = IsDefault;
            
            this.DisplayName = DisplayName;
            
            this.Summary = Summary;
            
            this.ImagePath = ImagePath;
            
            this.ChildSettings = ChildSettings;
            
        }

        /// <summary>
        /// Returns builder of CommonModelsCoreSetting.
        /// </summary>
        /// <returns>CommonModelsCoreSettingBuilder</returns>
        public static CommonModelsCoreSettingBuilder Builder()
        {
            return new CommonModelsCoreSettingBuilder();
        }

        /// <summary>
        /// Returns CommonModelsCoreSettingBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>CommonModelsCoreSettingBuilder</returns>
        public CommonModelsCoreSettingBuilder With()
        {
            return Builder()
                .Identifier(Identifier)
                .IsDefault(IsDefault)
                .DisplayName(DisplayName)
                .Summary(Summary)
                .ImagePath(ImagePath)
                .ChildSettings(ChildSettings);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(CommonModelsCoreSetting other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (CommonModelsCoreSetting.
        /// </summary>
        /// <param name="left">Compared (CommonModelsCoreSetting</param>
        /// <param name="right">Compared (CommonModelsCoreSetting</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (CommonModelsCoreSetting left, CommonModelsCoreSetting right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (CommonModelsCoreSetting.
        /// </summary>
        /// <param name="left">Compared (CommonModelsCoreSetting</param>
        /// <param name="right">Compared (CommonModelsCoreSetting</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (CommonModelsCoreSetting left, CommonModelsCoreSetting right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of CommonModelsCoreSetting.
        /// </summary>
        public sealed class CommonModelsCoreSettingBuilder
        {
            private string _Identifier;
            private bool? _IsDefault;
            private string _DisplayName;
            private string _Summary;
            private string _ImagePath;
            private List<CommonModelsCoreSetting> _ChildSettings;

            internal CommonModelsCoreSettingBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSetting.Identifier property.
            /// </summary>
            /// <param name="value">Identifier</param>
            public CommonModelsCoreSettingBuilder Identifier(string value)
            {
                _Identifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSetting.IsDefault property.
            /// </summary>
            /// <param name="value">IsDefault</param>
            public CommonModelsCoreSettingBuilder IsDefault(bool? value)
            {
                _IsDefault = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSetting.DisplayName property.
            /// </summary>
            /// <param name="value">DisplayName</param>
            public CommonModelsCoreSettingBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSetting.Summary property.
            /// </summary>
            /// <param name="value">Summary</param>
            public CommonModelsCoreSettingBuilder Summary(string value)
            {
                _Summary = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSetting.ImagePath property.
            /// </summary>
            /// <param name="value">ImagePath</param>
            public CommonModelsCoreSettingBuilder ImagePath(string value)
            {
                _ImagePath = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSetting.ChildSettings property.
            /// </summary>
            /// <param name="value">ChildSettings</param>
            public CommonModelsCoreSettingBuilder ChildSettings(List<CommonModelsCoreSetting> value)
            {
                _ChildSettings = value;
                return this;
            }


            /// <summary>
            /// Builds instance of CommonModelsCoreSetting.
            /// </summary>
            /// <returns>CommonModelsCoreSetting</returns>
            public CommonModelsCoreSetting Build()
            {
                Validate();
                return new CommonModelsCoreSetting(
                    Identifier: _Identifier,
                    IsDefault: _IsDefault,
                    DisplayName: _DisplayName,
                    Summary: _Summary,
                    ImagePath: _ImagePath,
                    ChildSettings: _ChildSettings
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}