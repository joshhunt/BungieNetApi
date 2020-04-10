using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Data regarding the progress of a Quest for a specific character. Quests are composed of multiple steps, each with potentially multiple objectives: this QuestStatus will return Objective data for the *currently active* step in this quest.
    /// </summary>
    public sealed class DestinyQuestsDestinyQuestStatus:  IEquatable<DestinyQuestsDestinyQuestStatus>
    { 
        /// <summary>
        /// The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest&#39;s DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
        /// </summary>
        public int? QuestHash { get; private set; }

        /// <summary>
        /// The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. You can use this to get human readable data about the current step and what to do in that step.
        /// </summary>
        public int? StepHash { get; private set; }

        /// <summary>
        /// A step can have multiple objectives. This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.
        /// </summary>
        public List<DestinyQuestsDestinyObjectiveProgress> StepObjectives { get; private set; }

        /// <summary>
        /// Whether or not the quest is tracked
        /// </summary>
        public bool? Tracked { get; private set; }

        /// <summary>
        /// The current Quest Step will be an instanced item in the player&#39;s inventory. If you care about that, this is the instance ID of that item.
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.
        /// </summary>
        public bool? Completed { get; private set; }

        /// <summary>
        /// Whether or not you have redeemed rewards for this quest.
        /// </summary>
        public bool? Redeemed { get; private set; }

        /// <summary>
        /// Whether or not you have started this quest.
        /// </summary>
        public bool? Started { get; private set; }

        /// <summary>
        /// If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.
        /// </summary>
        public int? VendorHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyQuestsDestinyQuestStatus.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyQuestsDestinyQuestStatus()
        {
        }

        private DestinyQuestsDestinyQuestStatus(int? QuestHash, int? StepHash, List<DestinyQuestsDestinyObjectiveProgress> StepObjectives, bool? Tracked, long? ItemInstanceId, bool? Completed, bool? Redeemed, bool? Started, int? VendorHash)
        {
            
            this.QuestHash = QuestHash;
            
            this.StepHash = StepHash;
            
            this.StepObjectives = StepObjectives;
            
            this.Tracked = Tracked;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Completed = Completed;
            
            this.Redeemed = Redeemed;
            
            this.Started = Started;
            
            this.VendorHash = VendorHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyQuestsDestinyQuestStatus.
        /// </summary>
        /// <returns>DestinyQuestsDestinyQuestStatusBuilder</returns>
        public static DestinyQuestsDestinyQuestStatusBuilder Builder()
        {
            return new DestinyQuestsDestinyQuestStatusBuilder();
        }

        /// <summary>
        /// Returns DestinyQuestsDestinyQuestStatusBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyQuestsDestinyQuestStatusBuilder</returns>
        public DestinyQuestsDestinyQuestStatusBuilder With()
        {
            return Builder()
                .QuestHash(QuestHash)
                .StepHash(StepHash)
                .StepObjectives(StepObjectives)
                .Tracked(Tracked)
                .ItemInstanceId(ItemInstanceId)
                .Completed(Completed)
                .Redeemed(Redeemed)
                .Started(Started)
                .VendorHash(VendorHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyQuestsDestinyQuestStatus other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyQuestsDestinyQuestStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyQuestsDestinyQuestStatus</param>
        /// <param name="right">Compared (DestinyQuestsDestinyQuestStatus</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyQuestsDestinyQuestStatus left, DestinyQuestsDestinyQuestStatus right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyQuestsDestinyQuestStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyQuestsDestinyQuestStatus</param>
        /// <param name="right">Compared (DestinyQuestsDestinyQuestStatus</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyQuestsDestinyQuestStatus left, DestinyQuestsDestinyQuestStatus right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyQuestsDestinyQuestStatus.
        /// </summary>
        public sealed class DestinyQuestsDestinyQuestStatusBuilder
        {
            private int? _QuestHash;
            private int? _StepHash;
            private List<DestinyQuestsDestinyObjectiveProgress> _StepObjectives;
            private bool? _Tracked;
            private long? _ItemInstanceId;
            private bool? _Completed;
            private bool? _Redeemed;
            private bool? _Started;
            private int? _VendorHash;

            internal DestinyQuestsDestinyQuestStatusBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.QuestHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest&#39;s DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.</param>
            public DestinyQuestsDestinyQuestStatusBuilder QuestHash(int? value)
            {
                _QuestHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.StepHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. You can use this to get human readable data about the current step and what to do in that step.</param>
            public DestinyQuestsDestinyQuestStatusBuilder StepHash(int? value)
            {
                _StepHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.StepObjectives property.
            /// </summary>
            /// <param name="value">A step can have multiple objectives. This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.</param>
            public DestinyQuestsDestinyQuestStatusBuilder StepObjectives(List<DestinyQuestsDestinyObjectiveProgress> value)
            {
                _StepObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.Tracked property.
            /// </summary>
            /// <param name="value">Whether or not the quest is tracked</param>
            public DestinyQuestsDestinyQuestStatusBuilder Tracked(bool? value)
            {
                _Tracked = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.ItemInstanceId property.
            /// </summary>
            /// <param name="value">The current Quest Step will be an instanced item in the player&#39;s inventory. If you care about that, this is the instance ID of that item.</param>
            public DestinyQuestsDestinyQuestStatusBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.Completed property.
            /// </summary>
            /// <param name="value">Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.</param>
            public DestinyQuestsDestinyQuestStatusBuilder Completed(bool? value)
            {
                _Completed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.Redeemed property.
            /// </summary>
            /// <param name="value">Whether or not you have redeemed rewards for this quest.</param>
            public DestinyQuestsDestinyQuestStatusBuilder Redeemed(bool? value)
            {
                _Redeemed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.Started property.
            /// </summary>
            /// <param name="value">Whether or not you have started this quest.</param>
            public DestinyQuestsDestinyQuestStatusBuilder Started(bool? value)
            {
                _Started = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyQuestsDestinyQuestStatus.VendorHash property.
            /// </summary>
            /// <param name="value">If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.</param>
            public DestinyQuestsDestinyQuestStatusBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyQuestsDestinyQuestStatus.
            /// </summary>
            /// <returns>DestinyQuestsDestinyQuestStatus</returns>
            public DestinyQuestsDestinyQuestStatus Build()
            {
                Validate();
                return new DestinyQuestsDestinyQuestStatus(
                    QuestHash: _QuestHash,
                    StepHash: _StepHash,
                    StepObjectives: _StepObjectives,
                    Tracked: _Tracked,
                    ItemInstanceId: _ItemInstanceId,
                    Completed: _Completed,
                    Redeemed: _Redeemed,
                    Started: _Started,
                    VendorHash: _VendorHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}