using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents the status and other related information for a challenge that is - or was - available to a player.   A challenge is a bonus objective, generally tacked onto Quests or Activities, that provide additional variations on play.
    /// </summary>
    public sealed class DestinyChallengesDestinyChallengeStatus:  IEquatable<DestinyChallengesDestinyChallengeStatus>
    { 
        /// <summary>
        /// The progress - including completion status - of the active challenge.
        /// </summary>
        public DestinyQuestsDestinyObjectiveProgress Objective { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyChallengesDestinyChallengeStatus.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyChallengesDestinyChallengeStatus()
        {
        }

        private DestinyChallengesDestinyChallengeStatus(DestinyQuestsDestinyObjectiveProgress Objective)
        {
            
            this.Objective = Objective;
            
        }

        /// <summary>
        /// Returns builder of DestinyChallengesDestinyChallengeStatus.
        /// </summary>
        /// <returns>DestinyChallengesDestinyChallengeStatusBuilder</returns>
        public static DestinyChallengesDestinyChallengeStatusBuilder Builder()
        {
            return new DestinyChallengesDestinyChallengeStatusBuilder();
        }

        /// <summary>
        /// Returns DestinyChallengesDestinyChallengeStatusBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyChallengesDestinyChallengeStatusBuilder</returns>
        public DestinyChallengesDestinyChallengeStatusBuilder With()
        {
            return Builder()
                .Objective(Objective);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyChallengesDestinyChallengeStatus other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyChallengesDestinyChallengeStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyChallengesDestinyChallengeStatus</param>
        /// <param name="right">Compared (DestinyChallengesDestinyChallengeStatus</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyChallengesDestinyChallengeStatus left, DestinyChallengesDestinyChallengeStatus right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyChallengesDestinyChallengeStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyChallengesDestinyChallengeStatus</param>
        /// <param name="right">Compared (DestinyChallengesDestinyChallengeStatus</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyChallengesDestinyChallengeStatus left, DestinyChallengesDestinyChallengeStatus right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyChallengesDestinyChallengeStatus.
        /// </summary>
        public sealed class DestinyChallengesDestinyChallengeStatusBuilder
        {
            private DestinyQuestsDestinyObjectiveProgress _Objective;

            internal DestinyChallengesDestinyChallengeStatusBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyChallengesDestinyChallengeStatus.Objective property.
            /// </summary>
            /// <param name="value">The progress - including completion status - of the active challenge.</param>
            public DestinyChallengesDestinyChallengeStatusBuilder Objective(DestinyQuestsDestinyObjectiveProgress value)
            {
                _Objective = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyChallengesDestinyChallengeStatus.
            /// </summary>
            /// <returns>DestinyChallengesDestinyChallengeStatus</returns>
            public DestinyChallengesDestinyChallengeStatus Build()
            {
                Validate();
                return new DestinyChallengesDestinyChallengeStatus(
                    Objective: _Objective
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}