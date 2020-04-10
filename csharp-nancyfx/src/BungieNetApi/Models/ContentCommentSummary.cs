using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentCommentSummary
    /// </summary>
    public sealed class ContentCommentSummary:  IEquatable<ContentCommentSummary>
    { 
        /// <summary>
        /// TopicId
        /// </summary>
        public long? TopicId { get; private set; }

        /// <summary>
        /// CommentCount
        /// </summary>
        public int? CommentCount { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentCommentSummary.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentCommentSummary()
        {
        }

        private ContentCommentSummary(long? TopicId, int? CommentCount)
        {
            
            this.TopicId = TopicId;
            
            this.CommentCount = CommentCount;
            
        }

        /// <summary>
        /// Returns builder of ContentCommentSummary.
        /// </summary>
        /// <returns>ContentCommentSummaryBuilder</returns>
        public static ContentCommentSummaryBuilder Builder()
        {
            return new ContentCommentSummaryBuilder();
        }

        /// <summary>
        /// Returns ContentCommentSummaryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentCommentSummaryBuilder</returns>
        public ContentCommentSummaryBuilder With()
        {
            return Builder()
                .TopicId(TopicId)
                .CommentCount(CommentCount);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentCommentSummary other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentCommentSummary.
        /// </summary>
        /// <param name="left">Compared (ContentCommentSummary</param>
        /// <param name="right">Compared (ContentCommentSummary</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentCommentSummary left, ContentCommentSummary right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentCommentSummary.
        /// </summary>
        /// <param name="left">Compared (ContentCommentSummary</param>
        /// <param name="right">Compared (ContentCommentSummary</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentCommentSummary left, ContentCommentSummary right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentCommentSummary.
        /// </summary>
        public sealed class ContentCommentSummaryBuilder
        {
            private long? _TopicId;
            private int? _CommentCount;

            internal ContentCommentSummaryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentCommentSummary.TopicId property.
            /// </summary>
            /// <param name="value">TopicId</param>
            public ContentCommentSummaryBuilder TopicId(long? value)
            {
                _TopicId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentCommentSummary.CommentCount property.
            /// </summary>
            /// <param name="value">CommentCount</param>
            public ContentCommentSummaryBuilder CommentCount(int? value)
            {
                _CommentCount = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentCommentSummary.
            /// </summary>
            /// <returns>ContentCommentSummary</returns>
            public ContentCommentSummary Build()
            {
                Validate();
                return new ContentCommentSummary(
                    TopicId: _TopicId,
                    CommentCount: _CommentCount
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}