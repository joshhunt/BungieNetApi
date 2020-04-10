using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Talent Grids on items have Nodes. These nodes have positions in the talent grid&#39;s UI, and contain \&quot;Steps\&quot; (DestinyTalentNodeStepDefinition), one of whom will be the \&quot;Current\&quot; step.  The Current Step determines the visual properties of the node, as well as what the node grants when it is activated.  See DestinyTalentGridDefinition for a more complete overview of how Talent Grids work, and how they are used in Destiny 2 (and how they were used in Destiny 1).
    /// </summary>
    public sealed class DestinyDefinitionsDestinyTalentNodeDefinition:  IEquatable<DestinyDefinitionsDestinyTalentNodeDefinition>
    { 
        /// <summary>
        /// The index into the DestinyTalentGridDefinition&#39;s \&quot;nodes\&quot; property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.
        /// </summary>
        public int? NodeIndex { get; private set; }

        /// <summary>
        /// The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!
        /// </summary>
        public int? NodeHash { get; private set; }

        /// <summary>
        /// The visual \&quot;row\&quot; where the node should be shown in the UI. If negative, then the node is hidden.
        /// </summary>
        public int? Row { get; private set; }

        /// <summary>
        /// The visual \&quot;column\&quot; where the node should be shown in the UI. If negative, the node is hidden.
        /// </summary>
        public int? Column { get; private set; }

        /// <summary>
        /// Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time.
        /// </summary>
        public List<int?> PrerequisiteNodeIndexes { get; private set; }

        /// <summary>
        /// At one point, Talent Nodes supported the idea of \&quot;Binary Pairs\&quot;: nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.
        /// </summary>
        public int? BinaryPairNodeIndex { get; private set; }

        /// <summary>
        /// If true, this node will automatically unlock when the Talent Grid&#39;s level reaches the required level of the current step of this node.
        /// </summary>
        public bool? AutoUnlocks { get; private set; }

        /// <summary>
        /// At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn&#39;t out of the question that this could end up being used again in a theoretical future.
        /// </summary>
        public bool? LastStepRepeats { get; private set; }

        /// <summary>
        /// If this is true, the node&#39;s step is determined randomly rather than the first step being chosen.
        /// </summary>
        public bool? IsRandom { get; private set; }

        /// <summary>
        /// At one point, you were going to be able to repurchase talent nodes that had random steps, to \&quot;re-roll\&quot; the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!
        /// </summary>
        public DestinyDefinitionsDestinyNodeActivationRequirement RandomActivationRequirement { get; private set; }

        /// <summary>
        /// If this is true, the node can be \&quot;re-rolled\&quot; to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.
        /// </summary>
        public bool? IsRandomRepurchasable { get; private set; }

        /// <summary>
        /// At this point, \&quot;steps\&quot; have been obfuscated into conceptual entities, aggregating the underlying notions of \&quot;properties\&quot; and \&quot;true steps\&quot;.  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you&#39;ll have to use the \&quot;realSteps\&quot; property below.
        /// </summary>
        public List<DestinyDefinitionsDestinyNodeStepDefinition> Steps { get; private set; }

        /// <summary>
        /// The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes.
        /// </summary>
        public List<int?> ExclusiveWithNodeHashes { get; private set; }

        /// <summary>
        /// If the node&#39;s step is randomly selected, this is the amount of the Talent Grid&#39;s progression experience at which the progression bar for the node should be shown.
        /// </summary>
        public int? RandomStartProgressionBarAtProgression { get; private set; }

        /// <summary>
        /// A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.
        /// </summary>
        public string LayoutIdentifier { get; private set; }

        /// <summary>
        /// As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node&#39;s group, if it is part of one.
        /// </summary>
        public int? GroupHash { get; private set; }

        /// <summary>
        /// Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.
        /// </summary>
        public int? LoreHash { get; private set; }

        /// <summary>
        /// Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.
        /// </summary>
        public string NodeStyleIdentifier { get; private set; }

        /// <summary>
        /// Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.
        /// </summary>
        public bool? IgnoreForCompletion { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyTalentNodeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyTalentNodeDefinition()
        {
        }

        private DestinyDefinitionsDestinyTalentNodeDefinition(int? NodeIndex, int? NodeHash, int? Row, int? Column, List<int?> PrerequisiteNodeIndexes, int? BinaryPairNodeIndex, bool? AutoUnlocks, bool? LastStepRepeats, bool? IsRandom, DestinyDefinitionsDestinyNodeActivationRequirement RandomActivationRequirement, bool? IsRandomRepurchasable, List<DestinyDefinitionsDestinyNodeStepDefinition> Steps, List<int?> ExclusiveWithNodeHashes, int? RandomStartProgressionBarAtProgression, string LayoutIdentifier, int? GroupHash, int? LoreHash, string NodeStyleIdentifier, bool? IgnoreForCompletion)
        {
            
            this.NodeIndex = NodeIndex;
            
            this.NodeHash = NodeHash;
            
            this.Row = Row;
            
            this.Column = Column;
            
            this.PrerequisiteNodeIndexes = PrerequisiteNodeIndexes;
            
            this.BinaryPairNodeIndex = BinaryPairNodeIndex;
            
            this.AutoUnlocks = AutoUnlocks;
            
            this.LastStepRepeats = LastStepRepeats;
            
            this.IsRandom = IsRandom;
            
            this.RandomActivationRequirement = RandomActivationRequirement;
            
            this.IsRandomRepurchasable = IsRandomRepurchasable;
            
            this.Steps = Steps;
            
            this.ExclusiveWithNodeHashes = ExclusiveWithNodeHashes;
            
            this.RandomStartProgressionBarAtProgression = RandomStartProgressionBarAtProgression;
            
            this.LayoutIdentifier = LayoutIdentifier;
            
            this.GroupHash = GroupHash;
            
            this.LoreHash = LoreHash;
            
            this.NodeStyleIdentifier = NodeStyleIdentifier;
            
            this.IgnoreForCompletion = IgnoreForCompletion;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyTalentNodeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyTalentNodeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyTalentNodeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyTalentNodeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder With()
        {
            return Builder()
                .NodeIndex(NodeIndex)
                .NodeHash(NodeHash)
                .Row(Row)
                .Column(Column)
                .PrerequisiteNodeIndexes(PrerequisiteNodeIndexes)
                .BinaryPairNodeIndex(BinaryPairNodeIndex)
                .AutoUnlocks(AutoUnlocks)
                .LastStepRepeats(LastStepRepeats)
                .IsRandom(IsRandom)
                .RandomActivationRequirement(RandomActivationRequirement)
                .IsRandomRepurchasable(IsRandomRepurchasable)
                .Steps(Steps)
                .ExclusiveWithNodeHashes(ExclusiveWithNodeHashes)
                .RandomStartProgressionBarAtProgression(RandomStartProgressionBarAtProgression)
                .LayoutIdentifier(LayoutIdentifier)
                .GroupHash(GroupHash)
                .LoreHash(LoreHash)
                .NodeStyleIdentifier(NodeStyleIdentifier)
                .IgnoreForCompletion(IgnoreForCompletion);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyTalentNodeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyTalentNodeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyTalentNodeDefinition left, DestinyDefinitionsDestinyTalentNodeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyTalentNodeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyTalentNodeDefinition left, DestinyDefinitionsDestinyTalentNodeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyTalentNodeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyTalentNodeDefinitionBuilder
        {
            private int? _NodeIndex;
            private int? _NodeHash;
            private int? _Row;
            private int? _Column;
            private List<int?> _PrerequisiteNodeIndexes;
            private int? _BinaryPairNodeIndex;
            private bool? _AutoUnlocks;
            private bool? _LastStepRepeats;
            private bool? _IsRandom;
            private DestinyDefinitionsDestinyNodeActivationRequirement _RandomActivationRequirement;
            private bool? _IsRandomRepurchasable;
            private List<DestinyDefinitionsDestinyNodeStepDefinition> _Steps;
            private List<int?> _ExclusiveWithNodeHashes;
            private int? _RandomStartProgressionBarAtProgression;
            private string _LayoutIdentifier;
            private int? _GroupHash;
            private int? _LoreHash;
            private string _NodeStyleIdentifier;
            private bool? _IgnoreForCompletion;

            internal DestinyDefinitionsDestinyTalentNodeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.NodeIndex property.
            /// </summary>
            /// <param name="value">The index into the DestinyTalentGridDefinition&#39;s \&quot;nodes\&quot; property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder NodeIndex(int? value)
            {
                _NodeIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.NodeHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder NodeHash(int? value)
            {
                _NodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.Row property.
            /// </summary>
            /// <param name="value">The visual \&quot;row\&quot; where the node should be shown in the UI. If negative, then the node is hidden.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder Row(int? value)
            {
                _Row = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.Column property.
            /// </summary>
            /// <param name="value">The visual \&quot;column\&quot; where the node should be shown in the UI. If negative, the node is hidden.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder Column(int? value)
            {
                _Column = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.PrerequisiteNodeIndexes property.
            /// </summary>
            /// <param name="value">Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder PrerequisiteNodeIndexes(List<int?> value)
            {
                _PrerequisiteNodeIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.BinaryPairNodeIndex property.
            /// </summary>
            /// <param name="value">At one point, Talent Nodes supported the idea of \&quot;Binary Pairs\&quot;: nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder BinaryPairNodeIndex(int? value)
            {
                _BinaryPairNodeIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.AutoUnlocks property.
            /// </summary>
            /// <param name="value">If true, this node will automatically unlock when the Talent Grid&#39;s level reaches the required level of the current step of this node.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder AutoUnlocks(bool? value)
            {
                _AutoUnlocks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.LastStepRepeats property.
            /// </summary>
            /// <param name="value">At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn&#39;t out of the question that this could end up being used again in a theoretical future.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder LastStepRepeats(bool? value)
            {
                _LastStepRepeats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.IsRandom property.
            /// </summary>
            /// <param name="value">If this is true, the node&#39;s step is determined randomly rather than the first step being chosen.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder IsRandom(bool? value)
            {
                _IsRandom = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.RandomActivationRequirement property.
            /// </summary>
            /// <param name="value">At one point, you were going to be able to repurchase talent nodes that had random steps, to \&quot;re-roll\&quot; the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder RandomActivationRequirement(DestinyDefinitionsDestinyNodeActivationRequirement value)
            {
                _RandomActivationRequirement = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.IsRandomRepurchasable property.
            /// </summary>
            /// <param name="value">If this is true, the node can be \&quot;re-rolled\&quot; to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder IsRandomRepurchasable(bool? value)
            {
                _IsRandomRepurchasable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.Steps property.
            /// </summary>
            /// <param name="value">At this point, \&quot;steps\&quot; have been obfuscated into conceptual entities, aggregating the underlying notions of \&quot;properties\&quot; and \&quot;true steps\&quot;.  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you&#39;ll have to use the \&quot;realSteps\&quot; property below.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder Steps(List<DestinyDefinitionsDestinyNodeStepDefinition> value)
            {
                _Steps = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.ExclusiveWithNodeHashes property.
            /// </summary>
            /// <param name="value">The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder ExclusiveWithNodeHashes(List<int?> value)
            {
                _ExclusiveWithNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.RandomStartProgressionBarAtProgression property.
            /// </summary>
            /// <param name="value">If the node&#39;s step is randomly selected, this is the amount of the Talent Grid&#39;s progression experience at which the progression bar for the node should be shown.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder RandomStartProgressionBarAtProgression(int? value)
            {
                _RandomStartProgressionBarAtProgression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.LayoutIdentifier property.
            /// </summary>
            /// <param name="value">A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder LayoutIdentifier(string value)
            {
                _LayoutIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.GroupHash property.
            /// </summary>
            /// <param name="value">As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node&#39;s group, if it is part of one.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder GroupHash(int? value)
            {
                _GroupHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.LoreHash property.
            /// </summary>
            /// <param name="value">Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder LoreHash(int? value)
            {
                _LoreHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.NodeStyleIdentifier property.
            /// </summary>
            /// <param name="value">Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder NodeStyleIdentifier(string value)
            {
                _NodeStyleIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeDefinition.IgnoreForCompletion property.
            /// </summary>
            /// <param name="value">Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.</param>
            public DestinyDefinitionsDestinyTalentNodeDefinitionBuilder IgnoreForCompletion(bool? value)
            {
                _IgnoreForCompletion = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyTalentNodeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyTalentNodeDefinition</returns>
            public DestinyDefinitionsDestinyTalentNodeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyTalentNodeDefinition(
                    NodeIndex: _NodeIndex,
                    NodeHash: _NodeHash,
                    Row: _Row,
                    Column: _Column,
                    PrerequisiteNodeIndexes: _PrerequisiteNodeIndexes,
                    BinaryPairNodeIndex: _BinaryPairNodeIndex,
                    AutoUnlocks: _AutoUnlocks,
                    LastStepRepeats: _LastStepRepeats,
                    IsRandom: _IsRandom,
                    RandomActivationRequirement: _RandomActivationRequirement,
                    IsRandomRepurchasable: _IsRandomRepurchasable,
                    Steps: _Steps,
                    ExclusiveWithNodeHashes: _ExclusiveWithNodeHashes,
                    RandomStartProgressionBarAtProgression: _RandomStartProgressionBarAtProgression,
                    LayoutIdentifier: _LayoutIdentifier,
                    GroupHash: _GroupHash,
                    LoreHash: _LoreHash,
                    NodeStyleIdentifier: _NodeStyleIdentifier,
                    IgnoreForCompletion: _IgnoreForCompletion
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}