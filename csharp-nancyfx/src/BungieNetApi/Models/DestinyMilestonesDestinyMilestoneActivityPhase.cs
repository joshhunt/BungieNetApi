using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents whatever information we can return about an explicit phase in an activity. In the future, I hope we&#39;ll have more than just \&quot;guh, you done gone and did something,\&quot; but for the forseeable future that&#39;s all we&#39;ve got. I&#39;m making it more than just a list of booleans out of that overly-optimistic hope.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneActivityPhase:  IEquatable<DestinyMilestonesDestinyMilestoneActivityPhase>
    { 
        /// <summary>
        /// Indicates if the phase has been completed.
        /// </summary>
        public bool? Complete { get; private set; }

        /// <summary>
        /// In DestinyActivityDefinition, if the activity has phases, there will be a set of phases defined in the \&quot;insertionPoints\&quot; property. This is the hash that maps to that phase.
        /// </summary>
        public int? PhaseHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneActivityPhase.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneActivityPhase()
        {
        }

        private DestinyMilestonesDestinyMilestoneActivityPhase(bool? Complete, int? PhaseHash)
        {
            
            this.Complete = Complete;
            
            this.PhaseHash = PhaseHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneActivityPhase.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityPhaseBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneActivityPhaseBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneActivityPhaseBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneActivityPhaseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityPhaseBuilder</returns>
        public DestinyMilestonesDestinyMilestoneActivityPhaseBuilder With()
        {
            return Builder()
                .Complete(Complete)
                .PhaseHash(PhaseHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneActivityPhase other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneActivityPhase.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivityPhase</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivityPhase</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneActivityPhase left, DestinyMilestonesDestinyMilestoneActivityPhase right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneActivityPhase.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivityPhase</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivityPhase</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneActivityPhase left, DestinyMilestonesDestinyMilestoneActivityPhase right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneActivityPhase.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneActivityPhaseBuilder
        {
            private bool? _Complete;
            private int? _PhaseHash;

            internal DestinyMilestonesDestinyMilestoneActivityPhaseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityPhase.Complete property.
            /// </summary>
            /// <param name="value">Indicates if the phase has been completed.</param>
            public DestinyMilestonesDestinyMilestoneActivityPhaseBuilder Complete(bool? value)
            {
                _Complete = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityPhase.PhaseHash property.
            /// </summary>
            /// <param name="value">In DestinyActivityDefinition, if the activity has phases, there will be a set of phases defined in the \&quot;insertionPoints\&quot; property. This is the hash that maps to that phase.</param>
            public DestinyMilestonesDestinyMilestoneActivityPhaseBuilder PhaseHash(int? value)
            {
                _PhaseHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneActivityPhase.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneActivityPhase</returns>
            public DestinyMilestonesDestinyMilestoneActivityPhase Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneActivityPhase(
                    Complete: _Complete,
                    PhaseHash: _PhaseHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}