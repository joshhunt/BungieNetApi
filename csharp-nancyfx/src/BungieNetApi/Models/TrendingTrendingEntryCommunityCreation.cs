using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingEntryCommunityCreation
    /// </summary>
    public sealed class TrendingTrendingEntryCommunityCreation:  IEquatable<TrendingTrendingEntryCommunityCreation>
    { 
        /// <summary>
        /// Media
        /// </summary>
        public string Media { get; private set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// AuthorMembershipId
        /// </summary>
        public long? AuthorMembershipId { get; private set; }

        /// <summary>
        /// PostId
        /// </summary>
        public long? PostId { get; private set; }

        /// <summary>
        /// Body
        /// </summary>
        public string Body { get; private set; }

        /// <summary>
        /// Upvotes
        /// </summary>
        public int? Upvotes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntryCommunityCreation.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntryCommunityCreation()
        {
        }

        private TrendingTrendingEntryCommunityCreation(string Media, string Title, string Author, long? AuthorMembershipId, long? PostId, string Body, int? Upvotes)
        {
            
            this.Media = Media;
            
            this.Title = Title;
            
            this.Author = Author;
            
            this.AuthorMembershipId = AuthorMembershipId;
            
            this.PostId = PostId;
            
            this.Body = Body;
            
            this.Upvotes = Upvotes;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntryCommunityCreation.
        /// </summary>
        /// <returns>TrendingTrendingEntryCommunityCreationBuilder</returns>
        public static TrendingTrendingEntryCommunityCreationBuilder Builder()
        {
            return new TrendingTrendingEntryCommunityCreationBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntryCommunityCreationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntryCommunityCreationBuilder</returns>
        public TrendingTrendingEntryCommunityCreationBuilder With()
        {
            return Builder()
                .Media(Media)
                .Title(Title)
                .Author(Author)
                .AuthorMembershipId(AuthorMembershipId)
                .PostId(PostId)
                .Body(Body)
                .Upvotes(Upvotes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingEntryCommunityCreation other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntryCommunityCreation.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryCommunityCreation</param>
        /// <param name="right">Compared (TrendingTrendingEntryCommunityCreation</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntryCommunityCreation left, TrendingTrendingEntryCommunityCreation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntryCommunityCreation.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryCommunityCreation</param>
        /// <param name="right">Compared (TrendingTrendingEntryCommunityCreation</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntryCommunityCreation left, TrendingTrendingEntryCommunityCreation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntryCommunityCreation.
        /// </summary>
        public sealed class TrendingTrendingEntryCommunityCreationBuilder
        {
            private string _Media;
            private string _Title;
            private string _Author;
            private long? _AuthorMembershipId;
            private long? _PostId;
            private string _Body;
            private int? _Upvotes;

            internal TrendingTrendingEntryCommunityCreationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.Media property.
            /// </summary>
            /// <param name="value">Media</param>
            public TrendingTrendingEntryCommunityCreationBuilder Media(string value)
            {
                _Media = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public TrendingTrendingEntryCommunityCreationBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.Author property.
            /// </summary>
            /// <param name="value">Author</param>
            public TrendingTrendingEntryCommunityCreationBuilder Author(string value)
            {
                _Author = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.AuthorMembershipId property.
            /// </summary>
            /// <param name="value">AuthorMembershipId</param>
            public TrendingTrendingEntryCommunityCreationBuilder AuthorMembershipId(long? value)
            {
                _AuthorMembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.PostId property.
            /// </summary>
            /// <param name="value">PostId</param>
            public TrendingTrendingEntryCommunityCreationBuilder PostId(long? value)
            {
                _PostId = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.Body property.
            /// </summary>
            /// <param name="value">Body</param>
            public TrendingTrendingEntryCommunityCreationBuilder Body(string value)
            {
                _Body = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryCommunityCreation.Upvotes property.
            /// </summary>
            /// <param name="value">Upvotes</param>
            public TrendingTrendingEntryCommunityCreationBuilder Upvotes(int? value)
            {
                _Upvotes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntryCommunityCreation.
            /// </summary>
            /// <returns>TrendingTrendingEntryCommunityCreation</returns>
            public TrendingTrendingEntryCommunityCreation Build()
            {
                Validate();
                return new TrendingTrendingEntryCommunityCreation(
                    Media: _Media,
                    Title: _Title,
                    Author: _Author,
                    AuthorMembershipId: _AuthorMembershipId,
                    PostId: _PostId,
                    Body: _Body,
                    Upvotes: _Upvotes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}