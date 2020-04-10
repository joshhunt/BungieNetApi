using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A \&quot;Progression\&quot; in Destiny is best explained by an example.  A Character&#39;s \&quot;Level\&quot; is a progression: it has Experience that can be earned, levels that can be gained, and is evaluated and displayed at various points in the game. A Character&#39;s \&quot;Faction Reputation\&quot; is also a progression for much the same reason.  Progression is used by a variety of systems, and the definition of a Progression will generally only be useful if combining with live data (such as a character&#39;s DestinyCharacterProgressionComponent.progressions property, which holds that character&#39;s live Progression states).  Fundamentally, a Progression measures your \&quot;Level\&quot; by evaluating the thresholds in its Steps (one step per level, except for the last step which can be repeated indefinitely for \&quot;Levels\&quot; that have no ceiling) against the total earned \&quot;progression points\&quot;/experience. (for simplicity purposes, we will henceforth refer to earned progression points as experience, though it need not be a mechanic that in any way resembles Experience in a traditional sense).  Earned experience is calculated in a variety of ways, determined by the Progression&#39;s scope. These go from looking up a stored value to performing exceedingly obtuse calculations. This is why we provide live data in DestinyCharacterProgressionComponent.progressions, so you don&#39;t have to worry about those.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyProgressionDefinition:  IEquatable<DestinyDefinitionsDestinyProgressionDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The \&quot;Scope\&quot; of the progression indicates the source of the progression&#39;s live data.  See the DestinyProgressionScope enum for more info: but essentially, a Progression can either be backed by a stored value, or it can be a calculated derivative of other values.
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// If this is True, then the progression doesn&#39;t have a maximum level.
        /// </summary>
        public bool? RepeatLastStep { get; private set; }

        /// <summary>
        /// If there&#39;s a description of how to earn this progression in the local config, this will be that localized description.
        /// </summary>
        public string Source { get; private set; }

        /// <summary>
        /// Progressions are divided into Steps, which roughly equate to \&quot;Levels\&quot; in the traditional sense of a Progression. Notably, the last step can be repeated indefinitely if repeatLastStep is true, meaning that the calculation for your level is not as simple as comparing your current progress to the max progress of the steps.   These and more calculations are done for you if you grab live character progression data, such as in the DestinyCharacterProgressionComponent.
        /// </summary>
        public List<DestinyDefinitionsDestinyProgressionStepDefinition> Steps { get; private set; }

        /// <summary>
        /// If true, the Progression is something worth showing to users.  If false, BNet isn&#39;t going to show it. But that doesn&#39;t mean you can&#39;t. We&#39;re all friends here.
        /// </summary>
        public bool? Visible { get; private set; }

        /// <summary>
        /// If the value exists, this is the hash identifier for the Faction that owns this Progression.  This is purely for convenience, if you&#39;re looking at a progression and want to know if and who it&#39;s related to in terms of Faction Reputation.
        /// </summary>
        public int? FactionHash { get; private set; }

        /// <summary>
        /// The #RGB string value for the color related to this progression, if there is one.
        /// </summary>
        public DestinyMiscDestinyColor Color { get; private set; }

        /// <summary>
        /// For progressions that have it, this is the rank icon we use in the Companion, displayed above the progressions&#39; rank value.
        /// </summary>
        public string RankIcon { get; private set; }

        /// <summary>
        /// RewardItems
        /// </summary>
        public List<DestinyDefinitionsDestinyProgressionRewardItemQuantity> RewardItems { get; private set; }

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
        /// Use DestinyDefinitionsDestinyProgressionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyProgressionDefinition()
        {
        }

        private DestinyDefinitionsDestinyProgressionDefinition(DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition DisplayProperties, int? Scope, bool? RepeatLastStep, string Source, List<DestinyDefinitionsDestinyProgressionStepDefinition> Steps, bool? Visible, int? FactionHash, DestinyMiscDestinyColor Color, string RankIcon, List<DestinyDefinitionsDestinyProgressionRewardItemQuantity> RewardItems, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Scope = Scope;
            
            this.RepeatLastStep = RepeatLastStep;
            
            this.Source = Source;
            
            this.Steps = Steps;
            
            this.Visible = Visible;
            
            this.FactionHash = FactionHash;
            
            this.Color = Color;
            
            this.RankIcon = RankIcon;
            
            this.RewardItems = RewardItems;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyProgressionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyProgressionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyProgressionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyProgressionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyProgressionDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Scope(Scope)
                .RepeatLastStep(RepeatLastStep)
                .Source(Source)
                .Steps(Steps)
                .Visible(Visible)
                .FactionHash(FactionHash)
                .Color(Color)
                .RankIcon(RankIcon)
                .RewardItems(RewardItems)
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

        public bool Equals(DestinyDefinitionsDestinyProgressionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyProgressionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyProgressionDefinition left, DestinyDefinitionsDestinyProgressionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyProgressionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyProgressionDefinition left, DestinyDefinitionsDestinyProgressionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyProgressionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyProgressionDefinitionBuilder
        {
            private DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition _DisplayProperties;
            private int? _Scope;
            private bool? _RepeatLastStep;
            private string _Source;
            private List<DestinyDefinitionsDestinyProgressionStepDefinition> _Steps;
            private bool? _Visible;
            private int? _FactionHash;
            private DestinyMiscDestinyColor _Color;
            private string _RankIcon;
            private List<DestinyDefinitionsDestinyProgressionRewardItemQuantity> _RewardItems;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyProgressionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder DisplayProperties(DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Scope property.
            /// </summary>
            /// <param name="value">The \&quot;Scope\&quot; of the progression indicates the source of the progression&#39;s live data.  See the DestinyProgressionScope enum for more info: but essentially, a Progression can either be backed by a stored value, or it can be a calculated derivative of other values.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.RepeatLastStep property.
            /// </summary>
            /// <param name="value">If this is True, then the progression doesn&#39;t have a maximum level.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder RepeatLastStep(bool? value)
            {
                _RepeatLastStep = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Source property.
            /// </summary>
            /// <param name="value">If there&#39;s a description of how to earn this progression in the local config, this will be that localized description.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Source(string value)
            {
                _Source = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Steps property.
            /// </summary>
            /// <param name="value">Progressions are divided into Steps, which roughly equate to \&quot;Levels\&quot; in the traditional sense of a Progression. Notably, the last step can be repeated indefinitely if repeatLastStep is true, meaning that the calculation for your level is not as simple as comparing your current progress to the max progress of the steps.   These and more calculations are done for you if you grab live character progression data, such as in the DestinyCharacterProgressionComponent.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Steps(List<DestinyDefinitionsDestinyProgressionStepDefinition> value)
            {
                _Steps = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Visible property.
            /// </summary>
            /// <param name="value">If true, the Progression is something worth showing to users.  If false, BNet isn&#39;t going to show it. But that doesn&#39;t mean you can&#39;t. We&#39;re all friends here.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Visible(bool? value)
            {
                _Visible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.FactionHash property.
            /// </summary>
            /// <param name="value">If the value exists, this is the hash identifier for the Faction that owns this Progression.  This is purely for convenience, if you&#39;re looking at a progression and want to know if and who it&#39;s related to in terms of Faction Reputation.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder FactionHash(int? value)
            {
                _FactionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Color property.
            /// </summary>
            /// <param name="value">The #RGB string value for the color related to this progression, if there is one.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Color(DestinyMiscDestinyColor value)
            {
                _Color = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.RankIcon property.
            /// </summary>
            /// <param name="value">For progressions that have it, this is the rank icon we use in the Companion, displayed above the progressions&#39; rank value.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder RankIcon(string value)
            {
                _RankIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.RewardItems property.
            /// </summary>
            /// <param name="value">RewardItems</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder RewardItems(List<DestinyDefinitionsDestinyProgressionRewardItemQuantity> value)
            {
                _RewardItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyProgressionDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyProgressionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyProgressionDefinition</returns>
            public DestinyDefinitionsDestinyProgressionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyProgressionDefinition(
                    DisplayProperties: _DisplayProperties,
                    Scope: _Scope,
                    RepeatLastStep: _RepeatLastStep,
                    Source: _Source,
                    Steps: _Steps,
                    Visible: _Visible,
                    FactionHash: _FactionHash,
                    Color: _Color,
                    RankIcon: _RankIcon,
                    RewardItems: _RewardItems,
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