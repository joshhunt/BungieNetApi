using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The list entry view for trending items. Returns just enough to show the item on the trending page.
    /// </summary>
    public sealed class TrendingTrendingEntry:  IEquatable<TrendingTrendingEntry>
    { 
        /// <summary>
        /// The weighted score of this trending item.
        /// </summary>
        public double? Weight { get; private set; }

        /// <summary>
        /// IsFeatured
        /// </summary>
        public bool? IsFeatured { get; private set; }

        /// <summary>
        /// We don&#39;t know whether the identifier will be a string, a uint, or a long... so we&#39;re going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.
        /// </summary>
        public string Identifier { get; private set; }

        /// <summary>
        /// An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.
        /// </summary>
        public int? EntityType { get; private set; }

        /// <summary>
        /// The localized \&quot;display name/article title/&#39;primary localized identifier&#39;\&quot; of the entity.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// If the entity has a localized tagline/subtitle/motto/whatever, that is found here.
        /// </summary>
        public string Tagline { get; private set; }

        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; private set; }

        /// <summary>
        /// StartDate
        /// </summary>
        public DateTime? StartDate { get; private set; }

        /// <summary>
        /// EndDate
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// Link
        /// </summary>
        public string Link { get; private set; }

        /// <summary>
        /// If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
        /// </summary>
        public string WebmVideo { get; private set; }

        /// <summary>
        /// If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
        /// </summary>
        public string Mp4Video { get; private set; }

        /// <summary>
        /// If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don&#39;t use it all the time.
        /// </summary>
        public string FeatureImage { get; private set; }

        /// <summary>
        /// If the item is of entityType TrendingEntryType.Container, it may have items - also Trending Entries - contained within it. This is the ordered list of those to display under the Container&#39;s header.
        /// </summary>
        public List<TrendingTrendingEntry> Items { get; private set; }

        /// <summary>
        /// If the entry has a date at which it was created, this is that date.
        /// </summary>
        public DateTime? CreationDate { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntry()
        {
        }

        private TrendingTrendingEntry(double? Weight, bool? IsFeatured, string Identifier, int? EntityType, string DisplayName, string Tagline, string Image, DateTime? StartDate, DateTime? EndDate, string Link, string WebmVideo, string Mp4Video, string FeatureImage, List<TrendingTrendingEntry> Items, DateTime? CreationDate)
        {
            
            this.Weight = Weight;
            
            this.IsFeatured = IsFeatured;
            
            this.Identifier = Identifier;
            
            this.EntityType = EntityType;
            
            this.DisplayName = DisplayName;
            
            this.Tagline = Tagline;
            
            this.Image = Image;
            
            this.StartDate = StartDate;
            
            this.EndDate = EndDate;
            
            this.Link = Link;
            
            this.WebmVideo = WebmVideo;
            
            this.Mp4Video = Mp4Video;
            
            this.FeatureImage = FeatureImage;
            
            this.Items = Items;
            
            this.CreationDate = CreationDate;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntry.
        /// </summary>
        /// <returns>TrendingTrendingEntryBuilder</returns>
        public static TrendingTrendingEntryBuilder Builder()
        {
            return new TrendingTrendingEntryBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntryBuilder</returns>
        public TrendingTrendingEntryBuilder With()
        {
            return Builder()
                .Weight(Weight)
                .IsFeatured(IsFeatured)
                .Identifier(Identifier)
                .EntityType(EntityType)
                .DisplayName(DisplayName)
                .Tagline(Tagline)
                .Image(Image)
                .StartDate(StartDate)
                .EndDate(EndDate)
                .Link(Link)
                .WebmVideo(WebmVideo)
                .Mp4Video(Mp4Video)
                .FeatureImage(FeatureImage)
                .Items(Items)
                .CreationDate(CreationDate);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntry.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntry</param>
        /// <param name="right">Compared (TrendingTrendingEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntry left, TrendingTrendingEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntry.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntry</param>
        /// <param name="right">Compared (TrendingTrendingEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntry left, TrendingTrendingEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntry.
        /// </summary>
        public sealed class TrendingTrendingEntryBuilder
        {
            private double? _Weight;
            private bool? _IsFeatured;
            private string _Identifier;
            private int? _EntityType;
            private string _DisplayName;
            private string _Tagline;
            private string _Image;
            private DateTime? _StartDate;
            private DateTime? _EndDate;
            private string _Link;
            private string _WebmVideo;
            private string _Mp4Video;
            private string _FeatureImage;
            private List<TrendingTrendingEntry> _Items;
            private DateTime? _CreationDate;

            internal TrendingTrendingEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Weight property.
            /// </summary>
            /// <param name="value">The weighted score of this trending item.</param>
            public TrendingTrendingEntryBuilder Weight(double? value)
            {
                _Weight = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.IsFeatured property.
            /// </summary>
            /// <param name="value">IsFeatured</param>
            public TrendingTrendingEntryBuilder IsFeatured(bool? value)
            {
                _IsFeatured = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Identifier property.
            /// </summary>
            /// <param name="value">We don&#39;t know whether the identifier will be a string, a uint, or a long... so we&#39;re going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.</param>
            public TrendingTrendingEntryBuilder Identifier(string value)
            {
                _Identifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.EntityType property.
            /// </summary>
            /// <param name="value">An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.</param>
            public TrendingTrendingEntryBuilder EntityType(int? value)
            {
                _EntityType = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.DisplayName property.
            /// </summary>
            /// <param name="value">The localized \&quot;display name/article title/&#39;primary localized identifier&#39;\&quot; of the entity.</param>
            public TrendingTrendingEntryBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Tagline property.
            /// </summary>
            /// <param name="value">If the entity has a localized tagline/subtitle/motto/whatever, that is found here.</param>
            public TrendingTrendingEntryBuilder Tagline(string value)
            {
                _Tagline = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Image property.
            /// </summary>
            /// <param name="value">Image</param>
            public TrendingTrendingEntryBuilder Image(string value)
            {
                _Image = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.StartDate property.
            /// </summary>
            /// <param name="value">StartDate</param>
            public TrendingTrendingEntryBuilder StartDate(DateTime? value)
            {
                _StartDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.EndDate property.
            /// </summary>
            /// <param name="value">EndDate</param>
            public TrendingTrendingEntryBuilder EndDate(DateTime? value)
            {
                _EndDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Link property.
            /// </summary>
            /// <param name="value">Link</param>
            public TrendingTrendingEntryBuilder Link(string value)
            {
                _Link = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.WebmVideo property.
            /// </summary>
            /// <param name="value">If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo</param>
            public TrendingTrendingEntryBuilder WebmVideo(string value)
            {
                _WebmVideo = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Mp4Video property.
            /// </summary>
            /// <param name="value">If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo</param>
            public TrendingTrendingEntryBuilder Mp4Video(string value)
            {
                _Mp4Video = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.FeatureImage property.
            /// </summary>
            /// <param name="value">If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don&#39;t use it all the time.</param>
            public TrendingTrendingEntryBuilder FeatureImage(string value)
            {
                _FeatureImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.Items property.
            /// </summary>
            /// <param name="value">If the item is of entityType TrendingEntryType.Container, it may have items - also Trending Entries - contained within it. This is the ordered list of those to display under the Container&#39;s header.</param>
            public TrendingTrendingEntryBuilder Items(List<TrendingTrendingEntry> value)
            {
                _Items = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntry.CreationDate property.
            /// </summary>
            /// <param name="value">If the entry has a date at which it was created, this is that date.</param>
            public TrendingTrendingEntryBuilder CreationDate(DateTime? value)
            {
                _CreationDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntry.
            /// </summary>
            /// <returns>TrendingTrendingEntry</returns>
            public TrendingTrendingEntry Build()
            {
                Validate();
                return new TrendingTrendingEntry(
                    Weight: _Weight,
                    IsFeatured: _IsFeatured,
                    Identifier: _Identifier,
                    EntityType: _EntityType,
                    DisplayName: _DisplayName,
                    Tagline: _Tagline,
                    Image: _Image,
                    StartDate: _StartDate,
                    EndDate: _EndDate,
                    Link: _Link,
                    WebmVideo: _WebmVideo,
                    Mp4Video: _Mp4Video,
                    FeatureImage: _FeatureImage,
                    Items: _Items,
                    CreationDate: _CreationDate
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}