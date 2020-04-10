using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsContentPreview
    /// </summary>
    public sealed class ContentModelsContentPreview:  IEquatable<ContentModelsContentPreview>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Path
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// ItemInSet
        /// </summary>
        public bool? ItemInSet { get; private set; }

        /// <summary>
        /// SetTag
        /// </summary>
        public string SetTag { get; private set; }

        /// <summary>
        /// SetNesting
        /// </summary>
        public int? SetNesting { get; private set; }

        /// <summary>
        /// UseSetId
        /// </summary>
        public int? UseSetId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsContentPreview.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsContentPreview()
        {
        }

        private ContentModelsContentPreview(string Name, string Path, bool? ItemInSet, string SetTag, int? SetNesting, int? UseSetId)
        {
            
            this.Name = Name;
            
            this.Path = Path;
            
            this.ItemInSet = ItemInSet;
            
            this.SetTag = SetTag;
            
            this.SetNesting = SetNesting;
            
            this.UseSetId = UseSetId;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsContentPreview.
        /// </summary>
        /// <returns>ContentModelsContentPreviewBuilder</returns>
        public static ContentModelsContentPreviewBuilder Builder()
        {
            return new ContentModelsContentPreviewBuilder();
        }

        /// <summary>
        /// Returns ContentModelsContentPreviewBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsContentPreviewBuilder</returns>
        public ContentModelsContentPreviewBuilder With()
        {
            return Builder()
                .Name(Name)
                .Path(Path)
                .ItemInSet(ItemInSet)
                .SetTag(SetTag)
                .SetNesting(SetNesting)
                .UseSetId(UseSetId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsContentPreview other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsContentPreview.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentPreview</param>
        /// <param name="right">Compared (ContentModelsContentPreview</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsContentPreview left, ContentModelsContentPreview right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsContentPreview.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentPreview</param>
        /// <param name="right">Compared (ContentModelsContentPreview</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsContentPreview left, ContentModelsContentPreview right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsContentPreview.
        /// </summary>
        public sealed class ContentModelsContentPreviewBuilder
        {
            private string _Name;
            private string _Path;
            private bool? _ItemInSet;
            private string _SetTag;
            private int? _SetNesting;
            private int? _UseSetId;

            internal ContentModelsContentPreviewBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsContentPreview.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentModelsContentPreviewBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentPreview.Path property.
            /// </summary>
            /// <param name="value">Path</param>
            public ContentModelsContentPreviewBuilder Path(string value)
            {
                _Path = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentPreview.ItemInSet property.
            /// </summary>
            /// <param name="value">ItemInSet</param>
            public ContentModelsContentPreviewBuilder ItemInSet(bool? value)
            {
                _ItemInSet = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentPreview.SetTag property.
            /// </summary>
            /// <param name="value">SetTag</param>
            public ContentModelsContentPreviewBuilder SetTag(string value)
            {
                _SetTag = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentPreview.SetNesting property.
            /// </summary>
            /// <param name="value">SetNesting</param>
            public ContentModelsContentPreviewBuilder SetNesting(int? value)
            {
                _SetNesting = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentPreview.UseSetId property.
            /// </summary>
            /// <param name="value">UseSetId</param>
            public ContentModelsContentPreviewBuilder UseSetId(int? value)
            {
                _UseSetId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsContentPreview.
            /// </summary>
            /// <returns>ContentModelsContentPreview</returns>
            public ContentModelsContentPreview Build()
            {
                Validate();
                return new ContentModelsContentPreview(
                    Name: _Name,
                    Path: _Path,
                    ItemInSet: _ItemInSet,
                    SetTag: _SetTag,
                    SetNesting: _SetNesting,
                    UseSetId: _UseSetId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}