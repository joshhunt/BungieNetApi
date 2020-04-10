using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Summary information about the activity that was played.
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsActivity:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsActivity>
    { 
        /// <summary>
        /// The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to do over, it&#39;d be named activityHash. Too late now.
        /// </summary>
        public int? ReferenceId { get; private set; }

        /// <summary>
        /// The unique hash identifier of the DestinyActivityDefinition that was played.
        /// </summary>
        public int? DirectorActivityHash { get; private set; }

        /// <summary>
        /// The unique identifier for this *specific* match that was played.  This value can be used to get additional data about this activity such as who else was playing via the GetPostGameCarnageReport endpoint.
        /// </summary>
        public long? InstanceId { get; private set; }

        /// <summary>
        /// Indicates the most specific game mode of the activity that we could find.
        /// </summary>
        public int? Mode { get; private set; }

        /// <summary>
        /// The list of all Activity Modes to which this activity applies, including aggregates. This will let you see, for example, whether the activity was both Clash and part of the Trials of the Nine event.
        /// </summary>
        public List<int?> Modes { get; private set; }

        /// <summary>
        /// Whether or not the match was a private match.
        /// </summary>
        public bool? IsPrivate { get; private set; }

        /// <summary>
        /// The Membership Type indicating the platform on which this match was played.
        /// </summary>
        public int? MembershipType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsActivity()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsActivity(int? ReferenceId, int? DirectorActivityHash, long? InstanceId, int? Mode, List<int?> Modes, bool? IsPrivate, int? MembershipType)
        {
            
            this.ReferenceId = ReferenceId;
            
            this.DirectorActivityHash = DirectorActivityHash;
            
            this.InstanceId = InstanceId;
            
            this.Mode = Mode;
            
            this.Modes = Modes;
            
            this.IsPrivate = IsPrivate;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsActivity.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder With()
        {
            return Builder()
                .ReferenceId(ReferenceId)
                .DirectorActivityHash(DirectorActivityHash)
                .InstanceId(InstanceId)
                .Mode(Mode)
                .Modes(Modes)
                .IsPrivate(IsPrivate)
                .MembershipType(MembershipType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsActivity</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsActivity left, DestinyHistoricalStatsDestinyHistoricalStatsActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsActivity</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsActivity left, DestinyHistoricalStatsDestinyHistoricalStatsActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsActivity.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder
        {
            private int? _ReferenceId;
            private int? _DirectorActivityHash;
            private long? _InstanceId;
            private int? _Mode;
            private List<int?> _Modes;
            private bool? _IsPrivate;
            private int? _MembershipType;

            internal DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.ReferenceId property.
            /// </summary>
            /// <param name="value">The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to do over, it&#39;d be named activityHash. Too late now.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder ReferenceId(int? value)
            {
                _ReferenceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.DirectorActivityHash property.
            /// </summary>
            /// <param name="value">The unique hash identifier of the DestinyActivityDefinition that was played.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder DirectorActivityHash(int? value)
            {
                _DirectorActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.InstanceId property.
            /// </summary>
            /// <param name="value">The unique identifier for this *specific* match that was played.  This value can be used to get additional data about this activity such as who else was playing via the GetPostGameCarnageReport endpoint.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder InstanceId(long? value)
            {
                _InstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.Mode property.
            /// </summary>
            /// <param name="value">Indicates the most specific game mode of the activity that we could find.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder Mode(int? value)
            {
                _Mode = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.Modes property.
            /// </summary>
            /// <param name="value">The list of all Activity Modes to which this activity applies, including aggregates. This will let you see, for example, whether the activity was both Clash and part of the Trials of the Nine event.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder Modes(List<int?> value)
            {
                _Modes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.IsPrivate property.
            /// </summary>
            /// <param name="value">Whether or not the match was a private match.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder IsPrivate(bool? value)
            {
                _IsPrivate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsActivity.MembershipType property.
            /// </summary>
            /// <param name="value">The Membership Type indicating the platform on which this match was played.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivityBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsActivity.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsActivity</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsActivity Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsActivity(
                    ReferenceId: _ReferenceId,
                    DirectorActivityHash: _DirectorActivityHash,
                    InstanceId: _InstanceId,
                    Mode: _Mode,
                    Modes: _Modes,
                    IsPrivate: _IsPrivate,
                    MembershipType: _MembershipType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}