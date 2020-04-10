using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsTagMetadataItem
    /// </summary>
    public sealed class ContentModelsTagMetadataItem:  IEquatable<ContentModelsTagMetadataItem>
    { 
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// TagText
        /// </summary>
        public string TagText { get; private set; }

        /// <summary>
        /// Groups
        /// </summary>
        public List<string> Groups { get; private set; }

        /// <summary>
        /// IsDefault
        /// </summary>
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsTagMetadataItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsTagMetadataItem()
        {
        }

        private ContentModelsTagMetadataItem(string Description, string TagText, List<string> Groups, bool? IsDefault, string Name)
        {
            
            this.Description = Description;
            
            this.TagText = TagText;
            
            this.Groups = Groups;
            
            this.IsDefault = IsDefault;
            
            this.Name = Name;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsTagMetadataItem.
        /// </summary>
        /// <returns>ContentModelsTagMetadataItemBuilder</returns>
        public static ContentModelsTagMetadataItemBuilder Builder()
        {
            return new ContentModelsTagMetadataItemBuilder();
        }

        /// <summary>
        /// Returns ContentModelsTagMetadataItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsTagMetadataItemBuilder</returns>
        public ContentModelsTagMetadataItemBuilder With()
        {
            return Builder()
                .Description(Description)
                .TagText(TagText)
                .Groups(Groups)
                .IsDefault(IsDefault)
                .Name(Name);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsTagMetadataItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsTagMetadataItem.
        /// </summary>
        /// <param name="left">Compared (ContentModelsTagMetadataItem</param>
        /// <param name="right">Compared (ContentModelsTagMetadataItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsTagMetadataItem left, ContentModelsTagMetadataItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsTagMetadataItem.
        /// </summary>
        /// <param name="left">Compared (ContentModelsTagMetadataItem</param>
        /// <param name="right">Compared (ContentModelsTagMetadataItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsTagMetadataItem left, ContentModelsTagMetadataItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsTagMetadataItem.
        /// </summary>
        public sealed class ContentModelsTagMetadataItemBuilder
        {
            private string _Description;
            private string _TagText;
            private List<string> _Groups;
            private bool? _IsDefault;
            private string _Name;

            internal ContentModelsTagMetadataItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataItem.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public ContentModelsTagMetadataItemBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataItem.TagText property.
            /// </summary>
            /// <param name="value">TagText</param>
            public ContentModelsTagMetadataItemBuilder TagText(string value)
            {
                _TagText = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataItem.Groups property.
            /// </summary>
            /// <param name="value">Groups</param>
            public ContentModelsTagMetadataItemBuilder Groups(List<string> value)
            {
                _Groups = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataItem.IsDefault property.
            /// </summary>
            /// <param name="value">IsDefault</param>
            public ContentModelsTagMetadataItemBuilder IsDefault(bool? value)
            {
                _IsDefault = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataItem.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentModelsTagMetadataItemBuilder Name(string value)
            {
                _Name = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsTagMetadataItem.
            /// </summary>
            /// <returns>ContentModelsTagMetadataItem</returns>
            public ContentModelsTagMetadataItem Build()
            {
                Validate();
                return new ContentModelsTagMetadataItem(
                    Description: _Description,
                    TagText: _TagText,
                    Groups: _Groups,
                    IsDefault: _IsDefault,
                    Name: _Name
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}