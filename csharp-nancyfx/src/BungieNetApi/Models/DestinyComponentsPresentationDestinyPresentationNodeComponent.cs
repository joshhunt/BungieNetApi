using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsPresentationDestinyPresentationNodeComponent
    /// </summary>
    public sealed class DestinyComponentsPresentationDestinyPresentationNodeComponent:  IEquatable<DestinyComponentsPresentationDestinyPresentationNodeComponent>
    { 
        /// <summary>
        /// State
        /// </summary>
        public int? State { get; private set; }

        /// <summary>
        /// An optional property: presentation nodes MAY have objectives, which can be used to infer more human readable data about the progress. However, progressValue and completionValue ought to be considered the canonical values for progress on Progression Nodes.
        /// </summary>
        public DestinyQuestsDestinyObjectiveProgress Objective { get; private set; }

        /// <summary>
        /// How much of the presentation node is considered to be completed so far by the given character/profile.
        /// </summary>
        public int? ProgressValue { get; private set; }

        /// <summary>
        /// The value at which the presentation node is considered to be completed.
        /// </summary>
        public int? CompletionValue { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsPresentationDestinyPresentationNodeComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsPresentationDestinyPresentationNodeComponent()
        {
        }

        private DestinyComponentsPresentationDestinyPresentationNodeComponent(int? State, DestinyQuestsDestinyObjectiveProgress Objective, int? ProgressValue, int? CompletionValue)
        {
            
            this.State = State;
            
            this.Objective = Objective;
            
            this.ProgressValue = ProgressValue;
            
            this.CompletionValue = CompletionValue;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsPresentationDestinyPresentationNodeComponent.
        /// </summary>
        /// <returns>DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder</returns>
        public static DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder Builder()
        {
            return new DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder</returns>
        public DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder With()
        {
            return Builder()
                .State(State)
                .Objective(Objective)
                .ProgressValue(ProgressValue)
                .CompletionValue(CompletionValue);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsPresentationDestinyPresentationNodeComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsPresentationDestinyPresentationNodeComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsPresentationDestinyPresentationNodeComponent</param>
        /// <param name="right">Compared (DestinyComponentsPresentationDestinyPresentationNodeComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsPresentationDestinyPresentationNodeComponent left, DestinyComponentsPresentationDestinyPresentationNodeComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsPresentationDestinyPresentationNodeComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsPresentationDestinyPresentationNodeComponent</param>
        /// <param name="right">Compared (DestinyComponentsPresentationDestinyPresentationNodeComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsPresentationDestinyPresentationNodeComponent left, DestinyComponentsPresentationDestinyPresentationNodeComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsPresentationDestinyPresentationNodeComponent.
        /// </summary>
        public sealed class DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder
        {
            private int? _State;
            private DestinyQuestsDestinyObjectiveProgress _Objective;
            private int? _ProgressValue;
            private int? _CompletionValue;

            internal DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsPresentationDestinyPresentationNodeComponent.State property.
            /// </summary>
            /// <param name="value">State</param>
            public DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder State(int? value)
            {
                _State = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsPresentationDestinyPresentationNodeComponent.Objective property.
            /// </summary>
            /// <param name="value">An optional property: presentation nodes MAY have objectives, which can be used to infer more human readable data about the progress. However, progressValue and completionValue ought to be considered the canonical values for progress on Progression Nodes.</param>
            public DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder Objective(DestinyQuestsDestinyObjectiveProgress value)
            {
                _Objective = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsPresentationDestinyPresentationNodeComponent.ProgressValue property.
            /// </summary>
            /// <param name="value">How much of the presentation node is considered to be completed so far by the given character/profile.</param>
            public DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder ProgressValue(int? value)
            {
                _ProgressValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsPresentationDestinyPresentationNodeComponent.CompletionValue property.
            /// </summary>
            /// <param name="value">The value at which the presentation node is considered to be completed.</param>
            public DestinyComponentsPresentationDestinyPresentationNodeComponentBuilder CompletionValue(int? value)
            {
                _CompletionValue = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsPresentationDestinyPresentationNodeComponent.
            /// </summary>
            /// <returns>DestinyComponentsPresentationDestinyPresentationNodeComponent</returns>
            public DestinyComponentsPresentationDestinyPresentationNodeComponent Build()
            {
                Validate();
                return new DestinyComponentsPresentationDestinyPresentationNodeComponent(
                    State: _State,
                    Objective: _Objective,
                    ProgressValue: _ProgressValue,
                    CompletionValue: _CompletionValue
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}