using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The actual activity to be redirected to when you click on the node. Note that a node can have many Activities attached to it: but only one will be active at any given time. The list of Node Activities will be traversed, and the first one found to be active will be displayed. This way, a node can layer multiple variants of an activity on top of each other. For instance, one node can control the weekly Crucible Playlist. There are multiple possible playlists, but only one is active for the week.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition>
    { 
        /// <summary>
        /// An identifier for this node activity. It is only guaranteed to be unique within the Activity Graph.
        /// </summary>
        public int? NodeActivityId { get; private set; }

        /// <summary>
        /// The activity that will be activated if the user clicks on this node. Controls all activity-related information displayed on the node if it is active (the text shown in the tooltip etc)
        /// </summary>
        public int? ActivityHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition(int? NodeActivityId, int? ActivityHash)
        {
            
            this.NodeActivityId = NodeActivityId;
            
            this.ActivityHash = ActivityHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder With()
        {
            return Builder()
                .NodeActivityId(NodeActivityId)
                .ActivityHash(ActivityHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder
        {
            private int? _NodeActivityId;
            private int? _ActivityHash;

            internal DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.NodeActivityId property.
            /// </summary>
            /// <param name="value">An identifier for this node activity. It is only guaranteed to be unique within the Activity Graph.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder NodeActivityId(int? value)
            {
                _NodeActivityId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.ActivityHash property.
            /// </summary>
            /// <param name="value">The activity that will be activated if the user clicks on this node. Controls all activity-related information displayed on the node if it is active (the text shown in the tooltip etc)</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinitionBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition(
                    NodeActivityId: _NodeActivityId,
                    ActivityHash: _ActivityHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}