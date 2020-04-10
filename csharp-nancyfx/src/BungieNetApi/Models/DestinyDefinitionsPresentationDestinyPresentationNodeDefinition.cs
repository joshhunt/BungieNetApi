using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A PresentationNode is an entity that represents a logical grouping of other entities visually/organizationally.  For now, Presentation Nodes may contain the following... but it may be used for more in the future:  - Collectibles - Records (Or, as the public will call them, \&quot;Triumphs.\&quot; Don&#39;t ask me why we&#39;re overloading the term \&quot;Triumph\&quot;, it still hurts me to think about it) - Metrics (aka Stat Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created  Part of me wants to break these into conceptual definitions per entity being collected, but the possibility of these different types being mixed in the same UI and the possibility that it could actually be more useful to return the \&quot;bare metal\&quot; presentation node concept has resulted in me deciding against that for the time being.  We&#39;ll see if I come to regret this as well.
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeDefinition:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The original icon for this presentation node, before we futzed with it.
        /// </summary>
        public string OriginalIcon { get; private set; }

        /// <summary>
        /// Some presentation nodes are meant to be explicitly shown on the \&quot;root\&quot; or \&quot;entry\&quot; screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \&quot;entry point\&quot; view in your UI. If you don&#39;t have a UI, then I guess it doesn&#39;t matter either way does it?
        /// </summary>
        public string RootViewIcon { get; private set; }

        /// <summary>
        /// NodeType
        /// </summary>
        public int? NodeType { get; private set; }

        /// <summary>
        /// Indicates whether this presentation node&#39;s state is determined on a per-character or on an account-wide basis.
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.
        /// </summary>
        public int? ObjectiveHash { get; private set; }

        /// <summary>
        /// If this presentation node has an associated \&quot;Record\&quot; that you can accomplish for completing its children, this is the identifier of that Record.
        /// </summary>
        public int? CompletionRecordHash { get; private set; }

        /// <summary>
        /// The child entities contained by this presentation node.
        /// </summary>
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock Children { get; private set; }

        /// <summary>
        /// A hint for how to display this presentation node when it&#39;s shown in a list.
        /// </summary>
        public int? DisplayStyle { get; private set; }

        /// <summary>
        /// A hint for how to display this presentation node when it&#39;s shown in its own detail screen.
        /// </summary>
        public int? ScreenStyle { get; private set; }

        /// <summary>
        /// The requirements for being able to interact with this presentation node and its children.
        /// </summary>
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; private set; }

        /// <summary>
        /// If this presentation node has children, but the game doesn&#39;t let you inspect the details of those children, that is indicated here.
        /// </summary>
        public bool? DisableChildSubscreenNavigation { get; private set; }

        /// <summary>
        /// PresentationNodeType
        /// </summary>
        public int? PresentationNodeType { get; private set; }

        /// <summary>
        /// TraitIds
        /// </summary>
        public List<string> TraitIds { get; private set; }

        /// <summary>
        /// TraitHashes
        /// </summary>
        public List<int?> TraitHashes { get; private set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        public List<int?> ParentNodeHashes { get; private set; }

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
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeDefinition()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string OriginalIcon, string RootViewIcon, int? NodeType, int? Scope, int? ObjectiveHash, int? CompletionRecordHash, DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock Children, int? DisplayStyle, int? ScreenStyle, DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements, bool? DisableChildSubscreenNavigation, int? PresentationNodeType, List<string> TraitIds, List<int?> TraitHashes, List<int?> ParentNodeHashes, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.OriginalIcon = OriginalIcon;
            
            this.RootViewIcon = RootViewIcon;
            
            this.NodeType = NodeType;
            
            this.Scope = Scope;
            
            this.ObjectiveHash = ObjectiveHash;
            
            this.CompletionRecordHash = CompletionRecordHash;
            
            this.Children = Children;
            
            this.DisplayStyle = DisplayStyle;
            
            this.ScreenStyle = ScreenStyle;
            
            this.Requirements = Requirements;
            
            this.DisableChildSubscreenNavigation = DisableChildSubscreenNavigation;
            
            this.PresentationNodeType = PresentationNodeType;
            
            this.TraitIds = TraitIds;
            
            this.TraitHashes = TraitHashes;
            
            this.ParentNodeHashes = ParentNodeHashes;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .OriginalIcon(OriginalIcon)
                .RootViewIcon(RootViewIcon)
                .NodeType(NodeType)
                .Scope(Scope)
                .ObjectiveHash(ObjectiveHash)
                .CompletionRecordHash(CompletionRecordHash)
                .Children(Children)
                .DisplayStyle(DisplayStyle)
                .ScreenStyle(ScreenStyle)
                .Requirements(Requirements)
                .DisableChildSubscreenNavigation(DisableChildSubscreenNavigation)
                .PresentationNodeType(PresentationNodeType)
                .TraitIds(TraitIds)
                .TraitHashes(TraitHashes)
                .ParentNodeHashes(ParentNodeHashes)
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

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition left, DestinyDefinitionsPresentationDestinyPresentationNodeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeDefinition left, DestinyDefinitionsPresentationDestinyPresentationNodeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _OriginalIcon;
            private string _RootViewIcon;
            private int? _NodeType;
            private int? _Scope;
            private int? _ObjectiveHash;
            private int? _CompletionRecordHash;
            private DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock _Children;
            private int? _DisplayStyle;
            private int? _ScreenStyle;
            private DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock _Requirements;
            private bool? _DisableChildSubscreenNavigation;
            private int? _PresentationNodeType;
            private List<string> _TraitIds;
            private List<int?> _TraitHashes;
            private List<int?> _ParentNodeHashes;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.OriginalIcon property.
            /// </summary>
            /// <param name="value">The original icon for this presentation node, before we futzed with it.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder OriginalIcon(string value)
            {
                _OriginalIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.RootViewIcon property.
            /// </summary>
            /// <param name="value">Some presentation nodes are meant to be explicitly shown on the \&quot;root\&quot; or \&quot;entry\&quot; screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \&quot;entry point\&quot; view in your UI. If you don&#39;t have a UI, then I guess it doesn&#39;t matter either way does it?</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder RootViewIcon(string value)
            {
                _RootViewIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.NodeType property.
            /// </summary>
            /// <param name="value">NodeType</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder NodeType(int? value)
            {
                _NodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Scope property.
            /// </summary>
            /// <param name="value">Indicates whether this presentation node&#39;s state is determined on a per-character or on an account-wide basis.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.ObjectiveHash property.
            /// </summary>
            /// <param name="value">If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.CompletionRecordHash property.
            /// </summary>
            /// <param name="value">If this presentation node has an associated \&quot;Record\&quot; that you can accomplish for completing its children, this is the identifier of that Record.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder CompletionRecordHash(int? value)
            {
                _CompletionRecordHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Children property.
            /// </summary>
            /// <param name="value">The child entities contained by this presentation node.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Children(DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock value)
            {
                _Children = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.DisplayStyle property.
            /// </summary>
            /// <param name="value">A hint for how to display this presentation node when it&#39;s shown in a list.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder DisplayStyle(int? value)
            {
                _DisplayStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.ScreenStyle property.
            /// </summary>
            /// <param name="value">A hint for how to display this presentation node when it&#39;s shown in its own detail screen.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder ScreenStyle(int? value)
            {
                _ScreenStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Requirements property.
            /// </summary>
            /// <param name="value">The requirements for being able to interact with this presentation node and its children.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Requirements(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock value)
            {
                _Requirements = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.DisableChildSubscreenNavigation property.
            /// </summary>
            /// <param name="value">If this presentation node has children, but the game doesn&#39;t let you inspect the details of those children, that is indicated here.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder DisableChildSubscreenNavigation(bool? value)
            {
                _DisableChildSubscreenNavigation = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.PresentationNodeType property.
            /// </summary>
            /// <param name="value">PresentationNodeType</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder PresentationNodeType(int? value)
            {
                _PresentationNodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">TraitIds</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.TraitHashes property.
            /// </summary>
            /// <param name="value">TraitHashes</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder TraitHashes(List<int?> value)
            {
                _TraitHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.ParentNodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder ParentNodeHashes(List<int?> value)
            {
                _ParentNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeDefinition</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeDefinition(
                    DisplayProperties: _DisplayProperties,
                    OriginalIcon: _OriginalIcon,
                    RootViewIcon: _RootViewIcon,
                    NodeType: _NodeType,
                    Scope: _Scope,
                    ObjectiveHash: _ObjectiveHash,
                    CompletionRecordHash: _CompletionRecordHash,
                    Children: _Children,
                    DisplayStyle: _DisplayStyle,
                    ScreenStyle: _ScreenStyle,
                    Requirements: _Requirements,
                    DisableChildSubscreenNavigation: _DisableChildSubscreenNavigation,
                    PresentationNodeType: _PresentationNodeType,
                    TraitIds: _TraitIds,
                    TraitHashes: _TraitHashes,
                    ParentNodeHashes: _ParentNodeHashes,
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