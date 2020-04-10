using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentContentRepresentation
    /// </summary>
    public sealed class ContentContentRepresentation:  IEquatable<ContentContentRepresentation>
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
        /// ValidationString
        /// </summary>
        public string ValidationString { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentContentRepresentation.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentContentRepresentation()
        {
        }

        private ContentContentRepresentation(string Name, string Path, string ValidationString)
        {
            
            this.Name = Name;
            
            this.Path = Path;
            
            this.ValidationString = ValidationString;
            
        }

        /// <summary>
        /// Returns builder of ContentContentRepresentation.
        /// </summary>
        /// <returns>ContentContentRepresentationBuilder</returns>
        public static ContentContentRepresentationBuilder Builder()
        {
            return new ContentContentRepresentationBuilder();
        }

        /// <summary>
        /// Returns ContentContentRepresentationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentContentRepresentationBuilder</returns>
        public ContentContentRepresentationBuilder With()
        {
            return Builder()
                .Name(Name)
                .Path(Path)
                .ValidationString(ValidationString);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentContentRepresentation other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentContentRepresentation.
        /// </summary>
        /// <param name="left">Compared (ContentContentRepresentation</param>
        /// <param name="right">Compared (ContentContentRepresentation</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentContentRepresentation left, ContentContentRepresentation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentContentRepresentation.
        /// </summary>
        /// <param name="left">Compared (ContentContentRepresentation</param>
        /// <param name="right">Compared (ContentContentRepresentation</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentContentRepresentation left, ContentContentRepresentation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentContentRepresentation.
        /// </summary>
        public sealed class ContentContentRepresentationBuilder
        {
            private string _Name;
            private string _Path;
            private string _ValidationString;

            internal ContentContentRepresentationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentContentRepresentation.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentContentRepresentationBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentRepresentation.Path property.
            /// </summary>
            /// <param name="value">Path</param>
            public ContentContentRepresentationBuilder Path(string value)
            {
                _Path = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentRepresentation.ValidationString property.
            /// </summary>
            /// <param name="value">ValidationString</param>
            public ContentContentRepresentationBuilder ValidationString(string value)
            {
                _ValidationString = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentContentRepresentation.
            /// </summary>
            /// <returns>ContentContentRepresentation</returns>
            public ContentContentRepresentation Build()
            {
                Validate();
                return new ContentContentRepresentation(
                    Name: _Name,
                    Path: _Path,
                    ValidationString: _ValidationString
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}