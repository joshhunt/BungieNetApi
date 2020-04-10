using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TagsModelsContractsTagResponse
    /// </summary>
    public sealed class TagsModelsContractsTagResponse:  IEquatable<TagsModelsContractsTagResponse>
    { 
        /// <summary>
        /// TagText
        /// </summary>
        public string TagText { get; private set; }

        /// <summary>
        /// IgnoreStatus
        /// </summary>
        public IgnoresIgnoreResponse IgnoreStatus { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TagsModelsContractsTagResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TagsModelsContractsTagResponse()
        {
        }

        private TagsModelsContractsTagResponse(string TagText, IgnoresIgnoreResponse IgnoreStatus)
        {
            
            this.TagText = TagText;
            
            this.IgnoreStatus = IgnoreStatus;
            
        }

        /// <summary>
        /// Returns builder of TagsModelsContractsTagResponse.
        /// </summary>
        /// <returns>TagsModelsContractsTagResponseBuilder</returns>
        public static TagsModelsContractsTagResponseBuilder Builder()
        {
            return new TagsModelsContractsTagResponseBuilder();
        }

        /// <summary>
        /// Returns TagsModelsContractsTagResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TagsModelsContractsTagResponseBuilder</returns>
        public TagsModelsContractsTagResponseBuilder With()
        {
            return Builder()
                .TagText(TagText)
                .IgnoreStatus(IgnoreStatus);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TagsModelsContractsTagResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TagsModelsContractsTagResponse.
        /// </summary>
        /// <param name="left">Compared (TagsModelsContractsTagResponse</param>
        /// <param name="right">Compared (TagsModelsContractsTagResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TagsModelsContractsTagResponse left, TagsModelsContractsTagResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TagsModelsContractsTagResponse.
        /// </summary>
        /// <param name="left">Compared (TagsModelsContractsTagResponse</param>
        /// <param name="right">Compared (TagsModelsContractsTagResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TagsModelsContractsTagResponse left, TagsModelsContractsTagResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TagsModelsContractsTagResponse.
        /// </summary>
        public sealed class TagsModelsContractsTagResponseBuilder
        {
            private string _TagText;
            private IgnoresIgnoreResponse _IgnoreStatus;

            internal TagsModelsContractsTagResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TagsModelsContractsTagResponse.TagText property.
            /// </summary>
            /// <param name="value">TagText</param>
            public TagsModelsContractsTagResponseBuilder TagText(string value)
            {
                _TagText = value;
                return this;
            }

            /// <summary>
            /// Sets value for TagsModelsContractsTagResponse.IgnoreStatus property.
            /// </summary>
            /// <param name="value">IgnoreStatus</param>
            public TagsModelsContractsTagResponseBuilder IgnoreStatus(IgnoresIgnoreResponse value)
            {
                _IgnoreStatus = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TagsModelsContractsTagResponse.
            /// </summary>
            /// <returns>TagsModelsContractsTagResponse</returns>
            public TagsModelsContractsTagResponse Build()
            {
                Validate();
                return new TagsModelsContractsTagResponse(
                    TagText: _TagText,
                    IgnoreStatus: _IgnoreStatus
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}