using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These definitions represent Factions in the game. Factions have ended up unilaterally being related to Vendors that represent them, but that need not necessarily be the case.  A Faction is really just an entity that has a related progression for which a character can gain experience. In Destiny 1, Dead Orbit was an example of a Faction: there happens to be a Vendor that represents Dead Orbit (and indeed, DestinyVendorDefinition.factionHash defines to this relationship), but Dead Orbit could theoretically exist without the Vendor that provides rewards.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyFactionDefinition:  IEquatable<DestinyDefinitionsDestinyFactionDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The hash identifier for the DestinyProgressionDefinition that indicates the character&#39;s relationship with this faction in terms of experience and levels.
        /// </summary>
        public int? ProgressionHash { get; private set; }

        /// <summary>
        /// The faction token item hashes, and their respective progression values.
        /// </summary>
        public Dictionary<string, int?> TokenValues { get; private set; }

        /// <summary>
        /// The faction reward item hash, usually an engram.
        /// </summary>
        public int? RewardItemHash { get; private set; }

        /// <summary>
        /// The faction reward vendor hash, used for faction engram previews.
        /// </summary>
        public int? RewardVendorHash { get; private set; }

        /// <summary>
        /// List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.
        /// </summary>
        public List<DestinyDefinitionsDestinyFactionVendorDefinition> Vendors { get; private set; }

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
        /// Use DestinyDefinitionsDestinyFactionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyFactionDefinition()
        {
        }

        private DestinyDefinitionsDestinyFactionDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? ProgressionHash, Dictionary<string, int?> TokenValues, int? RewardItemHash, int? RewardVendorHash, List<DestinyDefinitionsDestinyFactionVendorDefinition> Vendors, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.ProgressionHash = ProgressionHash;
            
            this.TokenValues = TokenValues;
            
            this.RewardItemHash = RewardItemHash;
            
            this.RewardVendorHash = RewardVendorHash;
            
            this.Vendors = Vendors;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyFactionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyFactionDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyFactionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyFactionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyFactionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyFactionDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyFactionDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .ProgressionHash(ProgressionHash)
                .TokenValues(TokenValues)
                .RewardItemHash(RewardItemHash)
                .RewardVendorHash(RewardVendorHash)
                .Vendors(Vendors)
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

        public bool Equals(DestinyDefinitionsDestinyFactionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyFactionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyFactionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyFactionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyFactionDefinition left, DestinyDefinitionsDestinyFactionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyFactionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyFactionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyFactionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyFactionDefinition left, DestinyDefinitionsDestinyFactionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyFactionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyFactionDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _ProgressionHash;
            private Dictionary<string, int?> _TokenValues;
            private int? _RewardItemHash;
            private int? _RewardVendorHash;
            private List<DestinyDefinitionsDestinyFactionVendorDefinition> _Vendors;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyFactionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.ProgressionHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the DestinyProgressionDefinition that indicates the character&#39;s relationship with this faction in terms of experience and levels.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder ProgressionHash(int? value)
            {
                _ProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.TokenValues property.
            /// </summary>
            /// <param name="value">The faction token item hashes, and their respective progression values.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder TokenValues(Dictionary<string, int?> value)
            {
                _TokenValues = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.RewardItemHash property.
            /// </summary>
            /// <param name="value">The faction reward item hash, usually an engram.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder RewardItemHash(int? value)
            {
                _RewardItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.RewardVendorHash property.
            /// </summary>
            /// <param name="value">The faction reward vendor hash, used for faction engram previews.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder RewardVendorHash(int? value)
            {
                _RewardVendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.Vendors property.
            /// </summary>
            /// <param name="value">List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder Vendors(List<DestinyDefinitionsDestinyFactionVendorDefinition> value)
            {
                _Vendors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyFactionDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyFactionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyFactionDefinition</returns>
            public DestinyDefinitionsDestinyFactionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyFactionDefinition(
                    DisplayProperties: _DisplayProperties,
                    ProgressionHash: _ProgressionHash,
                    TokenValues: _TokenValues,
                    RewardItemHash: _RewardItemHash,
                    RewardVendorHash: _RewardVendorHash,
                    Vendors: _Vendors,
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