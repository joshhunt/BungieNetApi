using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingEntryDestinyRitual
    /// </summary>
    public sealed class TrendingTrendingEntryDestinyRitual:  IEquatable<TrendingTrendingEntryDestinyRitual>
    { 
        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; private set; }

        /// <summary>
        /// Icon
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Subtitle
        /// </summary>
        public string Subtitle { get; private set; }

        /// <summary>
        /// DateStart
        /// </summary>
        public DateTime? DateStart { get; private set; }

        /// <summary>
        /// DateEnd
        /// </summary>
        public DateTime? DateEnd { get; private set; }

        /// <summary>
        /// A destiny event does not necessarily have a related Milestone, but if it does the details will be returned here.
        /// </summary>
        public DestinyMilestonesDestinyPublicMilestone MilestoneDetails { get; private set; }

        /// <summary>
        /// A destiny event will not necessarily have milestone \&quot;custom content\&quot;, but if it does the details will be here.
        /// </summary>
        public DestinyMilestonesDestinyMilestoneContent EventContent { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntryDestinyRitual.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntryDestinyRitual()
        {
        }

        private TrendingTrendingEntryDestinyRitual(string Image, string Icon, string Title, string Subtitle, DateTime? DateStart, DateTime? DateEnd, DestinyMilestonesDestinyPublicMilestone MilestoneDetails, DestinyMilestonesDestinyMilestoneContent EventContent)
        {
            
            this.Image = Image;
            
            this.Icon = Icon;
            
            this.Title = Title;
            
            this.Subtitle = Subtitle;
            
            this.DateStart = DateStart;
            
            this.DateEnd = DateEnd;
            
            this.MilestoneDetails = MilestoneDetails;
            
            this.EventContent = EventContent;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntryDestinyRitual.
        /// </summary>
        /// <returns>TrendingTrendingEntryDestinyRitualBuilder</returns>
        public static TrendingTrendingEntryDestinyRitualBuilder Builder()
        {
            return new TrendingTrendingEntryDestinyRitualBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntryDestinyRitualBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntryDestinyRitualBuilder</returns>
        public TrendingTrendingEntryDestinyRitualBuilder With()
        {
            return Builder()
                .Image(Image)
                .Icon(Icon)
                .Title(Title)
                .Subtitle(Subtitle)
                .DateStart(DateStart)
                .DateEnd(DateEnd)
                .MilestoneDetails(MilestoneDetails)
                .EventContent(EventContent);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingEntryDestinyRitual other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntryDestinyRitual.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryDestinyRitual</param>
        /// <param name="right">Compared (TrendingTrendingEntryDestinyRitual</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntryDestinyRitual left, TrendingTrendingEntryDestinyRitual right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntryDestinyRitual.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryDestinyRitual</param>
        /// <param name="right">Compared (TrendingTrendingEntryDestinyRitual</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntryDestinyRitual left, TrendingTrendingEntryDestinyRitual right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntryDestinyRitual.
        /// </summary>
        public sealed class TrendingTrendingEntryDestinyRitualBuilder
        {
            private string _Image;
            private string _Icon;
            private string _Title;
            private string _Subtitle;
            private DateTime? _DateStart;
            private DateTime? _DateEnd;
            private DestinyMilestonesDestinyPublicMilestone _MilestoneDetails;
            private DestinyMilestonesDestinyMilestoneContent _EventContent;

            internal TrendingTrendingEntryDestinyRitualBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.Image property.
            /// </summary>
            /// <param name="value">Image</param>
            public TrendingTrendingEntryDestinyRitualBuilder Image(string value)
            {
                _Image = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.Icon property.
            /// </summary>
            /// <param name="value">Icon</param>
            public TrendingTrendingEntryDestinyRitualBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public TrendingTrendingEntryDestinyRitualBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.Subtitle property.
            /// </summary>
            /// <param name="value">Subtitle</param>
            public TrendingTrendingEntryDestinyRitualBuilder Subtitle(string value)
            {
                _Subtitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.DateStart property.
            /// </summary>
            /// <param name="value">DateStart</param>
            public TrendingTrendingEntryDestinyRitualBuilder DateStart(DateTime? value)
            {
                _DateStart = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.DateEnd property.
            /// </summary>
            /// <param name="value">DateEnd</param>
            public TrendingTrendingEntryDestinyRitualBuilder DateEnd(DateTime? value)
            {
                _DateEnd = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.MilestoneDetails property.
            /// </summary>
            /// <param name="value">A destiny event does not necessarily have a related Milestone, but if it does the details will be returned here.</param>
            public TrendingTrendingEntryDestinyRitualBuilder MilestoneDetails(DestinyMilestonesDestinyPublicMilestone value)
            {
                _MilestoneDetails = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyRitual.EventContent property.
            /// </summary>
            /// <param name="value">A destiny event will not necessarily have milestone \&quot;custom content\&quot;, but if it does the details will be here.</param>
            public TrendingTrendingEntryDestinyRitualBuilder EventContent(DestinyMilestonesDestinyMilestoneContent value)
            {
                _EventContent = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntryDestinyRitual.
            /// </summary>
            /// <returns>TrendingTrendingEntryDestinyRitual</returns>
            public TrendingTrendingEntryDestinyRitual Build()
            {
                Validate();
                return new TrendingTrendingEntryDestinyRitual(
                    Image: _Image,
                    Icon: _Icon,
                    Title: _Title,
                    Subtitle: _Subtitle,
                    DateStart: _DateStart,
                    DateEnd: _DateEnd,
                    MilestoneDetails: _MilestoneDetails,
                    EventContent: _EventContent
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}