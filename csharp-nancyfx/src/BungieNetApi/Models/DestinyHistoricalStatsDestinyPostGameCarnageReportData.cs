using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyPostGameCarnageReportData
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportData:  IEquatable<DestinyHistoricalStatsDestinyPostGameCarnageReportData>
    { 
        /// <summary>
        /// Date and time for the activity.
        /// </summary>
        public DateTime? Period { get; private set; }

        /// <summary>
        /// If this activity has \&quot;phases\&quot;, this is the phase at which the activity was started.
        /// </summary>
        public int? StartingPhaseIndex { get; private set; }

        /// <summary>
        /// Details about the activity.
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails { get; private set; }

        /// <summary>
        /// Collection of players and their data for this activity.
        /// </summary>
        public List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> Entries { get; private set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        public List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> Teams { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyPostGameCarnageReportData.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyPostGameCarnageReportData()
        {
        }

        private DestinyHistoricalStatsDestinyPostGameCarnageReportData(DateTime? Period, int? StartingPhaseIndex, DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails, List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> Entries, List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> Teams)
        {
            
            this.Period = Period;
            
            this.StartingPhaseIndex = StartingPhaseIndex;
            
            this.ActivityDetails = ActivityDetails;
            
            this.Entries = Entries;
            
            this.Teams = Teams;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyPostGameCarnageReportData.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder</returns>
        public static DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder</returns>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder With()
        {
            return Builder()
                .Period(Period)
                .StartingPhaseIndex(StartingPhaseIndex)
                .ActivityDetails(ActivityDetails)
                .Entries(Entries)
                .Teams(Teams);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyPostGameCarnageReportData other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportData.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportData</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportData</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyPostGameCarnageReportData left, DestinyHistoricalStatsDestinyPostGameCarnageReportData right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportData.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportData</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportData</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyPostGameCarnageReportData left, DestinyHistoricalStatsDestinyPostGameCarnageReportData right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyPostGameCarnageReportData.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder
        {
            private DateTime? _Period;
            private int? _StartingPhaseIndex;
            private DestinyHistoricalStatsDestinyHistoricalStatsActivity _ActivityDetails;
            private List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> _Entries;
            private List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> _Teams;

            internal DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportData.Period property.
            /// </summary>
            /// <param name="value">Date and time for the activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder Period(DateTime? value)
            {
                _Period = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportData.StartingPhaseIndex property.
            /// </summary>
            /// <param name="value">If this activity has \&quot;phases\&quot;, this is the phase at which the activity was started.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder StartingPhaseIndex(int? value)
            {
                _StartingPhaseIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportData.ActivityDetails property.
            /// </summary>
            /// <param name="value">Details about the activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder ActivityDetails(DestinyHistoricalStatsDestinyHistoricalStatsActivity value)
            {
                _ActivityDetails = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportData.Entries property.
            /// </summary>
            /// <param name="value">Collection of players and their data for this activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder Entries(List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> value)
            {
                _Entries = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportData.Teams property.
            /// </summary>
            /// <param name="value">Collection of stats for the player in this activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportDataBuilder Teams(List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> value)
            {
                _Teams = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyPostGameCarnageReportData.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportData</returns>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportData Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyPostGameCarnageReportData(
                    Period: _Period,
                    StartingPhaseIndex: _StartingPhaseIndex,
                    ActivityDetails: _ActivityDetails,
                    Entries: _Entries,
                    Teams: _Teams
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}