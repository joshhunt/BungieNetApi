using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A Vendor Interaction is a dialog shown by the vendor other than sale items or transfer screens. The vendor is showing you something, and asking you to reply to it by choosing an option or reward.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorInteractionDefinition:  IEquatable<DestinyDefinitionsDestinyVendorInteractionDefinition>
    { 
        /// <summary>
        /// The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.
        /// </summary>
        public int? InteractionIndex { get; private set; }

        /// <summary>
        /// The potential replies that the user can make to the interaction.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> Replies { get; private set; }

        /// <summary>
        /// If &gt;&#x3D; 0, this is the category of sale items to show along with this interaction dialog.
        /// </summary>
        public int? VendorCategoryIndex { get; private set; }

        /// <summary>
        /// If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character&#39;s status with the quest if you use it to find the character&#39;s current Quest Step by checking their inventory against this questlineItemHash&#39;s DestinyInventoryItemDefinition.setData.
        /// </summary>
        public int? QuestlineItemHash { get; private set; }

        /// <summary>
        /// If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> SackInteractionList { get; private set; }

        /// <summary>
        /// A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn&#39;t as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.
        /// </summary>
        public int? UiInteractionType { get; private set; }

        /// <summary>
        /// The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.
        /// </summary>
        public int? InteractionType { get; private set; }

        /// <summary>
        /// If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.
        /// </summary>
        public string RewardBlockLabel { get; private set; }

        /// <summary>
        /// If the vendor&#39;s reward list is sourced from one of his categories, this is the index into the category array of items to show.
        /// </summary>
        public int? RewardVendorCategoryIndex { get; private set; }

        /// <summary>
        /// If the vendor interaction has flavor text, this is some of it.
        /// </summary>
        public string FlavorLineOne { get; private set; }

        /// <summary>
        /// If the vendor interaction has flavor text, this is the rest of it.
        /// </summary>
        public string FlavorLineTwo { get; private set; }

        /// <summary>
        /// The header for the interaction dialog.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition HeaderDisplayProperties { get; private set; }

        /// <summary>
        /// The localized text telling the player what to do when they see this dialog.
        /// </summary>
        public string Instructions { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorInteractionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorInteractionDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorInteractionDefinition(int? InteractionIndex, List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> Replies, int? VendorCategoryIndex, int? QuestlineItemHash, List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> SackInteractionList, int? UiInteractionType, int? InteractionType, string RewardBlockLabel, int? RewardVendorCategoryIndex, string FlavorLineOne, string FlavorLineTwo, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition HeaderDisplayProperties, string Instructions)
        {
            
            this.InteractionIndex = InteractionIndex;
            
            this.Replies = Replies;
            
            this.VendorCategoryIndex = VendorCategoryIndex;
            
            this.QuestlineItemHash = QuestlineItemHash;
            
            this.SackInteractionList = SackInteractionList;
            
            this.UiInteractionType = UiInteractionType;
            
            this.InteractionType = InteractionType;
            
            this.RewardBlockLabel = RewardBlockLabel;
            
            this.RewardVendorCategoryIndex = RewardVendorCategoryIndex;
            
            this.FlavorLineOne = FlavorLineOne;
            
            this.FlavorLineTwo = FlavorLineTwo;
            
            this.HeaderDisplayProperties = HeaderDisplayProperties;
            
            this.Instructions = Instructions;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorInteractionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder With()
        {
            return Builder()
                .InteractionIndex(InteractionIndex)
                .Replies(Replies)
                .VendorCategoryIndex(VendorCategoryIndex)
                .QuestlineItemHash(QuestlineItemHash)
                .SackInteractionList(SackInteractionList)
                .UiInteractionType(UiInteractionType)
                .InteractionType(InteractionType)
                .RewardBlockLabel(RewardBlockLabel)
                .RewardVendorCategoryIndex(RewardVendorCategoryIndex)
                .FlavorLineOne(FlavorLineOne)
                .FlavorLineTwo(FlavorLineTwo)
                .HeaderDisplayProperties(HeaderDisplayProperties)
                .Instructions(Instructions);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorInteractionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorInteractionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInteractionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInteractionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorInteractionDefinition left, DestinyDefinitionsDestinyVendorInteractionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorInteractionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInteractionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInteractionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorInteractionDefinition left, DestinyDefinitionsDestinyVendorInteractionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorInteractionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder
        {
            private int? _InteractionIndex;
            private List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> _Replies;
            private int? _VendorCategoryIndex;
            private int? _QuestlineItemHash;
            private List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> _SackInteractionList;
            private int? _UiInteractionType;
            private int? _InteractionType;
            private string _RewardBlockLabel;
            private int? _RewardVendorCategoryIndex;
            private string _FlavorLineOne;
            private string _FlavorLineTwo;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _HeaderDisplayProperties;
            private string _Instructions;

            internal DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.InteractionIndex property.
            /// </summary>
            /// <param name="value">The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder InteractionIndex(int? value)
            {
                _InteractionIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.Replies property.
            /// </summary>
            /// <param name="value">The potential replies that the user can make to the interaction.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder Replies(List<DestinyDefinitionsDestinyVendorInteractionReplyDefinition> value)
            {
                _Replies = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.VendorCategoryIndex property.
            /// </summary>
            /// <param name="value">If &gt;&#x3D; 0, this is the category of sale items to show along with this interaction dialog.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder VendorCategoryIndex(int? value)
            {
                _VendorCategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.QuestlineItemHash property.
            /// </summary>
            /// <param name="value">If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character&#39;s status with the quest if you use it to find the character&#39;s current Quest Step by checking their inventory against this questlineItemHash&#39;s DestinyInventoryItemDefinition.setData.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder QuestlineItemHash(int? value)
            {
                _QuestlineItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.SackInteractionList property.
            /// </summary>
            /// <param name="value">If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder SackInteractionList(List<DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition> value)
            {
                _SackInteractionList = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.UiInteractionType property.
            /// </summary>
            /// <param name="value">A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn&#39;t as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder UiInteractionType(int? value)
            {
                _UiInteractionType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.InteractionType property.
            /// </summary>
            /// <param name="value">The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder InteractionType(int? value)
            {
                _InteractionType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.RewardBlockLabel property.
            /// </summary>
            /// <param name="value">If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder RewardBlockLabel(string value)
            {
                _RewardBlockLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.RewardVendorCategoryIndex property.
            /// </summary>
            /// <param name="value">If the vendor&#39;s reward list is sourced from one of his categories, this is the index into the category array of items to show.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder RewardVendorCategoryIndex(int? value)
            {
                _RewardVendorCategoryIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.FlavorLineOne property.
            /// </summary>
            /// <param name="value">If the vendor interaction has flavor text, this is some of it.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder FlavorLineOne(string value)
            {
                _FlavorLineOne = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.FlavorLineTwo property.
            /// </summary>
            /// <param name="value">If the vendor interaction has flavor text, this is the rest of it.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder FlavorLineTwo(string value)
            {
                _FlavorLineTwo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.HeaderDisplayProperties property.
            /// </summary>
            /// <param name="value">The header for the interaction dialog.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder HeaderDisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _HeaderDisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionDefinition.Instructions property.
            /// </summary>
            /// <param name="value">The localized text telling the player what to do when they see this dialog.</param>
            public DestinyDefinitionsDestinyVendorInteractionDefinitionBuilder Instructions(string value)
            {
                _Instructions = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorInteractionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorInteractionDefinition</returns>
            public DestinyDefinitionsDestinyVendorInteractionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorInteractionDefinition(
                    InteractionIndex: _InteractionIndex,
                    Replies: _Replies,
                    VendorCategoryIndex: _VendorCategoryIndex,
                    QuestlineItemHash: _QuestlineItemHash,
                    SackInteractionList: _SackInteractionList,
                    UiInteractionType: _UiInteractionType,
                    InteractionType: _InteractionType,
                    RewardBlockLabel: _RewardBlockLabel,
                    RewardVendorCategoryIndex: _RewardVendorCategoryIndex,
                    FlavorLineOne: _FlavorLineOne,
                    FlavorLineTwo: _FlavorLineTwo,
                    HeaderDisplayProperties: _HeaderDisplayProperties,
                    Instructions: _Instructions
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}