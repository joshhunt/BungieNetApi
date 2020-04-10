using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This defines a single Step in a progression (which roughly equates to a level. See DestinyProgressionDefinition for caveats).
    /// </summary>
    public sealed class DestinyDefinitionsDestinyProgressionStepDefinition:  IEquatable<DestinyDefinitionsDestinyProgressionStepDefinition>
    { 
        /// <summary>
        /// Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.
        /// </summary>
        public string StepName { get; private set; }

        /// <summary>
        /// This appears to be, when you \&quot;level up\&quot;, whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.
        /// </summary>
        public int? DisplayEffectType { get; private set; }

        /// <summary>
        /// The total amount of progression points/\&quot;experience\&quot; you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.
        /// </summary>
        public int? ProgressTotal { get; private set; }

        /// <summary>
        /// A listing of items rewarded as a result of reaching this level.
        /// </summary>
        public List<DestinyDestinyItemQuantity> RewardItems { get; private set; }

        /// <summary>
        /// If this progression step has a specific icon related to it, this is the icon to show.
        /// </summary>
        public string Icon { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyProgressionStepDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyProgressionStepDefinition()
        {
        }

        private DestinyDefinitionsDestinyProgressionStepDefinition(string StepName, int? DisplayEffectType, int? ProgressTotal, List<DestinyDestinyItemQuantity> RewardItems, string Icon)
        {
            
            this.StepName = StepName;
            
            this.DisplayEffectType = DisplayEffectType;
            
            this.ProgressTotal = ProgressTotal;
            
            this.RewardItems = RewardItems;
            
            this.Icon = Icon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyProgressionStepDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionStepDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyProgressionStepDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyProgressionStepDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyProgressionStepDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionStepDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyProgressionStepDefinitionBuilder With()
        {
            return Builder()
                .StepName(StepName)
                .DisplayEffectType(DisplayEffectType)
                .ProgressTotal(ProgressTotal)
                .RewardItems(RewardItems)
                .Icon(Icon);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyProgressionStepDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyProgressionStepDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionStepDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionStepDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyProgressionStepDefinition left, DestinyDefinitionsDestinyProgressionStepDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyProgressionStepDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionStepDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionStepDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyProgressionStepDefinition left, DestinyDefinitionsDestinyProgressionStepDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyProgressionStepDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyProgressionStepDefinitionBuilder
        {
            private string _StepName;
            private int? _DisplayEffectType;
            private int? _ProgressTotal;
            private List<DestinyDestinyItemQuantity> _RewardItems;
            private string _Icon;

            internal DestinyDefinitionsDestinyProgressionStepDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionStepDefinition.StepName property.
            /// </summary>
            /// <param name="value">Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.</param>
            public DestinyDefinitionsDestinyProgressionStepDefinitionBuilder StepName(string value)
            {
                _StepName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionStepDefinition.DisplayEffectType property.
            /// </summary>
            /// <param name="value">This appears to be, when you \&quot;level up\&quot;, whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.</param>
            public DestinyDefinitionsDestinyProgressionStepDefinitionBuilder DisplayEffectType(int? value)
            {
                _DisplayEffectType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionStepDefinition.ProgressTotal property.
            /// </summary>
            /// <param name="value">The total amount of progression points/\&quot;experience\&quot; you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.</param>
            public DestinyDefinitionsDestinyProgressionStepDefinitionBuilder ProgressTotal(int? value)
            {
                _ProgressTotal = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionStepDefinition.RewardItems property.
            /// </summary>
            /// <param name="value">A listing of items rewarded as a result of reaching this level.</param>
            public DestinyDefinitionsDestinyProgressionStepDefinitionBuilder RewardItems(List<DestinyDestinyItemQuantity> value)
            {
                _RewardItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionStepDefinition.Icon property.
            /// </summary>
            /// <param name="value">If this progression step has a specific icon related to it, this is the icon to show.</param>
            public DestinyDefinitionsDestinyProgressionStepDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyProgressionStepDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyProgressionStepDefinition</returns>
            public DestinyDefinitionsDestinyProgressionStepDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyProgressionStepDefinition(
                    StepName: _StepName,
                    DisplayEffectType: _DisplayEffectType,
                    ProgressTotal: _ProgressTotal,
                    RewardItems: _RewardItems,
                    Icon: _Icon
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}