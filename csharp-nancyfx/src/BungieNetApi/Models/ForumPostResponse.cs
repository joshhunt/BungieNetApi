using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ForumPostResponse
    /// </summary>
    public sealed class ForumPostResponse:  IEquatable<ForumPostResponse>
    { 
        /// <summary>
        /// LastReplyTimestamp
        /// </summary>
        public DateTime? LastReplyTimestamp { get; private set; }

        /// <summary>
        /// IsPinned
        /// </summary>
        public bool? IsPinned { get; private set; }

        /// <summary>
        /// UrlMediaType
        /// </summary>
        public int? UrlMediaType { get; private set; }

        /// <summary>
        /// Thumbnail
        /// </summary>
        public string Thumbnail { get; private set; }

        /// <summary>
        /// Popularity
        /// </summary>
        public int? Popularity { get; private set; }

        /// <summary>
        /// IsActive
        /// </summary>
        public bool? IsActive { get; private set; }

        /// <summary>
        /// IsAnnouncement
        /// </summary>
        public bool? IsAnnouncement { get; private set; }

        /// <summary>
        /// UserRating
        /// </summary>
        public int? UserRating { get; private set; }

        /// <summary>
        /// UserHasRated
        /// </summary>
        public bool? UserHasRated { get; private set; }

        /// <summary>
        /// UserHasMutedPost
        /// </summary>
        public bool? UserHasMutedPost { get; private set; }

        /// <summary>
        /// LatestReplyPostId
        /// </summary>
        public long? LatestReplyPostId { get; private set; }

        /// <summary>
        /// LatestReplyAuthorId
        /// </summary>
        public long? LatestReplyAuthorId { get; private set; }

        /// <summary>
        /// IgnoreStatus
        /// </summary>
        public IgnoresIgnoreResponse IgnoreStatus { get; private set; }

        /// <summary>
        /// Locale
        /// </summary>
        public string Locale { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ForumPostResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ForumPostResponse()
        {
        }

        private ForumPostResponse(DateTime? LastReplyTimestamp, bool? IsPinned, int? UrlMediaType, string Thumbnail, int? Popularity, bool? IsActive, bool? IsAnnouncement, int? UserRating, bool? UserHasRated, bool? UserHasMutedPost, long? LatestReplyPostId, long? LatestReplyAuthorId, IgnoresIgnoreResponse IgnoreStatus, string Locale)
        {
            
            this.LastReplyTimestamp = LastReplyTimestamp;
            
            this.IsPinned = IsPinned;
            
            this.UrlMediaType = UrlMediaType;
            
            this.Thumbnail = Thumbnail;
            
            this.Popularity = Popularity;
            
            this.IsActive = IsActive;
            
            this.IsAnnouncement = IsAnnouncement;
            
            this.UserRating = UserRating;
            
            this.UserHasRated = UserHasRated;
            
            this.UserHasMutedPost = UserHasMutedPost;
            
            this.LatestReplyPostId = LatestReplyPostId;
            
            this.LatestReplyAuthorId = LatestReplyAuthorId;
            
            this.IgnoreStatus = IgnoreStatus;
            
            this.Locale = Locale;
            
        }

        /// <summary>
        /// Returns builder of ForumPostResponse.
        /// </summary>
        /// <returns>ForumPostResponseBuilder</returns>
        public static ForumPostResponseBuilder Builder()
        {
            return new ForumPostResponseBuilder();
        }

        /// <summary>
        /// Returns ForumPostResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ForumPostResponseBuilder</returns>
        public ForumPostResponseBuilder With()
        {
            return Builder()
                .LastReplyTimestamp(LastReplyTimestamp)
                .IsPinned(IsPinned)
                .UrlMediaType(UrlMediaType)
                .Thumbnail(Thumbnail)
                .Popularity(Popularity)
                .IsActive(IsActive)
                .IsAnnouncement(IsAnnouncement)
                .UserRating(UserRating)
                .UserHasRated(UserHasRated)
                .UserHasMutedPost(UserHasMutedPost)
                .LatestReplyPostId(LatestReplyPostId)
                .LatestReplyAuthorId(LatestReplyAuthorId)
                .IgnoreStatus(IgnoreStatus)
                .Locale(Locale);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ForumPostResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ForumPostResponse.
        /// </summary>
        /// <param name="left">Compared (ForumPostResponse</param>
        /// <param name="right">Compared (ForumPostResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ForumPostResponse left, ForumPostResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ForumPostResponse.
        /// </summary>
        /// <param name="left">Compared (ForumPostResponse</param>
        /// <param name="right">Compared (ForumPostResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ForumPostResponse left, ForumPostResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ForumPostResponse.
        /// </summary>
        public sealed class ForumPostResponseBuilder
        {
            private DateTime? _LastReplyTimestamp;
            private bool? _IsPinned;
            private int? _UrlMediaType;
            private string _Thumbnail;
            private int? _Popularity;
            private bool? _IsActive;
            private bool? _IsAnnouncement;
            private int? _UserRating;
            private bool? _UserHasRated;
            private bool? _UserHasMutedPost;
            private long? _LatestReplyPostId;
            private long? _LatestReplyAuthorId;
            private IgnoresIgnoreResponse _IgnoreStatus;
            private string _Locale;

            internal ForumPostResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ForumPostResponse.LastReplyTimestamp property.
            /// </summary>
            /// <param name="value">LastReplyTimestamp</param>
            public ForumPostResponseBuilder LastReplyTimestamp(DateTime? value)
            {
                _LastReplyTimestamp = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.IsPinned property.
            /// </summary>
            /// <param name="value">IsPinned</param>
            public ForumPostResponseBuilder IsPinned(bool? value)
            {
                _IsPinned = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.UrlMediaType property.
            /// </summary>
            /// <param name="value">UrlMediaType</param>
            public ForumPostResponseBuilder UrlMediaType(int? value)
            {
                _UrlMediaType = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.Thumbnail property.
            /// </summary>
            /// <param name="value">Thumbnail</param>
            public ForumPostResponseBuilder Thumbnail(string value)
            {
                _Thumbnail = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.Popularity property.
            /// </summary>
            /// <param name="value">Popularity</param>
            public ForumPostResponseBuilder Popularity(int? value)
            {
                _Popularity = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.IsActive property.
            /// </summary>
            /// <param name="value">IsActive</param>
            public ForumPostResponseBuilder IsActive(bool? value)
            {
                _IsActive = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.IsAnnouncement property.
            /// </summary>
            /// <param name="value">IsAnnouncement</param>
            public ForumPostResponseBuilder IsAnnouncement(bool? value)
            {
                _IsAnnouncement = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.UserRating property.
            /// </summary>
            /// <param name="value">UserRating</param>
            public ForumPostResponseBuilder UserRating(int? value)
            {
                _UserRating = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.UserHasRated property.
            /// </summary>
            /// <param name="value">UserHasRated</param>
            public ForumPostResponseBuilder UserHasRated(bool? value)
            {
                _UserHasRated = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.UserHasMutedPost property.
            /// </summary>
            /// <param name="value">UserHasMutedPost</param>
            public ForumPostResponseBuilder UserHasMutedPost(bool? value)
            {
                _UserHasMutedPost = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.LatestReplyPostId property.
            /// </summary>
            /// <param name="value">LatestReplyPostId</param>
            public ForumPostResponseBuilder LatestReplyPostId(long? value)
            {
                _LatestReplyPostId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.LatestReplyAuthorId property.
            /// </summary>
            /// <param name="value">LatestReplyAuthorId</param>
            public ForumPostResponseBuilder LatestReplyAuthorId(long? value)
            {
                _LatestReplyAuthorId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.IgnoreStatus property.
            /// </summary>
            /// <param name="value">IgnoreStatus</param>
            public ForumPostResponseBuilder IgnoreStatus(IgnoresIgnoreResponse value)
            {
                _IgnoreStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPostResponse.Locale property.
            /// </summary>
            /// <param name="value">Locale</param>
            public ForumPostResponseBuilder Locale(string value)
            {
                _Locale = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ForumPostResponse.
            /// </summary>
            /// <returns>ForumPostResponse</returns>
            public ForumPostResponse Build()
            {
                Validate();
                return new ForumPostResponse(
                    LastReplyTimestamp: _LastReplyTimestamp,
                    IsPinned: _IsPinned,
                    UrlMediaType: _UrlMediaType,
                    Thumbnail: _Thumbnail,
                    Popularity: _Popularity,
                    IsActive: _IsActive,
                    IsAnnouncement: _IsAnnouncement,
                    UserRating: _UserRating,
                    UserHasRated: _UserHasRated,
                    UserHasMutedPost: _UserHasMutedPost,
                    LatestReplyPostId: _LatestReplyPostId,
                    LatestReplyAuthorId: _LatestReplyAuthorId,
                    IgnoreStatus: _IgnoreStatus,
                    Locale: _Locale
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}