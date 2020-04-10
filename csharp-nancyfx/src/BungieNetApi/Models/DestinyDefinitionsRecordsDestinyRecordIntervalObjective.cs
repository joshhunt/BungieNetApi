using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsRecordsDestinyRecordIntervalObjective
    /// </summary>
    public sealed class DestinyDefinitionsRecordsDestinyRecordIntervalObjective:  IEquatable<DestinyDefinitionsRecordsDestinyRecordIntervalObjective>
    { 
        /// <summary>
        /// IntervalObjectiveHash
        /// </summary>
        public int? IntervalObjectiveHash { get; private set; }

        /// <summary>
        /// IntervalScoreValue
        /// </summary>
        public int? IntervalScoreValue { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsRecordsDestinyRecordIntervalObjective.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsDestinyRecordIntervalObjective()
        {
        }

        private DestinyDefinitionsRecordsDestinyRecordIntervalObjective(int? IntervalObjectiveHash, int? IntervalScoreValue)
        {
            
            this.IntervalObjectiveHash = IntervalObjectiveHash;
            
            this.IntervalScoreValue = IntervalScoreValue;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsDestinyRecordIntervalObjective.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder</returns>
        public static DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder Builder()
        {
            return new DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder</returns>
        public DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder With()
        {
            return Builder()
                .IntervalObjectiveHash(IntervalObjectiveHash)
                .IntervalScoreValue(IntervalScoreValue);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsRecordsDestinyRecordIntervalObjective other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsDestinyRecordIntervalObjective.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalObjective</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalObjective</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsDestinyRecordIntervalObjective left, DestinyDefinitionsRecordsDestinyRecordIntervalObjective right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsDestinyRecordIntervalObjective.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalObjective</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalObjective</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsDestinyRecordIntervalObjective left, DestinyDefinitionsRecordsDestinyRecordIntervalObjective right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsDestinyRecordIntervalObjective.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder
        {
            private int? _IntervalObjectiveHash;
            private int? _IntervalScoreValue;

            internal DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordIntervalObjective.IntervalObjectiveHash property.
            /// </summary>
            /// <param name="value">IntervalObjectiveHash</param>
            public DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder IntervalObjectiveHash(int? value)
            {
                _IntervalObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordIntervalObjective.IntervalScoreValue property.
            /// </summary>
            /// <param name="value">IntervalScoreValue</param>
            public DestinyDefinitionsRecordsDestinyRecordIntervalObjectiveBuilder IntervalScoreValue(int? value)
            {
                _IntervalScoreValue = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsDestinyRecordIntervalObjective.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsDestinyRecordIntervalObjective</returns>
            public DestinyDefinitionsRecordsDestinyRecordIntervalObjective Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsDestinyRecordIntervalObjective(
                    IntervalObjectiveHash: _IntervalObjectiveHash,
                    IntervalScoreValue: _IntervalScoreValue
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}