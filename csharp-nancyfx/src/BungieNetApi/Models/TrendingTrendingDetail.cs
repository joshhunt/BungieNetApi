using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingDetail
    /// </summary>
    public sealed class TrendingTrendingDetail:  IEquatable<TrendingTrendingDetail>
    { 
        /// <summary>
        /// Identifier
        /// </summary>
        public string Identifier { get; private set; }

        /// <summary>
        /// EntityType
        /// </summary>
        public int? EntityType { get; private set; }

        /// <summary>
        /// News
        /// </summary>
        public TrendingTrendingEntryNews News { get; private set; }

        /// <summary>
        /// Support
        /// </summary>
        public TrendingTrendingEntrySupportArticle Support { get; private set; }

        /// <summary>
        /// DestinyItem
        /// </summary>
        public TrendingTrendingEntryDestinyItem DestinyItem { get; private set; }

        /// <summary>
        /// DestinyActivity
        /// </summary>
        public TrendingTrendingEntryDestinyActivity DestinyActivity { get; private set; }

        /// <summary>
        /// DestinyRitual
        /// </summary>
        public TrendingTrendingEntryDestinyRitual DestinyRitual { get; private set; }

        /// <summary>
        /// Creation
        /// </summary>
        public TrendingTrendingEntryCommunityCreation Creation { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingDetail.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingDetail()
        {
        }

        private TrendingTrendingDetail(string Identifier, int? EntityType, TrendingTrendingEntryNews News, TrendingTrendingEntrySupportArticle Support, TrendingTrendingEntryDestinyItem DestinyItem, TrendingTrendingEntryDestinyActivity DestinyActivity, TrendingTrendingEntryDestinyRitual DestinyRitual, TrendingTrendingEntryCommunityCreation Creation)
        {
            
            this.Identifier = Identifier;
            
            this.EntityType = EntityType;
            
            this.News = News;
            
            this.Support = Support;
            
            this.DestinyItem = DestinyItem;
            
            this.DestinyActivity = DestinyActivity;
            
            this.DestinyRitual = DestinyRitual;
            
            this.Creation = Creation;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingDetail.
        /// </summary>
        /// <returns>TrendingTrendingDetailBuilder</returns>
        public static TrendingTrendingDetailBuilder Builder()
        {
            return new TrendingTrendingDetailBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingDetailBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingDetailBuilder</returns>
        public TrendingTrendingDetailBuilder With()
        {
            return Builder()
                .Identifier(Identifier)
                .EntityType(EntityType)
                .News(News)
                .Support(Support)
                .DestinyItem(DestinyItem)
                .DestinyActivity(DestinyActivity)
                .DestinyRitual(DestinyRitual)
                .Creation(Creation);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingDetail other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingDetail.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingDetail</param>
        /// <param name="right">Compared (TrendingTrendingDetail</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingDetail left, TrendingTrendingDetail right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingDetail.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingDetail</param>
        /// <param name="right">Compared (TrendingTrendingDetail</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingDetail left, TrendingTrendingDetail right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingDetail.
        /// </summary>
        public sealed class TrendingTrendingDetailBuilder
        {
            private string _Identifier;
            private int? _EntityType;
            private TrendingTrendingEntryNews _News;
            private TrendingTrendingEntrySupportArticle _Support;
            private TrendingTrendingEntryDestinyItem _DestinyItem;
            private TrendingTrendingEntryDestinyActivity _DestinyActivity;
            private TrendingTrendingEntryDestinyRitual _DestinyRitual;
            private TrendingTrendingEntryCommunityCreation _Creation;

            internal TrendingTrendingDetailBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.Identifier property.
            /// </summary>
            /// <param name="value">Identifier</param>
            public TrendingTrendingDetailBuilder Identifier(string value)
            {
                _Identifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.EntityType property.
            /// </summary>
            /// <param name="value">EntityType</param>
            public TrendingTrendingDetailBuilder EntityType(int? value)
            {
                _EntityType = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.News property.
            /// </summary>
            /// <param name="value">News</param>
            public TrendingTrendingDetailBuilder News(TrendingTrendingEntryNews value)
            {
                _News = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.Support property.
            /// </summary>
            /// <param name="value">Support</param>
            public TrendingTrendingDetailBuilder Support(TrendingTrendingEntrySupportArticle value)
            {
                _Support = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.DestinyItem property.
            /// </summary>
            /// <param name="value">DestinyItem</param>
            public TrendingTrendingDetailBuilder DestinyItem(TrendingTrendingEntryDestinyItem value)
            {
                _DestinyItem = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.DestinyActivity property.
            /// </summary>
            /// <param name="value">DestinyActivity</param>
            public TrendingTrendingDetailBuilder DestinyActivity(TrendingTrendingEntryDestinyActivity value)
            {
                _DestinyActivity = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.DestinyRitual property.
            /// </summary>
            /// <param name="value">DestinyRitual</param>
            public TrendingTrendingDetailBuilder DestinyRitual(TrendingTrendingEntryDestinyRitual value)
            {
                _DestinyRitual = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingDetail.Creation property.
            /// </summary>
            /// <param name="value">Creation</param>
            public TrendingTrendingDetailBuilder Creation(TrendingTrendingEntryCommunityCreation value)
            {
                _Creation = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingDetail.
            /// </summary>
            /// <returns>TrendingTrendingDetail</returns>
            public TrendingTrendingDetail Build()
            {
                Validate();
                return new TrendingTrendingDetail(
                    Identifier: _Identifier,
                    EntityType: _EntityType,
                    News: _News,
                    Support: _Support,
                    DestinyItem: _DestinyItem,
                    DestinyActivity: _DestinyActivity,
                    DestinyRitual: _DestinyRitual,
                    Creation: _Creation
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}