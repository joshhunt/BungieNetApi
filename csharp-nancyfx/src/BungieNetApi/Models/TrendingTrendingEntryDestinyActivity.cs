using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// TrendingTrendingEntryDestinyActivity
    /// </summary>
    public sealed class TrendingTrendingEntryDestinyActivity:  IEquatable<TrendingTrendingEntryDestinyActivity>
    { 
        /// <summary>
        /// ActivityHash
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// Status
        /// </summary>
        public DestinyActivitiesDestinyPublicActivityStatus Status { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use TrendingTrendingEntryDestinyActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public TrendingTrendingEntryDestinyActivity()
        {
        }

        private TrendingTrendingEntryDestinyActivity(int? ActivityHash, DestinyActivitiesDestinyPublicActivityStatus Status)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.Status = Status;
            
        }

        /// <summary>
        /// Returns builder of TrendingTrendingEntryDestinyActivity.
        /// </summary>
        /// <returns>TrendingTrendingEntryDestinyActivityBuilder</returns>
        public static TrendingTrendingEntryDestinyActivityBuilder Builder()
        {
            return new TrendingTrendingEntryDestinyActivityBuilder();
        }

        /// <summary>
        /// Returns TrendingTrendingEntryDestinyActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>TrendingTrendingEntryDestinyActivityBuilder</returns>
        public TrendingTrendingEntryDestinyActivityBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .Status(Status);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(TrendingTrendingEntryDestinyActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (TrendingTrendingEntryDestinyActivity.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryDestinyActivity</param>
        /// <param name="right">Compared (TrendingTrendingEntryDestinyActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (TrendingTrendingEntryDestinyActivity left, TrendingTrendingEntryDestinyActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (TrendingTrendingEntryDestinyActivity.
        /// </summary>
        /// <param name="left">Compared (TrendingTrendingEntryDestinyActivity</param>
        /// <param name="right">Compared (TrendingTrendingEntryDestinyActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (TrendingTrendingEntryDestinyActivity left, TrendingTrendingEntryDestinyActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of TrendingTrendingEntryDestinyActivity.
        /// </summary>
        public sealed class TrendingTrendingEntryDestinyActivityBuilder
        {
            private int? _ActivityHash;
            private DestinyActivitiesDestinyPublicActivityStatus _Status;

            internal TrendingTrendingEntryDestinyActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyActivity.ActivityHash property.
            /// </summary>
            /// <param name="value">ActivityHash</param>
            public TrendingTrendingEntryDestinyActivityBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for TrendingTrendingEntryDestinyActivity.Status property.
            /// </summary>
            /// <param name="value">Status</param>
            public TrendingTrendingEntryDestinyActivityBuilder Status(DestinyActivitiesDestinyPublicActivityStatus value)
            {
                _Status = value;
                return this;
            }


            /// <summary>
            /// Builds instance of TrendingTrendingEntryDestinyActivity.
            /// </summary>
            /// <returns>TrendingTrendingEntryDestinyActivity</returns>
            public TrendingTrendingEntryDestinyActivity Build()
            {
                Validate();
                return new TrendingTrendingEntryDestinyActivity(
                    ActivityHash: _ActivityHash,
                    Status: _Status
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}