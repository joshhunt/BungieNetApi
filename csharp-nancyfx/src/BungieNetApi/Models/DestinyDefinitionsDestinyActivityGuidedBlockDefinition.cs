using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Guided Game information for this activity.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityGuidedBlockDefinition:  IEquatable<DestinyDefinitionsDestinyActivityGuidedBlockDefinition>
    { 
        /// <summary>
        /// The maximum amount of people that can be in the waiting lobby.
        /// </summary>
        public int? GuidedMaxLobbySize { get; private set; }

        /// <summary>
        /// The minimum amount of people that can be in the waiting lobby.
        /// </summary>
        public int? GuidedMinLobbySize { get; private set; }

        /// <summary>
        /// If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.
        /// </summary>
        public int? GuidedDisbandCount { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityGuidedBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityGuidedBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityGuidedBlockDefinition(int? GuidedMaxLobbySize, int? GuidedMinLobbySize, int? GuidedDisbandCount)
        {
            
            this.GuidedMaxLobbySize = GuidedMaxLobbySize;
            
            this.GuidedMinLobbySize = GuidedMinLobbySize;
            
            this.GuidedDisbandCount = GuidedDisbandCount;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityGuidedBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder With()
        {
            return Builder()
                .GuidedMaxLobbySize(GuidedMaxLobbySize)
                .GuidedMinLobbySize(GuidedMinLobbySize)
                .GuidedDisbandCount(GuidedDisbandCount);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityGuidedBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityGuidedBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityGuidedBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityGuidedBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityGuidedBlockDefinition left, DestinyDefinitionsDestinyActivityGuidedBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityGuidedBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityGuidedBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityGuidedBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityGuidedBlockDefinition left, DestinyDefinitionsDestinyActivityGuidedBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityGuidedBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder
        {
            private int? _GuidedMaxLobbySize;
            private int? _GuidedMinLobbySize;
            private int? _GuidedDisbandCount;

            internal DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityGuidedBlockDefinition.GuidedMaxLobbySize property.
            /// </summary>
            /// <param name="value">The maximum amount of people that can be in the waiting lobby.</param>
            public DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder GuidedMaxLobbySize(int? value)
            {
                _GuidedMaxLobbySize = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityGuidedBlockDefinition.GuidedMinLobbySize property.
            /// </summary>
            /// <param name="value">The minimum amount of people that can be in the waiting lobby.</param>
            public DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder GuidedMinLobbySize(int? value)
            {
                _GuidedMinLobbySize = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityGuidedBlockDefinition.GuidedDisbandCount property.
            /// </summary>
            /// <param name="value">If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.</param>
            public DestinyDefinitionsDestinyActivityGuidedBlockDefinitionBuilder GuidedDisbandCount(int? value)
            {
                _GuidedDisbandCount = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityGuidedBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityGuidedBlockDefinition</returns>
            public DestinyDefinitionsDestinyActivityGuidedBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityGuidedBlockDefinition(
                    GuidedMaxLobbySize: _GuidedMaxLobbySize,
                    GuidedMinLobbySize: _GuidedMinLobbySize,
                    GuidedDisbandCount: _GuidedDisbandCount
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}