using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If the activity is a playlist, this is the definition for a specific entry in the playlist: a single possible combination of Activity and Activity Mode that can be chosen.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityPlaylistItemDefinition:  IEquatable<DestinyDefinitionsDestinyActivityPlaylistItemDefinition>
    { 
        /// <summary>
        /// The hash identifier of the Activity that can be played. Use it to look up the DestinyActivityDefinition.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// If this playlist entry had an activity mode directly defined on it, this will be the hash of that mode.
        /// </summary>
        public int? DirectActivityModeHash { get; private set; }

        /// <summary>
        /// If the playlist entry had an activity mode directly defined on it, this will be the enum value of that mode.
        /// </summary>
        public DirectActivityModeTypeEnum? DirectActivityModeType { get; private set; }

        /// <summary>
        /// The hash identifiers for Activity Modes relevant to this entry.
        /// </summary>
        public List<int?> ActivityModeHashes { get; private set; }

        /// <summary>
        /// The activity modes - if any - in enum form. Because we can&#39;t seem to escape the enums.
        /// </summary>
        public List<int?> ActivityModeTypes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityPlaylistItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityPlaylistItemDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityPlaylistItemDefinition(int? ActivityHash, int? DirectActivityModeHash, DirectActivityModeTypeEnum? DirectActivityModeType, List<int?> ActivityModeHashes, List<int?> ActivityModeTypes)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.DirectActivityModeHash = DirectActivityModeHash;
            
            this.DirectActivityModeType = DirectActivityModeType;
            
            this.ActivityModeHashes = ActivityModeHashes;
            
            this.ActivityModeTypes = ActivityModeTypes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityPlaylistItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .DirectActivityModeHash(DirectActivityModeHash)
                .DirectActivityModeType(DirectActivityModeType)
                .ActivityModeHashes(ActivityModeHashes)
                .ActivityModeTypes(ActivityModeTypes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityPlaylistItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityPlaylistItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityPlaylistItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityPlaylistItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityPlaylistItemDefinition left, DestinyDefinitionsDestinyActivityPlaylistItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityPlaylistItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityPlaylistItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityPlaylistItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityPlaylistItemDefinition left, DestinyDefinitionsDestinyActivityPlaylistItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityPlaylistItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder
        {
            private int? _ActivityHash;
            private int? _DirectActivityModeHash;
            private DirectActivityModeTypeEnum? _DirectActivityModeType;
            private List<int?> _ActivityModeHashes;
            private List<int?> _ActivityModeTypes;

            internal DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityPlaylistItemDefinition.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Activity that can be played. Use it to look up the DestinyActivityDefinition.</param>
            public DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityPlaylistItemDefinition.DirectActivityModeHash property.
            /// </summary>
            /// <param name="value">If this playlist entry had an activity mode directly defined on it, this will be the hash of that mode.</param>
            public DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder DirectActivityModeHash(int? value)
            {
                _DirectActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityPlaylistItemDefinition.DirectActivityModeType property.
            /// </summary>
            /// <param name="value">If the playlist entry had an activity mode directly defined on it, this will be the enum value of that mode.</param>
            public DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder DirectActivityModeType(DirectActivityModeTypeEnum? value)
            {
                _DirectActivityModeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityPlaylistItemDefinition.ActivityModeHashes property.
            /// </summary>
            /// <param name="value">The hash identifiers for Activity Modes relevant to this entry.</param>
            public DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder ActivityModeHashes(List<int?> value)
            {
                _ActivityModeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityPlaylistItemDefinition.ActivityModeTypes property.
            /// </summary>
            /// <param name="value">The activity modes - if any - in enum form. Because we can&#39;t seem to escape the enums.</param>
            public DestinyDefinitionsDestinyActivityPlaylistItemDefinitionBuilder ActivityModeTypes(List<int?> value)
            {
                _ActivityModeTypes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityPlaylistItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityPlaylistItemDefinition</returns>
            public DestinyDefinitionsDestinyActivityPlaylistItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityPlaylistItemDefinition(
                    ActivityHash: _ActivityHash,
                    DirectActivityModeHash: _DirectActivityModeHash,
                    DirectActivityModeType: _DirectActivityModeType,
                    ActivityModeHashes: _ActivityModeHashes,
                    ActivityModeTypes: _ActivityModeTypes
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum DirectActivityModeTypeEnum { _0, _2, _3, _4, _5, _6, _7, _9, _10, _11, _12, _13, _15, _16, _17, _18, _19, _20, _21, _22, _24, _25, _26, _27, _28, _29, _30, _31, _32, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84 };
    }
}