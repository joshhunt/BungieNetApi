using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsRecordsDestinyRecordComponent
    /// </summary>
    public sealed class DestinyComponentsRecordsDestinyRecordComponent:  IEquatable<DestinyComponentsRecordsDestinyRecordComponent>
    { 
        /// <summary>
        /// State
        /// </summary>
        public int? State { get; private set; }

        /// <summary>
        /// Objectives
        /// </summary>
        public List<DestinyQuestsDestinyObjectiveProgress> Objectives { get; private set; }

        /// <summary>
        /// IntervalObjectives
        /// </summary>
        public List<DestinyQuestsDestinyObjectiveProgress> IntervalObjectives { get; private set; }

        /// <summary>
        /// IntervalsRedeemedCount
        /// </summary>
        public int? IntervalsRedeemedCount { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsRecordsDestinyRecordComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsRecordsDestinyRecordComponent()
        {
        }

        private DestinyComponentsRecordsDestinyRecordComponent(int? State, List<DestinyQuestsDestinyObjectiveProgress> Objectives, List<DestinyQuestsDestinyObjectiveProgress> IntervalObjectives, int? IntervalsRedeemedCount)
        {
            
            this.State = State;
            
            this.Objectives = Objectives;
            
            this.IntervalObjectives = IntervalObjectives;
            
            this.IntervalsRedeemedCount = IntervalsRedeemedCount;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsRecordsDestinyRecordComponent.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyRecordComponentBuilder</returns>
        public static DestinyComponentsRecordsDestinyRecordComponentBuilder Builder()
        {
            return new DestinyComponentsRecordsDestinyRecordComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsRecordsDestinyRecordComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyRecordComponentBuilder</returns>
        public DestinyComponentsRecordsDestinyRecordComponentBuilder With()
        {
            return Builder()
                .State(State)
                .Objectives(Objectives)
                .IntervalObjectives(IntervalObjectives)
                .IntervalsRedeemedCount(IntervalsRedeemedCount);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsRecordsDestinyRecordComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsRecordsDestinyRecordComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyRecordComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyRecordComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsRecordsDestinyRecordComponent left, DestinyComponentsRecordsDestinyRecordComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsRecordsDestinyRecordComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyRecordComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyRecordComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsRecordsDestinyRecordComponent left, DestinyComponentsRecordsDestinyRecordComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsRecordsDestinyRecordComponent.
        /// </summary>
        public sealed class DestinyComponentsRecordsDestinyRecordComponentBuilder
        {
            private int? _State;
            private List<DestinyQuestsDestinyObjectiveProgress> _Objectives;
            private List<DestinyQuestsDestinyObjectiveProgress> _IntervalObjectives;
            private int? _IntervalsRedeemedCount;

            internal DestinyComponentsRecordsDestinyRecordComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordComponent.State property.
            /// </summary>
            /// <param name="value">State</param>
            public DestinyComponentsRecordsDestinyRecordComponentBuilder State(int? value)
            {
                _State = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordComponent.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyComponentsRecordsDestinyRecordComponentBuilder Objectives(List<DestinyQuestsDestinyObjectiveProgress> value)
            {
                _Objectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordComponent.IntervalObjectives property.
            /// </summary>
            /// <param name="value">IntervalObjectives</param>
            public DestinyComponentsRecordsDestinyRecordComponentBuilder IntervalObjectives(List<DestinyQuestsDestinyObjectiveProgress> value)
            {
                _IntervalObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordComponent.IntervalsRedeemedCount property.
            /// </summary>
            /// <param name="value">IntervalsRedeemedCount</param>
            public DestinyComponentsRecordsDestinyRecordComponentBuilder IntervalsRedeemedCount(int? value)
            {
                _IntervalsRedeemedCount = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsRecordsDestinyRecordComponent.
            /// </summary>
            /// <returns>DestinyComponentsRecordsDestinyRecordComponent</returns>
            public DestinyComponentsRecordsDestinyRecordComponent Build()
            {
                Validate();
                return new DestinyComponentsRecordsDestinyRecordComponent(
                    State: _State,
                    Objectives: _Objectives,
                    IntervalObjectives: _IntervalObjectives,
                    IntervalsRedeemedCount: _IntervalsRedeemedCount
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}