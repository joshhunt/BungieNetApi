using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsRecordsDestinyRecordIntervalBlock
    /// </summary>
    public sealed class DestinyDefinitionsRecordsDestinyRecordIntervalBlock:  IEquatable<DestinyDefinitionsRecordsDestinyRecordIntervalBlock>
    { 
        /// <summary>
        /// IntervalObjectives
        /// </summary>
        public List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> IntervalObjectives { get; private set; }

        /// <summary>
        /// OriginalObjectiveArrayInsertionIndex
        /// </summary>
        public int? OriginalObjectiveArrayInsertionIndex { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsRecordsDestinyRecordIntervalBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsDestinyRecordIntervalBlock()
        {
        }

        private DestinyDefinitionsRecordsDestinyRecordIntervalBlock(List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> IntervalObjectives, int? OriginalObjectiveArrayInsertionIndex)
        {
            
            this.IntervalObjectives = IntervalObjectives;
            
            this.OriginalObjectiveArrayInsertionIndex = OriginalObjectiveArrayInsertionIndex;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsDestinyRecordIntervalBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder</returns>
        public static DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder Builder()
        {
            return new DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder</returns>
        public DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder With()
        {
            return Builder()
                .IntervalObjectives(IntervalObjectives)
                .OriginalObjectiveArrayInsertionIndex(OriginalObjectiveArrayInsertionIndex);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsRecordsDestinyRecordIntervalBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsDestinyRecordIntervalBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsDestinyRecordIntervalBlock left, DestinyDefinitionsRecordsDestinyRecordIntervalBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsDestinyRecordIntervalBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordIntervalBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsDestinyRecordIntervalBlock left, DestinyDefinitionsRecordsDestinyRecordIntervalBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsDestinyRecordIntervalBlock.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder
        {
            private List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> _IntervalObjectives;
            private int? _OriginalObjectiveArrayInsertionIndex;

            internal DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordIntervalBlock.IntervalObjectives property.
            /// </summary>
            /// <param name="value">IntervalObjectives</param>
            public DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder IntervalObjectives(List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> value)
            {
                _IntervalObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordIntervalBlock.OriginalObjectiveArrayInsertionIndex property.
            /// </summary>
            /// <param name="value">OriginalObjectiveArrayInsertionIndex</param>
            public DestinyDefinitionsRecordsDestinyRecordIntervalBlockBuilder OriginalObjectiveArrayInsertionIndex(int? value)
            {
                _OriginalObjectiveArrayInsertionIndex = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsDestinyRecordIntervalBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsDestinyRecordIntervalBlock</returns>
            public DestinyDefinitionsRecordsDestinyRecordIntervalBlock Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsDestinyRecordIntervalBlock(
                    IntervalObjectives: _IntervalObjectives,
                    OriginalObjectiveArrayInsertionIndex: _OriginalObjectiveArrayInsertionIndex
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}