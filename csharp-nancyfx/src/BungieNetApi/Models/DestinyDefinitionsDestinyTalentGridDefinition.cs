using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The time has unfortunately come to talk about Talent Grids.  Talent Grids are the most complex and unintuitive part of the Destiny Definition data. Grab a cup of coffee before we begin, I can wait.  Talent Grids were the primary way that items could be customized in Destiny 1. In Destiny 2, for now, talent grids have become exclusively used by Subclass/Build items: but the system is still in place for it to be used by items should the direction change back toward talent grids.  Talent Grids have Nodes: the visual circles on the talent grid detail screen that have icons and can be activated if you meet certain requirements and pay costs. The actual visual data and effects, however, are driven by the \&quot;Steps\&quot; on Talent Nodes. Any given node will have 1:M of these steps, and the specific step that will be considered the \&quot;current\&quot; step (and thus the dictator of all benefits, visual state, and activation requirements on the Node) will almost always not be determined until an instance of the item is created. This is how, in Destiny 1, items were able to have such a wide variety of what users saw as \&quot;Perks\&quot;: they were actually Talent Grids with nodes that had a wide variety of Steps, randomly chosen at the time of item creation.  Now that Talent Grids are used exclusively by subclasses and builds, all of the properties within still apply: but there are additional visual elements on the Subclass/Build screens that are superimposed on top of the talent nodes. Unfortunately, BNet doesn&#39;t have this data: if you want to build a subclass screen, you will have to provide your own \&quot;decorative\&quot; assets, such as the visual connectors between nodes and the fancy colored-fire-bathed character standing behind the nodes.  DestinyInventoryItem.talentGrid.talentGridHash defines an item&#39;s linked Talent Grid, which brings you to this definition that contains enough satic data about talent grids to make your head spin. These *must* be combined with instanced data - found when live data returns DestinyItemTalentGridComponent - in order to derive meaning. The instanced data will reference nodes and steps within these definitions, which you will then have to look up in the definition and combine with the instanced data to give the user the visual representation of their item&#39;s talent grid.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyTalentGridDefinition:  IEquatable<DestinyDefinitionsDestinyTalentGridDefinition>
    { 
        /// <summary>
        /// The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.
        /// </summary>
        public int? MaxGridLevel { get; private set; }

        /// <summary>
        /// The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \&quot;column\&quot; of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it&#39;s just a bit of interesting history.
        /// </summary>
        public int? GridLevelPerColumn { get; private set; }

        /// <summary>
        /// The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid&#39;s level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition&#39;s activation requirements for more information.
        /// </summary>
        public int? ProgressionHash { get; private set; }

        /// <summary>
        /// The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).
        /// </summary>
        public List<DestinyDefinitionsDestinyTalentNodeDefinition> Nodes { get; private set; }

        /// <summary>
        /// Talent Nodes can exist in \&quot;exclusive sets\&quot;: these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \&quot;Swap\&quot;).  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.
        /// </summary>
        public List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> ExclusiveSets { get; private set; }

        /// <summary>
        /// This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.
        /// </summary>
        public List<int?> IndependentNodeIndexes { get; private set; }

        /// <summary>
        /// Talent Nodes can have \&quot;Exclusive Groups\&quot;. These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \&quot;groupHash\&quot; from DestinyTalentExclusiveGroup.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> Groups { get; private set; }

        /// <summary>
        /// BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \&quot;Independent\&quot; nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.
        /// </summary>
        public List<DestinyDefinitionsDestinyTalentNodeCategory> NodeCategories { get; private set; }

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
        /// Use DestinyDefinitionsDestinyTalentGridDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyTalentGridDefinition()
        {
        }

        private DestinyDefinitionsDestinyTalentGridDefinition(int? MaxGridLevel, int? GridLevelPerColumn, int? ProgressionHash, List<DestinyDefinitionsDestinyTalentNodeDefinition> Nodes, List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> ExclusiveSets, List<int?> IndependentNodeIndexes, Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> Groups, List<DestinyDefinitionsDestinyTalentNodeCategory> NodeCategories, int? Hash, int? Index, bool? Redacted)
        {
            
            this.MaxGridLevel = MaxGridLevel;
            
            this.GridLevelPerColumn = GridLevelPerColumn;
            
            this.ProgressionHash = ProgressionHash;
            
            this.Nodes = Nodes;
            
            this.ExclusiveSets = ExclusiveSets;
            
            this.IndependentNodeIndexes = IndependentNodeIndexes;
            
            this.Groups = Groups;
            
            this.NodeCategories = NodeCategories;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyTalentGridDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentGridDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyTalentGridDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyTalentGridDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyTalentGridDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentGridDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyTalentGridDefinitionBuilder With()
        {
            return Builder()
                .MaxGridLevel(MaxGridLevel)
                .GridLevelPerColumn(GridLevelPerColumn)
                .ProgressionHash(ProgressionHash)
                .Nodes(Nodes)
                .ExclusiveSets(ExclusiveSets)
                .IndependentNodeIndexes(IndependentNodeIndexes)
                .Groups(Groups)
                .NodeCategories(NodeCategories)
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

        public bool Equals(DestinyDefinitionsDestinyTalentGridDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyTalentGridDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentGridDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentGridDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyTalentGridDefinition left, DestinyDefinitionsDestinyTalentGridDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyTalentGridDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentGridDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentGridDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyTalentGridDefinition left, DestinyDefinitionsDestinyTalentGridDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyTalentGridDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyTalentGridDefinitionBuilder
        {
            private int? _MaxGridLevel;
            private int? _GridLevelPerColumn;
            private int? _ProgressionHash;
            private List<DestinyDefinitionsDestinyTalentNodeDefinition> _Nodes;
            private List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> _ExclusiveSets;
            private List<int?> _IndependentNodeIndexes;
            private Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> _Groups;
            private List<DestinyDefinitionsDestinyTalentNodeCategory> _NodeCategories;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyTalentGridDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.MaxGridLevel property.
            /// </summary>
            /// <param name="value">The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder MaxGridLevel(int? value)
            {
                _MaxGridLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.GridLevelPerColumn property.
            /// </summary>
            /// <param name="value">The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \&quot;column\&quot; of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it&#39;s just a bit of interesting history.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder GridLevelPerColumn(int? value)
            {
                _GridLevelPerColumn = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.ProgressionHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid&#39;s level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition&#39;s activation requirements for more information.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder ProgressionHash(int? value)
            {
                _ProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.Nodes property.
            /// </summary>
            /// <param name="value">The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder Nodes(List<DestinyDefinitionsDestinyTalentNodeDefinition> value)
            {
                _Nodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.ExclusiveSets property.
            /// </summary>
            /// <param name="value">Talent Nodes can exist in \&quot;exclusive sets\&quot;: these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \&quot;Swap\&quot;).  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder ExclusiveSets(List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> value)
            {
                _ExclusiveSets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.IndependentNodeIndexes property.
            /// </summary>
            /// <param name="value">This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder IndependentNodeIndexes(List<int?> value)
            {
                _IndependentNodeIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.Groups property.
            /// </summary>
            /// <param name="value">Talent Nodes can have \&quot;Exclusive Groups\&quot;. These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \&quot;groupHash\&quot; from DestinyTalentExclusiveGroup.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder Groups(Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> value)
            {
                _Groups = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.NodeCategories property.
            /// </summary>
            /// <param name="value">BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \&quot;Independent\&quot; nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder NodeCategories(List<DestinyDefinitionsDestinyTalentNodeCategory> value)
            {
                _NodeCategories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentGridDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyTalentGridDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyTalentGridDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyTalentGridDefinition</returns>
            public DestinyDefinitionsDestinyTalentGridDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyTalentGridDefinition(
                    MaxGridLevel: _MaxGridLevel,
                    GridLevelPerColumn: _GridLevelPerColumn,
                    ProgressionHash: _ProgressionHash,
                    Nodes: _Nodes,
                    ExclusiveSets: _ExclusiveSets,
                    IndependentNodeIndexes: _IndependentNodeIndexes,
                    Groups: _Groups,
                    NodeCategories: _NodeCategories,
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