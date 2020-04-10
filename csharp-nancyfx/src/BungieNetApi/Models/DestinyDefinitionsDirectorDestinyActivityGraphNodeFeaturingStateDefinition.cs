using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Nodes can have different visual states. This object represents a single visual state (\&quot;highlight type\&quot;) that a node can be in, and the unlock expression condition to determine whether it should be set.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition>
    { 
        /// <summary>
        /// The node can be highlighted in a variety of ways - the game iterates through these and finds the first FeaturingState that is valid at the present moment given the Game, Account, and Character state, and renders the node in that state. See the ActivityGraphNodeHighlightType enum for possible values.
        /// </summary>
        public int? HighlightType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition(int? HighlightType)
        {
            
            this.HighlightType = HighlightType;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder With()
        {
            return Builder()
                .HighlightType(HighlightType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder
        {
            private int? _HighlightType;

            internal DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.HighlightType property.
            /// </summary>
            /// <param name="value">The node can be highlighted in a variety of ways - the game iterates through these and finds the first FeaturingState that is valid at the present moment given the Game, Account, and Character state, and renders the node in that state. See the ActivityGraphNodeHighlightType enum for possible values.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinitionBuilder HighlightType(int? value)
            {
                _HighlightType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition(
                    HighlightType: _HighlightType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}