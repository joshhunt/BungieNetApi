using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines an \&quot;Objective\&quot;.  An objective is a specific task you should accomplish in the game. These are referred to by:  - Quest Steps (which are DestinyInventoryItemDefinition entities with Objectives)  - Challenges (which are Objectives defined on an DestinyActivityDefintion)  - Milestones (which refer to Objectives that are defined on both Quest Steps and Activities)  - Anything else that the designers decide to do later.  Objectives have progress, a notion of having been Completed, human readable data describing the task to be accomplished, and a lot of optional tack-on data that can enhance the information provided about the task.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyObjectiveDefinition:  IEquatable<DestinyDefinitionsDestinyObjectiveDefinition>
    { 
        /// <summary>
        /// Ideally, this should tell you what your task is. I&#39;m not going to lie to you though. Sometimes this doesn&#39;t have useful information at all. Which sucks, but there&#39;s nothing either of us can do about it.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status.
        /// </summary>
        public int? CompletionValue { get; private set; }

        /// <summary>
        /// A shortcut for determining the most restrictive gating that this Objective is set to use. This includes both the dynamic determination of progress and of completion values. See the DestinyGatingScope enum&#39;s documentation for more details.
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info.
        /// </summary>
        public int? LocationHash { get; private set; }

        /// <summary>
        /// If true, the value is allowed to go negative.
        /// </summary>
        public bool? AllowNegativeValue { get; private set; }

        /// <summary>
        /// If true, you can effectively \&quot;un-complete\&quot; this objective if you lose progress after crossing the completion threshold.   If False, once you complete the task it will remain completed forever by locking the value.
        /// </summary>
        public bool? AllowValueChangeWhenCompleted { get; private set; }

        /// <summary>
        /// If true, completion means having an unlock value less than or equal to the completionValue.  If False, completion means having an unlock value greater than or equal to the completionValue.
        /// </summary>
        public bool? IsCountingDownward { get; private set; }

        /// <summary>
        /// The UI style applied to the objective. It&#39;s an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI.
        /// </summary>
        public int? ValueStyle { get; private set; }

        /// <summary>
        /// Text to describe the progress bar.
        /// </summary>
        public string ProgressDescription { get; private set; }

        /// <summary>
        /// If this objective enables Perks intrinsically, the conditions for that enabling are defined here.
        /// </summary>
        public DestinyDefinitionsDestinyObjectivePerkEntryDefinition Perks { get; private set; }

        /// <summary>
        /// If this objective enables modifications on a player&#39;s stats intrinsically, the conditions are defined here.
        /// </summary>
        public DestinyDefinitionsDestinyObjectiveStatEntryDefinition Stats { get; private set; }

        /// <summary>
        /// If nonzero, this is the minimum value at which the objective&#39;s progression should be shown. Otherwise, don&#39;t show it yet.
        /// </summary>
        public int? MinimumVisibilityThreshold { get; private set; }

        /// <summary>
        /// If True, the progress will continue even beyond the point where the objective met its minimum completion requirements. Your UI will have to accommodate it.
        /// </summary>
        public bool? AllowOvercompletion { get; private set; }

        /// <summary>
        /// If True, you should continue showing the progression value in the UI after it&#39;s complete. I mean, we already do that in BNet anyways, but if you want to be better behaved than us you could honor this flag.
        /// </summary>
        public bool? ShowValueOnComplete { get; private set; }

        /// <summary>
        /// The style to use when the objective is completed.
        /// </summary>
        public int? CompletedValueStyle { get; private set; }

        /// <summary>
        /// The style to use when the objective is still in progress.
        /// </summary>
        public int? InProgressValueStyle { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyObjectiveDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyObjectiveDefinition()
        {
        }

        private DestinyDefinitionsDestinyObjectiveDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? CompletionValue, int? Scope, int? LocationHash, bool? AllowNegativeValue, bool? AllowValueChangeWhenCompleted, bool? IsCountingDownward, int? ValueStyle, string ProgressDescription, DestinyDefinitionsDestinyObjectivePerkEntryDefinition Perks, DestinyDefinitionsDestinyObjectiveStatEntryDefinition Stats, int? MinimumVisibilityThreshold, bool? AllowOvercompletion, bool? ShowValueOnComplete, int? CompletedValueStyle, int? InProgressValueStyle, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.CompletionValue = CompletionValue;
            
            this.Scope = Scope;
            
            this.LocationHash = LocationHash;
            
            this.AllowNegativeValue = AllowNegativeValue;
            
            this.AllowValueChangeWhenCompleted = AllowValueChangeWhenCompleted;
            
            this.IsCountingDownward = IsCountingDownward;
            
            this.ValueStyle = ValueStyle;
            
            this.ProgressDescription = ProgressDescription;
            
            this.Perks = Perks;
            
            this.Stats = Stats;
            
            this.MinimumVisibilityThreshold = MinimumVisibilityThreshold;
            
            this.AllowOvercompletion = AllowOvercompletion;
            
            this.ShowValueOnComplete = ShowValueOnComplete;
            
            this.CompletedValueStyle = CompletedValueStyle;
            
            this.InProgressValueStyle = InProgressValueStyle;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyObjectiveDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectiveDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyObjectiveDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyObjectiveDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyObjectiveDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectiveDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyObjectiveDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .CompletionValue(CompletionValue)
                .Scope(Scope)
                .LocationHash(LocationHash)
                .AllowNegativeValue(AllowNegativeValue)
                .AllowValueChangeWhenCompleted(AllowValueChangeWhenCompleted)
                .IsCountingDownward(IsCountingDownward)
                .ValueStyle(ValueStyle)
                .ProgressDescription(ProgressDescription)
                .Perks(Perks)
                .Stats(Stats)
                .MinimumVisibilityThreshold(MinimumVisibilityThreshold)
                .AllowOvercompletion(AllowOvercompletion)
                .ShowValueOnComplete(ShowValueOnComplete)
                .CompletedValueStyle(CompletedValueStyle)
                .InProgressValueStyle(InProgressValueStyle)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyObjectiveDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyObjectiveDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectiveDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectiveDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyObjectiveDefinition left, DestinyDefinitionsDestinyObjectiveDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyObjectiveDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectiveDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectiveDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyObjectiveDefinition left, DestinyDefinitionsDestinyObjectiveDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyObjectiveDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyObjectiveDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _CompletionValue;
            private int? _Scope;
            private int? _LocationHash;
            private bool? _AllowNegativeValue;
            private bool? _AllowValueChangeWhenCompleted;
            private bool? _IsCountingDownward;
            private int? _ValueStyle;
            private string _ProgressDescription;
            private DestinyDefinitionsDestinyObjectivePerkEntryDefinition _Perks;
            private DestinyDefinitionsDestinyObjectiveStatEntryDefinition _Stats;
            private int? _MinimumVisibilityThreshold;
            private bool? _AllowOvercompletion;
            private bool? _ShowValueOnComplete;
            private int? _CompletedValueStyle;
            private int? _InProgressValueStyle;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyObjectiveDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">Ideally, this should tell you what your task is. I&#39;m not going to lie to you though. Sometimes this doesn&#39;t have useful information at all. Which sucks, but there&#39;s nothing either of us can do about it.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.CompletionValue property.
            /// </summary>
            /// <param name="value">The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder CompletionValue(int? value)
            {
                _CompletionValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.Scope property.
            /// </summary>
            /// <param name="value">A shortcut for determining the most restrictive gating that this Objective is set to use. This includes both the dynamic determination of progress and of completion values. See the DestinyGatingScope enum&#39;s documentation for more details.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.LocationHash property.
            /// </summary>
            /// <param name="value">OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder LocationHash(int? value)
            {
                _LocationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.AllowNegativeValue property.
            /// </summary>
            /// <param name="value">If true, the value is allowed to go negative.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder AllowNegativeValue(bool? value)
            {
                _AllowNegativeValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.AllowValueChangeWhenCompleted property.
            /// </summary>
            /// <param name="value">If true, you can effectively \&quot;un-complete\&quot; this objective if you lose progress after crossing the completion threshold.   If False, once you complete the task it will remain completed forever by locking the value.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder AllowValueChangeWhenCompleted(bool? value)
            {
                _AllowValueChangeWhenCompleted = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.IsCountingDownward property.
            /// </summary>
            /// <param name="value">If true, completion means having an unlock value less than or equal to the completionValue.  If False, completion means having an unlock value greater than or equal to the completionValue.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder IsCountingDownward(bool? value)
            {
                _IsCountingDownward = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.ValueStyle property.
            /// </summary>
            /// <param name="value">The UI style applied to the objective. It&#39;s an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder ValueStyle(int? value)
            {
                _ValueStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.ProgressDescription property.
            /// </summary>
            /// <param name="value">Text to describe the progress bar.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder ProgressDescription(string value)
            {
                _ProgressDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.Perks property.
            /// </summary>
            /// <param name="value">If this objective enables Perks intrinsically, the conditions for that enabling are defined here.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder Perks(DestinyDefinitionsDestinyObjectivePerkEntryDefinition value)
            {
                _Perks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.Stats property.
            /// </summary>
            /// <param name="value">If this objective enables modifications on a player&#39;s stats intrinsically, the conditions are defined here.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder Stats(DestinyDefinitionsDestinyObjectiveStatEntryDefinition value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.MinimumVisibilityThreshold property.
            /// </summary>
            /// <param name="value">If nonzero, this is the minimum value at which the objective&#39;s progression should be shown. Otherwise, don&#39;t show it yet.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder MinimumVisibilityThreshold(int? value)
            {
                _MinimumVisibilityThreshold = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.AllowOvercompletion property.
            /// </summary>
            /// <param name="value">If True, the progress will continue even beyond the point where the objective met its minimum completion requirements. Your UI will have to accommodate it.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder AllowOvercompletion(bool? value)
            {
                _AllowOvercompletion = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.ShowValueOnComplete property.
            /// </summary>
            /// <param name="value">If True, you should continue showing the progression value in the UI after it&#39;s complete. I mean, we already do that in BNet anyways, but if you want to be better behaved than us you could honor this flag.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder ShowValueOnComplete(bool? value)
            {
                _ShowValueOnComplete = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.CompletedValueStyle property.
            /// </summary>
            /// <param name="value">The style to use when the objective is completed.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder CompletedValueStyle(int? value)
            {
                _CompletedValueStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.InProgressValueStyle property.
            /// </summary>
            /// <param name="value">The style to use when the objective is still in progress.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder InProgressValueStyle(int? value)
            {
                _InProgressValueStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyObjectiveDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyObjectiveDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyObjectiveDefinition</returns>
            public DestinyDefinitionsDestinyObjectiveDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyObjectiveDefinition(
                    DisplayProperties: _DisplayProperties,
                    CompletionValue: _CompletionValue,
                    Scope: _Scope,
                    LocationHash: _LocationHash,
                    AllowNegativeValue: _AllowNegativeValue,
                    AllowValueChangeWhenCompleted: _AllowValueChangeWhenCompleted,
                    IsCountingDownward: _IsCountingDownward,
                    ValueStyle: _ValueStyle,
                    ProgressDescription: _ProgressDescription,
                    Perks: _Perks,
                    Stats: _Stats,
                    MinimumVisibilityThreshold: _MinimumVisibilityThreshold,
                    AllowOvercompletion: _AllowOvercompletion,
                    ShowValueOnComplete: _ShowValueOnComplete,
                    CompletedValueStyle: _CompletedValueStyle,
                    InProgressValueStyle: _InProgressValueStyle,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}