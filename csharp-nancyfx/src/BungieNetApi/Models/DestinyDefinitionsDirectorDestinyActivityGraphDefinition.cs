using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a Map View in the director: be them overview views, destination views, or other.  They have nodes which map to activities, and other various visual elements that we (or others) may or may not be able to use.  Activity graphs, most importantly, have nodes which can have activities in various states of playability.  Unfortunately, activity graphs are combined at runtime with Game UI-only assets such as fragments of map images, various in-game special effects, decals etc... that we don&#39;t get in these definitions.  If we end up having time, we may end up trying to manually populate those here: but the last time we tried that, before the lead-up to D1, it proved to be unmaintainable as the game&#39;s content changed. So don&#39;t bet the farm on us providing that content in this definition.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphDefinition>
    { 
        /// <summary>
        /// These represent the visual \&quot;nodes\&quot; on the map&#39;s view. These are the activities you can click on in the map.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition> Nodes { get; private set; }

        /// <summary>
        /// Represents one-off/special UI elements that appear on the map.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition> ArtElements { get; private set; }

        /// <summary>
        /// Represents connections between graph nodes. However, it lacks context that we&#39;d need to make good use of it.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition> Connections { get; private set; }

        /// <summary>
        /// Objectives can display on maps, and this is supposedly metadata for that. I have not had the time to analyze the details of what is useful within however: we could be missing important data to make this work. Expect this property to be expanded on later if possible.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition> DisplayObjectives { get; private set; }

        /// <summary>
        /// Progressions can also display on maps, but similarly to displayObjectives we appear to lack some required information and context right now. We will have to look into it later and add more data if possible.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition> DisplayProgressions { get; private set; }

        /// <summary>
        /// Represents links between this Activity Graph and other ones.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition> LinkedGraphs { get; private set; }

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
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphDefinition(List<DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition> Nodes, List<DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition> ArtElements, List<DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition> Connections, List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition> DisplayObjectives, List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition> DisplayProgressions, List<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition> LinkedGraphs, int? Hash, int? Index, bool? Redacted)
        {
            
            this.Nodes = Nodes;
            
            this.ArtElements = ArtElements;
            
            this.Connections = Connections;
            
            this.DisplayObjectives = DisplayObjectives;
            
            this.DisplayProgressions = DisplayProgressions;
            
            this.LinkedGraphs = LinkedGraphs;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder With()
        {
            return Builder()
                .Nodes(Nodes)
                .ArtElements(ArtElements)
                .Connections(Connections)
                .DisplayObjectives(DisplayObjectives)
                .DisplayProgressions(DisplayProgressions)
                .LinkedGraphs(LinkedGraphs)
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

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder
        {
            private List<DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition> _Nodes;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition> _ArtElements;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition> _Connections;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition> _DisplayObjectives;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition> _DisplayProgressions;
            private List<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition> _LinkedGraphs;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.Nodes property.
            /// </summary>
            /// <param name="value">These represent the visual \&quot;nodes\&quot; on the map&#39;s view. These are the activities you can click on in the map.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder Nodes(List<DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition> value)
            {
                _Nodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.ArtElements property.
            /// </summary>
            /// <param name="value">Represents one-off/special UI elements that appear on the map.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder ArtElements(List<DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition> value)
            {
                _ArtElements = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.Connections property.
            /// </summary>
            /// <param name="value">Represents connections between graph nodes. However, it lacks context that we&#39;d need to make good use of it.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder Connections(List<DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition> value)
            {
                _Connections = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.DisplayObjectives property.
            /// </summary>
            /// <param name="value">Objectives can display on maps, and this is supposedly metadata for that. I have not had the time to analyze the details of what is useful within however: we could be missing important data to make this work. Expect this property to be expanded on later if possible.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder DisplayObjectives(List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition> value)
            {
                _DisplayObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.DisplayProgressions property.
            /// </summary>
            /// <param name="value">Progressions can also display on maps, but similarly to displayObjectives we appear to lack some required information and context right now. We will have to look into it later and add more data if possible.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder DisplayProgressions(List<DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition> value)
            {
                _DisplayProgressions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.LinkedGraphs property.
            /// </summary>
            /// <param name="value">Represents links between this Activity Graph and other ones.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder LinkedGraphs(List<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition> value)
            {
                _LinkedGraphs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphDefinition(
                    Nodes: _Nodes,
                    ArtElements: _ArtElements,
                    Connections: _Connections,
                    DisplayObjectives: _DisplayObjectives,
                    DisplayProgressions: _DisplayProgressions,
                    LinkedGraphs: _LinkedGraphs,
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