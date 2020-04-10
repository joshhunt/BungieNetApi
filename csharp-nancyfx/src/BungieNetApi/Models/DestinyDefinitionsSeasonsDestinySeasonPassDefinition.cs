using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsSeasonsDestinySeasonPassDefinition
    /// </summary>
    public sealed class DestinyDefinitionsSeasonsDestinySeasonPassDefinition:  IEquatable<DestinyDefinitionsSeasonsDestinySeasonPassDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// This is the progression definition related to the progression for the initial levels 1-100 that provide item rewards for the Season pass. Further experience after you reach the limit is provided in the \&quot;Prestige\&quot; progression referred to by prestigeProgressionHash.
        /// </summary>
        public int? RewardProgressionHash { get; private set; }

        /// <summary>
        /// I know what you&#39;re thinking, but I promise we&#39;re not going to duplicate and drown you. Instead, we&#39;re giving you sweet, sweet power bonuses.   Prestige progression is further progression that you can make on the Season pass after you gain max ranks, that will ultimately increase your power/light level over the theoretical limit.
        /// </summary>
        public int? PrestigeProgressionHash { get; private set; }

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
        /// Use DestinyDefinitionsSeasonsDestinySeasonPassDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSeasonsDestinySeasonPassDefinition()
        {
        }

        private DestinyDefinitionsSeasonsDestinySeasonPassDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? RewardProgressionHash, int? PrestigeProgressionHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.RewardProgressionHash = RewardProgressionHash;
            
            this.PrestigeProgressionHash = PrestigeProgressionHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSeasonsDestinySeasonPassDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder</returns>
        public static DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder</returns>
        public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .RewardProgressionHash(RewardProgressionHash)
                .PrestigeProgressionHash(PrestigeProgressionHash)
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

        public bool Equals(DestinyDefinitionsSeasonsDestinySeasonPassDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSeasonsDestinySeasonPassDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSeasonsDestinySeasonPassDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSeasonsDestinySeasonPassDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSeasonsDestinySeasonPassDefinition left, DestinyDefinitionsSeasonsDestinySeasonPassDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSeasonsDestinySeasonPassDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSeasonsDestinySeasonPassDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSeasonsDestinySeasonPassDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSeasonsDestinySeasonPassDefinition left, DestinyDefinitionsSeasonsDestinySeasonPassDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSeasonsDestinySeasonPassDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _RewardProgressionHash;
            private int? _PrestigeProgressionHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonPassDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonPassDefinition.RewardProgressionHash property.
            /// </summary>
            /// <param name="value">This is the progression definition related to the progression for the initial levels 1-100 that provide item rewards for the Season pass. Further experience after you reach the limit is provided in the \&quot;Prestige\&quot; progression referred to by prestigeProgressionHash.</param>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder RewardProgressionHash(int? value)
            {
                _RewardProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonPassDefinition.PrestigeProgressionHash property.
            /// </summary>
            /// <param name="value">I know what you&#39;re thinking, but I promise we&#39;re not going to duplicate and drown you. Instead, we&#39;re giving you sweet, sweet power bonuses.   Prestige progression is further progression that you can make on the Season pass after you gain max ranks, that will ultimately increase your power/light level over the theoretical limit.</param>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder PrestigeProgressionHash(int? value)
            {
                _PrestigeProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonPassDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonPassDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSeasonsDestinySeasonPassDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSeasonsDestinySeasonPassDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSeasonsDestinySeasonPassDefinition</returns>
            public DestinyDefinitionsSeasonsDestinySeasonPassDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSeasonsDestinySeasonPassDefinition(
                    DisplayProperties: _DisplayProperties,
                    RewardProgressionHash: _RewardProgressionHash,
                    PrestigeProgressionHash: _PrestigeProgressionHash,
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