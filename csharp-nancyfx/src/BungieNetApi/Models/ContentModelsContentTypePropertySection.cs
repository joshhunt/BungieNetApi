using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsContentTypePropertySection
    /// </summary>
    public sealed class ContentModelsContentTypePropertySection:  IEquatable<ContentModelsContentTypePropertySection>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// ReadableName
        /// </summary>
        public string ReadableName { get; private set; }

        /// <summary>
        /// Collapsed
        /// </summary>
        public bool? Collapsed { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsContentTypePropertySection.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsContentTypePropertySection()
        {
        }

        private ContentModelsContentTypePropertySection(string Name, string ReadableName, bool? Collapsed)
        {
            
            this.Name = Name;
            
            this.ReadableName = ReadableName;
            
            this.Collapsed = Collapsed;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsContentTypePropertySection.
        /// </summary>
        /// <returns>ContentModelsContentTypePropertySectionBuilder</returns>
        public static ContentModelsContentTypePropertySectionBuilder Builder()
        {
            return new ContentModelsContentTypePropertySectionBuilder();
        }

        /// <summary>
        /// Returns ContentModelsContentTypePropertySectionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsContentTypePropertySectionBuilder</returns>
        public ContentModelsContentTypePropertySectionBuilder With()
        {
            return Builder()
                .Name(Name)
                .ReadableName(ReadableName)
                .Collapsed(Collapsed);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsContentTypePropertySection other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsContentTypePropertySection.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypePropertySection</param>
        /// <param name="right">Compared (ContentModelsContentTypePropertySection</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsContentTypePropertySection left, ContentModelsContentTypePropertySection right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsContentTypePropertySection.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypePropertySection</param>
        /// <param name="right">Compared (ContentModelsContentTypePropertySection</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsContentTypePropertySection left, ContentModelsContentTypePropertySection right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsContentTypePropertySection.
        /// </summary>
        public sealed class ContentModelsContentTypePropertySectionBuilder
        {
            private string _Name;
            private string _ReadableName;
            private bool? _Collapsed;

            internal ContentModelsContentTypePropertySectionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypePropertySection.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentModelsContentTypePropertySectionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypePropertySection.ReadableName property.
            /// </summary>
            /// <param name="value">ReadableName</param>
            public ContentModelsContentTypePropertySectionBuilder ReadableName(string value)
            {
                _ReadableName = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypePropertySection.Collapsed property.
            /// </summary>
            /// <param name="value">Collapsed</param>
            public ContentModelsContentTypePropertySectionBuilder Collapsed(bool? value)
            {
                _Collapsed = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsContentTypePropertySection.
            /// </summary>
            /// <returns>ContentModelsContentTypePropertySection</returns>
            public ContentModelsContentTypePropertySection Build()
            {
                Validate();
                return new ContentModelsContentTypePropertySection(
                    Name: _Name,
                    ReadableName: _ReadableName,
                    Collapsed: _Collapsed
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}