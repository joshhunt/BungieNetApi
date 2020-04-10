using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents this player&#39;s personal completion status for the Activity under a Milestone, if the activity has trackable completion and progress information. (most activities won&#39;t, or the concept won&#39;t apply. For instance, it makes sense to talk about a tier of a raid as being Completed or having progress, but it doesn&#39;t make sense to talk about a Crucible Playlist in those terms.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneActivityCompletionStatus:  IEquatable<DestinyMilestonesDestinyMilestoneActivityCompletionStatus>
    { 
        /// <summary>
        /// If the activity has been \&quot;completed\&quot;, that information will be returned here.
        /// </summary>
        public bool? Completed { get; private set; }

        /// <summary>
        /// If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneActivityCompletionStatus.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneActivityCompletionStatus()
        {
        }

        private DestinyMilestonesDestinyMilestoneActivityCompletionStatus(bool? Completed, List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases)
        {
            
            this.Completed = Completed;
            
            this.Phases = Phases;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneActivityCompletionStatus.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder</returns>
        public DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder With()
        {
            return Builder()
                .Completed(Completed)
                .Phases(Phases);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneActivityCompletionStatus other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneActivityCompletionStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivityCompletionStatus</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivityCompletionStatus</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneActivityCompletionStatus left, DestinyMilestonesDestinyMilestoneActivityCompletionStatus right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneActivityCompletionStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivityCompletionStatus</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivityCompletionStatus</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneActivityCompletionStatus left, DestinyMilestonesDestinyMilestoneActivityCompletionStatus right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneActivityCompletionStatus.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder
        {
            private bool? _Completed;
            private List<DestinyMilestonesDestinyMilestoneActivityPhase> _Phases;

            internal DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityCompletionStatus.Completed property.
            /// </summary>
            /// <param name="value">If the activity has been \&quot;completed\&quot;, that information will be returned here.</param>
            public DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder Completed(bool? value)
            {
                _Completed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityCompletionStatus.Phases property.
            /// </summary>
            /// <param name="value">If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.</param>
            public DestinyMilestonesDestinyMilestoneActivityCompletionStatusBuilder Phases(List<DestinyMilestonesDestinyMilestoneActivityPhase> value)
            {
                _Phases = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneActivityCompletionStatus.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneActivityCompletionStatus</returns>
            public DestinyMilestonesDestinyMilestoneActivityCompletionStatus Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneActivityCompletionStatus(
                    Completed: _Completed,
                    Phases: _Phases
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}