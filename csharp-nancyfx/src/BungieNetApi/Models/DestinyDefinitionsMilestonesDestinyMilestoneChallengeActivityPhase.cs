using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase>
    { 
        /// <summary>
        /// The hash identifier of the activity&#39;s phase.
        /// </summary>
        public int? PhaseHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase(int? PhaseHash)
        {
            
            this.PhaseHash = PhaseHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder
        {
            private int? _PhaseHash;

            internal DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.PhaseHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the activity&#39;s phase.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhaseBuilder PhaseHash(int? value)
            {
                _PhaseHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase(
                    PhaseHash: _PhaseHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}