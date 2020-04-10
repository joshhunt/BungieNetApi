using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// LinksHyperlinkReference
    /// </summary>
    public sealed class LinksHyperlinkReference:  IEquatable<LinksHyperlinkReference>
    { 
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use LinksHyperlinkReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public LinksHyperlinkReference()
        {
        }

        private LinksHyperlinkReference(string Title, string Url)
        {
            
            this.Title = Title;
            
            this.Url = Url;
            
        }

        /// <summary>
        /// Returns builder of LinksHyperlinkReference.
        /// </summary>
        /// <returns>LinksHyperlinkReferenceBuilder</returns>
        public static LinksHyperlinkReferenceBuilder Builder()
        {
            return new LinksHyperlinkReferenceBuilder();
        }

        /// <summary>
        /// Returns LinksHyperlinkReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>LinksHyperlinkReferenceBuilder</returns>
        public LinksHyperlinkReferenceBuilder With()
        {
            return Builder()
                .Title(Title)
                .Url(Url);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(LinksHyperlinkReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (LinksHyperlinkReference.
        /// </summary>
        /// <param name="left">Compared (LinksHyperlinkReference</param>
        /// <param name="right">Compared (LinksHyperlinkReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (LinksHyperlinkReference left, LinksHyperlinkReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (LinksHyperlinkReference.
        /// </summary>
        /// <param name="left">Compared (LinksHyperlinkReference</param>
        /// <param name="right">Compared (LinksHyperlinkReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (LinksHyperlinkReference left, LinksHyperlinkReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of LinksHyperlinkReference.
        /// </summary>
        public sealed class LinksHyperlinkReferenceBuilder
        {
            private string _Title;
            private string _Url;

            internal LinksHyperlinkReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for LinksHyperlinkReference.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public LinksHyperlinkReferenceBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for LinksHyperlinkReference.Url property.
            /// </summary>
            /// <param name="value">Url</param>
            public LinksHyperlinkReferenceBuilder Url(string value)
            {
                _Url = value;
                return this;
            }


            /// <summary>
            /// Builds instance of LinksHyperlinkReference.
            /// </summary>
            /// <returns>LinksHyperlinkReference</returns>
            public LinksHyperlinkReference Build()
            {
                Validate();
                return new LinksHyperlinkReference(
                    Title: _Title,
                    Url: _Url
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}