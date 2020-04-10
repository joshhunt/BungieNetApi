using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An item can have objectives on it. In practice, these are the exclusive purview of \&quot;Quest Step\&quot; items: DestinyInventoryItemDefinitions that represent a specific step in a Quest.  Quest steps have 1:M objectives that we end up processing and returning in live data as DestinyQuestStatus data, and other useful information.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemObjectiveBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemObjectiveBlockDefinition>
    { 
        /// <summary>
        /// The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.
        /// </summary>
        public List<int?> ObjectiveHashes { get; private set; }

        /// <summary>
        /// For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.
        /// </summary>
        public List<int?> DisplayActivityHashes { get; private set; }

        /// <summary>
        /// If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.
        /// </summary>
        public bool? RequireFullObjectiveCompletion { get; private set; }

        /// <summary>
        /// The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.
        /// </summary>
        public int? QuestlineItemHash { get; private set; }

        /// <summary>
        /// The localized string for narrative text related to this quest step, if any.
        /// </summary>
        public string Narrative { get; private set; }

        /// <summary>
        /// The localized string describing an action to be performed associated with the objectives, if any.
        /// </summary>
        public string ObjectiveVerbName { get; private set; }

        /// <summary>
        /// The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.
        /// </summary>
        public string QuestTypeIdentifier { get; private set; }

        /// <summary>
        /// A hashed value for the questTypeIdentifier, because apparently I like to be redundant.
        /// </summary>
        public int? QuestTypeHash { get; private set; }

        /// <summary>
        /// One entry per Objective on the item, it will have related display information.
        /// </summary>
        public List<DestinyDefinitionsDestinyObjectiveDisplayProperties> PerObjectiveDisplayProperties { get; private set; }

        /// <summary>
        /// DisplayAsStatTracker
        /// </summary>
        public bool? DisplayAsStatTracker { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemObjectiveBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemObjectiveBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemObjectiveBlockDefinition(List<int?> ObjectiveHashes, List<int?> DisplayActivityHashes, bool? RequireFullObjectiveCompletion, int? QuestlineItemHash, string Narrative, string ObjectiveVerbName, string QuestTypeIdentifier, int? QuestTypeHash, List<DestinyDefinitionsDestinyObjectiveDisplayProperties> PerObjectiveDisplayProperties, bool? DisplayAsStatTracker)
        {
            
            this.ObjectiveHashes = ObjectiveHashes;
            
            this.DisplayActivityHashes = DisplayActivityHashes;
            
            this.RequireFullObjectiveCompletion = RequireFullObjectiveCompletion;
            
            this.QuestlineItemHash = QuestlineItemHash;
            
            this.Narrative = Narrative;
            
            this.ObjectiveVerbName = ObjectiveVerbName;
            
            this.QuestTypeIdentifier = QuestTypeIdentifier;
            
            this.QuestTypeHash = QuestTypeHash;
            
            this.PerObjectiveDisplayProperties = PerObjectiveDisplayProperties;
            
            this.DisplayAsStatTracker = DisplayAsStatTracker;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemObjectiveBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder With()
        {
            return Builder()
                .ObjectiveHashes(ObjectiveHashes)
                .DisplayActivityHashes(DisplayActivityHashes)
                .RequireFullObjectiveCompletion(RequireFullObjectiveCompletion)
                .QuestlineItemHash(QuestlineItemHash)
                .Narrative(Narrative)
                .ObjectiveVerbName(ObjectiveVerbName)
                .QuestTypeIdentifier(QuestTypeIdentifier)
                .QuestTypeHash(QuestTypeHash)
                .PerObjectiveDisplayProperties(PerObjectiveDisplayProperties)
                .DisplayAsStatTracker(DisplayAsStatTracker);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemObjectiveBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemObjectiveBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemObjectiveBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemObjectiveBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemObjectiveBlockDefinition left, DestinyDefinitionsDestinyItemObjectiveBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemObjectiveBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemObjectiveBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemObjectiveBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemObjectiveBlockDefinition left, DestinyDefinitionsDestinyItemObjectiveBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemObjectiveBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder
        {
            private List<int?> _ObjectiveHashes;
            private List<int?> _DisplayActivityHashes;
            private bool? _RequireFullObjectiveCompletion;
            private int? _QuestlineItemHash;
            private string _Narrative;
            private string _ObjectiveVerbName;
            private string _QuestTypeIdentifier;
            private int? _QuestTypeHash;
            private List<DestinyDefinitionsDestinyObjectiveDisplayProperties> _PerObjectiveDisplayProperties;
            private bool? _DisplayAsStatTracker;

            internal DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.ObjectiveHashes property.
            /// </summary>
            /// <param name="value">The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder ObjectiveHashes(List<int?> value)
            {
                _ObjectiveHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.DisplayActivityHashes property.
            /// </summary>
            /// <param name="value">For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder DisplayActivityHashes(List<int?> value)
            {
                _DisplayActivityHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.RequireFullObjectiveCompletion property.
            /// </summary>
            /// <param name="value">If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder RequireFullObjectiveCompletion(bool? value)
            {
                _RequireFullObjectiveCompletion = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.QuestlineItemHash property.
            /// </summary>
            /// <param name="value">The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder QuestlineItemHash(int? value)
            {
                _QuestlineItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.Narrative property.
            /// </summary>
            /// <param name="value">The localized string for narrative text related to this quest step, if any.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder Narrative(string value)
            {
                _Narrative = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.ObjectiveVerbName property.
            /// </summary>
            /// <param name="value">The localized string describing an action to be performed associated with the objectives, if any.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder ObjectiveVerbName(string value)
            {
                _ObjectiveVerbName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.QuestTypeIdentifier property.
            /// </summary>
            /// <param name="value">The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder QuestTypeIdentifier(string value)
            {
                _QuestTypeIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.QuestTypeHash property.
            /// </summary>
            /// <param name="value">A hashed value for the questTypeIdentifier, because apparently I like to be redundant.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder QuestTypeHash(int? value)
            {
                _QuestTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.PerObjectiveDisplayProperties property.
            /// </summary>
            /// <param name="value">One entry per Objective on the item, it will have related display information.</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder PerObjectiveDisplayProperties(List<DestinyDefinitionsDestinyObjectiveDisplayProperties> value)
            {
                _PerObjectiveDisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemObjectiveBlockDefinition.DisplayAsStatTracker property.
            /// </summary>
            /// <param name="value">DisplayAsStatTracker</param>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinitionBuilder DisplayAsStatTracker(bool? value)
            {
                _DisplayAsStatTracker = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemObjectiveBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemObjectiveBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemObjectiveBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemObjectiveBlockDefinition(
                    ObjectiveHashes: _ObjectiveHashes,
                    DisplayActivityHashes: _DisplayActivityHashes,
                    RequireFullObjectiveCompletion: _RequireFullObjectiveCompletion,
                    QuestlineItemHash: _QuestlineItemHash,
                    Narrative: _Narrative,
                    ObjectiveVerbName: _ObjectiveVerbName,
                    QuestTypeIdentifier: _QuestTypeIdentifier,
                    QuestTypeHash: _QuestTypeHash,
                    PerObjectiveDisplayProperties: _PerObjectiveDisplayProperties,
                    DisplayAsStatTracker: _DisplayAsStatTracker
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}