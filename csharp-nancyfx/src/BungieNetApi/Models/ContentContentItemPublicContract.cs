using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentContentItemPublicContract
    /// </summary>
    public sealed class ContentContentItemPublicContract:  IEquatable<ContentContentItemPublicContract>
    { 
        /// <summary>
        /// ContentId
        /// </summary>
        public long? ContentId { get; private set; }

        /// <summary>
        /// CType
        /// </summary>
        public string CType { get; private set; }

        /// <summary>
        /// CmsPath
        /// </summary>
        public string CmsPath { get; private set; }

        /// <summary>
        /// CreationDate
        /// </summary>
        public DateTime? CreationDate { get; private set; }

        /// <summary>
        /// ModifyDate
        /// </summary>
        public DateTime? ModifyDate { get; private set; }

        /// <summary>
        /// AllowComments
        /// </summary>
        public bool? AllowComments { get; private set; }

        /// <summary>
        /// HasAgeGate
        /// </summary>
        public bool? HasAgeGate { get; private set; }

        /// <summary>
        /// MinimumAge
        /// </summary>
        public int? MinimumAge { get; private set; }

        /// <summary>
        /// RatingImagePath
        /// </summary>
        public string RatingImagePath { get; private set; }

        /// <summary>
        /// Author
        /// </summary>
        public UserGeneralUser Author { get; private set; }

        /// <summary>
        /// AutoEnglishPropertyFallback
        /// </summary>
        public bool? AutoEnglishPropertyFallback { get; private set; }

        /// <summary>
        /// Firehose content is really a collection of metadata and \&quot;properties\&quot;, which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown.  As Cole Porter would have crooned, \&quot;Anything Goes\&quot; with Firehose properties. They are most often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized.
        /// </summary>
        public Dictionary<string, Object> Properties { get; private set; }

        /// <summary>
        /// Representations
        /// </summary>
        public List<ContentContentRepresentation> Representations { get; private set; }

        /// <summary>
        /// NOTE: Tags will always be lower case.
        /// </summary>
        public List<string> Tags { get; private set; }

        /// <summary>
        /// CommentSummary
        /// </summary>
        public ContentCommentSummary CommentSummary { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentContentItemPublicContract.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentContentItemPublicContract()
        {
        }

        private ContentContentItemPublicContract(long? ContentId, string CType, string CmsPath, DateTime? CreationDate, DateTime? ModifyDate, bool? AllowComments, bool? HasAgeGate, int? MinimumAge, string RatingImagePath, UserGeneralUser Author, bool? AutoEnglishPropertyFallback, Dictionary<string, Object> Properties, List<ContentContentRepresentation> Representations, List<string> Tags, ContentCommentSummary CommentSummary)
        {
            
            this.ContentId = ContentId;
            
            this.CType = CType;
            
            this.CmsPath = CmsPath;
            
            this.CreationDate = CreationDate;
            
            this.ModifyDate = ModifyDate;
            
            this.AllowComments = AllowComments;
            
            this.HasAgeGate = HasAgeGate;
            
            this.MinimumAge = MinimumAge;
            
            this.RatingImagePath = RatingImagePath;
            
            this.Author = Author;
            
            this.AutoEnglishPropertyFallback = AutoEnglishPropertyFallback;
            
            this.Properties = Properties;
            
            this.Representations = Representations;
            
            this.Tags = Tags;
            
            this.CommentSummary = CommentSummary;
            
        }

        /// <summary>
        /// Returns builder of ContentContentItemPublicContract.
        /// </summary>
        /// <returns>ContentContentItemPublicContractBuilder</returns>
        public static ContentContentItemPublicContractBuilder Builder()
        {
            return new ContentContentItemPublicContractBuilder();
        }

        /// <summary>
        /// Returns ContentContentItemPublicContractBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentContentItemPublicContractBuilder</returns>
        public ContentContentItemPublicContractBuilder With()
        {
            return Builder()
                .ContentId(ContentId)
                .CType(CType)
                .CmsPath(CmsPath)
                .CreationDate(CreationDate)
                .ModifyDate(ModifyDate)
                .AllowComments(AllowComments)
                .HasAgeGate(HasAgeGate)
                .MinimumAge(MinimumAge)
                .RatingImagePath(RatingImagePath)
                .Author(Author)
                .AutoEnglishPropertyFallback(AutoEnglishPropertyFallback)
                .Properties(Properties)
                .Representations(Representations)
                .Tags(Tags)
                .CommentSummary(CommentSummary);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentContentItemPublicContract other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentContentItemPublicContract.
        /// </summary>
        /// <param name="left">Compared (ContentContentItemPublicContract</param>
        /// <param name="right">Compared (ContentContentItemPublicContract</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentContentItemPublicContract left, ContentContentItemPublicContract right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentContentItemPublicContract.
        /// </summary>
        /// <param name="left">Compared (ContentContentItemPublicContract</param>
        /// <param name="right">Compared (ContentContentItemPublicContract</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentContentItemPublicContract left, ContentContentItemPublicContract right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentContentItemPublicContract.
        /// </summary>
        public sealed class ContentContentItemPublicContractBuilder
        {
            private long? _ContentId;
            private string _CType;
            private string _CmsPath;
            private DateTime? _CreationDate;
            private DateTime? _ModifyDate;
            private bool? _AllowComments;
            private bool? _HasAgeGate;
            private int? _MinimumAge;
            private string _RatingImagePath;
            private UserGeneralUser _Author;
            private bool? _AutoEnglishPropertyFallback;
            private Dictionary<string, Object> _Properties;
            private List<ContentContentRepresentation> _Representations;
            private List<string> _Tags;
            private ContentCommentSummary _CommentSummary;

            internal ContentContentItemPublicContractBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.ContentId property.
            /// </summary>
            /// <param name="value">ContentId</param>
            public ContentContentItemPublicContractBuilder ContentId(long? value)
            {
                _ContentId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.CType property.
            /// </summary>
            /// <param name="value">CType</param>
            public ContentContentItemPublicContractBuilder CType(string value)
            {
                _CType = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.CmsPath property.
            /// </summary>
            /// <param name="value">CmsPath</param>
            public ContentContentItemPublicContractBuilder CmsPath(string value)
            {
                _CmsPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.CreationDate property.
            /// </summary>
            /// <param name="value">CreationDate</param>
            public ContentContentItemPublicContractBuilder CreationDate(DateTime? value)
            {
                _CreationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.ModifyDate property.
            /// </summary>
            /// <param name="value">ModifyDate</param>
            public ContentContentItemPublicContractBuilder ModifyDate(DateTime? value)
            {
                _ModifyDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.AllowComments property.
            /// </summary>
            /// <param name="value">AllowComments</param>
            public ContentContentItemPublicContractBuilder AllowComments(bool? value)
            {
                _AllowComments = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.HasAgeGate property.
            /// </summary>
            /// <param name="value">HasAgeGate</param>
            public ContentContentItemPublicContractBuilder HasAgeGate(bool? value)
            {
                _HasAgeGate = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.MinimumAge property.
            /// </summary>
            /// <param name="value">MinimumAge</param>
            public ContentContentItemPublicContractBuilder MinimumAge(int? value)
            {
                _MinimumAge = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.RatingImagePath property.
            /// </summary>
            /// <param name="value">RatingImagePath</param>
            public ContentContentItemPublicContractBuilder RatingImagePath(string value)
            {
                _RatingImagePath = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.Author property.
            /// </summary>
            /// <param name="value">Author</param>
            public ContentContentItemPublicContractBuilder Author(UserGeneralUser value)
            {
                _Author = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.AutoEnglishPropertyFallback property.
            /// </summary>
            /// <param name="value">AutoEnglishPropertyFallback</param>
            public ContentContentItemPublicContractBuilder AutoEnglishPropertyFallback(bool? value)
            {
                _AutoEnglishPropertyFallback = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.Properties property.
            /// </summary>
            /// <param name="value">Firehose content is really a collection of metadata and \&quot;properties\&quot;, which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown.  As Cole Porter would have crooned, \&quot;Anything Goes\&quot; with Firehose properties. They are most often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized.</param>
            public ContentContentItemPublicContractBuilder Properties(Dictionary<string, Object> value)
            {
                _Properties = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.Representations property.
            /// </summary>
            /// <param name="value">Representations</param>
            public ContentContentItemPublicContractBuilder Representations(List<ContentContentRepresentation> value)
            {
                _Representations = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.Tags property.
            /// </summary>
            /// <param name="value">NOTE: Tags will always be lower case.</param>
            public ContentContentItemPublicContractBuilder Tags(List<string> value)
            {
                _Tags = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentContentItemPublicContract.CommentSummary property.
            /// </summary>
            /// <param name="value">CommentSummary</param>
            public ContentContentItemPublicContractBuilder CommentSummary(ContentCommentSummary value)
            {
                _CommentSummary = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentContentItemPublicContract.
            /// </summary>
            /// <returns>ContentContentItemPublicContract</returns>
            public ContentContentItemPublicContract Build()
            {
                Validate();
                return new ContentContentItemPublicContract(
                    ContentId: _ContentId,
                    CType: _CType,
                    CmsPath: _CmsPath,
                    CreationDate: _CreationDate,
                    ModifyDate: _ModifyDate,
                    AllowComments: _AllowComments,
                    HasAgeGate: _HasAgeGate,
                    MinimumAge: _MinimumAge,
                    RatingImagePath: _RatingImagePath,
                    Author: _Author,
                    AutoEnglishPropertyFallback: _AutoEnglishPropertyFallback,
                    Properties: _Properties,
                    Representations: _Representations,
                    Tags: _Tags,
                    CommentSummary: _CommentSummary
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}