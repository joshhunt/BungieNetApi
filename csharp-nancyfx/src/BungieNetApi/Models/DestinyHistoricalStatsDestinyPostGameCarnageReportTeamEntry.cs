using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry:  IEquatable<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry>
    { 
        /// <summary>
        /// Integer ID for the team.
        /// </summary>
        public int? TeamId { get; private set; }

        /// <summary>
        /// Team&#39;s standing relative to other teams.
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValue Standing { get; private set; }

        /// <summary>
        /// Score earned by the team
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValue Score { get; private set; }

        /// <summary>
        /// Alpha or Bravo
        /// </summary>
        public string TeamName { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry()
        {
        }

        private DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry(int? TeamId, DestinyHistoricalStatsDestinyHistoricalStatsValue Standing, DestinyHistoricalStatsDestinyHistoricalStatsValue Score, string TeamName)
        {
            
            this.TeamId = TeamId;
            
            this.Standing = Standing;
            
            this.Score = Score;
            
            this.TeamName = TeamName;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder</returns>
        public static DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder</returns>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder With()
        {
            return Builder()
                .TeamId(TeamId)
                .Standing(Standing)
                .Score(Score)
                .TeamName(TeamName);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry left, DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry left, DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder
        {
            private int? _TeamId;
            private DestinyHistoricalStatsDestinyHistoricalStatsValue _Standing;
            private DestinyHistoricalStatsDestinyHistoricalStatsValue _Score;
            private string _TeamName;

            internal DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.TeamId property.
            /// </summary>
            /// <param name="value">Integer ID for the team.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder TeamId(int? value)
            {
                _TeamId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.Standing property.
            /// </summary>
            /// <param name="value">Team&#39;s standing relative to other teams.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder Standing(DestinyHistoricalStatsDestinyHistoricalStatsValue value)
            {
                _Standing = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.Score property.
            /// </summary>
            /// <param name="value">Score earned by the team</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder Score(DestinyHistoricalStatsDestinyHistoricalStatsValue value)
            {
                _Score = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.TeamName property.
            /// </summary>
            /// <param name="value">Alpha or Bravo</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntryBuilder TeamName(string value)
            {
                _TeamName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry</returns>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry(
                    TeamId: _TeamId,
                    Standing: _Standing,
                    Score: _Score,
                    TeamName: _TeamName
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}