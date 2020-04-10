using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// I see you&#39;ve come to find out more about Talent Nodes. I&#39;m so sorry. Talent Nodes are the conceptual, visual nodes that appear on Talent Grids. Talent Grids, in Destiny 1, were found on almost every instanced item: they had Nodes that could be activated to change the properties of the item. In Destiny 2, Talent Grids only exist for Builds/Subclasses, and while the basic concept is the same (Nodes can be activated once you&#39;ve gained sufficient Experience on the Item, and provide effects), there are some new concepts from Destiny 1. Examine DestinyTalentGridDefinition and its subordinates for more information. This is the \&quot;Live\&quot; information for the current status of a Talent Node on a specific item. Talent Nodes have many Steps, but only one can be active at any one time: and it is the Step that determines both the visual and the game state-changing properties that the Node provides. Examine this and DestinyTalentNodeStepDefinition carefully. *IMPORTANT NOTE* Talent Nodes are, unfortunately, Content Version DEPENDENT. Though they refer to hashes for Nodes and Steps, those hashes are not guaranteed to be immutable across content versions. This is a source of great exasperation for me, but as a result anyone using Talent Grid data must ensure that the content version of their static content matches that of the server responses before showing or making decisions based on talent grid data.
    /// </summary>
    public sealed class DestinyDestinyTalentNode:  IEquatable<DestinyDestinyTalentNode>
    { 
        /// <summary>
        /// The index of the Talent Node being referred to (an index into DestinyTalentGridDefinition.nodes[]). CONTENT VERSION DEPENDENT.
        /// </summary>
        public int? NodeIndex { get; private set; }

        /// <summary>
        /// The hash of the Talent Node being referred to (in DestinyTalentGridDefinition.nodes). Deceptively CONTENT VERSION DEPENDENT. We have no guarantee of the hash&#39;s immutability between content versions.
        /// </summary>
        public int? NodeHash { get; private set; }

        /// <summary>
        /// An DestinyTalentNodeState enum value indicating the node&#39;s state: whether it can be activated or swapped, and why not if neither can be performed.
        /// </summary>
        public int? State { get; private set; }

        /// <summary>
        /// If true, the node is activated: it&#39;s current step then provides its benefits.
        /// </summary>
        public bool? IsActivated { get; private set; }

        /// <summary>
        /// The currently relevant Step for the node. It is this step that has rendering data for the node and the benefits that are provided if the node is activated. (the actual rules for benefits provided are extremely complicated in theory, but with how Talent Grids are being used in Destiny 2 you don&#39;t have to worry about a lot of those old Destiny 1 rules.) This is an index into: DestinyTalentGridDefinition.nodes[nodeIndex].steps[stepIndex]
        /// </summary>
        public int? StepIndex { get; private set; }

        /// <summary>
        /// If the node has material requirements to be activated, this is the list of those requirements.
        /// </summary>
        public List<DestinyDefinitionsDestinyMaterialRequirement> MaterialsToUpgrade { get; private set; }

        /// <summary>
        /// The progression level required on the Talent Grid in order to be able to activate this talent node. Talent Grids have their own Progression - similar to Character Level, but in this case it is experience related to the item itself.
        /// </summary>
        public int? ActivationGridLevel { get; private set; }

        /// <summary>
        /// If you want to show a progress bar or circle for how close this talent node is to being activate-able, this is the percentage to show. It follows the node&#39;s underlying rules about when the progress bar should first show up, and when it should be filled.
        /// </summary>
        public float? ProgressPercent { get; private set; }

        /// <summary>
        /// Whether or not the talent node is actually visible in the game&#39;s UI. Whether you want to show it in your own UI is up to you! I&#39;m not gonna tell you who to sock it to.
        /// </summary>
        public bool? Hidden { get; private set; }

        /// <summary>
        /// This property has some history. A talent grid can provide stats on both the item it&#39;s related to and the character equipping the item. This returns data about those stat bonuses.
        /// </summary>
        public DestinyDestinyTalentNodeStatBlock NodeStatsBlock { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyTalentNode.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyTalentNode()
        {
        }

        private DestinyDestinyTalentNode(int? NodeIndex, int? NodeHash, int? State, bool? IsActivated, int? StepIndex, List<DestinyDefinitionsDestinyMaterialRequirement> MaterialsToUpgrade, int? ActivationGridLevel, float? ProgressPercent, bool? Hidden, DestinyDestinyTalentNodeStatBlock NodeStatsBlock)
        {
            
            this.NodeIndex = NodeIndex;
            
            this.NodeHash = NodeHash;
            
            this.State = State;
            
            this.IsActivated = IsActivated;
            
            this.StepIndex = StepIndex;
            
            this.MaterialsToUpgrade = MaterialsToUpgrade;
            
            this.ActivationGridLevel = ActivationGridLevel;
            
            this.ProgressPercent = ProgressPercent;
            
            this.Hidden = Hidden;
            
            this.NodeStatsBlock = NodeStatsBlock;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyTalentNode.
        /// </summary>
        /// <returns>DestinyDestinyTalentNodeBuilder</returns>
        public static DestinyDestinyTalentNodeBuilder Builder()
        {
            return new DestinyDestinyTalentNodeBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyTalentNodeBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyTalentNodeBuilder</returns>
        public DestinyDestinyTalentNodeBuilder With()
        {
            return Builder()
                .NodeIndex(NodeIndex)
                .NodeHash(NodeHash)
                .State(State)
                .IsActivated(IsActivated)
                .StepIndex(StepIndex)
                .MaterialsToUpgrade(MaterialsToUpgrade)
                .ActivationGridLevel(ActivationGridLevel)
                .ProgressPercent(ProgressPercent)
                .Hidden(Hidden)
                .NodeStatsBlock(NodeStatsBlock);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyTalentNode other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyTalentNode.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyTalentNode</param>
        /// <param name="right">Compared (DestinyDestinyTalentNode</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyTalentNode left, DestinyDestinyTalentNode right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyTalentNode.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyTalentNode</param>
        /// <param name="right">Compared (DestinyDestinyTalentNode</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyTalentNode left, DestinyDestinyTalentNode right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyTalentNode.
        /// </summary>
        public sealed class DestinyDestinyTalentNodeBuilder
        {
            private int? _NodeIndex;
            private int? _NodeHash;
            private int? _State;
            private bool? _IsActivated;
            private int? _StepIndex;
            private List<DestinyDefinitionsDestinyMaterialRequirement> _MaterialsToUpgrade;
            private int? _ActivationGridLevel;
            private float? _ProgressPercent;
            private bool? _Hidden;
            private DestinyDestinyTalentNodeStatBlock _NodeStatsBlock;

            internal DestinyDestinyTalentNodeBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.NodeIndex property.
            /// </summary>
            /// <param name="value">The index of the Talent Node being referred to (an index into DestinyTalentGridDefinition.nodes[]). CONTENT VERSION DEPENDENT.</param>
            public DestinyDestinyTalentNodeBuilder NodeIndex(int? value)
            {
                _NodeIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.NodeHash property.
            /// </summary>
            /// <param name="value">The hash of the Talent Node being referred to (in DestinyTalentGridDefinition.nodes). Deceptively CONTENT VERSION DEPENDENT. We have no guarantee of the hash&#39;s immutability between content versions.</param>
            public DestinyDestinyTalentNodeBuilder NodeHash(int? value)
            {
                _NodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.State property.
            /// </summary>
            /// <param name="value">An DestinyTalentNodeState enum value indicating the node&#39;s state: whether it can be activated or swapped, and why not if neither can be performed.</param>
            public DestinyDestinyTalentNodeBuilder State(int? value)
            {
                _State = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.IsActivated property.
            /// </summary>
            /// <param name="value">If true, the node is activated: it&#39;s current step then provides its benefits.</param>
            public DestinyDestinyTalentNodeBuilder IsActivated(bool? value)
            {
                _IsActivated = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.StepIndex property.
            /// </summary>
            /// <param name="value">The currently relevant Step for the node. It is this step that has rendering data for the node and the benefits that are provided if the node is activated. (the actual rules for benefits provided are extremely complicated in theory, but with how Talent Grids are being used in Destiny 2 you don&#39;t have to worry about a lot of those old Destiny 1 rules.) This is an index into: DestinyTalentGridDefinition.nodes[nodeIndex].steps[stepIndex]</param>
            public DestinyDestinyTalentNodeBuilder StepIndex(int? value)
            {
                _StepIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.MaterialsToUpgrade property.
            /// </summary>
            /// <param name="value">If the node has material requirements to be activated, this is the list of those requirements.</param>
            public DestinyDestinyTalentNodeBuilder MaterialsToUpgrade(List<DestinyDefinitionsDestinyMaterialRequirement> value)
            {
                _MaterialsToUpgrade = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.ActivationGridLevel property.
            /// </summary>
            /// <param name="value">The progression level required on the Talent Grid in order to be able to activate this talent node. Talent Grids have their own Progression - similar to Character Level, but in this case it is experience related to the item itself.</param>
            public DestinyDestinyTalentNodeBuilder ActivationGridLevel(int? value)
            {
                _ActivationGridLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.ProgressPercent property.
            /// </summary>
            /// <param name="value">If you want to show a progress bar or circle for how close this talent node is to being activate-able, this is the percentage to show. It follows the node&#39;s underlying rules about when the progress bar should first show up, and when it should be filled.</param>
            public DestinyDestinyTalentNodeBuilder ProgressPercent(float? value)
            {
                _ProgressPercent = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.Hidden property.
            /// </summary>
            /// <param name="value">Whether or not the talent node is actually visible in the game&#39;s UI. Whether you want to show it in your own UI is up to you! I&#39;m not gonna tell you who to sock it to.</param>
            public DestinyDestinyTalentNodeBuilder Hidden(bool? value)
            {
                _Hidden = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNode.NodeStatsBlock property.
            /// </summary>
            /// <param name="value">This property has some history. A talent grid can provide stats on both the item it&#39;s related to and the character equipping the item. This returns data about those stat bonuses.</param>
            public DestinyDestinyTalentNodeBuilder NodeStatsBlock(DestinyDestinyTalentNodeStatBlock value)
            {
                _NodeStatsBlock = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyTalentNode.
            /// </summary>
            /// <returns>DestinyDestinyTalentNode</returns>
            public DestinyDestinyTalentNode Build()
            {
                Validate();
                return new DestinyDestinyTalentNode(
                    NodeIndex: _NodeIndex,
                    NodeHash: _NodeHash,
                    State: _State,
                    IsActivated: _IsActivated,
                    StepIndex: _StepIndex,
                    MaterialsToUpgrade: _MaterialsToUpgrade,
                    ActivationGridLevel: _ActivationGridLevel,
                    ProgressPercent: _ProgressPercent,
                    Hidden: _Hidden,
                    NodeStatsBlock: _NodeStatsBlock
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}