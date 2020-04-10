using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsContentTypeDefaultValue
    /// </summary>
    public sealed class ContentModelsContentTypeDefaultValue:  IEquatable<ContentModelsContentTypeDefaultValue>
    { 
        /// <summary>
        /// WhenClause
        /// </summary>
        public string WhenClause { get; private set; }

        /// <summary>
        /// WhenValue
        /// </summary>
        public string WhenValue { get; private set; }

        /// <summary>
        /// DefaultValue
        /// </summary>
        public string DefaultValue { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsContentTypeDefaultValue.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsContentTypeDefaultValue()
        {
        }

        private ContentModelsContentTypeDefaultValue(string WhenClause, string WhenValue, string DefaultValue)
        {
            
            this.WhenClause = WhenClause;
            
            this.WhenValue = WhenValue;
            
            this.DefaultValue = DefaultValue;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsContentTypeDefaultValue.
        /// </summary>
        /// <returns>ContentModelsContentTypeDefaultValueBuilder</returns>
        public static ContentModelsContentTypeDefaultValueBuilder Builder()
        {
            return new ContentModelsContentTypeDefaultValueBuilder();
        }

        /// <summary>
        /// Returns ContentModelsContentTypeDefaultValueBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsContentTypeDefaultValueBuilder</returns>
        public ContentModelsContentTypeDefaultValueBuilder With()
        {
            return Builder()
                .WhenClause(WhenClause)
                .WhenValue(WhenValue)
                .DefaultValue(DefaultValue);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsContentTypeDefaultValue other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsContentTypeDefaultValue.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypeDefaultValue</param>
        /// <param name="right">Compared (ContentModelsContentTypeDefaultValue</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsContentTypeDefaultValue left, ContentModelsContentTypeDefaultValue right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsContentTypeDefaultValue.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypeDefaultValue</param>
        /// <param name="right">Compared (ContentModelsContentTypeDefaultValue</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsContentTypeDefaultValue left, ContentModelsContentTypeDefaultValue right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsContentTypeDefaultValue.
        /// </summary>
        public sealed class ContentModelsContentTypeDefaultValueBuilder
        {
            private string _WhenClause;
            private string _WhenValue;
            private string _DefaultValue;

            internal ContentModelsContentTypeDefaultValueBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDefaultValue.WhenClause property.
            /// </summary>
            /// <param name="value">WhenClause</param>
            public ContentModelsContentTypeDefaultValueBuilder WhenClause(string value)
            {
                _WhenClause = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDefaultValue.WhenValue property.
            /// </summary>
            /// <param name="value">WhenValue</param>
            public ContentModelsContentTypeDefaultValueBuilder WhenValue(string value)
            {
                _WhenValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDefaultValue.DefaultValue property.
            /// </summary>
            /// <param name="value">DefaultValue</param>
            public ContentModelsContentTypeDefaultValueBuilder DefaultValue(string value)
            {
                _DefaultValue = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsContentTypeDefaultValue.
            /// </summary>
            /// <returns>ContentModelsContentTypeDefaultValue</returns>
            public ContentModelsContentTypeDefaultValue Build()
            {
                Validate();
                return new ContentModelsContentTypeDefaultValue(
                    WhenClause: _WhenClause,
                    WhenValue: _WhenValue,
                    DefaultValue: _DefaultValue
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}