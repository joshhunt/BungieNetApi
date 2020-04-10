using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a canonical \&quot;Season\&quot; of Destiny: a range of a few months where the game highlights certain challenges, provides new loot, has new Clan-related rewards and celebrates various seasonal events.
    /// </summary>
    public sealed class DestinyDefinitionsSeasonsDestinySeasonDefinition:  IEquatable<DestinyDefinitionsSeasonsDestinySeasonDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// BackgroundImagePath
        /// </summary>
        public string BackgroundImagePath { get; private set; }

        /// <summary>
        /// SeasonNumber
        /// </summary>
        public int? SeasonNumber { get; private set; }

        /// <summary>
        /// StartDate
        /// </summary>
        public DateTime? StartDate { get; private set; }

        /// <summary>
        /// EndDate
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// SeasonPassHash
        /// </summary>
        public int? SeasonPassHash { get; private set; }

        /// <summary>
        /// SeasonPassProgressionHash
        /// </summary>
        public int? SeasonPassProgressionHash { get; private set; }

        /// <summary>
        /// ArtifactItemHash
        /// </summary>
        public int? ArtifactItemHash { get; private set; }

        /// <summary>
        /// SealPresentationNodeHash
        /// </summary>
        public int? SealPresentationNodeHash { get; private set; }

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
        /// Use DestinyDefinitionsSeasonsDestinySeasonDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSeasonsDestinySeasonDefinition()
        {
        }

        private DestinyDefinitionsSeasonsDestinySeasonDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string BackgroundImagePath, int? SeasonNumber, DateTime? StartDate, DateTime? EndDate, int? SeasonPassHash, int? SeasonPassProgressionHash, int? ArtifactItemHash, int? SealPresentationNodeHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.BackgroundImagePath = BackgroundImagePath;
            
            this.SeasonNumber = SeasonNumber;
            
            this.StartDate = StartDate;
            
            this.EndDate = EndDate;
            
            this.SeasonPassHash = SeasonPassHash;
            
            this.SeasonPassProgressionHash = SeasonPassProgressionHash;
            
            this.ArtifactItemHash = ArtifactItemHash;
            
            this.SealPresentationNodeHash = SealPresentationNodeHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSeasonsDestinySeasonDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder</returns>
        public static DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder</returns>
        public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .BackgroundImagePath(BackgroundImagePath)
                .SeasonNumber(SeasonNumber)
                .StartDate(StartDate)
                .EndDate(EndDate)
                .SeasonPassHash(SeasonPassHash)
                .SeasonPassProgressionHash(SeasonPassProgressionHash)
                .ArtifactItemHash(ArtifactItemHash)
                .SealPresentationNodeHash(SealPresentationNodeHash)
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

        public bool Equals(DestinyDefinitionsSeasonsDestinySeasonDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSeasonsDestinySeasonDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSeasonsDestinySeasonDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSeasonsDestinySeasonDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSeasonsDestinySeasonDefinition left, DestinyDefinitionsSeasonsDestinySeasonDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSeasonsDestinySeasonDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSeasonsDestinySeasonDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSeasonsDestinySeasonDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSeasonsDestinySeasonDefinition left, DestinyDefinitionsSeasonsDestinySeasonDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSeasonsDestinySeasonDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _BackgroundImagePath;
            private int? _SeasonNumber;
            private DateTime? _StartDate;
            private DateTime? _EndDate;
            private int? _SeasonPassHash;
            private int? _SeasonPassProgressionHash;
            private int? _ArtifactItemHash;
            private int? _SealPresentationNodeHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.BackgroundImagePath property.
            /// </summary>
            /// <param name="value">BackgroundImagePath</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder BackgroundImagePath(string value)
            {
                _BackgroundImagePath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.SeasonNumber property.
            /// </summary>
            /// <param name="value">SeasonNumber</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder SeasonNumber(int? value)
            {
                _SeasonNumber = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.StartDate property.
            /// </summary>
            /// <param name="value">StartDate</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder StartDate(DateTime? value)
            {
                _StartDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.EndDate property.
            /// </summary>
            /// <param name="value">EndDate</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder EndDate(DateTime? value)
            {
                _EndDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.SeasonPassHash property.
            /// </summary>
            /// <param name="value">SeasonPassHash</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder SeasonPassHash(int? value)
            {
                _SeasonPassHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.SeasonPassProgressionHash property.
            /// </summary>
            /// <param name="value">SeasonPassProgressionHash</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder SeasonPassProgressionHash(int? value)
            {
                _SeasonPassProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.ArtifactItemHash property.
            /// </summary>
            /// <param name="value">ArtifactItemHash</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder ArtifactItemHash(int? value)
            {
                _ArtifactItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.SealPresentationNodeHash property.
            /// </summary>
            /// <param name="value">SealPresentationNodeHash</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder SealPresentationNodeHash(int? value)
            {
                _SealPresentationNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsSeasonsDestinySeasonDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSeasonsDestinySeasonDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSeasonsDestinySeasonDefinition</returns>
            public DestinyDefinitionsSeasonsDestinySeasonDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSeasonsDestinySeasonDefinition(
                    DisplayProperties: _DisplayProperties,
                    BackgroundImagePath: _BackgroundImagePath,
                    SeasonNumber: _SeasonNumber,
                    StartDate: _StartDate,
                    EndDate: _EndDate,
                    SeasonPassHash: _SeasonPassHash,
                    SeasonPassProgressionHash: _SeasonPassProgressionHash,
                    ArtifactItemHash: _ArtifactItemHash,
                    SealPresentationNodeHash: _SealPresentationNodeHash,
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