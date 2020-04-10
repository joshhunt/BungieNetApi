using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyTalentExclusiveGroup:  IEquatable<DestinyDefinitionsDestinyTalentExclusiveGroup>
    { 
        /// <summary>
        /// The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.
        /// </summary>
        public int? GroupHash { get; private set; }

        /// <summary>
        /// If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.
        /// </summary>
        public int? LoreHash { get; private set; }

        /// <summary>
        /// A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
        /// </summary>
        public List<int?> NodeHashes { get; private set; }

        /// <summary>
        /// A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.
        /// </summary>
        public List<int?> OpposingGroupHashes { get; private set; }

        /// <summary>
        /// A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
        /// </summary>
        public List<int?> OpposingNodeHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyTalentExclusiveGroup.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyTalentExclusiveGroup()
        {
        }

        private DestinyDefinitionsDestinyTalentExclusiveGroup(int? GroupHash, int? LoreHash, List<int?> NodeHashes, List<int?> OpposingGroupHashes, List<int?> OpposingNodeHashes)
        {
            
            this.GroupHash = GroupHash;
            
            this.LoreHash = LoreHash;
            
            this.NodeHashes = NodeHashes;
            
            this.OpposingGroupHashes = OpposingGroupHashes;
            
            this.OpposingNodeHashes = OpposingNodeHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyTalentExclusiveGroup.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentExclusiveGroupBuilder</returns>
        public static DestinyDefinitionsDestinyTalentExclusiveGroupBuilder Builder()
        {
            return new DestinyDefinitionsDestinyTalentExclusiveGroupBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyTalentExclusiveGroupBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentExclusiveGroupBuilder</returns>
        public DestinyDefinitionsDestinyTalentExclusiveGroupBuilder With()
        {
            return Builder()
                .GroupHash(GroupHash)
                .LoreHash(LoreHash)
                .NodeHashes(NodeHashes)
                .OpposingGroupHashes(OpposingGroupHashes)
                .OpposingNodeHashes(OpposingNodeHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyTalentExclusiveGroup other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyTalentExclusiveGroup.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentExclusiveGroup</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentExclusiveGroup</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyTalentExclusiveGroup left, DestinyDefinitionsDestinyTalentExclusiveGroup right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyTalentExclusiveGroup.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentExclusiveGroup</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentExclusiveGroup</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyTalentExclusiveGroup left, DestinyDefinitionsDestinyTalentExclusiveGroup right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyTalentExclusiveGroup.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyTalentExclusiveGroupBuilder
        {
            private int? _GroupHash;
            private int? _LoreHash;
            private List<int?> _NodeHashes;
            private List<int?> _OpposingGroupHashes;
            private List<int?> _OpposingNodeHashes;

            internal DestinyDefinitionsDestinyTalentExclusiveGroupBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentExclusiveGroup.GroupHash property.
            /// </summary>
            /// <param name="value">The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.</param>
            public DestinyDefinitionsDestinyTalentExclusiveGroupBuilder GroupHash(int? value)
            {
                _GroupHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentExclusiveGroup.LoreHash property.
            /// </summary>
            /// <param name="value">If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.</param>
            public DestinyDefinitionsDestinyTalentExclusiveGroupBuilder LoreHash(int? value)
            {
                _LoreHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentExclusiveGroup.NodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)</param>
            public DestinyDefinitionsDestinyTalentExclusiveGroupBuilder NodeHashes(List<int?> value)
            {
                _NodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentExclusiveGroup.OpposingGroupHashes property.
            /// </summary>
            /// <param name="value">A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.</param>
            public DestinyDefinitionsDestinyTalentExclusiveGroupBuilder OpposingGroupHashes(List<int?> value)
            {
                _OpposingGroupHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentExclusiveGroup.OpposingNodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)</param>
            public DestinyDefinitionsDestinyTalentExclusiveGroupBuilder OpposingNodeHashes(List<int?> value)
            {
                _OpposingNodeHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyTalentExclusiveGroup.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyTalentExclusiveGroup</returns>
            public DestinyDefinitionsDestinyTalentExclusiveGroup Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyTalentExclusiveGroup(
                    GroupHash: _GroupHash,
                    LoreHash: _LoreHash,
                    NodeHashes: _NodeHashes,
                    OpposingGroupHashes: _OpposingGroupHashes,
                    OpposingNodeHashes: _OpposingNodeHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}