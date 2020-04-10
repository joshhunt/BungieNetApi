using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Returns data about a character&#39;s status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
    /// </summary>
    public sealed class DestinyQuestsDestinyObjectiveProgress:  IEquatable<DestinyQuestsDestinyObjectiveProgress>
    { 
        /// <summary>
        /// The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.
        /// </summary>
        public int? ObjectiveHash { get; private set; }

        /// <summary>
        /// If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.
        /// </summary>
        public int? DestinationHash { get; private set; }

        /// <summary>
        /// If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.
        /// </summary>
        public int? Progress { get; private set; }

        /// <summary>
        /// As of Forsaken, objectives&#39; completion value is determined dynamically at runtime.  This value represents the threshold of progress you need to surpass in order for this objective to be considered \&quot;complete\&quot;.  If you were using objective data, switch from using the DestinyObjectiveDefinition&#39;s \&quot;completionValue\&quot; to this value.
        /// </summary>
        public int? CompletionValue { get; private set; }

        /// <summary>
        /// Whether or not the Objective is completed.
        /// </summary>
        public bool? Complete { get; private set; }

        /// <summary>
        /// If this is true, the objective is visible in-game. Otherwise, it&#39;s not yet visible to the player. Up to you if you want to honor this property.
        /// </summary>
        public bool? Visible { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyQuestsDestinyObjectiveProgress.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyQuestsDestinyObjectiveProgress()
        {
        }

        private DestinyQuestsDestinyObjectiveProgress(int? ObjectiveHash, int? DestinationHash, int? ActivityHash, int? Progress, int? CompletionValue, bool? Complete, bool? Visible)
        {
            
            this.ObjectiveHash = ObjectiveHash;
            
            this.DestinationHash = DestinationHash;
            
            this.ActivityHash = ActivityHash;
            
            this.Progress = Progress;
            
            this.CompletionValue = CompletionValue;
            
            this.Complete = Complete;
            
            this.Visible = Visible;
            
        }

        /// <summary>
        /// Returns builder of DestinyQuestsDestinyObjectiveProgress.
        /// </summary>
        /// <returns>DestinyQuestsDestinyObjectiveProgressBuilder</returns>
        public static DestinyQuestsDestinyObjectiveProgressBuilder Builder()
        {
            return new DestinyQuestsDestinyObjectiveProgressBuilder();
        }

        /// <summary>
        /// Returns DestinyQuestsDestinyObjectiveProgressBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyQuestsDestinyObjectiveProgressBuilder</returns>
        public DestinyQuestsDestinyObjectiveProgressBuilder With()
        {
            return Builder()
                .ObjectiveHash(ObjectiveHash)
                .DestinationHash(DestinationHash)
                .ActivityHash(ActivityHash)
                .Progress(Progress)
                .CompletionValue(CompletionValue)
                .Complete(Complete)
                .Visible(Visible);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyQuestsDestinyObjectiveProgress other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyQuestsDestinyObjectiveProgress.
        /// </summary>
        /// <param name="left">Compared (DestinyQuestsDestinyObjectiveProgress</param>
        /// <param name="right">Compared (DestinyQuestsDestinyObjectiveProgress</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyQuestsDestinyObjectiveProgress left, DestinyQuestsDestinyObjectiveProgress right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyQuestsDestinyObjectiveProgress.
        /// </summary>
        /// <param name="left">Compared (DestinyQuestsDestinyObjectiveProgress</param>
        /// <param name="right">Compared (DestinyQuestsDestinyObjectiveProgress</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyQuestsDestinyObjectiveProgress left, DestinyQuestsDestinyObjectiveProgress right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyQuestsDestinyObjectiveProgress.
        /// </summary>
        public sealed class DestinyQuestsDestinyObjectiveProgressBuilder
        {
            private int? _ObjectiveHash;
            private int? _DestinationHash;
            private int? _ActivityHash;
            private int? _Progress;
            private int? _CompletionValue;
            private bool? _Complete;
            private bool? _Visible;

            internal DestinyQuestsDestinyObjectiveProgressBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.ObjectiveHash property.
            /// </summary>
            /// <param name="value">The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.DestinationHash property.
            /// </summary>
            /// <param name="value">If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.ActivityHash property.
            /// </summary>
            /// <param name="value">If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.Progress property.
            /// </summary>
            /// <param name="value">If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder Progress(int? value)
            {
                _Progress = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.CompletionValue property.
            /// </summary>
            /// <param name="value">As of Forsaken, objectives&#39; completion value is determined dynamically at runtime.  This value represents the threshold of progress you need to surpass in order for this objective to be considered \&quot;complete\&quot;.  If you were using objective data, switch from using the DestinyObjectiveDefinition&#39;s \&quot;completionValue\&quot; to this value.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder CompletionValue(int? value)
            {
                _CompletionValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.Complete property.
            /// </summary>
            /// <param name="value">Whether or not the Objective is completed.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder Complete(bool? value)
            {
                _Complete = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyObjectiveProgress.Visible property.
            /// </summary>
            /// <param name="value">If this is true, the objective is visible in-game. Otherwise, it&#39;s not yet visible to the player. Up to you if you want to honor this property.</param>
            public DestinyQuestsDestinyObjectiveProgressBuilder Visible(bool? value)
            {
                _Visible = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyQuestsDestinyObjectiveProgress.
            /// </summary>
            /// <returns>DestinyQuestsDestinyObjectiveProgress</returns>
            public DestinyQuestsDestinyObjectiveProgress Build()
            {
                Validate();
                return new DestinyQuestsDestinyObjectiveProgress(
                    ObjectiveHash: _ObjectiveHash,
                    DestinationHash: _DestinationHash,
                    ActivityHash: _ActivityHash,
                    Progress: _Progress,
                    CompletionValue: _CompletionValue,
                    Complete: _Complete,
                    Visible: _Visible
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}