using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Activities can refer to one or more sets of tooltip-friendly reward data. These are the definitions for those tooltip friendly rewards.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityRewardDefinition:  IEquatable<DestinyDefinitionsDestinyActivityRewardDefinition>
    { 
        /// <summary>
        /// The header for the reward set, if any.
        /// </summary>
        public string RewardText { get; private set; }

        /// <summary>
        /// The \&quot;Items provided\&quot; in the reward. This is almost always a pointer to a DestinyInventoryItemDefintion for an item that you can&#39;t actually earn in-game, but that has name/description/icon information for the vague concept of the rewards you will receive. This is because the actual reward generation is non-deterministic and extremely complicated, so the best the game can do is tell you what you&#39;ll get in vague terms. And so too shall we.  Interesting trivia: you actually *do* earn these items when you complete the activity. They go into a single-slot bucket on your profile, which is how you see the pop-ups of these rewards when you complete an activity that match these \&quot;dummy\&quot; items. You can even see them if you look at the last one you earned in your profile-level inventory through the BNet API! Who said reading documentation is a waste of time?
        /// </summary>
        public List<DestinyDestinyItemQuantity> RewardItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityRewardDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityRewardDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityRewardDefinition(string RewardText, List<DestinyDestinyItemQuantity> RewardItems)
        {
            
            this.RewardText = RewardText;
            
            this.RewardItems = RewardItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityRewardDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityRewardDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityRewardDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityRewardDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityRewardDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityRewardDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityRewardDefinitionBuilder With()
        {
            return Builder()
                .RewardText(RewardText)
                .RewardItems(RewardItems);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityRewardDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityRewardDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityRewardDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityRewardDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityRewardDefinition left, DestinyDefinitionsDestinyActivityRewardDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityRewardDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityRewardDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityRewardDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityRewardDefinition left, DestinyDefinitionsDestinyActivityRewardDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityRewardDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityRewardDefinitionBuilder
        {
            private string _RewardText;
            private List<DestinyDestinyItemQuantity> _RewardItems;

            internal DestinyDefinitionsDestinyActivityRewardDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityRewardDefinition.RewardText property.
            /// </summary>
            /// <param name="value">The header for the reward set, if any.</param>
            public DestinyDefinitionsDestinyActivityRewardDefinitionBuilder RewardText(string value)
            {
                _RewardText = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityRewardDefinition.RewardItems property.
            /// </summary>
            /// <param name="value">The \&quot;Items provided\&quot; in the reward. This is almost always a pointer to a DestinyInventoryItemDefintion for an item that you can&#39;t actually earn in-game, but that has name/description/icon information for the vague concept of the rewards you will receive. This is because the actual reward generation is non-deterministic and extremely complicated, so the best the game can do is tell you what you&#39;ll get in vague terms. And so too shall we.  Interesting trivia: you actually *do* earn these items when you complete the activity. They go into a single-slot bucket on your profile, which is how you see the pop-ups of these rewards when you complete an activity that match these \&quot;dummy\&quot; items. You can even see them if you look at the last one you earned in your profile-level inventory through the BNet API! Who said reading documentation is a waste of time?</param>
            public DestinyDefinitionsDestinyActivityRewardDefinitionBuilder RewardItems(List<DestinyDestinyItemQuantity> value)
            {
                _RewardItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityRewardDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityRewardDefinition</returns>
            public DestinyDefinitionsDestinyActivityRewardDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityRewardDefinition(
                    RewardText: _RewardText,
                    RewardItems: _RewardItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}